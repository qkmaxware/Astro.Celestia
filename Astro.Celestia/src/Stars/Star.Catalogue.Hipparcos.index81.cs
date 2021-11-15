using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_81() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103577"},
        {"Hipparcos Number", "HIP 58164"},
        {"Geneva Identification System", "GEN# +1.00103577"},
        {"Smithsonian Astrophysical Observation", "SAO 82053"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.92991006),
        dec: Angle.Degrees(+22.64282843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46276"},
        {"Smithsonian Astrophysical Observation", "SAO 80831"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.53353497),
        dec: Angle.Degrees(+22.64485138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92818",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11820 A"},
        {"Aitken 2", "ADS 11820 AB"},
        {"Henry Draper", "HD 175493"},
        {"Henry Draper 2", "HD 175492"},
        {"Hipparcos Number", "HIP 92818"},
        {"Fundamental Katalog 5th Edition", "FK5 3508"},
        {"Geneva Identification System", "GEN# +1.00175492"},
        {"Smithsonian Astrophysical Observation", "SAO 86567"},
        {"Wilson Evans Batten Catalogue", "WEB 16061"},
    },
    visualMagnitude: 4.57,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.68700483),
        dec: Angle.Degrees(+22.64507357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345011"},
        {"Hipparcos Number", "HIP 97474"},
        {"Geneva Identification System", "GEN# +1.00345011"},
        {"Smithsonian Astrophysical Observation", "SAO 87752"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.17637711),
        dec: Angle.Degrees(+22.64508961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139692"},
        {"Hipparcos Number", "HIP 76621"},
        {"Smithsonian Astrophysical Observation", "SAO 83926"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.71276484),
        dec: Angle.Degrees(+22.64609930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224303"},
        {"Hipparcos Number", "HIP 118048"},
        {"Fundamental Katalog 5th Edition", "FK5 1628"},
        {"Geneva Identification System", "GEN# +1.00224303"},
        {"Smithsonian Astrophysical Observation", "SAO 91595"},
        {"Wilson Evans Batten Catalogue", "WEB 20757"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.17298182),
        dec: Angle.Degrees(+22.64810699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80494"},
        {"Hipparcos Number", "HIP 45830"},
        {"Geneva Identification System", "GEN# +1.00080494"},
        {"Smithsonian Astrophysical Observation", "SAO 80773"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.16856917),
        dec: Angle.Degrees(+22.64814322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217510"},
        {"Hipparcos Number", "HIP 113645"},
        {"Geneva Identification System", "GEN# +1.00217510"},
        {"Smithsonian Astrophysical Observation", "SAO 90942"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.24266499),
        dec: Angle.Degrees(+22.64823679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12869"},
        {"Hipparcos Number", "HIP 9836"},
        {"Celescope Catalog", "CEL 201"},
        {"Geneva Identification System", "GEN# +1.00012869"},
        {"Renson", "Renson 3280"},
        {"Smithsonian Astrophysical Observation", "SAO 75146"},
        {"Wilson Evans Batten Catalogue", "WEB 2066"},
    },
    visualMagnitude: 5.03,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.64130188),
        dec: Angle.Degrees(+22.64840404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134695"},
        {"Hipparcos Number", "HIP 74266"},
        {"Smithsonian Astrophysical Observation", "SAO 83704"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.66525083),
        dec: Angle.Degrees(+22.64902404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79090"},
        {"Smithsonian Astrophysical Observation", "SAO 84209"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.16407446),
        dec: Angle.Degrees(+22.64925106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58808"},
        {"Hipparcos Number", "HIP 36279"},
        {"Smithsonian Astrophysical Observation", "SAO 79409"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.03380897),
        dec: Angle.Degrees(+22.65204055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29450"},
        {"Hipparcos Number", "HIP 21677"},
        {"Geneva Identification System", "GEN# +1.00029450"},
        {"Smithsonian Astrophysical Observation", "SAO 76688"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.80643565),
        dec: Angle.Degrees(+22.65225925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202697"},
        {"Hipparcos Number", "HIP 105063"},
        {"Geneva Identification System", "GEN# +1.00202697"},
        {"Smithsonian Astrophysical Observation", "SAO 89577"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.25200671),
        dec: Angle.Degrees(+22.65689850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103800"},
        {"Hipparcos Number", "HIP 58297"},
        {"Geneva Identification System", "GEN# +1.00103800"},
        {"Smithsonian Astrophysical Observation", "SAO 82069"},
        {"Wilson Evans Batten Catalogue", "WEB 10427"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.32619042),
        dec: Angle.Degrees(+22.65950287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109996"},
        {"Hipparcos Number", "HIP 61719"},
        {"Geneva Identification System", "GEN# +1.00109996"},
        {"Smithsonian Astrophysical Observation", "SAO 82420"},
        {"Wilson Evans Batten Catalogue", "WEB 10980"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.75919869),
        dec: Angle.Degrees(+22.65954468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3378"},
    },
    visualMagnitude: 11.55,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.73544215),
        dec: Angle.Degrees(+22.65957407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 400.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14572"},
        {"Smithsonian Astrophysical Observation", "SAO 75746"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.03542212),
        dec: Angle.Degrees(+22.65963499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22578"},
        {"Hipparcos Number", "HIP 17000"},
        {"Geneva Identification System", "GEN# +5.20223304"},
        {"Smithsonian Astrophysical Observation", "SAO 76043"},
        {"Wilson Evans Batten Catalogue", "WEB 3233"},
    },
    visualMagnitude: 6.71,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.66961700),
        dec: Angle.Degrees(+22.65972170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33880"},
        {"Hipparcos Number", "HIP 24415"},
        {"Smithsonian Astrophysical Observation", "SAO 77045"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.57915994),
        dec: Angle.Degrees(+22.65996506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79894"},
        {"Smithsonian Astrophysical Observation", "SAO 84294"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.61101161),
        dec: Angle.Degrees(+22.66033418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37784"},
        {"Hipparcos Number", "HIP 26853"},
        {"Smithsonian Astrophysical Observation", "SAO 77420"},
        {"Wilson Evans Batten Catalogue", "WEB 5293"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.51660701),
        dec: Angle.Degrees(+22.66038594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284865"},
        {"Hipparcos Number", "HIP 22691"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.19126314),
        dec: Angle.Degrees(+22.66194044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27627"},
        {"Hipparcos Number", "HIP 20412"},
        {"Smithsonian Astrophysical Observation", "SAO 76570"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.57998571),
        dec: Angle.Degrees(+22.66249224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108140"},
    },
    visualMagnitude: 11.22,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.63982961),
        dec: Angle.Degrees(+22.66286509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69504"},
        {"Smithsonian Astrophysical Observation", "SAO 83232"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.43361833),
        dec: Angle.Degrees(+22.66288370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 446"},
        {"Hipparcos Number", "HIP 735"},
        {"Smithsonian Astrophysical Observation", "SAO 73773"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.26322766),
        dec: Angle.Degrees(+22.66426725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86312"},
        {"Hipparcos Number", "HIP 48874"},
        {"Smithsonian Astrophysical Observation", "SAO 81116"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.53011573),
        dec: Angle.Degrees(+22.66433867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96199"},
        {"Hipparcos Number", "HIP 54244"},
        {"Geneva Identification System", "GEN# +1.00096199"},
        {"Smithsonian Astrophysical Observation", "SAO 81664"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.46299847),
        dec: Angle.Degrees(+22.66544832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177572"},
        {"Hipparcos Number", "HIP 93669"},
        {"Geneva Identification System", "GEN# +1.00177572"},
        {"Smithsonian Astrophysical Observation", "SAO 86765"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.10950809),
        dec: Angle.Degrees(+22.66586464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56238"},
        {"Geneva Identification System", "GEN# +0.02302359"},
        {"Wilson Evans Batten Catalogue", "WEB 10113"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.93234431),
        dec: Angle.Degrees(+22.66706057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -583.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73414"},
        {"Smithsonian Astrophysical Observation", "SAO 83611"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.04702672),
        dec: Angle.Degrees(+22.66967268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60700"},
        {"Geneva Identification System", "GEN# +0.02302459"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.60862585),
        dec: Angle.Degrees(+22.67221146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24206"},
        {"Hipparcos Number", "HIP 18097"},
        {"Geneva Identification System", "GEN# +1.00024206"},
        {"Smithsonian Astrophysical Observation", "SAO 76283"},
        {"Wilson Evans Batten Catalogue", "WEB 3493"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.02277927),
        dec: Angle.Degrees(+22.67245692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -340.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284310"},
        {"Hipparcos Number", "HIP 19981"},
        {"Wilson Evans Batten Catalogue", "WEB 3812"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.27832781),
        dec: Angle.Degrees(+22.67341977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2959",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 524 AB"},
        {"Henry Draper", "HD 3455"},
        {"Hipparcos Number", "HIP 2959"},
        {"Smithsonian Astrophysical Observation", "SAO 74152"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.40115074),
        dec: Angle.Degrees(+22.67442815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139621"},
        {"Hipparcos Number", "HIP 76580"},
        {"Smithsonian Astrophysical Observation", "SAO 83922"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.60315106),
        dec: Angle.Degrees(+22.67495573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24702"},
        {"Hipparcos Number", "HIP 18433"},
        {"Geneva Identification System", "GEN# +1.00024702"},
        {"Smithsonian Astrophysical Observation", "SAO 76334"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.11923816),
        dec: Angle.Degrees(+22.67496102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -233.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125054"},
        {"Hipparcos Number", "HIP 69757"},
        {"Smithsonian Astrophysical Observation", "SAO 83263"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.14564408),
        dec: Angle.Degrees(+22.67518218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86515"},
        {"Hipparcos Number", "HIP 48980"},
        {"Smithsonian Astrophysical Observation", "SAO 81130"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.89696860),
        dec: Angle.Degrees(+22.67567583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37939"},
        {"Hipparcos Number", "HIP 26944"},
        {"Smithsonian Astrophysical Observation", "SAO 77443"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.75840044),
        dec: Angle.Degrees(+22.67568966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343290"},
        {"Hipparcos Number", "HIP 92655"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.21225213),
        dec: Angle.Degrees(+22.67590114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54444"},
        {"Geneva Identification System", "GEN# +0.02302309"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.09786741),
        dec: Angle.Degrees(+22.67608019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -259.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52514"},
    },
    visualMagnitude: 10.59,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.06274509),
        dec: Angle.Degrees(+22.67653386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82609",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10243 AB"},
        {"Hipparcos Number", "HIP 82609"},
        {"Smithsonian Astrophysical Observation", "SAO 84666"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.32087732),
        dec: Angle.Degrees(+22.67747434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78622"},
        {"Hipparcos Number", "HIP 45004"},
        {"Smithsonian Astrophysical Observation", "SAO 80668"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.49192354),
        dec: Angle.Degrees(+22.67748512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167764"},
        {"Hipparcos Number", "HIP 89495"},
        {"Smithsonian Astrophysical Observation", "SAO 85870"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.95195307),
        dec: Angle.Degrees(+22.67851548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254755"},
        {"Hipparcos Number", "HIP 29968"},
        {"Geneva Identification System", "GEN# +1.00254755"},
        {"Smithsonian Astrophysical Observation", "SAO 78203"},
        {"Wilson Evans Batten Catalogue", "WEB 5943"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.63238755),
        dec: Angle.Degrees(+22.67920409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121559"},
        {"Hipparcos Number", "HIP 68026"},
        {"Geneva Identification System", "GEN# +1.00121559"},
        {"Smithsonian Astrophysical Observation", "SAO 83076"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.95105631),
        dec: Angle.Degrees(+22.68046459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341518"},
        {"Hipparcos Number", "HIP 88480"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.00353282),
        dec: Angle.Degrees(+22.68128970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53532"},
        {"Hipparcos Number", "HIP 34271"},
        {"Geneva Identification System", "GEN# +1.00053532"},
        {"Smithsonian Astrophysical Observation", "SAO 79056"},
        {"Wilson Evans Batten Catalogue", "WEB 6866"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.57025077),
        dec: Angle.Degrees(+22.68367796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133827"},
        {"Hipparcos Number", "HIP 73872"},
        {"Smithsonian Astrophysical Observation", "SAO 83655"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.46604724),
        dec: Angle.Degrees(+22.68881799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170230"},
        {"Hipparcos Number", "HIP 90453"},
        {"Smithsonian Astrophysical Observation", "SAO 86074"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.85742267),
        dec: Angle.Degrees(+22.68942558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124157"},
        {"Hipparcos Number", "HIP 69318"},
        {"Smithsonian Astrophysical Observation", "SAO 83210"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.81592480),
        dec: Angle.Degrees(+22.69076143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21341",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3311 A"},
        {"Henry Draper", "HD 28976"},
        {"Hipparcos Number", "HIP 21341"},
        {"Geneva Identification System", "GEN# +1.00028976"},
        {"Smithsonian Astrophysical Observation", "SAO 76658"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.68923115),
        dec: Angle.Degrees(+22.69238227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47201"},
        {"Geneva Identification System", "GEN# +0.02302121"},
        {"Wilson Evans Batten Catalogue", "WEB 8881"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.29765051),
        dec: Angle.Degrees(+22.69457414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198135"},
        {"Hipparcos Number", "HIP 102620"},
        {"Geneva Identification System", "GEN# +1.00198135"},
        {"Smithsonian Astrophysical Observation", "SAO 89130"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.92015653),
        dec: Angle.Degrees(+22.69580856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117999"},
        {"Hipparcos Number", "HIP 66168"},
        {"Smithsonian Astrophysical Observation", "SAO 82881"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.44722739),
        dec: Angle.Degrees(+22.69644671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215716"},
        {"Hipparcos Number", "HIP 112463"},
        {"Smithsonian Astrophysical Observation", "SAO 90781"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.70956900),
        dec: Angle.Degrees(+22.69856423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59219"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.18185040),
        dec: Angle.Degrees(+22.69945225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202834"},
        {"Hipparcos Number", "HIP 105150"},
        {"Smithsonian Astrophysical Observation", "SAO 89595"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.50634894),
        dec: Angle.Degrees(+22.69948600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119584"},
        {"Hipparcos Number", "HIP 66992"},
        {"Geneva Identification System", "GEN# +1.00119584"},
        {"Smithsonian Astrophysical Observation", "SAO 82969"},
        {"Wilson Evans Batten Catalogue", "WEB 11805"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.93805500),
        dec: Angle.Degrees(+22.70051305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97005"},
        {"Hipparcos Number", "HIP 54592"},
        {"Geneva Identification System", "GEN# +1.00097005"},
        {"Smithsonian Astrophysical Observation", "SAO 81703"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.58751400),
        dec: Angle.Degrees(+22.70194376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53791"},
        {"Hipparcos Number", "HIP 34356"},
        {"Geneva Identification System", "GEN# +1.00053791"},
        {"Smithsonian Astrophysical Observation", "SAO 79070"},
        {"Wilson Evans Batten Catalogue", "WEB 6887"},
    },
    visualMagnitude: 7.53,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.83865316),
        dec: Angle.Degrees(+22.70354004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7771"},
        {"Hipparcos Number", "HIP 6055"},
        {"Smithsonian Astrophysical Observation", "SAO 74613"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.43830160),
        dec: Angle.Degrees(+22.70369957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345464"},
        {"Hipparcos Number", "HIP 98440"},
        {"Geneva Identification System", "GEN# +1.00345464"},
        {"Smithsonian Astrophysical Observation", "SAO 88041"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.02542463),
        dec: Angle.Degrees(+22.70498595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183681"},
        {"Hipparcos Number", "HIP 95867"},
        {"Geneva Identification System", "GEN# +1.00183681"},
        {"Smithsonian Astrophysical Observation", "SAO 87278"},
        {"Wilson Evans Batten Catalogue", "WEB 16786"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.46981989),
        dec: Angle.Degrees(+22.70663119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169798"},
        {"Hipparcos Number", "HIP 90295"},
        {"Geneva Identification System", "GEN# +1.00169798"},
        {"Smithsonian Astrophysical Observation", "SAO 86026"},
        {"Wilson Evans Batten Catalogue", "WEB 15454"},
    },
    visualMagnitude: 6.80,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.36615530),
        dec: Angle.Degrees(+22.70681302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344394"},
        {"Hipparcos Number", "HIP 95602"},
        {"Geneva Identification System", "GEN# +1.00344394"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.67236964),
        dec: Angle.Degrees(+22.70782965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26675"},
        {"Hipparcos Number", "HIP 19745"},
        {"Smithsonian Astrophysical Observation", "SAO 76510"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.49608957),
        dec: Angle.Degrees(+22.70808382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99359"},
        {"Hipparcos Number", "HIP 55808"},
        {"Geneva Identification System", "GEN# +1.00099359"},
        {"Smithsonian Astrophysical Observation", "SAO 81823"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.53655039),
        dec: Angle.Degrees(+22.70824705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189733"},
        {"Hipparcos Number", "HIP 98505"},
        {"Geneva Identification System", "GEN# +1.00189733"},
        {"Smithsonian Astrophysical Observation", "SAO 88060"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.18214519),
        dec: Angle.Degrees(+22.71146227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106776"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.42484167),
        dec: Angle.Degrees(+22.71170731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79468"},
        {"Hipparcos Number", "HIP 45379"},
        {"Smithsonian Astrophysical Observation", "SAO 80715"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.71973861),
        dec: Angle.Degrees(+22.71184604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190946"},
        {"Hipparcos Number", "HIP 99058"},
        {"Smithsonian Astrophysical Observation", "SAO 88203"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.66747027),
        dec: Angle.Degrees(+22.71198639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42840"},
        {"Smithsonian Astrophysical Observation", "SAO 80384"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.93992967),
        dec: Angle.Degrees(+22.71334061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106985"},
        {"Hipparcos Number", "HIP 59986"},
        {"Geneva Identification System", "GEN# +5.21110051"},
        {"Smithsonian Astrophysical Observation", "SAO 82226"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.54607091),
        dec: Angle.Degrees(+22.71503868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47051"},
        {"Hipparcos Number", "HIP 31667"},
        {"Smithsonian Astrophysical Observation", "SAO 78561"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.41153221),
        dec: Angle.Degrees(+22.71643505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70678",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70678"},
        {"Geneva Identification System", "GEN# +0.02302698"},
        {"Smithsonian Astrophysical Observation", "SAO 83362"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.84492746),
        dec: Angle.Degrees(+22.71646970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343173"},
        {"Hipparcos Number", "HIP 92406"},
        {"Smithsonian Astrophysical Observation", "SAO 86480"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.47331280),
        dec: Angle.Degrees(+22.71871817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111254"},
        {"Hipparcos Number", "HIP 62446"},
        {"Geneva Identification System", "GEN# +1.00111254"},
        {"Smithsonian Astrophysical Observation", "SAO 82499"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.97091877),
        dec: Angle.Degrees(+22.71972611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82610",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82610"},
        {"Smithsonian Astrophysical Observation", "SAO 84667"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.32113552),
        dec: Angle.Degrees(+22.72115021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7119"},
        {"Hipparcos Number", "HIP 5588"},
        {"Geneva Identification System", "GEN# +1.00007119"},
        {"Renson", "Renson 1780"},
        {"Smithsonian Astrophysical Observation", "SAO 74548"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.91749533),
        dec: Angle.Degrees(+22.72214154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84095"},
        {"Smithsonian Astrophysical Observation", "SAO 84902"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.88815546),
        dec: Angle.Degrees(+22.72494387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347685"},
        {"Hipparcos Number", "HIP 103122"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.41184790),
        dec: Angle.Degrees(+22.72584169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44236",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44236"},
        {"Smithsonian Astrophysical Observation", "SAO 80572"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.13628489),
        dec: Angle.Degrees(+22.72696730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179147"},
        {"Hipparcos Number", "HIP 94187"},
        {"Smithsonian Astrophysical Observation", "SAO 86891"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.63149126),
        dec: Angle.Degrees(+22.72728209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71917"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.64666195),
        dec: Angle.Degrees(+22.72986199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198584"},
        {"Hipparcos Number", "HIP 102880"},
        {"Smithsonian Astrophysical Observation", "SAO 89197"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.66064378),
        dec: Angle.Degrees(+22.73039196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123190"},
        {"Hipparcos Number", "HIP 68835"},
        {"Geneva Identification System", "GEN# +1.00123190"},
        {"Smithsonian Astrophysical Observation", "SAO 83159"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.42233013),
        dec: Angle.Degrees(+22.73119564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21840",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3388 A"},
        {"Henry Draper", "HD 284578"},
        {"Hipparcos Number", "HIP 21840"},
        {"Smithsonian Astrophysical Observation", "SAO 76713"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.43064622),
        dec: Angle.Degrees(+22.73159980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63515"},
        {"Hipparcos Number", "HIP 38247"},
        {"Smithsonian Astrophysical Observation", "SAO 79732"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.52844874),
        dec: Angle.Degrees(+22.73176223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11152",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11152"},
    },
    visualMagnitude: 11.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.86076706),
        dec: Angle.Degrees(+22.73548451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49114"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.35417133),
        dec: Angle.Degrees(+22.73765160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45086"},
        {"Hipparcos Number", "HIP 30648"},
        {"Smithsonian Astrophysical Observation", "SAO 78369"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.60388525),
        dec: Angle.Degrees(+22.73824246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106417"},
    },
    visualMagnitude: 12.15,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.30639400),
        dec: Angle.Degrees(+22.74009244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9277"},
        {"Hipparcos Number", "HIP 7119"},
        {"Geneva Identification System", "GEN# +1.00009277"},
        {"Smithsonian Astrophysical Observation", "SAO 74770"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.93520386),
        dec: Angle.Degrees(+22.74128299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20580",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3191 AB"},
        {"Henry Draper", "HD 27832"},
        {"Hipparcos Number", "HIP 20580"},
        {"Smithsonian Astrophysical Observation", "SAO 76595"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.12280584),
        dec: Angle.Degrees(+22.74160111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204935"},
        {"Hipparcos Number", "HIP 106260"},
        {"Smithsonian Astrophysical Observation", "SAO 89774"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.84318561),
        dec: Angle.Degrees(+22.74191470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35832"},
        {"Hipparcos Number", "HIP 25621"},
        {"Smithsonian Astrophysical Observation", "SAO 77191"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.10710734),
        dec: Angle.Degrees(+22.74263338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102926"},
        {"Hipparcos Number", "HIP 57795"},
        {"Fundamental Katalog 5th Edition", "FK5 5043"},
        {"Geneva Identification System", "GEN# +1.00102926"},
        {"Smithsonian Astrophysical Observation", "SAO 82014"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.76752752),
        dec: Angle.Degrees(+22.74325232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155904"},
        {"Hipparcos Number", "HIP 84262"},
        {"Smithsonian Astrophysical Observation", "SAO 84933"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.37551505),
        dec: Angle.Degrees(+22.74574656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66395"},
        {"Smithsonian Astrophysical Observation", "SAO 82901"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.19460053),
        dec: Angle.Degrees(+22.74615661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205420"},
        {"Hipparcos Number", "HIP 106527"},
        {"Geneva Identification System", "GEN# +1.00205420"},
        {"Smithsonian Astrophysical Observation", "SAO 89807"},
        {"Wilson Evans Batten Catalogue", "WEB 19276"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.64153036),
        dec: Angle.Degrees(+22.75465142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171799"},
        {"Hipparcos Number", "HIP 91166"},
        {"Smithsonian Astrophysical Observation", "SAO 86227"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.98215398),
        dec: Angle.Degrees(+22.75553488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182918"},
        {"Hipparcos Number", "HIP 95558"},
        {"Geneva Identification System", "GEN# +1.00182918"},
        {"Smithsonian Astrophysical Observation", "SAO 87202"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.54714943),
        dec: Angle.Degrees(+22.75730599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87890"},
        {"Smithsonian Astrophysical Observation", "SAO 85574"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.30426882),
        dec: Angle.Degrees(+22.75820855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66396",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66396"},
        {"Smithsonian Astrophysical Observation", "SAO 82902"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.19879745),
        dec: Angle.Degrees(+22.75935114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22107"},
        {"Hipparcos Number", "HIP 16668"},
        {"Smithsonian Astrophysical Observation", "SAO 76001"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.62620987),
        dec: Angle.Degrees(+22.75946254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8375"},
        {"Smithsonian Astrophysical Observation", "SAO 74938"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.98032418),
        dec: Angle.Degrees(+22.75966618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69264"},
        {"Hipparcos Number", "HIP 40571"},
        {"Smithsonian Astrophysical Observation", "SAO 80065"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.24284126),
        dec: Angle.Degrees(+22.76264792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187238"},
        {"Hipparcos Number", "HIP 97434"},
        {"Geneva Identification System", "GEN# +1.00187238"},
        {"Smithsonian Astrophysical Observation", "SAO 87735"},
    },
    visualMagnitude: 7.02,
    bvColour: 2.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.04932655),
        dec: Angle.Degrees(+22.76288803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81251"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.93026461),
        dec: Angle.Degrees(+22.76359380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120847"},
        {"Hipparcos Number", "HIP 67640"},
        {"Geneva Identification System", "GEN# +1.00120847"},
        {"Smithsonian Astrophysical Observation", "SAO 83037"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.88664309),
        dec: Angle.Degrees(+22.76487805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53198"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.20690906),
        dec: Angle.Degrees(+22.76650541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112010"},
        {"Smithsonian Astrophysical Observation", "SAO 90703"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.33117523),
        dec: Angle.Degrees(+22.76662509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80651"},
        {"Hipparcos Number", "HIP 45907"},
        {"Smithsonian Astrophysical Observation", "SAO 80782"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.40952658),
        dec: Angle.Degrees(+22.76663456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150553"},
        {"Hipparcos Number", "HIP 81665"},
        {"Geneva Identification System", "GEN# +1.00150553"},
        {"Smithsonian Astrophysical Observation", "SAO 84535"},
        {"Wilson Evans Batten Catalogue", "WEB 13791"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.23648778),
        dec: Angle.Degrees(+22.76809104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2397"},
        {"Cincinnati Publication", "Ci 18 54"},
        {"Geneva Identification System", "GEN# +0.02100055"},
        {"Smithsonian Astrophysical Observation", "SAO 74047"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.62873789),
        dec: Angle.Degrees(+22.76941622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63425"},
        {"Geneva Identification System", "GEN# +0.02302519"},
        {"Smithsonian Astrophysical Observation", "SAO 82597"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.96411730),
        dec: Angle.Degrees(+22.77049051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82963",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82963"},
        {"Smithsonian Astrophysical Observation", "SAO 84716"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.30441124),
        dec: Angle.Degrees(+22.77078252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31086"},
        {"Hipparcos Number", "HIP 22767"},
        {"Smithsonian Astrophysical Observation", "SAO 76816"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.46580122),
        dec: Angle.Degrees(+22.77104199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38361"},
        {"Hipparcos Number", "HIP 27222"},
        {"Smithsonian Astrophysical Observation", "SAO 77532"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.54407261),
        dec: Angle.Degrees(+22.77271374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164696"},
        {"Hipparcos Number", "HIP 88261"},
        {"Smithsonian Astrophysical Observation", "SAO 85646"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.35626489),
        dec: Angle.Degrees(+22.77433250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67047"},
        {"Hipparcos Number", "HIP 39705"},
        {"Geneva Identification System", "GEN# +1.00067047"},
        {"Smithsonian Astrophysical Observation", "SAO 79951"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.73438038),
        dec: Angle.Degrees(+22.77544484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50318"},
        {"Hipparcos Number", "HIP 33097"},
        {"Smithsonian Astrophysical Observation", "SAO 78837"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.40242877),
        dec: Angle.Degrees(+22.77620513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87059"},
        {"Smithsonian Astrophysical Observation", "SAO 85414"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.85450375),
        dec: Angle.Degrees(+22.77857097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258192"},
        {"Hipparcos Number", "HIP 30958"},
        {"Smithsonian Astrophysical Observation", "SAO 78437"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.47426265),
        dec: Angle.Degrees(+22.77900891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67227"},
        {"Hipparcos Number", "HIP 39788"},
        {"Smithsonian Astrophysical Observation", "SAO 79962"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.96151071),
        dec: Angle.Degrees(+22.78268398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4931"},
        {"Smithsonian Astrophysical Observation", "SAO 74451"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.81914590),
        dec: Angle.Degrees(+22.78503901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22992"},
        {"Hipparcos Number", "HIP 17305"},
        {"Geneva Identification System", "GEN# +1.00022992"},
        {"Smithsonian Astrophysical Observation", "SAO 76088"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.56627304),
        dec: Angle.Degrees(+22.78663999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59086"},
        {"Hipparcos Number", "HIP 36386"},
        {"Smithsonian Astrophysical Observation", "SAO 79429"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.32571830),
        dec: Angle.Degrees(+22.78869360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86726"},
        {"Smithsonian Astrophysical Observation", "SAO 85358"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.82523059),
        dec: Angle.Degrees(+22.79317189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109461"},
        {"Cincinnati Publication", "Ci 20 1342"},
        {"Geneva Identification System", "GEN# +0.02204567"},
        {"Smithsonian Astrophysical Observation", "SAO 90288"},
        {"Wilson Evans Batten Catalogue", "WEB 19672"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.63244070),
        dec: Angle.Degrees(+22.79715401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -579.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190750"},
        {"Hipparcos Number", "HIP 98987"},
        {"Smithsonian Astrophysical Observation", "SAO 88178"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.43460212),
        dec: Angle.Degrees(+22.79721893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96563",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12704 AB"},
        {"Henry Draper", "HD 185353"},
        {"Hipparcos Number", "HIP 96563"},
        {"Geneva Identification System", "GEN# +1.00185353J"},
        {"Smithsonian Astrophysical Observation", "SAO 87482"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.46691504),
        dec: Angle.Degrees(+22.79724644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168795"},
        {"Hipparcos Number", "HIP 89898"},
        {"Smithsonian Astrophysical Observation", "SAO 85950"},
    },
    visualMagnitude: 6.80,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.16111566),
        dec: Angle.Degrees(+22.79743201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129813"},
        {"Hipparcos Number", "HIP 72034"},
        {"Smithsonian Astrophysical Observation", "SAO 83494"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.02982660),
        dec: Angle.Degrees(+22.79823703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76792"},
        {"Hipparcos Number", "HIP 44120"},
        {"Smithsonian Astrophysical Observation", "SAO 80556"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.78535654),
        dec: Angle.Degrees(+22.79875789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23823"},
        {"Hipparcos Number", "HIP 17828"},
        {"Celescope Catalog", "CEL 351"},
        {"Geneva Identification System", "GEN# +1.00023823"},
        {"Smithsonian Astrophysical Observation", "SAO 76224"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.22794154),
        dec: Angle.Degrees(+22.79922132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81227"},
        {"Hipparcos Number", "HIP 46187"},
        {"Smithsonian Astrophysical Observation", "SAO 80812"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.25517337),
        dec: Angle.Degrees(+22.79940887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120280"},
        {"Hipparcos Number", "HIP 67342"},
        {"Smithsonian Astrophysical Observation", "SAO 82998"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.03835453),
        dec: Angle.Degrees(+22.80166091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9714"},
        {"Cincinnati Publication", "Ci 20 142"},
        {"Geneva Identification System", "GEN# +0.02200301"},
        {"Wilson Evans Batten Catalogue", "WEB 2041"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.24362351),
        dec: Angle.Degrees(+22.80310342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 359.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -345.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16181",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2552 A"},
        {"Henry Draper", "HD 21467"},
        {"Hipparcos Number", "HIP 16181"},
        {"Geneva Identification System", "GEN# +1.00021467"},
        {"Smithsonian Astrophysical Observation", "SAO 75945"},
        {"Wilson Evans Batten Catalogue", "WEB 3084"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.11069649),
        dec: Angle.Degrees(+22.80427706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143894"},
        {"Hipparcos Number", "HIP 78554"},
        {"Fundamental Katalog 5th Edition", "FK5 3268"},
        {"Geneva Identification System", "GEN# +1.00143894"},
        {"Smithsonian Astrophysical Observation", "SAO 84155"},
        {"Wilson Evans Batten Catalogue", "WEB 13278"},
    },
    visualMagnitude: 4.82,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.57370453),
        dec: Angle.Degrees(+22.80439543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118264"},
        {"Hipparcos Number", "HIP 66312"},
        {"Geneva Identification System", "GEN# +1.00118264"},
        {"Smithsonian Astrophysical Observation", "SAO 82890"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.85236073),
        dec: Angle.Degrees(+22.80568614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143991"},
        {"Hipparcos Number", "HIP 78583"},
        {"Smithsonian Astrophysical Observation", "SAO 84161"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.68582934),
        dec: Angle.Degrees(+22.80586893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42443"},
        {"Smithsonian Astrophysical Observation", "SAO 80321"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.81036859),
        dec: Angle.Degrees(+22.80678633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20071",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3114 AB"},
        {"Henry Draper", "HD 27160"},
        {"Hipparcos Number", "HIP 20071"},
        {"Smithsonian Astrophysical Observation", "SAO 76539"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.56061310),
        dec: Angle.Degrees(+22.80690372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1864"},
        {"Smithsonian Astrophysical Observation", "SAO 73949"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.90578351),
        dec: Angle.Degrees(+22.80744789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45425",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7261 AB"},
        {"Henry Draper", "HD 79553"},
        {"Hipparcos Number", "HIP 45425"},
        {"Smithsonian Astrophysical Observation", "SAO 80722"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.86157848),
        dec: Angle.Degrees(+22.80808987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175956"},
        {"Hipparcos Number", "HIP 93020"},
        {"Geneva Identification System", "GEN# +1.00175956"},
        {"Smithsonian Astrophysical Observation", "SAO 86613"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.26039740),
        dec: Angle.Degrees(+22.80848400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15723"},
        {"Smithsonian Astrophysical Observation", "SAO 75897"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.63170051),
        dec: Angle.Degrees(+22.80994239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212832"},
        {"Hipparcos Number", "HIP 110789"},
        {"Smithsonian Astrophysical Observation", "SAO 90511"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.68589510),
        dec: Angle.Degrees(+22.81215113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63582"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.44002479),
        dec: Angle.Degrees(+22.81297542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28024"},
        {"Hipparcos Number", "HIP 20711"},
        {"Fundamental Katalog 5th Edition", "FK5 2326"},
        {"Geneva Identification System", "GEN# +5.20250060"},
        {"Smithsonian Astrophysical Observation", "SAO 76608"},
        {"Wilson Evans Batten Catalogue", "WEB 3970"},
    },
    visualMagnitude: 4.28,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.57664484),
        dec: Angle.Degrees(+22.81369394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176541"},
        {"Hipparcos Number", "HIP 93270"},
        {"Geneva Identification System", "GEN# +1.00176541"},
        {"Smithsonian Astrophysical Observation", "SAO 86675"},
        {"Wilson Evans Batten Catalogue", "WEB 16174"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.99216447),
        dec: Angle.Degrees(+22.81449194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80318",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80318"},
        {"Smithsonian Astrophysical Observation", "SAO 84347"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.97428879),
        dec: Angle.Degrees(+22.81492945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206793"},
        {"Hipparcos Number", "HIP 107297"},
        {"Smithsonian Astrophysical Observation", "SAO 89935"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.99216944),
        dec: Angle.Degrees(+22.81539445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58989"},
        {"Hipparcos Number", "HIP 36350"},
        {"Smithsonian Astrophysical Observation", "SAO 79424"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.21680534),
        dec: Angle.Degrees(+22.81554112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346159"},
        {"Hipparcos Number", "HIP 99786"},
        {"Smithsonian Astrophysical Observation", "SAO 88397"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.69018943),
        dec: Angle.Degrees(+22.81640051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100128"},
        {"Hipparcos Number", "HIP 56207"},
        {"Geneva Identification System", "GEN# +1.00100128"},
        {"Smithsonian Astrophysical Observation", "SAO 81865"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.83870389),
        dec: Angle.Degrees(+22.81781049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25413"},
        {"Smithsonian Astrophysical Observation", "SAO 77167"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.52808626),
        dec: Angle.Degrees(+22.82182509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16753"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.88200182),
        dec: Angle.Degrees(+22.82369569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195714"},
        {"Hipparcos Number", "HIP 101318"},
        {"Smithsonian Astrophysical Observation", "SAO 88813"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.03770601),
        dec: Angle.Degrees(+22.82434811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167106"},
        {"Hipparcos Number", "HIP 89255"},
        {"Smithsonian Astrophysical Observation", "SAO 85826"},
        {"Wilson Evans Batten Catalogue", "WEB 15174"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.21679691),
        dec: Angle.Degrees(+22.82511172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243549"},
        {"Hipparcos Number", "HIP 25409"},
        {"Smithsonian Astrophysical Observation", "SAO 77166"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.52246981),
        dec: Angle.Degrees(+22.82606225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6966",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1183 AB"},
        {"Henry Draper", "HD 9071"},
        {"Hipparcos Number", "HIP 6966"},
        {"Geneva Identification System", "GEN# +1.00009071"},
        {"Smithsonian Astrophysical Observation", "SAO 74751"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.42153264),
        dec: Angle.Degrees(+22.82623228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115850"},
        {"Hipparcos Number", "HIP 65005"},
        {"Geneva Identification System", "GEN# +1.00115850"},
        {"Smithsonian Astrophysical Observation", "SAO 82780"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.86108352),
        dec: Angle.Degrees(+22.82777288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98116"},
        {"Hipparcos Number", "HIP 55146"},
        {"Smithsonian Astrophysical Observation", "SAO 81753"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.35475869),
        dec: Angle.Degrees(+22.82786482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70545"},
        {"Smithsonian Astrophysical Observation", "SAO 83348"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.46877000),
        dec: Angle.Degrees(+22.82817446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192560"},
        {"Hipparcos Number", "HIP 99783"},
        {"Smithsonian Astrophysical Observation", "SAO 88396"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.68409218),
        dec: Angle.Degrees(+22.82858859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18643"},
        {"Hipparcos Number", "HIP 14024"},
        {"Fundamental Katalog 5th Edition", "FK5 4275"},
        {"Geneva Identification System", "GEN# +1.00018643"},
        {"Smithsonian Astrophysical Observation", "SAO 75681"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.15159815),
        dec: Angle.Degrees(+22.82897089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24668",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3868 AB"},
        {"Henry Draper", "HD 34315"},
        {"Hipparcos Number", "HIP 24668"},
        {"Smithsonian Astrophysical Observation", "SAO 77083"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.38514760),
        dec: Angle.Degrees(+22.82921027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77730"},
        {"Hipparcos Number", "HIP 44586"},
        {"Geneva Identification System", "GEN# +1.00077730"},
        {"Smithsonian Astrophysical Observation", "SAO 80615"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.25022385),
        dec: Angle.Degrees(+22.83208940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 130.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20420"},
        {"Hipparcos Number", "HIP 15341"},
        {"Smithsonian Astrophysical Observation", "SAO 75845"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.45726700),
        dec: Angle.Degrees(+22.83229674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3961"},
        {"Hipparcos Number", "HIP 3325"},
        {"Smithsonian Astrophysical Observation", "SAO 74214"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.59412713),
        dec: Angle.Degrees(+22.83241419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15268",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15268"},
        {"Smithsonian Astrophysical Observation", "SAO 75833"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.23860854),
        dec: Angle.Degrees(+22.83355045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53767"},
        {"Cincinnati Publication", "Ci 20 601"},
        {"Geneva Identification System", "GEN# +9.80058032"},
        {"Wilson Evans Batten Catalogue", "WEB 9740"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.01886286),
        dec: Angle.Degrees(+22.83364286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -426.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -279.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284181"},
        {"Hipparcos Number", "HIP 19484"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.59637555),
        dec: Angle.Degrees(+22.83395393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346902"},
        {"Hipparcos Number", "HIP 101441"},
        {"Smithsonian Astrophysical Observation", "SAO 88832"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.36643569),
        dec: Angle.Degrees(+22.83640260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48548"},
        {"Hipparcos Number", "HIP 32333"},
        {"Smithsonian Astrophysical Observation", "SAO 78696"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.23482869),
        dec: Angle.Degrees(+22.83738214)
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
    primaryId: "HIP 5673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7230"},
        {"Hipparcos Number", "HIP 5673"},
        {"Smithsonian Astrophysical Observation", "SAO 74560"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.22368102),
        dec: Angle.Degrees(+22.83844015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39983"},
        {"Hipparcos Number", "HIP 28166"},
        {"Smithsonian Astrophysical Observation", "SAO 77756"},
        {"Wilson Evans Batten Catalogue", "WEB 5513"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.28081157),
        dec: Angle.Degrees(+22.83897452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52945",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7937 AB"},
        {"Henry Draper", "HD 93741"},
        {"Hipparcos Number", "HIP 52945"},
        {"Smithsonian Astrophysical Observation", "SAO 81540"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.41012644),
        dec: Angle.Degrees(+22.84003203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222"},
        {"Hipparcos Number", "HIP 578"},
        {"Geneva Identification System", "GEN# +1.00000222"},
        {"Smithsonian Astrophysical Observation", "SAO 73750"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.75830785),
        dec: Angle.Degrees(+22.84448874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28621"},
        {"Hipparcos Number", "HIP 21120"},
        {"Geneva Identification System", "GEN# +1.00028621"},
        {"Smithsonian Astrophysical Observation", "SAO 76640"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.89904715),
        dec: Angle.Degrees(+22.84511833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345459"},
        {"Hipparcos Number", "HIP 98523"},
        {"Smithsonian Astrophysical Observation", "SAO 88067"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.23726245),
        dec: Angle.Degrees(+22.84697516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193818"},
        {"Hipparcos Number", "HIP 100390"},
        {"Smithsonian Astrophysical Observation", "SAO 88566"},
        {"Wilson Evans Batten Catalogue", "WEB 18115"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.38352161),
        dec: Angle.Degrees(+22.84888501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78449"},
        {"Smithsonian Astrophysical Observation", "SAO 84140"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.23489959),
        dec: Angle.Degrees(+22.85064613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186310"},
        {"Hipparcos Number", "HIP 96985"},
        {"Smithsonian Astrophysical Observation", "SAO 87607"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.70172519),
        dec: Angle.Degrees(+22.85167713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3989"},
        {"Smithsonian Astrophysical Observation", "SAO 74318"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.82065721),
        dec: Angle.Degrees(+22.85423962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223425"},
        {"Hipparcos Number", "HIP 117479"},
        {"Smithsonian Astrophysical Observation", "SAO 91514"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.32633742),
        dec: Angle.Degrees(+22.85459977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55343"},
        {"Smithsonian Astrophysical Observation", "SAO 81776"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.00577622),
        dec: Angle.Degrees(+22.85837729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22977"},
        {"Hipparcos Number", "HIP 17289"},
        {"Geneva Identification System", "GEN# +5.20223310"},
        {"Smithsonian Astrophysical Observation", "SAO 76086"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.51962648),
        dec: Angle.Degrees(+22.85866532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207816"},
        {"Hipparcos Number", "HIP 107869"},
        {"Fundamental Katalog 5th Edition", "FK5 5929"},
        {"Smithsonian Astrophysical Observation", "SAO 90052"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.82905911),
        dec: Angle.Degrees(+22.85992700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105844"},
        {"Hipparcos Number", "HIP 59382"},
        {"Geneva Identification System", "GEN# +1.00105844"},
        {"Smithsonian Astrophysical Observation", "SAO 82167"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.74852515),
        dec: Angle.Degrees(+22.86200114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63262"},
        {"Smithsonian Astrophysical Observation", "SAO 82585"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.45031084),
        dec: Angle.Degrees(+22.86253841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111591"},
        {"Hipparcos Number", "HIP 62653"},
        {"Geneva Identification System", "GEN# +1.00111591"},
        {"Smithsonian Astrophysical Observation", "SAO 82523"},
        {"Wilson Evans Batten Catalogue", "WEB 11116"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.57179055),
        dec: Angle.Degrees(+22.86356935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214921"},
        {"Hipparcos Number", "HIP 112003"},
        {"Smithsonian Astrophysical Observation", "SAO 90702"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.30730000),
        dec: Angle.Degrees(+22.86420514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149907"},
        {"Hipparcos Number", "HIP 81357"},
        {"Smithsonian Astrophysical Observation", "SAO 84484"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.22446835),
        dec: Angle.Degrees(+22.86825165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11572",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1885 AB"},
        {"Hipparcos Number", "HIP 11572"},
        {"Geneva Identification System", "GEN# +0.02200353J"},
        {"Smithsonian Astrophysical Observation", "SAO 75396"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.28011712),
        dec: Angle.Degrees(+22.86860186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88534"},
        {"Hipparcos Number", "HIP 50048"},
        {"Smithsonian Astrophysical Observation", "SAO 81237"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.27158690),
        dec: Angle.Degrees(+22.86881059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343932"},
        {"Hipparcos Number", "HIP 94427"},
        {"Renson", "Renson 49913"},
        {"Smithsonian Astrophysical Observation", "SAO 86943"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.28617571),
        dec: Angle.Degrees(+22.86900181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122120"},
        {"Hipparcos Number", "HIP 68337"},
        {"Geneva Identification System", "GEN# +1.00122120"},
        {"Smithsonian Astrophysical Observation", "SAO 83112"},
        {"Wilson Evans Batten Catalogue", "WEB 11989"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.83127021),
        dec: Angle.Degrees(+22.86971986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7485"},
        {"Hipparcos Number", "HIP 5867"},
        {"Smithsonian Astrophysical Observation", "SAO 74589"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.81520536),
        dec: Angle.Degrees(+22.87051507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37739"},
        {"Hipparcos Number", "HIP 26828"},
        {"Geneva Identification System", "GEN# +1.00037739"},
        {"Smithsonian Astrophysical Observation", "SAO 77405"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.44428366),
        dec: Angle.Degrees(+22.87065711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 194.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9619"},
        {"Smithsonian Astrophysical Observation", "SAO 75116"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.90719349),
        dec: Angle.Degrees(+22.87288283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158824"},
        {"Hipparcos Number", "HIP 85671"},
        {"Smithsonian Astrophysical Observation", "SAO 85157"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.61156959),
        dec: Angle.Degrees(+22.87301197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60375"},
        {"Smithsonian Astrophysical Observation", "SAO 82279"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.69800908),
        dec: Angle.Degrees(+22.87337611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14595"},
        {"Hipparcos Number", "HIP 11035"},
        {"Geneva Identification System", "GEN# +1.00014595"},
        {"Smithsonian Astrophysical Observation", "SAO 75308"},
        {"Wilson Evans Batten Catalogue", "WEB 2321"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.52762061),
        dec: Angle.Degrees(+22.87359371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55404"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.18323068),
        dec: Angle.Degrees(+22.87470572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214757"},
        {"Hipparcos Number", "HIP 111893"},
        {"Smithsonian Astrophysical Observation", "SAO 90686"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.98227812),
        dec: Angle.Degrees(+22.87699642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11509"},
    },
    visualMagnitude: 11.40,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.09647068),
        dec: Angle.Degrees(+22.87823427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15142"},
        {"Hipparcos Number", "HIP 11406"},
        {"Geneva Identification System", "GEN# +1.00015142"},
        {"Smithsonian Astrophysical Observation", "SAO 75369"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.74458799),
        dec: Angle.Degrees(+22.87875626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347771"},
        {"Hipparcos Number", "HIP 103423"},
        {"Smithsonian Astrophysical Observation", "SAO 89314"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.30741770),
        dec: Angle.Degrees(+22.87888252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1449"},
        {"Hipparcos Number", "HIP 1495"},
        {"Geneva Identification System", "GEN# +1.00001449"},
        {"Smithsonian Astrophysical Observation", "SAO 73884"},
        {"Wilson Evans Batten Catalogue", "WEB 278"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.66514424),
        dec: Angle.Degrees(+22.87965131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108874"},
        {"Hipparcos Number", "HIP 61028"},
        {"Geneva Identification System", "GEN# +5.21110157"},
        {"Smithsonian Astrophysical Observation", "SAO 82344"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.61167130),
        dec: Angle.Degrees(+22.88004600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343635"},
        {"Hipparcos Number", "HIP 93619"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.97471763),
        dec: Angle.Degrees(+22.88012429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -205.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1418"},
        {"Hipparcos Number", "HIP 1480"},
        {"Geneva Identification System", "GEN# +1.00001418"},
        {"Smithsonian Astrophysical Observation", "SAO 73881"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.60405288),
        dec: Angle.Degrees(+22.88026405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14908"},
        {"Smithsonian Astrophysical Observation", "SAO 75790"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.10314521),
        dec: Angle.Degrees(+22.88049799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98574"},
        {"Hipparcos Number", "HIP 55402"},
        {"Smithsonian Astrophysical Observation", "SAO 81783"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.18160654),
        dec: Angle.Degrees(+22.88102613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4885"},
        {"Hipparcos Number", "HIP 3974"},
        {"Smithsonian Astrophysical Observation", "SAO 74315"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.77114856),
        dec: Angle.Degrees(+22.88188533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118138"},
        {"Smithsonian Astrophysical Observation", "SAO 91612"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.44847787),
        dec: Angle.Degrees(+22.88270921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216399"},
        {"Hipparcos Number", "HIP 112929"},
        {"Smithsonian Astrophysical Observation", "SAO 90845"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.07413987),
        dec: Angle.Degrees(+22.88301828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78916"},
        {"Smithsonian Astrophysical Observation", "SAO 84196"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.63069348),
        dec: Angle.Degrees(+22.88338888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36691",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6160 B"},
        {"Hipparcos Number", "HIP 36691"},
        {"Geneva Identification System", "GEN# +1.00059878B"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.21108324),
        dec: Angle.Degrees(+22.88441706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100549"},
        {"Hipparcos Number", "HIP 56446"},
        {"Geneva Identification System", "GEN# +1.00100549"},
        {"Smithsonian Astrophysical Observation", "SAO 81881"},
    },
    visualMagnitude: 9.32,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.59373243),
        dec: Angle.Degrees(+22.88655463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36690",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6160 A"},
        {"Henry Draper", "HD 59878"},
        {"Hipparcos Number", "HIP 36690"},
        {"Geneva Identification System", "GEN# +1.00059878A"},
        {"Smithsonian Astrophysical Observation", "SAO 79489"},
        {"Wilson Evans Batten Catalogue", "WEB 7294"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.21099951),
        dec: Angle.Degrees(+22.88764436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203401"},
        {"Hipparcos Number", "HIP 105435"},
        {"Smithsonian Astrophysical Observation", "SAO 89643"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.34535406),
        dec: Angle.Degrees(+22.88932796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43381",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43381"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.54355583),
        dec: Angle.Degrees(+22.88977021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97309"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.64662711),
        dec: Angle.Degrees(+22.88979737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284532"},
        {"Hipparcos Number", "HIP 21348"},
        {"Geneva Identification System", "GEN# +1.00284532"},
        {"Smithsonian Astrophysical Observation", "SAO 76662"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.70907987),
        dec: Angle.Degrees(+22.89037766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80611"},
        {"Hipparcos Number", "HIP 45884"},
        {"Smithsonian Astrophysical Observation", "SAO 80779"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.33873710),
        dec: Angle.Degrees(+22.89070782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51295"},
        {"Hipparcos Number", "HIP 33497"},
        {"Geneva Identification System", "GEN# +1.00051295"},
        {"Smithsonian Astrophysical Observation", "SAO 78912"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.44344997),
        dec: Angle.Degrees(+22.89289613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148682"},
        {"Hipparcos Number", "HIP 80734"},
        {"Smithsonian Astrophysical Observation", "SAO 84405"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.24379845),
        dec: Angle.Degrees(+22.89495563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166657"},
        {"Hipparcos Number", "HIP 89072"},
        {"Smithsonian Astrophysical Observation", "SAO 85802"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.68457013),
        dec: Angle.Degrees(+22.89598919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211433"},
        {"Hipparcos Number", "HIP 109992"},
        {"Geneva Identification System", "GEN# +1.00211433"},
        {"Renson", "Renson 58700"},
        {"Smithsonian Astrophysical Observation", "SAO 90381"},
        {"Wilson Evans Batten Catalogue", "WEB 19745"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.16792638),
        dec: Angle.Degrees(+22.89614221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206966"},
        {"Hipparcos Number", "HIP 107394"},
        {"Smithsonian Astrophysical Observation", "SAO 89952"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.28790038),
        dec: Angle.Degrees(+22.89630389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346904"},
        {"Hipparcos Number", "HIP 101501"},
        {"Smithsonian Astrophysical Observation", "SAO 88847"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.53486182),
        dec: Angle.Degrees(+22.89630557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16119"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.91419989),
        dec: Angle.Degrees(+22.89788647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40545"},
        {"Hipparcos Number", "HIP 28455"},
        {"Geneva Identification System", "GEN# +1.00040545"},
        {"Smithsonian Astrophysical Observation", "SAO 77831"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.11785965),
        dec: Angle.Degrees(+22.89973432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63910"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.44938362),
        dec: Angle.Degrees(+22.90059809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3151"},
        {"Hipparcos Number", "HIP 2733"},
        {"Fundamental Katalog 5th Edition", "FK5 4050"},
        {"Geneva Identification System", "GEN# +1.00003151"},
        {"Smithsonian Astrophysical Observation", "SAO 74116"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.73007433),
        dec: Angle.Degrees(+22.90272094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131042"},
        {"Hipparcos Number", "HIP 72604"},
        {"Cincinnati Publication", "Ci 20 887"},
        {"Geneva Identification System", "GEN# +1.00131042"},
        {"Smithsonian Astrophysical Observation", "SAO 83555"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.67187990),
        dec: Angle.Degrees(+22.90776407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -432.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134062"},
        {"Hipparcos Number", "HIP 73993"},
        {"Smithsonian Astrophysical Observation", "SAO 83670"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.82229954),
        dec: Angle.Degrees(+22.90837056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42543"},
        {"Hipparcos Number", "HIP 29450"},
        {"Geneva Identification System", "GEN# +1.00042543"},
        {"Smithsonian Astrophysical Observation", "SAO 78098"},
        {"Wilson Evans Batten Catalogue", "WEB 5790"},
    },
    visualMagnitude: 6.51,
    bvColour: 2.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.07957899),
        dec: Angle.Degrees(+22.90851943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6847"},
        {"Hipparcos Number", "HIP 5430"},
        {"Geneva Identification System", "GEN# +1.00006847"},
        {"Smithsonian Astrophysical Observation", "SAO 74521"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.34541134),
        dec: Angle.Degrees(+22.90962363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261572"},
        {"Hipparcos Number", "HIP 31941"},
        {"Smithsonian Astrophysical Observation", "SAO 78624"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.12412530),
        dec: Angle.Degrees(+22.91243733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165435"},
        {"Hipparcos Number", "HIP 88568"},
        {"Fundamental Katalog 5th Edition", "FK5 5594"},
        {"Geneva Identification System", "GEN# +1.00165435"},
        {"Smithsonian Astrophysical Observation", "SAO 85712"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.25770434),
        dec: Angle.Degrees(+22.91431949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107400"},
        {"Hipparcos Number", "HIP 60200"},
        {"Smithsonian Astrophysical Observation", "SAO 82255"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.17545439),
        dec: Angle.Degrees(+22.91444384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64442",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8817 AB"},
        {"Hipparcos Number", "HIP 64442"},
        {"Smithsonian Astrophysical Observation", "SAO 82712"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.12481468),
        dec: Angle.Degrees(+22.91719940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197880"},
        {"Hipparcos Number", "HIP 102461"},
        {"Smithsonian Astrophysical Observation", "SAO 89104"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.43819922),
        dec: Angle.Degrees(+22.92096096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140572"},
        {"Hipparcos Number", "HIP 77021"},
        {"Geneva Identification System", "GEN# +1.00140572"},
        {"Smithsonian Astrophysical Observation", "SAO 83964"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.88770012),
        dec: Angle.Degrees(+22.92096918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157330"},
        {"Hipparcos Number", "HIP 84948"},
        {"Geneva Identification System", "GEN# +1.00157330"},
        {"Smithsonian Astrophysical Observation", "SAO 85031"},
        {"Wilson Evans Batten Catalogue", "WEB 14346"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.42653101),
        dec: Angle.Degrees(+22.92111390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343390"},
        {"Hipparcos Number", "HIP 92859"},
        {"Smithsonian Astrophysical Observation", "SAO 86579"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.83210014),
        dec: Angle.Degrees(+22.92211437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23610"},
        {"Hipparcos Number", "HIP 17694"},
        {"Celescope Catalog", "CEL 339"},
        {"Geneva Identification System", "GEN# +5.20221407"},
        {"Renson", "Renson 6053"},
        {"Smithsonian Astrophysical Observation", "SAO 76196"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.84535261),
        dec: Angle.Degrees(+22.92223144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38525"},
        {"Hipparcos Number", "HIP 27343"},
        {"Smithsonian Astrophysical Observation", "SAO 77559"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.87234748),
        dec: Angle.Degrees(+22.92249131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164900"},
        {"Hipparcos Number", "HIP 88346"},
        {"Geneva Identification System", "GEN# +1.00164900"},
        {"Smithsonian Astrophysical Observation", "SAO 85676"},
        {"Wilson Evans Batten Catalogue", "WEB 14932"},
    },
    visualMagnitude: 6.22,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.62564696),
        dec: Angle.Degrees(+22.92324285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24844"},
        {"Hipparcos Number", "HIP 18531"},
        {"Smithsonian Astrophysical Observation", "SAO 76355"},
        {"Wilson Evans Batten Catalogue", "WEB 3571"},
    },
    visualMagnitude: 8.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.44664805),
        dec: Angle.Degrees(+22.92436790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57953"},
        {"Hipparcos Number", "HIP 35930"},
        {"Smithsonian Astrophysical Observation", "SAO 79364"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.10285861),
        dec: Angle.Degrees(+22.92774816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108103"},
        {"Hipparcos Number", "HIP 60585"},
        {"Geneva Identification System", "GEN# +5.21110112"},
        {"Smithsonian Astrophysical Observation", "SAO 82296"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.26832089),
        dec: Angle.Degrees(+22.92868685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61836"},
        {"Hipparcos Number", "HIP 37522"},
        {"Smithsonian Astrophysical Observation", "SAO 79621"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.52114758),
        dec: Angle.Degrees(+22.92885585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35769"},
        {"Hipparcos Number", "HIP 25586"},
        {"Geneva Identification System", "GEN# +1.00035769"},
        {"Smithsonian Astrophysical Observation", "SAO 77189"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.02524600),
        dec: Angle.Degrees(+22.93065859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122167"},
        {"Hipparcos Number", "HIP 68367"},
        {"Geneva Identification System", "GEN# +1.00122167"},
        {"Smithsonian Astrophysical Observation", "SAO 83116"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.92082192),
        dec: Angle.Degrees(+22.93216664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13627"},
        {"Smithsonian Astrophysical Observation", "SAO 75643"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.87682050),
        dec: Angle.Degrees(+22.93420544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201525"},
        {"Hipparcos Number", "HIP 104457"},
        {"Geneva Identification System", "GEN# +1.00201525"},
        {"Smithsonian Astrophysical Observation", "SAO 89491"},
        {"Wilson Evans Batten Catalogue", "WEB 19016"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.39640468),
        dec: Angle.Degrees(+22.93450790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83343"},
        {"Smithsonian Astrophysical Observation", "SAO 84773"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.49961691),
        dec: Angle.Degrees(+22.93575608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71153"},
        {"Smithsonian Astrophysical Observation", "SAO 83399"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.28992872),
        dec: Angle.Degrees(+22.93713508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193313"},
        {"Hipparcos Number", "HIP 100139"},
        {"Geneva Identification System", "GEN# +1.00193313"},
        {"Smithsonian Astrophysical Observation", "SAO 88499"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.70099538),
        dec: Angle.Degrees(+22.93980335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169168"},
        {"Hipparcos Number", "HIP 90045"},
        {"Smithsonian Astrophysical Observation", "SAO 85978"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.60455572),
        dec: Angle.Degrees(+22.93985255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69175"},
        {"Hipparcos Number", "HIP 40529"},
        {"Geneva Identification System", "GEN# +1.00069175"},
        {"Smithsonian Astrophysical Observation", "SAO 80061"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.13277911),
        dec: Angle.Degrees(+22.94025560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190322"},
        {"Hipparcos Number", "HIP 98772"},
        {"Smithsonian Astrophysical Observation", "SAO 88129"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.91170802),
        dec: Angle.Degrees(+22.94109632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62454"},
    },
    visualMagnitude: 11.38,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.99447488),
        dec: Angle.Degrees(+22.94162497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341640"},
        {"Hipparcos Number", "HIP 88927"},
        {"Smithsonian Astrophysical Observation", "SAO 85779"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.28709018),
        dec: Angle.Degrees(+22.94399138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18955"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.93399914),
        dec: Angle.Degrees(+22.94439335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29935"},
        {"Hipparcos Number", "HIP 22013"},
        {"Smithsonian Astrophysical Observation", "SAO 76729"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.97500613),
        dec: Angle.Degrees(+22.94444992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2128"},
        {"Hipparcos Number", "HIP 2023"},
        {"Smithsonian Astrophysical Observation", "SAO 73973"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.41825751),
        dec: Angle.Degrees(+22.94514483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57744"},
        {"Hipparcos Number", "HIP 35842"},
        {"Geneva Identification System", "GEN# +1.00057744"},
        {"Smithsonian Astrophysical Observation", "SAO 79354"},
        {"Wilson Evans Batten Catalogue", "WEB 7142"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.86730662),
        dec: Angle.Degrees(+22.94543651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207135"},
        {"Hipparcos Number", "HIP 107498"},
        {"Smithsonian Astrophysical Observation", "SAO 89975"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.58945682),
        dec: Angle.Degrees(+22.94633480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117694"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.03320356),
        dec: Angle.Degrees(+22.94677623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113320"},
        {"Hipparcos Number", "HIP 63638"},
        {"Geneva Identification System", "GEN# +1.00113320"},
        {"Smithsonian Astrophysical Observation", "SAO 82620"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.64609656),
        dec: Angle.Degrees(+22.94682543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95189"},
        {"Hipparcos Number", "HIP 53752"},
        {"Smithsonian Astrophysical Observation", "SAO 81611"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.95746478),
        dec: Angle.Degrees(+22.94722601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207089"},
        {"Hipparcos Number", "HIP 107472"},
        {"Fundamental Katalog 5th Edition", "FK5 3739"},
        {"Geneva Identification System", "GEN# +1.00207089"},
        {"Smithsonian Astrophysical Observation", "SAO 89972"},
        {"Wilson Evans Batten Catalogue", "WEB 19401"},
    },
    visualMagnitude: 5.29,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.51816071),
        dec: Angle.Degrees(+22.94888549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94459"},
        {"Hipparcos Number", "HIP 53337"},
        {"Cincinnati Publication", "Ci 18 1321"},
        {"Smithsonian Astrophysical Observation", "SAO 81573"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.63266089),
        dec: Angle.Degrees(+22.94936451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284307"},
        {"Hipparcos Number", "HIP 20270"},
        {"Smithsonian Astrophysical Observation", "SAO 76561"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.17659483),
        dec: Angle.Degrees(+22.94967583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204214"},
        {"Hipparcos Number", "HIP 105875"},
        {"Smithsonian Astrophysical Observation", "SAO 89708"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.64473588),
        dec: Angle.Degrees(+22.94982079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63921"},
        {"Smithsonian Astrophysical Observation", "SAO 82644"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.49275266),
        dec: Angle.Degrees(+22.95222951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346637"},
        {"Hipparcos Number", "HIP 100782"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.50756148),
        dec: Angle.Degrees(+22.95287837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70275"},
        {"Hipparcos Number", "HIP 40984"},
        {"Geneva Identification System", "GEN# +1.00070275"},
        {"Smithsonian Astrophysical Observation", "SAO 80128"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.46310157),
        dec: Angle.Degrees(+22.95296854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60299"},
        {"Hipparcos Number", "HIP 36864"},
        {"Geneva Identification System", "GEN# +1.00060299"},
        {"Smithsonian Astrophysical Observation", "SAO 79519"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.68504061),
        dec: Angle.Degrees(+22.95315712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8743"},
        {"Smithsonian Astrophysical Observation", "SAO 74992"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.12198131),
        dec: Angle.Degrees(+22.95347896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15072",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2414 A"},
        {"Henry Draper", "HD 20078"},
        {"Hipparcos Number", "HIP 15072"},
        {"Smithsonian Astrophysical Observation", "SAO 75806"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.57132248),
        dec: Angle.Degrees(+22.95378876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242904"},
        {"Hipparcos Number", "HIP 25068"},
        {"Smithsonian Astrophysical Observation", "SAO 77128"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.49405638),
        dec: Angle.Degrees(+22.95379971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174436"},
        {"Hipparcos Number", "HIP 92381"},
        {"Geneva Identification System", "GEN# +1.00174436"},
        {"Smithsonian Astrophysical Observation", "SAO 86473"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.39538867),
        dec: Angle.Degrees(+22.95388139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216879"},
        {"Hipparcos Number", "HIP 113282"},
        {"Smithsonian Astrophysical Observation", "SAO 90881"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.09865303),
        dec: Angle.Degrees(+22.95590180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86282",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10675 AB"},
        {"Hipparcos Number", "HIP 86282"},
        {"Geneva Identification System", "GEN# +0.02303151"},
        {"Wilson Evans Batten Catalogue", "WEB 14555"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.45331762),
        dec: Angle.Degrees(+22.95593294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248983"},
        {"Hipparcos Number", "HIP 27926"},
        {"Geneva Identification System", "GEN# +1.00248983"},
        {"Smithsonian Astrophysical Observation", "SAO 77707"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.63997805),
        dec: Angle.Degrees(+22.95615649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6660"},
        {"Henry Draper 2", "HD 6660A"},
        {"Hipparcos Number", "HIP 5286"},
        {"Cincinnati Publication", "Ci 20 80"},
        {"Geneva Identification System", "GEN# +1.00006660"},
        {"Smithsonian Astrophysical Observation", "SAO 74504"},
        {"Wilson Evans Batten Catalogue", "WEB 1126"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.90753784),
        dec: Angle.Degrees(+22.95617138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -491.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29763"},
        {"Hipparcos Number", "HIP 21881"},
        {"Fundamental Katalog 5th Edition", "FK5 174"},
        {"Geneva Identification System", "GEN# +1.00029763J"},
        {"Geneva Identification System 2", "GEN# +1.20029763"},
        {"Smithsonian Astrophysical Observation", "SAO 76721"},
        {"Wilson Evans Batten Catalogue", "WEB 4206"},
    },
    visualMagnitude: 4.27,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.56126452),
        dec: Angle.Degrees(+22.95697545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8401"},
        {"Hipparcos Number", "HIP 6503"},
        {"Smithsonian Astrophysical Observation", "SAO 74683"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.88347851),
        dec: Angle.Degrees(+22.95703383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117029"},
        {"Hipparcos Number", "HIP 65609"},
        {"Smithsonian Astrophysical Observation", "SAO 82845"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.78949145),
        dec: Angle.Degrees(+22.95850996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19702",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3058 AB"},
        {"Hipparcos Number", "HIP 19702"},
        {"Smithsonian Astrophysical Observation", "SAO 76507"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.30834034),
        dec: Angle.Degrees(+22.95881550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157728"},
        {"Hipparcos Number", "HIP 85157"},
        {"Fundamental Katalog 5th Edition", "FK5 3383"},
        {"Geneva Identification System", "GEN# +1.00157728"},
        {"Smithsonian Astrophysical Observation", "SAO 85062"},
        {"Wilson Evans Batten Catalogue", "WEB 14380"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.02756159),
        dec: Angle.Degrees(+22.96037466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17309"},
        {"Hipparcos Number", "HIP 13012"},
        {"Geneva Identification System", "GEN# +1.00017309"},
        {"Smithsonian Astrophysical Observation", "SAO 75571"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.81418433),
        dec: Angle.Degrees(+22.96038572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168604"},
        {"Hipparcos Number", "HIP 89801"},
        {"Smithsonian Astrophysical Observation", "SAO 85926"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.90514326),
        dec: Angle.Degrees(+22.96286959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182551"},
        {"Hipparcos Number", "HIP 95395"},
        {"Smithsonian Astrophysical Observation", "SAO 87161"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.08741924),
        dec: Angle.Degrees(+22.96477555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27760"},
        {"Hipparcos Number", "HIP 20513"},
        {"Smithsonian Astrophysical Observation", "SAO 76588"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.93406815),
        dec: Angle.Degrees(+22.96483225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8586"},
        {"Hipparcos Number", "HIP 6640"},
        {"Geneva Identification System", "GEN# +1.00008586"},
        {"Smithsonian Astrophysical Observation", "SAO 74703"},
        {"Wilson Evans Batten Catalogue", "WEB 1451"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.30008354),
        dec: Angle.Degrees(+22.96730229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15966"},
        {"Hipparcos Number", "HIP 11995"},
        {"Fundamental Katalog 5th Edition", "FK5 4236"},
        {"Geneva Identification System", "GEN# +1.00015966"},
        {"Smithsonian Astrophysical Observation", "SAO 75453"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.66362726),
        dec: Angle.Degrees(+22.96792890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46750",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alterf"},
        {"Henry Draper", "HD 82308"},
        {"Hipparcos Number", "HIP 46750"},
        {"Fundamental Katalog 5th Edition", "FK5 2756"},
        {"Geneva Identification System", "GEN# +1.00082308"},
        {"Smithsonian Astrophysical Observation", "SAO 80885"},
        {"Wilson Evans Batten Catalogue", "WEB 8817"},
    },
    visualMagnitude: 4.32,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.93016816),
        dec: Angle.Degrees(+22.96806545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109070"},
        {"Hipparcos Number", "HIP 61143"},
        {"Geneva Identification System", "GEN# +1.00109070"},
        {"Smithsonian Astrophysical Observation", "SAO 82358"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.94165400),
        dec: Angle.Degrees(+22.96958355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114190"},
        {"Hipparcos Number", "HIP 64143"},
        {"Geneva Identification System", "GEN# +1.00114190"},
        {"Smithsonian Astrophysical Observation", "SAO 82673"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.18225160),
        dec: Angle.Degrees(+22.97159379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61860"},
        {"Geneva Identification System", "GEN# +0.02302484"},
        {"Smithsonian Astrophysical Observation", "SAO 82438"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.17333190),
        dec: Angle.Degrees(+22.97163149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243348"},
        {"Hipparcos Number", "HIP 25312"},
        {"Smithsonian Astrophysical Observation", "SAO 77154"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.21105120),
        dec: Angle.Degrees(+22.97212217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96592"},
        {"Hipparcos Number", "HIP 54399"},
        {"Smithsonian Astrophysical Observation", "SAO 81684"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.97506345),
        dec: Angle.Degrees(+22.97345747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87193",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87193"},
        {"Smithsonian Astrophysical Observation", "SAO 85435"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.20252307),
        dec: Angle.Degrees(+22.97352381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103814"},
        {"Hipparcos Number", "HIP 58300"},
        {"Smithsonian Astrophysical Observation", "SAO 82070"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.33018677),
        dec: Angle.Degrees(+22.97654643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73300"},
    },
    visualMagnitude: 11.42,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.70173185),
        dec: Angle.Degrees(+22.97743906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44768",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7187 AB"},
        {"Henry Draper", "HD 78175"},
        {"Hipparcos Number", "HIP 44768"},
        {"Geneva Identification System", "GEN# +1.00078175"},
        {"Wilson Evans Batten Catalogue", "WEB 8559"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.86254944),
        dec: Angle.Degrees(+22.98086458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346763"},
        {"Hipparcos Number", "HIP 101141"},
        {"Geneva Identification System", "GEN# +1.00346763"},
        {"Smithsonian Astrophysical Observation", "SAO 88767"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.52318879),
        dec: Angle.Degrees(+22.98125101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109348"},
        {"Smithsonian Astrophysical Observation", "SAO 90271"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.28555673),
        dec: Angle.Degrees(+22.98196752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135263"},
        {"Hipparcos Number", "HIP 74505"},
        {"Fundamental Katalog 5th Edition", "FK5 3201"},
        {"Geneva Identification System", "GEN# +1.00135263"},
        {"Smithsonian Astrophysical Observation", "SAO 83723"},
        {"Wilson Evans Batten Catalogue", "WEB 12711"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.38266153),
        dec: Angle.Degrees(+22.98315563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102138",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14169 A"},
        {"Henry Draper", "HD 197246"},
        {"Hipparcos Number", "HIP 102138"},
        {"Smithsonian Astrophysical Observation", "SAO 89020"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.45701039),
        dec: Angle.Degrees(+22.98338596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41907"},
        {"Hipparcos Number", "HIP 29139"},
        {"Smithsonian Astrophysical Observation", "SAO 78030"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.19841006),
        dec: Angle.Degrees(+22.98474585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57540"},
        {"Geneva Identification System", "GEN# +0.02302388"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.89828989),
        dec: Angle.Degrees(+22.98517662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345112"},
        {"Hipparcos Number", "HIP 97716"},
        {"Geneva Identification System", "GEN# +2.68300078"},
        {"New General Catalogue", "NGC 6830 78"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.87809705),
        dec: Angle.Degrees(+22.98554919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171010"},
        {"Hipparcos Number", "HIP 90808"},
        {"Fundamental Katalog 5th Edition", "FK5 5626"},
        {"Geneva Identification System", "GEN# +1.00171010"},
        {"Smithsonian Astrophysical Observation", "SAO 86155"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.86392222),
        dec: Angle.Degrees(+22.98588709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81689"},
        {"Hipparcos Number", "HIP 46403"},
        {"Smithsonian Astrophysical Observation", "SAO 80841"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.94518922),
        dec: Angle.Degrees(+22.98643526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183831"},
        {"Hipparcos Number", "HIP 95933"},
        {"Renson", "Renson 50760"},
        {"Smithsonian Astrophysical Observation", "SAO 87294"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.64525045),
        dec: Angle.Degrees(+22.98739919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25011"},
        {"Hipparcos Number", "HIP 18625"},
        {"Smithsonian Astrophysical Observation", "SAO 76367"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.78930336),
        dec: Angle.Degrees(+22.98842745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80117",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10017 AB"},
        {"Henry Draper", "HD 147442"},
        {"Hipparcos Number", "HIP 80117"},
        {"Smithsonian Astrophysical Observation", "SAO 84317"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.31142762),
        dec: Angle.Degrees(+22.98856451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71427",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71427"},
        {"Smithsonian Astrophysical Observation", "SAO 83430"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.09473555),
        dec: Angle.Degrees(+22.98938727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198315"},
        {"Hipparcos Number", "HIP 102720"},
        {"Smithsonian Astrophysical Observation", "SAO 89156"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.21323373),
        dec: Angle.Degrees(+22.99416849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116435",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116435"},
        {"Smithsonian Astrophysical Observation", "SAO 91364"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.91419046),
        dec: Angle.Degrees(+22.99488891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143513"},
        {"Hipparcos Number", "HIP 78375"},
        {"Geneva Identification System", "GEN# +1.00143513"},
        {"Smithsonian Astrophysical Observation", "SAO 84133"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.00412292),
        dec: Angle.Degrees(+22.99606762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193446"},
        {"Hipparcos Number", "HIP 100206"},
        {"Geneva Identification System", "GEN# +1.00193446"},
        {"Smithsonian Astrophysical Observation", "SAO 88514"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.86557175),
        dec: Angle.Degrees(+22.99620183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28149"},
        {"Hipparcos Number", "HIP 20789"},
        {"Geneva Identification System", "GEN# +1.00028149"},
        {"Smithsonian Astrophysical Observation", "SAO 76613"},
        {"Wilson Evans Batten Catalogue", "WEB 3989"},
    },
    visualMagnitude: 5.53,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.82269876),
        dec: Angle.Degrees(+22.99636881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29288",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4768 AB"},
        {"Henry Draper", "HD 42216"},
        {"Hipparcos Number", "HIP 29288"},
        {"Smithsonian Astrophysical Observation", "SAO 78063"},
        {"Wilson Evans Batten Catalogue", "WEB 5747"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.62473770),
        dec: Angle.Degrees(+22.99787983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252109"},
        {"Hipparcos Number", "HIP 29117"},
        {"Smithsonian Astrophysical Observation", "SAO 78017"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.10294080),
        dec: Angle.Degrees(+22.99807690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43753"},
        {"Hipparcos Number", "HIP 30015"},
        {"Geneva Identification System", "GEN# +1.00043753"},
        {"Smithsonian Astrophysical Observation", "SAO 78211"},
        {"Wilson Evans Batten Catalogue", "WEB 5959"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.74878118),
        dec: Angle.Degrees(+23.00113664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81577",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10146 B"},
        {"Hipparcos Number", "HIP 81577"},
        {"Smithsonian Astrophysical Observation", "SAO 84522"},
        {"Wilson Evans Batten Catalogue", "WEB 13781"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.90636650),
        dec: Angle.Degrees(+23.00170493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81575",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10146 A"},
        {"Henry Draper", "HD 150340"},
        {"Hipparcos Number", "HIP 81575"},
        {"Smithsonian Astrophysical Observation", "SAO 84521"},
        {"Wilson Evans Batten Catalogue", "WEB 13779"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.90128835),
        dec: Angle.Degrees(+23.00174910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62150"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.07563658),
        dec: Angle.Degrees(+23.00177429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85398"},
        {"Hipparcos Number", "HIP 48398"},
        {"Geneva Identification System", "GEN# +1.00085398"},
        {"Smithsonian Astrophysical Observation", "SAO 81055"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.00618030),
        dec: Angle.Degrees(+23.00290185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15640",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15640"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.34080239),
        dec: Angle.Degrees(+23.00783165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43703"},
        {"Hipparcos Number", "HIP 29979"},
        {"Geneva Identification System", "GEN# +1.00043703"},
        {"Smithsonian Astrophysical Observation", "SAO 78205"},
        {"Wilson Evans Batten Catalogue", "WEB 5947"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.66431763),
        dec: Angle.Degrees(+23.00793242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250917"},
        {"Hipparcos Number", "HIP 28736"},
        {"Geneva Identification System", "GEN# +6.20030115"},
        {"Geneva Identification System 2", "GEN# +9.80100056"},
        {"Wilson Evans Batten Catalogue", "WEB 5620"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.99574432),
        dec: Angle.Degrees(+23.00881280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -349.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61223",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8593 AB"},
        {"Hipparcos Number", "HIP 61223"},
        {"Smithsonian Astrophysical Observation", "SAO 82370"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.18769918),
        dec: Angle.Degrees(+23.00992960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198267"},
        {"Hipparcos Number", "HIP 102698"},
        {"Smithsonian Astrophysical Observation", "SAO 89151"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.13352013),
        dec: Angle.Degrees(+23.01175131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246421"},
        {"Hipparcos Number", "HIP 26856"},
        {"Geneva Identification System", "GEN# +1.00246421"},
        {"Smithsonian Astrophysical Observation", "SAO 77422"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.52738179),
        dec: Angle.Degrees(+23.01356624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197868"},
        {"Hipparcos Number", "HIP 102454"},
        {"Geneva Identification System", "GEN# +1.00197868"},
        {"Smithsonian Astrophysical Observation", "SAO 89103"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.41810347),
        dec: Angle.Degrees(+23.01750026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61603"},
        {"Hipparcos Number", "HIP 37428"},
        {"Fundamental Katalog 5th Edition", "FK5 2595"},
        {"Geneva Identification System", "GEN# +1.00061603"},
        {"Smithsonian Astrophysical Observation", "SAO 79607"},
        {"Wilson Evans Batten Catalogue", "WEB 7403"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.24384521),
        dec: Angle.Degrees(+23.01855829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62457"},
        {"Hipparcos Number", "HIP 37799"},
        {"Smithsonian Astrophysical Observation", "SAO 79663"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.25785861),
        dec: Angle.Degrees(+23.01962307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284858"},
        {"Hipparcos Number", "HIP 22751"},
        {"Geneva Identification System", "GEN# +5.20250125"},
        {"Smithsonian Astrophysical Observation", "SAO 76813"},
        {"Wilson Evans Batten Catalogue", "WEB 4401"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.41118104),
        dec: Angle.Degrees(+23.02034019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10309"},
        {"Hipparcos Number", "HIP 7861"},
        {"Fundamental Katalog 5th Edition", "FK5 4150"},
        {"Geneva Identification System", "GEN# +1.00010309"},
        {"Smithsonian Astrophysical Observation", "SAO 74866"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.28001138),
        dec: Angle.Degrees(+23.02531752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94827",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12287 A"},
        {"Henry Draper", "HD 180968"},
        {"Hipparcos Number", "HIP 94827"},
        {"Geneva Identification System", "GEN# +1.00180968"},
        {"Smithsonian Astrophysical Observation", "SAO 87036"},
        {"Wilson Evans Batten Catalogue", "WEB 16549"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.43181365),
        dec: Angle.Degrees(+23.02554904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57099",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57099"},
    },
    visualMagnitude: 11.58,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.57710072),
        dec: Angle.Degrees(+23.02675157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -199.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82101"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.56165735),
        dec: Angle.Degrees(+23.02960813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114247"},
        {"Smithsonian Astrophysical Observation", "SAO 91034"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.07547616),
        dec: Angle.Degrees(+23.03014933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130818"},
        {"Hipparcos Number", "HIP 72528"},
        {"Geneva Identification System", "GEN# +1.00130818"},
        {"Smithsonian Astrophysical Observation", "SAO 83548"},
        {"Wilson Evans Batten Catalogue", "WEB 12471"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.42916115),
        dec: Angle.Degrees(+23.03235044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215183"},
        {"Hipparcos Number", "HIP 112174"},
        {"Smithsonian Astrophysical Observation", "SAO 90735"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.77544143),
        dec: Angle.Degrees(+23.03263275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7570"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.38230548),
        dec: Angle.Degrees(+23.03299173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134921"},
        {"Hipparcos Number", "HIP 74363"},
        {"Smithsonian Astrophysical Observation", "SAO 83711"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.95545187),
        dec: Angle.Degrees(+23.03446572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107168"},
        {"Hipparcos Number", "HIP 60087"},
        {"Geneva Identification System", "GEN# +5.21110062"},
        {"Renson", "Renson 31030"},
        {"Smithsonian Astrophysical Observation", "SAO 82239"},
        {"Wilson Evans Batten Catalogue", "WEB 10680"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.83000395),
        dec: Angle.Degrees(+23.03469539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105303"},
        {"Hipparcos Number", "HIP 59125"},
        {"Geneva Identification System", "GEN# +1.00105303"},
        {"Smithsonian Astrophysical Observation", "SAO 82143"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.86732467),
        dec: Angle.Degrees(+23.04229963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96617",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12731 A"},
        {"Henry Draper", "HD 185529"},
        {"Hipparcos Number", "HIP 96617"},
        {"Smithsonian Astrophysical Observation", "SAO 87494"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.65964323),
        dec: Angle.Degrees(+23.04234093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29050"},
        {"Hipparcos Number", "HIP 21380"},
        {"Geneva Identification System", "GEN# +1.00029050"},
        {"Smithsonian Astrophysical Observation", "SAO 76664"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.82182733),
        dec: Angle.Degrees(+23.04533388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60408"},
        {"Hipparcos Number", "HIP 36898"},
        {"Geneva Identification System", "GEN# +1.00060408"},
        {"Smithsonian Astrophysical Observation", "SAO 79527"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.79716994),
        dec: Angle.Degrees(+23.04589270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199719"},
        {"Hipparcos Number", "HIP 103516"},
        {"Geneva Identification System", "GEN# +1.00199719"},
        {"Smithsonian Astrophysical Observation", "SAO 89334"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.57791221),
        dec: Angle.Degrees(+23.04635180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221113"},
        {"Hipparcos Number", "HIP 115915"},
        {"Smithsonian Astrophysical Observation", "SAO 91295"},
        {"Wilson Evans Batten Catalogue", "WEB 20502"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.27374695),
        dec: Angle.Degrees(+23.04829000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83396"},
        {"Hipparcos Number", "HIP 47323"},
        {"Geneva Identification System", "GEN# +1.00083396"},
        {"Smithsonian Astrophysical Observation", "SAO 80943"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.64780959),
        dec: Angle.Degrees(+23.04869292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259548"},
        {"Hipparcos Number", "HIP 31313"},
        {"Smithsonian Astrophysical Observation", "SAO 78505"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.50666070),
        dec: Angle.Degrees(+23.04912553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205239"},
        {"Hipparcos Number", "HIP 106437"},
        {"Geneva Identification System", "GEN# +1.00205239"},
        {"Smithsonian Astrophysical Observation", "SAO 89797"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.37272551),
        dec: Angle.Degrees(+23.04958472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115165"},
        {"Hipparcos Number", "HIP 64644"},
        {"Geneva Identification System", "GEN# +1.00115165"},
        {"Smithsonian Astrophysical Observation", "SAO 82738"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.75724845),
        dec: Angle.Degrees(+23.05067602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284653"},
        {"Hipparcos Number", "HIP 22253"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.85890853),
        dec: Angle.Degrees(+23.05102247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11850"},
        {"Hipparcos Number", "HIP 9073"},
        {"Geneva Identification System", "GEN# +1.00011850"},
        {"Smithsonian Astrophysical Observation", "SAO 75038"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.19715132),
        dec: Angle.Degrees(+23.05117755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16198"},
        {"Hipparcos Number", "HIP 12159"},
        {"Geneva Identification System", "GEN# +1.00016198"},
        {"Smithsonian Astrophysical Observation", "SAO 75466"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.17509512),
        dec: Angle.Degrees(+23.05311334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41592"},
        {"Hipparcos Number", "HIP 28998"},
        {"Geneva Identification System", "GEN# +1.00041592"},
        {"Smithsonian Astrophysical Observation", "SAO 77975"},
        {"Wilson Evans Batten Catalogue", "WEB 5677"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.77885172),
        dec: Angle.Degrees(+23.05394131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12665"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.68215706),
        dec: Angle.Degrees(+23.05646107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7390"},
        {"Smithsonian Astrophysical Observation", "SAO 74808"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.82654344),
        dec: Angle.Degrees(+23.05761782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220617"},
        {"Hipparcos Number", "HIP 115606"},
        {"Geneva Identification System", "GEN# +1.00220617"},
        {"Smithsonian Astrophysical Observation", "SAO 91249"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.27701025),
        dec: Angle.Degrees(+23.05961516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284658"},
        {"Hipparcos Number", "HIP 21868"},
        {"Smithsonian Astrophysical Observation", "SAO 76719"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.52438314),
        dec: Angle.Degrees(+23.06020777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211984"},
        {"Hipparcos Number", "HIP 110324"},
        {"Smithsonian Astrophysical Observation", "SAO 90434"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.17859451),
        dec: Angle.Degrees(+23.06093268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32641"},
        {"Hipparcos Number", "HIP 23699"},
        {"Fundamental Katalog 5th Edition", "FK5 4467"},
        {"Smithsonian Astrophysical Observation", "SAO 76954"},
        {"Wilson Evans Batten Catalogue", "WEB 4623"},
        {"New General Catalogue", "NGC 1750 1547"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.40715609),
        dec: Angle.Degrees(+23.06106903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65018"},
        {"Geneva Identification System", "GEN# +0.02302561"},
        {"Smithsonian Astrophysical Observation", "SAO 82785"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.92625228),
        dec: Angle.Degrees(+23.06112882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18940"},
        {"Hipparcos Number", "HIP 14230"},
        {"Geneva Identification System", "GEN# +1.00018940"},
        {"Smithsonian Astrophysical Observation", "SAO 75711"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.86910309),
        dec: Angle.Degrees(+23.06147114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51353"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.34008772),
        dec: Angle.Degrees(+23.06209072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33444"},
        {"Hipparcos Number", "HIP 24151"},
        {"Smithsonian Astrophysical Observation", "SAO 77019"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.79758262),
        dec: Angle.Degrees(+23.06407906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148295"},
        {"Hipparcos Number", "HIP 80523"},
        {"Smithsonian Astrophysical Observation", "SAO 84374"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.57455258),
        dec: Angle.Degrees(+23.06468533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347112"},
        {"Hipparcos Number", "HIP 101861"},
        {"Smithsonian Astrophysical Observation", "SAO 88942"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.61289509),
        dec: Angle.Degrees(+23.06861731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6213"},
        {"Hipparcos Number", "HIP 4953"},
        {"Smithsonian Astrophysical Observation", "SAO 74455"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.88330176),
        dec: Angle.Degrees(+23.06975979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219865"},
        {"Hipparcos Number", "HIP 115118"},
        {"Smithsonian Astrophysical Observation", "SAO 91167"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.75899690),
        dec: Angle.Degrees(+23.06994328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175825"},
        {"Hipparcos Number", "HIP 92954"},
        {"Geneva Identification System", "GEN# +1.00175825"},
        {"Smithsonian Astrophysical Observation", "SAO 86595"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.07348943),
        dec: Angle.Degrees(+23.07036610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120229",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 9.37,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)58, 41.7200),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)04, 16.300)
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
    primaryId: "HIP 43856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43856"},
        {"Smithsonian Astrophysical Observation", "SAO 80515"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.01685185),
        dec: Angle.Degrees(+23.07142877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217588"},
        {"Hipparcos Number", "HIP 113692"},
        {"Geneva Identification System", "GEN# +1.00217588"},
        {"Smithsonian Astrophysical Observation", "SAO 90958"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.39600665),
        dec: Angle.Degrees(+23.07331080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177745"},
        {"Hipparcos Number", "HIP 93731"},
        {"Cincinnati Publication", "Ci 18 2491"},
        {"Geneva Identification System", "GEN# +1.00177745"},
        {"Smithsonian Astrophysical Observation", "SAO 86786"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.28071913),
        dec: Angle.Degrees(+23.07719556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 225.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 247.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79990"},
        {"Hipparcos Number", "HIP 45606"},
        {"Fundamental Katalog 5th Edition", "FK5 4826"},
        {"Smithsonian Astrophysical Observation", "SAO 80744"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.44030318),
        dec: Angle.Degrees(+23.07883983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201890"},
        {"Hipparcos Number", "HIP 104648"},
        {"Fundamental Katalog 5th Edition", "FK5 5869"},
        {"Smithsonian Astrophysical Observation", "SAO 89519"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.97845961),
        dec: Angle.Degrees(+23.08063496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44582"},
        {"Hipparcos Number", "HIP 30399"},
        {"Geneva Identification System", "GEN# +1.00044582"},
        {"Smithsonian Astrophysical Observation", "SAO 78315"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.88191400),
        dec: Angle.Degrees(+23.08447652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345104"},
        {"Hipparcos Number", "HIP 97713"},
        {"Geneva Identification System", "GEN# +2.68300072"},
        {"Smithsonian Astrophysical Observation", "SAO 87821"},
        {"New General Catalogue", "NGC 6830 72"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.87083209),
        dec: Angle.Degrees(+23.08517325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177024"},
        {"Hipparcos Number", "HIP 93457"},
        {"Smithsonian Astrophysical Observation", "SAO 86725"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.50364163),
        dec: Angle.Degrees(+23.08528411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65472"},
        {"Hipparcos Number", "HIP 39087"},
        {"Smithsonian Astrophysical Observation", "SAO 79848"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.94488249),
        dec: Angle.Degrees(+23.08696440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86584"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.41619069),
        dec: Angle.Degrees(+23.08892433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103816"},
        {"Smithsonian Astrophysical Observation", "SAO 89388"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.56179457),
        dec: Angle.Degrees(+23.08942092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109905"},
        {"Smithsonian Astrophysical Observation", "SAO 90361"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.90040952),
        dec: Angle.Degrees(+23.08983480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43171"},
        {"Smithsonian Astrophysical Observation", "SAO 80427"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.90013040),
        dec: Angle.Degrees(+23.09006491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156593"},
        {"Hipparcos Number", "HIP 84599"},
        {"Smithsonian Astrophysical Observation", "SAO 84982"},
        {"Wilson Evans Batten Catalogue", "WEB 14284"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.39940050),
        dec: Angle.Degrees(+23.09063832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61747"},
        {"Hipparcos Number", "HIP 37479"},
        {"Smithsonian Astrophysical Observation", "SAO 79616"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.40443840),
        dec: Angle.Degrees(+23.09090199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219992"},
        {"Hipparcos Number", "HIP 115214"},
        {"Smithsonian Astrophysical Observation", "SAO 91179"},
        {"Wilson Evans Batten Catalogue", "WEB 20409"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.04844340),
        dec: Angle.Degrees(+23.09120038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106023"},
        {"Hipparcos Number", "HIP 59486"},
        {"Cincinnati Publication", "Ci 18 1521"},
        {"Smithsonian Astrophysical Observation", "SAO 82180"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.99820860),
        dec: Angle.Degrees(+23.09324957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19166"},
        {"Hipparcos Number", "HIP 14394"},
        {"Smithsonian Astrophysical Observation", "SAO 75729"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.42091938),
        dec: Angle.Degrees(+23.09405762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97778"},
        {"Hipparcos Number", "HIP 54951"},
        {"Fundamental Katalog 5th Edition", "FK5 2897"},
        {"Geneva Identification System", "GEN# +1.00097778"},
        {"Smithsonian Astrophysical Observation", "SAO 81736"},
        {"Wilson Evans Batten Catalogue", "WEB 9916"},
    },
    visualMagnitude: 4.56,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.80101292),
        dec: Angle.Degrees(+23.09552528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70317"},
        {"Hipparcos Number", "HIP 40999"},
        {"Smithsonian Astrophysical Observation", "SAO 80130"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.50592495),
        dec: Angle.Degrees(+23.09713244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46866"},
        {"Hipparcos Number", "HIP 31595"},
        {"Smithsonian Astrophysical Observation", "SAO 78545"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.17647463),
        dec: Angle.Degrees(+23.09805062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97673"},
        {"Geneva Identification System", "GEN# +2.68300007"},
        {"New General Catalogue", "NGC 6830 7"},
    },
    visualMagnitude: 11.25,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.75190807),
        dec: Angle.Degrees(+23.09811082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26128"},
        {"Hipparcos Number", "HIP 19363"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.22289969),
        dec: Angle.Degrees(+23.09864633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189410"},
        {"Hipparcos Number", "HIP 98375"},
        {"Geneva Identification System", "GEN# +1.00189410"},
        {"Smithsonian Astrophysical Observation", "SAO 88016"},
        {"Wilson Evans Batten Catalogue", "WEB 17361"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.79409487),
        dec: Angle.Degrees(+23.10127381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117023"},
        {"Smithsonian Astrophysical Observation", "SAO 91445"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.84668139),
        dec: Angle.Degrees(+23.10223086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51041"},
        {"Smithsonian Astrophysical Observation", "SAO 81333"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.41778417),
        dec: Angle.Degrees(+23.10268566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284953"},
        {"Hipparcos Number", "HIP 23371"},
        {"Smithsonian Astrophysical Observation", "SAO 76899"},
        {"New General Catalogue", "NGC 1750 20"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.37402471),
        dec: Angle.Degrees(+23.10424243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50384",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7712 A"},
        {"Henry Draper", "HD 89125A"},
        {"Henry Draper 2", "HD 89125"},
        {"Hipparcos Number", "HIP 50384"},
        {"Cincinnati Publication", "Ci 20 571"},
        {"Geneva Identification System", "GEN# +1.00089125"},
        {"Smithsonian Astrophysical Observation", "SAO 81270"},
        {"Wilson Evans Batten Catalogue", "WEB 9249"},
    },
    visualMagnitude: 5.81,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.31166926),
        dec: Angle.Degrees(+23.10645604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -413.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160182"},
        {"Hipparcos Number", "HIP 86258"},
        {"Smithsonian Astrophysical Observation", "SAO 85265"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.38878168),
        dec: Angle.Degrees(+23.10728014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68751"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.08948646),
        dec: Angle.Degrees(+23.10855196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86261",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 9.67,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)37, 34.4500),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)06, 36.700)
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
    primaryId: "HIP 35046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55672"},
        {"Hipparcos Number", "HIP 35046"},
        {"Smithsonian Astrophysical Observation", "SAO 79203"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.71820084),
        dec: Angle.Degrees(+23.11105161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173242"},
        {"Hipparcos Number", "HIP 91834"},
        {"Geneva Identification System", "GEN# +1.00173242"},
        {"Smithsonian Astrophysical Observation", "SAO 86366"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.85127091),
        dec: Angle.Degrees(+23.11131852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29225",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4751 AB"},
        {"Henry Draper", "HD 42087"},
        {"Hipparcos Number", "HIP 29225"},
        {"Geneva Identification System", "GEN# +1.00042087J"},
        {"Smithsonian Astrophysical Observation", "SAO 78050"},
        {"Wilson Evans Batten Catalogue", "WEB 5730"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.43327240),
        dec: Angle.Degrees(+23.11346966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185547"},
        {"Hipparcos Number", "HIP 96623"},
        {"Smithsonian Astrophysical Observation", "SAO 87497"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.69174733),
        dec: Angle.Degrees(+23.11425562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169719"},
        {"Hipparcos Number", "HIP 90276"},
        {"Smithsonian Astrophysical Observation", "SAO 86021"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.29950205),
        dec: Angle.Degrees(+23.11449143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1702"},
        {"Smithsonian Astrophysical Observation", "SAO 73917"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.34728093),
        dec: Angle.Degrees(+23.11575241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87595"},
    },
    visualMagnitude: 12.04,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.40233790),
        dec: Angle.Degrees(+23.11686380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81043",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10112 A"},
        {"Henry Draper", "HD 149326"},
        {"Hipparcos Number", "HIP 81043"},
        {"Smithsonian Astrophysical Observation", "SAO 84447"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.29103178),
        dec: Angle.Degrees(+23.11751660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58622"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.32762962),
        dec: Angle.Degrees(+23.11797056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107067"},
        {"Hipparcos Number", "HIP 60025"},
        {"Geneva Identification System", "GEN# +5.21110053"},
        {"Smithsonian Astrophysical Observation", "SAO 82228"},
        {"Wilson Evans Batten Catalogue", "WEB 10667"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.65078580),
        dec: Angle.Degrees(+23.12010044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87597"},
        {"Smithsonian Astrophysical Observation", "SAO 85518"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.40671503),
        dec: Angle.Degrees(+23.12119661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146604"},
        {"Hipparcos Number", "HIP 79724"},
        {"Fundamental Katalog 5th Edition", "FK5 1425"},
        {"Geneva Identification System", "GEN# +1.00146604"},
        {"Smithsonian Astrophysical Observation", "SAO 84274"},
        {"Wilson Evans Batten Catalogue", "WEB 13490"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.06970163),
        dec: Angle.Degrees(+23.12275648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24369"},
        {"Hipparcos Number", "HIP 18181"},
        {"Smithsonian Astrophysical Observation", "SAO 76300"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.33818044),
        dec: Angle.Degrees(+23.12359814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85341"},
        {"Smithsonian Astrophysical Observation", "SAO 85088"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.59291763),
        dec: Angle.Degrees(+23.12405287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210444"},
        {"Hipparcos Number", "HIP 109414"},
        {"Smithsonian Astrophysical Observation", "SAO 90281"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.50932067),
        dec: Angle.Degrees(+23.12589191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20328"},
        {"Hipparcos Number", "HIP 15267"},
        {"Smithsonian Astrophysical Observation", "SAO 75832"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.23744923),
        dec: Angle.Degrees(+23.12693048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16312"},
        {"Hipparcos Number", "HIP 12257"},
        {"Smithsonian Astrophysical Observation", "SAO 75481"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.45523246),
        dec: Angle.Degrees(+23.12855726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171215"},
        {"Hipparcos Number", "HIP 90901"},
        {"Geneva Identification System", "GEN# +1.00171215"},
        {"Smithsonian Astrophysical Observation", "SAO 86169"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.12295698),
        dec: Angle.Degrees(+23.12990075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217783"},
        {"Hipparcos Number", "HIP 113800"},
        {"Geneva Identification System", "GEN# +1.00217783"},
        {"Smithsonian Astrophysical Observation", "SAO 90969"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.68437462),
        dec: Angle.Degrees(+23.13050349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79412"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.10247020),
        dec: Angle.Degrees(+23.13368811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86043"},
        {"Hipparcos Number", "HIP 48743"},
        {"Smithsonian Astrophysical Observation", "SAO 81094"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.13496046),
        dec: Angle.Degrees(+23.13726925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68543"},
        {"Hipparcos Number", "HIP 40293"},
        {"Geneva Identification System", "GEN# +1.00068543"},
        {"Smithsonian Astrophysical Observation", "SAO 80024"},
        {"Wilson Evans Batten Catalogue", "WEB 7857"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.42380599),
        dec: Angle.Degrees(+23.13775848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245545"},
        {"Hipparcos Number", "HIP 26441"},
        {"Celescope Catalog", "CEL 862"},
        {"Geneva Identification System", "GEN# +1.00245545"},
        {"Smithsonian Astrophysical Observation", "SAO 77332"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.40241832),
        dec: Angle.Degrees(+23.13887457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250371"},
        {"Hipparcos Number", "HIP 28537"},
        {"Geneva Identification System", "GEN# +1.00250371C"},
        {"Wilson Evans Batten Catalogue", "WEB 5579"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.36691195),
        dec: Angle.Degrees(+23.14098299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38106",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6378"},
        {"Henry Draper", "HD 63208"},
        {"Henry Draper 2", "HD 63209"},
        {"Hipparcos Number", "HIP 38106"},
        {"Smithsonian Astrophysical Observation", "SAO 79704"},
        {"Wilson Evans Batten Catalogue", "WEB 7510"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.14019136),
        dec: Angle.Degrees(+23.14098449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36501"},
        {"Hipparcos Number", "HIP 26015"},
        {"Smithsonian Astrophysical Observation", "SAO 77246"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.27229612),
        dec: Angle.Degrees(+23.14234392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84215"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.22161956),
        dec: Angle.Degrees(+23.14271489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60830"},
        {"Geneva Identification System", "GEN# +5.21110142"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.01840792),
        dec: Angle.Degrees(+23.14345425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41462",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6816 B"},
        {"Hipparcos Number", "HIP 41462"},
        {"Smithsonian Astrophysical Observation", "SAO 80196"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.85920173),
        dec: Angle.Degrees(+23.14550237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17789"},
        {"Hipparcos Number", "HIP 13362"},
        {"Smithsonian Astrophysical Observation", "SAO 75607"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.98016979),
        dec: Angle.Degrees(+23.14610523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10597"},
        {"Smithsonian Astrophysical Observation", "SAO 75251"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.11204746),
        dec: Angle.Degrees(+23.14707354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17572",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2748 A"},
        {"Henry Draper", "HD 23410"},
        {"Hipparcos Number", "HIP 17572"},
        {"Celescope Catalog", "CEL 323"},
        {"Geneva Identification System", "GEN# +5.20220801"},
        {"Smithsonian Astrophysical Observation", "SAO 76156"},
        {"Wilson Evans Batten Catalogue", "WEB 3337"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.45334190),
        dec: Angle.Degrees(+23.14725691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245546"},
        {"Hipparcos Number", "HIP 26449"},
        {"Geneva Identification System", "GEN# +1.00245546"},
        {"Smithsonian Astrophysical Observation", "SAO 77334"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.40915263),
        dec: Angle.Degrees(+23.14746562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54077",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8041 AB"},
        {"Henry Draper", "HD 95867"},
        {"Hipparcos Number", "HIP 54077"},
        {"Smithsonian Astrophysical Observation", "SAO 81649"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.98773023),
        dec: Angle.Degrees(+23.14764000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249548"},
        {"Hipparcos Number", "HIP 28195"},
        {"Smithsonian Astrophysical Observation", "SAO 77767"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.37282563),
        dec: Angle.Degrees(+23.14830761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341461"},
        {"Hipparcos Number", "HIP 88208"},
        {"Smithsonian Astrophysical Observation", "SAO 85630"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.19379847),
        dec: Angle.Degrees(+23.14847512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115962"},
        {"Smithsonian Astrophysical Observation", "SAO 91303"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.41186271),
        dec: Angle.Degrees(+23.14879399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123438"},
        {"Hipparcos Number", "HIP 68971"},
        {"Smithsonian Astrophysical Observation", "SAO 83175"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.80815838),
        dec: Angle.Degrees(+23.14906864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29419"},
        {"Hipparcos Number", "HIP 21637"},
        {"Geneva Identification System", "GEN# +5.20250105"},
        {"Smithsonian Astrophysical Observation", "SAO 76683"},
        {"Wilson Evans Batten Catalogue", "WEB 4157"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.71343839),
        dec: Angle.Degrees(+23.15010505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16659"},
        {"Smithsonian Astrophysical Observation", "SAO 75997"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.58420550),
        dec: Angle.Degrees(+23.15012474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24711"},
        {"Hipparcos Number", "HIP 18431"},
        {"Geneva Identification System", "GEN# +5.20223334"},
        {"Smithsonian Astrophysical Observation", "SAO 76333"},
        {"Wilson Evans Batten Catalogue", "WEB 3555"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.11712801),
        dec: Angle.Degrees(+23.15038762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75348"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.95727552),
        dec: Angle.Degrees(+23.15091375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118129",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118129"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.42176747),
        dec: Angle.Degrees(+23.15105682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41460",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6816 A"},
        {"Henry Draper", "HD 71309"},
        {"Hipparcos Number", "HIP 41460"},
        {"Smithsonian Astrophysical Observation", "SAO 80195"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.85702881),
        dec: Angle.Degrees(+23.15214167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62978"},
        {"Hipparcos Number", "HIP 38019"},
        {"Smithsonian Astrophysical Observation", "SAO 79693"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.88013537),
        dec: Angle.Degrees(+23.15343055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44781"},
        {"Hipparcos Number", "HIP 30498"},
        {"Smithsonian Astrophysical Observation", "SAO 78330"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.17087127),
        dec: Angle.Degrees(+23.15461883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123878"},
        {"Hipparcos Number", "HIP 69181"},
        {"Geneva Identification System", "GEN# +1.00123878"},
        {"Smithsonian Astrophysical Observation", "SAO 83198"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.41711992),
        dec: Angle.Degrees(+23.15481496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40207"},
        {"Hipparcos Number", "HIP 28272"},
        {"Smithsonian Astrophysical Observation", "SAO 77785"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.60226473),
        dec: Angle.Degrees(+23.15594345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5361"},
        {"Hipparcos Number", "HIP 4344"},
        {"Smithsonian Astrophysical Observation", "SAO 74369"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.92407302),
        dec: Angle.Degrees(+23.15616934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157392"},
        {"Hipparcos Number", "HIP 84976"},
        {"Smithsonian Astrophysical Observation", "SAO 85038"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.51894492),
        dec: Angle.Degrees(+23.16122747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93781"},
        {"Hipparcos Number", "HIP 52956"},
        {"Geneva Identification System", "GEN# +1.00093781"},
        {"Smithsonian Astrophysical Observation", "SAO 81541"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.46219642),
        dec: Angle.Degrees(+23.16283572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4322"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.82554971),
        dec: Angle.Degrees(+23.16371360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219237"},
        {"Hipparcos Number", "HIP 114715"},
        {"Smithsonian Astrophysical Observation", "SAO 91109"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.56485863),
        dec: Angle.Degrees(+23.16413088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94587"},
        {"Hipparcos Number", "HIP 53414"},
        {"Geneva Identification System", "GEN# +1.00094587"},
        {"Smithsonian Astrophysical Observation", "SAO 81582"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.87458721),
        dec: Angle.Degrees(+23.16423195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193078"},
        {"Hipparcos Number", "HIP 100026"},
        {"Smithsonian Astrophysical Observation", "SAO 88472"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.41104791),
        dec: Angle.Degrees(+23.16720089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73731"},
        {"Smithsonian Astrophysical Observation", "SAO 83642"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.07710322),
        dec: Angle.Degrees(+23.16733412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53230"},
        {"Hipparcos Number", "HIP 34180"},
        {"Smithsonian Astrophysical Observation", "SAO 79040"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.32109506),
        dec: Angle.Degrees(+23.16736851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14262"},
        {"Henry Draper 2", "HD 14263"},
        {"Hipparcos Number", "HIP 10795"},
        {"Geneva Identification System", "GEN# +1.00014262"},
        {"Smithsonian Astrophysical Observation", "SAO 75277"},
        {"Wilson Evans Batten Catalogue", "WEB 2273"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.74149127),
        dec: Angle.Degrees(+23.16783614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25695"},
        {"Hipparcos Number", "HIP 19078"},
        {"Smithsonian Astrophysical Observation", "SAO 76441"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.35007973),
        dec: Angle.Degrees(+23.16866175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245380"},
        {"Hipparcos Number", "HIP 26365"},
        {"Geneva Identification System", "GEN# +1.00245380"},
        {"Smithsonian Astrophysical Observation", "SAO 77319"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.22623298),
        dec: Angle.Degrees(+23.17349197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47679"},
        {"Hipparcos Number", "HIP 31975"},
        {"Smithsonian Astrophysical Observation", "SAO 78628"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.23619167),
        dec: Angle.Degrees(+23.17499100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24769"},
        {"Hipparcos Number", "HIP 18485"},
        {"Geneva Identification System", "GEN# +1.00024769"},
        {"Renson", "Renson 6330"},
        {"Smithsonian Astrophysical Observation", "SAO 76343"},
        {"Wilson Evans Batten Catalogue", "WEB 3563"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.26584139),
        dec: Angle.Degrees(+23.17559132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77565"},
        {"Smithsonian Astrophysical Observation", "SAO 84026"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.53731427),
        dec: Angle.Degrees(+23.17588235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9187"},
        {"Hipparcos Number", "HIP 7048"},
        {"Geneva Identification System", "GEN# +1.00009187"},
        {"Smithsonian Astrophysical Observation", "SAO 74766"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.71078434),
        dec: Angle.Degrees(+23.17653309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66026"},
        {"Geneva Identification System", "GEN# +0.02302578"},
        {"Smithsonian Astrophysical Observation", "SAO 82873"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.04950842),
        dec: Angle.Degrees(+23.17700819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344787"},
        {"Hipparcos Number", "HIP 97057"},
        {"Geneva Identification System", "GEN# +2.68230035"},
        {"Smithsonian Astrophysical Observation", "SAO 87628"},
        {"New General Catalogue", "NGC 6823 35"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.87244442),
        dec: Angle.Degrees(+23.17796319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46279"},
        {"Hipparcos Number", "HIP 31268"},
        {"Smithsonian Astrophysical Observation", "SAO 78493"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.36362138),
        dec: Angle.Degrees(+23.17871576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136694"},
        {"Hipparcos Number", "HIP 75139"},
        {"Geneva Identification System", "GEN# +1.00136694"},
        {"Smithsonian Astrophysical Observation", "SAO 83783"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.33175832),
        dec: Angle.Degrees(+23.18090575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65471"},
        {"Hipparcos Number", "HIP 39077"},
        {"Smithsonian Astrophysical Observation", "SAO 79847"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.92757447),
        dec: Angle.Degrees(+23.18295980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20697"},
        {"Hipparcos Number", "HIP 15586"},
        {"Geneva Identification System", "GEN# +1.00020697"},
        {"Smithsonian Astrophysical Observation", "SAO 75882"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.19048050),
        dec: Angle.Degrees(+23.18400045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116636"},
        {"Hipparcos Number", "HIP 65419"},
        {"Geneva Identification System", "GEN# +1.00116636"},
        {"Smithsonian Astrophysical Observation", "SAO 82822"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.13039038),
        dec: Angle.Degrees(+23.18779066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206296"},
        {"Hipparcos Number", "HIP 107034"},
        {"Smithsonian Astrophysical Observation", "SAO 89898"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.15815100),
        dec: Angle.Degrees(+23.18829586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92825"},
        {"Hipparcos Number", "HIP 52457"},
        {"Fundamental Katalog 5th Edition", "FK5 405"},
        {"Geneva Identification System", "GEN# +1.00092825"},
        {"Smithsonian Astrophysical Observation", "SAO 81490"},
        {"Wilson Evans Batten Catalogue", "WEB 9555"},
    },
    visualMagnitude: 5.08,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.85429114),
        dec: Angle.Degrees(+23.18838442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86056"},
        {"Smithsonian Astrophysical Observation", "SAO 85227"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.80523843),
        dec: Angle.Degrees(+23.18939654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83004"},
        {"Hipparcos Number", "HIP 47112"},
        {"Smithsonian Astrophysical Observation", "SAO 80917"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.01882218),
        dec: Angle.Degrees(+23.19155095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99662"},
        {"Hipparcos Number", "HIP 55966"},
        {"Smithsonian Astrophysical Observation", "SAO 81841"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.03014712),
        dec: Angle.Degrees(+23.19177798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70750"},
    },
    visualMagnitude: 11.24,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.04090109),
        dec: Angle.Degrees(+23.19290439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344788"},
        {"Hipparcos Number", "HIP 97003"},
        {"Geneva Identification System", "GEN# +2.68230189"},
        {"Smithsonian Astrophysical Observation", "SAO 87613"},
        {"New General Catalogue", "NGC 6823 189"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.73993631),
        dec: Angle.Degrees(+23.19307279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2573",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 451 A"},
        {"Henry Draper", "HD 2925"},
        {"Hipparcos Number", "HIP 2573"},
        {"Geneva Identification System", "GEN# +1.00002925"},
        {"Smithsonian Astrophysical Observation", "SAO 74086"},
        {"Wilson Evans Batten Catalogue", "WEB 472"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.16444027),
        dec: Angle.Degrees(+23.19336931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150946"},
        {"Hipparcos Number", "HIP 81875"},
        {"Smithsonian Astrophysical Observation", "SAO 84563"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.86177538),
        dec: Angle.Degrees(+23.19640712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46466"},
        {"Hipparcos Number", "HIP 31364"},
        {"Smithsonian Astrophysical Observation", "SAO 78516"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.65065012),
        dec: Angle.Degrees(+23.20059425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25201"},
        {"Hipparcos Number", "HIP 18748"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.23670892),
        dec: Angle.Degrees(+23.20157634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24518"},
        {"Hipparcos Number", "HIP 18296"},
        {"Smithsonian Astrophysical Observation", "SAO 76314"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.68574858),
        dec: Angle.Degrees(+23.20161008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49381"},
        {"Hipparcos Number", "HIP 32688"},
        {"Smithsonian Astrophysical Observation", "SAO 78771"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.28578564),
        dec: Angle.Degrees(+23.20193732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113380"},
        {"Hipparcos Number", "HIP 63682"},
        {"Geneva Identification System", "GEN# +1.00113380"},
        {"Smithsonian Astrophysical Observation", "SAO 82624"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.76046437),
        dec: Angle.Degrees(+23.20241182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37967"},
        {"Hipparcos Number", "HIP 26964"},
        {"Geneva Identification System", "GEN# +1.00037967"},
        {"Smithsonian Astrophysical Observation", "SAO 77450"},
        {"Wilson Evans Batten Catalogue", "WEB 5315"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.83124380),
        dec: Angle.Degrees(+23.20441036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105085"},
        {"Hipparcos Number", "HIP 59015"},
        {"Geneva Identification System", "GEN# +1.00105085"},
        {"Smithsonian Astrophysical Observation", "SAO 82136"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.50346360),
        dec: Angle.Degrees(+23.20464599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68510"},
        {"Geneva Identification System", "GEN# +0.02302643"},
        {"Smithsonian Astrophysical Observation", "SAO 83132"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.37080827),
        dec: Angle.Degrees(+23.20571631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64397"},
        {"Smithsonian Astrophysical Observation", "SAO 82703"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.97892109),
        dec: Angle.Degrees(+23.20623683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347680"},
        {"Hipparcos Number", "HIP 103202"},
        {"Smithsonian Astrophysical Observation", "SAO 89269"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.64308391),
        dec: Angle.Degrees(+23.20654392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179937"},
        {"Hipparcos Number", "HIP 94471"},
        {"Smithsonian Astrophysical Observation", "SAO 86952"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.41145711),
        dec: Angle.Degrees(+23.20701710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42474"},
        {"Hipparcos Number", "HIP 29425"},
        {"Geneva Identification System", "GEN# +1.00042474"},
        {"Smithsonian Astrophysical Observation", "SAO 78094"},
        {"Wilson Evans Batten Catalogue", "WEB 5775"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.98437946),
        dec: Angle.Degrees(+23.20706168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150362"},
        {"Hipparcos Number", "HIP 81587"},
        {"Smithsonian Astrophysical Observation", "SAO 84524"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.93335662),
        dec: Angle.Degrees(+23.20727299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244354"},
        {"Hipparcos Number", "HIP 25848"},
        {"Smithsonian Astrophysical Observation", "SAO 77222"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.76826077),
        dec: Angle.Degrees(+23.20975493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87180"},
        {"Smithsonian Astrophysical Observation", "SAO 85433"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.17578403),
        dec: Angle.Degrees(+23.20985962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138934"},
        {"Hipparcos Number", "HIP 76235"},
        {"Smithsonian Astrophysical Observation", "SAO 83890"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.58903652),
        dec: Angle.Degrees(+23.21020976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190590"},
        {"Hipparcos Number", "HIP 98897"},
        {"Geneva Identification System", "GEN# +1.00190590"},
        {"Smithsonian Astrophysical Observation", "SAO 88163"},
        {"Wilson Evans Batten Catalogue", "WEB 17556"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.24409217),
        dec: Angle.Degrees(+23.21036653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22374"},
        {"Hipparcos Number", "HIP 16859"},
        {"Fundamental Katalog 5th Edition", "FK5 4324"},
        {"Geneva Identification System", "GEN# +1.00022374"},
        {"Renson", "Renson 5660"},
        {"Smithsonian Astrophysical Observation", "SAO 76029"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.24181123),
        dec: Angle.Degrees(+23.21111378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64399"},
        {"Smithsonian Astrophysical Observation", "SAO 82705"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.98639193),
        dec: Angle.Degrees(+23.21225852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48143"},
        {"Hipparcos Number", "HIP 32157"},
        {"Geneva Identification System", "GEN# +1.00048143"},
        {"Smithsonian Astrophysical Observation", "SAO 78665"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.72490764),
        dec: Angle.Degrees(+23.21385690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33035"},
        {"Hipparcos Number", "HIP 23917"},
        {"Renson", "Renson 8447"},
        {"Smithsonian Astrophysical Observation", "SAO 76977"},
        {"New General Catalogue", "NGC 1750 2381"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.08481908),
        dec: Angle.Degrees(+23.21448990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82184"},
        {"Geneva Identification System", "GEN# +0.02302998"},
        {"Smithsonian Astrophysical Observation", "SAO 84606"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.85278101),
        dec: Angle.Degrees(+23.21599684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13364"},
        {"Hipparcos Number", "HIP 10201"},
        {"Geneva Identification System", "GEN# +1.00013364"},
        {"Smithsonian Astrophysical Observation", "SAO 75187"},
        {"Wilson Evans Batten Catalogue", "WEB 2130"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.78901169),
        dec: Angle.Degrees(+23.21684981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25851"},
        {"Renson", "Renson 9353"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.77306395),
        dec: Angle.Degrees(+23.21782047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50856"},
        {"Smithsonian Astrophysical Observation", "SAO 81323"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.77177309),
        dec: Angle.Degrees(+23.21878142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13212"},
        {"Hipparcos Number", "HIP 10070"},
        {"Geneva Identification System", "GEN# +1.00013212"},
        {"Smithsonian Astrophysical Observation", "SAO 75174"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.39641092),
        dec: Angle.Degrees(+23.21893960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54898"},
        {"Hipparcos Number", "HIP 34749"},
        {"Smithsonian Astrophysical Observation", "SAO 79145"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.90893441),
        dec: Angle.Degrees(+23.22373676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49201"},
        {"Hipparcos Number", "HIP 32614"},
        {"Geneva Identification System", "GEN# +1.00049201"},
        {"Smithsonian Astrophysical Observation", "SAO 78758"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.07393441),
        dec: Angle.Degrees(+23.22401928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 262919"},
        {"Hipparcos Number", "HIP 32325"},
        {"Smithsonian Astrophysical Observation", "SAO 78695"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.22236282),
        dec: Angle.Degrees(+23.22784336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108154"},
        {"Hipparcos Number", "HIP 60611"},
        {"Geneva Identification System", "GEN# +5.21110114"},
        {"Smithsonian Astrophysical Observation", "SAO 82298"},
        {"Wilson Evans Batten Catalogue", "WEB 10783"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.34376546),
        dec: Angle.Degrees(+23.22911268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39155"},
        {"Hipparcos Number", "HIP 27685"},
        {"Smithsonian Astrophysical Observation", "SAO 77641"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.91445184),
        dec: Angle.Degrees(+23.23000523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81003",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10107 AB"},
        {"Henry Draper", "HD 149224"},
        {"Hipparcos Number", "HIP 81003"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.13943193),
        dec: Angle.Degrees(+23.23205009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163309"},
        {"Hipparcos Number", "HIP 87682"},
        {"Smithsonian Astrophysical Observation", "SAO 85529"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.63183645),
        dec: Angle.Degrees(+23.23233841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6555"},
        {"Hipparcos Number", "HIP 5213"},
        {"Smithsonian Astrophysical Observation", "SAO 74494"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.66100561),
        dec: Angle.Degrees(+23.23285317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62281"},
        {"Smithsonian Astrophysical Observation", "SAO 82480"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.45087763),
        dec: Angle.Degrees(+23.23323864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50394"},
        {"Smithsonian Astrophysical Observation", "SAO 81273"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.35432314),
        dec: Angle.Degrees(+23.23329310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19050"},
        {"Geneva Identification System", "GEN# +6.20058012"},
    },
    visualMagnitude: 10.71,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.22233037),
        dec: Angle.Degrees(+23.23631517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74978"},
        {"Smithsonian Astrophysical Observation", "SAO 83764"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.82910346),
        dec: Angle.Degrees(+23.23643619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35074"},
        {"Smithsonian Astrophysical Observation", "SAO 79211"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.79666885),
        dec: Angle.Degrees(+23.23798048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40915"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.25207311),
        dec: Angle.Degrees(+23.24008175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108727"},
        {"Smithsonian Astrophysical Observation", "SAO 90173"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.37211117),
        dec: Angle.Degrees(+23.24148662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141529"},
        {"Hipparcos Number", "HIP 77459"},
        {"Fundamental Katalog 5th Edition", "FK5 5397"},
        {"Geneva Identification System", "GEN# +1.00141529"},
        {"Smithsonian Astrophysical Observation", "SAO 84016"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.22132324),
        dec: Angle.Degrees(+23.24164791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217242"},
        {"Hipparcos Number", "HIP 113494"},
        {"Smithsonian Astrophysical Observation", "SAO 90916"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.77175172),
        dec: Angle.Degrees(+23.24205098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6796"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.86457938),
        dec: Angle.Degrees(+23.24458807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184198"},
        {"Hipparcos Number", "HIP 96110"},
        {"Geneva Identification System", "GEN# +1.00184198"},
        {"Smithsonian Astrophysical Observation", "SAO 87329"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.10971785),
        dec: Angle.Degrees(+23.24526675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37400",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6267 AB"},
        {"Henry Draper", "HD 61562"},
        {"Hipparcos Number", "HIP 37400"},
        {"Smithsonian Astrophysical Observation", "SAO 79603"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.18872969),
        dec: Angle.Degrees(+23.24651507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42253",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6891 AB"},
        {"Hipparcos Number", "HIP 42253"},
        {"Smithsonian Astrophysical Observation", "SAO 80288"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.23271178),
        dec: Angle.Degrees(+23.24690795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199740"},
        {"Hipparcos Number", "HIP 103529"},
        {"Geneva Identification System", "GEN# +1.00199740"},
        {"Smithsonian Astrophysical Observation", "SAO 89339"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.61731642),
        dec: Angle.Degrees(+23.24749425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128402"},
        {"Hipparcos Number", "HIP 71406"},
        {"Fundamental Katalog 5th Edition", "FK5 3157"},
        {"Geneva Identification System", "GEN# +1.00128402"},
        {"Smithsonian Astrophysical Observation", "SAO 83427"},
        {"Wilson Evans Batten Catalogue", "WEB 12324"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.02866131),
        dec: Angle.Degrees(+23.25029315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3673",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 650 AB"},
        {"Henry Draper", "HD 4463"},
        {"Hipparcos Number", "HIP 3673"},
        {"Smithsonian Astrophysical Observation", "SAO 74263"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.75343602),
        dec: Angle.Degrees(+23.25069140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94719"},
        {"Hipparcos Number", "HIP 53476"},
        {"Geneva Identification System", "GEN# +1.00094719"},
        {"Smithsonian Astrophysical Observation", "SAO 81590"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.08952328),
        dec: Angle.Degrees(+23.25073612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170828"},
        {"Hipparcos Number", "HIP 90718"},
        {"Smithsonian Astrophysical Observation", "SAO 86139"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.63510516),
        dec: Angle.Degrees(+23.25239082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7182"},
        {"Hipparcos Number", "HIP 5640"},
        {"Geneva Identification System", "GEN# +1.00007182"},
        {"Smithsonian Astrophysical Observation", "SAO 74554"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.11926204),
        dec: Angle.Degrees(+23.25571117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162527"},
        {"Hipparcos Number", "HIP 87321"},
        {"Smithsonian Astrophysical Observation", "SAO 85465"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.63866559),
        dec: Angle.Degrees(+23.25595102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100374"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.34871698),
        dec: Angle.Degrees(+23.25598083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1254"},
        {"Hipparcos Number", "HIP 1353"},
        {"Fundamental Katalog 5th Edition", "FK5 4031"},
        {"Smithsonian Astrophysical Observation", "SAO 73868"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.22905149),
        dec: Angle.Degrees(+23.25623242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36560"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.80739285),
        dec: Angle.Degrees(+23.25717424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 230.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196792"},
        {"Hipparcos Number", "HIP 101888"},
        {"Wilson Evans Batten Catalogue", "WEB 18410"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.71953297),
        dec: Angle.Degrees(+23.25864724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84468",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84468"},
        {"Smithsonian Astrophysical Observation", "SAO 84960"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.03167243),
        dec: Angle.Degrees(+23.26025322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41116"},
        {"Hipparcos Number", "HIP 28734"},
        {"Fundamental Katalog 5th Edition", "FK5 1163"},
        {"Geneva Identification System", "GEN# +1.00041116"},
        {"Smithsonian Astrophysical Observation", "SAO 77915"},
        {"Wilson Evans Batten Catalogue", "WEB 5621"},
    },
    visualMagnitude: 4.16,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.03006890),
        dec: Angle.Degrees(+23.26363207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345827"},
        {"Hipparcos Number", "HIP 99178"},
        {"Smithsonian Astrophysical Observation", "SAO 88222"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.03067009),
        dec: Angle.Degrees(+23.26431636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106947"},
        {"Geneva Identification System", "GEN# +0.02204454"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.90182890),
        dec: Angle.Degrees(+23.26502496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 204.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59609"},
        {"Geneva Identification System", "GEN# +5.21110023"},
        {"Smithsonian Astrophysical Observation", "SAO 82193"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.36642785),
        dec: Angle.Degrees(+23.26550313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -294.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76506"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.37826933),
        dec: Angle.Degrees(+23.26763441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23289"},
        {"Hipparcos Number", "HIP 17497"},
        {"Celescope Catalog", "CEL 315"},
        {"Geneva Identification System", "GEN# +5.20220470"},
        {"Smithsonian Astrophysical Observation", "SAO 76130"},
        {"Wilson Evans Batten Catalogue", "WEB 3316"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.21342687),
        dec: Angle.Degrees(+23.26902878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109083"},
        {"Hipparcos Number", "HIP 61151"},
        {"Geneva Identification System", "GEN# +5.21110170"},
        {"Smithsonian Astrophysical Observation", "SAO 82361"},
        {"Wilson Evans Batten Catalogue", "WEB 10890"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.96665421),
        dec: Angle.Degrees(+23.26922702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225261"},
        {"Hipparcos Number", "HIP 400"},
        {"Geneva Identification System", "GEN# +1.00225261"},
        {"Smithsonian Astrophysical Observation", "SAO 73730"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.23366004),
        dec: Angle.Degrees(+23.26964739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 382.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96380",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12648 AB"},
        {"Henry Draper", "HD 344620"},
        {"Hipparcos Number", "HIP 96380"},
        {"Smithsonian Astrophysical Observation", "SAO 87413"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.93955971),
        dec: Angle.Degrees(+23.27060452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34493"},
        {"Smithsonian Astrophysical Observation", "SAO 79107"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.21155471),
        dec: Angle.Degrees(+23.27153865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43836"},
        {"Hipparcos Number", "HIP 30049"},
        {"Geneva Identification System", "GEN# +1.00043836"},
        {"Smithsonian Astrophysical Observation", "SAO 78225"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.84384719),
        dec: Angle.Degrees(+23.27451163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110398"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.42831039),
        dec: Angle.Degrees(+23.27452548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53355"},
        {"Hipparcos Number", "HIP 34228"},
        {"Smithsonian Astrophysical Observation", "SAO 79048"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.44263508),
        dec: Angle.Degrees(+23.27520265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217836"},
        {"Hipparcos Number", "HIP 113843"},
        {"Smithsonian Astrophysical Observation", "SAO 90975"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.82241016),
        dec: Angle.Degrees(+23.27834728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240792"},
        {"Hipparcos Number", "HIP 23854"},
        {"New General Catalogue", "NGC 1750 2185"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.91037626),
        dec: Angle.Degrees(+23.27863761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242874"},
        {"Hipparcos Number", "HIP 25051"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.45387586),
        dec: Angle.Degrees(+23.28355434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81725"},
        {"Hipparcos Number", "HIP 46427"},
        {"Smithsonian Astrophysical Observation", "SAO 80844"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.01234826),
        dec: Angle.Degrees(+23.28492828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169110"},
        {"Hipparcos Number", "HIP 90023"},
        {"Geneva Identification System", "GEN# +1.00169110"},
        {"Smithsonian Astrophysical Observation", "SAO 85975"},
        {"Wilson Evans Batten Catalogue", "WEB 15380"},
    },
    visualMagnitude: 5.41,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.53622172),
        dec: Angle.Degrees(+23.28498721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65748"},
        {"Geneva Identification System", "GEN# +0.02402587"},
        {"Smithsonian Astrophysical Observation", "SAO 82858"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.16725233),
        dec: Angle.Degrees(+23.28807413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85865"},
        {"Smithsonian Astrophysical Observation", "SAO 85194"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.20254909),
        dec: Angle.Degrees(+23.28833637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86495"},
        {"Hipparcos Number", "HIP 48973"},
        {"Smithsonian Astrophysical Observation", "SAO 81127"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.84806499),
        dec: Angle.Degrees(+23.28936185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22680"},
        {"Hipparcos Number", "HIP 17091"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.92150640),
        dec: Angle.Degrees(+23.29098731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35744"},
        {"Hipparcos Number", "HIP 25572"},
        {"Fundamental Katalog 5th Edition", "FK5 4501"},
        {"Smithsonian Astrophysical Observation", "SAO 77187"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.98087233),
        dec: Angle.Degrees(+23.29317372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284169"},
        {"Hipparcos Number", "HIP 19417"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.37119459),
        dec: Angle.Degrees(+23.29441119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93343",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11934 AB"},
        {"Henry Draper", "HD 176732"},
        {"Hipparcos Number", "HIP 93343"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.19077366),
        dec: Angle.Degrees(+23.29549368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43614"},
        {"Smithsonian Astrophysical Observation", "SAO 80482"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.24696241),
        dec: Angle.Degrees(+23.29567176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31409"},
        {"Hipparcos Number", "HIP 22972"},
        {"Geneva Identification System", "GEN# +1.00031409"},
        {"Smithsonian Astrophysical Observation", "SAO 76853"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.14874560),
        dec: Angle.Degrees(+23.29595608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117632"},
        {"Smithsonian Astrophysical Observation", "SAO 91540"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.84297405),
        dec: Angle.Degrees(+23.29676272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168323"},
        {"Hipparcos Number", "HIP 89683"},
        {"Smithsonian Astrophysical Observation", "SAO 85906"},
        {"Wilson Evans Batten Catalogue", "WEB 15283"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.53217527),
        dec: Angle.Degrees(+23.29693573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100109",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 10.38,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)18, 29.9200),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)17, 53.100)
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
    primaryId: "HIP 53842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95365"},
        {"Hipparcos Number", "HIP 53842"},
        {"Geneva Identification System", "GEN# +1.00095365"},
        {"Smithsonian Astrophysical Observation", "SAO 81622"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.21531153),
        dec: Angle.Degrees(+23.30027509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181360"},
        {"Hipparcos Number", "HIP 94947"},
        {"Fundamental Katalog 5th Edition", "FK5 5699"},
        {"Geneva Identification System", "GEN# +1.00181360"},
        {"Smithsonian Astrophysical Observation", "SAO 87063"},
        {"Wilson Evans Batten Catalogue", "WEB 16580"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.81720637),
        dec: Angle.Degrees(+23.30412284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284574"},
        {"Hipparcos Number", "HIP 21741"},
        {"Geneva Identification System", "GEN# +5.20250109"},
        {"Smithsonian Astrophysical Observation", "SAO 76695"},
        {"Wilson Evans Batten Catalogue", "WEB 4182"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.02414691),
        dec: Angle.Degrees(+23.30463986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250290"},
        {"Hipparcos Number", "HIP 28513"},
        {"Geneva Identification System", "GEN# +2.21290004"},
        {"Smithsonian Astrophysical Observation", "SAO 77842"},
        {"Wilson Evans Batten Catalogue", "WEB 5573"},
        {"New General Catalogue", "NGC 2129 4"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.28187801),
        dec: Angle.Degrees(+23.30486254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222249"},
        {"Hipparcos Number", "HIP 116688"},
        {"Geneva Identification System", "GEN# +1.00222249"},
        {"Smithsonian Astrophysical Observation", "SAO 91399"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.70617044),
        dec: Angle.Degrees(+23.30842576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8762"},
        {"Hipparcos Number", "HIP 6741"},
        {"Smithsonian Astrophysical Observation", "SAO 74724"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.69830817),
        dec: Angle.Degrees(+23.31021324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138173"},
        {"Hipparcos Number", "HIP 75850"},
        {"Smithsonian Astrophysical Observation", "SAO 83849"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.40285509),
        dec: Angle.Degrees(+23.31056424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111245"},
        {"Smithsonian Astrophysical Observation", "SAO 90575"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.07671198),
        dec: Angle.Degrees(+23.31092337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31039"},
        {"Hipparcos Number", "HIP 22743"},
        {"Smithsonian Astrophysical Observation", "SAO 76812"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.39208581),
        dec: Angle.Degrees(+23.31565460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119392"},
        {"Hipparcos Number", "HIP 66899"},
        {"Geneva Identification System", "GEN# +1.00119392"},
        {"Smithsonian Astrophysical Observation", "SAO 82957"},
        {"Wilson Evans Batten Catalogue", "WEB 11793"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.64223948),
        dec: Angle.Degrees(+23.31882642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91231"},
        {"Hipparcos Number", "HIP 51594"},
        {"Geneva Identification System", "GEN# +1.00091231"},
        {"Smithsonian Astrophysical Observation", "SAO 81404"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.09047177),
        dec: Angle.Degrees(+23.31907682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99548"},
        {"Hipparcos Number", "HIP 55895"},
        {"Geneva Identification System", "GEN# +1.00099548"},
        {"Smithsonian Astrophysical Observation", "SAO 81835"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.85773920),
        dec: Angle.Degrees(+23.32146186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206646"},
        {"Hipparcos Number", "HIP 107214"},
        {"Smithsonian Astrophysical Observation", "SAO 89921"},
        {"Wilson Evans Batten Catalogue", "WEB 19364"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.72770975),
        dec: Angle.Degrees(+23.32177067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154691"},
        {"Hipparcos Number", "HIP 83669"},
        {"Smithsonian Astrophysical Observation", "SAO 84830"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.51438856),
        dec: Angle.Degrees(+23.32206416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105982"},
        {"Hipparcos Number", "HIP 59459"},
        {"Geneva Identification System", "GEN# +1.00105982"},
        {"Smithsonian Astrophysical Observation", "SAO 82177"},
        {"Wilson Evans Batten Catalogue", "WEB 10571"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.94188302),
        dec: Angle.Degrees(+23.32255130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120951"},
        {"Hipparcos Number", "HIP 67706"},
        {"Smithsonian Astrophysical Observation", "SAO 83041"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.04149326),
        dec: Angle.Degrees(+23.32314921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26599",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4239 C"},
        {"Henry Draper", "HD 37387"},
        {"Hipparcos Number", "HIP 26599"},
        {"Geneva Identification System", "GEN# +1.00037387"},
        {"Smithsonian Astrophysical Observation", "SAO 77355"},
        {"Wilson Evans Batten Catalogue", "WEB 5243"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.81178024),
        dec: Angle.Degrees(+23.32337592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96528"},
        {"Hipparcos Number", "HIP 54388"},
        {"Geneva Identification System", "GEN# +1.00096528"},
        {"Renson", "Renson 27840"},
        {"Smithsonian Astrophysical Observation", "SAO 81681"},
        {"Wilson Evans Batten Catalogue", "WEB 9822"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.91548362),
        dec: Angle.Degrees(+23.32373831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200352"},
        {"Hipparcos Number", "HIP 103823"},
        {"Geneva Identification System", "GEN# +1.00200352"},
        {"Smithsonian Astrophysical Observation", "SAO 89391"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.59068602),
        dec: Angle.Degrees(+23.32429165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37752"},
        {"Hipparcos Number", "HIP 26836"},
        {"Geneva Identification System", "GEN# +1.00037752"},
        {"Renson", "Renson 10180"},
        {"Smithsonian Astrophysical Observation", "SAO 77413"},
        {"Wilson Evans Batten Catalogue", "WEB 5288"},
    },
    visualMagnitude: 6.57,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.47814681),
        dec: Angle.Degrees(+23.32627288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78089"},
        {"Hipparcos Number", "HIP 44740"},
        {"Geneva Identification System", "GEN# +1.00078089"},
        {"Smithsonian Astrophysical Observation", "SAO 80636"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.76157670),
        dec: Angle.Degrees(+23.32661577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44927"},
        {"Hipparcos Number", "HIP 30570"},
        {"Geneva Identification System", "GEN# +1.00044927"},
        {"Smithsonian Astrophysical Observation", "SAO 78349"},
        {"Wilson Evans Batten Catalogue", "WEB 6092"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.38725983),
        dec: Angle.Degrees(+23.32720900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93678",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12010 B"},
        {"Hipparcos Number", "HIP 93678"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.15670166),
        dec: Angle.Degrees(+23.32883800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83906"},
        {"Hipparcos Number", "HIP 47576"},
        {"Geneva Identification System", "GEN# +1.00083906"},
        {"Smithsonian Astrophysical Observation", "SAO 80974"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.51059486),
        dec: Angle.Degrees(+23.32915703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93680",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12010 A"},
        {"Henry Draper", "HD 177648"},
        {"Hipparcos Number", "HIP 93680"},
        {"Geneva Identification System", "GEN# +1.00177648"},
        {"Smithsonian Astrophysical Observation", "SAO 86774"},
        {"Wilson Evans Batten Catalogue", "WEB 16277"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.16042990),
        dec: Angle.Degrees(+23.32929531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101179"},
        {"Hipparcos Number", "HIP 56806"},
        {"Geneva Identification System", "GEN# +1.00101179"},
        {"Smithsonian Astrophysical Observation", "SAO 81919"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.68384314),
        dec: Angle.Degrees(+23.33053311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198758"},
        {"Hipparcos Number", "HIP 102980"},
        {"Smithsonian Astrophysical Observation", "SAO 89221"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.95762687),
        dec: Angle.Degrees(+23.33143971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111560"},
        {"Smithsonian Astrophysical Observation", "SAO 90630"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.01561005),
        dec: Angle.Degrees(+23.33253366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121063"},
        {"Hipparcos Number", "HIP 67753"},
        {"Geneva Identification System", "GEN# +1.00121063"},
        {"Smithsonian Astrophysical Observation", "SAO 83048"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.20702298),
        dec: Angle.Degrees(+23.33403027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93487"},
        {"Hipparcos Number", "HIP 52817"},
        {"Smithsonian Astrophysical Observation", "SAO 81527"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.98130710),
        dec: Angle.Degrees(+23.33546767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106231",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106231"},
        {"Geneva Identification System", "GEN# +0.02204409"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.75678551),
        dec: Angle.Degrees(+23.33573366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61414"},
        {"Wilson Evans Batten Catalogue", "WEB 10934"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.77103908),
        dec: Angle.Degrees(+23.33725517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28510",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4590 A"},
        {"Henry Draper", "HD 250289"},
        {"Hipparcos Number", "HIP 28510"},
        {"Geneva Identification System", "GEN# +2.21290007"},
        {"Smithsonian Astrophysical Observation", "SAO 77839"},
        {"Wilson Evans Batten Catalogue", "WEB 5572"},
        {"New General Catalogue", "NGC 2129 7"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.27445519),
        dec: Angle.Degrees(+23.33900052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219128"},
        {"Hipparcos Number", "HIP 114632"},
        {"Smithsonian Astrophysical Observation", "SAO 91099"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.32476687),
        dec: Angle.Degrees(+23.33904112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217715"},
        {"Hipparcos Number", "HIP 113766"},
        {"Smithsonian Astrophysical Observation", "SAO 90964"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.58767421),
        dec: Angle.Degrees(+23.34047999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29169"},
        {"Hipparcos Number", "HIP 21459"},
        {"Geneva Identification System", "GEN# +5.20250100"},
        {"Smithsonian Astrophysical Observation", "SAO 76670"},
        {"Wilson Evans Batten Catalogue", "WEB 4119"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.12111497),
        dec: Angle.Degrees(+23.34098574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190404"},
        {"Hipparcos Number", "HIP 98792"},
        {"Cincinnati Publication", "Ci 20 1186"},
        {"Geneva Identification System", "GEN# +1.00190404"},
        {"Smithsonian Astrophysical Observation", "SAO 88138"},
        {"Wilson Evans Batten Catalogue", "WEB 17507"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.96985375),
        dec: Angle.Degrees(+23.34290432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1002.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -912.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131582"},
        {"Hipparcos Number", "HIP 72875"},
        {"Cincinnati Publication", "Ci 20 895"},
        {"Geneva Identification System", "GEN# +1.00131582"},
        {"Smithsonian Astrophysical Observation", "SAO 83571"},
        {"Wilson Evans Batten Catalogue", "WEB 12514"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.42539399),
        dec: Angle.Degrees(+23.34516795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -824.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62365"},
        {"Hipparcos Number", "HIP 37747"},
        {"Smithsonian Astrophysical Observation", "SAO 79657"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.13352339),
        dec: Angle.Degrees(+23.34524524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28581"},
        {"Hipparcos Number", "HIP 21094"},
        {"Geneva Identification System", "GEN# +1.00028581"},
        {"Smithsonian Astrophysical Observation", "SAO 76636"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.80483991),
        dec: Angle.Degrees(+23.34615043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100599"},
        {"Hipparcos Number", "HIP 56468"},
        {"Geneva Identification System", "GEN# +1.00100599"},
        {"Smithsonian Astrophysical Observation", "SAO 81883"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.66114202),
        dec: Angle.Degrees(+23.34939089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51699",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7833 AB"},
        {"Henry Draper", "HD 91427"},
        {"Hipparcos Number", "HIP 51699"},
        {"Smithsonian Astrophysical Observation", "SAO 81415"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.44712941),
        dec: Angle.Degrees(+23.35066683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108201"},
        {"Hipparcos Number", "HIP 60640"},
        {"Geneva Identification System", "GEN# +5.21110116"},
        {"Smithsonian Astrophysical Observation", "SAO 82302"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.41428573),
        dec: Angle.Degrees(+23.35111193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76822"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.27181901),
        dec: Angle.Degrees(+23.35186184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30826"},
        {"Hipparcos Number", "HIP 22610"},
        {"Smithsonian Astrophysical Observation", "SAO 76792"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.96678058),
        dec: Angle.Degrees(+23.35467700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83586"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.25530810),
        dec: Angle.Degrees(+23.35638581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24570"},
        {"Hipparcos Number", "HIP 18346"},
        {"Smithsonian Astrophysical Observation", "SAO 76321"},
        {"Wilson Evans Batten Catalogue", "WEB 3541"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.83084354),
        dec: Angle.Degrees(+23.36041986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121812"},
        {"Hipparcos Number", "HIP 68160"},
        {"Cincinnati Publication", "Ci 18 1825"},
        {"Smithsonian Astrophysical Observation", "SAO 83091"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.31811449),
        dec: Angle.Degrees(+23.36270558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -330.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49838"},
        {"Hipparcos Number", "HIP 32906"},
        {"Geneva Identification System", "GEN# +1.00049838"},
        {"Smithsonian Astrophysical Observation", "SAO 78802"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.84127051),
        dec: Angle.Degrees(+23.36392028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71249"},
        {"Hipparcos Number", "HIP 41435"},
        {"Smithsonian Astrophysical Observation", "SAO 80191"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.76039155),
        dec: Angle.Degrees(+23.36504726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82814",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10263 A"},
        {"Henry Draper", "HD 152928"},
        {"Hipparcos Number", "HIP 82814"},
        {"Smithsonian Astrophysical Observation", "SAO 84697"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.87096054),
        dec: Angle.Degrees(+23.36575939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17055"},
        {"Hipparcos Number", "HIP 12830"},
        {"Geneva Identification System", "GEN# +1.00017055"},
        {"Smithsonian Astrophysical Observation", "SAO 75549"},
        {"Wilson Evans Batten Catalogue", "WEB 2608"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.23809713),
        dec: Angle.Degrees(+23.36776828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343606"},
        {"Hipparcos Number", "HIP 93528"},
        {"Smithsonian Astrophysical Observation", "SAO 86737"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.73619344),
        dec: Angle.Degrees(+23.37101051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48805"},
        {"Hipparcos Number", "HIP 32431"},
        {"Fundamental Katalog 5th Edition", "FK5 4615"},
        {"Geneva Identification System", "GEN# +1.00048805"},
        {"Smithsonian Astrophysical Observation", "SAO 78717"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.54323962),
        dec: Angle.Degrees(+23.37111507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103069"},
        {"Wilson Evans Batten Catalogue", "WEB 18713"},
    },
    visualMagnitude: 12.40,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.24918921),
        dec: Angle.Degrees(+23.37115403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344205"},
        {"Hipparcos Number", "HIP 95008"},
        {"Geneva Identification System", "GEN# +1.00344205"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.98875293),
        dec: Angle.Degrees(+23.37121947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52262"},
        {"Smithsonian Astrophysical Observation", "SAO 81466"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.17664795),
        dec: Angle.Degrees(+23.37322759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65979"},
        {"Geneva Identification System", "GEN# +0.02402595"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.91204342),
        dec: Angle.Degrees(+23.37468549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79498"},
        {"Hipparcos Number", "HIP 45406"},
        {"Geneva Identification System", "GEN# +1.00079498"},
        {"Smithsonian Astrophysical Observation", "SAO 80717"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.78951036),
        dec: Angle.Degrees(+23.37592693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104330",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104330"},
        {"Smithsonian Astrophysical Observation", "SAO 89477"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.01644653),
        dec: Angle.Degrees(+23.37719405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344779"},
        {"Hipparcos Number", "HIP 96902"},
        {"Geneva Identification System", "GEN# +2.68230206"},
        {"Smithsonian Astrophysical Observation", "SAO 87582"},
        {"New General Catalogue", "NGC 6823 206"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.46808605),
        dec: Angle.Degrees(+23.37839214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217874"},
        {"Hipparcos Number", "HIP 113869"},
        {"Smithsonian Astrophysical Observation", "SAO 90978"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.89759759),
        dec: Angle.Degrees(+23.37860653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39184"},
        {"Hipparcos Number", "HIP 27696"},
        {"Smithsonian Astrophysical Observation", "SAO 77647"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.96109297),
        dec: Angle.Degrees(+23.38284389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117050"},
        {"Smithsonian Astrophysical Observation", "SAO 91451"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.92693508),
        dec: Angle.Degrees(+23.38530196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123302"},
        {"Hipparcos Number", "HIP 68890"},
        {"Geneva Identification System", "GEN# +1.00123302"},
        {"Smithsonian Astrophysical Observation", "SAO 83165"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.57641930),
        dec: Angle.Degrees(+23.38846610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8137"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.15796464),
        dec: Angle.Degrees(+23.38875406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97048",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97048"},
        {"New General Catalogue", "NGC 6823 97"},
    },
    visualMagnitude: 11.32,
    bvColour: 1.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.84762728),
        dec: Angle.Degrees(+23.39133529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38234"},
        {"Hipparcos Number", "HIP 27150"},
        {"Smithsonian Astrophysical Observation", "SAO 77504"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.33883960),
        dec: Angle.Degrees(+23.39328556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205087"},
        {"Hipparcos Number", "HIP 106355"},
        {"Geneva Identification System", "GEN# +1.00205087"},
        {"Renson", "Renson 57120"},
        {"Smithsonian Astrophysical Observation", "SAO 89786"},
        {"Wilson Evans Batten Catalogue", "WEB 19258"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.11248605),
        dec: Angle.Degrees(+23.39457573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12354"},
        {"Hipparcos Number", "HIP 9452"},
        {"Geneva Identification System", "GEN# +1.00012354"},
        {"Smithsonian Astrophysical Observation", "SAO 75093"},
        {"Wilson Evans Batten Catalogue", "WEB 1982"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.38932555),
        dec: Angle.Degrees(+23.39545809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30572"},
        {"Hipparcos Number", "HIP 22446"},
        {"Geneva Identification System", "GEN# +5.20250165"},
        {"Smithsonian Astrophysical Observation", "SAO 76777"},
        {"Wilson Evans Batten Catalogue", "WEB 4330"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.45000181),
        dec: Angle.Degrees(+23.39587606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167943"},
        {"Hipparcos Number", "HIP 89561"},
        {"Smithsonian Astrophysical Observation", "SAO 85884"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.13137034),
        dec: Angle.Degrees(+23.39856365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213634"},
        {"Hipparcos Number", "HIP 111270"},
        {"Geneva Identification System", "GEN# +1.00213634"},
        {"Renson", "Renson 59260"},
        {"Smithsonian Astrophysical Observation", "SAO 90582"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.13371330),
        dec: Angle.Degrees(+23.39943208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94027"},
        {"Hipparcos Number", "HIP 53069"},
        {"Smithsonian Astrophysical Observation", "SAO 81554"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.86592544),
        dec: Angle.Degrees(+23.40000146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45494",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7268 A"},
        {"Henry Draper", "HD 79679"},
        {"Hipparcos Number", "HIP 45494"},
        {"Smithsonian Astrophysical Observation", "SAO 80731"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.04698403),
        dec: Angle.Degrees(+23.40288717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165847"},
        {"Hipparcos Number", "HIP 88750"},
        {"Smithsonian Astrophysical Observation", "SAO 85743"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.76550482),
        dec: Angle.Degrees(+23.40351681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105015"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.05080809),
        dec: Angle.Degrees(+23.40371010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115623",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alkarab"},
        {"Henry Draper", "HD 220657"},
        {"Hipparcos Number", "HIP 115623"},
        {"Fundamental Katalog 5th Edition", "FK5 881"},
        {"Geneva Identification System", "GEN# +1.00220657"},
        {"Smithsonian Astrophysical Observation", "SAO 91253"},
        {"Wilson Evans Batten Catalogue", "WEB 20464"},
    },
    visualMagnitude: 4.42,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.34442250),
        dec: Angle.Degrees(+23.40401243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66346"},
        {"Hipparcos Number", "HIP 39465"},
        {"Smithsonian Astrophysical Observation", "SAO 79906"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.99525996),
        dec: Angle.Degrees(+23.40581810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93901"},
        {"Hipparcos Number", "HIP 53005"},
        {"Geneva Identification System", "GEN# +1.00093901"},
        {"Renson", "Renson 27160"},
        {"Smithsonian Astrophysical Observation", "SAO 81547"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.65252357),
        dec: Angle.Degrees(+23.40624298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25532"},
        {"Hipparcos Number", "HIP 18995"},
        {"Geneva Identification System", "GEN# +1.00025532"},
        {"Smithsonian Astrophysical Observation", "SAO 76423"},
        {"Wilson Evans Batten Catalogue", "WEB 3651"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.04562697),
        dec: Angle.Degrees(+23.40781053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216550"},
        {"Hipparcos Number", "HIP 113035"},
        {"Smithsonian Astrophysical Observation", "SAO 90857"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.38006864),
        dec: Angle.Degrees(+23.41147840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78954"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.76215001),
        dec: Angle.Degrees(+23.41256840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168533"},
        {"Hipparcos Number", "HIP 89778"},
        {"Smithsonian Astrophysical Observation", "SAO 85923"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.82321579),
        dec: Angle.Degrees(+23.41296544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112918"},
        {"Geneva Identification System", "GEN# +0.02204725"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.01014900),
        dec: Angle.Degrees(+23.41361260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112696"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.32220907),
        dec: Angle.Degrees(+23.41374895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191399"},
        {"Hipparcos Number", "HIP 99259"},
        {"Smithsonian Astrophysical Observation", "SAO 88249"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.23880831),
        dec: Angle.Degrees(+23.41492191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34775"},
        {"Smithsonian Astrophysical Observation", "SAO 79150"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.98051063),
        dec: Angle.Degrees(+23.41556715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5308"},
        {"Hipparcos Number", "HIP 4301"},
        {"Geneva Identification System", "GEN# +1.00005308"},
        {"Smithsonian Astrophysical Observation", "SAO 74363"},
        {"Wilson Evans Batten Catalogue", "WEB 775"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.77899350),
        dec: Angle.Degrees(+23.41612891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50335",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Adhafera"},
        {"Henry Draper", "HD 89025"},
        {"Hipparcos Number", "HIP 50335"},
        {"Fundamental Katalog 5th Edition", "FK5 384"},
        {"Geneva Identification System", "GEN# +1.00089025"},
        {"Smithsonian Astrophysical Observation", "SAO 81265"},
        {"Wilson Evans Batten Catalogue", "WEB 9242"},
    },
    visualMagnitude: 3.43,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.17251805),
        dec: Angle.Degrees(+23.41732840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5516"},
        {"Hipparcos Number", "HIP 4463"},
        {"Fundamental Katalog 5th Edition", "FK5 2060"},
        {"Geneva Identification System", "GEN# +1.00005516"},
        {"Smithsonian Astrophysical Observation", "SAO 74388"},
        {"Wilson Evans Batten Catalogue", "WEB 805"},
    },
    visualMagnitude: 4.40,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.30178237),
        dec: Angle.Degrees(+23.41775997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23753"},
        {"Hipparcos Number", "HIP 17776"},
        {"Celescope Catalog", "CEL 348"},
        {"Geneva Identification System", "GEN# +5.20221823"},
        {"Smithsonian Astrophysical Observation", "SAO 76215"},
        {"Wilson Evans Batten Catalogue", "WEB 3403"},
    },
    visualMagnitude: 5.44,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.08668426),
        dec: Angle.Degrees(+23.42136355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54757"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.16566700),
        dec: Angle.Degrees(+23.42187829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60450",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 11.16,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23, 35.6800),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)25, 25.500)
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
    primaryId: "HIP 10964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14512"},
        {"Hipparcos Number", "HIP 10964"},
        {"Smithsonian Astrophysical Observation", "SAO 75300"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.31035271),
        dec: Angle.Degrees(+23.42663938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18804"},
        {"Hipparcos Number", "HIP 14129"},
        {"Smithsonian Astrophysical Observation", "SAO 75695"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.55658817),
        dec: Angle.Degrees(+23.42774446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107864"},
        {"Hipparcos Number", "HIP 60446"},
        {"Geneva Identification System", "GEN# +5.21110100"},
        {"Smithsonian Astrophysical Observation", "SAO 82284"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.89510766),
        dec: Angle.Degrees(+23.42856370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156730"},
        {"Hipparcos Number", "HIP 84651"},
        {"Geneva Identification System", "GEN# +1.00156730"},
        {"Smithsonian Astrophysical Observation", "SAO 84994"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.58817963),
        dec: Angle.Degrees(+23.43222932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345183"},
        {"Hipparcos Number", "HIP 97968"},
        {"Smithsonian Astrophysical Observation", "SAO 87910"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.65998440),
        dec: Angle.Degrees(+23.43799147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32003"},
        {"Hipparcos Number", "HIP 23333"},
        {"Geneva Identification System", "GEN# +1.00032003"},
        {"Smithsonian Astrophysical Observation", "SAO 76893"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.28338528),
        dec: Angle.Degrees(+23.43904903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52035"},
        {"Hipparcos Number", "HIP 33757"},
        {"Smithsonian Astrophysical Observation", "SAO 78963"},
    },
    visualMagnitude: 7.17,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.16843178),
        dec: Angle.Degrees(+23.44021466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44926"},
        {"Hipparcos Number", "HIP 30569"},
        {"Geneva Identification System", "GEN# +1.00044926"},
        {"Smithsonian Astrophysical Observation", "SAO 78348"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.38578362),
        dec: Angle.Degrees(+23.44216777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109705"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.32725404),
        dec: Angle.Degrees(+23.44358734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138820"},
        {"Hipparcos Number", "HIP 76189"},
        {"Smithsonian Astrophysical Observation", "SAO 83883"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.42474130),
        dec: Angle.Degrees(+23.44397351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8817"},
    },
    visualMagnitude: 12.48,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.33586141),
        dec: Angle.Degrees(+23.44478553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194511"},
        {"Hipparcos Number", "HIP 100723"},
        {"Smithsonian Astrophysical Observation", "SAO 88653"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.31036984),
        dec: Angle.Degrees(+23.44506487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16072"},
        {"Cincinnati Publication", "Ci 20 233"},
        {"Geneva Identification System", "GEN# +9.80005036"},
        {"Wilson Evans Batten Catalogue", "WEB 3066"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.74835624),
        dec: Angle.Degrees(+23.77748362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 262.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -342.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117996",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17104 AB"},
        {"Henry Draper", "HD 224219"},
        {"Hipparcos Number", "HIP 117996"},
        {"Smithsonian Astrophysical Observation", "SAO 91588"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.01799082),
        dec: Angle.Degrees(+23.44687093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180530"},
        {"Hipparcos Number", "HIP 94689"},
        {"Smithsonian Astrophysical Observation", "SAO 87006"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.01155470),
        dec: Angle.Degrees(+23.44756135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120334"},
        {"Hipparcos Number", "HIP 67364"},
        {"Geneva Identification System", "GEN# +1.00120334"},
        {"Smithsonian Astrophysical Observation", "SAO 83000"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.10259785),
        dec: Angle.Degrees(+23.44926747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91932"},
        {"Hipparcos Number", "HIP 51983"},
        {"Geneva Identification System", "GEN# +1.00091932"},
        {"Smithsonian Astrophysical Observation", "SAO 81438"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.31718968),
        dec: Angle.Degrees(+23.44989887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223082"},
        {"Hipparcos Number", "HIP 117244"},
        {"Smithsonian Astrophysical Observation", "SAO 91475"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.59775463),
        dec: Angle.Degrees(+23.45002487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101657"},
        {"Hipparcos Number", "HIP 57070"},
        {"Geneva Identification System", "GEN# +1.00101657"},
        {"Smithsonian Astrophysical Observation", "SAO 81947"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.48699528),
        dec: Angle.Degrees(+23.45058124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75646",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75646"},
        {"Smithsonian Astrophysical Observation", "SAO 83828"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.82527546),
        dec: Angle.Degrees(+23.45359600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192304"},
        {"Hipparcos Number", "HIP 99658"},
        {"Smithsonian Astrophysical Observation", "SAO 88371"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.35704015),
        dec: Angle.Degrees(+23.45361761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82670"},
        {"Hipparcos Number", "HIP 46938"},
        {"Geneva Identification System", "GEN# +1.00082670"},
        {"Smithsonian Astrophysical Observation", "SAO 80909"},
        {"Wilson Evans Batten Catalogue", "WEB 8849"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.49653757),
        dec: Angle.Degrees(+23.45411990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74352"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.92473762),
        dec: Angle.Degrees(+23.45460761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48585"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.63474785),
        dec: Angle.Degrees(+23.45494674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90120",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11309 AB"},
        {"Henry Draper", "HD 169388"},
        {"Hipparcos Number", "HIP 90120"},
        {"Smithsonian Astrophysical Observation", "SAO 85995"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.85725710),
        dec: Angle.Degrees(+23.45523339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74672"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.89891371),
        dec: Angle.Degrees(+23.45745165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179647"},
        {"Hipparcos Number", "HIP 94375"},
        {"Smithsonian Astrophysical Observation", "SAO 86928"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.12074974),
        dec: Angle.Degrees(+23.45933135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173241"},
        {"Hipparcos Number", "HIP 91833"},
        {"Smithsonian Astrophysical Observation", "SAO 86367"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.85033871),
        dec: Angle.Degrees(+23.46143315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9884",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Hamal"},
        {"Henry Draper", "HD 12929"},
        {"Hipparcos Number", "HIP 9884"},
        {"Fundamental Katalog 5th Edition", "FK5 74"},
        {"Geneva Identification System", "GEN# +1.00012929"},
        {"Smithsonian Astrophysical Observation", "SAO 75151"},
        {"Wilson Evans Batten Catalogue", "WEB 2075"},
    },
    visualMagnitude: 2.01,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.79285757),
        dec: Angle.Degrees(+23.46277743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344776"},
        {"Hipparcos Number", "HIP 96990"},
        {"Geneva Identification System", "GEN# +2.68230111"},
        {"Smithsonian Astrophysical Observation", "SAO 87608"},
        {"New General Catalogue", "NGC 6823 111"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.70677543),
        dec: Angle.Degrees(+23.46331513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139642"},
        {"Hipparcos Number", "HIP 76587"},
        {"Smithsonian Astrophysical Observation", "SAO 83924"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.62146818),
        dec: Angle.Degrees(+23.46338936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7000"},
        {"Hipparcos Number", "HIP 5525"},
        {"Smithsonian Astrophysical Observation", "SAO 74537"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.67982534),
        dec: Angle.Degrees(+23.46620172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2197"},
        {"Smithsonian Astrophysical Observation", "SAO 74013"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.94119087),
        dec: Angle.Degrees(+23.46766067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15385"},
        {"Hipparcos Number", "HIP 11578"},
        {"Geneva Identification System", "GEN# +1.00015385"},
        {"Renson", "Renson 3870"},
        {"Smithsonian Astrophysical Observation", "SAO 75398"},
        {"Wilson Evans Batten Catalogue", "WEB 2412"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.30678090),
        dec: Angle.Degrees(+23.46907769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20012"},
        {"Cincinnati Publication", "Ci 20 290"},
        {"Geneva Identification System", "GEN# +9.80008022"},
    },
    visualMagnitude: 11.36,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.36520178),
        dec: Angle.Degrees(+23.46915884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 488.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -289.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43818"},
        {"Hipparcos Number", "HIP 30046"},
        {"Geneva Identification System", "GEN# +1.00043818"},
        {"Smithsonian Astrophysical Observation", "SAO 78222"},
        {"Wilson Evans Batten Catalogue", "WEB 5965"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.83039901),
        dec: Angle.Degrees(+23.46940924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344208"},
        {"Hipparcos Number", "HIP 95209"},
        {"Smithsonian Astrophysical Observation", "SAO 87123"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.52899950),
        dec: Angle.Degrees(+23.46982622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86657"},
        {"Smithsonian Astrophysical Observation", "SAO 85339"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.58803527),
        dec: Angle.Degrees(+23.47044394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 756"},
        {"Hipparcos Number", "HIP 969"},
        {"Geneva Identification System", "GEN# +1.00000756"},
        {"Smithsonian Astrophysical Observation", "SAO 73802"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.00550041),
        dec: Angle.Degrees(+23.47174032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66981"},
        {"Smithsonian Astrophysical Observation", "SAO 82968"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.91421486),
        dec: Angle.Degrees(+23.47196737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214350"},
        {"Hipparcos Number", "HIP 111659"},
        {"Geneva Identification System", "GEN# +1.00214350"},
        {"Smithsonian Astrophysical Observation", "SAO 90651"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.30241865),
        dec: Angle.Degrees(+23.47343598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96317",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12631"},
        {"Aitken 2", "ADS 12631 AB"},
        {"Henry Draper", "HD 184739"},
        {"Hipparcos Number", "HIP 96317"},
        {"Smithsonian Astrophysical Observation", "SAO 87387"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.75711276),
        dec: Angle.Degrees(+23.47426074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84347"},
        {"Hipparcos Number", "HIP 47853"},
        {"Geneva Identification System", "GEN# +1.00084347"},
        {"Smithsonian Astrophysical Observation", "SAO 81002"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.31143339),
        dec: Angle.Degrees(+23.47462916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345180"},
        {"Hipparcos Number", "HIP 98000"},
        {"Geneva Identification System", "GEN# +0.02303835"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.74317270),
        dec: Angle.Degrees(+23.47643379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78022"},
        {"Smithsonian Astrophysical Observation", "SAO 84082"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.97234895),
        dec: Angle.Degrees(+23.47793443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179309"},
        {"Hipparcos Number", "HIP 94258"},
        {"Smithsonian Astrophysical Observation", "SAO 86904"},
        {"Wilson Evans Batten Catalogue", "WEB 16419"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.79359399),
        dec: Angle.Degrees(+23.47993383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185858"},
        {"Hipparcos Number", "HIP 96786"},
        {"Smithsonian Astrophysical Observation", "SAO 87541"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.09892834),
        dec: Angle.Degrees(+23.48008707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220583"},
        {"Hipparcos Number", "HIP 115585"},
        {"Smithsonian Astrophysical Observation", "SAO 91246"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.19396113),
        dec: Angle.Degrees(+23.48024831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87914"},
        {"Hipparcos Number", "HIP 49700"},
        {"Geneva Identification System", "GEN# +1.00087914"},
        {"Smithsonian Astrophysical Observation", "SAO 81204"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.18480843),
        dec: Angle.Degrees(+23.48048921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68040"},
        {"Hipparcos Number", "HIP 40102"},
        {"Smithsonian Astrophysical Observation", "SAO 80002"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.87800977),
        dec: Angle.Degrees(+23.48228904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116393"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.78674680),
        dec: Angle.Degrees(+23.48336314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2678"},
        {"Hipparcos Number", "HIP 2401"},
        {"Smithsonian Astrophysical Observation", "SAO 74050"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.64606111),
        dec: Angle.Degrees(+23.48476184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71924"},
        {"Hipparcos Number", "HIP 41743"},
        {"Smithsonian Astrophysical Observation", "SAO 80220"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.68625014),
        dec: Angle.Degrees(+23.48572046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22887"},
        {"Hipparcos Number", "HIP 17225"},
        {"Geneva Identification System", "GEN# +5.20223309"},
        {"Smithsonian Astrophysical Observation", "SAO 76082"},
        {"Wilson Evans Batten Catalogue", "WEB 3263"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.34564029),
        dec: Angle.Degrees(+23.48704606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69077"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.09058502),
        dec: Angle.Degrees(+23.48780485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65592",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65592"},
        {"Geneva Identification System", "GEN# +0.02402584"},
        {"Smithsonian Astrophysical Observation", "SAO 82842"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.73232693),
        dec: Angle.Degrees(+23.48888767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167064"},
        {"Hipparcos Number", "HIP 89244"},
        {"Smithsonian Astrophysical Observation", "SAO 85824"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.17080703),
        dec: Angle.Degrees(+23.49280225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187"},
        {"Hipparcos Number", "HIP 557"},
        {"Geneva Identification System", "GEN# +1.00000187"},
        {"Smithsonian Astrophysical Observation", "SAO 73746"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.69574083),
        dec: Angle.Degrees(+23.49381547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145713"},
        {"Hipparcos Number", "HIP 79349"},
        {"Geneva Identification System", "GEN# +1.00145713"},
        {"Smithsonian Astrophysical Observation", "SAO 84240"},
        {"Wilson Evans Batten Catalogue", "WEB 13412"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.90853829),
        dec: Angle.Degrees(+23.49482992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130525"},
        {"Hipparcos Number", "HIP 72395"},
        {"Smithsonian Astrophysical Observation", "SAO 83531"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.02515774),
        dec: Angle.Degrees(+23.49543010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209320"},
        {"Hipparcos Number", "HIP 108767"},
        {"Geneva Identification System", "GEN# +1.00209320"},
        {"Smithsonian Astrophysical Observation", "SAO 90183"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.50592324),
        dec: Angle.Degrees(+23.49553571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76518"},
        {"Smithsonian Astrophysical Observation", "SAO 83912"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.40936836),
        dec: Angle.Degrees(+23.49697172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65156"},
        {"Geneva Identification System", "GEN# +0.02402570"},
        {"Smithsonian Astrophysical Observation", "SAO 82795"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.28779486),
        dec: Angle.Degrees(+23.49732385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184403"},
        {"Hipparcos Number", "HIP 96184"},
        {"Geneva Identification System", "GEN# +1.00184403"},
        {"Smithsonian Astrophysical Observation", "SAO 87353"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.35930854),
        dec: Angle.Degrees(+23.49751327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63632",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8749 AB"},
        {"Henry Draper", "HD 113303"},
        {"Hipparcos Number", "HIP 63632"},
        {"Smithsonian Astrophysical Observation", "SAO 82618"},
        {"Wilson Evans Batten Catalogue", "WEB 11262"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.62766309),
        dec: Angle.Degrees(+23.49932934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66775"},
        {"Smithsonian Astrophysical Observation", "SAO 82948"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.29610971),
        dec: Angle.Degrees(+23.50006677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15953"},
        {"Hipparcos Number", "HIP 11976"},
        {"Geneva Identification System", "GEN# +1.00015953"},
        {"Smithsonian Astrophysical Observation", "SAO 75448"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.61966852),
        dec: Angle.Degrees(+23.50118222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117848"},
        {"Smithsonian Astrophysical Observation", "SAO 91566"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.52206775),
        dec: Angle.Degrees(+23.50169278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89010"},
        {"Hipparcos Number", "HIP 50319"},
        {"Geneva Identification System", "GEN# +1.00089010"},
        {"Smithsonian Astrophysical Observation", "SAO 81260"},
        {"Wilson Evans Batten Catalogue", "WEB 9240"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.13507067),
        dec: Angle.Degrees(+23.50301282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64327"},
        {"Hipparcos Number", "HIP 38603"},
        {"Smithsonian Astrophysical Observation", "SAO 79781"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.55946810),
        dec: Angle.Degrees(+23.50392266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70021",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9222 AB"},
        {"Henry Draper", "HD 125578"},
        {"Hipparcos Number", "HIP 70021"},
        {"Smithsonian Astrophysical Observation", "SAO 83291"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.92021093),
        dec: Angle.Degrees(+23.50445508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 342218"},
        {"Hipparcos Number", "HIP 90409"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.71044013),
        dec: Angle.Degrees(+23.50464299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78478"},
        {"Hipparcos Number", "HIP 44941"},
        {"Smithsonian Astrophysical Observation", "SAO 80663"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.30971537),
        dec: Angle.Degrees(+23.50494781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202476"},
        {"Hipparcos Number", "HIP 104949"},
        {"Smithsonian Astrophysical Observation", "SAO 89568"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.88487879),
        dec: Angle.Degrees(+23.50832839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192713"},
        {"Hipparcos Number", "HIP 99853"},
        {"Geneva Identification System", "GEN# +1.00192713"},
        {"Smithsonian Astrophysical Observation", "SAO 88416"},
        {"Wilson Evans Batten Catalogue", "WEB 17951"},
    },
    visualMagnitude: 5.18,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.87598846),
        dec: Angle.Degrees(+23.50892242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8634"},
        {"Hipparcos Number", "HIP 6669"},
        {"Fundamental Katalog 5th Edition", "FK5 2096"},
        {"Geneva Identification System", "GEN# +1.00008634"},
        {"Smithsonian Astrophysical Observation", "SAO 74707"},
        {"Wilson Evans Batten Catalogue", "WEB 1456"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.39856813),
        dec: Angle.Degrees(+23.51157323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174160"},
        {"Hipparcos Number", "HIP 92270"},
        {"Geneva Identification System", "GEN# +1.00174160"},
        {"Smithsonian Astrophysical Observation", "SAO 86451"},
        {"Wilson Evans Batten Catalogue", "WEB 15920"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.06827761),
        dec: Angle.Degrees(+23.51476509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128219"},
        {"Hipparcos Number", "HIP 71322"},
        {"Geneva Identification System", "GEN# +1.00128219"},
        {"Smithsonian Astrophysical Observation", "SAO 83420"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.77501643),
        dec: Angle.Degrees(+23.51579411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81933",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10184 AB"},
        {"Henry Draper", "HD 151070"},
        {"Hipparcos Number", "HIP 81933"},
        {"Smithsonian Astrophysical Observation", "SAO 84572"},
        {"Wilson Evans Batten Catalogue", "WEB 13836"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.04404488),
        dec: Angle.Degrees(+23.51745811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113124"},
        {"Geneva Identification System", "GEN# +9.80067033"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.62785087),
        dec: Angle.Degrees(+23.51829116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 258.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260650"},
        {"Hipparcos Number", "HIP 31668"},
        {"Smithsonian Astrophysical Observation", "SAO 78562"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.41657128),
        dec: Angle.Degrees(+23.51899145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26545"},
        {"Hipparcos Number", "HIP 19662"},
        {"Smithsonian Astrophysical Observation", "SAO 76502"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.19469509),
        dec: Angle.Degrees(+23.52082061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76072"},
        {"Smithsonian Astrophysical Observation", "SAO 83872"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.05120696),
        dec: Angle.Degrees(+23.52145281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85135"},
        {"Smithsonian Astrophysical Observation", "SAO 85061"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.98765935),
        dec: Angle.Degrees(+23.52350764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341454"},
        {"Hipparcos Number", "HIP 88106"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.90906956),
        dec: Angle.Degrees(+23.52710584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191768"},
        {"Hipparcos Number", "HIP 99425"},
        {"Smithsonian Astrophysical Observation", "SAO 88302"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.70854644),
        dec: Angle.Degrees(+23.52730553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197532"},
        {"Hipparcos Number", "HIP 102287"},
        {"Smithsonian Astrophysical Observation", "SAO 89053"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.88893105),
        dec: Angle.Degrees(+23.52823383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224723"},
        {"Hipparcos Number", "HIP 20"},
        {"Geneva Identification System", "GEN# +1.00224723"},
        {"Smithsonian Astrophysical Observation", "SAO 91645"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.06295050),
        dec: Angle.Degrees(+23.52928397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344546"},
        {"Hipparcos Number", "HIP 96192"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.39508814),
        dec: Angle.Degrees(+23.53010914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213013"},
        {"Hipparcos Number", "HIP 110911"},
        {"Smithsonian Astrophysical Observation", "SAO 90526"},
        {"Wilson Evans Batten Catalogue", "WEB 19857"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.05511012),
        dec: Angle.Degrees(+23.53267041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18696"},
        {"Geneva Identification System", "GEN# +0.02300601"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.08025882),
        dec: Angle.Degrees(+23.53430249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70568"},
        {"Hipparcos Number", "HIP 41133"},
        {"Geneva Identification System", "GEN# +1.00070568"},
        {"Smithsonian Astrophysical Observation", "SAO 80146"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.88064594),
        dec: Angle.Degrees(+23.53453924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 342892"},
        {"Hipparcos Number", "HIP 91859"},
        {"Smithsonian Astrophysical Observation", "SAO 86375"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.91897705),
        dec: Angle.Degrees(+23.53528310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343797"},
        {"Hipparcos Number", "HIP 93939"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.91461424),
        dec: Angle.Degrees(+23.53715108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222242"},
        {"Hipparcos Number", "HIP 116678"},
        {"Smithsonian Astrophysical Observation", "SAO 91396"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.68088609),
        dec: Angle.Degrees(+23.53724650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45801"},
        {"Hipparcos Number", "HIP 31029"},
        {"Smithsonian Astrophysical Observation", "SAO 78452"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.66449238),
        dec: Angle.Degrees(+23.53798332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224806"},
        {"Hipparcos Number", "HIP 67"},
        {"Geneva Identification System", "GEN# +1.00224806"},
        {"Smithsonian Astrophysical Observation", "SAO 91653"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.19910132),
        dec: Angle.Degrees(+23.53824873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185175"},
        {"Hipparcos Number", "HIP 96485"},
        {"Geneva Identification System", "GEN# +1.00185175"},
        {"Smithsonian Astrophysical Observation", "SAO 87455"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.22337551),
        dec: Angle.Degrees(+23.54230710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135839"},
        {"Hipparcos Number", "HIP 74741"},
        {"Smithsonian Astrophysical Observation", "SAO 83740"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.12478432),
        dec: Angle.Degrees(+23.54500994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121828"},
        {"Hipparcos Number", "HIP 68179"},
        {"Smithsonian Astrophysical Observation", "SAO 83095"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.36823954),
        dec: Angle.Degrees(+23.54559458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5948"},
        {"Smithsonian Astrophysical Observation", "SAO 74597"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.13847782),
        dec: Angle.Degrees(+23.54633256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83342"},
        {"Hipparcos Number", "HIP 47288"},
        {"Geneva Identification System", "GEN# +1.00083342"},
        {"Smithsonian Astrophysical Observation", "SAO 80939"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.55577372),
        dec: Angle.Degrees(+23.54702316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108124"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.57965106),
        dec: Angle.Degrees(+23.54733587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62695"},
        {"Hipparcos Number", "HIP 37914"},
        {"Smithsonian Astrophysical Observation", "SAO 79679"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.54301128),
        dec: Angle.Degrees(+23.54869181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121726"},
        {"Hipparcos Number", "HIP 68118"},
        {"Geneva Identification System", "GEN# +1.00121726"},
        {"Smithsonian Astrophysical Observation", "SAO 83087"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.19005015),
        dec: Angle.Degrees(+23.55174897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220265"},
        {"Hipparcos Number", "HIP 115371"},
        {"Smithsonian Astrophysical Observation", "SAO 91212"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.55836796),
        dec: Angle.Degrees(+23.55175294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72896"},
        {"Cincinnati Publication", "Ci 20 896"},
    },
    visualMagnitude: 11.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.46626781),
        dec: Angle.Degrees(+23.55551709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -679.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175742"},
        {"Hipparcos Number", "HIP 92919"},
        {"Cincinnati Publication", "Ci 18 2474"},
        {"Geneva Identification System", "GEN# +1.00175742"},
        {"Smithsonian Astrophysical Observation", "SAO 86592"},
        {"Wilson Evans Batten Catalogue", "WEB 16090"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.97142294),
        dec: Angle.Degrees(+23.55733799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -283.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76871",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76871"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.45390890),
        dec: Angle.Degrees(+23.55811696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116927"},
        {"Hipparcos Number", "HIP 65556"},
        {"Geneva Identification System", "GEN# +1.00116927"},
        {"Smithsonian Astrophysical Observation", "SAO 82836"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.60880628),
        dec: Angle.Degrees(+23.55850596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130685"},
        {"Hipparcos Number", "HIP 72453"},
        {"Smithsonian Astrophysical Observation", "SAO 83540"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.23823671),
        dec: Angle.Degrees(+23.55942536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42303"},
        {"Wilson Evans Batten Catalogue", "WEB 8127"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.37558453),
        dec: Angle.Degrees(+23.56156937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121029"},
        {"Hipparcos Number", "HIP 67739"},
        {"Geneva Identification System", "GEN# +1.00121029"},
        {"Smithsonian Astrophysical Observation", "SAO 83044"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.14307971),
        dec: Angle.Degrees(+23.56324708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83727"},
        {"Smithsonian Astrophysical Observation", "SAO 84846"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.68508344),
        dec: Angle.Degrees(+23.56394934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215665"},
        {"Hipparcos Number", "HIP 112440"},
        {"Fundamental Katalog 5th Edition", "FK5 859"},
        {"Geneva Identification System", "GEN# +1.00215665"},
        {"Smithsonian Astrophysical Observation", "SAO 90775"},
        {"Wilson Evans Batten Catalogue", "WEB 20053"},
    },
    visualMagnitude: 3.97,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.63267663),
        dec: Angle.Degrees(+23.56567939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108753",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15589 AB"},
        {"Henry Draper", "HD 209299"},
        {"Hipparcos Number", "HIP 108753"},
        {"Smithsonian Astrophysical Observation", "SAO 90181"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.45392071),
        dec: Angle.Degrees(+23.56747565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285140"},
        {"Hipparcos Number", "HIP 23645"},
        {"Smithsonian Astrophysical Observation", "SAO 76950"},
        {"New General Catalogue", "NGC 1750 1268"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.22884667),
        dec: Angle.Degrees(+23.56852371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107114"},
        {"Hipparcos Number", "HIP 60056"},
        {"Geneva Identification System", "GEN# +5.21110057"},
        {"Smithsonian Astrophysical Observation", "SAO 82234"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.74277542),
        dec: Angle.Degrees(+23.56893748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168429"},
        {"Hipparcos Number", "HIP 89722"},
        {"Smithsonian Astrophysical Observation", "SAO 85912"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.66134620),
        dec: Angle.Degrees(+23.56908806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2206",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 367 AB"},
        {"Henry Draper", "HD 2390"},
        {"Hipparcos Number", "HIP 2206"},
        {"Smithsonian Astrophysical Observation", "SAO 74016"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.97080245),
        dec: Angle.Degrees(+23.57162141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63128"},
        {"Geneva Identification System", "GEN# +0.02402508"},
        {"Smithsonian Astrophysical Observation", "SAO 82574"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.01567710),
        dec: Angle.Degrees(+23.57415651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26514"},
        {"Hipparcos Number", "HIP 19634"},
        {"Geneva Identification System", "GEN# +1.00026514J"},
        {"Smithsonian Astrophysical Observation", "SAO 76499"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.10421844),
        dec: Angle.Degrees(+23.57463362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66533"},
        {"Smithsonian Astrophysical Observation", "SAO 82917"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.57879969),
        dec: Angle.Degrees(+23.57475738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225096"},
        {"Hipparcos Number", "HIP 269"},
        {"Smithsonian Astrophysical Observation", "SAO 73715"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.84205196),
        dec: Angle.Degrees(+23.57504990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26736"},
        {"Hipparcos Number", "HIP 19793"},
        {"Geneva Identification System", "GEN# +5.20250015"},
        {"Smithsonian Astrophysical Observation", "SAO 76516"},
        {"Wilson Evans Batten Catalogue", "WEB 3776"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.63432646),
        dec: Angle.Degrees(+23.57506214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11763"},
        {"Hipparcos Number", "HIP 8993"},
        {"Fundamental Katalog 5th Edition", "FK5 2130"},
        {"Geneva Identification System", "GEN# +1.00011763"},
        {"Smithsonian Astrophysical Observation", "SAO 75030"},
        {"Wilson Evans Batten Catalogue", "WEB 1885"},
    },
    visualMagnitude: 5.76,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.96263355),
        dec: Angle.Degrees(+23.57734317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155286"},
        {"Hipparcos Number", "HIP 83951"},
        {"Geneva Identification System", "GEN# +1.00155286"},
        {"Smithsonian Astrophysical Observation", "SAO 84881"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.40736932),
        dec: Angle.Degrees(+23.57785100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209378"},
        {"Hipparcos Number", "HIP 108805"},
        {"Smithsonian Astrophysical Observation", "SAO 90189"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.62750439),
        dec: Angle.Degrees(+23.57845377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81107"},
        {"Hipparcos Number", "HIP 46119"},
        {"Smithsonian Astrophysical Observation", "SAO 80805"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.07764980),
        dec: Angle.Degrees(+23.57922782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93100"},
        {"Hipparcos Number", "HIP 52605"},
        {"Smithsonian Astrophysical Observation", "SAO 81502"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.36035101),
        dec: Angle.Degrees(+23.57936916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201138"},
        {"Hipparcos Number", "HIP 104228"},
        {"Smithsonian Astrophysical Observation", "SAO 89465"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.75875911),
        dec: Angle.Degrees(+23.58147693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39194",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6513 AB"},
        {"Henry Draper", "HD 65757"},
        {"Hipparcos Number", "HIP 39194"},
        {"Smithsonian Astrophysical Observation", "SAO 79864"},
        {"Wilson Evans Batten Catalogue", "WEB 7686"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.25330632),
        dec: Angle.Degrees(+23.58316149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201871"},
        {"Hipparcos Number", "HIP 104637"},
        {"Smithsonian Astrophysical Observation", "SAO 89517"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.93026097),
        dec: Angle.Degrees(+23.58493067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258480"},
        {"Hipparcos Number", "HIP 31044"},
        {"Smithsonian Astrophysical Observation", "SAO 78458"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.70891325),
        dec: Angle.Degrees(+23.58607779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220952"},
        {"Hipparcos Number", "HIP 115829"},
        {"Smithsonian Astrophysical Observation", "SAO 91280"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.99197746),
        dec: Angle.Degrees(+23.58665908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243314"},
        {"Hipparcos Number", "HIP 25309"},
        {"Smithsonian Astrophysical Observation", "SAO 77152"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.20267777),
        dec: Angle.Degrees(+23.58733381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218662"},
        {"Hipparcos Number", "HIP 114350"},
        {"Smithsonian Astrophysical Observation", "SAO 91047"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.39050710),
        dec: Angle.Degrees(+23.58881157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28482"},
        {"Hipparcos Number", "HIP 21013"},
        {"Geneva Identification System", "GEN# +1.00028482"},
        {"Smithsonian Astrophysical Observation", "SAO 76635"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.59346238),
        dec: Angle.Degrees(+23.58885677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7615"},
        {"Hipparcos Number", "HIP 5942"},
        {"Geneva Identification System", "GEN# +1.00007615"},
        {"Smithsonian Astrophysical Observation", "SAO 74596"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.11573890),
        dec: Angle.Degrees(+23.58948149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173494"},
        {"Hipparcos Number", "HIP 91958"},
        {"Geneva Identification System", "GEN# +1.00173494"},
        {"Smithsonian Astrophysical Observation", "SAO 86393"},
        {"Wilson Evans Batten Catalogue", "WEB 15838"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.16785681),
        dec: Angle.Degrees(+23.59009138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9493"},
        {"Hipparcos Number", "HIP 7255"},
        {"Geneva Identification System", "GEN# +1.00009493"},
        {"Smithsonian Astrophysical Observation", "SAO 74792"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.36969200),
        dec: Angle.Degrees(+23.59051312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4269"},
        {"Hipparcos Number", "HIP 3541"},
        {"Fundamental Katalog 5th Edition", "FK5 4066"},
        {"Smithsonian Astrophysical Observation", "SAO 74240"},
        {"Wilson Evans Batten Catalogue", "WEB 625"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.30344971),
        dec: Angle.Degrees(+23.59080507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78338"},
        {"Smithsonian Astrophysical Observation", "SAO 84130"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.93637625),
        dec: Angle.Degrees(+23.59130375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131766"},
        {"Hipparcos Number", "HIP 72982"},
        {"Smithsonian Astrophysical Observation", "SAO 83577"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.72505605),
        dec: Angle.Degrees(+23.59306871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110872"},
        {"Hipparcos Number", "HIP 62216"},
        {"Geneva Identification System", "GEN# +1.00110872"},
        {"Smithsonian Astrophysical Observation", "SAO 82470"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.26610822),
        dec: Angle.Degrees(+23.59368073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1968"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.23169691),
        dec: Angle.Degrees(+23.59419454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9153",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1563 A"},
        {"Henry Draper", "HD 11973"},
        {"Hipparcos Number", "HIP 9153"},
        {"Geneva Identification System", "GEN# +1.10011973"},
        {"Geneva Identification System 2", "GEN# +1.00011973A"},
        {"Smithsonian Astrophysical Observation", "SAO 75051"},
        {"Wilson Evans Batten Catalogue", "WEB 1923"},
    },
    visualMagnitude: 4.79,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.48239763),
        dec: Angle.Degrees(+23.59609610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1290"},
        {"Hipparcos Number", "HIP 1377"},
        {"Geneva Identification System", "GEN# +1.00001290"},
        {"Smithsonian Astrophysical Observation", "SAO 73871"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.30183851),
        dec: Angle.Degrees(+23.59764940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106835",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15156 AB"},
        {"Hipparcos Number", "HIP 106835"},
        {"Smithsonian Astrophysical Observation", "SAO 89864"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.57406915),
        dec: Angle.Degrees(+23.59847795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55660"},
        {"Geneva Identification System", "GEN# +0.02402350"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.06210036),
        dec: Angle.Degrees(+23.59860751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27370"},
        {"Hipparcos Number", "HIP 20226"},
        {"Geneva Identification System", "GEN# +0.02300675"},
        {"Geneva Identification System 2", "GEN# +1.00027370"},
        {"Smithsonian Astrophysical Observation", "SAO 76555"},
        {"Wilson Evans Batten Catalogue", "WEB 3857"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.01649066),
        dec: Angle.Degrees(+23.59887031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267704"},
        {"Hipparcos Number", "HIP 33777"},
        {"Smithsonian Astrophysical Observation", "SAO 78966"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.21267600),
        dec: Angle.Degrees(+23.59962509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200831"},
        {"Hipparcos Number", "HIP 104086"},
        {"Smithsonian Astrophysical Observation", "SAO 89437"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.31070128),
        dec: Angle.Degrees(+23.60042608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208667"},
        {"Hipparcos Number", "HIP 108381"},
        {"Smithsonian Astrophysical Observation", "SAO 90127"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.36081144),
        dec: Angle.Degrees(+23.60092302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49968"},
        {"Hipparcos Number", "HIP 32968"},
        {"Geneva Identification System", "GEN# +1.00049968"},
        {"Smithsonian Astrophysical Observation", "SAO 78816"},
        {"Wilson Evans Batten Catalogue", "WEB 6636"},
    },
    visualMagnitude: 5.68,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.00004886),
        dec: Angle.Degrees(+23.60174256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84037"},
        {"Hipparcos Number", "HIP 47644"},
        {"Smithsonian Astrophysical Observation", "SAO 80981"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.70656772),
        dec: Angle.Degrees(+23.60196547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43740"},
        {"Hipparcos Number", "HIP 30003"},
        {"Geneva Identification System", "GEN# +1.00043740"},
        {"Smithsonian Astrophysical Observation", "SAO 78210"},
        {"Wilson Evans Batten Catalogue", "WEB 5957"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.72677881),
        dec: Angle.Degrees(+23.60329943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47086"},
        {"Hipparcos Number", "HIP 31696"},
        {"Smithsonian Astrophysical Observation", "SAO 78568"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.46860660),
        dec: Angle.Degrees(+23.60445296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87681"},
        {"Hipparcos Number", "HIP 49570"},
        {"Smithsonian Astrophysical Observation", "SAO 81188"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.79082826),
        dec: Angle.Degrees(+23.60519801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91139",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11479 AB"},
        {"Henry Draper", "HD 171745"},
        {"Hipparcos Number", "HIP 91139"},
        {"Geneva Identification System", "GEN# +1.00171745"},
        {"Smithsonian Astrophysical Observation", "SAO 86224"},
        {"Wilson Evans Batten Catalogue", "WEB 15650"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.87664511),
        dec: Angle.Degrees(+23.60552870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 342576"},
        {"Hipparcos Number", "HIP 91231"},
        {"Smithsonian Astrophysical Observation", "SAO 86240"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.15077278),
        dec: Angle.Degrees(+23.60627610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146915"},
        {"Hipparcos Number", "HIP 79846"},
        {"Smithsonian Astrophysical Observation", "SAO 84290"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.46472939),
        dec: Angle.Degrees(+23.60721944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69880"},
        {"Geneva Identification System", "GEN# +0.02402714"},
        {"Smithsonian Astrophysical Observation", "SAO 83277"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.49990017),
        dec: Angle.Degrees(+23.60866809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65075"},
        {"Smithsonian Astrophysical Observation", "SAO 82788"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.08886933),
        dec: Angle.Degrees(+23.61057133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66550"},
        {"Hipparcos Number", "HIP 39546"},
        {"Geneva Identification System", "GEN# +1.00066550"},
        {"Smithsonian Astrophysical Observation", "SAO 79917"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.21800232),
        dec: Angle.Degrees(+23.61387195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190993"},
        {"Hipparcos Number", "HIP 99080"},
        {"Celescope Catalog", "CEL 4933"},
        {"Fundamental Katalog 5th Edition", "FK5 3611"},
        {"Geneva Identification System", "GEN# +1.00190993"},
        {"Smithsonian Astrophysical Observation", "SAO 88212"},
        {"Wilson Evans Batten Catalogue", "WEB 17619"},
    },
    visualMagnitude: 5.08,
    bvColour: -0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.72249122),
        dec: Angle.Degrees(+23.61442409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98562"},
        {"Hipparcos Number", "HIP 55398"},
        {"Geneva Identification System", "GEN# +1.00098562"},
        {"Smithsonian Astrophysical Observation", "SAO 81782"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.15236853),
        dec: Angle.Degrees(+23.61460539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182636"},
        {"Hipparcos Number", "HIP 95434"},
        {"Geneva Identification System", "GEN# +1.00182636"},
        {"Smithsonian Astrophysical Observation", "SAO 87172"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.18675223),
        dec: Angle.Degrees(+23.61560205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171245"},
        {"Hipparcos Number", "HIP 90915"},
        {"Fundamental Katalog 5th Edition", "FK5 3472"},
        {"Geneva Identification System", "GEN# +1.00171245"},
        {"Smithsonian Astrophysical Observation", "SAO 86175"},
        {"Wilson Evans Batten Catalogue", "WEB 15594"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.19227861),
        dec: Angle.Degrees(+23.61677633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70529"},
        {"Cincinnati Publication", "Ci 20 856"},
        {"Geneva Identification System", "GEN# +0.02402733A"},
        {"Smithsonian Astrophysical Observation", "SAO 83344"},
        {"Wilson Evans Batten Catalogue", "WEB 12233"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.42904283),
        dec: Angle.Degrees(+23.61979409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 794.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1115.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128480"},
        {"Hipparcos Number", "HIP 71439"},
        {"Smithsonian Astrophysical Observation", "SAO 83432"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.13470494),
        dec: Angle.Degrees(+23.62148341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77119"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.20247608),
        dec: Angle.Degrees(+23.62268891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70536",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70536"},
        {"Cincinnati Publication", "Ci 20 857"},
        {"Cincinnati Publication 2", "Ci 18 1895"},
        {"Geneva Identification System", "GEN# +0.02402733B"},
        {"Smithsonian Astrophysical Observation", "SAO 83345"},
        {"Wilson Evans Batten Catalogue", "WEB 12234"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.44227875),
        dec: Angle.Degrees(+23.62319461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 795.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1119.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64705"},
        {"Hipparcos Number", "HIP 38761"},
        {"Smithsonian Astrophysical Observation", "SAO 79805"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.02694976),
        dec: Angle.Degrees(+23.62385015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247920"},
        {"Hipparcos Number", "HIP 27496"},
        {"Smithsonian Astrophysical Observation", "SAO 77598"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.33904911),
        dec: Angle.Degrees(+23.62478698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197681"},
        {"Hipparcos Number", "HIP 102374"},
        {"Smithsonian Astrophysical Observation", "SAO 89074"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.14732886),
        dec: Angle.Degrees(+23.62497659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152275"},
        {"Hipparcos Number", "HIP 82486"},
        {"Smithsonian Astrophysical Observation", "SAO 84647"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.88100227),
        dec: Angle.Degrees(+23.62560561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177348"},
        {"Hipparcos Number", "HIP 93561"},
        {"Geneva Identification System", "GEN# +1.00177348"},
        {"Smithsonian Astrophysical Observation", "SAO 86745"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.84560707),
        dec: Angle.Degrees(+23.62734631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30122"},
        {"Hipparcos Number", "HIP 22128"},
        {"Geneva Identification System", "GEN# +1.00030122"},
        {"Smithsonian Astrophysical Observation", "SAO 76737"},
        {"Wilson Evans Batten Catalogue", "WEB 4252"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.42692303),
        dec: Angle.Degrees(+23.62803649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24983"},
        {"Hipparcos Number", "HIP 18620"},
        {"Smithsonian Astrophysical Observation", "SAO 76366"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.76434171),
        dec: Angle.Degrees(+23.62809497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110625"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.15689485),
        dec: Angle.Degrees(+23.62836081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4288",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 755 AB"},
        {"Henry Draper", "HD 5286"},
        {"Hipparcos Number", "HIP 4288"},
        {"Geneva Identification System", "GEN# +1.00005286"},
        {"Smithsonian Astrophysical Observation", "SAO 74359"},
        {"Wilson Evans Batten Catalogue", "WEB 771"},
    },
    visualMagnitude: 5.46,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.74174956),
        dec: Angle.Degrees(+23.62844595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57107"},
        {"Hipparcos Number", "HIP 35596"},
        {"Smithsonian Astrophysical Observation", "SAO 79302"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.19247961),
        dec: Angle.Degrees(+23.63070364)
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
    primaryId: "HIP 4032",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 700 AB"},
        {"Henry Draper", "HD 4933"},
        {"Hipparcos Number", "HIP 4032"},
        {"Smithsonian Astrophysical Observation", "SAO 74323"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.90895634),
        dec: Angle.Degrees(+23.63214704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61550",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8608 AB"},
        {"Henry Draper", "HD 109719"},
        {"Hipparcos Number", "HIP 61550"},
        {"Smithsonian Astrophysical Observation", "SAO 82400"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.17755716),
        dec: Angle.Degrees(+23.63316419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109954"},
        {"Hipparcos Number", "HIP 61681"},
        {"Geneva Identification System", "GEN# +1.00109954"},
        {"Smithsonian Astrophysical Observation", "SAO 82416"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.66915559),
        dec: Angle.Degrees(+23.63467443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80103"},
        {"Smithsonian Astrophysical Observation", "SAO 84314"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.27583806),
        dec: Angle.Degrees(+23.63516410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344464"},
        {"Hipparcos Number", "HIP 95880"},
        {"Smithsonian Astrophysical Observation", "SAO 87279"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.50370930),
        dec: Angle.Degrees(+23.63586250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284163"},
        {"Henry Draper 2", "HD 284163A"},
        {"Hipparcos Number", "HIP 19591"},
        {"Wilson Evans Batten Catalogue", "WEB 3748"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.98389231),
        dec: Angle.Degrees(+23.63645851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115899"},
        {"Hipparcos Number", "HIP 65037"},
        {"Geneva Identification System", "GEN# +1.00115899"},
        {"Smithsonian Astrophysical Observation", "SAO 82786"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.96416935),
        dec: Angle.Degrees(+23.63647851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17331"},
        {"Hipparcos Number", "HIP 13035"},
        {"Geneva Identification System", "GEN# +1.00017331"},
        {"Smithsonian Astrophysical Observation", "SAO 75575"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.87647539),
        dec: Angle.Degrees(+23.63664607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76221"},
        {"Smithsonian Astrophysical Observation", "SAO 83889"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.55519181),
        dec: Angle.Degrees(+23.63807444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193554"},
        {"Hipparcos Number", "HIP 100259"},
        {"Smithsonian Astrophysical Observation", "SAO 88531"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.01522726),
        dec: Angle.Degrees(+23.63811400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41543"},
        {"Hipparcos Number", "HIP 28969"},
        {"Fundamental Katalog 5th Edition", "FK5 4556"},
        {"Smithsonian Astrophysical Observation", "SAO 77971"},
        {"Wilson Evans Batten Catalogue", "WEB 5670"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.70274986),
        dec: Angle.Degrees(+23.63860641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106140",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15027 A"},
        {"Henry Draper", "HD 204724"},
        {"Hipparcos Number", "HIP 106140"},
        {"Fundamental Katalog 5th Edition", "FK5 1565"},
        {"Geneva Identification System", "GEN# +1.00204724"},
        {"Smithsonian Astrophysical Observation", "SAO 89752"},
        {"Wilson Evans Batten Catalogue", "WEB 19233"},
    },
    visualMagnitude: 4.52,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.48699859),
        dec: Angle.Degrees(+23.63882922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63735",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8758 AB"},
        {"Hipparcos Number", "HIP 63735"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.91767780),
        dec: Angle.Degrees(+23.64313054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197516"},
        {"Hipparcos Number", "HIP 102277"},
        {"Smithsonian Astrophysical Observation", "SAO 89049"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.85458830),
        dec: Angle.Degrees(+23.64474006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115556"},
        {"Hipparcos Number", "HIP 64841"},
        {"Geneva Identification System", "GEN# +1.00115556"},
        {"Smithsonian Astrophysical Observation", "SAO 82758"},
        {"Wilson Evans Batten Catalogue", "WEB 11461"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.37977335),
        dec: Angle.Degrees(+23.64488077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48641"},
        {"Hipparcos Number", "HIP 32367"},
        {"Smithsonian Astrophysical Observation", "SAO 78707"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.34699157),
        dec: Angle.Degrees(+23.64622946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84680"},
        {"Hipparcos Number", "HIP 48023"},
        {"Geneva Identification System", "GEN# +1.00084680"},
        {"Smithsonian Astrophysical Observation", "SAO 81015"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.84251980),
        dec: Angle.Degrees(+23.64769203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23157"},
        {"Hipparcos Number", "HIP 17401"},
        {"Geneva Identification System", "GEN# +5.20220157"},
        {"Smithsonian Astrophysical Observation", "SAO 76103"},
        {"Wilson Evans Batten Catalogue", "WEB 3289"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.92300763),
        dec: Angle.Degrees(+23.64926000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21804"},
        {"Hipparcos Number", "HIP 16440"},
        {"Geneva Identification System", "GEN# +1.00021804"},
        {"Smithsonian Astrophysical Observation", "SAO 75977"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.92665785),
        dec: Angle.Degrees(+23.64944546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32500"},
        {"Hipparcos Number", "HIP 23606"},
        {"Smithsonian Astrophysical Observation", "SAO 76942"},
        {"New General Catalogue", "NGC 1750 1110"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.14080041),
        dec: Angle.Degrees(+23.64953191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217092"},
        {"Hipparcos Number", "HIP 113384"},
        {"Smithsonian Astrophysical Observation", "SAO 90900"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.44501931),
        dec: Angle.Degrees(+23.65159100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113037"},
        {"Hipparcos Number", "HIP 63493"},
        {"Geneva Identification System", "GEN# +1.00113037"},
        {"Smithsonian Astrophysical Observation", "SAO 82604"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.14660024),
        dec: Angle.Degrees(+23.65177441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87166",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10812 AB"},
        {"Hipparcos Number", "HIP 87166"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.14024639),
        dec: Angle.Degrees(+23.65256560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79872"},
        {"Hipparcos Number", "HIP 45574"},
        {"Wilson Evans Batten Catalogue", "WEB 8660"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.33018152),
        dec: Angle.Degrees(+23.65287786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106421"},
        {"Hipparcos Number", "HIP 59692"},
        {"Geneva Identification System", "GEN# +5.21110029"},
        {"Smithsonian Astrophysical Observation", "SAO 82201"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.61468184),
        dec: Angle.Degrees(+23.66154469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62926"},
        {"Hipparcos Number", "HIP 37988"},
        {"Smithsonian Astrophysical Observation", "SAO 79688"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.78750384),
        dec: Angle.Degrees(+23.66377404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200290"},
        {"Hipparcos Number", "HIP 103791"},
        {"Smithsonian Astrophysical Observation", "SAO 89382"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.47852525),
        dec: Angle.Degrees(+23.66589651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81810",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10171 AB"},
        {"Henry Draper", "HD 150828"},
        {"Hipparcos Number", "HIP 81810"},
        {"Smithsonian Astrophysical Observation", "SAO 84552"},
        {"Smithsonian Astrophysical Observation 2", "SAO 84551"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.64510480),
        dec: Angle.Degrees(+23.66718932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194912"},
        {"Hipparcos Number", "HIP 100887"},
        {"Smithsonian Astrophysical Observation", "SAO 88698"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.84341411),
        dec: Angle.Degrees(+23.66795356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67062",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9007 AB"},
        {"Henry Draper", "HD 119731"},
        {"Hipparcos Number", "HIP 67062"},
        {"Geneva Identification System", "GEN# +1.00119731J"},
        {"Smithsonian Astrophysical Observation", "SAO 82979"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.14156719),
        dec: Angle.Degrees(+23.66830005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45376"},
        {"Hipparcos Number", "HIP 30774"},
        {"Geneva Identification System", "GEN# +1.00045376"},
        {"Smithsonian Astrophysical Observation", "SAO 78399"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.99512658),
        dec: Angle.Degrees(+23.66846154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194163"},
        {"Hipparcos Number", "HIP 100555"},
        {"Fundamental Katalog 5th Edition", "FK5 5798"},
        {"Smithsonian Astrophysical Observation", "SAO 88617"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.85376353),
        dec: Angle.Degrees(+23.66971269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251971"},
        {"Hipparcos Number", "HIP 29070"},
        {"Geneva Identification System", "GEN# +1.00251971"},
        {"Smithsonian Astrophysical Observation", "SAO 78001"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.98558578),
        dec: Angle.Degrees(+23.67042471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141691"},
        {"Hipparcos Number", "HIP 77519"},
        {"Geneva Identification System", "GEN# +1.00141691"},
        {"Smithsonian Astrophysical Observation", "SAO 84020"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.41221452),
        dec: Angle.Degrees(+23.67114629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168670"},
        {"Hipparcos Number", "HIP 89836"},
        {"Renson", "Renson 47270"},
        {"Smithsonian Astrophysical Observation", "SAO 85932"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.99132722),
        dec: Angle.Degrees(+23.67137929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47525"},
        {"Hipparcos Number", "HIP 31903"},
        {"Geneva Identification System", "GEN# +1.00047525"},
        {"Smithsonian Astrophysical Observation", "SAO 78610"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.02229864),
        dec: Angle.Degrees(+23.67380450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95607"},
        {"Hipparcos Number", "HIP 53959"},
        {"Geneva Identification System", "GEN# +1.00095607"},
        {"Smithsonian Astrophysical Observation", "SAO 81638"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.59909720),
        dec: Angle.Degrees(+23.67481383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30191"},
        {"Hipparcos Number", "HIP 22187"},
        {"Smithsonian Astrophysical Observation", "SAO 76742"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.59444772),
        dec: Angle.Degrees(+23.67513037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207245"},
        {"Hipparcos Number", "HIP 107550"},
        {"Smithsonian Astrophysical Observation", "SAO 89987"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.74549575),
        dec: Angle.Degrees(+23.67710743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17632"},
        {"Hipparcos Number", "HIP 13242"},
        {"Geneva Identification System", "GEN# +1.00017632"},
        {"Smithsonian Astrophysical Observation", "SAO 75599"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.60843796),
        dec: Angle.Degrees(+23.67755513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48913"},
        {"Hipparcos Number", "HIP 32491"},
        {"Geneva Identification System", "GEN# +1.00048913"},
        {"Smithsonian Astrophysical Observation", "SAO 78733"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.71180929),
        dec: Angle.Degrees(+23.68040397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196753"},
        {"Henry Draper 2", "HD 196754"},
        {"Hipparcos Number", "HIP 101870"},
        {"Geneva Identification System", "GEN# +1.00196753"},
        {"Smithsonian Astrophysical Observation", "SAO 88946"},
        {"Wilson Evans Batten Catalogue", "WEB 18406"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.64578512),
        dec: Angle.Degrees(+23.68050731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80006"},
        {"Smithsonian Astrophysical Observation", "SAO 84304"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.96913450),
        dec: Angle.Degrees(+23.68231820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169472"},
        {"Hipparcos Number", "HIP 90143"},
        {"Smithsonian Astrophysical Observation", "SAO 86006"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.94475761),
        dec: Angle.Degrees(+23.68276402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9660 A"},
        {"Henry Draper", "HD 137984"},
        {"Hipparcos Number", "HIP 75733"},
        {"Cincinnati Publication", "Ci 18 2068"},
        {"Smithsonian Astrophysical Observation", "SAO 83837"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.08414086),
        dec: Angle.Degrees(+23.68407642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124797"},
        {"Hipparcos Number", "HIP 69626"},
        {"Geneva Identification System", "GEN# +1.00124797"},
        {"Smithsonian Astrophysical Observation", "SAO 83251"},
        {"Wilson Evans Batten Catalogue", "WEB 12126"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.75656996),
        dec: Angle.Degrees(+23.68611383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73344"},
        {"Hipparcos Number", "HIP 42403"},
        {"Fundamental Katalog 5th Edition", "FK5 4776"},
        {"Geneva Identification System", "GEN# +1.00073344"},
        {"Smithsonian Astrophysical Observation", "SAO 80310"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.68979410),
        dec: Angle.Degrees(+23.68626609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157359"},
        {"Hipparcos Number", "HIP 84954"},
        {"Smithsonian Astrophysical Observation", "SAO 85035"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.45683922),
        dec: Angle.Degrees(+23.68631088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19389"},
        {"Hipparcos Number", "HIP 14554"},
        {"Geneva Identification System", "GEN# +1.00019389"},
        {"Smithsonian Astrophysical Observation", "SAO 75744"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.96751473),
        dec: Angle.Degrees(+23.68804754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15552",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2473 AB"},
        {"Henry Draper", "HD 20655"},
        {"Hipparcos Number", "HIP 15552"},
        {"Smithsonian Astrophysical Observation", "SAO 75873"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.08845974),
        dec: Angle.Degrees(+23.68942541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9091"},
        {"Hipparcos Number", "HIP 6975"},
        {"Geneva Identification System", "GEN# +1.00009091"},
        {"Smithsonian Astrophysical Observation", "SAO 74753"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.45285280),
        dec: Angle.Degrees(+23.69056180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5870"},
        {"Hipparcos Number", "HIP 4706"},
        {"Smithsonian Astrophysical Observation", "SAO 74427"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.12463874),
        dec: Angle.Degrees(+23.69187479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16529"},
        {"Geneva Identification System", "GEN# +5.20250004"},
        {"Smithsonian Astrophysical Observation", "SAO 75985"},
        {"Wilson Evans Batten Catalogue", "WEB 3159"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.20823163),
        dec: Angle.Degrees(+23.69228308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64704"},
        {"Hipparcos Number", "HIP 38755"},
        {"Geneva Identification System", "GEN# +1.00064704J"},
        {"Smithsonian Astrophysical Observation", "SAO 79804"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.01171428),
        dec: Angle.Degrees(+23.69307762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9430"},
        {"Hipparcos Number", "HIP 7217"},
        {"Smithsonian Astrophysical Observation", "SAO 74779"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.24054526),
        dec: Angle.Degrees(+23.69607202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -204.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26719"},
        {"Hipparcos Number", "HIP 19785"},
        {"Smithsonian Astrophysical Observation", "SAO 76512"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.61009999),
        dec: Angle.Degrees(+23.69645378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59169"},
        {"Geneva Identification System", "GEN# +0.02402428"},
        {"Smithsonian Astrophysical Observation", "SAO 82146"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.00957093),
        dec: Angle.Degrees(+23.70265479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100739"},
        {"Hipparcos Number", "HIP 56559"},
        {"Smithsonian Astrophysical Observation", "SAO 81889"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.94039237),
        dec: Angle.Degrees(+23.70278048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95311"},
        {"Hipparcos Number", "HIP 53813"},
        {"Smithsonian Astrophysical Observation", "SAO 81617"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.15334493),
        dec: Angle.Degrees(+23.70616955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11491",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11491"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.04998313),
        dec: Angle.Degrees(+23.70646009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208025"},
        {"Hipparcos Number", "HIP 108003"},
        {"Geneva Identification System", "GEN# +1.00208025"},
        {"Smithsonian Astrophysical Observation", "SAO 90071"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.21375878),
        dec: Angle.Degrees(+23.70663811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101397"},
        {"Hipparcos Number", "HIP 56920"},
        {"Geneva Identification System", "GEN# +1.00101397"},
        {"Smithsonian Astrophysical Observation", "SAO 81930"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.03892476),
        dec: Angle.Degrees(+23.70815157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2495"},
        {"Smithsonian Astrophysical Observation", "SAO 74064"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.91674416),
        dec: Angle.Degrees(+23.70822208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174159"},
        {"Hipparcos Number", "HIP 92265"},
        {"Smithsonian Astrophysical Observation", "SAO 86450"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.05448602),
        dec: Angle.Degrees(+23.70925315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44883"},
        {"Hipparcos Number", "HIP 30548"},
        {"Geneva Identification System", "GEN# +1.00044883"},
        {"Smithsonian Astrophysical Observation", "SAO 78344"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.32773581),
        dec: Angle.Degrees(+23.70953453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196199"},
        {"Hipparcos Number", "HIP 101564"},
        {"Geneva Identification System", "GEN# +1.00196199"},
        {"Smithsonian Astrophysical Observation", "SAO 88866"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.76159193),
        dec: Angle.Degrees(+23.71046365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23923"},
        {"Hipparcos Number", "HIP 17900"},
        {"Celescope Catalog", "CEL 363"},
        {"Geneva Identification System", "GEN# +5.20222425"},
        {"Smithsonian Astrophysical Observation", "SAO 76244"},
        {"Wilson Evans Batten Catalogue", "WEB 3446"},
    },
    visualMagnitude: 6.17,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.43133245),
        dec: Angle.Degrees(+23.71196331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345556"},
        {"Hipparcos Number", "HIP 98727"},
        {"Smithsonian Astrophysical Observation", "SAO 88119"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.77558054),
        dec: Angle.Degrees(+23.71546831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151202"},
        {"Hipparcos Number", "HIP 81996"},
        {"Cincinnati Publication", "Ci 18 2234"},
        {"Smithsonian Astrophysical Observation", "SAO 84574"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.25998355),
        dec: Angle.Degrees(+23.71777243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96801",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12778 A"},
        {"Henry Draper", "HD 185915"},
        {"Hipparcos Number", "HIP 96801"},
        {"Geneva Identification System", "GEN# +1.00185915J"},
        {"Smithsonian Astrophysical Observation", "SAO 87551"},
        {"Wilson Evans Batten Catalogue", "WEB 16987"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.16492109),
        dec: Angle.Degrees(+23.71797274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102357"},
        {"Hipparcos Number", "HIP 57488"},
        {"Geneva Identification System", "GEN# +1.00102357"},
        {"Smithsonian Astrophysical Observation", "SAO 81988"},
        {"Wilson Evans Batten Catalogue", "WEB 10322"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.75397911),
        dec: Angle.Degrees(+23.72044618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71805"},
        {"Smithsonian Astrophysical Observation", "SAO 83468"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.32601771),
        dec: Angle.Degrees(+23.72212284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23609"},
        {"Hipparcos Number", "HIP 17684"},
        {"Celescope Catalog", "CEL 336"},
        {"Geneva Identification System", "GEN# +5.20221357"},
        {"Smithsonian Astrophysical Observation", "SAO 76189"},
        {"Wilson Evans Batten Catalogue", "WEB 20796"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.82151746),
        dec: Angle.Degrees(+23.72681291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104419",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104419"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.28818667),
        dec: Angle.Degrees(+23.72835959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96818",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12778 C"},
        {"Henry Draper", "HD 344694"},
        {"Hipparcos Number", "HIP 96818"},
        {"Geneva Identification System", "GEN# +1.00344694"},
        {"Smithsonian Astrophysical Observation", "SAO 87555"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.19780405),
        dec: Angle.Degrees(+23.73110541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45178"},
        {"Hipparcos Number", "HIP 30698"},
        {"Smithsonian Astrophysical Observation", "SAO 78378"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.75051550),
        dec: Angle.Degrees(+23.73387086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85855"},
        {"Smithsonian Astrophysical Observation", "SAO 85193"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.17431971),
        dec: Angle.Degrees(+23.73677746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -332.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 342569"},
        {"Hipparcos Number", "HIP 91186"},
        {"Smithsonian Astrophysical Observation", "SAO 86233"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.03310321),
        dec: Angle.Degrees(+23.73721745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41752"},
        {"Hipparcos Number", "HIP 29081"},
        {"Geneva Identification System", "GEN# +1.00041752"},
        {"Smithsonian Astrophysical Observation", "SAO 78005"},
        {"Wilson Evans Batten Catalogue", "WEB 5697"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.02016525),
        dec: Angle.Degrees(+23.73803611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284421"},
        {"Hipparcos Number", "HIP 20644"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.36255910),
        dec: Angle.Degrees(+23.73830228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115250",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Salm"},
        {"Henry Draper", "HD 220061"},
        {"Hipparcos Number", "HIP 115250"},
        {"Fundamental Katalog 5th Edition", "FK5 880"},
        {"Geneva Identification System", "GEN# +1.00220061"},
        {"Smithsonian Astrophysical Observation", "SAO 91186"},
        {"Wilson Evans Batten Catalogue", "WEB 20415"},
    },
    visualMagnitude: 4.58,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.15926320),
        dec: Angle.Degrees(+23.74035920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57842"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.92839406),
        dec: Angle.Degrees(+23.74077955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43384"},
        {"Hipparcos Number", "HIP 29840"},
        {"Geneva Identification System", "GEN# +1.00043384"},
        {"Smithsonian Astrophysical Observation", "SAO 78176"},
        {"Wilson Evans Batten Catalogue", "WEB 5901"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.24460603),
        dec: Angle.Degrees(+23.74091563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17675"},
        {"Hipparcos Number", "HIP 13277"},
        {"Smithsonian Astrophysical Observation", "SAO 75602"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.72355116),
        dec: Angle.Degrees(+23.74126151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192712"},
        {"Hipparcos Number", "HIP 99852"},
        {"Geneva Identification System", "GEN# +1.00192712"},
        {"Smithsonian Astrophysical Observation", "SAO 88417"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.87496912),
        dec: Angle.Degrees(+23.74201555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 264152"},
        {"Hipparcos Number", "HIP 32678"},
        {"Smithsonian Astrophysical Observation", "SAO 78767"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.24349405),
        dec: Angle.Degrees(+23.74246673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156284"},
        {"Hipparcos Number", "HIP 84431"},
        {"Geneva Identification System", "GEN# +1.00156284"},
        {"Smithsonian Astrophysical Observation", "SAO 84955"},
        {"Wilson Evans Batten Catalogue", "WEB 14253"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.92290165),
        dec: Angle.Degrees(+23.74270442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7768",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7768"},
        {"Smithsonian Astrophysical Observation", "SAO 74861"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.99920579),
        dec: Angle.Degrees(+23.74485988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198583"},
        {"Hipparcos Number", "HIP 102874"},
        {"Geneva Identification System", "GEN# +1.00198583"},
        {"Smithsonian Astrophysical Observation", "SAO 89195"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.64634999),
        dec: Angle.Degrees(+23.74551507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72207"},
        {"Hipparcos Number", "HIP 41883"},
        {"Smithsonian Astrophysical Observation", "SAO 80235"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.10081318),
        dec: Angle.Degrees(+23.74655706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68849"},
        {"Hipparcos Number", "HIP 40421"},
        {"Smithsonian Astrophysical Observation", "SAO 80042"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.78744002),
        dec: Angle.Degrees(+23.74704654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62705"},
    },
    visualMagnitude: 11.08,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.74340525),
        dec: Angle.Degrees(+23.74725099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38319"},
        {"Hipparcos Number", "HIP 27203"},
        {"Smithsonian Astrophysical Observation", "SAO 77526"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.49431543),
        dec: Angle.Degrees(+23.74747471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30885"},
        {"Hipparcos Number", "HIP 22653"},
        {"Smithsonian Astrophysical Observation", "SAO 76796"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.09407912),
        dec: Angle.Degrees(+23.75165877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160965"},
        {"Hipparcos Number", "HIP 86599"},
        {"Smithsonian Astrophysical Observation", "SAO 85328"},
    },
    visualMagnitude: 6.96,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.45738617),
        dec: Angle.Degrees(+23.75345274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88371"},
        {"Hipparcos Number", "HIP 49942"},
        {"Cincinnati Publication", "Ci 20 565"},
        {"Geneva Identification System", "GEN# +1.00088371"},
        {"Smithsonian Astrophysical Observation", "SAO 81224"},
        {"Wilson Evans Batten Catalogue", "WEB 9190"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.95129403),
        dec: Angle.Degrees(+23.75501401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -378.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138266"},
        {"Hipparcos Number", "HIP 75900"},
        {"Smithsonian Astrophysical Observation", "SAO 83854"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.54382638),
        dec: Angle.Degrees(+23.75564130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53370",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7975 AB"},
        {"Henry Draper", "HD 94498"},
        {"Hipparcos Number", "HIP 53370"},
        {"Geneva Identification System", "GEN# +1.00094498"},
        {"Smithsonian Astrophysical Observation", "SAO 81578"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.70724609),
        dec: Angle.Degrees(+23.75566775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80856"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.67194890),
        dec: Angle.Degrees(+23.75671842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20209",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3131 C"},
        {"Henry Draper", "HD 284287"},
        {"Hipparcos Number", "HIP 20209"},
        {"Smithsonian Astrophysical Observation", "SAO 76553"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.96543348),
        dec: Angle.Degrees(+23.75789284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36054"},
        {"Hipparcos Number", "HIP 25761"},
        {"Geneva Identification System", "GEN# +1.00036054"},
        {"Smithsonian Astrophysical Observation", "SAO 77211"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.51343168),
        dec: Angle.Degrees(+23.75875729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210801"},
        {"Hipparcos Number", "HIP 109627"},
        {"Smithsonian Astrophysical Observation", "SAO 90321"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.11087856),
        dec: Angle.Degrees(+23.75895918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220539"},
        {"Hipparcos Number", "HIP 115549"},
        {"Smithsonian Astrophysical Observation", "SAO 91239"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.07957730),
        dec: Angle.Degrees(+23.75994408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120751"},
        {"Hipparcos Number", "HIP 67594"},
        {"Geneva Identification System", "GEN# +1.00120751"},
        {"Smithsonian Astrophysical Observation", "SAO 83032"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.76190966),
        dec: Angle.Degrees(+23.76276704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120751B"},
        {"Hipparcos Number", "HIP 67593"},
    },
    visualMagnitude: 13.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.75601036),
        dec: Angle.Degrees(+23.76362602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2281.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5369.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284738"},
        {"Hipparcos Number", "HIP 22306"},
        {"Smithsonian Astrophysical Observation", "SAO 76763"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.06497591),
        dec: Angle.Degrees(+23.76363403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14067"},
        {"Hipparcos Number", "HIP 10657"},
        {"Fundamental Katalog 5th Edition", "FK5 2156"},
        {"Geneva Identification System", "GEN# +1.00014067"},
        {"Smithsonian Astrophysical Observation", "SAO 75262"},
        {"Wilson Evans Batten Catalogue", "WEB 2243"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.29358530),
        dec: Angle.Degrees(+23.76793086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6229"},
        {"Hipparcos Number", "HIP 4960"},
        {"Geneva Identification System", "GEN# +1.00006229"},
        {"Smithsonian Astrophysical Observation", "SAO 74458"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.90186079),
        dec: Angle.Degrees(+23.76848837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77788"},
    },
    visualMagnitude: 11.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.26014924),
        dec: Angle.Degrees(+23.76978753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45423",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7259 AB"},
        {"Henry Draper", "HD 79531"},
        {"Hipparcos Number", "HIP 45423"},
        {"Smithsonian Astrophysical Observation", "SAO 80719"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.84541578),
        dec: Angle.Degrees(+23.77000783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3757"},
        {"Hipparcos Number", "HIP 3167"},
        {"Smithsonian Astrophysical Observation", "SAO 74186"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.09599876),
        dec: Angle.Degrees(+23.77019039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249731"},
        {"Hipparcos Number", "HIP 28279"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.62912896),
        dec: Angle.Degrees(+23.77300432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108956"},
        {"Hipparcos Number", "HIP 61075"},
        {"Geneva Identification System", "GEN# +5.21110161"},
        {"Smithsonian Astrophysical Observation", "SAO 82347"},
        {"Wilson Evans Batten Catalogue", "WEB 10872"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.76381716),
        dec: Angle.Degrees(+23.77301022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84441"},
        {"Hipparcos Number", "HIP 47908"},
        {"Fundamental Katalog 5th Edition", "FK5 367"},
        {"Geneva Identification System", "GEN# +1.00084441"},
        {"Smithsonian Astrophysical Observation", "SAO 81004"},
        {"Wilson Evans Batten Catalogue", "WEB 8962"},
    },
    visualMagnitude: 2.97,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.46292670),
        dec: Angle.Degrees(+23.77427792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87519"},
        {"Smithsonian Astrophysical Observation", "SAO 85502"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.20970136),
        dec: Angle.Degrees(+23.77601800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188929"},
        {"Hipparcos Number", "HIP 98154"},
        {"Geneva Identification System", "GEN# +1.00188929"},
        {"Smithsonian Astrophysical Observation", "SAO 87959"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.20728597),
        dec: Angle.Degrees(+23.77669989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80751"},
        {"Cincinnati Publication", "Ci 20 994"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.30997804),
        dec: Angle.Degrees(+23.77688017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -324.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130384"},
        {"Hipparcos Number", "HIP 72316"},
        {"Smithsonian Astrophysical Observation", "SAO 83518"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.82875970),
        dec: Angle.Degrees(+23.77864291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57930"},
        {"Smithsonian Astrophysical Observation", "SAO 82026"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.22064701),
        dec: Angle.Degrees(+23.78039472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77052"},
        {"Hipparcos Number", "HIP 44262"},
        {"Smithsonian Astrophysical Observation", "SAO 80575"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.20515034),
        dec: Angle.Degrees(+23.78041291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343005"},
        {"Hipparcos Number", "HIP 92049"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.42578866),
        dec: Angle.Degrees(+23.78120314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284572"},
        {"Hipparcos Number", "HIP 21551"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.41197390),
        dec: Angle.Degrees(+23.78240317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176696"},
        {"Hipparcos Number", "HIP 93337"},
        {"Smithsonian Astrophysical Observation", "SAO 86691"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.15202003),
        dec: Angle.Degrees(+23.78290721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43206"},
        {"Hipparcos Number", "HIP 29757"},
        {"Smithsonian Astrophysical Observation", "SAO 78155"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.00057051),
        dec: Angle.Degrees(+23.78324917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46791"},
        {"Smithsonian Astrophysical Observation", "SAO 80891"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.02055439),
        dec: Angle.Degrees(+23.78416597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15844"},
        {"Geneva Identification System", "GEN# +6.00111120"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.02642250),
        dec: Angle.Degrees(+23.78534067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38692"},
        {"Hipparcos Number", "HIP 27442"},
        {"Smithsonian Astrophysical Observation", "SAO 77586"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.16069749),
        dec: Angle.Degrees(+23.78547860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344457"},
        {"Hipparcos Number", "HIP 95917"},
        {"Smithsonian Astrophysical Observation", "SAO 87291"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.59827784),
        dec: Angle.Degrees(+23.78554608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
