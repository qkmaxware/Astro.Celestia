using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_76() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89267"},
        {"Smithsonian Astrophysical Observation", "SAO 103492"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.24011303),
        dec: Angle.Degrees(+17.04400115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206830"},
        {"Hipparcos Number", "HIP 107331"},
        {"Geneva Identification System", "GEN# +1.00206830"},
        {"Smithsonian Astrophysical Observation", "SAO 107362"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.09037018),
        dec: Angle.Degrees(+17.04529465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49204"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.64251372),
        dec: Angle.Degrees(+17.04642360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71030"},
        {"Hipparcos Number", "HIP 41319"},
        {"Geneva Identification System", "GEN# +1.00071030"},
        {"Renson", "Renson 19630"},
        {"Smithsonian Astrophysical Observation", "SAO 97806"},
        {"Wilson Evans Batten Catalogue", "WEB 7994"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.45830668),
        dec: Angle.Degrees(+17.04663770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79043",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9933 A"},
        {"Henry Draper", "HD 145001"},
        {"Hipparcos Number", "HIP 79043"},
        {"Fundamental Katalog 5th Edition", "FK5 1421"},
        {"Geneva Identification System", "GEN# +1.00145001"},
        {"Smithsonian Astrophysical Observation", "SAO 101951"},
        {"Wilson Evans Batten Catalogue", "WEB 13364"},
    },
    visualMagnitude: 5.00,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.01894370),
        dec: Angle.Degrees(+17.04699349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79045",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9933 B"},
        {"Henry Draper", "HD 145000"},
        {"Hipparcos Number", "HIP 79045"},
        {"Geneva Identification System", "GEN# +1.00145000"},
        {"Smithsonian Astrophysical Observation", "SAO 101952"},
        {"Wilson Evans Batten Catalogue", "WEB 13363"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.02070728),
        dec: Angle.Degrees(+17.05445306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59181",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59181"},
    },
    visualMagnitude: 12.26,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.04867663),
        dec: Angle.Degrees(+17.05473261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217202"},
        {"Hipparcos Number", "HIP 113476"},
        {"Geneva Identification System", "GEN# +1.00217202"},
        {"Smithsonian Astrophysical Observation", "SAO 108306"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.71347447),
        dec: Angle.Degrees(+17.05547976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117366",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17009 A"},
        {"Henry Draper", "HD 223249"},
        {"Hipparcos Number", "HIP 117366"},
        {"Smithsonian Astrophysical Observation", "SAO 108841"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.96577149),
        dec: Angle.Degrees(+17.05598660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79609"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.67745517),
        dec: Angle.Degrees(+17.05726579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149632"},
        {"Hipparcos Number", "HIP 81231"},
        {"Fundamental Katalog 5th Edition", "FK5 3313"},
        {"Geneva Identification System", "GEN# +1.00149632"},
        {"Smithsonian Astrophysical Observation", "SAO 102259"},
        {"Wilson Evans Batten Catalogue", "WEB 13729"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.85955560),
        dec: Angle.Degrees(+17.05734541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7930"},
        {"Geneva Identification System", "GEN# +0.01600188"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.48778355),
        dec: Angle.Degrees(+17.05811015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36408"},
        {"Hipparcos Number", "HIP 25950"},
        {"Celescope Catalog", "CEL 763"},
        {"Geneva Identification System", "GEN# +1.00036408"},
        {"Wilson Evans Batten Catalogue", "WEB 5047"},
    },
    visualMagnitude: 5.50,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.05893591),
        dec: Angle.Degrees(+17.05815445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127477"},
        {"Hipparcos Number", "HIP 70997"},
        {"Smithsonian Astrophysical Observation", "SAO 101062"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.80827238),
        dec: Angle.Degrees(+17.05964120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73346"},
        {"Hipparcos Number", "HIP 42382"},
        {"Geneva Identification System", "GEN# +1.00073346"},
        {"Smithsonian Astrophysical Observation", "SAO 97990"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.62037754),
        dec: Angle.Degrees(+17.05997469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56113"},
        {"Smithsonian Astrophysical Observation", "SAO 99635"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.54030511),
        dec: Angle.Degrees(+17.06003692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104581"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.77150850),
        dec: Angle.Degrees(+17.06140586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 185.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222189"},
        {"Hipparcos Number", "HIP 116644"},
        {"Smithsonian Astrophysical Observation", "SAO 108737"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.57172975),
        dec: Angle.Degrees(+17.06331064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178235"},
        {"Hipparcos Number", "HIP 93890"},
        {"Smithsonian Astrophysical Observation", "SAO 104493"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.78582311),
        dec: Angle.Degrees(+17.06544106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74794"},
        {"Geneva Identification System", "GEN# +0.01702844"},
        {"Smithsonian Astrophysical Observation", "SAO 101475"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.27571368),
        dec: Angle.Degrees(+17.06665994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11499"},
        {"Hipparcos Number", "HIP 8816"},
        {"Smithsonian Astrophysical Observation", "SAO 92679"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.33401691),
        dec: Angle.Degrees(+17.06685119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177305"},
        {"Hipparcos Number", "HIP 93566"},
        {"Geneva Identification System", "GEN# +1.00177305"},
        {"Smithsonian Astrophysical Observation", "SAO 104418"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.86111975),
        dec: Angle.Degrees(+17.06750914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225240"},
        {"Hipparcos Number", "HIP 380"},
        {"Geneva Identification System", "GEN# +1.00225240"},
        {"Smithsonian Astrophysical Observation", "SAO 91691"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.17796311),
        dec: Angle.Degrees(+17.06977988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83768",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83768"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.79862461),
        dec: Angle.Degrees(+17.07075777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190406"},
        {"Hipparcos Number", "HIP 98819"},
        {"Cincinnati Publication", "Ci 20 1185"},
        {"Geneva Identification System", "GEN# +1.00190406"},
        {"Smithsonian Astrophysical Observation", "SAO 105635"},
        {"Wilson Evans Batten Catalogue", "WEB 17517"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.02693796),
        dec: Angle.Degrees(+17.07116105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -394.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -406.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117365",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17009 BC"},
        {"Henry Draper", "HD 223248"},
        {"Hipparcos Number", "HIP 117365"},
        {"Smithsonian Astrophysical Observation", "SAO 108840"},
    },
    visualMagnitude: 8.27,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.96465106),
        dec: Angle.Degrees(+17.07304565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111862"},
        {"Hipparcos Number", "HIP 62807"},
        {"Fundamental Katalog 5th Edition", "FK5 1333"},
        {"Geneva Identification System", "GEN# +1.00111862"},
        {"Smithsonian Astrophysical Observation", "SAO 100309"},
        {"Wilson Evans Batten Catalogue", "WEB 11135"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.05106622),
        dec: Angle.Degrees(+17.07395533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178771"},
        {"Hipparcos Number", "HIP 94099"},
        {"Smithsonian Astrophysical Observation", "SAO 104537"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.32706921),
        dec: Angle.Degrees(+17.07410024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61061"},
        {"Hipparcos Number", "HIP 37151"},
        {"Smithsonian Astrophysical Observation", "SAO 97098"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.52370290),
        dec: Angle.Degrees(+17.07563256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195480"},
        {"Hipparcos Number", "HIP 101219"},
        {"Smithsonian Astrophysical Observation", "SAO 106192"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.75950652),
        dec: Angle.Degrees(+17.07613355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6437"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.67092719),
        dec: Angle.Degrees(+17.07621198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110833"},
        {"Smithsonian Astrophysical Observation", "SAO 107925"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.81923671),
        dec: Angle.Degrees(+17.07748372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27848"},
        {"Hipparcos Number", "HIP 20567"},
        {"Geneva Identification System", "GEN# +5.20250051"},
        {"Smithsonian Astrophysical Observation", "SAO 93913"},
        {"Wilson Evans Batten Catalogue", "WEB 3939"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.09255092),
        dec: Angle.Degrees(+17.07901927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8941"},
        {"Hipparcos Number", "HIP 6869"},
        {"Geneva Identification System", "GEN# +1.00008941"},
        {"Smithsonian Astrophysical Observation", "SAO 92453"},
        {"Wilson Evans Batten Catalogue", "WEB 1498"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.10121023),
        dec: Angle.Degrees(+17.07934224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11349"},
        {"Hipparcos Number", "HIP 8700"},
        {"Geneva Identification System", "GEN# +1.00011349"},
        {"Smithsonian Astrophysical Observation", "SAO 92667"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.98392413),
        dec: Angle.Degrees(+17.07965583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77230"},
        {"Hipparcos Number", "HIP 44336"},
        {"Fundamental Katalog 5th Edition", "FK5 4802"},
        {"Smithsonian Astrophysical Observation", "SAO 98302"},
        {"Wilson Evans Batten Catalogue", "WEB 8500"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.43195136),
        dec: Angle.Degrees(+17.08109379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83965"},
        {"Hipparcos Number", "HIP 47598"},
        {"Smithsonian Astrophysical Observation", "SAO 98722"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.57854722),
        dec: Angle.Degrees(+17.08210897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199647"},
        {"Hipparcos Number", "HIP 103496"},
        {"Smithsonian Astrophysical Observation", "SAO 106708"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.52736076),
        dec: Angle.Degrees(+17.08353309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12898"},
        {"Hipparcos Number", "HIP 9839"},
        {"Smithsonian Astrophysical Observation", "SAO 92796"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.64888889),
        dec: Angle.Degrees(+17.08427340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155980"},
        {"Hipparcos Number", "HIP 84321"},
        {"Smithsonian Astrophysical Observation", "SAO 102676"},
    },
    visualMagnitude: 8.08,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.57380681),
        dec: Angle.Degrees(+17.08462268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72287"},
    },
    visualMagnitude: 12.00,
    bvColour: 2.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.75062081),
        dec: Angle.Degrees(+17.08608043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -540.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59686"},
        {"Hipparcos Number", "HIP 36616"},
        {"Fundamental Katalog 5th Edition", "FK5 2585"},
        {"Geneva Identification System", "GEN# +1.00059686"},
        {"Smithsonian Astrophysical Observation", "SAO 96985"},
        {"Wilson Evans Batten Catalogue", "WEB 7276"},
    },
    visualMagnitude: 5.45,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.95154548),
        dec: Angle.Degrees(+17.08622915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55357"},
        {"Smithsonian Astrophysical Observation", "SAO 99561"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.03618718),
        dec: Angle.Degrees(+17.08625901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117251",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16988 AB"},
        {"Henry Draper", "HD 223095"},
        {"Hipparcos Number", "HIP 117251"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.63073037),
        dec: Angle.Degrees(+17.08696765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197420"},
        {"Hipparcos Number", "HIP 102246"},
        {"Smithsonian Astrophysical Observation", "SAO 106422"},
        {"Wilson Evans Batten Catalogue", "WEB 18501"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.77032839),
        dec: Angle.Degrees(+17.08814130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109742"},
        {"Hipparcos Number", "HIP 61571"},
        {"Fundamental Katalog 5th Edition", "FK5 3007"},
        {"Geneva Identification System", "GEN# +1.00109742"},
        {"Smithsonian Astrophysical Observation", "SAO 100176"},
        {"Wilson Evans Batten Catalogue", "WEB 10954"},
    },
    visualMagnitude: 5.70,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.24314199),
        dec: Angle.Degrees(+17.08957856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86645"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.55762324),
        dec: Angle.Degrees(+17.08979096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176393"},
        {"Hipparcos Number", "HIP 93230"},
        {"Geneva Identification System", "GEN# +1.00176393"},
        {"Smithsonian Astrophysical Observation", "SAO 104316"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.85918939),
        dec: Angle.Degrees(+17.09684883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199480"},
        {"Hipparcos Number", "HIP 103405"},
        {"Smithsonian Astrophysical Observation", "SAO 106689"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.25576433),
        dec: Angle.Degrees(+17.09746489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82948"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.26068353),
        dec: Angle.Degrees(+17.09776734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9081"},
        {"Hipparcos Number", "HIP 6969"},
        {"Geneva Identification System", "GEN# +1.00009081"},
        {"Smithsonian Astrophysical Observation", "SAO 92461"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.42608190),
        dec: Angle.Degrees(+17.09897824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214568"},
        {"Hipparcos Number", "HIP 111823"},
        {"Geneva Identification System", "GEN# +1.00214568"},
        {"Smithsonian Astrophysical Observation", "SAO 108065"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.74091883),
        dec: Angle.Degrees(+17.09992289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42921"},
        {"Hipparcos Number", "HIP 29591"},
        {"Smithsonian Astrophysical Observation", "SAO 95414"},
        {"Wilson Evans Batten Catalogue", "WEB 5823"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.54521030),
        dec: Angle.Degrees(+17.10049858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78719"},
        {"Smithsonian Astrophysical Observation", "SAO 101903"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.04970040),
        dec: Angle.Degrees(+17.10061241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149631"},
        {"Hipparcos Number", "HIP 81230"},
        {"Geneva Identification System", "GEN# +1.00149631"},
        {"Smithsonian Astrophysical Observation", "SAO 102258"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.85891234),
        dec: Angle.Degrees(+17.10076939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101195"},
        {"Hipparcos Number", "HIP 56821"},
        {"Geneva Identification System", "GEN# +1.00101195"},
        {"Smithsonian Astrophysical Observation", "SAO 99711"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.71713134),
        dec: Angle.Degrees(+17.10173624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102242"},
        {"Smithsonian Astrophysical Observation", "SAO 106421"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.76463591),
        dec: Angle.Degrees(+17.10278584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164448"},
        {"Hipparcos Number", "HIP 88181"},
        {"Smithsonian Astrophysical Observation", "SAO 103292"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.13103959),
        dec: Angle.Degrees(+17.10322849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132031"},
        {"Hipparcos Number", "HIP 73106"},
        {"Geneva Identification System", "GEN# +1.00132031"},
        {"Smithsonian Astrophysical Observation", "SAO 101295"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.12481741),
        dec: Angle.Degrees(+17.10333620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165399"},
        {"Hipparcos Number", "HIP 88578"},
        {"Smithsonian Astrophysical Observation", "SAO 103364"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.29063407),
        dec: Angle.Degrees(+17.10423869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34521"},
        {"Hipparcos Number", "HIP 24784"},
        {"Geneva Identification System", "GEN# +1.00034521"},
        {"Smithsonian Astrophysical Observation", "SAO 94454"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.69699405),
        dec: Angle.Degrees(+17.10486242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94384"},
        {"Hipparcos Number", "HIP 53291"},
        {"Smithsonian Astrophysical Observation", "SAO 99348"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.48709469),
        dec: Angle.Degrees(+17.10656273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201282"},
        {"Hipparcos Number", "HIP 104333"},
        {"Geneva Identification System", "GEN# +1.00201282"},
        {"Smithsonian Astrophysical Observation", "SAO 106862"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.02212450),
        dec: Angle.Degrees(+17.10724757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123614"},
        {"Hipparcos Number", "HIP 69079"},
        {"Geneva Identification System", "GEN# +1.00123614"},
        {"Smithsonian Astrophysical Observation", "SAO 100864"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.09648405),
        dec: Angle.Degrees(+17.10795894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111892"},
        {"Hipparcos Number", "HIP 62819"},
        {"Geneva Identification System", "GEN# +1.00111892"},
        {"Smithsonian Astrophysical Observation", "SAO 100311"},
        {"Wilson Evans Batten Catalogue", "WEB 11137"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.09515160),
        dec: Angle.Degrees(+17.10847753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184830"},
        {"Hipparcos Number", "HIP 96377"},
        {"Geneva Identification System", "GEN# +1.00184830"},
        {"Smithsonian Astrophysical Observation", "SAO 105019"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.92353469),
        dec: Angle.Degrees(+17.10858559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108246"},
        {"Smithsonian Astrophysical Observation", "SAO 107512"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.93071272),
        dec: Angle.Degrees(+17.10900127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70298",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70298"},
        {"Smithsonian Astrophysical Observation", "SAO 101000"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.75501360),
        dec: Angle.Degrees(+17.10923895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77985"},
        {"Hipparcos Number", "HIP 44674"},
        {"Geneva Identification System", "GEN# +1.00077985"},
        {"Smithsonian Astrophysical Observation", "SAO 98362"},
        {"Wilson Evans Batten Catalogue", "WEB 8546"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.56495393),
        dec: Angle.Degrees(+17.11203055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244499"},
        {"Hipparcos Number", "HIP 25890"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.90234152),
        dec: Angle.Degrees(+17.11488202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98528"},
        {"Hipparcos Number", "HIP 55359"},
        {"Smithsonian Astrophysical Observation", "SAO 99562"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.03920339),
        dec: Angle.Degrees(+17.11494617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24984"},
        {"Hipparcos Number", "HIP 18595"},
        {"Smithsonian Astrophysical Observation", "SAO 93701"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.68344244),
        dec: Angle.Degrees(+17.11916632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 354088"},
        {"Hipparcos Number", "HIP 97983"},
        {"Geneva Identification System", "GEN# +1.00354088"},
        {"Smithsonian Astrophysical Observation", "SAO 105410"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.69874417),
        dec: Angle.Degrees(+17.11932884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89812"},
        {"Hipparcos Number", "HIP 50793"},
        {"Smithsonian Astrophysical Observation", "SAO 99085"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.56606132),
        dec: Angle.Degrees(+17.11974507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49013"},
        {"Hipparcos Number", "HIP 32514"},
        {"Smithsonian Astrophysical Observation", "SAO 96102"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.78150491),
        dec: Angle.Degrees(+17.11996978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190338"},
        {"Hipparcos Number", "HIP 98801"},
        {"Smithsonian Astrophysical Observation", "SAO 105629"},
        {"Wilson Evans Batten Catalogue", "WEB 17512"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.99739987),
        dec: Angle.Degrees(+17.12294327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113095"},
        {"Hipparcos Number", "HIP 63533"},
        {"Geneva Identification System", "GEN# +1.00113095"},
        {"Smithsonian Astrophysical Observation", "SAO 100374"},
        {"Wilson Evans Batten Catalogue", "WEB 11243"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.29008399),
        dec: Angle.Degrees(+17.12320260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77011"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.86016990),
        dec: Angle.Degrees(+17.12421731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62068"},
        {"Geneva Identification System", "GEN# +0.01702527"},
        {"Smithsonian Astrophysical Observation", "SAO 100223"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.81263716),
        dec: Angle.Degrees(+17.12447164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156614"},
        {"Hipparcos Number", "HIP 84623"},
        {"Smithsonian Astrophysical Observation", "SAO 102722"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.49320841),
        dec: Angle.Degrees(+17.12462816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92731"},
        {"Hipparcos Number", "HIP 52408"},
        {"Smithsonian Astrophysical Observation", "SAO 99261"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.69808062),
        dec: Angle.Degrees(+17.12468588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32462"},
        {"Hipparcos Number", "HIP 23574"},
        {"Geneva Identification System", "GEN# +5.20250150"},
        {"Smithsonian Astrophysical Observation", "SAO 94288"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.02234554),
        dec: Angle.Degrees(+17.12500026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208932"},
        {"Hipparcos Number", "HIP 108549"},
        {"Smithsonian Astrophysical Observation", "SAO 107564"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.84028739),
        dec: Angle.Degrees(+17.12642212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8724"},
        {"Hipparcos Number", "HIP 6710"},
        {"Geneva Identification System", "GEN# +1.00008724"},
        {"Smithsonian Astrophysical Observation", "SAO 92437"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.57317658),
        dec: Angle.Degrees(+17.12660839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80510"},
        {"Hipparcos Number", "HIP 45827"},
        {"Geneva Identification System", "GEN# +1.00080510"},
        {"Smithsonian Astrophysical Observation", "SAO 98511"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.15917874),
        dec: Angle.Degrees(+17.12736693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69364"},
        {"Smithsonian Astrophysical Observation", "SAO 100905"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.98538622),
        dec: Angle.Degrees(+17.12999161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46896"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.35754802),
        dec: Angle.Degrees(+17.13090690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117711"},
        {"Hipparcos Number", "HIP 65995"},
        {"Fundamental Katalog 5th Edition", "FK5 5192"},
        {"Geneva Identification System", "GEN# +1.00117711"},
        {"Smithsonian Astrophysical Observation", "SAO 100607"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.96012657),
        dec: Angle.Degrees(+17.13130267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213102"},
        {"Hipparcos Number", "HIP 110957"},
        {"Smithsonian Astrophysical Observation", "SAO 107947"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.20341356),
        dec: Angle.Degrees(+17.13217323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19957"},
        {"Hipparcos Number", "HIP 14971"},
        {"Smithsonian Astrophysical Observation", "SAO 93338"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.25013767),
        dec: Angle.Degrees(+17.13225089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58205"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.06152949),
        dec: Angle.Degrees(+17.13259010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151701"},
        {"Hipparcos Number", "HIP 82253"},
        {"Smithsonian Astrophysical Observation", "SAO 102396"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.10079645),
        dec: Angle.Degrees(+17.13319498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90709"},
        {"Hipparcos Number", "HIP 51299"},
        {"Geneva Identification System", "GEN# +1.00090709"},
        {"Smithsonian Astrophysical Observation", "SAO 99148"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.18122428),
        dec: Angle.Degrees(+17.13347939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106891"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.74594376),
        dec: Angle.Degrees(+17.13350228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42764"},
        {"Smithsonian Astrophysical Observation", "SAO 98061"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.71836785),
        dec: Angle.Degrees(+17.13379791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138803"},
        {"Hipparcos Number", "HIP 76198"},
        {"Geneva Identification System", "GEN# +1.00138803"},
        {"Smithsonian Astrophysical Observation", "SAO 101618"},
        {"Wilson Evans Batten Catalogue", "WEB 12941"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.46973117),
        dec: Angle.Degrees(+17.13747753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245001"},
        {"Hipparcos Number", "HIP 26157"},
        {"Smithsonian Astrophysical Observation", "SAO 94661"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.64667611),
        dec: Angle.Degrees(+17.14054397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99004"},
        {"Hipparcos Number", "HIP 55614"},
        {"Smithsonian Astrophysical Observation", "SAO 99585"},
        {"Wilson Evans Batten Catalogue", "WEB 9995"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.90885778),
        dec: Angle.Degrees(+17.14210842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66883"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.59992453),
        dec: Angle.Degrees(+17.14261474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15961"},
        {"Geneva Identification System", "GEN# +0.01600440"},
        {"Smithsonian Astrophysical Observation", "SAO 93428"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.37846707),
        dec: Angle.Degrees(+17.14277510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76508"},
        {"Hipparcos Number", "HIP 43957"},
        {"Geneva Identification System", "GEN# +1.00076508"},
        {"Smithsonian Astrophysical Observation", "SAO 98245"},
        {"Wilson Evans Batten Catalogue", "WEB 8450"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.28460280),
        dec: Angle.Degrees(+17.14383105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71156"},
        {"Smithsonian Astrophysical Observation", "SAO 101075"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.30022722),
        dec: Angle.Degrees(+17.14483211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189089"},
        {"Hipparcos Number", "HIP 98230"},
        {"Geneva Identification System", "GEN# +1.00189089"},
        {"Smithsonian Astrophysical Observation", "SAO 105470"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.43358517),
        dec: Angle.Degrees(+17.14593752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52926",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7935 AB"},
        {"Henry Draper", "HD 93717"},
        {"Hipparcos Number", "HIP 52926"},
        {"Smithsonian Astrophysical Observation", "SAO 99308"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.36171841),
        dec: Angle.Degrees(+17.14645543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107917"},
        {"Smithsonian Astrophysical Observation", "SAO 107454"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.95924293),
        dec: Angle.Degrees(+17.14669856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101675"},
        {"Smithsonian Astrophysical Observation", "SAO 106296"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.14670337),
        dec: Angle.Degrees(+17.14797341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6230"},
        {"Hipparcos Number", "HIP 4946"},
        {"Smithsonian Astrophysical Observation", "SAO 92222"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.86252131),
        dec: Angle.Degrees(+17.15041182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9236"},
        {"Hipparcos Number", "HIP 7081"},
        {"Geneva Identification System", "GEN# +1.00009236"},
        {"Smithsonian Astrophysical Observation", "SAO 92478"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.80819219),
        dec: Angle.Degrees(+17.15214350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213873"},
        {"Hipparcos Number", "HIP 111410"},
        {"Smithsonian Astrophysical Observation", "SAO 108005"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.57486211),
        dec: Angle.Degrees(+17.15349572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255925"},
        {"Hipparcos Number", "HIP 30293"},
        {"Smithsonian Astrophysical Observation", "SAO 95591"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.58163791),
        dec: Angle.Degrees(+17.15363125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31539"},
        {"Hipparcos Number", "HIP 23043"},
        {"Geneva Identification System", "GEN# +1.00031539"},
        {"Smithsonian Astrophysical Observation", "SAO 94227"},
        {"Wilson Evans Batten Catalogue", "WEB 4473"},
    },
    visualMagnitude: 5.51,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.34311423),
        dec: Angle.Degrees(+17.15370680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187972"},
        {"Hipparcos Number", "HIP 97790"},
        {"Smithsonian Astrophysical Observation", "SAO 105359"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.07324539),
        dec: Angle.Degrees(+17.15411003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86401"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.82406261),
        dec: Angle.Degrees(+17.15664109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102092"},
        {"Hipparcos Number", "HIP 57310"},
        {"Geneva Identification System", "GEN# +1.00102092"},
        {"Smithsonian Astrophysical Observation", "SAO 99771"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.26633144),
        dec: Angle.Degrees(+17.16001821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285471"},
        {"Hipparcos Number", "HIP 19401"},
        {"Smithsonian Astrophysical Observation", "SAO 93789"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.34359328),
        dec: Angle.Degrees(+17.16218636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 351680"},
        {"Hipparcos Number", "HIP 99446"},
        {"Smithsonian Astrophysical Observation", "SAO 105791"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.76491679),
        dec: Angle.Degrees(+17.16502602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164481"},
        {"Hipparcos Number", "HIP 88199"},
        {"Smithsonian Astrophysical Observation", "SAO 103295"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.17627027),
        dec: Angle.Degrees(+17.16669152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21457"},
        {"Hipparcos Number", "HIP 16152"},
        {"Smithsonian Astrophysical Observation", "SAO 93443"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.03802725),
        dec: Angle.Degrees(+17.16760046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85747"},
        {"Hipparcos Number", "HIP 48560"},
        {"Geneva Identification System", "GEN# +1.00085747"},
        {"Smithsonian Astrophysical Observation", "SAO 98836"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.56921164),
        dec: Angle.Degrees(+17.16919793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72580",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72580"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.62314408),
        dec: Angle.Degrees(+17.17540579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67151"},
        {"Hipparcos Number", "HIP 39737"},
        {"Smithsonian Astrophysical Observation", "SAO 97568"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.82910104),
        dec: Angle.Degrees(+17.17875469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143515"},
        {"Hipparcos Number", "HIP 78391"},
        {"Geneva Identification System", "GEN# +1.00143515"},
        {"Smithsonian Astrophysical Observation", "SAO 101866"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.06159219),
        dec: Angle.Degrees(+17.17931009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43335"},
        {"Hipparcos Number", "HIP 29798"},
        {"Geneva Identification System", "GEN# +1.00043335"},
        {"Smithsonian Astrophysical Observation", "SAO 95473"},
        {"Wilson Evans Batten Catalogue", "WEB 5886"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.09913445),
        dec: Angle.Degrees(+17.18163062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70843"},
        {"Hipparcos Number", "HIP 41226"},
        {"Geneva Identification System", "GEN# +1.00070843"},
        {"Smithsonian Astrophysical Observation", "SAO 97797"},
        {"Wilson Evans Batten Catalogue", "WEB 7978"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.18914466),
        dec: Angle.Degrees(+17.18205874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112707"},
        {"Hipparcos Number", "HIP 63326"},
        {"Geneva Identification System", "GEN# +1.00112707"},
        {"Smithsonian Astrophysical Observation", "SAO 100354"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.65199314),
        dec: Angle.Degrees(+17.18296281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42069"},
        {"Hipparcos Number", "HIP 29186"},
        {"Geneva Identification System", "GEN# +1.00042069"},
        {"Smithsonian Astrophysical Observation", "SAO 95298"},
        {"Wilson Evans Batten Catalogue", "WEB 5722"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.35489805),
        dec: Angle.Degrees(+17.18329022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53644",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7997 AB"},
        {"Henry Draper", "HD 95037"},
        {"Hipparcos Number", "HIP 53644"},
        {"Smithsonian Astrophysical Observation", "SAO 99380"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.61804564),
        dec: Angle.Degrees(+17.18540291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84093"},
        {"Smithsonian Astrophysical Observation", "SAO 102638"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.87659822),
        dec: Angle.Degrees(+17.18556486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143003"},
        {"Hipparcos Number", "HIP 78135"},
        {"Geneva Identification System", "GEN# +1.00143003"},
        {"Smithsonian Astrophysical Observation", "SAO 101835"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.31298336),
        dec: Angle.Degrees(+17.18592274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105548"},
        {"Hipparcos Number", "HIP 59246"},
        {"Geneva Identification System", "GEN# +1.00105548"},
        {"Smithsonian Astrophysical Observation", "SAO 99962"},
        {"Wilson Evans Batten Catalogue", "WEB 10538"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.30386174),
        dec: Angle.Degrees(+17.18616419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50445",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7716 AB"},
        {"Henry Draper", "HD 89240"},
        {"Hipparcos Number", "HIP 50445"},
        {"Smithsonian Astrophysical Observation", "SAO 99042"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.49966905),
        dec: Angle.Degrees(+17.18664151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11729"},
        {"Hipparcos Number", "HIP 8968"},
        {"Smithsonian Astrophysical Observation", "SAO 92697"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.87988774),
        dec: Angle.Degrees(+17.18938167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109788",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15763 A"},
        {"Henry Draper", "HD 211076"},
        {"Hipparcos Number", "HIP 109788"},
        {"Fundamental Katalog 5th Edition", "FK5 5963"},
        {"Geneva Identification System", "GEN# +1.00211076J"},
        {"Smithsonian Astrophysical Observation", "SAO 107756"},
        {"Wilson Evans Batten Catalogue", "WEB 19721"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.57688102),
        dec: Angle.Degrees(+17.18956616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154276"},
        {"Hipparcos Number", "HIP 83489"},
        {"Geneva Identification System", "GEN# +1.00154276"},
        {"Smithsonian Astrophysical Observation", "SAO 102567"},
        {"Wilson Evans Batten Catalogue", "WEB 14112"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.95535619),
        dec: Angle.Degrees(+17.18959570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -216.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207223"},
        {"Hipparcos Number", "HIP 107558"},
        {"Geneva Identification System", "GEN# +1.00207223"},
        {"Smithsonian Astrophysical Observation", "SAO 107395"},
        {"Wilson Evans Batten Catalogue", "WEB 19414"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.76956790),
        dec: Angle.Degrees(+17.19407481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109790",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15763 B"},
        {"Hipparcos Number", "HIP 109790"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.57910472),
        dec: Angle.Degrees(+17.19499629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45065"},
        {"Hipparcos Number", "HIP 30612"},
        {"Smithsonian Astrophysical Observation", "SAO 95673"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.49937166),
        dec: Angle.Degrees(+17.19581604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37650"},
        {"Hipparcos Number", "HIP 26734"},
        {"Celescope Catalog", "CEL 915"},
        {"Smithsonian Astrophysical Observation", "SAO 94752"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.20122358),
        dec: Angle.Degrees(+17.19602973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8321"},
        {"Hipparcos Number", "HIP 6439"},
        {"Geneva Identification System", "GEN# +1.00008321"},
        {"Smithsonian Astrophysical Observation", "SAO 92405"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.67975200),
        dec: Angle.Degrees(+17.19699142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46764"},
        {"Hipparcos Number", "HIP 31503"},
        {"Celescope Catalog", "CEL 1309"},
        {"Geneva Identification System", "GEN# +1.00046764"},
        {"Smithsonian Astrophysical Observation", "SAO 95881"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.96463359),
        dec: Angle.Degrees(+17.20007004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92856"},
        {"Geneva Identification System", "GEN# +8.02170002"},
    },
    visualMagnitude: 11.20,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.81680295),
        dec: Angle.Degrees(+17.20059504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96719"},
        {"Hipparcos Number", "HIP 54470"},
        {"Geneva Identification System", "GEN# +1.00096719"},
        {"Smithsonian Astrophysical Observation", "SAO 99464"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.17003114),
        dec: Angle.Degrees(+17.20113380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29051"},
        {"Hipparcos Number", "HIP 21365"},
        {"Smithsonian Astrophysical Observation", "SAO 94019"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.75988548),
        dec: Angle.Degrees(+17.20123486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30676"},
        {"Hipparcos Number", "HIP 22496"},
        {"Geneva Identification System", "GEN# +5.20250119"},
        {"Smithsonian Astrophysical Observation", "SAO 94158"},
        {"Wilson Evans Batten Catalogue", "WEB 4339"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.59944989),
        dec: Angle.Degrees(+17.20273764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9613"},
        {"Smithsonian Astrophysical Observation", "SAO 92773"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.89001774),
        dec: Angle.Degrees(+17.20313410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145122"},
        {"Hipparcos Number", "HIP 79102"},
        {"Celescope Catalog", "CEL 4414"},
        {"Geneva Identification System", "GEN# +1.00145122"},
        {"Smithsonian Astrophysical Observation", "SAO 101962"},
        {"Wilson Evans Batten Catalogue", "WEB 13372"},
    },
    visualMagnitude: 6.13,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.19434273),
        dec: Angle.Degrees(+17.20571235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149027"},
        {"Hipparcos Number", "HIP 80923"},
        {"Geneva Identification System", "GEN# +1.00149027"},
        {"Smithsonian Astrophysical Observation", "SAO 102222"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.87118881),
        dec: Angle.Degrees(+17.20733905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17334"},
        {"Hipparcos Number", "HIP 13023"},
        {"Smithsonian Astrophysical Observation", "SAO 93104"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.85463912),
        dec: Angle.Degrees(+17.20995461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66429"},
        {"Geneva Identification System", "GEN# +0.01702651"},
        {"Smithsonian Astrophysical Observation", "SAO 100636"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.28173868),
        dec: Angle.Degrees(+17.20997990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203472"},
        {"Hipparcos Number", "HIP 105493"},
        {"Geneva Identification System", "GEN# +1.00203472"},
        {"Smithsonian Astrophysical Observation", "SAO 107070"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.49629077),
        dec: Angle.Degrees(+17.21052149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82341"},
        {"Smithsonian Astrophysical Observation", "SAO 102409"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.36863848),
        dec: Angle.Degrees(+17.21061250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198515"},
        {"Hipparcos Number", "HIP 102857"},
        {"Smithsonian Astrophysical Observation", "SAO 106555"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.57321669),
        dec: Angle.Degrees(+17.21224012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33659"},
        {"Hipparcos Number", "HIP 24269"},
        {"Geneva Identification System", "GEN# +1.00033659"},
        {"Smithsonian Astrophysical Observation", "SAO 94391"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.12490373),
        dec: Angle.Degrees(+17.21330015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86927"},
        {"Geneva Identification System", "GEN# +0.01703325"},
        {"Smithsonian Astrophysical Observation", "SAO 103087"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.42825351),
        dec: Angle.Degrees(+17.21435781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218549"},
        {"Hipparcos Number", "HIP 114290"},
        {"Geneva Identification System", "GEN# +1.00218549"},
        {"Wilson Evans Batten Catalogue", "WEB 20294"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.21315353),
        dec: Angle.Degrees(+17.21560814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230414"},
        {"Hipparcos Number", "HIP 93356"},
        {"Smithsonian Astrophysical Observation", "SAO 104357"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.23550619),
        dec: Angle.Degrees(+17.21860930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51145",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7775 AB"},
        {"Henry Draper", "HD 90444"},
        {"Hipparcos Number", "HIP 51145"},
        {"Smithsonian Astrophysical Observation", "SAO 99127"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.72097782),
        dec: Angle.Degrees(+17.21958794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75520"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.42951880),
        dec: Angle.Degrees(+17.21999677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38009"},
        {"Smithsonian Astrophysical Observation", "SAO 97241"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.84937043),
        dec: Angle.Degrees(+17.22303830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13201"},
        {"Hipparcos Number", "HIP 10050"},
        {"Geneva Identification System", "GEN# +1.00013201"},
        {"Smithsonian Astrophysical Observation", "SAO 92810"},
        {"Wilson Evans Batten Catalogue", "WEB 2107"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.34594705),
        dec: Angle.Degrees(+17.22464882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90384"},
        {"Hipparcos Number", "HIP 51099"},
        {"Geneva Identification System", "GEN# +1.00090384"},
        {"Smithsonian Astrophysical Observation", "SAO 99119"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.60100982),
        dec: Angle.Degrees(+17.22471146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222773"},
        {"Hipparcos Number", "HIP 117031"},
        {"Geneva Identification System", "GEN# +1.00222773"},
        {"Smithsonian Astrophysical Observation", "SAO 108791"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.86768565),
        dec: Angle.Degrees(+17.22581853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5873"},
        {"Hipparcos Number", "HIP 4696"},
        {"Geneva Identification System", "GEN# +1.00005873"},
        {"Smithsonian Astrophysical Observation", "SAO 92195"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.08816243),
        dec: Angle.Degrees(+17.22641018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10089"},
        {"Hipparcos Number", "HIP 7683"},
        {"Smithsonian Astrophysical Observation", "SAO 92551"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.73415639),
        dec: Angle.Degrees(+17.22673362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160966"},
        {"Hipparcos Number", "HIP 86648"},
        {"Smithsonian Astrophysical Observation", "SAO 103038"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.56291919),
        dec: Angle.Degrees(+17.22835934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134130"},
        {"Hipparcos Number", "HIP 74028"},
        {"Smithsonian Astrophysical Observation", "SAO 101385"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.92271728),
        dec: Angle.Degrees(+17.22871034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83070"},
        {"Hipparcos Number", "HIP 47138"},
        {"Smithsonian Astrophysical Observation", "SAO 98666"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.08267899),
        dec: Angle.Degrees(+17.22994421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76221"},
        {"Hipparcos Number", "HIP 43811"},
        {"Geneva Identification System", "GEN# +1.00076221"},
        {"Smithsonian Astrophysical Observation", "SAO 98230"},
        {"Wilson Evans Batten Catalogue", "WEB 8425"},
    },
    visualMagnitude: 6.28,
    bvColour: 2.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.84534491),
        dec: Angle.Degrees(+17.23126020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231007"},
        {"Hipparcos Number", "HIP 94639"},
        {"Smithsonian Astrophysical Observation", "SAO 104658"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.86329276),
        dec: Angle.Degrees(+17.23299897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215733"},
        {"Hipparcos Number", "HIP 112482"},
        {"Geneva Identification System", "GEN# +1.00215733"},
        {"Smithsonian Astrophysical Observation", "SAO 108170"},
        {"Wilson Evans Batten Catalogue", "WEB 20059"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.76045583),
        dec: Angle.Degrees(+17.23309023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78463"},
        {"Hipparcos Number", "HIP 44908"},
        {"Smithsonian Astrophysical Observation", "SAO 98388"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.22662982),
        dec: Angle.Degrees(+17.23436827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90159"},
        {"Smithsonian Astrophysical Observation", "SAO 103675"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.98241268),
        dec: Angle.Degrees(+17.23504710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150555"},
        {"Hipparcos Number", "HIP 81683"},
        {"Smithsonian Astrophysical Observation", "SAO 102316"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.28805652),
        dec: Angle.Degrees(+17.23820836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35802"},
        {"Hipparcos Number", "HIP 25583"},
        {"Geneva Identification System", "GEN# +1.00035802"},
        {"Smithsonian Astrophysical Observation", "SAO 94573"},
        {"Wilson Evans Batten Catalogue", "WEB 4964"},
    },
    visualMagnitude: 5.77,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.00666898),
        dec: Angle.Degrees(+17.23924182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13752",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2230 AB"},
        {"Henry Draper", "HD 18309"},
        {"Hipparcos Number", "HIP 13752"},
        {"Smithsonian Astrophysical Observation", "SAO 93197"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.25634136),
        dec: Angle.Degrees(+17.23954102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15683",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15683"},
        {"Geneva Identification System", "GEN# +9.80006003"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.50922634),
        dec: Angle.Degrees(+17.24039500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87481"},
        {"Smithsonian Astrophysical Observation", "SAO 103166"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.11230466),
        dec: Angle.Degrees(+17.24140041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68774"},
        {"Smithsonian Astrophysical Observation", "SAO 100839"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.15311926),
        dec: Angle.Degrees(+17.24271469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34791"},
        {"Hipparcos Number", "HIP 24959"},
        {"Smithsonian Astrophysical Observation", "SAO 94476"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.18131343),
        dec: Angle.Degrees(+17.24296147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96588",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12711 A"},
        {"Henry Draper", "HD 185354"},
        {"Hipparcos Number", "HIP 96588"},
        {"Smithsonian Astrophysical Observation", "SAO 105081"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.54038418),
        dec: Angle.Degrees(+17.24322687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5369"},
        {"Cincinnati Publication", "Ci 20 82"},
        {"Wilson Evans Batten Catalogue", "WEB 1168"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.16831270),
        dec: Angle.Degrees(+17.24402032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -584.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136439"},
        {"Hipparcos Number", "HIP 75047"},
        {"Smithsonian Astrophysical Observation", "SAO 101494"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.03352900),
        dec: Angle.Degrees(+17.24547485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17962"},
        {"Geneva Identification System", "GEN# +5.20257023"},
        {"Wilson Evans Batten Catalogue", "WEB 3460"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.60370473),
        dec: Angle.Degrees(+17.24656274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139495"},
        {"Hipparcos Number", "HIP 76548"},
        {"Smithsonian Astrophysical Observation", "SAO 101660"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.50619856),
        dec: Angle.Degrees(+17.24766609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215192"},
        {"Hipparcos Number", "HIP 112187"},
        {"Geneva Identification System", "GEN# +1.00215192"},
        {"Smithsonian Astrophysical Observation", "SAO 108129"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.82622733),
        dec: Angle.Degrees(+17.25138219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67712"},
        {"Hipparcos Number", "HIP 39982"},
        {"Geneva Identification System", "GEN# +1.00067712"},
        {"Smithsonian Astrophysical Observation", "SAO 97610"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.47752617),
        dec: Angle.Degrees(+17.25160726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71924"},
        {"Smithsonian Astrophysical Observation", "SAO 101162"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.66285372),
        dec: Angle.Degrees(+17.25245209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220091"},
        {"Hipparcos Number", "HIP 115288"},
        {"Fundamental Katalog 5th Edition", "FK5 3872"},
        {"Geneva Identification System", "GEN# +1.00220091"},
        {"Smithsonian Astrophysical Observation", "SAO 108560"},
        {"Wilson Evans Batten Catalogue", "WEB 20422"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.23988003),
        dec: Angle.Degrees(+17.25258039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42277"},
        {"Smithsonian Astrophysical Observation", "SAO 97970"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.30412951),
        dec: Angle.Degrees(+17.25413046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91900"},
        {"Hipparcos Number", "HIP 51965"},
        {"Smithsonian Astrophysical Observation", "SAO 99209"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.24413616),
        dec: Angle.Degrees(+17.25535381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62308",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8660 AB"},
        {"Hipparcos Number", "HIP 62308"},
        {"Geneva Identification System", "GEN# +0.01802659J"},
        {"Smithsonian Astrophysical Observation", "SAO 100246"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.51390809),
        dec: Angle.Degrees(+17.25584378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64762",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8840 AB"},
        {"Henry Draper", "HD 115320"},
        {"Hipparcos Number", "HIP 64762"},
        {"Smithsonian Astrophysical Observation", "SAO 100486"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.08451501),
        dec: Angle.Degrees(+17.25648616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96608",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12723 A"},
        {"Henry Draper", "HD 185418"},
        {"Hipparcos Number", "HIP 96608"},
        {"Geneva Identification System", "GEN# +1.00185418"},
        {"Smithsonian Astrophysical Observation", "SAO 105087"},
        {"Wilson Evans Batten Catalogue", "WEB 16951"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.61450173),
        dec: Angle.Degrees(+17.25725269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199180"},
        {"Hipparcos Number", "HIP 103246"},
        {"Geneva Identification System", "GEN# +1.00199180"},
        {"Renson", "Renson 55460"},
        {"Smithsonian Astrophysical Observation", "SAO 106651"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.75907788),
        dec: Angle.Degrees(+17.25958647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231638"},
        {"Hipparcos Number", "HIP 95960"},
        {"Geneva Identification System", "GEN# +1.00231638"},
        {"Smithsonian Astrophysical Observation", "SAO 104923"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.70930493),
        dec: Angle.Degrees(+17.26085505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19583"},
        {"Hipparcos Number", "HIP 14682"},
        {"Geneva Identification System", "GEN# +1.00019583"},
        {"Smithsonian Astrophysical Observation", "SAO 93307"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.41901951),
        dec: Angle.Degrees(+17.26097027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42120"},
        {"Smithsonian Astrophysical Observation", "SAO 97926"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.78959919),
        dec: Angle.Degrees(+17.26289971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110909",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15967 A"},
        {"Henry Draper", "HD 213014"},
        {"Hipparcos Number", "HIP 110909"},
        {"Geneva Identification System", "GEN# +1.00213014J"},
        {"Smithsonian Astrophysical Observation", "SAO 107941"},
        {"Wilson Evans Batten Catalogue", "WEB 19858"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.04804765),
        dec: Angle.Degrees(+17.26334187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140729"},
        {"Hipparcos Number", "HIP 77111"},
        {"Geneva Identification System", "GEN# +1.00140729"},
        {"Smithsonian Astrophysical Observation", "SAO 101712"},
        {"Wilson Evans Batten Catalogue", "WEB 13076"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.17562438),
        dec: Angle.Degrees(+17.26421031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187655"},
        {"Hipparcos Number", "HIP 97626"},
        {"Smithsonian Astrophysical Observation", "SAO 105332"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.63402365),
        dec: Angle.Degrees(+17.26877397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16512"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.15298284),
        dec: Angle.Degrees(+17.26907581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35710"},
        {"Hipparcos Number", "HIP 25514"},
        {"Smithsonian Astrophysical Observation", "SAO 94559"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.84387692),
        dec: Angle.Degrees(+17.26963698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12442"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.04418132),
        dec: Angle.Degrees(+17.27019121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84274",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10403 AB"},
        {"Hipparcos Number", "HIP 84274"},
        {"Smithsonian Astrophysical Observation", "SAO 102661"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.41207607),
        dec: Angle.Degrees(+17.27417786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171144"},
        {"Hipparcos Number", "HIP 90891"},
        {"Geneva Identification System", "GEN# +1.00171144"},
        {"Smithsonian Astrophysical Observation", "SAO 103825"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.10203405),
        dec: Angle.Degrees(+17.27459218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88389"},
        {"Hipparcos Number", "HIP 49939"},
        {"Smithsonian Astrophysical Observation", "SAO 98992"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.94949563),
        dec: Angle.Degrees(+17.27532344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88395"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.75412162),
        dec: Angle.Degrees(+17.27666819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26546"},
        {"Hipparcos Number", "HIP 19641"},
        {"Geneva Identification System", "GEN# +1.00026546"},
        {"Smithsonian Astrophysical Observation", "SAO 93810"},
        {"Wilson Evans Batten Catalogue", "WEB 3751"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.13051946),
        dec: Angle.Degrees(+17.27750726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92013"},
        {"Hipparcos Number", "HIP 52026"},
        {"Geneva Identification System", "GEN# +1.00092013"},
        {"Smithsonian Astrophysical Observation", "SAO 99219"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.44221264),
        dec: Angle.Degrees(+17.27869145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2828"},
        {"Hipparcos Number", "HIP 2508"},
        {"Smithsonian Astrophysical Observation", "SAO 91946"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.95058385),
        dec: Angle.Degrees(+17.27945907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43151",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43151"},
        {"Smithsonian Astrophysical Observation", "SAO 98122"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.83810141),
        dec: Angle.Degrees(+17.28014813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177330"},
        {"Hipparcos Number", "HIP 93586"},
        {"Smithsonian Astrophysical Observation", "SAO 104420"},
        {"Wilson Evans Batten Catalogue", "WEB 16255"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.89301035),
        dec: Angle.Degrees(+17.28086232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214333"},
        {"Hipparcos Number", "HIP 111658"},
        {"Geneva Identification System", "GEN# +1.00214333"},
        {"Smithsonian Astrophysical Observation", "SAO 108045"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.29266780),
        dec: Angle.Degrees(+17.28278691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13014",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2123 AB"},
        {"Henry Draper", "HD 17333"},
        {"Hipparcos Number", "HIP 13014"},
        {"Smithsonian Astrophysical Observation", "SAO 93102"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.83447317),
        dec: Angle.Degrees(+17.28433863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40977",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6763 A"},
        {"Henry Draper", "HD 70276"},
        {"Hipparcos Number", "HIP 40977"},
        {"Smithsonian Astrophysical Observation", "SAO 97753"},
        {"Wilson Evans Batten Catalogue", "WEB 7943"},
    },
    visualMagnitude: 9.25,
    bvColour: 2.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.42878697),
        dec: Angle.Degrees(+17.28528855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60145"},
        {"Geneva Identification System", "GEN# +0.01802590"},
        {"Smithsonian Astrophysical Observation", "SAO 100047"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.01193624),
        dec: Angle.Degrees(+17.28540667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28344"},
        {"Hipparcos Number", "HIP 20899"},
        {"Geneva Identification System", "GEN# +5.20250073"},
        {"Smithsonian Astrophysical Observation", "SAO 93958"},
        {"Wilson Evans Batten Catalogue", "WEB 4014"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.20096632),
        dec: Angle.Degrees(+17.28553719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207652"},
        {"Hipparcos Number", "HIP 107788"},
        {"Geneva Identification System", "GEN# +1.00207652J"},
        {"Smithsonian Astrophysical Observation", "SAO 107425"},
        {"Wilson Evans Batten Catalogue", "WEB 19438"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.53601656),
        dec: Angle.Degrees(+17.28595705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110650"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.23659865),
        dec: Angle.Degrees(+17.28807119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -272.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8309"},
        {"Smithsonian Astrophysical Observation", "SAO 92627"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.79155970),
        dec: Angle.Degrees(+17.28818141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42209"},
        {"Smithsonian Astrophysical Observation", "SAO 97955"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.09114243),
        dec: Angle.Degrees(+17.28884376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104999"},
        {"Hipparcos Number", "HIP 58963"},
        {"Geneva Identification System", "GEN# +1.00104999"},
        {"Smithsonian Astrophysical Observation", "SAO 99936"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.35493513),
        dec: Angle.Degrees(+17.28944187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286327"},
        {"Hipparcos Number", "HIP 23504"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.80641245),
        dec: Angle.Degrees(+17.29020326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26141"},
        {"Hipparcos Number", "HIP 19358"},
        {"Smithsonian Astrophysical Observation", "SAO 93781"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.20622508),
        dec: Angle.Degrees(+17.29175464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115538"},
        {"Hipparcos Number", "HIP 64845"},
        {"Geneva Identification System", "GEN# +1.00115538"},
        {"Smithsonian Astrophysical Observation", "SAO 100498"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.38872410),
        dec: Angle.Degrees(+17.29241952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23052"},
        {"Hipparcos Number", "HIP 17336"},
        {"Fundamental Katalog 5th Edition", "FK5 4338"},
        {"Geneva Identification System", "GEN# +1.00023052"},
        {"Smithsonian Astrophysical Observation", "SAO 93561"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.65401136),
        dec: Angle.Degrees(+17.29342647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115332"},
        {"Geneva Identification System", "GEN# +9.80068008"},
    },
    visualMagnitude: 11.70,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.40740164),
        dec: Angle.Degrees(+17.29374687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -536.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1385.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255639"},
        {"Hipparcos Number", "HIP 30220"},
        {"Smithsonian Astrophysical Observation", "SAO 95574"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.36539622),
        dec: Angle.Degrees(+17.29508674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68006"},
        {"Geneva Identification System", "GEN# +0.01802802"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.90113887),
        dec: Angle.Degrees(+17.29551424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116441"},
        {"Hipparcos Number", "HIP 65334"},
        {"Geneva Identification System", "GEN# +1.00116441"},
        {"Smithsonian Astrophysical Observation", "SAO 100544"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.85841902),
        dec: Angle.Degrees(+17.29631858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25175"},
        {"Hipparcos Number", "HIP 18717"},
        {"Geneva Identification System", "GEN# +1.00025175"},
        {"Smithsonian Astrophysical Observation", "SAO 93716"},
        {"Wilson Evans Batten Catalogue", "WEB 3601"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.15369368),
        dec: Angle.Degrees(+17.29673453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285305"},
        {"Hipparcos Number", "HIP 18823"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.51274869),
        dec: Angle.Degrees(+17.29740072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88446"},
        {"Hipparcos Number", "HIP 49988"},
        {"Cincinnati Publication", "Ci 18 1224"},
        {"Geneva Identification System", "GEN# +1.00088446"},
        {"Smithsonian Astrophysical Observation", "SAO 98999"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.07988525),
        dec: Angle.Degrees(+17.29973827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115352"},
        {"Hipparcos Number", "HIP 64775"},
        {"Geneva Identification System", "GEN# +1.00115352"},
        {"Smithsonian Astrophysical Observation", "SAO 100488"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.12372883),
        dec: Angle.Degrees(+17.30025796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19865"},
        {"Hipparcos Number", "HIP 14901"},
        {"Geneva Identification System", "GEN# +1.00019865"},
        {"Smithsonian Astrophysical Observation", "SAO 93333"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.06742404),
        dec: Angle.Degrees(+17.30109990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89208"},
        {"Smithsonian Astrophysical Observation", "SAO 103477"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.07891648),
        dec: Angle.Degrees(+17.30244808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 264"},
        {"Hipparcos Number", "HIP 613"},
        {"Geneva Identification System", "GEN# +1.00000264"},
        {"Smithsonian Astrophysical Observation", "SAO 91721"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.87192965),
        dec: Angle.Degrees(+17.30273637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80465",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10057 A"},
        {"Henry Draper", "HD 148147"},
        {"Hipparcos Number", "HIP 80465"},
        {"Geneva Identification System", "GEN# +1.00148147"},
        {"Smithsonian Astrophysical Observation", "SAO 102154"},
        {"Wilson Evans Batten Catalogue", "WEB 13612"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.36215963),
        dec: Angle.Degrees(+17.30311009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65759"},
        {"Hipparcos Number", "HIP 39177"},
        {"Fundamental Katalog 5th Edition", "FK5 2618"},
        {"Geneva Identification System", "GEN# +1.00065759"},
        {"Smithsonian Astrophysical Observation", "SAO 97472"},
        {"Wilson Evans Batten Catalogue", "WEB 7681"},
    },
    visualMagnitude: 5.60,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.19714045),
        dec: Angle.Degrees(+17.30870968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206227"},
        {"Hipparcos Number", "HIP 107008"},
        {"Smithsonian Astrophysical Observation", "SAO 107315"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.08808582),
        dec: Angle.Degrees(+17.31025401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29861"},
        {"Hipparcos Number", "HIP 21938"},
        {"Fundamental Katalog 5th Edition", "FK5 4424"},
        {"Smithsonian Astrophysical Observation", "SAO 94080"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.74370205),
        dec: Angle.Degrees(+17.31114315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98547"},
        {"Hipparcos Number", "HIP 55382"},
        {"Geneva Identification System", "GEN# +1.00098547"},
        {"Smithsonian Astrophysical Observation", "SAO 99564"},
        {"Wilson Evans Batten Catalogue", "WEB 9965"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.11026357),
        dec: Angle.Degrees(+17.31130739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194688"},
        {"Hipparcos Number", "HIP 100807"},
        {"Fundamental Katalog 5th Edition", "FK5 3635"},
        {"Geneva Identification System", "GEN# +1.00194688"},
        {"Smithsonian Astrophysical Observation", "SAO 106101"},
        {"Wilson Evans Batten Catalogue", "WEB 18215"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.59646487),
        dec: Angle.Degrees(+17.31557189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14083"},
        {"Hipparcos Number", "HIP 10648"},
        {"Smithsonian Astrophysical Observation", "SAO 92867"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.26550754),
        dec: Angle.Degrees(+17.31657935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156653"},
        {"Hipparcos Number", "HIP 84631"},
        {"Geneva Identification System", "GEN# +1.00156653"},
        {"Smithsonian Astrophysical Observation", "SAO 102724"},
        {"Wilson Evans Batten Catalogue", "WEB 14293"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.52055177),
        dec: Angle.Degrees(+17.31791351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36321"},
        {"Hipparcos Number", "HIP 25888"},
        {"Geneva Identification System", "GEN# +1.00036321"},
        {"Smithsonian Astrophysical Observation", "SAO 94614"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.90037814),
        dec: Angle.Degrees(+17.31861573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108557",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108557"},
        {"Smithsonian Astrophysical Observation", "SAO 107566"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.85221384),
        dec: Angle.Degrees(+17.31982418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36637"},
        {"Geneva Identification System", "GEN# +9.80088036"},
        {"Geneva Identification System 2", "GEN# +6.10212247"},
    },
    visualMagnitude: 10.98,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.01254359),
        dec: Angle.Degrees(+17.31986010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116478"},
        {"Hipparcos Number", "HIP 65350"},
        {"Geneva Identification System", "GEN# +1.00116478"},
        {"Smithsonian Astrophysical Observation", "SAO 100546"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.90596234),
        dec: Angle.Degrees(+17.32119045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108714"},
        {"Hipparcos Number", "HIP 60933"},
        {"Geneva Identification System", "GEN# +1.00108714"},
        {"Smithsonian Astrophysical Observation", "SAO 100122"},
        {"Wilson Evans Batten Catalogue", "WEB 10845"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.33524502),
        dec: Angle.Degrees(+17.32204490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353229"},
        {"Hipparcos Number", "HIP 103099"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.34216934),
        dec: Angle.Degrees(+17.32365270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35171"},
        {"Hipparcos Number", "HIP 25220"},
        {"Cincinnati Publication", "Ci 18 689"},
        {"Geneva Identification System", "GEN# +1.00035171"},
        {"Smithsonian Astrophysical Observation", "SAO 94513"},
        {"Wilson Evans Batten Catalogue", "WEB 4890"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.90927585),
        dec: Angle.Degrees(+17.32413076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 253.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43819"},
        {"Hipparcos Number", "HIP 30019"},
        {"Celescope Catalog", "CEL 1167"},
        {"Geneva Identification System", "GEN# +1.00043819"},
        {"Renson", "Renson 11620"},
        {"Smithsonian Astrophysical Observation", "SAO 95519"},
        {"Wilson Evans Batten Catalogue", "WEB 5960"},
    },
    visualMagnitude: 6.27,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.75769794),
        dec: Angle.Degrees(+17.32527063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77248"},
        {"Hipparcos Number", "HIP 44358"},
        {"Geneva Identification System", "GEN# +1.00077248"},
        {"Smithsonian Astrophysical Observation", "SAO 98303"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.49411262),
        dec: Angle.Degrees(+17.32666617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218080"},
        {"Hipparcos Number", "HIP 113995"},
        {"Smithsonian Astrophysical Observation", "SAO 108385"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.28058173),
        dec: Angle.Degrees(+17.32689826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132505"},
        {"Hipparcos Number", "HIP 73321"},
        {"Geneva Identification System", "GEN# +1.00132505"},
        {"Smithsonian Astrophysical Observation", "SAO 101312"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.74258052),
        dec: Angle.Degrees(+17.32714518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24357"},
        {"Hipparcos Number", "HIP 18170"},
        {"Fundamental Katalog 5th Edition", "FK5 1106"},
        {"Geneva Identification System", "GEN# +5.20250006"},
        {"Smithsonian Astrophysical Observation", "SAO 93650"},
        {"Wilson Evans Batten Catalogue", "WEB 3506"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.29149356),
        dec: Angle.Degrees(+17.32715595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231812"},
        {"Hipparcos Number", "HIP 96208"},
        {"Smithsonian Astrophysical Observation", "SAO 104969"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.44731858),
        dec: Angle.Degrees(+17.32803963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16598",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16598"},
        {"Smithsonian Astrophysical Observation", "SAO 93490"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.41232495),
        dec: Angle.Degrees(+17.32931248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60055"},
        {"Geneva Identification System", "GEN# +0.01802587"},
        {"Smithsonian Astrophysical Observation", "SAO 100035"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.74048002),
        dec: Angle.Degrees(+17.32947437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30946"},
        {"Hipparcos Number", "HIP 22676"},
        {"Smithsonian Astrophysical Observation", "SAO 94177"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.15325146),
        dec: Angle.Degrees(+17.33353239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72095"},
        {"Hipparcos Number", "HIP 41818"},
        {"Smithsonian Astrophysical Observation", "SAO 97878"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.88049074),
        dec: Angle.Degrees(+17.33584771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106058"},
        {"Smithsonian Astrophysical Observation", "SAO 107167"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.23768025),
        dec: Angle.Degrees(+17.33761921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69516"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.45506049),
        dec: Angle.Degrees(+17.33965550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3006 AB"},
        {"Henry Draper", "HD 26038"},
        {"Hipparcos Number", "HIP 19284"},
        {"Geneva Identification System", "GEN# +1.00026038J"},
        {"Smithsonian Astrophysical Observation", "SAO 93777"},
        {"Wilson Evans Batten Catalogue", "WEB 3707"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.99754752),
        dec: Angle.Degrees(+17.33992101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99108"},
        {"Hipparcos Number", "HIP 55673"},
        {"Geneva Identification System", "GEN# +1.00099108"},
        {"Smithsonian Astrophysical Observation", "SAO 99592"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.10830463),
        dec: Angle.Degrees(+17.34363777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24519"},
        {"Hipparcos Number", "HIP 18283"},
        {"Geneva Identification System", "GEN# +1.00024519"},
        {"Smithsonian Astrophysical Observation", "SAO 93663"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.65262373),
        dec: Angle.Degrees(+17.34373698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117577"},
        {"Geneva Identification System", "GEN# +0.01605004"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.66789186),
        dec: Angle.Degrees(+17.34425860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 167.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229753"},
        {"Hipparcos Number", "HIP 92528"},
        {"Smithsonian Astrophysical Observation", "SAO 104185"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.84801491),
        dec: Angle.Degrees(+17.34488663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188464"},
        {"Hipparcos Number", "HIP 97982"},
        {"Geneva Identification System", "GEN# +1.00188464"},
        {"Smithsonian Astrophysical Observation", "SAO 105408"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.68823938),
        dec: Angle.Degrees(+17.34575648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206859"},
        {"Hipparcos Number", "HIP 107348"},
        {"Geneva Identification System", "GEN# +1.00206859"},
        {"Smithsonian Astrophysical Observation", "SAO 107365"},
        {"Wilson Evans Batten Catalogue", "WEB 19384"},
    },
    visualMagnitude: 4.34,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.12787716),
        dec: Angle.Degrees(+17.35004352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229882"},
        {"Hipparcos Number", "HIP 92665"},
        {"Smithsonian Astrophysical Observation", "SAO 104217"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.24518843),
        dec: Angle.Degrees(+17.35103323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48384"},
        {"Smithsonian Astrophysical Observation", "SAO 98814"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.94841649),
        dec: Angle.Degrees(+17.35170372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58447"},
        {"Smithsonian Astrophysical Observation", "SAO 99893"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.76914926),
        dec: Angle.Degrees(+17.35207277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125391"},
        {"Hipparcos Number", "HIP 69936"},
        {"Geneva Identification System", "GEN# +1.00125391"},
        {"Smithsonian Astrophysical Observation", "SAO 100970"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.68117633),
        dec: Angle.Degrees(+17.35352450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60473"},
        {"Hipparcos Number", "HIP 36903"},
        {"Smithsonian Astrophysical Observation", "SAO 97047"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.81209815),
        dec: Angle.Degrees(+17.35456342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59554"},
        {"Geneva Identification System", "GEN# +0.01802578"},
        {"Smithsonian Astrophysical Observation", "SAO 99988"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.20860219),
        dec: Angle.Degrees(+17.35519426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83326"},
        {"Hipparcos Number", "HIP 47274"},
        {"Smithsonian Astrophysical Observation", "SAO 98684"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.51907557),
        dec: Angle.Degrees(+17.35550915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60441"},
        {"Smithsonian Astrophysical Observation", "SAO 100074"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.87820823),
        dec: Angle.Degrees(+17.35571389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83469"},
        {"Smithsonian Astrophysical Observation", "SAO 102563"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.89351334),
        dec: Angle.Degrees(+17.35824127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49657"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.06195443),
        dec: Angle.Degrees(+17.35866959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95518"},
        {"Hipparcos Number", "HIP 53901"},
        {"Geneva Identification System", "GEN# +1.00095518"},
        {"Smithsonian Astrophysical Observation", "SAO 99405"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.43204118),
        dec: Angle.Degrees(+17.35977261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93124",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11884 A"},
        {"Henry Draper", "HD 176155"},
        {"Hipparcos Number", "HIP 93124"},
        {"Smithsonian Astrophysical Observation", "SAO 104296"},
        {"Wilson Evans Batten Catalogue", "WEB 16131"},
    },
    visualMagnitude: 5.33,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.56144717),
        dec: Angle.Degrees(+17.36093633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62601"},
        {"Geneva Identification System", "GEN# +0.01802666"},
        {"Smithsonian Astrophysical Observation", "SAO 100288"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.41471127),
        dec: Angle.Degrees(+17.36138797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193222"},
        {"Hipparcos Number", "HIP 100116"},
        {"Smithsonian Astrophysical Observation", "SAO 105947"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.64614029),
        dec: Angle.Degrees(+17.36216555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200045"},
        {"Hipparcos Number", "HIP 103678"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.12377485),
        dec: Angle.Degrees(+17.36465627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61694"},
        {"Hipparcos Number", "HIP 37453"},
        {"Smithsonian Astrophysical Observation", "SAO 97142"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.32294256),
        dec: Angle.Degrees(+17.36529585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67707"},
        {"Geneva Identification System", "GEN# +0.01802791"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.05033032),
        dec: Angle.Degrees(+17.36604944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145202"},
        {"Hipparcos Number", "HIP 79130"},
        {"Smithsonian Astrophysical Observation", "SAO 101964"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.27452410),
        dec: Angle.Degrees(+17.36645141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263514"},
        {"Hipparcos Number", "HIP 32465"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.63701924),
        dec: Angle.Degrees(+17.36699106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75864"},
        {"Hipparcos Number", "HIP 43635"},
        {"Geneva Identification System", "GEN# +1.00075864"},
        {"Smithsonian Astrophysical Observation", "SAO 98196"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.30005148),
        dec: Angle.Degrees(+17.36863880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285465"},
        {"Hipparcos Number", "HIP 19472"},
        {"Cincinnati Publication", "Ci 20 283"},
        {"Geneva Identification System", "GEN# +5.20251014"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.55750940),
        dec: Angle.Degrees(+17.36880246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 414.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147953"},
        {"Hipparcos Number", "HIP 80357"},
        {"Smithsonian Astrophysical Observation", "SAO 102138"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.05563138),
        dec: Angle.Degrees(+17.37076797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3971",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3971"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.76573707),
        dec: Angle.Degrees(+17.37128694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69831",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9204 AB"},
        {"Hipparcos Number", "HIP 69831"},
        {"Smithsonian Astrophysical Observation", "SAO 100957"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.37464152),
        dec: Angle.Degrees(+17.37256695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240593"},
        {"Hipparcos Number", "HIP 23707"},
        {"Smithsonian Astrophysical Observation", "SAO 94309"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.44773720),
        dec: Angle.Degrees(+17.38102694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60487"},
        {"Hipparcos Number", "HIP 36921"},
        {"Geneva Identification System", "GEN# +1.00060487"},
        {"Smithsonian Astrophysical Observation", "SAO 97054"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.85197095),
        dec: Angle.Degrees(+17.38319229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35296"},
        {"Hipparcos Number", "HIP 25278"},
        {"Geneva Identification System", "GEN# +1.00035296"},
        {"Smithsonian Astrophysical Observation", "SAO 94526"},
        {"Wilson Evans Batten Catalogue", "WEB 4899"},
    },
    visualMagnitude: 5.00,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.10545973),
        dec: Angle.Degrees(+17.38355205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 250.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91426"},
        {"Smithsonian Astrophysical Observation", "SAO 103948"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.67711310),
        dec: Angle.Degrees(+17.38765105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37941"},
        {"Hipparcos Number", "HIP 26913"},
        {"Smithsonian Astrophysical Observation", "SAO 94792"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.70351826),
        dec: Angle.Degrees(+17.38949927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77892"},
        {"Hipparcos Number", "HIP 44637"},
        {"Smithsonian Astrophysical Observation", "SAO 98358"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.43976150),
        dec: Angle.Degrees(+17.39014916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74300"},
        {"Smithsonian Astrophysical Observation", "SAO 101419"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.80219268),
        dec: Angle.Degrees(+17.39113324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31566"},
        {"Hipparcos Number", "HIP 23049"},
        {"Smithsonian Astrophysical Observation", "SAO 94229"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.40475532),
        dec: Angle.Degrees(+17.39242635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75035"},
        {"Hipparcos Number", "HIP 43206"},
        {"Smithsonian Astrophysical Observation", "SAO 98133"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.02650923),
        dec: Angle.Degrees(+17.39484425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89277"},
        {"Hipparcos Number", "HIP 50469"},
        {"Smithsonian Astrophysical Observation", "SAO 99048"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.57533752),
        dec: Angle.Degrees(+17.39637278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67750"},
        {"Smithsonian Astrophysical Observation", "SAO 100748"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.19671065),
        dec: Angle.Degrees(+17.39778732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76759"},
        {"Smithsonian Astrophysical Observation", "SAO 101674"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.09695337),
        dec: Angle.Degrees(+17.39807299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285660"},
        {"Hipparcos Number", "HIP 20041"},
        {"Smithsonian Astrophysical Observation", "SAO 93848"},
        {"Wilson Evans Batten Catalogue", "WEB 3826"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.47313707),
        dec: Angle.Degrees(+17.39934365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241345"},
        {"Hipparcos Number", "HIP 24142"},
        {"Smithsonian Astrophysical Observation", "SAO 94374"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.77435855),
        dec: Angle.Degrees(+17.39940414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79926",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9997 AB"},
        {"Hipparcos Number", "HIP 79926"},
        {"Smithsonian Astrophysical Observation", "SAO 102080"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.70422731),
        dec: Angle.Degrees(+17.39953884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39699"},
        {"Hipparcos Number", "HIP 27972"},
        {"Smithsonian Astrophysical Observation", "SAO 94989"},
        {"Wilson Evans Batten Catalogue", "WEB 5482"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.74364168),
        dec: Angle.Degrees(+17.40196504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142244"},
        {"Hipparcos Number", "HIP 77782"},
        {"Smithsonian Astrophysical Observation", "SAO 101789"},
        {"Wilson Evans Batten Catalogue", "WEB 13158"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.23395552),
        dec: Angle.Degrees(+17.40316981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147717"},
        {"Hipparcos Number", "HIP 80239"},
        {"Geneva Identification System", "GEN# +1.00147717"},
        {"Smithsonian Astrophysical Observation", "SAO 102114"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.72071868),
        dec: Angle.Degrees(+17.40322637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152929"},
        {"Hipparcos Number", "HIP 82843"},
        {"Smithsonian Astrophysical Observation", "SAO 102480"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.94622233),
        dec: Angle.Degrees(+17.40336652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116180",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16821 AB"},
        {"Henry Draper", "HD 221479"},
        {"Hipparcos Number", "HIP 116180"},
        {"Smithsonian Astrophysical Observation", "SAO 108669"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.10277514),
        dec: Angle.Degrees(+17.40422679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87943"},
        {"Smithsonian Astrophysical Observation", "SAO 103251"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.48564158),
        dec: Angle.Degrees(+17.40498998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97659"},
        {"Hipparcos Number", "HIP 54899"},
        {"Smithsonian Astrophysical Observation", "SAO 99515"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.60626130),
        dec: Angle.Degrees(+17.40700613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119585"},
        {"Hipparcos Number", "HIP 66996"},
        {"Geneva Identification System", "GEN# +1.00119585"},
        {"Smithsonian Astrophysical Observation", "SAO 100680"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.95315029),
        dec: Angle.Degrees(+17.40755452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29420"},
        {"Hipparcos Number", "HIP 21630"},
        {"Geneva Identification System", "GEN# +1.00029420"},
        {"Smithsonian Astrophysical Observation", "SAO 94047"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.66369288),
        dec: Angle.Degrees(+17.40811925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34738"},
        {"Smithsonian Astrophysical Observation", "SAO 96606"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.88204239),
        dec: Angle.Degrees(+17.40838734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133072"},
        {"Hipparcos Number", "HIP 73558"},
        {"Smithsonian Astrophysical Observation", "SAO 101336"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.49075285),
        dec: Angle.Degrees(+17.40840456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49136"},
        {"Wilson Evans Batten Catalogue", "WEB 9107"},
        {"Wilson Evans Batten Catalogue 2", "WEB 9106"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.41830104),
        dec: Angle.Degrees(+17.40922506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112769"},
        {"Hipparcos Number", "HIP 63355"},
        {"Fundamental Katalog 5th Edition", "FK5 3036"},
        {"Geneva Identification System", "GEN# +1.00112769"},
        {"Smithsonian Astrophysical Observation", "SAO 100357"},
        {"Wilson Evans Batten Catalogue", "WEB 11218"},
    },
    visualMagnitude: 4.76,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.73110786),
        dec: Angle.Degrees(+17.40936063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57704"},
        {"Hipparcos Number", "HIP 35804"},
        {"Geneva Identification System", "GEN# +1.00057704"},
        {"Smithsonian Astrophysical Observation", "SAO 96839"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.77340003),
        dec: Angle.Degrees(+17.40968082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74566"},
        {"Smithsonian Astrophysical Observation", "SAO 101453"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.53301129),
        dec: Angle.Degrees(+17.40991613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57224"},
        {"Geneva Identification System", "GEN# +0.01802522"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.00286280),
        dec: Angle.Degrees(+17.41000008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6696"},
        {"Hipparcos Number", "HIP 5309"},
        {"Geneva Identification System", "GEN# +1.00006696"},
        {"Smithsonian Astrophysical Observation", "SAO 92263"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.98489016),
        dec: Angle.Degrees(+17.41233277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10845"},
        {"Hipparcos Number", "HIP 8271"},
        {"Geneva Identification System", "GEN# +1.00010845"},
        {"Smithsonian Astrophysical Observation", "SAO 92622"},
        {"Wilson Evans Batten Catalogue", "WEB 1762"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.64695097),
        dec: Angle.Degrees(+17.41269320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54125"},
    },
    visualMagnitude: 11.14,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.11386510),
        dec: Angle.Degrees(+17.41312158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75978"},
    },
    visualMagnitude: 10.81,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.74507195),
        dec: Angle.Degrees(+17.41467720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -264.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 351663"},
        {"Hipparcos Number", "HIP 99555"},
    },
    visualMagnitude: 9.45,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.05564089),
        dec: Angle.Degrees(+17.41497958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211566"},
        {"Hipparcos Number", "HIP 110069"},
        {"Geneva Identification System", "GEN# +1.00211566"},
        {"Smithsonian Astrophysical Observation", "SAO 107802"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.42048387),
        dec: Angle.Degrees(+17.41509381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126496"},
        {"Hipparcos Number", "HIP 70523"},
        {"Smithsonian Astrophysical Observation", "SAO 101018"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.38939113),
        dec: Angle.Degrees(+17.41685152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285663"},
        {"Hipparcos Number", "HIP 20086"},
        {"Geneva Identification System", "GEN# +5.20251135"},
        {"Geneva Identification System 2", "GEN# +5.20253253"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.59133050),
        dec: Angle.Degrees(+17.42174001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71087"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.05622529),
        dec: Angle.Degrees(+17.42365609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 687"},
        {"Geneva Identification System", "GEN# +6.20030351"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.11390101),
        dec: Angle.Degrees(+17.42445447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37591"},
        {"Smithsonian Astrophysical Observation", "SAO 97172"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.70355684),
        dec: Angle.Degrees(+17.42456788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118000"},
        {"Hipparcos Number", "HIP 66179"},
        {"Geneva Identification System", "GEN# +1.00118000"},
        {"Smithsonian Astrophysical Observation", "SAO 100619"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.45932383),
        dec: Angle.Degrees(+17.42516464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34237"},
        {"Fundamental Katalog 5th Edition", "FK5 4639"},
        {"Smithsonian Astrophysical Observation", "SAO 96479"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.46148062),
        dec: Angle.Degrees(+17.42853335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64662"},
    },
    visualMagnitude: 11.45,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.81801585),
        dec: Angle.Degrees(+17.84070109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188016"},
        {"Hipparcos Number", "HIP 97807"},
        {"Smithsonian Astrophysical Observation", "SAO 105364"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.13067843),
        dec: Angle.Degrees(+17.43156785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38709"},
        {"Hipparcos Number", "HIP 27428"},
        {"Celescope Catalog", "CEL 979"},
        {"Geneva Identification System", "GEN# +1.00038709"},
        {"Smithsonian Astrophysical Observation", "SAO 94872"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.12020768),
        dec: Angle.Degrees(+17.43351507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9780"},
        {"Hipparcos Number", "HIP 7447"},
        {"Geneva Identification System", "GEN# +1.00009780"},
        {"Smithsonian Astrophysical Observation", "SAO 92531"},
        {"Wilson Evans Batten Catalogue", "WEB 1593"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.97777176),
        dec: Angle.Degrees(+17.43378965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34902"},
        {"Geneva Identification System", "GEN# +0.01701524"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.32277436),
        dec: Angle.Degrees(+17.43436014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70642"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.74325482),
        dec: Angle.Degrees(+17.43480322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225181"},
        {"Hipparcos Number", "HIP 324"},
        {"Geneva Identification System", "GEN# +1.00225181"},
        {"Smithsonian Astrophysical Observation", "SAO 91684"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.04254351),
        dec: Angle.Degrees(+17.43668381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98824"},
        {"Hipparcos Number", "HIP 55533"},
        {"Geneva Identification System", "GEN# +1.00098824"},
        {"Smithsonian Astrophysical Observation", "SAO 99577"},
        {"Wilson Evans Batten Catalogue", "WEB 9984"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.62091024),
        dec: Angle.Degrees(+17.43705155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61718"},
        {"Geneva Identification System", "GEN# +0.01802637"},
        {"Smithsonian Astrophysical Observation", "SAO 100193"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.75810158),
        dec: Angle.Degrees(+17.43720007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254374"},
        {"Hipparcos Number", "HIP 29828"},
        {"Smithsonian Astrophysical Observation", "SAO 95481"},
        {"Wilson Evans Batten Catalogue", "WEB 5899"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.22018919),
        dec: Angle.Degrees(+17.43838066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208585"},
        {"Hipparcos Number", "HIP 108331"},
        {"Smithsonian Astrophysical Observation", "SAO 107529"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.22172730),
        dec: Angle.Degrees(+17.43978921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138322"},
        {"Hipparcos Number", "HIP 75958"},
        {"Fundamental Katalog 5th Edition", "FK5 5374"},
        {"Smithsonian Astrophysical Observation", "SAO 101589"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.70306064),
        dec: Angle.Degrees(+17.43992905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229590"},
        {"Hipparcos Number", "HIP 92311"},
        {"Cincinnati Publication", "Ci 18 2463"},
        {"Cincinnati Publication 2", "Ci 20 1109"},
        {"Geneva Identification System", "GEN# +1.00229590"},
        {"Smithsonian Astrophysical Observation", "SAO 104126"},
        {"Wilson Evans Batten Catalogue", "WEB 15936"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.21717260),
        dec: Angle.Degrees(+17.43997462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -408.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -422.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33402"},
        {"Hipparcos Number", "HIP 24103"},
        {"Fundamental Katalog 5th Edition", "FK5 4472"},
        {"Geneva Identification System", "GEN# +1.00033402"},
        {"Smithsonian Astrophysical Observation", "SAO 94366"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.66644641),
        dec: Angle.Degrees(+17.44025381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27819"},
        {"Hipparcos Number", "HIP 20542"},
        {"Geneva Identification System", "GEN# +5.20250047"},
        {"Smithsonian Astrophysical Observation", "SAO 93907"},
        {"Wilson Evans Batten Catalogue", "WEB 3930"},
    },
    visualMagnitude: 4.80,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.02372401),
        dec: Angle.Degrees(+17.44421161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205300"},
        {"Hipparcos Number", "HIP 106480"},
        {"Smithsonian Astrophysical Observation", "SAO 107236"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.49348540),
        dec: Angle.Degrees(+17.44515410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200078"},
        {"Hipparcos Number", "HIP 103692"},
        {"Geneva Identification System", "GEN# +1.00200078"},
        {"Smithsonian Astrophysical Observation", "SAO 106752"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.18082067),
        dec: Angle.Degrees(+17.44797545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 264.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219637"},
        {"Hipparcos Number", "HIP 114976"},
        {"Geneva Identification System", "GEN# +1.00219637"},
        {"Smithsonian Astrophysical Observation", "SAO 108509"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.31012309),
        dec: Angle.Degrees(+17.44950843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85161"},
        {"Smithsonian Astrophysical Observation", "SAO 102799"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.05154291),
        dec: Angle.Degrees(+17.44957831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74003"},
        {"Smithsonian Astrophysical Observation", "SAO 101380"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.85126830),
        dec: Angle.Degrees(+17.44960064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45210"},
        {"Hipparcos Number", "HIP 30687"},
        {"Geneva Identification System", "GEN# +1.00045210"},
        {"Smithsonian Astrophysical Observation", "SAO 95690"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.72943241),
        dec: Angle.Degrees(+17.45158371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113280",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16379 AB"},
        {"Henry Draper", "HD 216863"},
        {"Hipparcos Number", "HIP 113280"},
        {"Cincinnati Publication", "Ci 18 2997"},
        {"Geneva Identification System", "GEN# +1.00216863J"},
        {"Smithsonian Astrophysical Observation", "SAO 108269"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.09796143),
        dec: Angle.Degrees(+17.45284255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241771"},
        {"Hipparcos Number", "HIP 24386"},
        {"Smithsonian Astrophysical Observation", "SAO 94402"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.47489090),
        dec: Angle.Degrees(+17.45326656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126051"},
        {"Hipparcos Number", "HIP 70286"},
        {"Geneva Identification System", "GEN# +1.00126051"},
        {"Smithsonian Astrophysical Observation", "SAO 100998"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.70558126),
        dec: Angle.Degrees(+17.45338018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67275",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9025 A"},
        {"Henry Draper", "HD 120136"},
        {"Hipparcos Number", "HIP 67275"},
        {"Cincinnati Publication", "Ci 20 807"},
        {"Fundamental Katalog 5th Edition", "FK5 507"},
        {"Geneva Identification System", "GEN# +1.00120136"},
        {"Smithsonian Astrophysical Observation", "SAO 100706"},
        {"Wilson Evans Batten Catalogue", "WEB 11837"},
    },
    visualMagnitude: 4.50,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.81681937),
        dec: Angle.Degrees(+17.45677436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -480.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49033"},
        {"Smithsonian Astrophysical Observation", "SAO 98890"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.06137473),
        dec: Angle.Degrees(+17.45979559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7834"},
        {"Smithsonian Astrophysical Observation", "SAO 92570"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.20044308),
        dec: Angle.Degrees(+17.46191395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200532"},
        {"Hipparcos Number", "HIP 103935"},
        {"Geneva Identification System", "GEN# +1.00200532"},
    },
    visualMagnitude: 9.46,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.88511274),
        dec: Angle.Degrees(+17.46236268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13165",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2151 AB"},
        {"Henry Draper", "HD 17543"},
        {"Hipparcos Number", "HIP 13165"},
        {"Geneva Identification System", "GEN# +1.00017543"},
        {"Smithsonian Astrophysical Observation", "SAO 93127"},
        {"Wilson Evans Batten Catalogue", "WEB 2648"},
    },
    visualMagnitude: 5.26,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.32315708),
        dec: Angle.Degrees(+17.46434448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103877"},
        {"Hipparcos Number", "HIP 58327"},
        {"Fundamental Katalog 5th Edition", "FK5 2955"},
        {"Geneva Identification System", "GEN# +1.00103877"},
        {"Renson", "Renson 30000"},
        {"Smithsonian Astrophysical Observation", "SAO 99886"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.42685119),
        dec: Angle.Degrees(+17.46782969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83478"},
        {"Hipparcos Number", "HIP 47375"},
        {"Smithsonian Astrophysical Observation", "SAO 98693"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.78471398),
        dec: Angle.Degrees(+17.46802809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51583"},
        {"Hipparcos Number", "HIP 33583"},
        {"Smithsonian Astrophysical Observation", "SAO 96338"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.66027871),
        dec: Angle.Degrees(+17.46804312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147750"},
        {"Hipparcos Number", "HIP 80262"},
        {"Cincinnati Publication", "Ci 18 2190"},
        {"Geneva Identification System", "GEN# +1.00147750"},
        {"Smithsonian Astrophysical Observation", "SAO 102117"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.77558964),
        dec: Angle.Degrees(+17.46805873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 304.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118034"},
        {"Hipparcos Number", "HIP 66188"},
        {"Smithsonian Astrophysical Observation", "SAO 100622"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.49052712),
        dec: Angle.Degrees(+17.46820941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229301"},
        {"Hipparcos Number", "HIP 91817"},
        {"Smithsonian Astrophysical Observation", "SAO 104022"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.81476890),
        dec: Angle.Degrees(+17.46875648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166915"},
        {"Hipparcos Number", "HIP 89187"},
        {"Smithsonian Astrophysical Observation", "SAO 103469"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.02465806),
        dec: Angle.Degrees(+17.46881013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78479"},
        {"Hipparcos Number", "HIP 44918"},
        {"Geneva Identification System", "GEN# +1.00078479"},
        {"Smithsonian Astrophysical Observation", "SAO 98389"},
        {"Wilson Evans Batten Catalogue", "WEB 8579"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.25972972),
        dec: Angle.Degrees(+17.46973094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89761"},
        {"Smithsonian Astrophysical Observation", "SAO 103604"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.76491129),
        dec: Angle.Degrees(+17.47025611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4996"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.00782942),
        dec: Angle.Degrees(+17.47166075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149754"},
        {"Hipparcos Number", "HIP 81285"},
        {"Geneva Identification System", "GEN# +1.00149754"},
        {"Smithsonian Astrophysical Observation", "SAO 102267"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.03260838),
        dec: Angle.Degrees(+17.47175083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63614"},
        {"Hipparcos Number", "HIP 38270"},
        {"Smithsonian Astrophysical Observation", "SAO 97296"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.61307408),
        dec: Angle.Degrees(+17.47554738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244772"},
        {"Hipparcos Number", "HIP 26043"},
        {"Smithsonian Astrophysical Observation", "SAO 94646"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.32922649),
        dec: Angle.Degrees(+17.47591048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185958"},
        {"Hipparcos Number", "HIP 96837"},
        {"Fundamental Katalog 5th Edition", "FK5 1513"},
        {"Geneva Identification System", "GEN# +1.00185958"},
        {"Smithsonian Astrophysical Observation", "SAO 105133"},
        {"Wilson Evans Batten Catalogue", "WEB 16997"},
    },
    visualMagnitude: 4.39,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.26222378),
        dec: Angle.Degrees(+17.47612356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85362"},
        {"Hipparcos Number", "HIP 48372"},
        {"Geneva Identification System", "GEN# +1.00085362"},
        {"Smithsonian Astrophysical Observation", "SAO 98813"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.91306139),
        dec: Angle.Degrees(+17.47621804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79160"},
        {"Hipparcos Number", "HIP 45217"},
        {"Smithsonian Astrophysical Observation", "SAO 98435"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.22669041),
        dec: Angle.Degrees(+17.47685902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24040"},
        {"Hipparcos Number", "HIP 17960"},
        {"Geneva Identification System", "GEN# +1.00024040"},
        {"Smithsonian Astrophysical Observation", "SAO 93630"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.59540957),
        dec: Angle.Degrees(+17.47697953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104923"},
        {"Hipparcos Number", "HIP 58919"},
        {"Geneva Identification System", "GEN# +1.00104923"},
        {"Smithsonian Astrophysical Observation", "SAO 99930"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.23727898),
        dec: Angle.Degrees(+17.47714549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62436"},
        {"Hipparcos Number", "HIP 37759"},
        {"Geneva Identification System", "GEN# +1.00062436"},
        {"Smithsonian Astrophysical Observation", "SAO 97205"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.15434414),
        dec: Angle.Degrees(+17.47736627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73555"},
        {"Hipparcos Number", "HIP 42471"},
        {"Smithsonian Astrophysical Observation", "SAO 98005"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.88132568),
        dec: Angle.Degrees(+17.47826578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78539"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.51580676),
        dec: Angle.Degrees(+17.48065669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76445"},
        {"Hipparcos Number", "HIP 43915"},
        {"Geneva Identification System", "GEN# +1.00076445"},
        {"Smithsonian Astrophysical Observation", "SAO 98241"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.19154220),
        dec: Angle.Degrees(+17.48140012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114300"},
        {"Hipparcos Number", "HIP 64205"},
        {"Geneva Identification System", "GEN# +1.00114300"},
        {"Smithsonian Astrophysical Observation", "SAO 100438"},
        {"Wilson Evans Batten Catalogue", "WEB 11347"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.37885147),
        dec: Angle.Degrees(+17.48329639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31502"},
        {"Hipparcos Number", "HIP 23031"},
        {"Smithsonian Astrophysical Observation", "SAO 94223"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.28492748),
        dec: Angle.Degrees(+17.48750929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29550"},
        {"Hipparcos Number", "HIP 21725"},
        {"Smithsonian Astrophysical Observation", "SAO 94059"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.96744527),
        dec: Angle.Degrees(+17.48928680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173172"},
        {"Hipparcos Number", "HIP 91824"},
        {"Smithsonian Astrophysical Observation", "SAO 104024"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.82805486),
        dec: Angle.Degrees(+17.48978844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55128"},
    },
    visualMagnitude: 10.81,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.29959369),
        dec: Angle.Degrees(+17.49089393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -304.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80662"},
        {"Fundamental Katalog 5th Edition", "FK5 5456"},
        {"Smithsonian Astrophysical Observation", "SAO 102190"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.03420234),
        dec: Angle.Degrees(+17.49107356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200659"},
        {"Hipparcos Number", "HIP 104006"},
        {"Geneva Identification System", "GEN# +1.00200659"},
        {"Smithsonian Astrophysical Observation", "SAO 106817"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.07494850),
        dec: Angle.Degrees(+17.49374381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79635"},
        {"Hipparcos Number", "HIP 45454"},
        {"Smithsonian Astrophysical Observation", "SAO 98459"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.95719378),
        dec: Angle.Degrees(+17.49428472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74781"},
        {"Hipparcos Number", "HIP 43079"},
        {"Fundamental Katalog 5th Edition", "FK5 4787"},
        {"Geneva Identification System", "GEN# +1.00074781"},
        {"Smithsonian Astrophysical Observation", "SAO 98112"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.62293349),
        dec: Angle.Degrees(+17.49593939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38671"},
        {"Hipparcos Number", "HIP 27405"},
        {"Celescope Catalog", "CEL 973"},
        {"Geneva Identification System", "GEN# +1.00038671"},
        {"Smithsonian Astrophysical Observation", "SAO 94870"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.04991827),
        dec: Angle.Degrees(+17.49651293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347848"},
        {"Hipparcos Number", "HIP 88187"},
        {"Smithsonian Astrophysical Observation", "SAO 103293"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.14805324),
        dec: Angle.Degrees(+17.49653028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45597"},
        {"Hipparcos Number", "HIP 30900"},
        {"Geneva Identification System", "GEN# +1.00045597"},
        {"Smithsonian Astrophysical Observation", "SAO 95733"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.28980021),
        dec: Angle.Degrees(+17.49660256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205574"},
        {"Hipparcos Number", "HIP 106625"},
        {"Smithsonian Astrophysical Observation", "SAO 107260"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.95354822),
        dec: Angle.Degrees(+17.49829805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285464"},
        {"Hipparcos Number", "HIP 19420"},
        {"Smithsonian Astrophysical Observation", "SAO 93791"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.38736769),
        dec: Angle.Degrees(+17.49942943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149011"},
        {"Hipparcos Number", "HIP 80915"},
        {"Smithsonian Astrophysical Observation", "SAO 102221"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.85186507),
        dec: Angle.Degrees(+17.49995286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116341"},
        {"Smithsonian Astrophysical Observation", "SAO 108685"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.61119117),
        dec: Angle.Degrees(+17.50054065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20645"},
        {"Hipparcos Number", "HIP 15519"},
        {"Fundamental Katalog 5th Edition", "FK5 4306"},
        {"Geneva Identification System", "GEN# +1.00020645"},
        {"Smithsonian Astrophysical Observation", "SAO 93389"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.99675133),
        dec: Angle.Degrees(+17.50085575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48744"},
        {"Geneva Identification System", "GEN# +0.01802293"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.13497015),
        dec: Angle.Degrees(+17.50515258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179710"},
        {"Hipparcos Number", "HIP 94416"},
        {"Smithsonian Astrophysical Observation", "SAO 104612"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.24572853),
        dec: Angle.Degrees(+17.50674903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 350461"},
        {"Hipparcos Number", "HIP 96999"},
        {"Geneva Identification System", "GEN# +1.00350461"},
        {"Smithsonian Astrophysical Observation", "SAO 105182"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.72574752),
        dec: Angle.Degrees(+17.50878247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17446"},
        {"Hipparcos Number", "HIP 13092"},
        {"Smithsonian Astrophysical Observation", "SAO 93115"},
        {"Wilson Evans Batten Catalogue", "WEB 2641"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.08228671),
        dec: Angle.Degrees(+17.50942152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220782"},
        {"Hipparcos Number", "HIP 115699"},
        {"Geneva Identification System", "GEN# +1.00220782"},
        {"Smithsonian Astrophysical Observation", "SAO 108606"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.62083546),
        dec: Angle.Degrees(+17.50969796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85487"},
        {"Geneva Identification System", "GEN# +0.01703248"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.06040958),
        dec: Angle.Degrees(+17.51001238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209775"},
        {"Hipparcos Number", "HIP 109055"},
        {"Geneva Identification System", "GEN# +1.00209775"},
        {"Smithsonian Astrophysical Observation", "SAO 107656"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.38550285),
        dec: Angle.Degrees(+17.51064228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222843"},
        {"Hipparcos Number", "HIP 117070"},
        {"Geneva Identification System", "GEN# +1.00222843"},
        {"Smithsonian Astrophysical Observation", "SAO 108798"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.99603234),
        dec: Angle.Degrees(+17.51169758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11851"},
        {"Hipparcos Number", "HIP 9072"},
        {"Smithsonian Astrophysical Observation", "SAO 92711"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.19711092),
        dec: Angle.Degrees(+17.51187845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89847"},
        {"Hipparcos Number", "HIP 50814"},
        {"Geneva Identification System", "GEN# +1.00089847"},
        {"Smithsonian Astrophysical Observation", "SAO 99086"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.61920185),
        dec: Angle.Degrees(+17.51405952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189984"},
        {"Hipparcos Number", "HIP 98646"},
        {"Smithsonian Astrophysical Observation", "SAO 105574"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.55333707),
        dec: Angle.Degrees(+17.51525009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98438",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13230 A"},
        {"Henry Draper", "HD 189577"},
        {"Hipparcos Number", "HIP 98438"},
        {"Geneva Identification System", "GEN# +1.00189577"},
        {"Smithsonian Astrophysical Observation", "SAO 105522"},
        {"Wilson Evans Batten Catalogue", "WEB 17377"},
    },
    visualMagnitude: 5.33,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.01378061),
        dec: Angle.Degrees(+17.51654077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114762"},
        {"Henry Draper 2", "HD 114762A"},
        {"Hipparcos Number", "HIP 64426"},
        {"Cincinnati Publication", "Ci 20 766"},
        {"Cincinnati Publication 2", "Ci 18 1695"},
        {"Fundamental Katalog 5th Edition", "FK5 5165"},
        {"Geneva Identification System", "GEN# +1.00114762"},
        {"Smithsonian Astrophysical Observation", "SAO 100458"},
        {"Wilson Evans Batten Catalogue", "WEB 11388"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.08374652),
        dec: Angle.Degrees(+17.51712793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -582.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25627"},
        {"Hipparcos Number", "HIP 19036"},
        {"Fundamental Katalog 5th Edition", "FK5 4367"},
        {"Geneva Identification System", "GEN# +1.00025627"},
        {"Smithsonian Astrophysical Observation", "SAO 93749"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.16507236),
        dec: Angle.Degrees(+17.51757889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352826"},
        {"Hipparcos Number", "HIP 102000"},
        {"Smithsonian Astrophysical Observation", "SAO 106366"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.05400384),
        dec: Angle.Degrees(+17.51814190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210647"},
        {"Hipparcos Number", "HIP 109554"},
        {"Geneva Identification System", "GEN# +1.00210647"},
        {"Smithsonian Astrophysical Observation", "SAO 107726"},
        {"Wilson Evans Batten Catalogue", "WEB 19681"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.87318032),
        dec: Angle.Degrees(+17.51958400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158806"},
        {"Hipparcos Number", "HIP 85683"},
        {"Geneva Identification System", "GEN# +1.00158806"},
        {"Smithsonian Astrophysical Observation", "SAO 102873"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.64668325),
        dec: Angle.Degrees(+17.52047075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197249"},
        {"Hipparcos Number", "HIP 102158"},
        {"Geneva Identification System", "GEN# +1.00197249"},
        {"Smithsonian Astrophysical Observation", "SAO 106396"},
        {"Wilson Evans Batten Catalogue", "WEB 18484"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.49231374),
        dec: Angle.Degrees(+17.52138420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77587"},
        {"Smithsonian Astrophysical Observation", "SAO 101769"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.61276014),
        dec: Angle.Degrees(+17.52210080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37710"},
        {"Hipparcos Number", "HIP 26786"},
        {"Fundamental Katalog 5th Edition", "FK5 4516"},
        {"Geneva Identification System", "GEN# +1.00037710"},
        {"Smithsonian Astrophysical Observation", "SAO 94760"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.34418073),
        dec: Angle.Degrees(+17.52219078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61958"},
        {"Geneva Identification System", "GEN# +0.01802647"},
    },
    visualMagnitude: 11.85,
    bvColour: -0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.46581106),
        dec: Angle.Degrees(+17.52224351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100922"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.92180533),
        dec: Angle.Degrees(+17.52337031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27282"},
        {"Hipparcos Number", "HIP 20146"},
        {"Geneva Identification System", "GEN# +5.20250027"},
        {"Smithsonian Astrophysical Observation", "SAO 93860"},
        {"Wilson Evans Batten Catalogue", "WEB 3843"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.78307834),
        dec: Angle.Degrees(+17.52482183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118154"},
    },
    visualMagnitude: 12.14,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.50624414),
        dec: Angle.Degrees(+17.52622899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90207"},
        {"Hipparcos Number", "HIP 51005"},
        {"Geneva Identification System", "GEN# +1.00090207"},
        {"Smithsonian Astrophysical Observation", "SAO 99107"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.29284206),
        dec: Angle.Degrees(+17.52772355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89548",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89548"},
        {"Smithsonian Astrophysical Observation", "SAO 103550"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.08410888),
        dec: Angle.Degrees(+17.52811637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216980"},
        {"Hipparcos Number", "HIP 113340"},
        {"Smithsonian Astrophysical Observation", "SAO 108281"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.29733409),
        dec: Angle.Degrees(+17.52818677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64241",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Diadem"},
        {"Aitken", "ADS 8804 AB"},
        {"Hipparcos Number", "HIP 64241"},
        {"Cincinnati Publication", "Ci 20 762"},
        {"Geneva Identification System", "GEN# +1.00114378"},
        {"Smithsonian Astrophysical Observation", "SAO 100443"},
        {"Wilson Evans Batten Catalogue", "WEB 11357"},
    },
    visualMagnitude: 4.32,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.49812263),
        dec: Angle.Degrees(+17.52911621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -445.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223131"},
        {"Hipparcos Number", "HIP 117279"},
        {"Smithsonian Astrophysical Observation", "SAO 108830"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.71809349),
        dec: Angle.Degrees(+17.52913503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352176"},
        {"Hipparcos Number", "HIP 100522"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.74999677),
        dec: Angle.Degrees(+17.53032962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91225",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91225"},
        {"Smithsonian Astrophysical Observation", "SAO 103899"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.13775503),
        dec: Angle.Degrees(+17.53090486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70843"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.30592691),
        dec: Angle.Degrees(+17.53233789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71372",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71372"},
        {"Smithsonian Astrophysical Observation", "SAO 101098"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.94270083),
        dec: Angle.Degrees(+17.53295524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77259"},
        {"Smithsonian Astrophysical Observation", "SAO 101730"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.61309217),
        dec: Angle.Degrees(+17.53314978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 483"},
        {"Hipparcos Number", "HIP 759"},
        {"Fundamental Katalog 5th Edition", "FK5 4019"},
        {"Geneva Identification System", "GEN# +1.00000483"},
        {"Smithsonian Astrophysical Observation", "SAO 91740"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.33100682),
        dec: Angle.Degrees(+17.53423872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69478"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.35973218),
        dec: Angle.Degrees(+17.53434092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153455"},
        {"Hipparcos Number", "HIP 83108"},
        {"Geneva Identification System", "GEN# +1.00153455"},
        {"Smithsonian Astrophysical Observation", "SAO 102507"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.74314286),
        dec: Angle.Degrees(+17.53669164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61408"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.74458453),
        dec: Angle.Degrees(+17.54000711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85988"},
        {"Hipparcos Number", "HIP 48700"},
        {"Geneva Identification System", "GEN# +1.00085988"},
        {"Smithsonian Astrophysical Observation", "SAO 98850"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.98330235),
        dec: Angle.Degrees(+17.54160760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20455",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Secunda Hyadum"},
        {"Henry Draper", "HD 27697"},
        {"Hipparcos Number", "HIP 20455"},
        {"Fundamental Katalog 5th Edition", "FK5 162"},
        {"Geneva Identification System", "GEN# +5.20250041"},
        {"Smithsonian Astrophysical Observation", "SAO 93897"},
        {"Wilson Evans Batten Catalogue", "WEB 3912"},
    },
    visualMagnitude: 3.77,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.73344722),
        dec: Angle.Degrees(+17.54258430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11743"},
        {"Smithsonian Astrophysical Observation", "SAO 92985"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.88557693),
        dec: Angle.Degrees(+17.54379813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28394"},
        {"Hipparcos Number", "HIP 20935"},
        {"Geneva Identification System", "GEN# +5.20250077"},
        {"Smithsonian Astrophysical Observation", "SAO 93962"},
        {"Wilson Evans Batten Catalogue", "WEB 4024"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.33537074),
        dec: Angle.Degrees(+17.54501189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75995"},
        {"Hipparcos Number", "HIP 43672"},
        {"Smithsonian Astrophysical Observation", "SAO 98204"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.46144830),
        dec: Angle.Degrees(+17.54511147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16969"},
        {"Hipparcos Number", "HIP 12731"},
        {"Smithsonian Astrophysical Observation", "SAO 93073"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.91235536),
        dec: Angle.Degrees(+17.54850846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21031"},
        {"Hipparcos Number", "HIP 15854"},
        {"Smithsonian Astrophysical Observation", "SAO 93414"},
    },
    visualMagnitude: 8.10,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.05961321),
        dec: Angle.Degrees(+17.54971529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117846"},
        {"Geneva Identification System", "GEN# +0.01605012"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.51964029),
        dec: Angle.Degrees(+17.54990079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62520"},
        {"Smithsonian Astrophysical Observation", "SAO 100275"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.19172132),
        dec: Angle.Degrees(+17.55093922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225073"},
        {"Hipparcos Number", "HIP 258"},
        {"Smithsonian Astrophysical Observation", "SAO 91678"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.80532807),
        dec: Angle.Degrees(+17.55239698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11660"},
        {"Hipparcos Number", "HIP 8915"},
        {"Geneva Identification System", "GEN# +1.00011660"},
        {"Smithsonian Astrophysical Observation", "SAO 92692"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.69404676),
        dec: Angle.Degrees(+17.55245389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116047"},
        {"Smithsonian Astrophysical Observation", "SAO 108653"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.71039608),
        dec: Angle.Degrees(+17.55298839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177459"},
        {"Hipparcos Number", "HIP 93645"},
        {"Geneva Identification System", "GEN# +1.00177459"},
        {"Smithsonian Astrophysical Observation", "SAO 104437"},
        {"Wilson Evans Batten Catalogue", "WEB 16269"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.04033580),
        dec: Angle.Degrees(+17.55591189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112268",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112268"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.10416951),
        dec: Angle.Degrees(+17.55696558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142226"},
        {"Hipparcos Number", "HIP 77773"},
        {"Smithsonian Astrophysical Observation", "SAO 101787"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.21800882),
        dec: Angle.Degrees(+17.55722512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210170"},
        {"Hipparcos Number", "HIP 109261"},
        {"Geneva Identification System", "GEN# +1.00210170"},
        {"Smithsonian Astrophysical Observation", "SAO 107682"},
        {"Wilson Evans Batten Catalogue", "WEB 19635"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.03759749),
        dec: Angle.Degrees(+17.55862376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137492"},
        {"Hipparcos Number", "HIP 75533"},
        {"Smithsonian Astrophysical Observation", "SAO 101547"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.46809494),
        dec: Angle.Degrees(+17.56327216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260655"},
        {"Hipparcos Number", "HIP 31635"},
        {"Cincinnati Publication", "Ci 20 393"},
        {"Geneva Identification System", "GEN# +0.01701320"},
        {"Geneva Identification System 2", "GEN# +1.00260655"},
        {"Wilson Evans Batten Catalogue", "WEB 6335"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.29694468),
        dec: Angle.Degrees(+17.56399483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -775.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 331.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18903"},
        {"Hipparcos Number", "HIP 14183"},
        {"Smithsonian Astrophysical Observation", "SAO 93250"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.72317488),
        dec: Angle.Degrees(+17.56558346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86731"},
        {"Hipparcos Number", "HIP 49061"},
        {"Geneva Identification System", "GEN# +1.00086731"},
        {"Smithsonian Astrophysical Observation", "SAO 98894"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.17495314),
        dec: Angle.Degrees(+17.56776880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161728"},
        {"Hipparcos Number", "HIP 86975"},
        {"Geneva Identification System", "GEN# +1.00161728"},
        {"Smithsonian Astrophysical Observation", "SAO 103093"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.61599387),
        dec: Angle.Degrees(+17.56942489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197103"},
        {"Hipparcos Number", "HIP 102052"},
        {"Smithsonian Astrophysical Observation", "SAO 106376"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.22509239),
        dec: Angle.Degrees(+17.57100211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49406"},
        {"Smithsonian Astrophysical Observation", "SAO 98937"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.28469666),
        dec: Angle.Degrees(+17.57150713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197563"},
        {"Hipparcos Number", "HIP 102330"},
        {"Smithsonian Astrophysical Observation", "SAO 106433"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.99722676),
        dec: Angle.Degrees(+17.57154472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69031"},
        {"Hipparcos Number", "HIP 40458"},
        {"Geneva Identification System", "GEN# +1.00069031"},
        {"Smithsonian Astrophysical Observation", "SAO 97680"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.91479556),
        dec: Angle.Degrees(+17.57209513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1534"},
        {"Smithsonian Astrophysical Observation", "SAO 91842"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.77862058),
        dec: Angle.Degrees(+17.57236887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207532"},
        {"Hipparcos Number", "HIP 107720"},
        {"Smithsonian Astrophysical Observation", "SAO 107413"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.31720725),
        dec: Angle.Degrees(+17.57261494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20368"},
        {"Hipparcos Number", "HIP 15285"},
        {"Geneva Identification System", "GEN# +1.00020368"},
        {"Smithsonian Astrophysical Observation", "SAO 93370"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.30163345),
        dec: Angle.Degrees(+17.57297712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77457"},
        {"Hipparcos Number", "HIP 44432"},
        {"Geneva Identification System", "GEN# +1.00077457"},
        {"Smithsonian Astrophysical Observation", "SAO 98315"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.78696702),
        dec: Angle.Degrees(+17.57384060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30333",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4991 AB"},
        {"Henry Draper", "HD 44496"},
        {"Hipparcos Number", "HIP 30333"},
        {"Celescope Catalog", "CEL 1201"},
        {"Geneva Identification System", "GEN# +1.00044496J"},
        {"Smithsonian Astrophysical Observation", "SAO 95602"},
        {"Wilson Evans Batten Catalogue", "WEB 6034"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.70677331),
        dec: Angle.Degrees(+17.57411458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91386"},
        {"Hipparcos Number", "HIP 51677"},
        {"Smithsonian Astrophysical Observation", "SAO 99181"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.35754377),
        dec: Angle.Degrees(+17.57430351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117624"},
        {"Hipparcos Number", "HIP 65954"},
        {"Geneva Identification System", "GEN# +1.00117624"},
        {"Renson", "Renson 33910"},
        {"Smithsonian Astrophysical Observation", "SAO 100604"},
        {"Wilson Evans Batten Catalogue", "WEB 11662"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.82493803),
        dec: Angle.Degrees(+17.57655543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10013"},
        {"Smithsonian Astrophysical Observation", "SAO 92808"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.23623427),
        dec: Angle.Degrees(+17.57938805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111336"},
        {"Hipparcos Number", "HIP 62503"},
        {"Geneva Identification System", "GEN# +1.00111336"},
        {"Smithsonian Astrophysical Observation", "SAO 100271"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.11847643),
        dec: Angle.Degrees(+17.57980944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115981"},
        {"Hipparcos Number", "HIP 65085"},
        {"Geneva Identification System", "GEN# +1.00115981"},
        {"Smithsonian Astrophysical Observation", "SAO 100519"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.10738704),
        dec: Angle.Degrees(+17.58050032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59754"},
    },
    visualMagnitude: 11.05,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.80748160),
        dec: Angle.Degrees(+17.58149388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2754"},
        {"Smithsonian Astrophysical Observation", "SAO 91982"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.79112481),
        dec: Angle.Degrees(+17.58274899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231582"},
        {"Hipparcos Number", "HIP 95844"},
        {"Geneva Identification System", "GEN# +1.00231582"},
        {"Smithsonian Astrophysical Observation", "SAO 104901"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.39914558),
        dec: Angle.Degrees(+17.58509335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85962"},
        {"Smithsonian Astrophysical Observation", "SAO 102923"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.53511651),
        dec: Angle.Degrees(+17.58617326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49637"},
        {"Hipparcos Number", "HIP 32783"},
        {"Smithsonian Astrophysical Observation", "SAO 96167"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.52652638),
        dec: Angle.Degrees(+17.58980817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347847"},
        {"Hipparcos Number", "HIP 88200"},
        {"Smithsonian Astrophysical Observation", "SAO 103296"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.18137522),
        dec: Angle.Degrees(+17.59197078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222188"},
        {"Hipparcos Number", "HIP 116652"},
        {"Geneva Identification System", "GEN# +1.00222188"},
        {"Smithsonian Astrophysical Observation", "SAO 108739"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.59265516),
        dec: Angle.Degrees(+17.59396471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218792"},
        {"Hipparcos Number", "HIP 114449"},
        {"Geneva Identification System", "GEN# +1.00218792"},
        {"Smithsonian Astrophysical Observation", "SAO 108443"},
        {"Wilson Evans Batten Catalogue", "WEB 20314"},
    },
    visualMagnitude: 5.68,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.67759102),
        dec: Angle.Degrees(+17.59443802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118874"},
        {"Hipparcos Number", "HIP 66628"},
        {"Geneva Identification System", "GEN# +1.00118874"},
        {"Smithsonian Astrophysical Observation", "SAO 100653"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.85608918),
        dec: Angle.Degrees(+17.59524970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14739"},
        {"Hipparcos Number", "HIP 11112"},
        {"Geneva Identification System", "GEN# +1.00014739"},
        {"Smithsonian Astrophysical Observation", "SAO 92911"},
        {"Wilson Evans Batten Catalogue", "WEB 2339"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.74833243),
        dec: Angle.Degrees(+17.59789532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15143"},
        {"Hipparcos Number", "HIP 11384"},
        {"Geneva Identification System", "GEN# +1.00015143"},
        {"Smithsonian Astrophysical Observation", "SAO 92951"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.67926952),
        dec: Angle.Degrees(+17.59814730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16983",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2656 AB"},
        {"Henry Draper", "HD 22570"},
        {"Hipparcos Number", "HIP 16983"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.60739288),
        dec: Angle.Degrees(+17.59924286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170630"},
        {"Hipparcos Number", "HIP 90650"},
        {"Smithsonian Astrophysical Observation", "SAO 103781"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.44144216),
        dec: Angle.Degrees(+17.59935413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70318"},
        {"Hipparcos Number", "HIP 40989"},
        {"Geneva Identification System", "GEN# +1.00070318"},
        {"Renson", "Renson 19404"},
        {"Smithsonian Astrophysical Observation", "SAO 97757"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.47475755),
        dec: Angle.Degrees(+17.60110363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352495"},
        {"Hipparcos Number", "HIP 101254"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.86387811),
        dec: Angle.Degrees(+17.60267963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94911",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12301 AB"},
        {"Henry Draper", "HD 231121"},
        {"Hipparcos Number", "HIP 94911"},
        {"Smithsonian Astrophysical Observation", "SAO 104710"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.70373836),
        dec: Angle.Degrees(+17.60633794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285247"},
        {"Hipparcos Number", "HIP 18304"},
        {"Smithsonian Astrophysical Observation", "SAO 93666"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.70305216),
        dec: Angle.Degrees(+17.60755294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105260"},
        {"Hipparcos Number", "HIP 59107"},
        {"Fundamental Katalog 5th Edition", "FK5 5072"},
        {"Geneva Identification System", "GEN# +1.00105260"},
        {"Smithsonian Astrophysical Observation", "SAO 99945"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.80906438),
        dec: Angle.Degrees(+17.60768561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347898"},
        {"Hipparcos Number", "HIP 88430"},
        {"Smithsonian Astrophysical Observation", "SAO 103333"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.81562508),
        dec: Angle.Degrees(+17.60795209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31181"},
        {"Hipparcos Number", "HIP 22805"},
        {"Geneva Identification System", "GEN# +5.20250166"},
        {"Smithsonian Astrophysical Observation", "SAO 94189"},
        {"Wilson Evans Batten Catalogue", "WEB 4414"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.58593844),
        dec: Angle.Degrees(+17.60920044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189576"},
        {"Hipparcos Number", "HIP 98443"},
        {"Smithsonian Astrophysical Observation", "SAO 105523"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.03453642),
        dec: Angle.Degrees(+17.61072514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109206"},
        {"Smithsonian Astrophysical Observation", "SAO 107673"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.86152593),
        dec: Angle.Degrees(+17.61115314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223554"},
        {"Hipparcos Number", "HIP 117562"},
        {"Smithsonian Astrophysical Observation", "SAO 108866"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.62594529),
        dec: Angle.Degrees(+17.61126216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138306"},
        {"Hipparcos Number", "HIP 75965"},
        {"Smithsonian Astrophysical Observation", "SAO 101590"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.71024319),
        dec: Angle.Degrees(+17.61321380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129373"},
        {"Hipparcos Number", "HIP 71838"},
        {"Smithsonian Astrophysical Observation", "SAO 101154"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.43250516),
        dec: Angle.Degrees(+17.61430110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10435",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10435"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.61327279),
        dec: Angle.Degrees(+17.61468274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70509"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.34636239),
        dec: Angle.Degrees(+17.61584496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142376"},
        {"Hipparcos Number", "HIP 77849"},
        {"Smithsonian Astrophysical Observation", "SAO 101799"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.44705843),
        dec: Angle.Degrees(+17.61636247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66711"},
        {"Hipparcos Number", "HIP 39587"},
        {"Smithsonian Astrophysical Observation", "SAO 97545"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.34106880),
        dec: Angle.Degrees(+17.62183198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10454"},
        {"Smithsonian Astrophysical Observation", "SAO 92849"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.67963456),
        dec: Angle.Degrees(+17.62226216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347983"},
        {"Hipparcos Number", "HIP 88881"},
        {"Smithsonian Astrophysical Observation", "SAO 103423"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.17944758),
        dec: Angle.Degrees(+17.62319735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45722"},
        {"Hipparcos Number", "HIP 30954"},
        {"Smithsonian Astrophysical Observation", "SAO 95745"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.45782597),
        dec: Angle.Degrees(+17.62417899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40184",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6650 D"},
        {"Hipparcos Number", "HIP 40184"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.13114374),
        dec: Angle.Degrees(+17.62551525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93987"},
        {"Wilson Evans Batten Catalogue", "WEB 16359"},
    },
    visualMagnitude: 11.08,
    bvColour: 1.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.04906581),
        dec: Angle.Degrees(+17.62810621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202815"},
        {"Hipparcos Number", "HIP 105141"},
        {"Smithsonian Astrophysical Observation", "SAO 107005"},
        {"Wilson Evans Batten Catalogue", "WEB 19095"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.48594855),
        dec: Angle.Degrees(+17.62821330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18354",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2864 AB"},
        {"Henry Draper", "HD 24620"},
        {"Hipparcos Number", "HIP 18354"},
        {"Smithsonian Astrophysical Observation", "SAO 93676"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.85856736),
        dec: Angle.Degrees(+17.63266456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7602"},
        {"Hipparcos Number", "HIP 5925"},
        {"Geneva Identification System", "GEN# +1.00007602"},
        {"Smithsonian Astrophysical Observation", "SAO 92339"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.04956035),
        dec: Angle.Degrees(+17.63461477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75653",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9645 AB"},
        {"Henry Draper", "HD 137792"},
        {"Hipparcos Number", "HIP 75653"},
        {"Geneva Identification System", "GEN# +1.00137792J"},
        {"Smithsonian Astrophysical Observation", "SAO 101563"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.83673117),
        dec: Angle.Degrees(+17.63506965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243241"},
        {"Hipparcos Number", "HIP 25248"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.98733329),
        dec: Angle.Degrees(+17.63621252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123673"},
        {"Hipparcos Number", "HIP 69103"},
        {"Geneva Identification System", "GEN# +1.00123673"},
        {"Smithsonian Astrophysical Observation", "SAO 100870"},
        {"Wilson Evans Batten Catalogue", "WEB 12064"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.18272967),
        dec: Angle.Degrees(+17.63890071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73275"},
        {"Smithsonian Astrophysical Observation", "SAO 101309"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.63819055),
        dec: Angle.Degrees(+17.63988720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47681"},
        {"Hipparcos Number", "HIP 31950"},
        {"Smithsonian Astrophysical Observation", "SAO 95985"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.14594472),
        dec: Angle.Degrees(+17.64084346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106106",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106106"},
        {"Cincinnati Publication", "Ci 20 1285"},
        {"Geneva Identification System", "GEN# +6.10220775"},
        {"Geneva Identification System 2", "GEN# +6.10010829"},
        {"Wilson Evans Batten Catalogue", "WEB 19230"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.40081536),
        dec: Angle.Degrees(+17.64237600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1008.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 376.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127539"},
        {"Hipparcos Number", "HIP 71025"},
        {"Geneva Identification System", "GEN# +1.00127539"},
        {"Smithsonian Astrophysical Observation", "SAO 101063"},
        {"Wilson Evans Batten Catalogue", "WEB 12285"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.89078843),
        dec: Angle.Degrees(+17.64302028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48097"},
        {"Hipparcos Number", "HIP 32104"},
        {"Geneva Identification System", "GEN# +1.00048097"},
        {"Smithsonian Astrophysical Observation", "SAO 96015"},
        {"Wilson Evans Batten Catalogue", "WEB 6481"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.60134402),
        dec: Angle.Degrees(+17.64551421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42005"},
        {"Smithsonian Astrophysical Observation", "SAO 97911"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.42370410),
        dec: Angle.Degrees(+17.64587114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223532"},
        {"Hipparcos Number", "HIP 117540"},
        {"Geneva Identification System", "GEN# +1.00223532"},
        {"Smithsonian Astrophysical Observation", "SAO 108864"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.55978479),
        dec: Angle.Degrees(+17.64620452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148006"},
        {"Hipparcos Number", "HIP 80392"},
        {"Smithsonian Astrophysical Observation", "SAO 102142"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.13738183),
        dec: Angle.Degrees(+17.64648834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52533"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.11173893),
        dec: Angle.Degrees(+17.64727194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40167",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tegmine"},
        {"Aitken", "ADS 6650 ABC"},
        {"Hipparcos Number", "HIP 40167"},
        {"Geneva Identification System", "GEN# +1.00068257"},
    },
    visualMagnitude: 4.67,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.05295353),
        dec: Angle.Degrees(+17.64813756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116940"},
        {"Hipparcos Number", "HIP 65587"},
        {"Geneva Identification System", "GEN# +1.00116940"},
        {"Smithsonian Astrophysical Observation", "SAO 100567"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.69655188),
        dec: Angle.Degrees(+17.64917679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81978"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.19623468),
        dec: Angle.Degrees(+17.64989446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12793"},
        {"Hipparcos Number", "HIP 9777"},
        {"Fundamental Katalog 5th Edition", "FK5 4188"},
        {"Smithsonian Astrophysical Observation", "SAO 92787"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.43151358),
        dec: Angle.Degrees(+17.65003592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1919"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.06202475),
        dec: Angle.Degrees(+17.65015689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62652"},
        {"Smithsonian Astrophysical Observation", "SAO 100293"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.55922469),
        dec: Angle.Degrees(+17.65068489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220658"},
        {"Hipparcos Number", "HIP 115635"},
        {"Geneva Identification System", "GEN# +1.00220658"},
        {"Smithsonian Astrophysical Observation", "SAO 108603"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.37737240),
        dec: Angle.Degrees(+17.65128239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81977"},
        {"Hipparcos Number", "HIP 46545"},
        {"Smithsonian Astrophysical Observation", "SAO 98600"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.38728741),
        dec: Angle.Degrees(+17.65187197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30400",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5002 AB"},
        {"Henry Draper", "HD 44635"},
        {"Hipparcos Number", "HIP 30400"},
        {"Smithsonian Astrophysical Observation", "SAO 95615"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.88896532),
        dec: Angle.Degrees(+17.65299757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202303"},
        {"Hipparcos Number", "HIP 104853"},
        {"Smithsonian Astrophysical Observation", "SAO 106949"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.59816094),
        dec: Angle.Degrees(+17.65381585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6758"},
        {"Hipparcos Number", "HIP 5357"},
        {"Geneva Identification System", "GEN# +1.00006758"},
        {"Smithsonian Astrophysical Observation", "SAO 92271"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.12072923),
        dec: Angle.Degrees(+17.65385263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53496"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.15705011),
        dec: Angle.Degrees(+17.65473304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139074"},
        {"Hipparcos Number", "HIP 76337"},
        {"Fundamental Katalog 5th Edition", "FK5 3230"},
        {"Geneva Identification System", "GEN# +1.00139074"},
        {"Smithsonian Astrophysical Observation", "SAO 101631"},
        {"Wilson Evans Batten Catalogue", "WEB 12959"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.88865569),
        dec: Angle.Degrees(+17.65558738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94764"},
        {"Hipparcos Number", "HIP 53494"},
        {"Geneva Identification System", "GEN# +1.00094764"},
        {"Smithsonian Astrophysical Observation", "SAO 99362"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.15207307),
        dec: Angle.Degrees(+17.65566276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212378"},
        {"Hipparcos Number", "HIP 110523"},
        {"Geneva Identification System", "GEN# +1.00212378"},
        {"Smithsonian Astrophysical Observation", "SAO 107877"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.86649590),
        dec: Angle.Degrees(+17.65602105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54211"},
        {"Hipparcos Number", "HIP 34476"},
        {"Geneva Identification System", "GEN# +1.00054211"},
        {"Smithsonian Astrophysical Observation", "SAO 96543"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.18258185),
        dec: Angle.Degrees(+17.65731556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19582"},
        {"Hipparcos Number", "HIP 14683"},
        {"Smithsonian Astrophysical Observation", "SAO 93308"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.42510708),
        dec: Angle.Degrees(+17.66093878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72894"},
    },
    visualMagnitude: 12.05,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.46892280),
        dec: Angle.Degrees(+17.66297362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61168"},
        {"Smithsonian Astrophysical Observation", "SAO 100143"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.01180881),
        dec: Angle.Degrees(+17.66341596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25895"},
        {"Hipparcos Number", "HIP 19187"},
        {"Geneva Identification System", "GEN# +1.00025895"},
        {"Smithsonian Astrophysical Observation", "SAO 93766"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.68438135),
        dec: Angle.Degrees(+17.66349569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43846"},
        {"Smithsonian Astrophysical Observation", "SAO 98234"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.96101093),
        dec: Angle.Degrees(+17.66500624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40961"},
        {"Hipparcos Number", "HIP 28647"},
        {"Smithsonian Astrophysical Observation", "SAO 95157"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.73777908),
        dec: Angle.Degrees(+17.66559998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181903"},
        {"Hipparcos Number", "HIP 95173"},
        {"Wilson Evans Batten Catalogue", "WEB 16626"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.42519445),
        dec: Angle.Degrees(+17.66668102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112120"},
        {"Geneva Identification System", "GEN# +9.80067015"},
    },
    visualMagnitude: 11.78,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.65865688),
        dec: Angle.Degrees(+17.66798381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1106.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 514.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122443"},
        {"Hipparcos Number", "HIP 68516"},
        {"Geneva Identification System", "GEN# +1.00122443"},
        {"Smithsonian Astrophysical Observation", "SAO 100819"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.40349366),
        dec: Angle.Degrees(+17.66859315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63014"},
        {"Geneva Identification System", "GEN# +0.01802675"},
        {"Smithsonian Astrophysical Observation", "SAO 100329"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.70581823),
        dec: Angle.Degrees(+17.67143001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84220"},
        {"Hipparcos Number", "HIP 47745"},
        {"Geneva Identification System", "GEN# +1.00084220"},
        {"Smithsonian Astrophysical Observation", "SAO 98737"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.00408067),
        dec: Angle.Degrees(+17.67345595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49970"},
        {"Hipparcos Number", "HIP 32946"},
        {"Smithsonian Astrophysical Observation", "SAO 96203"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.94056375),
        dec: Angle.Degrees(+17.67377643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230207"},
        {"Hipparcos Number", "HIP 93060"},
        {"Smithsonian Astrophysical Observation", "SAO 104287"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.34566278),
        dec: Angle.Degrees(+17.67420752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61338"},
        {"Hipparcos Number", "HIP 37300"},
        {"Geneva Identification System", "GEN# +1.00061338"},
        {"Smithsonian Astrophysical Observation", "SAO 97120"},
        {"Wilson Evans Batten Catalogue", "WEB 7383"},
    },
    visualMagnitude: 5.04,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.86912974),
        dec: Angle.Degrees(+17.67451551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40342",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6673 AB"},
        {"Henry Draper", "HD 68703"},
        {"Hipparcos Number", "HIP 40342"},
        {"Geneva Identification System", "GEN# +1.00068703J"},
        {"Renson", "Renson 19050"},
        {"Smithsonian Astrophysical Observation", "SAO 97669"},
        {"Wilson Evans Batten Catalogue", "WEB 7868"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.54642043),
        dec: Angle.Degrees(+17.67591954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13870",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2248 AB"},
        {"Henry Draper", "HD 18461"},
        {"Hipparcos Number", "HIP 13870"},
        {"Smithsonian Astrophysical Observation", "SAO 93213"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.66119894),
        dec: Angle.Degrees(+17.67693153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28436"},
        {"Hipparcos Number", "HIP 20971"},
        {"Celescope Catalog", "CEL 413"},
        {"Geneva Identification System", "GEN# +1.00028436J"},
        {"Smithsonian Astrophysical Observation", "SAO 93967"},
        {"Wilson Evans Batten Catalogue", "WEB 4033"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.45050366),
        dec: Angle.Degrees(+17.67761752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161113"},
        {"Hipparcos Number", "HIP 86710"},
        {"Smithsonian Astrophysical Observation", "SAO 103048"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.75831021),
        dec: Angle.Degrees(+17.67917791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38514"},
        {"Smithsonian Astrophysical Observation", "SAO 97331"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.30982710),
        dec: Angle.Degrees(+17.68096504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208609"},
        {"Hipparcos Number", "HIP 108345"},
        {"Geneva Identification System", "GEN# +1.00208609"},
        {"Smithsonian Astrophysical Observation", "SAO 107531"},
        {"Wilson Evans Batten Catalogue", "WEB 19515"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.25897036),
        dec: Angle.Degrees(+17.68198997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219948"},
        {"Hipparcos Number", "HIP 115185"},
        {"Smithsonian Astrophysical Observation", "SAO 108545"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.95561422),
        dec: Angle.Degrees(+17.68393193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231373"},
        {"Hipparcos Number", "HIP 95500"},
        {"Geneva Identification System", "GEN# +1.00231373"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.37317347),
        dec: Angle.Degrees(+17.68441445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50578"},
        {"Hipparcos Number", "HIP 33203"},
        {"Smithsonian Astrophysical Observation", "SAO 96261"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.66474221),
        dec: Angle.Degrees(+17.68441831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9521"},
        {"Hipparcos Number", "HIP 7282"},
        {"Smithsonian Astrophysical Observation", "SAO 92512"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.44643733),
        dec: Angle.Degrees(+17.68528819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177544"},
        {"Hipparcos Number", "HIP 93671"},
        {"Smithsonian Astrophysical Observation", "SAO 104446"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.13466840),
        dec: Angle.Degrees(+17.68585240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97699"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.82903572),
        dec: Angle.Degrees(+17.68696505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153454"},
        {"Hipparcos Number", "HIP 83115"},
        {"Smithsonian Astrophysical Observation", "SAO 102508"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.77042261),
        dec: Angle.Degrees(+17.68830635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43418"},
        {"Smithsonian Astrophysical Observation", "SAO 98160"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.65402199),
        dec: Angle.Degrees(+17.68946714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86724",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10738 A"},
        {"Henry Draper", "HD 161164"},
        {"Hipparcos Number", "HIP 86724"},
        {"Smithsonian Astrophysical Observation", "SAO 103050"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.81701077),
        dec: Angle.Degrees(+17.68969036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65157"},
        {"Hipparcos Number", "HIP 38935"},
        {"Smithsonian Astrophysical Observation", "SAO 97419"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.50080492),
        dec: Angle.Degrees(+17.68993486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38506"},
        {"Smithsonian Astrophysical Observation", "SAO 97329"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.27946198),
        dec: Angle.Degrees(+17.69031904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1084"},
        {"Hipparcos Number", "HIP 1214"},
        {"Smithsonian Astrophysical Observation", "SAO 91799"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.79098059),
        dec: Angle.Degrees(+17.69164570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353300"},
        {"Hipparcos Number", "HIP 103236"},
        {"Geneva Identification System", "GEN# +1.00353300"},
        {"Smithsonian Astrophysical Observation", "SAO 106648"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.72246049),
        dec: Angle.Degrees(+17.69193915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46747"},
        {"Hipparcos Number", "HIP 31508"},
        {"Smithsonian Astrophysical Observation", "SAO 95883"},
        {"Wilson Evans Batten Catalogue", "WEB 6300"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.97421845),
        dec: Angle.Degrees(+17.69255159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61107"},
        {"Geneva Identification System", "GEN# +0.01802621"},
        {"Smithsonian Astrophysical Observation", "SAO 100137"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.85237480),
        dec: Angle.Degrees(+17.69310464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67444"},
        {"Smithsonian Astrophysical Observation", "SAO 100723"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.33381115),
        dec: Angle.Degrees(+17.69346059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183755"},
        {"Hipparcos Number", "HIP 95919"},
        {"Smithsonian Astrophysical Observation", "SAO 104913"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.60528066),
        dec: Angle.Degrees(+17.69523606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3253"},
        {"Smithsonian Astrophysical Observation", "SAO 92029"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.36095484),
        dec: Angle.Degrees(+17.69680063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87044",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10795 AB"},
        {"Henry Draper", "HD 161833"},
        {"Hipparcos Number", "HIP 87044"},
        {"Geneva Identification System", "GEN# +1.00161833J"},
        {"Smithsonian Astrophysical Observation", "SAO 103106"},
        {"Wilson Evans Batten Catalogue", "WEB 14683"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.78349746),
        dec: Angle.Degrees(+17.69704078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111845"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.81917694),
        dec: Angle.Degrees(+17.69711269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352914"},
        {"Hipparcos Number", "HIP 102361"},
        {"Geneva Identification System", "GEN# +1.00352914"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.10562677),
        dec: Angle.Degrees(+17.69730485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110822"},
        {"Hipparcos Number", "HIP 62188"},
        {"Geneva Identification System", "GEN# +1.00110822"},
        {"Smithsonian Astrophysical Observation", "SAO 100232"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.17781721),
        dec: Angle.Degrees(+17.70048289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131783"},
        {"Hipparcos Number", "HIP 72996"},
        {"Smithsonian Astrophysical Observation", "SAO 101283"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.77834817),
        dec: Angle.Degrees(+17.70154548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22485"},
        {"Geneva Identification System", "GEN# +6.20004001"},
    },
    visualMagnitude: 12.66,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.55635641),
        dec: Angle.Degrees(+17.70170296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47468"},
        {"Hipparcos Number", "HIP 31857"},
        {"Smithsonian Astrophysical Observation", "SAO 95955"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.89744593),
        dec: Angle.Degrees(+17.70302745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15596"},
        {"Hipparcos Number", "HIP 11698"},
        {"Fundamental Katalog 5th Edition", "FK5 1069"},
        {"Geneva Identification System", "GEN# +1.00015596"},
        {"Smithsonian Astrophysical Observation", "SAO 92983"},
        {"Wilson Evans Batten Catalogue", "WEB 2432"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.72657571),
        dec: Angle.Degrees(+17.70405706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80218"},
        {"Hipparcos Number", "HIP 45699"},
        {"Fundamental Katalog 5th Edition", "FK5 350"},
        {"Geneva Identification System", "GEN# +1.00080218"},
        {"Smithsonian Astrophysical Observation", "SAO 98488"},
        {"Wilson Evans Batten Catalogue", "WEB 8676"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.74545459),
        dec: Angle.Degrees(+17.70568032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89363"},
        {"Hipparcos Number", "HIP 50508"},
        {"Geneva Identification System", "GEN# +1.00089363"},
        {"Smithsonian Astrophysical Observation", "SAO 99056"},
        {"Wilson Evans Batten Catalogue", "WEB 9267"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.73956327),
        dec: Angle.Degrees(+17.70593296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150393"},
        {"Hipparcos Number", "HIP 81618"},
        {"Smithsonian Astrophysical Observation", "SAO 102305"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.05106355),
        dec: Angle.Degrees(+17.70719562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28634"},
        {"Hipparcos Number", "HIP 21123"},
        {"Geneva Identification System", "GEN# +5.20253285"},
        {"Geneva Identification System 2", "GEN# +5.20251627"},
        {"Wilson Evans Batten Catalogue", "WEB 4062"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.90432476),
        dec: Angle.Degrees(+17.70985241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187596"},
        {"Hipparcos Number", "HIP 97599"},
        {"Smithsonian Astrophysical Observation", "SAO 105329"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.56302289),
        dec: Angle.Degrees(+17.71002610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81193"},
        {"Hipparcos Number", "HIP 46149"},
        {"Smithsonian Astrophysical Observation", "SAO 98554"},
        {"Wilson Evans Batten Catalogue", "WEB 8738"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.17477629),
        dec: Angle.Degrees(+17.71058246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16706",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2624 AB"},
        {"Hipparcos Number", "HIP 16706"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.74376659),
        dec: Angle.Degrees(+17.71066842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76316"},
        {"Cincinnati Publication", "Ci 20 937"},
        {"Geneva Identification System", "GEN# +9.80137026"},
    },
    visualMagnitude: 12.41,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)35, 20.0500),
        dec: Angle.DegreesMinutesSeconds((int)+17, (int)42, 46.200)
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
    primaryId: "HIP 56973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101485"},
        {"Hipparcos Number", "HIP 56973"},
        {"Cincinnati Publication", "Ci 18 1444"},
        {"Geneva Identification System", "GEN# +1.00101485"},
        {"Smithsonian Astrophysical Observation", "SAO 99729"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.19046544),
        dec: Angle.Degrees(+17.71430448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123930"},
        {"Hipparcos Number", "HIP 69208"},
        {"Geneva Identification System", "GEN# +1.00123930"},
        {"Smithsonian Astrophysical Observation", "SAO 100889"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.53851990),
        dec: Angle.Degrees(+17.71700834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134549"},
        {"Hipparcos Number", "HIP 74212"},
        {"Smithsonian Astrophysical Observation", "SAO 101409"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.48221288),
        dec: Angle.Degrees(+17.71815679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12142"},
    },
    visualMagnitude: 12.33,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.12873657),
        dec: Angle.Degrees(+17.71848889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202907"},
        {"Hipparcos Number", "HIP 105179"},
        {"Fundamental Katalog 5th Edition", "FK5 5879"},
        {"Geneva Identification System", "GEN# +1.00202907"},
        {"Smithsonian Astrophysical Observation", "SAO 107014"},
        {"Wilson Evans Batten Catalogue", "WEB 19099"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.60516547),
        dec: Angle.Degrees(+17.72083657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50882"},
    },
    visualMagnitude: 11.65,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.84999824),
        dec: Angle.Degrees(+17.72157686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205144"},
        {"Hipparcos Number", "HIP 106401"},
        {"Smithsonian Astrophysical Observation", "SAO 107226"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.26014428),
        dec: Angle.Degrees(+17.72287548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15724"},
        {"Smithsonian Astrophysical Observation", "SAO 93405"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.63562659),
        dec: Angle.Degrees(+17.72542463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66320"},
        {"Hipparcos Number", "HIP 39434"},
        {"Smithsonian Astrophysical Observation", "SAO 97518"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.91692526),
        dec: Angle.Degrees(+17.72592432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5481"},
        {"Hipparcos Number", "HIP 4435"},
        {"Geneva Identification System", "GEN# +1.00005481"},
        {"Smithsonian Astrophysical Observation", "SAO 92169"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.18724045),
        dec: Angle.Degrees(+17.72607351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173564"},
        {"Hipparcos Number", "HIP 92015"},
        {"Geneva Identification System", "GEN# +1.00173564"},
        {"Smithsonian Astrophysical Observation", "SAO 104062"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.32659600),
        dec: Angle.Degrees(+17.72737141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60091",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8508 AB"},
        {"Henry Draper", "HD 107169"},
        {"Hipparcos Number", "HIP 60091"},
        {"Smithsonian Astrophysical Observation", "SAO 100040"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.84281040),
        dec: Angle.Degrees(+17.72878691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38558"},
        {"Hipparcos Number", "HIP 27338"},
        {"Fundamental Katalog 5th Edition", "FK5 218"},
        {"Geneva Identification System", "GEN# +1.00038558"},
        {"Smithsonian Astrophysical Observation", "SAO 94858"},
        {"Wilson Evans Batten Catalogue", "WEB 5373"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.85915586),
        dec: Angle.Degrees(+17.72915270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62078"},
        {"Geneva Identification System", "GEN# +0.01802652"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.84339146),
        dec: Angle.Degrees(+17.82848066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201891"},
        {"Hipparcos Number", "HIP 104659"},
        {"Cincinnati Publication", "Ci 20 1266"},
        {"Geneva Identification System", "GEN# +1.00201891"},
        {"Smithsonian Astrophysical Observation", "SAO 106908"},
        {"Wilson Evans Batten Catalogue", "WEB 19042"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.99627899),
        dec: Angle.Degrees(+17.72993320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -898.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247530"},
        {"Hipparcos Number", "HIP 27301"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.76412170),
        dec: Angle.Degrees(+17.73060406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83425"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.77321176),
        dec: Angle.Degrees(+17.73124721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -335.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59130"},
        {"Smithsonian Astrophysical Observation", "SAO 99952"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.88108172),
        dec: Angle.Degrees(+17.73149977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90996",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11454 ABC"},
        {"Henry Draper", "HD 171365"},
        {"Hipparcos Number", "HIP 90996"},
        {"Smithsonian Astrophysical Observation", "SAO 103853"},
        {"Wilson Evans Batten Catalogue", "WEB 15611"},
    },
    visualMagnitude: 7.08,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.44008436),
        dec: Angle.Degrees(+17.73220100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85198"},
        {"Hipparcos Number", "HIP 48288"},
        {"Geneva Identification System", "GEN# +1.00085198"},
        {"Smithsonian Astrophysical Observation", "SAO 98802"},
        {"Wilson Evans Batten Catalogue", "WEB 9007"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.67634379),
        dec: Angle.Degrees(+17.73348252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348731"},
        {"Hipparcos Number", "HIP 90420"},
        {"Smithsonian Astrophysical Observation", "SAO 103724"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.73739859),
        dec: Angle.Degrees(+17.73402832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18091"},
        {"Hipparcos Number", "HIP 13579"},
        {"Smithsonian Astrophysical Observation", "SAO 93178"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.72988219),
        dec: Angle.Degrees(+17.73481468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190405"},
        {"Hipparcos Number", "HIP 98835"},
        {"Geneva Identification System", "GEN# +1.00190405"},
        {"Smithsonian Astrophysical Observation", "SAO 105638"},
        {"Wilson Evans Batten Catalogue", "WEB 17525"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.05880990),
        dec: Angle.Degrees(+17.73487414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62533"},
        {"Smithsonian Astrophysical Observation", "SAO 100282"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.21506984),
        dec: Angle.Degrees(+17.73497490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231109"},
        {"Hipparcos Number", "HIP 94881"},
        {"Smithsonian Astrophysical Observation", "SAO 104701"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.62605933),
        dec: Angle.Degrees(+17.73603979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87774"},
        {"Hipparcos Number", "HIP 49622"},
        {"Smithsonian Astrophysical Observation", "SAO 98958"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.90600285),
        dec: Angle.Degrees(+17.73654597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50974"},
        {"Hipparcos Number", "HIP 33358"},
        {"Smithsonian Astrophysical Observation", "SAO 96288"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.06890850),
        dec: Angle.Degrees(+17.73723949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96372"},
        {"Hipparcos Number", "HIP 54319"},
        {"Fundamental Katalog 5th Edition", "FK5 2887"},
        {"Geneva Identification System", "GEN# +1.00096372"},
        {"Smithsonian Astrophysical Observation", "SAO 99444"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.68338781),
        dec: Angle.Degrees(+17.73742595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210617"},
        {"Hipparcos Number", "HIP 109532"},
        {"Geneva Identification System", "GEN# +1.00210617"},
        {"Smithsonian Astrophysical Observation", "SAO 107720"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.81146706),
        dec: Angle.Degrees(+17.73940407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50305",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7704 AB"},
        {"Henry Draper", "HD 88987"},
        {"Hipparcos Number", "HIP 50305"},
        {"Smithsonian Astrophysical Observation", "SAO 99032"},
        {"Wilson Evans Batten Catalogue", "WEB 9238"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.06687668),
        dec: Angle.Degrees(+17.74034024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120313"},
        {"Geneva Identification System", "GEN# +0.01802777"},
        {"Smithsonian Astrophysical Observation", "SAO 100694"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.39869287),
        dec: Angle.Degrees(+17.74244224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36407"},
        {"Hipparcos Number", "HIP 25959"},
        {"Geneva Identification System", "GEN# +1.00036407"},
        {"Smithsonian Astrophysical Observation", "SAO 94633"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.07524948),
        dec: Angle.Degrees(+17.74373650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21141"},
        {"Hipparcos Number", "HIP 15954"},
        {"Smithsonian Astrophysical Observation", "SAO 93424"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.35079509),
        dec: Angle.Degrees(+17.74401108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53588"},
        {"Hipparcos Number", "HIP 34273"},
        {"Smithsonian Astrophysical Observation", "SAO 96487"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.57256569),
        dec: Angle.Degrees(+17.74441270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45580"},
        {"Hipparcos Number", "HIP 30890"},
        {"Cincinnati Publication", "Ci 18 806"},
        {"Geneva Identification System", "GEN# +1.00045580"},
        {"Smithsonian Astrophysical Observation", "SAO 95730"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.26571860),
        dec: Angle.Degrees(+17.74562999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8075"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.93203586),
        dec: Angle.Degrees(+17.74630973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17466"},
        {"Smithsonian Astrophysical Observation", "SAO 93574"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.14317539),
        dec: Angle.Degrees(+17.74739203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73085"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.05413514),
        dec: Angle.Degrees(+17.74805627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -188.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28991"},
        {"Hipparcos Number", "HIP 21332"},
        {"Geneva Identification System", "GEN# +5.20251751"},
        {"Smithsonian Astrophysical Observation", "SAO 94015"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.67569115),
        dec: Angle.Degrees(+17.74826638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30264"},
        {"Hipparcos Number", "HIP 22224"},
        {"Geneva Identification System", "GEN# +5.20252092"},
        {"Smithsonian Astrophysical Observation", "SAO 94117"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.70581299),
        dec: Angle.Degrees(+17.74840598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100150"},
        {"Hipparcos Number", "HIP 56219"},
        {"Geneva Identification System", "GEN# +1.00100150"},
        {"Smithsonian Astrophysical Observation", "SAO 99645"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.88236240),
        dec: Angle.Degrees(+17.74988542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43151"},
        {"Hipparcos Number", "HIP 29707"},
        {"Geneva Identification System", "GEN# +1.00043151"},
        {"Smithsonian Astrophysical Observation", "SAO 95448"},
        {"Wilson Evans Batten Catalogue", "WEB 5854"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.86623415),
        dec: Angle.Degrees(+17.75020706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81443"},
        {"Smithsonian Astrophysical Observation", "SAO 102281"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.51085912),
        dec: Angle.Degrees(+17.75127189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29543"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.38038145),
        dec: Angle.Degrees(+17.75233626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -308.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182010"},
        {"Hipparcos Number", "HIP 95204"},
        {"Fundamental Katalog 5th Edition", "FK5 5704"},
        {"Geneva Identification System", "GEN# +1.00182010"},
        {"Smithsonian Astrophysical Observation", "SAO 104771"},
        {"Wilson Evans Batten Catalogue", "WEB 16633"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.51617810),
        dec: Angle.Degrees(+17.75340568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52554"},
        {"Hipparcos Number", "HIP 33929"},
        {"Fundamental Katalog 5th Edition", "FK5 2543"},
        {"Geneva Identification System", "GEN# +1.00052554"},
        {"Smithsonian Astrophysical Observation", "SAO 96407"},
        {"Wilson Evans Batten Catalogue", "WEB 6808"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.60634028),
        dec: Angle.Degrees(+17.75545510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130385"},
        {"Hipparcos Number", "HIP 72328"},
        {"Fundamental Katalog 5th Edition", "FK5 5309"},
        {"Geneva Identification System", "GEN# +1.00130385"},
        {"Smithsonian Astrophysical Observation", "SAO 101215"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.85134432),
        dec: Angle.Degrees(+17.75718232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16791"},
        {"Hipparcos Number", "HIP 12603"},
        {"Geneva Identification System", "GEN# +1.00016791"},
        {"Smithsonian Astrophysical Observation", "SAO 93057"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.51000597),
        dec: Angle.Degrees(+17.75732958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243673"},
        {"Hipparcos Number", "HIP 25446"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.63714694),
        dec: Angle.Degrees(+17.75763351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44234"},
        {"Hipparcos Number", "HIP 30218"},
        {"Smithsonian Astrophysical Observation", "SAO 95572"},
        {"Wilson Evans Batten Catalogue", "WEB 6007"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.35797171),
        dec: Angle.Degrees(+17.76360611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17017"},
        {"Hipparcos Number", "HIP 12784"},
        {"Fundamental Katalog 5th Edition", "FK5 2190"},
        {"Geneva Identification System", "GEN# +1.00017017"},
        {"Smithsonian Astrophysical Observation", "SAO 93081"},
        {"Wilson Evans Batten Catalogue", "WEB 2600"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.07954256),
        dec: Angle.Degrees(+17.76401488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65205",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8871 A"},
        {"Henry Draper", "HD 116206"},
        {"Hipparcos Number", "HIP 65205"},
        {"Geneva Identification System", "GEN# +1.00116206"},
        {"Smithsonian Astrophysical Observation", "SAO 100534"},
        {"Wilson Evans Batten Catalogue", "WEB 11509"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.45289784),
        dec: Angle.Degrees(+17.76551213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65069",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8863 AB"},
        {"Henry Draper", "HD 115955"},
        {"Hipparcos Number", "HIP 65069"},
        {"Smithsonian Astrophysical Observation", "SAO 100517"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.06575996),
        dec: Angle.Degrees(+17.76603081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84110"},
        {"Hipparcos Number", "HIP 47667"},
        {"Geneva Identification System", "GEN# +1.00084110"},
        {"Smithsonian Astrophysical Observation", "SAO 98726"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.79787566),
        dec: Angle.Degrees(+17.76663528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42531"},
        {"Hipparcos Number", "HIP 29430"},
        {"Celescope Catalog", "CEL 1113"},
        {"Geneva Identification System", "GEN# +1.00042531"},
        {"Smithsonian Astrophysical Observation", "SAO 95360"},
        {"Wilson Evans Batten Catalogue", "WEB 5781"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.99465182),
        dec: Angle.Degrees(+17.76778603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112642"},
        {"Hipparcos Number", "HIP 63283"},
        {"Geneva Identification System", "GEN# +1.00112642"},
        {"Smithsonian Astrophysical Observation", "SAO 100351"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.52629837),
        dec: Angle.Degrees(+17.76831190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105783"},
        {"Smithsonian Astrophysical Observation", "SAO 107127"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.35987963),
        dec: Angle.Degrees(+17.76913813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114265"},
        {"Hipparcos Number", "HIP 64186"},
        {"Cincinnati Publication", "Ci 20 761"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.32069259),
        dec: Angle.Degrees(+17.77022627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 220.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68253"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.59617753),
        dec: Angle.Degrees(+17.77034001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79723"},
        {"Smithsonian Astrophysical Observation", "SAO 102050"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.06784331),
        dec: Angle.Degrees(+17.77226485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116344"},
        {"Hipparcos Number", "HIP 65293"},
        {"Geneva Identification System", "GEN# +1.00116344"},
        {"Smithsonian Astrophysical Observation", "SAO 100538"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.72588190),
        dec: Angle.Degrees(+17.77581697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17983"},
        {"Smithsonian Astrophysical Observation", "SAO 93632"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.65671880),
        dec: Angle.Degrees(+17.77667551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146872"},
        {"Hipparcos Number", "HIP 79848"},
        {"Smithsonian Astrophysical Observation", "SAO 102067"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.46533558),
        dec: Angle.Degrees(+17.77697545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31156",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5166 B"},
        {"Henry Draper", "HD 46136B"},
        {"Hipparcos Number", "HIP 31156"},
        {"Geneva Identification System", "GEN# +1.00046136B"},
        {"Smithsonian Astrophysical Observation", "SAO 95794"},
        {"Wilson Evans Batten Catalogue", "WEB 6225"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.07419134),
        dec: Angle.Degrees(+17.77954618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24861"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.94525687),
        dec: Angle.Degrees(+17.77984911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131302"},
        {"Hipparcos Number", "HIP 72748"},
        {"Smithsonian Astrophysical Observation", "SAO 101262"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.08613204),
        dec: Angle.Degrees(+17.78134859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286320"},
        {"Hipparcos Number", "HIP 23642"},
        {"Smithsonian Astrophysical Observation", "SAO 94295"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.22394563),
        dec: Angle.Degrees(+17.78278660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96037",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12557 AB"},
        {"Henry Draper", "HD 231683"},
        {"Hipparcos Number", "HIP 96037"},
        {"Geneva Identification System", "GEN# +1.00231683"},
        {"Smithsonian Astrophysical Observation", "SAO 104937"},
        {"Wilson Evans Batten Catalogue", "WEB 16823"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.90751726),
        dec: Angle.Degrees(+17.78323706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8489"},
    },
    visualMagnitude: 11.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.36136196),
        dec: Angle.Degrees(+17.78356119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31158",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5166 A"},
        {"Henry Draper", "HD 46136"},
        {"Hipparcos Number", "HIP 31158"},
        {"Geneva Identification System", "GEN# +1.00046136A"},
        {"Smithsonian Astrophysical Observation", "SAO 95795"},
        {"Wilson Evans Batten Catalogue", "WEB 6219"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.07717921),
        dec: Angle.Degrees(+17.78428626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213722"},
        {"Hipparcos Number", "HIP 111324"},
        {"Geneva Identification System", "GEN# +1.00213722"},
        {"Smithsonian Astrophysical Observation", "SAO 107995"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.30502484),
        dec: Angle.Degrees(+17.78511044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14107"},
        {"Hipparcos Number", "HIP 10666"},
        {"Smithsonian Astrophysical Observation", "SAO 92869"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.31185478),
        dec: Angle.Degrees(+17.78598554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67090"},
        {"Cincinnati Publication", "Ci 18 1784"},
        {"Cincinnati Publication 2", "Ci 20 801"},
        {"Geneva Identification System", "GEN# +0.01802776"},
        {"Smithsonian Astrophysical Observation", "SAO 100686"},
        {"Wilson Evans Batten Catalogue", "WEB 11814"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.27001884),
        dec: Angle.Degrees(+17.78989211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 451.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1831.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79995"},
        {"Smithsonian Astrophysical Observation", "SAO 102090"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.94434268),
        dec: Angle.Degrees(+17.79061921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60202",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8521 A"},
        {"Henry Draper", "HD 107383"},
        {"Hipparcos Number", "HIP 60202"},
        {"Fundamental Katalog 5th Edition", "FK5 2987"},
        {"Geneva Identification System", "GEN# +1.00107383"},
        {"Smithsonian Astrophysical Observation", "SAO 100053"},
        {"Wilson Evans Batten Catalogue", "WEB 10703"},
    },
    visualMagnitude: 4.72,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.17955477),
        dec: Angle.Degrees(+17.79265307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193579"},
        {"Hipparcos Number", "HIP 100276"},
        {"Geneva Identification System", "GEN# +1.00193579"},
        {"Smithsonian Astrophysical Observation", "SAO 105991"},
        {"Wilson Evans Batten Catalogue", "WEB 18085"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.08915240),
        dec: Angle.Degrees(+17.79300261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63542"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.31612645),
        dec: Angle.Degrees(+17.79474592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216635"},
        {"Hipparcos Number", "HIP 113105"},
        {"Geneva Identification System", "GEN# +1.00216635"},
        {"Smithsonian Astrophysical Observation", "SAO 108242"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.57533946),
        dec: Angle.Degrees(+17.79505549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154844"},
        {"Hipparcos Number", "HIP 83771"},
        {"Geneva Identification System", "GEN# +1.00154844"},
        {"Smithsonian Astrophysical Observation", "SAO 102601"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.81327522),
        dec: Angle.Degrees(+17.79588752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247685"},
        {"Henry Draper 2", "HD 247686"},
        {"Hipparcos Number", "HIP 27374"},
        {"Smithsonian Astrophysical Observation", "SAO 94865"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.96989539),
        dec: Angle.Degrees(+17.79671791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216775"},
        {"Hipparcos Number", "HIP 113206"},
        {"Geneva Identification System", "GEN# +1.00216775"},
        {"Smithsonian Astrophysical Observation", "SAO 108260"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.87873808),
        dec: Angle.Degrees(+17.79672221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104393",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14683 AB"},
        {"Hipparcos Number", "HIP 104393"},
        {"Smithsonian Astrophysical Observation", "SAO 106876"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.23135675),
        dec: Angle.Degrees(+17.79721423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119083"},
        {"Hipparcos Number", "HIP 66745"},
        {"Geneva Identification System", "GEN# +1.00119083"},
        {"Smithsonian Astrophysical Observation", "SAO 100661"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.20001465),
        dec: Angle.Degrees(+17.80080816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156129"},
        {"Hipparcos Number", "HIP 84385"},
        {"Smithsonian Astrophysical Observation", "SAO 102689"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.78293349),
        dec: Angle.Degrees(+17.80152160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144149"},
        {"Hipparcos Number", "HIP 78690"},
        {"Smithsonian Astrophysical Observation", "SAO 101900"},
        {"Wilson Evans Batten Catalogue", "WEB 13302"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.95770182),
        dec: Angle.Degrees(+17.80273069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186932"},
        {"Hipparcos Number", "HIP 97317"},
        {"Geneva Identification System", "GEN# +1.00186932"},
        {"Smithsonian Astrophysical Observation", "SAO 105240"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.65753275),
        dec: Angle.Degrees(+17.80303663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73599"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.66080668),
        dec: Angle.Degrees(+17.80542861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153601"},
        {"Hipparcos Number", "HIP 83170"},
        {"Geneva Identification System", "GEN# +1.00153601"},
        {"Smithsonian Astrophysical Observation", "SAO 102519"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.96344708),
        dec: Angle.Degrees(+17.80613446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11532",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11532"},
        {"Geneva Identification System", "GEN# +0.01700372"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.17202429),
        dec: Angle.Degrees(+17.80640658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145771"},
        {"Hipparcos Number", "HIP 79389"},
        {"Smithsonian Astrophysical Observation", "SAO 102002"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.03719709),
        dec: Angle.Degrees(+17.80778074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159609"},
        {"Hipparcos Number", "HIP 86029"},
        {"Smithsonian Astrophysical Observation", "SAO 102934"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.72148965),
        dec: Angle.Degrees(+17.80877698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21796"},
        {"Hipparcos Number", "HIP 16416"},
        {"Smithsonian Astrophysical Observation", "SAO 93474"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.85186497),
        dec: Angle.Degrees(+17.81136834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22330"},
        {"Hipparcos Number", "HIP 16802"},
        {"Geneva Identification System", "GEN# +1.00022330"},
        {"Smithsonian Astrophysical Observation", "SAO 93505"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.06944654),
        dec: Angle.Degrees(+17.81208060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215775"},
        {"Hipparcos Number", "HIP 112506"},
        {"Cincinnati Publication", "Ci 18 2975"},
        {"Geneva Identification System", "GEN# +1.00215775"},
        {"Smithsonian Astrophysical Observation", "SAO 108177"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.84099372),
        dec: Angle.Degrees(+17.81311922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2689"},
        {"Hipparcos Number", "HIP 2402"},
        {"Smithsonian Astrophysical Observation", "SAO 91931"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.65321275),
        dec: Angle.Degrees(+17.81324351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18405"},
        {"Hipparcos Number", "HIP 13824"},
        {"Smithsonian Astrophysical Observation", "SAO 93209"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.47835834),
        dec: Angle.Degrees(+17.81342363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55513"},
        {"Smithsonian Astrophysical Observation", "SAO 99575"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.54615127),
        dec: Angle.Degrees(+17.81478397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28348",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4571 A"},
        {"Henry Draper", "HD 40412"},
        {"Hipparcos Number", "HIP 28348"},
        {"Geneva Identification System", "GEN# +1.00040412"},
        {"Smithsonian Astrophysical Observation", "SAO 95084"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.85200449),
        dec: Angle.Degrees(+17.81497159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188103"},
        {"Hipparcos Number", "HIP 97842"},
        {"Geneva Identification System", "GEN# +1.00188103"},
        {"Renson", "Renson 51940"},
        {"Smithsonian Astrophysical Observation", "SAO 105376"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.23749103),
        dec: Angle.Degrees(+17.81508626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120002",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4571 B"},
        {"Hipparcos Number", "HIP 120002"},
    },
    visualMagnitude: 10.48,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.85472733),
        dec: Angle.Degrees(+17.81640979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240648"},
        {"Hipparcos Number", "HIP 23750"},
        {"Geneva Identification System", "GEN# +0.01700841"},
        {"Geneva Identification System 2", "GEN# +1.00240648"},
        {"Smithsonian Astrophysical Observation", "SAO 94315"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.57479047),
        dec: Angle.Degrees(+17.81649215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11909"},
        {"Hipparcos Number", "HIP 9110"},
        {"Fundamental Katalog 5th Edition", "FK5 2132"},
        {"Geneva Identification System", "GEN# +1.00011909"},
        {"Smithsonian Astrophysical Observation", "SAO 92721"},
        {"Wilson Evans Batten Catalogue", "WEB 1911"},
    },
    visualMagnitude: 5.09,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.33763922),
        dec: Angle.Degrees(+17.81758940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143666"},
        {"Hipparcos Number", "HIP 78481"},
        {"Fundamental Katalog 5th Edition", "FK5 3263"},
        {"Geneva Identification System", "GEN# +1.00143666"},
        {"Smithsonian Astrophysical Observation", "SAO 101879"},
        {"Wilson Evans Batten Catalogue", "WEB 13270"},
    },
    visualMagnitude: 5.10,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.30977487),
        dec: Angle.Degrees(+17.81802578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 152.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8442"},
        {"Hipparcos Number", "HIP 6527"},
        {"Geneva Identification System", "GEN# +1.00008442"},
        {"Smithsonian Astrophysical Observation", "SAO 92413"},
        {"Wilson Evans Batten Catalogue", "WEB 1439"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.96176069),
        dec: Angle.Degrees(+17.81844369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116277",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16830 A"},
        {"Henry Draper", "HD 221627"},
        {"Hipparcos Number", "HIP 116277"},
        {"Geneva Identification System", "GEN# +1.00221627A"},
        {"Smithsonian Astrophysical Observation", "SAO 108677"},
        {"Wilson Evans Batten Catalogue", "WEB 20548"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.39433175),
        dec: Angle.Degrees(+17.81877104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 255.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111745"},
        {"Smithsonian Astrophysical Observation", "SAO 108057"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.54024808),
        dec: Angle.Degrees(+17.82011870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203015"},
        {"Hipparcos Number", "HIP 105254"},
        {"Geneva Identification System", "GEN# +1.00203015"},
        {"Smithsonian Astrophysical Observation", "SAO 107024"},
        {"Wilson Evans Batten Catalogue", "WEB 19117"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.79670939),
        dec: Angle.Degrees(+17.82238433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 351654"},
        {"Hipparcos Number", "HIP 99328"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.41547735),
        dec: Angle.Degrees(+17.82313510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169191"},
        {"Hipparcos Number", "HIP 90067"},
        {"Fundamental Katalog 5th Edition", "FK5 3460"},
        {"Geneva Identification System", "GEN# +1.00169191"},
        {"Smithsonian Astrophysical Observation", "SAO 103655"},
        {"Wilson Evans Batten Catalogue", "WEB 15395"},
    },
    visualMagnitude: 5.25,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.70414875),
        dec: Angle.Degrees(+17.82657724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95112"},
        {"Hipparcos Number", "HIP 53693"},
        {"Smithsonian Astrophysical Observation", "SAO 99387"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.78441985),
        dec: Angle.Degrees(+17.82688221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149346"},
        {"Hipparcos Number", "HIP 81068"},
        {"Geneva Identification System", "GEN# +1.00149346"},
        {"Smithsonian Astrophysical Observation", "SAO 102243"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.37561172),
        dec: Angle.Degrees(+17.82875701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192915"},
        {"Hipparcos Number", "HIP 99958"},
        {"Smithsonian Astrophysical Observation", "SAO 105921"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.21162878),
        dec: Angle.Degrees(+17.82921772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7626"},
        {"Geneva Identification System", "GEN# +0.01700235"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.55843066),
        dec: Angle.Degrees(+17.82981045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 251.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156206"},
        {"Hipparcos Number", "HIP 84422"},
        {"Smithsonian Astrophysical Observation", "SAO 102694"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.89283923),
        dec: Angle.Degrees(+17.83177061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162916"},
        {"Hipparcos Number", "HIP 87515"},
        {"Geneva Identification System", "GEN# +1.00162916"},
        {"Smithsonian Astrophysical Observation", "SAO 103172"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.20494355),
        dec: Angle.Degrees(+17.83322240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22072"},
        {"Hipparcos Number", "HIP 16641"},
        {"Geneva Identification System", "GEN# +1.00022072"},
        {"Smithsonian Astrophysical Observation", "SAO 93494"},
        {"Wilson Evans Batten Catalogue", "WEB 3174"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.53466813),
        dec: Angle.Degrees(+17.83358303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -310.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71053"},
        {"Hipparcos Number", "HIP 41326"},
        {"Geneva Identification System", "GEN# +1.00071053"},
        {"Smithsonian Astrophysical Observation", "SAO 97807"},
        {"Wilson Evans Batten Catalogue", "WEB 7997"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.47906487),
        dec: Angle.Degrees(+17.83363690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108468"},
        {"Hipparcos Number", "HIP 60790"},
        {"Fundamental Katalog 5th Edition", "FK5 5098"},
        {"Geneva Identification System", "GEN# +1.00108468"},
        {"Smithsonian Astrophysical Observation", "SAO 100104"},
        {"Wilson Evans Batten Catalogue", "WEB 10815"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.88798384),
        dec: Angle.Degrees(+17.83440184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42068"},
        {"Hipparcos Number", "HIP 29189"},
        {"Geneva Identification System", "GEN# +1.00042068"},
        {"Smithsonian Astrophysical Observation", "SAO 95299"},
        {"Wilson Evans Batten Catalogue", "WEB 5721"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.36270555),
        dec: Angle.Degrees(+17.83450766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285554"},
        {"Hipparcos Number", "HIP 19651"},
        {"Smithsonian Astrophysical Observation", "SAO 93811"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.15894646),
        dec: Angle.Degrees(+17.83467372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5945"},
        {"Hipparcos Number", "HIP 4751"},
        {"Geneva Identification System", "GEN# +1.00005945"},
        {"Smithsonian Astrophysical Observation", "SAO 92203"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.27171893),
        dec: Angle.Degrees(+17.83810691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101241"},
        {"Hipparcos Number", "HIP 56840"},
        {"Geneva Identification System", "GEN# +1.00101241"},
        {"Smithsonian Astrophysical Observation", "SAO 99714"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.79286118),
        dec: Angle.Degrees(+17.83829394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151354"},
        {"Hipparcos Number", "HIP 82103"},
        {"Smithsonian Astrophysical Observation", "SAO 102374"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.56317918),
        dec: Angle.Degrees(+17.83855529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187944"},
        {"Hipparcos Number", "HIP 97758"},
        {"Geneva Identification System", "GEN# +1.00187944"},
        {"Smithsonian Astrophysical Observation", "SAO 105350"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.99761113),
        dec: Angle.Degrees(+17.83858134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198269"},
        {"Hipparcos Number", "HIP 102706"},
        {"Geneva Identification System", "GEN# +1.00198269"},
        {"Smithsonian Astrophysical Observation", "SAO 106516"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.15298532),
        dec: Angle.Degrees(+17.84002568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 482",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 56"},
        {"Henry Draper", "HD 85"},
        {"Hipparcos Number", "HIP 482"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.43504635),
        dec: Angle.Degrees(+17.84032678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61079"},
        {"Hipparcos Number", "HIP 37160"},
        {"Smithsonian Astrophysical Observation", "SAO 97099"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.54983479),
        dec: Angle.Degrees(+17.84126017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86326"},
        {"Smithsonian Astrophysical Observation", "SAO 102988"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.58183823),
        dec: Angle.Degrees(+17.84174917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219526"},
        {"Hipparcos Number", "HIP 114893"},
        {"Geneva Identification System", "GEN# +1.00219526"},
        {"Smithsonian Astrophysical Observation", "SAO 108502"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.08322959),
        dec: Angle.Degrees(+17.84249831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107175"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.63731257),
        dec: Angle.Degrees(+17.84258118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 264.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177304"},
        {"Hipparcos Number", "HIP 93562"},
        {"Smithsonian Astrophysical Observation", "SAO 104416"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.85064099),
        dec: Angle.Degrees(+17.84465321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117188"},
        {"Hipparcos Number", "HIP 65720"},
        {"Geneva Identification System", "GEN# +1.00117188"},
        {"Smithsonian Astrophysical Observation", "SAO 100581"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.10045969),
        dec: Angle.Degrees(+17.84645681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183262"},
        {"Hipparcos Number", "HIP 95717"},
        {"Geneva Identification System", "GEN# +1.00183262"},
        {"Renson", "Renson 50630"},
        {"Smithsonian Astrophysical Observation", "SAO 104871"},
        {"Wilson Evans Batten Catalogue", "WEB 16748"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.02618892),
        dec: Angle.Degrees(+17.84677401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63829",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63829"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.23023076),
        dec: Angle.Degrees(+17.85240261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108023"},
        {"Hipparcos Number", "HIP 60543"},
        {"Geneva Identification System", "GEN# +1.00108023"},
        {"Smithsonian Astrophysical Observation", "SAO 100086"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.16816399),
        dec: Angle.Degrees(+17.85301455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102405"},
        {"Hipparcos Number", "HIP 57508"},
        {"Geneva Identification System", "GEN# +1.00102405"},
        {"Smithsonian Astrophysical Observation", "SAO 99791"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.81761069),
        dec: Angle.Degrees(+17.85726779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268472"},
        {"Hipparcos Number", "HIP 34034"},
        {"Geneva Identification System", "GEN# +1.00268472"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.90880452),
        dec: Angle.Degrees(+17.85849513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28406"},
        {"Hipparcos Number", "HIP 20948"},
        {"Celescope Catalog", "CEL 412"},
        {"Geneva Identification System", "GEN# +5.20250078"},
        {"Smithsonian Astrophysical Observation", "SAO 93963"},
        {"Wilson Evans Batten Catalogue", "WEB 4025"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.37619058),
        dec: Angle.Degrees(+17.86324256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57108"},
        {"Hipparcos Number", "HIP 35577"},
        {"Smithsonian Astrophysical Observation", "SAO 96791"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.13000787),
        dec: Angle.Degrees(+17.86464298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199333"},
        {"Hipparcos Number", "HIP 103323"},
        {"Geneva Identification System", "GEN# +1.00199333"},
        {"Smithsonian Astrophysical Observation", "SAO 106674"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.99637875),
        dec: Angle.Degrees(+17.86681212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137125"},
        {"Hipparcos Number", "HIP 75340"},
        {"Geneva Identification System", "GEN# +1.00137125"},
        {"Smithsonian Astrophysical Observation", "SAO 101522"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.92306802),
        dec: Angle.Degrees(+17.86699086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199784"},
        {"Hipparcos Number", "HIP 103556"},
        {"Geneva Identification System", "GEN# +1.00199784"},
        {"Smithsonian Astrophysical Observation", "SAO 106728"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.71910112),
        dec: Angle.Degrees(+17.86717721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224816"},
        {"Hipparcos Number", "HIP 78"},
        {"Smithsonian Astrophysical Observation", "SAO 108962"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.23231307),
        dec: Angle.Degrees(+17.86784193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134226"},
        {"Hipparcos Number", "HIP 74062"},
        {"Smithsonian Astrophysical Observation", "SAO 101392"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.04383053),
        dec: Angle.Degrees(+17.87106991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98643"},
        {"Hipparcos Number", "HIP 55429"},
        {"Smithsonian Astrophysical Observation", "SAO 99569"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.27142533),
        dec: Angle.Degrees(+17.87149173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100726"},
        {"Hipparcos Number", "HIP 56548"},
        {"Geneva Identification System", "GEN# +1.00100726"},
        {"Smithsonian Astrophysical Observation", "SAO 99682"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.92014685),
        dec: Angle.Degrees(+17.87480785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207841"},
        {"Hipparcos Number", "HIP 107897"},
        {"Smithsonian Astrophysical Observation", "SAO 107448"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.91810466),
        dec: Angle.Degrees(+17.87524101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154715"},
        {"Hipparcos Number", "HIP 83705"},
        {"Smithsonian Astrophysical Observation", "SAO 102596"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.61467652),
        dec: Angle.Degrees(+17.87659230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35392"},
        {"Smithsonian Astrophysical Observation", "SAO 96751"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.63987236),
        dec: Angle.Degrees(+17.87711035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285978"},
        {"Hipparcos Number", "HIP 21899"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.62821716),
        dec: Angle.Degrees(+17.87797731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190592"},
        {"Hipparcos Number", "HIP 98912"},
        {"Smithsonian Astrophysical Observation", "SAO 105654"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.27563247),
        dec: Angle.Degrees(+17.87868871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67453"},
        {"Geneva Identification System", "GEN# +0.01802787"},
        {"Smithsonian Astrophysical Observation", "SAO 100724"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.35565181),
        dec: Angle.Degrees(+17.87932067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19374"},
        {"Hipparcos Number", "HIP 14514"},
        {"Geneva Identification System", "GEN# +1.00019374"},
        {"Smithsonian Astrophysical Observation", "SAO 93284"},
        {"Wilson Evans Batten Catalogue", "WEB 2821"},
    },
    visualMagnitude: 6.13,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.85702924),
        dec: Angle.Degrees(+17.87997236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61577"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.27181045),
        dec: Angle.Degrees(+17.88026469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103419"},
        {"Hipparcos Number", "HIP 58070"},
        {"Geneva Identification System", "GEN# +1.00103419"},
        {"Smithsonian Astrophysical Observation", "SAO 99860"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.64088660),
        dec: Angle.Degrees(+17.88049490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349147"},
        {"Hipparcos Number", "HIP 91422"},
        {"Smithsonian Astrophysical Observation", "SAO 103947"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.67212388),
        dec: Angle.Degrees(+17.88166982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94306",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12146 AB"},
        {"Henry Draper", "HD 179398"},
        {"Hipparcos Number", "HIP 94306"},
        {"Smithsonian Astrophysical Observation", "SAO 104580"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.93132893),
        dec: Angle.Degrees(+17.88361216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130045"},
        {"Hipparcos Number", "HIP 72160"},
        {"Geneva Identification System", "GEN# +1.00130045"},
        {"Smithsonian Astrophysical Observation", "SAO 101191"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.38923639),
        dec: Angle.Degrees(+17.88454184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102781"},
        {"Hipparcos Number", "HIP 57709"},
        {"Geneva Identification System", "GEN# +1.00102781"},
        {"Smithsonian Astrophysical Observation", "SAO 99818"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.52365327),
        dec: Angle.Degrees(+17.88496702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7649"},
        {"Hipparcos Number", "HIP 5954"},
        {"Smithsonian Astrophysical Observation", "SAO 92345"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.15794158),
        dec: Angle.Degrees(+17.88524038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71867",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9347 A"},
        {"Henry Draper", "HD 129413"},
        {"Henry Draper 2", "HD 129413A"},
        {"Hipparcos Number", "HIP 71867"},
        {"Smithsonian Astrophysical Observation", "SAO 101158"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.49095889),
        dec: Angle.Degrees(+17.88542451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98087",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13140 AB"},
        {"Henry Draper", "HD 188726"},
        {"Hipparcos Number", "HIP 98087"},
        {"Geneva Identification System", "GEN# +1.00188726J"},
        {"Smithsonian Astrophysical Observation", "SAO 105437"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.00839406),
        dec: Angle.Degrees(+17.88684668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161818"},
        {"Hipparcos Number", "HIP 87028"},
        {"Smithsonian Astrophysical Observation", "SAO 103101"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.73380116),
        dec: Angle.Degrees(+17.88821974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58598"},
        {"Hipparcos Number", "HIP 36173"},
        {"Smithsonian Astrophysical Observation", "SAO 96905"},
    },
    visualMagnitude: 8.39,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.75942520),
        dec: Angle.Degrees(+17.88831677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15052"},
        {"Smithsonian Astrophysical Observation", "SAO 93346"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.49505246),
        dec: Angle.Degrees(+17.88870262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84485"},
        {"Hipparcos Number", "HIP 47927"},
        {"Geneva Identification System", "GEN# +1.00084485"},
        {"Smithsonian Astrophysical Observation", "SAO 98751"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.50458396),
        dec: Angle.Degrees(+17.88915040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40655"},
        {"Hipparcos Number", "HIP 28497"},
        {"Geneva Identification System", "GEN# +1.00040655"},
        {"Smithsonian Astrophysical Observation", "SAO 95113"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.23057885),
        dec: Angle.Degrees(+17.89024313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13600"},
        {"Smithsonian Astrophysical Observation", "SAO 93184"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.81754922),
        dec: Angle.Degrees(+17.89174217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230711"},
        {"Hipparcos Number", "HIP 93883"},
        {"Smithsonian Astrophysical Observation", "SAO 104494"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.78238124),
        dec: Angle.Degrees(+17.89304642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2411"},
        {"Hipparcos Number", "HIP 2219"},
        {"Geneva Identification System", "GEN# +1.00002411"},
        {"Smithsonian Astrophysical Observation", "SAO 91910"},
        {"Wilson Evans Batten Catalogue", "WEB 412"},
    },
    visualMagnitude: 5.01,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.01185234),
        dec: Angle.Degrees(+17.89307501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285773"},
        {"Hipparcos Number", "HIP 20951"},
        {"Geneva Identification System", "GEN# +5.20250079"},
        {"Smithsonian Astrophysical Observation", "SAO 93964"},
        {"Wilson Evans Batten Catalogue", "WEB 4028"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.38141803),
        dec: Angle.Degrees(+17.89326307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112784"},
    },
    visualMagnitude: 9.25,
    bvColour: 2.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.60343803),
        dec: Angle.Degrees(+17.89348635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35389"},
        {"Smithsonian Astrophysical Observation", "SAO 96750"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.63692344),
        dec: Angle.Degrees(+17.89489039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201872"},
        {"Hipparcos Number", "HIP 104652"},
        {"Smithsonian Astrophysical Observation", "SAO 106906"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.98658736),
        dec: Angle.Degrees(+17.89507163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87646"},
        {"Henry Draper 2", "HD 87646M"},
        {"Hipparcos Number", "HIP 49522"},
        {"Geneva Identification System", "GEN# +1.00087646"},
        {"Smithsonian Astrophysical Observation", "SAO 98950"},
        {"Wilson Evans Batten Catalogue", "WEB 9137"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.67008281),
        dec: Angle.Degrees(+17.89517485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108815"},
        {"Hipparcos Number", "HIP 60999"},
        {"Geneva Identification System", "GEN# +1.00108815"},
        {"Smithsonian Astrophysical Observation", "SAO 100132"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.53115771),
        dec: Angle.Degrees(+17.89561929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158211"},
        {"Hipparcos Number", "HIP 85419"},
        {"Smithsonian Astrophysical Observation", "SAO 102827"},
        {"Wilson Evans Batten Catalogue", "WEB 14428"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.82097772),
        dec: Angle.Degrees(+17.89756221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 350318"},
        {"Hipparcos Number", "HIP 96765"},
        {"Smithsonian Astrophysical Observation", "SAO 105121"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.04571772),
        dec: Angle.Degrees(+17.89925142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223837"},
        {"Hipparcos Number", "HIP 117770"},
        {"Smithsonian Astrophysical Observation", "SAO 108884"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.25366886),
        dec: Angle.Degrees(+17.89981761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78433"},
        {"Smithsonian Astrophysical Observation", "SAO 101871"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.18290735),
        dec: Angle.Degrees(+17.90079138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51354"},
        {"Hipparcos Number", "HIP 33493"},
        {"Geneva Identification System", "GEN# +1.00051354"},
        {"Smithsonian Astrophysical Observation", "SAO 96318"},
        {"Wilson Evans Batten Catalogue", "WEB 6734"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.42876766),
        dec: Angle.Degrees(+17.90202095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71766"},
        {"Geneva Identification System", "GEN# +0.01802910"},
    },
    visualMagnitude: 13.61,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.18973573),
        dec: Angle.Degrees(+17.90213669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2303"},
        {"Hipparcos Number", "HIP 2129"},
        {"Fundamental Katalog 5th Edition", "FK5 4043"},
        {"Smithsonian Astrophysical Observation", "SAO 91899"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.74955305),
        dec: Angle.Degrees(+17.90355908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208026"},
        {"Hipparcos Number", "HIP 108023"},
        {"Smithsonian Astrophysical Observation", "SAO 107466"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.26651585),
        dec: Angle.Degrees(+17.90390021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101303"},
        {"Hipparcos Number", "HIP 56882"},
        {"Geneva Identification System", "GEN# +1.00101303"},
        {"Smithsonian Astrophysical Observation", "SAO 99720"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.91102747),
        dec: Angle.Degrees(+17.90434226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204560"},
        {"Hipparcos Number", "HIP 106064"},
        {"Geneva Identification System", "GEN# +1.00204560"},
        {"Smithsonian Astrophysical Observation", "SAO 107168"},
        {"Wilson Evans Batten Catalogue", "WEB 19223"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.24967811),
        dec: Angle.Degrees(+17.90590802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42954"},
        {"Hipparcos Number", "HIP 29616"},
        {"Geneva Identification System", "GEN# +1.00042954"},
        {"Renson", "Renson 11460"},
        {"Smithsonian Astrophysical Observation", "SAO 95419"},
        {"Wilson Evans Batten Catalogue", "WEB 5827"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.61910415),
        dec: Angle.Degrees(+17.90637842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100735"},
        {"Wilson Evans Batten Catalogue", "WEB 18205"},
    },
    visualMagnitude: 10.46,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.35595137),
        dec: Angle.Degrees(+17.90690114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241111"},
        {"Hipparcos Number", "HIP 24000"},
        {"Smithsonian Astrophysical Observation", "SAO 94358"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.39776145),
        dec: Angle.Degrees(+17.90745976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55924"},
        {"Smithsonian Astrophysical Observation", "SAO 99611"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.92284883),
        dec: Angle.Degrees(+17.90912124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123323"},
        {"Hipparcos Number", "HIP 68919"},
        {"Fundamental Katalog 5th Edition", "FK5 5250"},
        {"Geneva Identification System", "GEN# +1.00123323"},
        {"Smithsonian Astrophysical Observation", "SAO 100853"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.63903193),
        dec: Angle.Degrees(+17.91203743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111815"},
        {"Hipparcos Number", "HIP 62777"},
        {"Geneva Identification System", "GEN# +1.00111815"},
        {"Smithsonian Astrophysical Observation", "SAO 100305"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.96722504),
        dec: Angle.Degrees(+17.91521186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153723"},
        {"Hipparcos Number", "HIP 83213"},
        {"Smithsonian Astrophysical Observation", "SAO 102525"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.09751053),
        dec: Angle.Degrees(+17.91649394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90143"},
        {"Hipparcos Number", "HIP 50964"},
        {"Geneva Identification System", "GEN# +1.00090143"},
        {"Smithsonian Astrophysical Observation", "SAO 99099"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.14819979),
        dec: Angle.Degrees(+17.91736579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17614"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.60629257),
        dec: Angle.Degrees(+17.91775569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1109"},
        {"Smithsonian Astrophysical Observation", "SAO 91785"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.45571071),
        dec: Angle.Degrees(+17.91821170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104208"},
        {"Hipparcos Number", "HIP 58521"},
        {"Geneva Identification System", "GEN# +1.00104208"},
        {"Smithsonian Astrophysical Observation", "SAO 99902"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.02381223),
        dec: Angle.Degrees(+17.92020008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 351362"},
        {"Hipparcos Number", "HIP 98934"},
        {"Geneva Identification System", "GEN# +1.00351362"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.32589385),
        dec: Angle.Degrees(+17.92190510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155263"},
        {"Hipparcos Number", "HIP 83965"},
        {"Smithsonian Astrophysical Observation", "SAO 102625"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.45179324),
        dec: Angle.Degrees(+17.92308795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104998"},
        {"Smithsonian Astrophysical Observation", "SAO 106978"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.98305632),
        dec: Angle.Degrees(+17.92371031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145588"},
        {"Hipparcos Number", "HIP 79310"},
        {"Smithsonian Astrophysical Observation", "SAO 101991"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.79000438),
        dec: Angle.Degrees(+17.92704464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20648",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3206 AB"},
        {"Henry Draper", "HD 27962"},
        {"Hipparcos Number", "HIP 20648"},
        {"Geneva Identification System", "GEN# +5.20250056"},
        {"Renson", "Renson 7160"},
        {"Smithsonian Astrophysical Observation", "SAO 93923"},
        {"Wilson Evans Batten Catalogue", "WEB 3959"},
    },
    visualMagnitude: 4.30,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.37215593),
        dec: Angle.Degrees(+17.92798917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4155"},
        {"Hipparcos Number", "HIP 3452"},
        {"Smithsonian Astrophysical Observation", "SAO 92057"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.03308553),
        dec: Angle.Degrees(+17.92958316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353102"},
        {"Hipparcos Number", "HIP 102779"},
        {"Geneva Identification System", "GEN# +1.00353102"},
        {"Smithsonian Astrophysical Observation", "SAO 106533"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.33407274),
        dec: Angle.Degrees(+17.93053561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8726"},
        {"Cincinnati Publication", "Ci 20 131"},
        {"Wilson Evans Batten Catalogue", "WEB 1841"},
    },
    visualMagnitude: 11.37,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.06051355),
        dec: Angle.Degrees(+17.93113960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 405.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16233"},
        {"Hipparcos Number", "HIP 12168"},
        {"Smithsonian Astrophysical Observation", "SAO 93024"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.20075646),
        dec: Angle.Degrees(+17.93127075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121107"},
        {"Hipparcos Number", "HIP 67787"},
        {"Geneva Identification System", "GEN# +1.00121107"},
        {"Smithsonian Astrophysical Observation", "SAO 100751"},
        {"Wilson Evans Batten Catalogue", "WEB 11914"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.30396336),
        dec: Angle.Degrees(+17.93285548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34936",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5900 AB"},
        {"Henry Draper", "HD 55460"},
        {"Hipparcos Number", "HIP 34936"},
        {"Smithsonian Astrophysical Observation", "SAO 96647"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.44145831),
        dec: Angle.Degrees(+17.93322750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42160"},
        {"Hipparcos Number", "HIP 29248"},
        {"Cincinnati Publication", "Ci 18 767"},
        {"Geneva Identification System", "GEN# +1.00042160"},
        {"Smithsonian Astrophysical Observation", "SAO 95311"},
        {"Wilson Evans Batten Catalogue", "WEB 5737"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.50392620),
        dec: Angle.Degrees(+17.93476897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285367"},
        {"Hipparcos Number", "HIP 19098"},
        {"Geneva Identification System", "GEN# +5.20252010"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.41498460),
        dec: Angle.Degrees(+17.93777817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47504",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7479 AB"},
        {"Henry Draper", "HD 83768"},
        {"Hipparcos Number", "HIP 47504"},
        {"Smithsonian Astrophysical Observation", "SAO 98707"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.27484514),
        dec: Angle.Degrees(+17.93809389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21787"},
        {"Hipparcos Number", "HIP 16414"},
        {"Smithsonian Astrophysical Observation", "SAO 93473"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.83804600),
        dec: Angle.Degrees(+17.93817634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267806"},
        {"Hipparcos Number", "HIP 33785"},
        {"Smithsonian Astrophysical Observation", "SAO 96376"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.23143213),
        dec: Angle.Degrees(+17.94107250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217770"},
        {"Hipparcos Number", "HIP 113814"},
        {"Geneva Identification System", "GEN# +1.00217770"},
        {"Smithsonian Astrophysical Observation", "SAO 108361"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.72174847),
        dec: Angle.Degrees(+17.94256471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151483"},
        {"Hipparcos Number", "HIP 82144"},
        {"Smithsonian Astrophysical Observation", "SAO 102381"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.72382605),
        dec: Angle.Degrees(+17.94959735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188346"},
        {"Hipparcos Number", "HIP 97925"},
        {"Smithsonian Astrophysical Observation", "SAO 105398"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.51670635),
        dec: Angle.Degrees(+17.95112454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87267"},
        {"Smithsonian Astrophysical Observation", "SAO 103139"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.48052028),
        dec: Angle.Degrees(+17.95177494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200353"},
        {"Hipparcos Number", "HIP 103837"},
        {"Smithsonian Astrophysical Observation", "SAO 106784"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.61517978),
        dec: Angle.Degrees(+17.95369743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12367"},
        {"Hipparcos Number", "HIP 9449"},
        {"Smithsonian Astrophysical Observation", "SAO 92755"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.37646929),
        dec: Angle.Degrees(+17.95393758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72757",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9422 AB"},
        {"Henry Draper", "HD 131317"},
        {"Hipparcos Number", "HIP 72757"},
        {"Smithsonian Astrophysical Observation", "SAO 101263"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.10765025),
        dec: Angle.Degrees(+17.95649321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64512"},
        {"Hipparcos Number", "HIP 38661"},
        {"Smithsonian Astrophysical Observation", "SAO 97360"},
        {"Wilson Evans Batten Catalogue", "WEB 7588"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.73169636),
        dec: Angle.Degrees(+17.95749587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183989"},
        {"Hipparcos Number", "HIP 96033"},
        {"Geneva Identification System", "GEN# +1.00183989"},
        {"Smithsonian Astrophysical Observation", "SAO 104936"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.89395522),
        dec: Angle.Degrees(+17.95816594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2984"},
        {"Hipparcos Number", "HIP 2621"},
        {"Smithsonian Astrophysical Observation", "SAO 91964"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.31637685),
        dec: Angle.Degrees(+17.95936793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5470"},
        {"Hipparcos Number", "HIP 4423"},
        {"Geneva Identification System", "GEN# +1.00005470"},
        {"Smithsonian Astrophysical Observation", "SAO 92167"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.16732517),
        dec: Angle.Degrees(+17.95993365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83844"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.02220020),
        dec: Angle.Degrees(+17.96096421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -350.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84698"},
        {"Smithsonian Astrophysical Observation", "SAO 102732"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.71257555),
        dec: Angle.Degrees(+17.96157002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25499",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4038 A"},
        {"Henry Draper", "HD 35671"},
        {"Hipparcos Number", "HIP 25499"},
        {"Celescope Catalog", "CEL 703"},
        {"Fundamental Katalog 5th Edition", "FK5 1148"},
        {"Geneva Identification System", "GEN# +1.00035671"},
        {"Smithsonian Astrophysical Observation", "SAO 94554"},
        {"Wilson Evans Batten Catalogue", "WEB 4948"},
    },
    visualMagnitude: 5.40,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.79203649),
        dec: Angle.Degrees(+17.96226766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48231"},
        {"Hipparcos Number", "HIP 32182"},
        {"Smithsonian Astrophysical Observation", "SAO 96034"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.78736217),
        dec: Angle.Degrees(+17.96325239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186272"},
        {"Hipparcos Number", "HIP 96984"},
        {"Fundamental Katalog 5th Edition", "FK5 5738"},
        {"Smithsonian Astrophysical Observation", "SAO 105179"},
        {"Wilson Evans Batten Catalogue", "WEB 17019"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.70115076),
        dec: Angle.Degrees(+17.96828626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82768"},
        {"Hipparcos Number", "HIP 46986"},
        {"Geneva Identification System", "GEN# +1.00082768"},
        {"Smithsonian Astrophysical Observation", "SAO 98648"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.64773785),
        dec: Angle.Degrees(+17.96838688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54"},
        {"Geneva Identification System", "GEN# +9.80030035"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.15165558),
        dec: Angle.Degrees(+17.96895579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 367.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218345"},
        {"Hipparcos Number", "HIP 114149"},
        {"Geneva Identification System", "GEN# +1.00218345"},
        {"Smithsonian Astrophysical Observation", "SAO 108406"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.76716053),
        dec: Angle.Degrees(+17.96916044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206125"},
        {"Hipparcos Number", "HIP 106953"},
        {"Fundamental Katalog 5th Edition", "FK5 5909"},
        {"Smithsonian Astrophysical Observation", "SAO 107308"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.91778640),
        dec: Angle.Degrees(+17.96924033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212048"},
        {"Hipparcos Number", "HIP 110363"},
        {"Geneva Identification System", "GEN# +1.00212048"},
        {"Smithsonian Astrophysical Observation", "SAO 107850"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.29641766),
        dec: Angle.Degrees(+17.96964613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67347"},
        {"Hipparcos Number", "HIP 39805"},
        {"Smithsonian Astrophysical Observation", "SAO 97578"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.01091526),
        dec: Angle.Degrees(+17.97173585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213392"},
        {"Hipparcos Number", "HIP 111125"},
        {"Smithsonian Astrophysical Observation", "SAO 107969"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.67753924),
        dec: Angle.Degrees(+17.97445380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230559"},
        {"Hipparcos Number", "HIP 93575"},
        {"Smithsonian Astrophysical Observation", "SAO 104419"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.87727261),
        dec: Angle.Degrees(+17.97531371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52372"},
        {"Hipparcos Number", "HIP 33859"},
        {"Smithsonian Astrophysical Observation", "SAO 96393"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.43977757),
        dec: Angle.Degrees(+17.97536093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133312"},
        {"Hipparcos Number", "HIP 73646"},
        {"Smithsonian Astrophysical Observation", "SAO 101353"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.80429289),
        dec: Angle.Degrees(+17.97565879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145770"},
        {"Hipparcos Number", "HIP 79379"},
        {"Geneva Identification System", "GEN# +1.00145770"},
        {"Smithsonian Astrophysical Observation", "SAO 102000"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.01148232),
        dec: Angle.Degrees(+17.97794688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59418"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.82827469),
        dec: Angle.Degrees(+17.97911705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168198"},
        {"Hipparcos Number", "HIP 89669"},
        {"Fundamental Katalog 5th Edition", "FK5 5611"},
        {"Geneva Identification System", "GEN# +1.00168198"},
        {"Smithsonian Astrophysical Observation", "SAO 103576"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.47848125),
        dec: Angle.Degrees(+17.98122684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184566"},
        {"Hipparcos Number", "HIP 96268"},
        {"Geneva Identification System", "GEN# +1.00184566"},
        {"Smithsonian Astrophysical Observation", "SAO 104986"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.61901665),
        dec: Angle.Degrees(+17.98126429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170562"},
        {"Hipparcos Number", "HIP 90609"},
        {"Smithsonian Astrophysical Observation", "SAO 103769"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.33692821),
        dec: Angle.Degrees(+17.98394937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31697"},
        {"Hipparcos Number", "HIP 23139"},
        {"Smithsonian Astrophysical Observation", "SAO 94237"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.68719264),
        dec: Angle.Degrees(+17.98724395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122653"},
        {"Hipparcos Number", "HIP 68622"},
        {"Geneva Identification System", "GEN# +1.00122653"},
        {"Smithsonian Astrophysical Observation", "SAO 100828"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.70967064),
        dec: Angle.Degrees(+17.98784598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202926"},
        {"Hipparcos Number", "HIP 105192"},
        {"Geneva Identification System", "GEN# +1.00202926"},
        {"Smithsonian Astrophysical Observation", "SAO 107016"},
        {"Wilson Evans Batten Catalogue", "WEB 19102"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.63322680),
        dec: Angle.Degrees(+17.98802204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49582"},
        {"Hipparcos Number", "HIP 32755"},
        {"Geneva Identification System", "GEN# +1.00049582"},
        {"Smithsonian Astrophysical Observation", "SAO 96160"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.45807968),
        dec: Angle.Degrees(+17.98934555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254504"},
        {"Hipparcos Number", "HIP 29875"},
        {"Geneva Identification System", "GEN# +1.00254504"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.35737567),
        dec: Angle.Degrees(+17.98943483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91204"},
        {"Hipparcos Number", "HIP 51579"},
        {"Geneva Identification System", "GEN# +1.00091204"},
        {"Smithsonian Astrophysical Observation", "SAO 99171"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.02289314),
        dec: Angle.Degrees(+17.98978769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39879"},
        {"Hipparcos Number", "HIP 28079"},
        {"Smithsonian Astrophysical Observation", "SAO 95005"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.03837515),
        dec: Angle.Degrees(+17.99128512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223954"},
        {"Hipparcos Number", "HIP 117836"},
        {"Geneva Identification System", "GEN# +1.00223954"},
        {"Smithsonian Astrophysical Observation", "SAO 108894"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.47592367),
        dec: Angle.Degrees(+17.99186793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132718"},
        {"Hipparcos Number", "HIP 73402"},
        {"Smithsonian Astrophysical Observation", "SAO 101321"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.01059373),
        dec: Angle.Degrees(+17.99301181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175744"},
        {"Hipparcos Number", "HIP 92934"},
        {"Geneva Identification System", "GEN# +1.00175744"},
        {"Renson", "Renson 49070"},
        {"Smithsonian Astrophysical Observation", "SAO 104271"},
        {"Wilson Evans Batten Catalogue", "WEB 16095"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.01583799),
        dec: Angle.Degrees(+17.99535387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66792"},
        {"Geneva Identification System", "GEN# +0.01802767"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.34511348),
        dec: Angle.Degrees(+17.99821078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205968"},
        {"Hipparcos Number", "HIP 106854"},
        {"Smithsonian Astrophysical Observation", "SAO 107295"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.63145384),
        dec: Angle.Degrees(+17.99993356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95175"},
        {"Hipparcos Number", "HIP 53731"},
        {"Cincinnati Publication", "Ci 18 1336"},
        {"Geneva Identification System", "GEN# +1.00095175"},
        {"Smithsonian Astrophysical Observation", "SAO 99390"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.89509410),
        dec: Angle.Degrees(+17.99995233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -235.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -231.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210090"},
        {"Hipparcos Number", "HIP 109212"},
        {"Geneva Identification System", "GEN# +1.00210090"},
        {"Smithsonian Astrophysical Observation", "SAO 107676"},
        {"Wilson Evans Batten Catalogue", "WEB 19631"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.87480137),
        dec: Angle.Degrees(+18.00078982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179586"},
        {"Hipparcos Number", "HIP 94373"},
        {"Geneva Identification System", "GEN# +1.00179586"},
        {"Smithsonian Astrophysical Observation", "SAO 104597"},
        {"Wilson Evans Batten Catalogue", "WEB 16445"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.11860834),
        dec: Angle.Degrees(+18.00190061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216219"},
        {"Hipparcos Number", "HIP 112821"},
        {"Geneva Identification System", "GEN# +1.00216219"},
        {"Smithsonian Astrophysical Observation", "SAO 108214"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.71715142),
        dec: Angle.Degrees(+18.00208828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100339"},
        {"Hipparcos Number", "HIP 56321"},
        {"Geneva Identification System", "GEN# +1.00100339"},
        {"Smithsonian Astrophysical Observation", "SAO 99655"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.20782130),
        dec: Angle.Degrees(+18.00231851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285720"},
        {"Hipparcos Number", "HIP 20563"},
        {"Geneva Identification System", "GEN# +5.20250174"},
        {"Geneva Identification System 2", "GEN# +5.20251310"},
        {"Wilson Evans Batten Catalogue", "WEB 3937"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.07029908),
        dec: Angle.Degrees(+18.00299503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43421",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7039 AB"},
        {"Henry Draper", "HD 75470"},
        {"Hipparcos Number", "HIP 43421"},
        {"Geneva Identification System", "GEN# +1.00075470J"},
        {"Smithsonian Astrophysical Observation", "SAO 98161"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.66840032),
        dec: Angle.Degrees(+18.00339221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230982"},
        {"Hipparcos Number", "HIP 94584"},
        {"Smithsonian Astrophysical Observation", "SAO 104647"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.73583196),
        dec: Angle.Degrees(+18.00455353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14021",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2279 A"},
        {"Henry Draper", "HD 18654"},
        {"Hipparcos Number", "HIP 14021"},
        {"Smithsonian Astrophysical Observation", "SAO 93229"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.13127786),
        dec: Angle.Degrees(+18.00503794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71534"},
        {"Smithsonian Astrophysical Observation", "SAO 101117"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.46803554),
        dec: Angle.Degrees(+18.00512098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85183",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85183"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.11709603),
        dec: Angle.Degrees(+18.00659308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67719"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.09021115),
        dec: Angle.Degrees(+18.00689542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160470"},
        {"Hipparcos Number", "HIP 86407"},
        {"Smithsonian Astrophysical Observation", "SAO 103004"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.84399613),
        dec: Angle.Degrees(+18.00695776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170597"},
        {"Hipparcos Number", "HIP 90638"},
        {"Smithsonian Astrophysical Observation", "SAO 103778"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.40159994),
        dec: Angle.Degrees(+18.01319991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230376"},
        {"Hipparcos Number", "HIP 93316"},
        {"Smithsonian Astrophysical Observation", "SAO 104343"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.10481946),
        dec: Angle.Degrees(+18.01367626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96757",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sham"},
        {"Aitken", "ADS 12766 A"},
        {"Henry Draper", "HD 185758"},
        {"Hipparcos Number", "HIP 96757"},
        {"Geneva Identification System", "GEN# +1.00185758"},
        {"Smithsonian Astrophysical Observation", "SAO 105120"},
        {"Wilson Evans Batten Catalogue", "WEB 16974"},
    },
    visualMagnitude: 4.39,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.02409394),
        dec: Angle.Degrees(+18.01393839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137946"},
        {"Hipparcos Number", "HIP 75748"},
        {"Smithsonian Astrophysical Observation", "SAO 101571"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.12062413),
        dec: Angle.Degrees(+18.01410717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21251",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3297 AB"},
        {"Henry Draper", "HD 28867"},
        {"Hipparcos Number", "HIP 21251"},
        {"Celescope Catalog", "CEL 428"},
        {"Geneva Identification System", "GEN# +1.00028867"},
        {"Smithsonian Astrophysical Observation", "SAO 94002"},
        {"Wilson Evans Batten Catalogue", "WEB 4081"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.38767313),
        dec: Angle.Degrees(+18.01676291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113390"},
        {"Wilson Evans Batten Catalogue", "WEB 20170"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.46564193),
        dec: Angle.Degrees(+18.01691231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70122"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.22080729),
        dec: Angle.Degrees(+18.01734491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27990"},
        {"Hipparcos Number", "HIP 20679"},
        {"Geneva Identification System", "GEN# +5.20251363"},
        {"Geneva Identification System 2", "GEN# +5.20250176"},
        {"Wilson Evans Batten Catalogue", "WEB 3964"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.44787712),
        dec: Angle.Degrees(+18.01735914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182444"},
        {"Hipparcos Number", "HIP 95367"},
        {"Geneva Identification System", "GEN# +1.00182444"},
        {"Smithsonian Astrophysical Observation", "SAO 104794"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.01832143),
        dec: Angle.Degrees(+18.01845077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156377"},
        {"Hipparcos Number", "HIP 84498"},
        {"Fundamental Katalog 5th Edition", "FK5 5524"},
        {"Smithsonian Astrophysical Observation", "SAO 102705"},
        {"Wilson Evans Batten Catalogue", "WEB 14265"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.12966105),
        dec: Angle.Degrees(+18.01970597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211075"},
        {"Hipparcos Number", "HIP 109793"},
        {"Geneva Identification System", "GEN# +1.00211075"},
        {"Smithsonian Astrophysical Observation", "SAO 107757"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.58348858),
        dec: Angle.Degrees(+18.02039376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175173"},
        {"Hipparcos Number", "HIP 92710"},
        {"Smithsonian Astrophysical Observation", "SAO 104225"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.36632686),
        dec: Angle.Degrees(+18.02091461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10295"},
        {"Smithsonian Astrophysical Observation", "SAO 92834"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.14719061),
        dec: Angle.Degrees(+18.02204865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18256"},
        {"Hipparcos Number", "HIP 13702"},
        {"Fundamental Katalog 5th Edition", "FK5 2204"},
        {"Geneva Identification System", "GEN# +1.00018256"},
        {"Smithsonian Astrophysical Observation", "SAO 93195"},
        {"Wilson Evans Batten Catalogue", "WEB 2717"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.10825985),
        dec: Angle.Degrees(+18.02365076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 281.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 350571"},
        {"Hipparcos Number", "HIP 97270"},
        {"Smithsonian Astrophysical Observation", "SAO 105225"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.53224594),
        dec: Angle.Degrees(+18.02436507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74945"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.71459531),
        dec: Angle.Degrees(+18.02440241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51746"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.58216484),
        dec: Angle.Degrees(+18.02566681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39018"},
        {"Hipparcos Number", "HIP 27590"},
        {"Celescope Catalog", "CEL 998"},
        {"Geneva Identification System", "GEN# +1.00039018"},
        {"Smithsonian Astrophysical Observation", "SAO 94903"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.63451281),
        dec: Angle.Degrees(+18.02637712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198835"},
        {"Hipparcos Number", "HIP 103036"},
        {"Geneva Identification System", "GEN# +1.00198835"},
        {"Smithsonian Astrophysical Observation", "SAO 106603"},
        {"Wilson Evans Batten Catalogue", "WEB 18703"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.12463108),
        dec: Angle.Degrees(+18.02736770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199057"},
        {"Hipparcos Number", "HIP 103169"},
        {"Geneva Identification System", "GEN# +1.00199057"},
        {"Smithsonian Astrophysical Observation", "SAO 106632"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.52811904),
        dec: Angle.Degrees(+18.02812211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20137"},
        {"Hipparcos Number", "HIP 15098"},
        {"Smithsonian Astrophysical Observation", "SAO 93354"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.69191321),
        dec: Angle.Degrees(+18.02863086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13018"},
        {"Hipparcos Number", "HIP 9924"},
        {"Geneva Identification System", "GEN# +1.00013018"},
        {"Smithsonian Astrophysical Observation", "SAO 92801"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.94156330),
        dec: Angle.Degrees(+18.02941430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45138"},
        {"Smithsonian Astrophysical Observation", "SAO 98423"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.95105853),
        dec: Angle.Degrees(+18.03329564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67947"},
        {"Smithsonian Astrophysical Observation", "SAO 100768"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.71926703),
        dec: Angle.Degrees(+18.03598113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81580"},
        {"Hipparcos Number", "HIP 46349"},
        {"Geneva Identification System", "GEN# +1.00081580"},
        {"Smithsonian Astrophysical Observation", "SAO 98575"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.74934473),
        dec: Angle.Degrees(+18.03728768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77919"},
        {"Fundamental Katalog 5th Edition", "FK5 5406"},
        {"Smithsonian Astrophysical Observation", "SAO 101810"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.68880795),
        dec: Angle.Degrees(+18.03916031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255390"},
        {"Hipparcos Number", "HIP 30146"},
        {"Smithsonian Astrophysical Observation", "SAO 95556"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.15431343),
        dec: Angle.Degrees(+18.04084790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66537",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66537"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.58703812),
        dec: Angle.Degrees(+18.04130918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79009"},
        {"Hipparcos Number", "HIP 45153"},
        {"Geneva Identification System", "GEN# +1.00079009"},
        {"Smithsonian Astrophysical Observation", "SAO 98425"},
        {"Wilson Evans Batten Catalogue", "WEB 8611"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.98721797),
        dec: Angle.Degrees(+18.04416969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1436"},
        {"Smithsonian Astrophysical Observation", "SAO 91827"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.47625722),
        dec: Angle.Degrees(+18.04523751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2202"},
        {"Smithsonian Astrophysical Observation", "SAO 91908"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.95853412),
        dec: Angle.Degrees(+18.04552537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91738"},
        {"Hipparcos Number", "HIP 51874"},
        {"Smithsonian Astrophysical Observation", "SAO 99194"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.97984893),
        dec: Angle.Degrees(+18.04566429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74642"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.76279589),
        dec: Angle.Degrees(+18.04790417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44073"},
        {"Hipparcos Number", "HIP 30139"},
        {"Geneva Identification System", "GEN# +1.00044073"},
        {"Smithsonian Astrophysical Observation", "SAO 95554"},
        {"Wilson Evans Batten Catalogue", "WEB 5995"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.14366310),
        dec: Angle.Degrees(+18.04911127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198552"},
        {"Hipparcos Number", "HIP 102878"},
        {"Geneva Identification System", "GEN# +1.00198552"},
        {"Smithsonian Astrophysical Observation", "SAO 106562"},
        {"Wilson Evans Batten Catalogue", "WEB 18662"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.65422764),
        dec: Angle.Degrees(+18.05125622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37486",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6287 AB"},
        {"Henry Draper", "HD 61787"},
        {"Hipparcos Number", "HIP 37486"},
        {"Smithsonian Astrophysical Observation", "SAO 97148"},
        {"Wilson Evans Batten Catalogue", "WEB 7414"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.42766309),
        dec: Angle.Degrees(+18.05321481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24251"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.08911895),
        dec: Angle.Degrees(+18.05369987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37491",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6287 C"},
        {"Hipparcos Number", "HIP 37491"},
        {"Smithsonian Astrophysical Observation", "SAO 97149"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.43336783),
        dec: Angle.Degrees(+18.05580865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157049"},
        {"Hipparcos Number", "HIP 84833"},
        {"Fundamental Katalog 5th Edition", "FK5 1454"},
        {"Geneva Identification System", "GEN# +1.00157049"},
        {"Smithsonian Astrophysical Observation", "SAO 102757"},
        {"Wilson Evans Batten Catalogue", "WEB 14322"},
    },
    visualMagnitude: 5.01,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.07860691),
        dec: Angle.Degrees(+18.05721601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84950"},
        {"Hipparcos Number", "HIP 48168"},
        {"Fundamental Katalog 5th Edition", "FK5 4872"},
        {"Smithsonian Astrophysical Observation", "SAO 98783"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.27285001),
        dec: Angle.Degrees(+18.05790159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16043"},
        {"Hipparcos Number", "HIP 12024"},
        {"Geneva Identification System", "GEN# +1.00016043"},
        {"Smithsonian Astrophysical Observation", "SAO 93009"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.76836179),
        dec: Angle.Degrees(+18.05979155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44125"},
        {"Smithsonian Astrophysical Observation", "SAO 98274"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.79464332),
        dec: Angle.Degrees(+18.06025130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84200"},
        {"Smithsonian Astrophysical Observation", "SAO 102654"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.17636704),
        dec: Angle.Degrees(+18.06077632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8004"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.69148106),
        dec: Angle.Degrees(+18.06090922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285360"},
        {"Hipparcos Number", "HIP 18849"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.61910193),
        dec: Angle.Degrees(+18.06159028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203614"},
        {"Hipparcos Number", "HIP 105571"},
        {"Geneva Identification System", "GEN# +1.00203614"},
        {"Smithsonian Astrophysical Observation", "SAO 107087"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.72536099),
        dec: Angle.Degrees(+18.06196171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152446"},
        {"Hipparcos Number", "HIP 82568"},
        {"Fundamental Katalog 5th Edition", "FK5 3340"},
        {"Geneva Identification System", "GEN# +1.00152446"},
        {"Smithsonian Astrophysical Observation", "SAO 102445"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.17135057),
        dec: Angle.Degrees(+18.06218777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92338"},
        {"Hipparcos Number", "HIP 52207"},
        {"Geneva Identification System", "GEN# +1.00092338"},
        {"Smithsonian Astrophysical Observation", "SAO 99241"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.99486662),
        dec: Angle.Degrees(+18.06263439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90483"},
        {"Hipparcos Number", "HIP 51171"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.78534946),
        dec: Angle.Degrees(+18.06267070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204133"},
        {"Hipparcos Number", "HIP 105833"},
        {"Geneva Identification System", "GEN# +1.00204133"},
        {"Smithsonian Astrophysical Observation", "SAO 107136"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.53092110),
        dec: Angle.Degrees(+18.06510254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53246"},
        {"Smithsonian Astrophysical Observation", "SAO 99345"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.35929265),
        dec: Angle.Degrees(+18.06533582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259979"},
        {"Hipparcos Number", "HIP 31435"},
        {"Smithsonian Astrophysical Observation", "SAO 95866"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.80309832),
        dec: Angle.Degrees(+18.06543046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353213"},
        {"Hipparcos Number", "HIP 102917"},
        {"Smithsonian Astrophysical Observation", "SAO 106570"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.75399055),
        dec: Angle.Degrees(+18.06614535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71407"},
        {"Hipparcos Number", "HIP 41505"},
        {"Geneva Identification System", "GEN# +1.00071407"},
        {"Smithsonian Astrophysical Observation", "SAO 97833"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.97436822),
        dec: Angle.Degrees(+18.06883785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95619"},
        {"Hipparcos Number", "HIP 53967"},
        {"Smithsonian Astrophysical Observation", "SAO 99416"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.60522173),
        dec: Angle.Degrees(+18.06915989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172383"},
        {"Hipparcos Number", "HIP 91458"},
        {"Smithsonian Astrophysical Observation", "SAO 103953"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.80230067),
        dec: Angle.Degrees(+18.07308744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208157"},
        {"Hipparcos Number", "HIP 108094"},
        {"Smithsonian Astrophysical Observation", "SAO 107479"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.51511926),
        dec: Angle.Degrees(+18.07390636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39897"},
        {"Hipparcos Number", "HIP 28090"},
        {"Smithsonian Astrophysical Observation", "SAO 95009"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.06747621),
        dec: Angle.Degrees(+18.07422185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 495",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 60"},
        {"Henry Draper", "HD 113"},
        {"Hipparcos Number", "HIP 495"},
        {"Cincinnati Publication", "Ci 18 4"},
        {"Geneva Identification System", "GEN# +1.00000113J"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.48151411),
        dec: Angle.Degrees(+18.07622626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152174"},
        {"Hipparcos Number", "HIP 82463"},
        {"Smithsonian Astrophysical Observation", "SAO 102428"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.78353312),
        dec: Angle.Degrees(+18.07749667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173133"},
        {"Hipparcos Number", "HIP 91798"},
        {"Smithsonian Astrophysical Observation", "SAO 104019"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.77156636),
        dec: Angle.Degrees(+18.07792479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69288"},
        {"Hipparcos Number", "HIP 40564"},
        {"Smithsonian Astrophysical Observation", "SAO 97697"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.23281797),
        dec: Angle.Degrees(+18.07928667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211775"},
        {"Hipparcos Number", "HIP 110189"},
        {"Geneva Identification System", "GEN# +1.00211775"},
        {"Smithsonian Astrophysical Observation", "SAO 107825"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.80066765),
        dec: Angle.Degrees(+18.08023520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59177"},
        {"Hipparcos Number", "HIP 36410"},
        {"Smithsonian Astrophysical Observation", "SAO 96946"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.37678166),
        dec: Angle.Degrees(+18.08415024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124605"},
        {"Hipparcos Number", "HIP 69549"},
        {"Geneva Identification System", "GEN# +1.00124605"},
        {"Smithsonian Astrophysical Observation", "SAO 100926"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.55089887),
        dec: Angle.Degrees(+18.08554340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90735"},
        {"Hipparcos Number", "HIP 51318"},
        {"Smithsonian Astrophysical Observation", "SAO 99151"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.23608957),
        dec: Angle.Degrees(+18.08675078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218200"},
        {"Hipparcos Number", "HIP 114059"},
        {"Geneva Identification System", "GEN# +1.00218200"},
        {"Smithsonian Astrophysical Observation", "SAO 108397"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.48592812),
        dec: Angle.Degrees(+18.08723713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179423"},
        {"Hipparcos Number", "HIP 94313"},
        {"Geneva Identification System", "GEN# +1.00179423"},
        {"Smithsonian Astrophysical Observation", "SAO 104583"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.94426291),
        dec: Angle.Degrees(+18.08782096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75347"},
        {"Smithsonian Astrophysical Observation", "SAO 101524"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.95602012),
        dec: Angle.Degrees(+18.08827078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197812"},
        {"Hipparcos Number", "HIP 102440"},
        {"Geneva Identification System", "GEN# +1.00197812"},
        {"Smithsonian Astrophysical Observation", "SAO 106458"},
        {"Wilson Evans Batten Catalogue", "WEB 18552"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.36762034),
        dec: Angle.Degrees(+18.09005793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109558"},
        {"Cincinnati Publication", "Ci 20 1343"},
        {"Geneva Identification System", "GEN# +0.01704708"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.87941554),
        dec: Angle.Degrees(+18.09268044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 511.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72094"},
        {"Hipparcos Number", "HIP 41822"},
        {"Fundamental Katalog 5th Edition", "FK5 2667"},
        {"Geneva Identification System", "GEN# +1.00072094"},
        {"Smithsonian Astrophysical Observation", "SAO 97881"},
        {"Wilson Evans Batten Catalogue", "WEB 8053"},
    },
    visualMagnitude: 5.33,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.89902880),
        dec: Angle.Degrees(+18.09455771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68447"},
        {"Geneva Identification System", "GEN# +0.01802811"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.18896252),
        dec: Angle.Degrees(+18.09853509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 293.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11158"},
    },
    visualMagnitude: 11.67,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.88857509),
        dec: Angle.Degrees(+18.09875520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -233.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64493"},
        {"Hipparcos Number", "HIP 38648"},
        {"Smithsonian Astrophysical Observation", "SAO 97357"},
        {"Wilson Evans Batten Catalogue", "WEB 7586"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.70546904),
        dec: Angle.Degrees(+18.10026208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17174"},
        {"Smithsonian Astrophysical Observation", "SAO 93549"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.17104060),
        dec: Angle.Degrees(+18.10075179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65063"},
        {"Hipparcos Number", "HIP 38890"},
        {"Geneva Identification System", "GEN# +1.00065063"},
        {"Smithsonian Astrophysical Observation", "SAO 97412"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.38142387),
        dec: Angle.Degrees(+18.10110903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243959"},
        {"Hipparcos Number", "HIP 25618"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.09287079),
        dec: Angle.Degrees(+18.10182778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55711"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.24195874),
        dec: Angle.Degrees(+18.10272436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107582"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.84114895),
        dec: Angle.Degrees(+18.10322735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2827"},
        {"Hipparcos Number", "HIP 2512"},
        {"Geneva Identification System", "GEN# +1.00002827"},
        {"Smithsonian Astrophysical Observation", "SAO 91947"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.96274771),
        dec: Angle.Degrees(+18.10554887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175743"},
        {"Hipparcos Number", "HIP 92937"},
        {"Geneva Identification System", "GEN# +1.00175743"},
        {"Smithsonian Astrophysical Observation", "SAO 104272"},
        {"Wilson Evans Batten Catalogue", "WEB 16094"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.02562647),
        dec: Angle.Degrees(+18.10579902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4141",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 727 AB"},
        {"Henry Draper", "HD 5093"},
        {"Hipparcos Number", "HIP 4141"},
        {"Geneva Identification System", "GEN# +1.00005093J"},
        {"Smithsonian Astrophysical Observation", "SAO 92133"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.24099702),
        dec: Angle.Degrees(+18.10676187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348058"},
        {"Hipparcos Number", "HIP 89018"},
    },
    visualMagnitude: 11.93,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.51506897),
        dec: Angle.Degrees(+18.10708194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105492"},
        {"Smithsonian Astrophysical Observation", "SAO 107071"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.49476785),
        dec: Angle.Degrees(+18.10811776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143936"},
        {"Hipparcos Number", "HIP 78570"},
        {"Smithsonian Astrophysical Observation", "SAO 101890"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.65563273),
        dec: Angle.Degrees(+18.11397541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61895"},
        {"Geneva Identification System", "GEN# +0.01802642"},
        {"Smithsonian Astrophysical Observation", "SAO 100204"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.25973993),
        dec: Angle.Degrees(+18.11503138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112306"},
        {"Wilson Evans Batten Catalogue", "WEB 20037"},
    },
    visualMagnitude: 10.89,
    bvColour: 2.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.22200846),
        dec: Angle.Degrees(+18.11545872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84606"},
        {"Hipparcos Number", "HIP 47979"},
        {"Geneva Identification System", "GEN# +1.00084606"},
        {"Smithsonian Astrophysical Observation", "SAO 98761"},
        {"Wilson Evans Batten Catalogue", "WEB 8976"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.69661004),
        dec: Angle.Degrees(+18.11591932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115560"},
        {"Smithsonian Astrophysical Observation", "SAO 108596"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.11569767),
        dec: Angle.Degrees(+18.11680000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112868"},
        {"Wilson Evans Batten Catalogue", "WEB 20103"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.84656152),
        dec: Angle.Degrees(+18.11886878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1897"},
        {"Geneva Identification System", "GEN# +0.01700044"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.99544109),
        dec: Angle.Degrees(+18.12092114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -252.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8066"},
        {"Hipparcos Number", "HIP 6265"},
        {"Smithsonian Astrophysical Observation", "SAO 92376"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.08784234),
        dec: Angle.Degrees(+18.12240736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36775"},
        {"Hipparcos Number", "HIP 26183"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.72699446),
        dec: Angle.Degrees(+18.12269108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43510"},
        {"Cincinnati Publication", "Ci 20 492"},
        {"Geneva Identification System", "GEN# +9.80009028"},
    },
    visualMagnitude: 11.54,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.93476871),
        dec: Angle.Degrees(+18.12510546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -897.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96280",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12623 AB"},
        {"Henry Draper", "HD 184591"},
        {"Hipparcos Number", "HIP 96280"},
        {"Smithsonian Astrophysical Observation", "SAO 104991"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.65596505),
        dec: Angle.Degrees(+18.12806271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79839"},
        {"Hipparcos Number", "HIP 45540"},
        {"Geneva Identification System", "GEN# +1.00079839"},
        {"Smithsonian Astrophysical Observation", "SAO 98471"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.22893066),
        dec: Angle.Degrees(+18.12907555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158227"},
        {"Hipparcos Number", "HIP 85427"},
        {"Smithsonian Astrophysical Observation", "SAO 102830"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.84667094),
        dec: Angle.Degrees(+18.13024125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42351"},
        {"Hipparcos Number", "HIP 29326"},
        {"Geneva Identification System", "GEN# +1.00042351"},
        {"Smithsonian Astrophysical Observation", "SAO 95337"},
        {"Wilson Evans Batten Catalogue", "WEB 5758"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.75737574),
        dec: Angle.Degrees(+18.13047056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168270"},
        {"Hipparcos Number", "HIP 89684"},
        {"Geneva Identification System", "GEN# +1.00168270"},
        {"Smithsonian Astrophysical Observation", "SAO 103581"},
        {"Wilson Evans Batten Catalogue", "WEB 15282"},
    },
    visualMagnitude: 6.24,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.53214741),
        dec: Angle.Degrees(+18.13168429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80888"},
        {"Hipparcos Number", "HIP 45992"},
        {"Smithsonian Astrophysical Observation", "SAO 98534"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.70094723),
        dec: Angle.Degrees(+18.13203262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201979"},
        {"Hipparcos Number", "HIP 104710"},
        {"Smithsonian Astrophysical Observation", "SAO 106918"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.16037745),
        dec: Angle.Degrees(+18.13233860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18096"},
        {"Smithsonian Astrophysical Observation", "SAO 93642"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.02069193),
        dec: Angle.Degrees(+18.13488922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76830"},
        {"Hipparcos Number", "HIP 44126"},
        {"Geneva Identification System", "GEN# +1.00076830"},
        {"Smithsonian Astrophysical Observation", "SAO 98276"},
        {"Wilson Evans Batten Catalogue", "WEB 8477"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.79483391),
        dec: Angle.Degrees(+18.13503174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58479"},
        {"Geneva Identification System", "GEN# +1.00104113B"},
        {"Smithsonian Astrophysical Observation", "SAO 99900"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.89045260),
        dec: Angle.Degrees(+18.13527049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74478"},
        {"Smithsonian Astrophysical Observation", "SAO 101441"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.27877758),
        dec: Angle.Degrees(+18.13606432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245735"},
        {"Hipparcos Number", "HIP 26520"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.59852472),
        dec: Angle.Degrees(+18.13630771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70593"},
        {"Hipparcos Number", "HIP 41120"},
        {"Smithsonian Astrophysical Observation", "SAO 97783"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.85764021),
        dec: Angle.Degrees(+18.13646551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7980"},
        {"Hipparcos Number", "HIP 6187"},
        {"Cincinnati Publication", "Ci 18 168"},
        {"Geneva Identification System", "GEN# +1.00007980"},
        {"Smithsonian Astrophysical Observation", "SAO 92365"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.85075483),
        dec: Angle.Degrees(+18.13791621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213373"},
        {"Hipparcos Number", "HIP 111120"},
        {"Smithsonian Astrophysical Observation", "SAO 107966"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.65886087),
        dec: Angle.Degrees(+18.13901691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69603"},
        {"Smithsonian Astrophysical Observation", "SAO 100933"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.68666987),
        dec: Angle.Degrees(+18.14079850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46137",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7341 AB"},
        {"Henry Draper", "HD 81163"},
        {"Hipparcos Number", "HIP 46137"},
        {"Smithsonian Astrophysical Observation", "SAO 98552"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.13012694),
        dec: Angle.Degrees(+18.14146111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77450",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Gudja"},
        {"Henry Draper", "HD 141477"},
        {"Hipparcos Number", "HIP 77450"},
        {"Fundamental Katalog 5th Edition", "FK5 584"},
        {"Geneva Identification System", "GEN# +1.00141477"},
        {"Smithsonian Astrophysical Observation", "SAO 101752"},
        {"Wilson Evans Batten Catalogue", "WEB 13115"},
    },
    visualMagnitude: 4.09,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.18503586),
        dec: Angle.Degrees(+18.14177930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78142"},
        {"Hipparcos Number", "HIP 44749"},
        {"Smithsonian Astrophysical Observation", "SAO 98371"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.79808373),
        dec: Angle.Degrees(+18.14329548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104113"},
        {"Hipparcos Number", "HIP 58478"},
        {"Geneva Identification System", "GEN# +1.00104113A"},
        {"Smithsonian Astrophysical Observation", "SAO 99899"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.88881546),
        dec: Angle.Degrees(+18.14423954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285973"},
        {"Hipparcos Number", "HIP 21926"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.71762090),
        dec: Angle.Degrees(+18.14518011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48276"},
        {"Hipparcos Number", "HIP 32202"},
        {"Smithsonian Astrophysical Observation", "SAO 96038"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.82652346),
        dec: Angle.Degrees(+18.14535403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38019"},
        {"Hipparcos Number", "HIP 26982"},
        {"Smithsonian Astrophysical Observation", "SAO 94802"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.87713568),
        dec: Angle.Degrees(+18.14537361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36060",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6064 A"},
        {"Henry Draper", "HD 58338"},
        {"Hipparcos Number", "HIP 36060"},
        {"Geneva Identification System", "GEN# +1.00058338"},
        {"Smithsonian Astrophysical Observation", "SAO 96888"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.47553804),
        dec: Angle.Degrees(+18.14750224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74200"},
        {"Hipparcos Number", "HIP 42791"},
        {"Geneva Identification System", "GEN# +1.00074200"},
        {"Smithsonian Astrophysical Observation", "SAO 98066"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.78481697),
        dec: Angle.Degrees(+18.15055479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66378"},
        {"Geneva Identification System", "GEN# +0.01802757"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.13325917),
        dec: Angle.Degrees(+18.15066489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140437"},
        {"Hipparcos Number", "HIP 76975"},
        {"Smithsonian Astrophysical Observation", "SAO 101698"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.75988949),
        dec: Angle.Degrees(+18.15144171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71512"},
        {"Smithsonian Astrophysical Observation", "SAO 101113"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.37796320),
        dec: Angle.Degrees(+18.15199250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94671"},
        {"Hipparcos Number", "HIP 53439"},
        {"Geneva Identification System", "GEN# +1.00094671"},
        {"Smithsonian Astrophysical Observation", "SAO 99358"},
        {"Wilson Evans Batten Catalogue", "WEB 9699"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.98385787),
        dec: Angle.Degrees(+18.15294297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41788"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.80409584),
        dec: Angle.Degrees(+18.15368014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42911",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Asellus Australis"},
        {"Aitken", "ADS 6967 A"},
        {"Henry Draper", "HD 74442"},
        {"Hipparcos Number", "HIP 42911"},
        {"Fundamental Katalog 5th Edition", "FK5 326"},
        {"Geneva Identification System", "GEN# +1.00074442"},
        {"Smithsonian Astrophysical Observation", "SAO 98087"},
        {"Wilson Evans Batten Catalogue", "WEB 8290"},
    },
    visualMagnitude: 3.94,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.17129209),
        dec: Angle.Degrees(+18.15486399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33707"},
        {"Hipparcos Number", "HIP 24298"},
        {"Geneva Identification System", "GEN# +1.00033707"},
        {"Smithsonian Astrophysical Observation", "SAO 94394"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.21430886),
        dec: Angle.Degrees(+18.15503511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100236"},
        {"Hipparcos Number", "HIP 56267"},
        {"Smithsonian Astrophysical Observation", "SAO 99650"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.01503070),
        dec: Angle.Degrees(+18.15516810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112765"},
        {"Smithsonian Astrophysical Observation", "SAO 108208"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.55707860),
        dec: Angle.Degrees(+18.16355636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69768"},
        {"Hipparcos Number", "HIP 40747"},
        {"Smithsonian Astrophysical Observation", "SAO 97724"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.76843506),
        dec: Angle.Degrees(+18.16367240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93205",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11904 AB"},
        {"Henry Draper", "HD 230309"},
        {"Hipparcos Number", "HIP 93205"},
        {"Smithsonian Astrophysical Observation", "SAO 104312"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.77470336),
        dec: Angle.Degrees(+18.16818006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231206"},
        {"Hipparcos Number", "HIP 95111"},
        {"Geneva Identification System", "GEN# +1.00231206"},
        {"Smithsonian Astrophysical Observation", "SAO 104751"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.22658755),
        dec: Angle.Degrees(+18.16880573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
