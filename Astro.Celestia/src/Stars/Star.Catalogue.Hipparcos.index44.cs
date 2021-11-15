using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_44() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94851"},
        {"Hipparcos Number", "HIP 53503"},
        {"Smithsonian Astrophysical Observation", "SAO 179363"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.18443325),
        dec: Angle.Degrees(-20.66463310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2318"},
        {"Hipparcos Number", "HIP 2122"},
        {"Geneva Identification System", "GEN# +1.00002318"},
        {"Smithsonian Astrophysical Observation", "SAO 166275"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.72154760),
        dec: Angle.Degrees(-20.66430961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4396"},
        {"Hipparcos Number", "HIP 3605"},
        {"Geneva Identification System", "GEN# +1.00004396"},
        {"Smithsonian Astrophysical Observation", "SAO 166553"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.54540617),
        dec: Angle.Degrees(-20.66376547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104414"},
        {"Hipparcos Number", "HIP 58626"},
        {"Smithsonian Astrophysical Observation", "SAO 180388"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.34710509),
        dec: Angle.Degrees(-20.66374391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60218"},
        {"Hipparcos Number", "HIP 36669"},
        {"Wilson Evans Batten Catalogue", "WEB 7290"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.15859305),
        dec: Angle.Degrees(-20.65811047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1869"},
        {"Hipparcos Number", "HIP 1808"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.73730624),
        dec: Angle.Degrees(-20.65646163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175687"},
        {"Hipparcos Number", "HIP 93057"},
        {"Geneva Identification System", "GEN# +1.00175687"},
        {"Smithsonian Astrophysical Observation", "SAO 187498"},
        {"Wilson Evans Batten Catalogue", "WEB 16115"},
    },
    visualMagnitude: 5.02,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.33532364),
        dec: Angle.Degrees(-20.65633439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97751"},
        {"Hipparcos Number", "HIP 54914"},
        {"Smithsonian Astrophysical Observation", "SAO 179680"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.67650930),
        dec: Angle.Degrees(-20.65569839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155233"},
        {"Hipparcos Number", "HIP 84056"},
        {"Geneva Identification System", "GEN# +1.00155233"},
        {"Smithsonian Astrophysical Observation", "SAO 185116"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.76820806),
        dec: Angle.Degrees(-20.65423411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168988"},
        {"Hipparcos Number", "HIP 90113"},
        {"Geneva Identification System", "GEN# +1.00168988"},
        {"Smithsonian Astrophysical Observation", "SAO 186750"},
    },
    visualMagnitude: 7.63,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.83302964),
        dec: Angle.Degrees(-20.65363453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202320"},
        {"Hipparcos Number", "HIP 104963"},
        {"Geneva Identification System", "GEN# +1.00202320"},
        {"Smithsonian Astrophysical Observation", "SAO 190173"},
        {"Wilson Evans Batten Catalogue", "WEB 19075"},
    },
    visualMagnitude: 5.17,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.90787714),
        dec: Angle.Degrees(-20.65169052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57544"},
        {"Hipparcos Number", "HIP 35610"},
        {"Smithsonian Astrophysical Observation", "SAO 173515"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.22557154),
        dec: Angle.Degrees(-20.64906810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19478"},
        {"Hipparcos Number", "HIP 14498"},
        {"Geneva Identification System", "GEN# +1.00019478"},
        {"Smithsonian Astrophysical Observation", "SAO 168313"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.82027267),
        dec: Angle.Degrees(-20.64868174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81713"},
        {"Hipparcos Number", "HIP 46332"},
        {"Geneva Identification System", "GEN# +1.00081713"},
        {"Smithsonian Astrophysical Observation", "SAO 177456"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.69104013),
        dec: Angle.Degrees(-20.64817205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45131"},
        {"Hipparcos Number", "HIP 30511"},
        {"Smithsonian Astrophysical Observation", "SAO 171708"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.20123245),
        dec: Angle.Degrees(-20.64802832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173297"},
        {"Hipparcos Number", "HIP 92013"},
        {"Geneva Identification System", "GEN# +1.00173297"},
        {"Smithsonian Astrophysical Observation", "SAO 187233"},
        {"Wilson Evans Batten Catalogue", "WEB 15853"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.32290856),
        dec: Angle.Degrees(-20.64737037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59343"},
        {"Hipparcos Number", "HIP 36330"},
        {"Renson", "Renson 16200"},
        {"Smithsonian Astrophysical Observation", "SAO 173821"},
    },
    visualMagnitude: 9.13,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.17398513),
        dec: Angle.Degrees(-20.64723401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121785"},
        {"Hipparcos Number", "HIP 68219"},
        {"Geneva Identification System", "GEN# +1.00121785"},
        {"Smithsonian Astrophysical Observation", "SAO 182127"},
        {"Wilson Evans Batten Catalogue", "WEB 11968"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.49227331),
        dec: Angle.Degrees(-20.64540384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11073"},
        {"Hipparcos Number", "HIP 8403"},
        {"Geneva Identification System", "GEN# +1.00011073"},
        {"Smithsonian Astrophysical Observation", "SAO 167309"},
        {"Wilson Evans Batten Catalogue", "WEB 1788"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.10400781),
        dec: Angle.Degrees(-20.64327847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181809"},
        {"Hipparcos Number", "HIP 95244"},
        {"Smithsonian Astrophysical Observation", "SAO 188043"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.66790375),
        dec: Angle.Degrees(-20.64265505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220704"},
        {"Hipparcos Number", "HIP 115669"},
        {"Geneva Identification System", "GEN# +1.00220704"},
        {"Smithsonian Astrophysical Observation", "SAO 191900"},
        {"Wilson Evans Batten Catalogue", "WEB 20469"},
    },
    visualMagnitude: 4.38,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.51173897),
        dec: Angle.Degrees(-20.64186122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156522"},
        {"Hipparcos Number", "HIP 84693"},
        {"Smithsonian Astrophysical Observation", "SAO 185255"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.70259945),
        dec: Angle.Degrees(-20.64183118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218072"},
        {"Hipparcos Number", "HIP 114011"},
        {"Smithsonian Astrophysical Observation", "SAO 191637"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.34490357),
        dec: Angle.Degrees(-20.64108665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43672"},
        {"Hipparcos Number", "HIP 29809"},
        {"Smithsonian Astrophysical Observation", "SAO 171491"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.15957148),
        dec: Angle.Degrees(-20.64058759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52485"},
        {"Hipparcos Number", "HIP 33743"},
        {"Smithsonian Astrophysical Observation", "SAO 172736"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.14620965),
        dec: Angle.Degrees(-20.64029046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27616"},
        {"Hipparcos Number", "HIP 20264"},
        {"Fundamental Katalog 5th Edition", "FK5 161"},
        {"Geneva Identification System", "GEN# +1.00027616"},
        {"Smithsonian Astrophysical Observation", "SAO 169354"},
        {"Wilson Evans Batten Catalogue", "WEB 3872"},
    },
    visualMagnitude: 5.38,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.16248826),
        dec: Angle.Degrees(-20.63959902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38967"},
        {"Hipparcos Number", "HIP 27440"},
        {"Geneva Identification System", "GEN# +1.00038967"},
        {"Smithsonian Astrophysical Observation", "SAO 170861"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.15193837),
        dec: Angle.Degrees(-20.63360361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104339"},
        {"Hipparcos Number", "HIP 58593"},
        {"Smithsonian Astrophysical Observation", "SAO 180378"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.22734237),
        dec: Angle.Degrees(-20.63269391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15073"},
        {"Hipparcos Number", "HIP 11274"},
        {"Smithsonian Astrophysical Observation", "SAO 167771"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.30308701),
        dec: Angle.Degrees(-20.63241334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198188"},
        {"Hipparcos Number", "HIP 102762"},
        {"Fundamental Katalog 5th Edition", "FK5 5838"},
        {"Geneva Identification System", "GEN# +1.00198188"},
        {"Smithsonian Astrophysical Observation", "SAO 189735"},
        {"Wilson Evans Batten Catalogue", "WEB 18631"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.31274436),
        dec: Angle.Degrees(-20.63032678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 213.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138311"},
        {"Hipparcos Number", "HIP 76056"},
        {"Smithsonian Astrophysical Observation", "SAO 183545"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.98631633),
        dec: Angle.Degrees(-20.62877340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4062"},
        {"Hipparcos Number", "HIP 3375"},
        {"Smithsonian Astrophysical Observation", "SAO 166509"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.72645502),
        dec: Angle.Degrees(-20.62873568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94340"},
        {"Hipparcos Number", "HIP 53217"},
        {"Geneva Identification System", "GEN# +1.00094340"},
        {"Smithsonian Astrophysical Observation", "SAO 179301"},
        {"Wilson Evans Batten Catalogue", "WEB 9660"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.26934305),
        dec: Angle.Degrees(-20.62749745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -272.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98915"},
        {"Hipparcos Number", "HIP 55570"},
        {"Smithsonian Astrophysical Observation", "SAO 179826"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.73773517),
        dec: Angle.Degrees(-20.62552589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214479"},
        {"Hipparcos Number", "HIP 111802"},
        {"Geneva Identification System", "GEN# +1.00214479A"},
        {"Smithsonian Astrophysical Observation", "SAO 191294"},
        {"Wilson Evans Batten Catalogue", "WEB 19970"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.68872796),
        dec: Angle.Degrees(-20.62094006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 450.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41406"},
        {"Hipparcos Number", "HIP 28733"},
        {"Geneva Identification System", "GEN# +1.00041406"},
        {"Renson", "Renson 11083"},
        {"Smithsonian Astrophysical Observation", "SAO 171195"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.02943425),
        dec: Angle.Degrees(-20.62057037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20001"},
        {"Hipparcos Number", "HIP 14898"},
        {"Geneva Identification System", "GEN# +1.00020001"},
        {"Smithsonian Astrophysical Observation", "SAO 168376"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.06406293),
        dec: Angle.Degrees(-20.61959897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102723",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14313 AB"},
        {"Henry Draper", "HD 198141"},
        {"Hipparcos Number", "HIP 102723"},
        {"Smithsonian Astrophysical Observation", "SAO 189726"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.23190710),
        dec: Angle.Degrees(-20.61892056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 899"},
        {"Hipparcos Number", "HIP 1072"},
        {"Smithsonian Astrophysical Observation", "SAO 166126"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.32615488),
        dec: Angle.Degrees(-20.61881565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110338"},
        {"Hipparcos Number", "HIP 61930"},
        {"Geneva Identification System", "GEN# +1.00110338"},
        {"Smithsonian Astrophysical Observation", "SAO 181022"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.37819634),
        dec: Angle.Degrees(-20.61676554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220689"},
        {"Hipparcos Number", "HIP 115662"},
        {"Geneva Identification System", "GEN# +1.00220689"},
        {"Smithsonian Astrophysical Observation", "SAO 191898"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.47083849),
        dec: Angle.Degrees(-20.61559573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69168"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.37677568),
        dec: Angle.Degrees(-20.61535197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51983"},
        {"Hipparcos Number", "HIP 33592"},
        {"Smithsonian Astrophysical Observation", "SAO 172672"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.68541960),
        dec: Angle.Degrees(-20.61521791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130991"},
        {"Hipparcos Number", "HIP 72692"},
        {"Smithsonian Astrophysical Observation", "SAO 182937"},
        {"Wilson Evans Batten Catalogue", "WEB 12496"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.93770836),
        dec: Angle.Degrees(-20.61419105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75916"},
        {"Smithsonian Astrophysical Observation", "SAO 183527"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.59018456),
        dec: Angle.Degrees(-20.61330040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11468"},
        {"Hipparcos Number", "HIP 8737"},
        {"Smithsonian Astrophysical Observation", "SAO 167366"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.10471119),
        dec: Angle.Degrees(-20.61107029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111401"},
        {"Hipparcos Number", "HIP 62568"},
        {"Smithsonian Astrophysical Observation", "SAO 181125"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.29374673),
        dec: Angle.Degrees(-20.60828566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49105"},
        {"Hipparcos Number", "HIP 32422"},
        {"Geneva Identification System", "GEN# +2.22870097"},
        {"Smithsonian Astrophysical Observation", "SAO 172294"},
        {"New General Catalogue", "NGC 2287 97"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.52017902),
        dec: Angle.Degrees(-20.60691663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217805"},
        {"Hipparcos Number", "HIP 113854"},
        {"Smithsonian Astrophysical Observation", "SAO 191609"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.85412446),
        dec: Angle.Degrees(-20.60401430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92771"},
        {"Hipparcos Number", "HIP 52379"},
        {"Fundamental Katalog 5th Edition", "FK5 4953"},
        {"Renson", "Renson 26800"},
        {"Smithsonian Astrophysical Observation", "SAO 179133"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.59217832),
        dec: Angle.Degrees(-20.60322150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33024"},
        {"Hipparcos Number", "HIP 23773"},
        {"Smithsonian Astrophysical Observation", "SAO 170068"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.64068810),
        dec: Angle.Degrees(-20.59838732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10718"},
        {"Hipparcos Number", "HIP 8121"},
        {"Cincinnati Publication", "Ci 18 241"},
        {"Geneva Identification System", "GEN# +1.00010718"},
        {"Smithsonian Astrophysical Observation", "SAO 167263"},
        {"Wilson Evans Batten Catalogue", "WEB 1738"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.09345308),
        dec: Angle.Degrees(-20.59540467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -306.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153741"},
        {"Hipparcos Number", "HIP 83348"},
        {"Smithsonian Astrophysical Observation", "SAO 184944"},
        {"Wilson Evans Batten Catalogue", "WEB 14087"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.50914308),
        dec: Angle.Degrees(-20.59538018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218413"},
        {"Hipparcos Number", "HIP 114231"},
        {"Smithsonian Astrophysical Observation", "SAO 191670"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.01513174),
        dec: Angle.Degrees(-20.59355916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191250"},
        {"Hipparcos Number", "HIP 99314"},
        {"Geneva Identification System", "GEN# +1.00191250"},
        {"Smithsonian Astrophysical Observation", "SAO 188965"},
        {"Wilson Evans Batten Catalogue", "WEB 17717"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.38937310),
        dec: Angle.Degrees(-20.59346131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76900"},
    },
    visualMagnitude: 10.41,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.52882802),
        dec: Angle.Degrees(-20.58955067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22839"},
        {"Hipparcos Number", "HIP 17053"},
        {"Geneva Identification System", "GEN# +1.00022839"},
        {"Smithsonian Astrophysical Observation", "SAO 168711"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.84791807),
        dec: Angle.Degrees(-20.58897979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141774"},
        {"Hipparcos Number", "HIP 77677"},
        {"Geneva Identification System", "GEN# +1.00141774"},
        {"Smithsonian Astrophysical Observation", "SAO 183864"},
        {"Wilson Evans Batten Catalogue", "WEB 13144"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.87433375),
        dec: Angle.Degrees(-20.58734035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47370"},
        {"Hipparcos Number", "HIP 31645"},
        {"Smithsonian Astrophysical Observation", "SAO 172043"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.35010266),
        dec: Angle.Degrees(-20.58696033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196207"},
        {"Hipparcos Number", "HIP 101666"},
        {"Smithsonian Astrophysical Observation", "SAO 189484"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.11028101),
        dec: Angle.Degrees(-20.58544481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199226"},
        {"Hipparcos Number", "HIP 103362"},
        {"Smithsonian Astrophysical Observation", "SAO 189855"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.11676931),
        dec: Angle.Degrees(-20.58402035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63738",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8757 AB"},
        {"Henry Draper", "HD 113415"},
        {"Hipparcos Number", "HIP 63738"},
        {"Geneva Identification System", "GEN# +1.00113415"},
        {"Smithsonian Astrophysical Observation", "SAO 181357"},
        {"Wilson Evans Batten Catalogue", "WEB 11271"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.94177817),
        dec: Angle.Degrees(-20.58350964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139463"},
        {"Hipparcos Number", "HIP 76631"},
        {"Smithsonian Astrophysical Observation", "SAO 183658"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.74886101),
        dec: Angle.Degrees(-20.58325505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158814"},
        {"Hipparcos Number", "HIP 85814"},
        {"Smithsonian Astrophysical Observation", "SAO 185484"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.02099422),
        dec: Angle.Degrees(-20.58309290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99380"},
        {"Hipparcos Number", "HIP 55802"},
        {"Geneva Identification System", "GEN# +1.00099380"},
        {"Smithsonian Astrophysical Observation", "SAO 179872"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.50842219),
        dec: Angle.Degrees(-20.58221902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55692"},
        {"Hipparcos Number", "HIP 34894"},
        {"Celescope Catalog", "CEL 1680"},
        {"Geneva Identification System", "GEN# +1.00055692"},
        {"Smithsonian Astrophysical Observation", "SAO 173221"},
        {"Wilson Evans Batten Catalogue", "WEB 6974"},
    },
    visualMagnitude: 8.48,
    bvColour: -0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.29113594),
        dec: Angle.Degrees(-20.58132022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67934",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67934"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.68296147),
        dec: Angle.Degrees(-20.57892597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92258"},
        {"Hipparcos Number", "HIP 52105"},
        {"Smithsonian Astrophysical Observation", "SAO 179069"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.69059407),
        dec: Angle.Degrees(-20.57744740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89885"},
        {"Hipparcos Number", "HIP 50768"},
        {"Geneva Identification System", "GEN# +1.00089885"},
        {"Smithsonian Astrophysical Observation", "SAO 178733"},
        {"Wilson Evans Batten Catalogue", "WEB 9294"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.50626362),
        dec: Angle.Degrees(-20.57578148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115981",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16791 AB"},
        {"Henry Draper", "HD 221183"},
        {"Hipparcos Number", "HIP 115981"},
        {"Smithsonian Astrophysical Observation", "SAO 191951"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.47581891),
        dec: Angle.Degrees(-20.57576107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68839"},
        {"Hipparcos Number", "HIP 40276"},
        {"Smithsonian Astrophysical Observation", "SAO 175408"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.37880080),
        dec: Angle.Degrees(-20.57481705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52643"},
        {"Hipparcos Number", "HIP 33820"},
        {"Celescope Catalog", "CEL 1509"},
        {"Geneva Identification System", "GEN# +1.00052643"},
        {"Smithsonian Astrophysical Observation", "SAO 172764"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.31430254),
        dec: Angle.Degrees(-20.57259431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115983",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16791 C"},
        {"Hipparcos Number", "HIP 115983"},
    },
    visualMagnitude: 9.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.47779759),
        dec: Angle.Degrees(-20.57044313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120571"},
        {"Hipparcos Number", "HIP 67565"},
        {"Geneva Identification System", "GEN# +1.00120571"},
        {"Smithsonian Astrophysical Observation", "SAO 182014"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.67675725),
        dec: Angle.Degrees(-20.57039415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157072"},
        {"Hipparcos Number", "HIP 84958"},
        {"Smithsonian Astrophysical Observation", "SAO 185318"},
        {"Wilson Evans Batten Catalogue", "WEB 14349"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.46485284),
        dec: Angle.Degrees(-20.56944054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225198"},
        {"Hipparcos Number", "HIP 342"},
        {"Smithsonian Astrophysical Observation", "SAO 166030"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.07898302),
        dec: Angle.Degrees(-20.56874520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156550"},
        {"Hipparcos Number", "HIP 84719"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.76107894),
        dec: Angle.Degrees(-20.56848199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87484"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.12686425),
        dec: Angle.Degrees(-20.56457223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126818"},
        {"Hipparcos Number", "HIP 70765"},
        {"Smithsonian Astrophysical Observation", "SAO 182573"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.07490389),
        dec: Angle.Degrees(-20.56455812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11835"},
        {"Hipparcos Number", "HIP 8988"},
        {"Geneva Identification System", "GEN# +1.00011835"},
        {"Smithsonian Astrophysical Observation", "SAO 167401"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.95459533),
        dec: Angle.Degrees(-20.56278045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100707"},
        {"Hipparcos Number", "HIP 56515"},
        {"Smithsonian Astrophysical Observation", "SAO 180007"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.79871751),
        dec: Angle.Degrees(-20.55779561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126275"},
        {"Hipparcos Number", "HIP 70482"},
        {"Smithsonian Astrophysical Observation", "SAO 182523"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.25002174),
        dec: Angle.Degrees(-20.55769498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46854"},
        {"Hipparcos Number", "HIP 31382"},
        {"Fundamental Katalog 5th Edition", "FK5 4596"},
        {"Smithsonian Astrophysical Observation", "SAO 171973"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.69092652),
        dec: Angle.Degrees(-20.55745090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201352"},
        {"Hipparcos Number", "HIP 104452"},
        {"Geneva Identification System", "GEN# +1.00201352"},
        {"Smithsonian Astrophysical Observation", "SAO 190069"},
        {"Wilson Evans Batten Catalogue", "WEB 19012"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.38718774),
        dec: Angle.Degrees(-20.55633140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19764"},
        {"Hipparcos Number", "HIP 14732"},
        {"Smithsonian Astrophysical Observation", "SAO 168347"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.56792969),
        dec: Angle.Degrees(-20.55566327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67456"},
        {"Hipparcos Number", "HIP 39734"},
        {"Geneva Identification System", "GEN# +1.00067456"},
        {"Renson", "Renson 18640"},
        {"Smithsonian Astrophysical Observation", "SAO 175206"},
        {"Wilson Evans Batten Catalogue", "WEB 7753"},
    },
    visualMagnitude: 5.33,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.82519225),
        dec: Angle.Degrees(-20.55434589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83165"},
        {"Hipparcos Number", "HIP 47102"},
        {"Smithsonian Astrophysical Observation", "SAO 177719"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.99592977),
        dec: Angle.Degrees(-20.55290712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10902"},
        {"Geneva Identification System", "GEN# -0.02100418"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.09100430),
        dec: Angle.Degrees(-20.55237491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185516"},
        {"Hipparcos Number", "HIP 96763"},
        {"Smithsonian Astrophysical Observation", "SAO 188421"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.04128941),
        dec: Angle.Degrees(-20.54776057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31903"},
        {"Hipparcos Number", "HIP 23138"},
        {"Smithsonian Astrophysical Observation", "SAO 169936"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.68647486),
        dec: Angle.Degrees(-20.54748367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77609"},
        {"Hipparcos Number", "HIP 44425"},
        {"Geneva Identification System", "GEN# +1.00077609"},
        {"Renson", "Renson 21960"},
        {"Smithsonian Astrophysical Observation", "SAO 176878"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.77763418),
        dec: Angle.Degrees(-20.54655591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23208"},
        {"Hipparcos Number", "HIP 17338"},
        {"Geneva Identification System", "GEN# +1.00023208"},
        {"Smithsonian Astrophysical Observation", "SAO 168761"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.66584010),
        dec: Angle.Degrees(-20.54551270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87636"},
        {"Hipparcos Number", "HIP 49464"},
        {"Smithsonian Astrophysical Observation", "SAO 178396"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.47560032),
        dec: Angle.Degrees(-20.54528657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69968"},
        {"Hipparcos Number", "HIP 40726"},
        {"Smithsonian Astrophysical Observation", "SAO 175567"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.68584368),
        dec: Angle.Degrees(-20.54520543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167570"},
        {"Henry Draper 2", "HD 167571"},
        {"Hipparcos Number", "HIP 89567"},
        {"Geneva Identification System", "GEN# +1.00167570"},
        {"Smithsonian Astrophysical Observation", "SAO 186575"},
        {"Wilson Evans Batten Catalogue", "WEB 15251"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.14736056),
        dec: Angle.Degrees(-20.54446476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90289",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11325 A"},
        {"Henry Draper", "HD 169420"},
        {"Henry Draper 2", "HD 169421"},
        {"Hipparcos Number", "HIP 90289"},
        {"Geneva Identification System", "GEN# +1.00169420"},
        {"Smithsonian Astrophysical Observation", "SAO 186794"},
        {"Wilson Evans Batten Catalogue", "WEB 15446"},
    },
    visualMagnitude: 4.81,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.33764809),
        dec: Angle.Degrees(-20.54160918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107839",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15371 AB"},
        {"Henry Draper", "HD 207629"},
        {"Hipparcos Number", "HIP 107839"},
        {"Smithsonian Astrophysical Observation", "SAO 190678"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.71159468),
        dec: Angle.Degrees(-20.54083957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22772"},
        {"Geneva Identification System", "GEN# -0.02000958"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.48156597),
        dec: Angle.Degrees(-20.53950233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 240.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16973"},
        {"Hipparcos Number", "HIP 12658"},
        {"Smithsonian Astrophysical Observation", "SAO 167991"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.65805801),
        dec: Angle.Degrees(-20.53833238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13814"},
        {"Hipparcos Number", "HIP 10408"},
        {"Smithsonian Astrophysical Observation", "SAO 167650"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.52253801),
        dec: Angle.Degrees(-20.53534419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190241"},
        {"Hipparcos Number", "HIP 98875"},
        {"Geneva Identification System", "GEN# +1.00190241"},
        {"Smithsonian Astrophysical Observation", "SAO 188886"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.19145060),
        dec: Angle.Degrees(-20.53414517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216769"},
        {"Hipparcos Number", "HIP 113242"},
        {"Smithsonian Astrophysical Observation", "SAO 191504"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.97876345),
        dec: Angle.Degrees(-20.53156081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44261"},
        {"Hipparcos Number", "HIP 30090"},
        {"Smithsonian Astrophysical Observation", "SAO 171581"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.99468731),
        dec: Angle.Degrees(-20.53108215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34013"},
        {"Hipparcos Number", "HIP 24343"},
        {"Smithsonian Astrophysical Observation", "SAO 170204"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.36509505),
        dec: Angle.Degrees(-20.52959086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106582"},
        {"Hipparcos Number", "HIP 59791"},
        {"Smithsonian Astrophysical Observation", "SAO 180614"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.90243002),
        dec: Angle.Degrees(-20.52954382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51898"},
        {"Hipparcos Number", "HIP 33554"},
        {"Celescope Catalog", "CEL 1464"},
        {"Geneva Identification System", "GEN# +1.00051898"},
        {"Smithsonian Astrophysical Observation", "SAO 172659"},
        {"Wilson Evans Batten Catalogue", "WEB 6748"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.59548549),
        dec: Angle.Degrees(-20.52953685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193918"},
        {"Hipparcos Number", "HIP 100563"},
        {"Smithsonian Astrophysical Observation", "SAO 189224"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.87569061),
        dec: Angle.Degrees(-20.52948720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109585"},
        {"Hipparcos Number", "HIP 61496"},
        {"Celescope Catalog", "CEL 4128"},
        {"Geneva Identification System", "GEN# +1.00109585"},
        {"Smithsonian Astrophysical Observation", "SAO 180937"},
        {"Wilson Evans Batten Catalogue", "WEB 10944"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.99488728),
        dec: Angle.Degrees(-20.52735401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23542"},
        {"Hipparcos Number", "HIP 17539"},
        {"Geneva Identification System", "GEN# +1.00023542"},
        {"Renson", "Renson 6043"},
        {"Smithsonian Astrophysical Observation", "SAO 168802"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.33409079),
        dec: Angle.Degrees(-20.52396416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67182"},
        {"Hipparcos Number", "HIP 39647"},
        {"Smithsonian Astrophysical Observation", "SAO 175166"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.53031748),
        dec: Angle.Degrees(-20.52345498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134328"},
        {"Hipparcos Number", "HIP 74203"},
        {"Geneva Identification System", "GEN# +1.00134328"},
        {"Smithsonian Astrophysical Observation", "SAO 183232"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.45314468),
        dec: Angle.Degrees(-20.52034858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75775"},
        {"Hipparcos Number", "HIP 43472"},
        {"Geneva Identification System", "GEN# +1.00075775"},
        {"Smithsonian Astrophysical Observation", "SAO 176586"},
        {"Wilson Evans Batten Catalogue", "WEB 8379"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.82882255),
        dec: Angle.Degrees(-20.51838452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9884"},
        {"Hipparcos Number", "HIP 7461"},
        {"Smithsonian Astrophysical Observation", "SAO 167166"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.03380749),
        dec: Angle.Degrees(-20.51782663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10246"},
        {"Hipparcos Number", "HIP 7754"},
        {"Smithsonian Astrophysical Observation", "SAO 167206"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.96009111),
        dec: Angle.Degrees(-20.51760979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223920"},
        {"Hipparcos Number", "HIP 117813"},
        {"Smithsonian Astrophysical Observation", "SAO 192222"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.41034368),
        dec: Angle.Degrees(-20.51750351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157986"},
        {"Hipparcos Number", "HIP 85426"},
        {"Geneva Identification System", "GEN# +1.00157986"},
        {"Smithsonian Astrophysical Observation", "SAO 185416"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.84507979),
        dec: Angle.Degrees(-20.51701042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219351"},
        {"Hipparcos Number", "HIP 114799"},
        {"Smithsonian Astrophysical Observation", "SAO 191759"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.82338378),
        dec: Angle.Degrees(-20.51466853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96874"},
        {"Hipparcos Number", "HIP 54505"},
        {"Smithsonian Astrophysical Observation", "SAO 179584"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.27184807),
        dec: Angle.Degrees(-20.51355590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2337"},
        {"Hipparcos Number", "HIP 2134"},
        {"Geneva Identification System", "GEN# +1.00002337"},
        {"Smithsonian Astrophysical Observation", "SAO 166278"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.76673773),
        dec: Angle.Degrees(-20.51329182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7399"},
        {"Hipparcos Number", "HIP 5750"},
        {"Geneva Identification System", "GEN# +1.00007399"},
        {"Smithsonian Astrophysical Observation", "SAO 166885"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.46396751),
        dec: Angle.Degrees(-20.51327886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130359"},
        {"Hipparcos Number", "HIP 72405"},
        {"Smithsonian Astrophysical Observation", "SAO 182887"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.07558789),
        dec: Angle.Degrees(-20.51268100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25944"},
        {"Hipparcos Number", "HIP 19111"},
        {"Geneva Identification System", "GEN# +1.00025944"},
        {"Smithsonian Astrophysical Observation", "SAO 169111"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.44469987),
        dec: Angle.Degrees(-20.51253638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207462"},
        {"Hipparcos Number", "HIP 107748"},
        {"Smithsonian Astrophysical Observation", "SAO 190658"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.41457041),
        dec: Angle.Degrees(-20.50788245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57890"},
        {"Hipparcos Number", "HIP 35746"},
        {"Geneva Identification System", "GEN# +1.00057890"},
        {"Smithsonian Astrophysical Observation", "SAO 173565"},
        {"Wilson Evans Batten Catalogue", "WEB 7124"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.59622798),
        dec: Angle.Degrees(-20.50667155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25574"},
        {"Hipparcos Number", "HIP 18882"},
        {"Smithsonian Astrophysical Observation", "SAO 169061"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.72448791),
        dec: Angle.Degrees(-20.50614466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42414"},
        {"Hipparcos Number", "HIP 29229"},
        {"Smithsonian Astrophysical Observation", "SAO 171316"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.44285482),
        dec: Angle.Degrees(-20.50500631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25610"},
        {"Hipparcos Number", "HIP 18905"},
        {"Smithsonian Astrophysical Observation", "SAO 169066"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.78516431),
        dec: Angle.Degrees(-20.50411399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200995"},
        {"Hipparcos Number", "HIP 104261"},
        {"Geneva Identification System", "GEN# +1.00200995"},
        {"Smithsonian Astrophysical Observation", "SAO 190029"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.83246618),
        dec: Angle.Degrees(-20.49986037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42777"},
        {"Hipparcos Number", "HIP 29410"},
        {"Renson", "Renson 11450"},
        {"Smithsonian Astrophysical Observation", "SAO 171365"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.95454602),
        dec: Angle.Degrees(-20.49984477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211519"},
        {"Hipparcos Number", "HIP 110085"},
        {"Smithsonian Astrophysical Observation", "SAO 191031"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.50020680),
        dec: Angle.Degrees(-20.49958971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67816"},
        {"Hipparcos Number", "HIP 39908"},
        {"Geneva Identification System", "GEN# +1.00067816"},
        {"Smithsonian Astrophysical Observation", "SAO 175262"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.26171193),
        dec: Angle.Degrees(-20.49942141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156542"},
        {"Hipparcos Number", "HIP 84703"},
        {"Geneva Identification System", "GEN# +1.00156542"},
        {"Smithsonian Astrophysical Observation", "SAO 185258"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.71829168),
        dec: Angle.Degrees(-20.49925289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172404"},
        {"Hipparcos Number", "HIP 91602"},
        {"Smithsonian Astrophysical Observation", "SAO 187124"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.21889528),
        dec: Angle.Degrees(-20.49628552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99837",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13571 AB"},
        {"Henry Draper", "HD 192391"},
        {"Hipparcos Number", "HIP 99837"},
        {"Smithsonian Astrophysical Observation", "SAO 189072"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.84659919),
        dec: Angle.Degrees(-20.49543200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154204"},
        {"Hipparcos Number", "HIP 83567"},
        {"Geneva Identification System", "GEN# +1.00154204"},
        {"Smithsonian Astrophysical Observation", "SAO 184999"},
        {"Wilson Evans Batten Catalogue", "WEB 14128"},
    },
    visualMagnitude: 6.29,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.18887255),
        dec: Angle.Degrees(-20.49464339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50708"},
        {"Hipparcos Number", "HIP 33095"},
        {"Geneva Identification System", "GEN# +1.00050708"},
        {"Renson", "Renson 13926"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.40093488),
        dec: Angle.Degrees(-20.49379164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191391"},
        {"Hipparcos Number", "HIP 99385"},
        {"Geneva Identification System", "GEN# +1.00191391"},
        {"Smithsonian Astrophysical Observation", "SAO 188984"},
        {"Wilson Evans Batten Catalogue", "WEB 17738"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.58275051),
        dec: Angle.Degrees(-20.49251554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -457.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -376.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188450"},
        {"Hipparcos Number", "HIP 98084"},
        {"Smithsonian Astrophysical Observation", "SAO 188726"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.00492924),
        dec: Angle.Degrees(-20.49190112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66247"},
        {"Hipparcos Number", "HIP 39277"},
        {"Smithsonian Astrophysical Observation", "SAO 175012"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.47337213),
        dec: Angle.Degrees(-20.49157663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8866"},
        {"Hipparcos Number", "HIP 6769"},
        {"Smithsonian Astrophysical Observation", "SAO 167049"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.76373443),
        dec: Angle.Degrees(-20.49152743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131900"},
        {"Hipparcos Number", "HIP 73139"},
        {"Geneva Identification System", "GEN# +1.00131900"},
        {"Smithsonian Astrophysical Observation", "SAO 183024"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.20281340),
        dec: Angle.Degrees(-20.48984875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113309"},
        {"Hipparcos Number", "HIP 63673"},
        {"Geneva Identification System", "GEN# +1.00113309"},
        {"Smithsonian Astrophysical Observation", "SAO 181342"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.73982697),
        dec: Angle.Degrees(-20.48963164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112650"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.22382996),
        dec: Angle.Degrees(-20.48394431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129714"},
        {"Hipparcos Number", "HIP 72080"},
        {"Smithsonian Astrophysical Observation", "SAO 182834"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.17923688),
        dec: Angle.Degrees(-20.48207432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188600"},
        {"Hipparcos Number", "HIP 98140"},
        {"Smithsonian Astrophysical Observation", "SAO 188740"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.17788636),
        dec: Angle.Degrees(-20.47723891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17461"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.13366011),
        dec: Angle.Degrees(-20.47552754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 260.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25459"},
        {"Hipparcos Number", "HIP 18813"},
        {"Geneva Identification System", "GEN# +1.00025459"},
        {"Smithsonian Astrophysical Observation", "SAO 169045"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.46690086),
        dec: Angle.Degrees(-20.47507388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199751"},
        {"Hipparcos Number", "HIP 103626"},
        {"Smithsonian Astrophysical Observation", "SAO 189908"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.93924409),
        dec: Angle.Degrees(-20.47193322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78622"},
        {"Smithsonian Astrophysical Observation", "SAO 184063"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.76306146),
        dec: Angle.Degrees(-20.47130013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8103"},
        {"Hipparcos Number", "HIP 6243"},
        {"Smithsonian Astrophysical Observation", "SAO 166967"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.02187602),
        dec: Angle.Degrees(-20.47089282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140990"},
        {"Hipparcos Number", "HIP 77338"},
        {"Geneva Identification System", "GEN# +1.00140990"},
        {"Smithsonian Astrophysical Observation", "SAO 183790"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.83468653),
        dec: Angle.Degrees(-20.46914766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22631"},
        {"Hipparcos Number", "HIP 16916"},
        {"Smithsonian Astrophysical Observation", "SAO 168688"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.43370706),
        dec: Angle.Degrees(-20.46756900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16919"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.43726870),
        dec: Angle.Degrees(-20.46738810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62371"},
        {"Hipparcos Number", "HIP 37588"},
        {"Smithsonian Astrophysical Observation", "SAO 174351"},
    },
    visualMagnitude: 8.88,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.70040189),
        dec: Angle.Degrees(-20.46680638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224191"},
        {"Hipparcos Number", "HIP 117989"},
        {"Geneva Identification System", "GEN# +1.00224191"},
        {"Smithsonian Astrophysical Observation", "SAO 192247"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.99164552),
        dec: Angle.Degrees(-20.46625766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109570"},
        {"Hipparcos Number", "HIP 61476"},
        {"Geneva Identification System", "GEN# +1.00109570"},
        {"Smithsonian Astrophysical Observation", "SAO 180934"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.95543238),
        dec: Angle.Degrees(-20.46580488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -259.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28559"},
        {"Hipparcos Number", "HIP 20940"},
        {"Smithsonian Astrophysical Observation", "SAO 169497"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.34462122),
        dec: Angle.Degrees(-20.46559814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100378"},
    },
    visualMagnitude: 10.41,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.36044476),
        dec: Angle.Degrees(-20.46549740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222507"},
        {"Hipparcos Number", "HIP 116868"},
        {"Geneva Identification System", "GEN# +1.00222507"},
        {"Smithsonian Astrophysical Observation", "SAO 192086"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.32748534),
        dec: Angle.Degrees(-20.46467806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56748"},
        {"Hipparcos Number", "HIP 35289"},
        {"Renson", "Renson 15470"},
        {"Smithsonian Astrophysical Observation", "SAO 173390"},
    },
    visualMagnitude: 8.86,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.36147950),
        dec: Angle.Degrees(-20.46360357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65102"},
        {"Hipparcos Number", "HIP 38789"},
        {"Fundamental Katalog 5th Edition", "FK5 4714"},
        {"Smithsonian Astrophysical Observation", "SAO 174836"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.09047757),
        dec: Angle.Degrees(-20.46324858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24672"},
        {"Hipparcos Number", "HIP 18281"},
        {"Geneva Identification System", "GEN# +1.00024672"},
        {"Smithsonian Astrophysical Observation", "SAO 168936"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.64833892),
        dec: Angle.Degrees(-20.46105315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177095"},
        {"Hipparcos Number", "HIP 93623"},
        {"Cincinnati Publication", "Ci 20 1124"},
        {"Geneva Identification System", "GEN# +1.00177095"},
        {"Smithsonian Astrophysical Observation", "SAO 187628"},
        {"Wilson Evans Batten Catalogue", "WEB 16262"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.98688466),
        dec: Angle.Degrees(-20.45873287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -227.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -586.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7257"},
        {"Hipparcos Number", "HIP 5651"},
        {"Geneva Identification System", "GEN# +1.00007257"},
        {"Smithsonian Astrophysical Observation", "SAO 166876"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.14294348),
        dec: Angle.Degrees(-20.45855126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16526"},
        {"Hipparcos Number", "HIP 12313"},
        {"Smithsonian Astrophysical Observation", "SAO 167939"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.63927126),
        dec: Angle.Degrees(-20.45613287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151593"},
        {"Hipparcos Number", "HIP 82306"},
        {"Fundamental Katalog 5th Edition", "FK5 5484"},
        {"Smithsonian Astrophysical Observation", "SAO 184666"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.25605941),
        dec: Angle.Degrees(-20.45598336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90515"},
        {"Hipparcos Number", "HIP 51118"},
        {"Smithsonian Astrophysical Observation", "SAO 178822"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.65655785),
        dec: Angle.Degrees(-20.45370153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98712"},
        {"Hipparcos Number", "HIP 55454"},
        {"Geneva Identification System", "GEN# +1.00098712"},
        {"Smithsonian Astrophysical Observation", "SAO 179801"},
        {"Wilson Evans Batten Catalogue", "WEB 9976"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.36063915),
        dec: Angle.Degrees(-20.45350329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78420",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9871 AB"},
        {"Henry Draper", "HD 143335"},
        {"Hipparcos Number", "HIP 78420"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.14555509),
        dec: Angle.Degrees(-20.45095227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97573"},
        {"Hipparcos Number", "HIP 54838"},
        {"Smithsonian Astrophysical Observation", "SAO 179657"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.40323361),
        dec: Angle.Degrees(-20.45043398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144253"},
        {"Hipparcos Number", "HIP 78843"},
        {"Geneva Identification System", "GEN# +1.00144253"},
        {"Smithsonian Astrophysical Observation", "SAO 184105"},
        {"Wilson Evans Batten Catalogue", "WEB 13329"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.41786099),
        dec: Angle.Degrees(-20.44918647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 296.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -359.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65811"},
        {"Hipparcos Number", "HIP 39090"},
        {"Smithsonian Astrophysical Observation", "SAO 174948"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.95363395),
        dec: Angle.Degrees(-20.44847167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205290"},
        {"Hipparcos Number", "HIP 106561"},
        {"Smithsonian Astrophysical Observation", "SAO 190462"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.71643868),
        dec: Angle.Degrees(-20.44525906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199683"},
        {"Hipparcos Number", "HIP 103595"},
        {"Geneva Identification System", "GEN# +1.00199683"},
        {"Smithsonian Astrophysical Observation", "SAO 189903"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.85113182),
        dec: Angle.Degrees(-20.44436574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223417"},
        {"Hipparcos Number", "HIP 117489"},
        {"Smithsonian Astrophysical Observation", "SAO 192177"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.35939355),
        dec: Angle.Degrees(-20.44279082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84608"},
        {"Hipparcos Number", "HIP 47915"},
        {"Smithsonian Astrophysical Observation", "SAO 177949"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.49162018),
        dec: Angle.Degrees(-20.43973513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127964"},
        {"Hipparcos Number", "HIP 71295"},
        {"Fundamental Katalog 5th Edition", "FK5 5293"},
        {"Geneva Identification System", "GEN# +1.00127964"},
        {"Smithsonian Astrophysical Observation", "SAO 182676"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.71132791),
        dec: Angle.Degrees(-20.43937760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138992"},
        {"Hipparcos Number", "HIP 76393"},
        {"Smithsonian Astrophysical Observation", "SAO 183609"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.03663841),
        dec: Angle.Degrees(-20.43798740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26643",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4260 B"},
        {"Hipparcos Number", "HIP 26643"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.93901096),
        dec: Angle.Degrees(-20.43686551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153609"},
        {"Hipparcos Number", "HIP 83286"},
        {"Geneva Identification System", "GEN# +1.00153609"},
        {"Smithsonian Astrophysical Observation", "SAO 184922"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.31201849),
        dec: Angle.Degrees(-20.43664939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26642",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4260 A"},
        {"Henry Draper", "HD 37702"},
        {"Hipparcos Number", "HIP 26642"},
        {"Smithsonian Astrophysical Observation", "SAO 170652"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.93630039),
        dec: Angle.Degrees(-20.43520169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82045"},
        {"Hipparcos Number", "HIP 46498"},
        {"Smithsonian Astrophysical Observation", "SAO 177513"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.24834896),
        dec: Angle.Degrees(-20.43497784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55834"},
        {"Hipparcos Number", "HIP 34941"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.45371587),
        dec: Angle.Degrees(-20.43414102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8973"},
        {"Hipparcos Number", "HIP 6843"},
        {"Geneva Identification System", "GEN# +1.00008973"},
        {"Smithsonian Astrophysical Observation", "SAO 167063"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.01118910),
        dec: Angle.Degrees(-20.43359589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205706"},
        {"Hipparcos Number", "HIP 106764"},
        {"Smithsonian Astrophysical Observation", "SAO 190504"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.40060097),
        dec: Angle.Degrees(-20.43182455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142686"},
        {"Hipparcos Number", "HIP 78082"},
        {"Geneva Identification System", "GEN# +1.00142686"},
        {"Smithsonian Astrophysical Observation", "SAO 183955"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.15523823),
        dec: Angle.Degrees(-20.43046575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76177"},
        {"Hipparcos Number", "HIP 43690"},
        {"Geneva Identification System", "GEN# +1.00076177"},
        {"Smithsonian Astrophysical Observation", "SAO 176657"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.48616918),
        dec: Angle.Degrees(-20.42997063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30627"},
        {"Hipparcos Number", "HIP 22333"},
        {"Smithsonian Astrophysical Observation", "SAO 169781"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.14820724),
        dec: Angle.Degrees(-20.42942813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65412"},
        {"Hipparcos Number", "HIP 38923"},
        {"Smithsonian Astrophysical Observation", "SAO 174884"},
    },
    visualMagnitude: 7.28,
    bvColour: 2.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.47537366),
        dec: Angle.Degrees(-20.42869355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74930"},
        {"Hipparcos Number", "HIP 43054"},
        {"Geneva Identification System", "GEN# +1.00074930"},
        {"Smithsonian Astrophysical Observation", "SAO 176445"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.57317581),
        dec: Angle.Degrees(-20.42789893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16649"},
        {"Hipparcos Number", "HIP 12399"},
        {"Geneva Identification System", "GEN# +1.00016649"},
        {"Smithsonian Astrophysical Observation", "SAO 167957"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.91442375),
        dec: Angle.Degrees(-20.42761015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181007"},
        {"Hipparcos Number", "HIP 94964"},
        {"Geneva Identification System", "GEN# +1.00181007"},
        {"Smithsonian Astrophysical Observation", "SAO 187970"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.86879037),
        dec: Angle.Degrees(-20.42725898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24109"},
        {"Hipparcos Number", "HIP 17906"},
        {"Smithsonian Astrophysical Observation", "SAO 168866"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.43984863),
        dec: Angle.Degrees(-20.42686698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49683"},
        {"Hipparcos Number", "HIP 32671"},
        {"Smithsonian Astrophysical Observation", "SAO 172360"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.21080129),
        dec: Angle.Degrees(-20.42561958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165593"},
        {"Hipparcos Number", "HIP 88796"},
        {"Smithsonian Astrophysical Observation", "SAO 186316"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.89247382),
        dec: Angle.Degrees(-20.42531006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105862",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14968 ABC"},
        {"Henry Draper", "HD 204043"},
        {"Hipparcos Number", "HIP 105862"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.60942009),
        dec: Angle.Degrees(-20.42475685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155291"},
        {"Hipparcos Number", "HIP 84078"},
        {"Geneva Identification System", "GEN# +1.00155291"},
        {"Smithsonian Astrophysical Observation", "SAO 185122"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.84163334),
        dec: Angle.Degrees(-20.42466537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87130"},
        {"Hipparcos Number", "HIP 49209"},
        {"Geneva Identification System", "GEN# +1.00087130"},
        {"Smithsonian Astrophysical Observation", "SAO 178336"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.65428341),
        dec: Angle.Degrees(-20.42395869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93118",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11872 A"},
        {"Henry Draper", "HD 175876"},
        {"Hipparcos Number", "HIP 93118"},
        {"Fundamental Katalog 5th Edition", "FK5 5673"},
        {"Geneva Identification System", "GEN# +1.00175876A"},
        {"Smithsonian Astrophysical Observation", "SAO 187514"},
        {"Wilson Evans Batten Catalogue", "WEB 16130"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.54484488),
        dec: Angle.Degrees(-20.42374784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166546"},
        {"Hipparcos Number", "HIP 89177"},
        {"Geneva Identification System", "GEN# +1.00166546"},
        {"Smithsonian Astrophysical Observation", "SAO 186450"},
        {"Wilson Evans Batten Catalogue", "WEB 15150"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.98791051),
        dec: Angle.Degrees(-20.42337143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179409"},
        {"Hipparcos Number", "HIP 94429"},
        {"Geneva Identification System", "GEN# +1.00179409"},
        {"Smithsonian Astrophysical Observation", "SAO 187837"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.28796455),
        dec: Angle.Degrees(-20.42184333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45535"},
        {"Hipparcos Number", "HIP 30713"},
        {"Smithsonian Astrophysical Observation", "SAO 171767"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.80051265),
        dec: Angle.Degrees(-20.42086886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1271"},
        {"Smithsonian Astrophysical Observation", "SAO 166156"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.98448594),
        dec: Angle.Degrees(-20.41616797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152311"},
        {"Hipparcos Number", "HIP 82621"},
        {"Geneva Identification System", "GEN# +1.00152311"},
        {"Smithsonian Astrophysical Observation", "SAO 184754"},
        {"Wilson Evans Batten Catalogue", "WEB 13950"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.35523754),
        dec: Angle.Degrees(-20.41548861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133569"},
        {"Hipparcos Number", "HIP 73867"},
        {"Smithsonian Astrophysical Observation", "SAO 183166"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.45295425),
        dec: Angle.Degrees(-20.41525268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102060"},
        {"Hipparcos Number", "HIP 57267"},
        {"Smithsonian Astrophysical Observation", "SAO 180154"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.15469967),
        dec: Angle.Degrees(-20.41525075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23954"},
        {"Hipparcos Number", "HIP 17783"},
        {"Smithsonian Astrophysical Observation", "SAO 168845"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.09839071),
        dec: Angle.Degrees(-20.41277657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209520"},
        {"Hipparcos Number", "HIP 108955"},
        {"Geneva Identification System", "GEN# +1.00209520"},
        {"Smithsonian Astrophysical Observation", "SAO 190861"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.10684839),
        dec: Angle.Degrees(-20.41208804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96276"},
        {"Hipparcos Number", "HIP 54242"},
        {"Geneva Identification System", "GEN# +1.00096276"},
        {"Smithsonian Astrophysical Observation", "SAO 179520"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.46126092),
        dec: Angle.Degrees(-20.40898249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213055"},
        {"Hipparcos Number", "HIP 110982"},
        {"Smithsonian Astrophysical Observation", "SAO 191172"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.27671081),
        dec: Angle.Degrees(-20.40887744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150259"},
        {"Hipparcos Number", "HIP 81632"},
        {"Geneva Identification System", "GEN# +1.00150259"},
        {"Smithsonian Astrophysical Observation", "SAO 184541"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.14378360),
        dec: Angle.Degrees(-20.40871834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163061"},
        {"Hipparcos Number", "HIP 87714"},
        {"Geneva Identification System", "GEN# +1.00163061"},
        {"Smithsonian Astrophysical Observation", "SAO 185935"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.75656394),
        dec: Angle.Degrees(-20.40606792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33248",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5585 A"},
        {"Henry Draper", "HD 51055"},
        {"Hipparcos Number", "HIP 33248"},
        {"Geneva Identification System", "GEN# +1.00051055J"},
        {"Smithsonian Astrophysical Observation", "SAO 172569"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.76140934),
        dec: Angle.Degrees(-20.40485094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100478"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.63902230),
        dec: Angle.Degrees(-20.40282930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58763"},
        {"Hipparcos Number", "HIP 36098"},
        {"Smithsonian Astrophysical Observation", "SAO 173722"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.54848918),
        dec: Angle.Degrees(-20.40268008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17224"},
        {"Hipparcos Number", "HIP 12858"},
        {"Smithsonian Astrophysical Observation", "SAO 168025"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.32659436),
        dec: Angle.Degrees(-20.40165435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183840"},
        {"Hipparcos Number", "HIP 96086"},
        {"Geneva Identification System", "GEN# +1.00183840"},
        {"Smithsonian Astrophysical Observation", "SAO 188250"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.02841012),
        dec: Angle.Degrees(-20.40033338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145294"},
        {"Hipparcos Number", "HIP 79293"},
        {"Smithsonian Astrophysical Observation", "SAO 184199"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.73975231),
        dec: Angle.Degrees(-20.39896927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36050"},
        {"Hipparcos Number", "HIP 25596"},
        {"Smithsonian Astrophysical Observation", "SAO 170456"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.04459860),
        dec: Angle.Degrees(-20.39706345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141179"},
        {"Hipparcos Number", "HIP 77428"},
        {"Smithsonian Astrophysical Observation", "SAO 183812"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.09504106),
        dec: Angle.Degrees(-20.39539974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30524"},
        {"Hipparcos Number", "HIP 22269"},
        {"Smithsonian Astrophysical Observation", "SAO 169773"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.92202814),
        dec: Angle.Degrees(-20.39358452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51836"},
        {"Smithsonian Astrophysical Observation", "SAO 179004"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.85384952),
        dec: Angle.Degrees(-20.39308182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46932"},
        {"Hipparcos Number", "HIP 31445"},
        {"Smithsonian Astrophysical Observation", "SAO 171988"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.81517485),
        dec: Angle.Degrees(-20.39228215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116003"},
        {"Geneva Identification System", "GEN# +9.80273059"},
    },
    visualMagnitude: 11.09,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.55517617),
        dec: Angle.Degrees(-20.39046404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 314.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31391"},
        {"Hipparcos Number", "HIP 22835"},
        {"Smithsonian Astrophysical Observation", "SAO 169878"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.70224630),
        dec: Angle.Degrees(-20.38950101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154036"},
        {"Hipparcos Number", "HIP 83486"},
        {"Smithsonian Astrophysical Observation", "SAO 184976"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.94496996),
        dec: Angle.Degrees(-20.38893961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136458"},
        {"Hipparcos Number", "HIP 75144"},
        {"Geneva Identification System", "GEN# +1.00136458"},
        {"Smithsonian Astrophysical Observation", "SAO 183401"},
        {"Wilson Evans Batten Catalogue", "WEB 12819"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.34995347),
        dec: Angle.Degrees(-20.38840785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89440",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11191 A"},
        {"Henry Draper", "HD 167263"},
        {"Hipparcos Number", "HIP 89440"},
        {"Geneva Identification System", "GEN# +1.00167263J"},
        {"Smithsonian Astrophysical Observation", "SAO 186544"},
        {"Wilson Evans Batten Catalogue", "WEB 15214"},
    },
    visualMagnitude: 5.96,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.80403819),
        dec: Angle.Degrees(-20.38796936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25803"},
        {"Hipparcos Number", "HIP 19037"},
        {"Geneva Identification System", "GEN# +1.00025803"},
        {"Smithsonian Astrophysical Observation", "SAO 169095"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.17038255),
        dec: Angle.Degrees(-20.38183041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179086"},
        {"Hipparcos Number", "HIP 94320"},
        {"Smithsonian Astrophysical Observation", "SAO 187799"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.96745619),
        dec: Angle.Degrees(-20.38088780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214304"},
        {"Hipparcos Number", "HIP 111684"},
        {"Renson", "Renson 59366"},
        {"Smithsonian Astrophysical Observation", "SAO 191273"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.37428147),
        dec: Angle.Degrees(-20.37810717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28346"},
        {"Hipparcos Number", "HIP 20798"},
        {"Geneva Identification System", "GEN# +1.00028346"},
        {"Smithsonian Astrophysical Observation", "SAO 169463"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.85010491),
        dec: Angle.Degrees(-20.37272578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80316"},
        {"Hipparcos Number", "HIP 45658"},
        {"Geneva Identification System", "GEN# +1.00080316"},
        {"Renson", "Renson 22850"},
        {"Smithsonian Astrophysical Observation", "SAO 177244"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.60416027),
        dec: Angle.Degrees(-20.37105767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22215"},
        {"Hipparcos Number", "HIP 16629"},
        {"Smithsonian Astrophysical Observation", "SAO 168637"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.49210517),
        dec: Angle.Degrees(-20.36997827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171077"},
        {"Hipparcos Number", "HIP 90978"},
        {"Smithsonian Astrophysical Observation", "SAO 186969"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.37050496),
        dec: Angle.Degrees(-20.36828703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21979"},
        {"Hipparcos Number", "HIP 16451"},
        {"Geneva Identification System", "GEN# +1.00021979"},
        {"Smithsonian Astrophysical Observation", "SAO 168611"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.97666118),
        dec: Angle.Degrees(-20.36793258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23085"},
        {"Hipparcos Number", "HIP 17247"},
        {"Smithsonian Astrophysical Observation", "SAO 168744"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.40447452),
        dec: Angle.Degrees(-20.36764497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187989"},
        {"Hipparcos Number", "HIP 97899"},
        {"Smithsonian Astrophysical Observation", "SAO 188682"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.43148546),
        dec: Angle.Degrees(-20.36732942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84257"},
        {"Hipparcos Number", "HIP 47698"},
        {"Fundamental Katalog 5th Edition", "FK5 2779"},
        {"Smithsonian Astrophysical Observation", "SAO 177893"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.87759335),
        dec: Angle.Degrees(-20.36582051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111547"},
        {"Hipparcos Number", "HIP 62642"},
        {"Geneva Identification System", "GEN# +1.00111547"},
        {"Smithsonian Astrophysical Observation", "SAO 181142"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.54567555),
        dec: Angle.Degrees(-20.36562745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10369"},
        {"Hipparcos Number", "HIP 7838"},
        {"Smithsonian Astrophysical Observation", "SAO 167220"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.20974353),
        dec: Angle.Degrees(-20.36505139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158152"},
        {"Hipparcos Number", "HIP 85502"},
        {"Smithsonian Astrophysical Observation", "SAO 185432"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.09917059),
        dec: Angle.Degrees(-20.36385751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182887"},
        {"Hipparcos Number", "HIP 95668"},
        {"Renson", "Renson 50557"},
        {"Smithsonian Astrophysical Observation", "SAO 188147"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.89501557),
        dec: Angle.Degrees(-20.36337428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67751"},
        {"Hipparcos Number", "HIP 39876"},
        {"Geneva Identification System", "GEN# +1.00067751"},
        {"Renson", "Renson 18690"},
        {"Smithsonian Astrophysical Observation", "SAO 175250"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.18159545),
        dec: Angle.Degrees(-20.36317828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4049"},
        {"Hipparcos Number", "HIP 3359"},
        {"Smithsonian Astrophysical Observation", "SAO 166505"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.69153323),
        dec: Angle.Degrees(-20.36008452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86626"},
        {"Hipparcos Number", "HIP 48964"},
        {"Fundamental Katalog 5th Edition", "FK5 2804"},
        {"Smithsonian Astrophysical Observation", "SAO 178276"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.82804249),
        dec: Angle.Degrees(-20.35677015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26591"},
        {"Hipparcos Number", "HIP 19571"},
        {"Fundamental Katalog 5th Edition", "FK5 2302"},
        {"Geneva Identification System", "GEN# +1.00026591"},
        {"Renson", "Renson 6790"},
        {"Smithsonian Astrophysical Observation", "SAO 169206"},
        {"Wilson Evans Batten Catalogue", "WEB 3746"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.90073099),
        dec: Angle.Degrees(-20.35627812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73039"},
        {"Hipparcos Number", "HIP 42148"},
        {"Smithsonian Astrophysical Observation", "SAO 176127"},
        {"Wilson Evans Batten Catalogue", "WEB 8101"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.87100863),
        dec: Angle.Degrees(-20.35408768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57361"},
    },
    visualMagnitude: 11.79,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.39308155),
        dec: Angle.Degrees(-20.35362627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103292"},
        {"Hipparcos Number", "HIP 57986"},
        {"Smithsonian Astrophysical Observation", "SAO 180274"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.40899321),
        dec: Angle.Degrees(-20.35335970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104067"},
        {"Hipparcos Number", "HIP 58451"},
        {"Geneva Identification System", "GEN# +1.00104067"},
        {"Smithsonian Astrophysical Observation", "SAO 180353"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.79133711),
        dec: Angle.Degrees(-20.35275134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -423.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11016"},
        {"Smithsonian Astrophysical Observation", "SAO 167729"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.46527743),
        dec: Angle.Degrees(-20.35220891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29306",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4784 AB"},
        {"Henry Draper", "HD 42566"},
        {"Hipparcos Number", "HIP 29306"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.66950439),
        dec: Angle.Degrees(-20.35191846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8895"},
        {"Hipparcos Number", "HIP 6791"},
        {"Geneva Identification System", "GEN# +1.00008895"},
        {"Smithsonian Astrophysical Observation", "SAO 167056"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.85479335),
        dec: Angle.Degrees(-20.35186146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30105"},
        {"Hipparcos Number", "HIP 22001"},
        {"Geneva Identification System", "GEN# +1.00030105"},
        {"Smithsonian Astrophysical Observation", "SAO 169702"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.94601676),
        dec: Angle.Degrees(-20.35182067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139346"},
        {"Hipparcos Number", "HIP 76576"},
        {"Smithsonian Astrophysical Observation", "SAO 183648"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.57738550),
        dec: Angle.Degrees(-20.34880086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76453"},
        {"Smithsonian Astrophysical Observation", "SAO 183618"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.21121090),
        dec: Angle.Degrees(-20.34781972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178929"},
        {"Hipparcos Number", "HIP 94274"},
        {"Renson", "Renson 49744"},
        {"Smithsonian Astrophysical Observation", "SAO 187789"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.83022524),
        dec: Angle.Degrees(-20.34722571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39172"},
        {"Hipparcos Number", "HIP 27539"},
        {"Smithsonian Astrophysical Observation", "SAO 170891"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.48343145),
        dec: Angle.Degrees(-20.34335376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102677"},
        {"Hipparcos Number", "HIP 57645"},
        {"Geneva Identification System", "GEN# +1.00102677"},
        {"Smithsonian Astrophysical Observation", "SAO 180214"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.30532272),
        dec: Angle.Degrees(-20.34302704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47866",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7509 AB"},
        {"Henry Draper", "HD 84517"},
        {"Hipparcos Number", "HIP 47866"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.33654478),
        dec: Angle.Degrees(-20.34017393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93589"},
        {"Hipparcos Number", "HIP 52814"},
        {"Geneva Identification System", "GEN# +1.00093589"},
        {"Smithsonian Astrophysical Observation", "SAO 179232"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.97267291),
        dec: Angle.Degrees(-20.33962057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164028"},
        {"Hipparcos Number", "HIP 88125"},
        {"Geneva Identification System", "GEN# +1.00164028"},
        {"Smithsonian Astrophysical Observation", "SAO 186070"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.00033368),
        dec: Angle.Degrees(-20.33949167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4259"},
        {"Hipparcos Number", "HIP 3515"},
        {"Geneva Identification System", "GEN# +1.00004259"},
        {"Smithsonian Astrophysical Observation", "SAO 166530"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.21614924),
        dec: Angle.Degrees(-20.33668373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15910"},
        {"Hipparcos Number", "HIP 11844"},
        {"Geneva Identification System", "GEN# +1.00015910"},
    },
    visualMagnitude: 10.10,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.22699818),
        dec: Angle.Degrees(-20.33666713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202725"},
        {"Hipparcos Number", "HIP 105181"},
        {"Smithsonian Astrophysical Observation", "SAO 190214"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.60896063),
        dec: Angle.Degrees(-20.33541234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25343"},
        {"Hipparcos Number", "HIP 18745"},
        {"Geneva Identification System", "GEN# +1.00025343"},
        {"Smithsonian Astrophysical Observation", "SAO 169028"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.22455202),
        dec: Angle.Degrees(-20.33481627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2475"},
        {"Hipparcos Number", "HIP 2237"},
        {"Fundamental Katalog 5th Edition", "FK5 2029"},
        {"Geneva Identification System", "GEN# +1.00002475J"},
        {"Smithsonian Astrophysical Observation", "SAO 166296"},
        {"Wilson Evans Batten Catalogue", "WEB 416"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.08820670),
        dec: Angle.Degrees(-20.33477667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67290"},
        {"Hipparcos Number", "HIP 39676"},
        {"Geneva Identification System", "GEN# +1.00067290"},
        {"Smithsonian Astrophysical Observation", "SAO 175178"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.62902857),
        dec: Angle.Degrees(-20.33437047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21305"},
        {"Hipparcos Number", "HIP 15967"},
        {"Geneva Identification System", "GEN# +1.00021305"},
    },
    visualMagnitude: 10.35,
    bvColour: -0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.39971096),
        dec: Angle.Degrees(-20.33432546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201721"},
        {"Hipparcos Number", "HIP 104665"},
        {"Geneva Identification System", "GEN# +1.00201721"},
        {"Smithsonian Astrophysical Observation", "SAO 190114"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.01204159),
        dec: Angle.Degrees(-20.33298241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35549"},
        {"Geneva Identification System", "GEN# +6.10180720"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.02983262),
        dec: Angle.Degrees(-20.33286140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25189"},
        {"Hipparcos Number", "HIP 18641"},
        {"Geneva Identification System", "GEN# +1.00025189"},
        {"Smithsonian Astrophysical Observation", "SAO 169008"},
        {"Wilson Evans Batten Catalogue", "WEB 3590"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.85547756),
        dec: Angle.Degrees(-20.33281831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90390"},
        {"Hipparcos Number", "HIP 51052"},
        {"Smithsonian Astrophysical Observation", "SAO 178806"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.46272702),
        dec: Angle.Degrees(-20.32533991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75055"},
        {"Hipparcos Number", "HIP 43132"},
        {"Smithsonian Astrophysical Observation", "SAO 176464"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.78843285),
        dec: Angle.Degrees(-20.32481287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92390",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11713 A"},
        {"Henry Draper", "HD 174116"},
        {"Hipparcos Number", "HIP 92390"},
        {"Geneva Identification System", "GEN# +1.00174116"},
        {"Smithsonian Astrophysical Observation", "SAO 187324"},
        {"Wilson Evans Batten Catalogue", "WEB 15954"},
    },
    visualMagnitude: 5.22,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.41711408),
        dec: Angle.Degrees(-20.32474038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20911"},
        {"Hipparcos Number", "HIP 15660"},
        {"Smithsonian Astrophysical Observation", "SAO 168485"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.42461696),
        dec: Angle.Degrees(-20.32461508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53063"},
        {"Hipparcos Number", "HIP 33964"},
        {"Celescope Catalog", "CEL 1528"},
        {"Geneva Identification System", "GEN# +1.00053063J"},
        {"Smithsonian Astrophysical Observation", "SAO 172834"},
    },
    visualMagnitude: 9.45,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.70815470),
        dec: Angle.Degrees(-20.32429415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8461"},
        {"Hipparcos Number", "HIP 6491"},
        {"Geneva Identification System", "GEN# +1.00008461"},
        {"Smithsonian Astrophysical Observation", "SAO 167007"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.85119844),
        dec: Angle.Degrees(-20.31993172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224482"},
        {"Hipparcos Number", "HIP 118181"},
        {"Geneva Identification System", "GEN# +1.00224482"},
        {"Smithsonian Astrophysical Observation", "SAO 192274"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.59280405),
        dec: Angle.Degrees(-20.31865255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39336",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6539 A"},
        {"Henry Draper", "HD 66376"},
        {"Hipparcos Number", "HIP 39336"},
        {"Smithsonian Astrophysical Observation", "SAO 175036"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.61988696),
        dec: Angle.Degrees(-20.31831171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48203"},
        {"Hipparcos Number", "HIP 32037"},
        {"Geneva Identification System", "GEN# +1.00048203"},
        {"Smithsonian Astrophysical Observation", "SAO 172167"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.37826623),
        dec: Angle.Degrees(-20.31754635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181786"},
        {"Hipparcos Number", "HIP 95233"},
        {"Smithsonian Astrophysical Observation", "SAO 188039"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.63507201),
        dec: Angle.Degrees(-20.31623759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129830"},
        {"Hipparcos Number", "HIP 72148"},
        {"Smithsonian Astrophysical Observation", "SAO 182847"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.35589864),
        dec: Angle.Degrees(-20.31579064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9530"},
        {"Smithsonian Astrophysical Observation", "SAO 167510"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.64086149),
        dec: Angle.Degrees(-20.31506592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142183"},
        {"Hipparcos Number", "HIP 77854"},
        {"Smithsonian Astrophysical Observation", "SAO 183902"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.46814898),
        dec: Angle.Degrees(-20.31472309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91238",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11487 A"},
        {"Henry Draper", "HD 171611"},
        {"Hipparcos Number", "HIP 91238"},
        {"Smithsonian Astrophysical Observation", "SAO 187040"},
        {"Wilson Evans Batten Catalogue", "WEB 15672"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.16427462),
        dec: Angle.Degrees(-20.31393365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88035"},
        {"Hipparcos Number", "HIP 49696"},
        {"Geneva Identification System", "GEN# +1.00088035"},
        {"Smithsonian Astrophysical Observation", "SAO 178458"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.17495951),
        dec: Angle.Degrees(-20.31381395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212294"},
        {"Hipparcos Number", "HIP 110528"},
        {"Smithsonian Astrophysical Observation", "SAO 191106"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.87653778),
        dec: Angle.Degrees(-20.31376740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117350"},
        {"Hipparcos Number", "HIP 65866"},
        {"Smithsonian Astrophysical Observation", "SAO 181702"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.50286741),
        dec: Angle.Degrees(-20.31244715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9536",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9536"},
    },
    visualMagnitude: 12.11,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.64829628),
        dec: Angle.Degrees(-20.31229500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172696"},
        {"Hipparcos Number", "HIP 91736"},
        {"Geneva Identification System", "GEN# +1.00172696"},
        {"Renson", "Renson 48385"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.60602228),
        dec: Angle.Degrees(-20.31191423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89437"},
        {"Hipparcos Number", "HIP 50512"},
        {"Smithsonian Astrophysical Observation", "SAO 178669"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.74863786),
        dec: Angle.Degrees(-20.31119866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144094"},
        {"Hipparcos Number", "HIP 78769"},
        {"Smithsonian Astrophysical Observation", "SAO 184089"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.21549025),
        dec: Angle.Degrees(-20.30713146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194744"},
        {"Hipparcos Number", "HIP 100950"},
        {"Geneva Identification System", "GEN# +1.00194744"},
        {"Smithsonian Astrophysical Observation", "SAO 189314"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.01743129),
        dec: Angle.Degrees(-20.30485952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72245"},
        {"Hipparcos Number", "HIP 41772"},
        {"Smithsonian Astrophysical Observation", "SAO 175984"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.76878694),
        dec: Angle.Degrees(-20.30409049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45289"},
        {"Smithsonian Astrophysical Observation", "SAO 177133"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.44980489),
        dec: Angle.Degrees(-20.30285251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174403"},
        {"Hipparcos Number", "HIP 92505"},
        {"Geneva Identification System", "GEN# +1.00174403"},
        {"Smithsonian Astrophysical Observation", "SAO 187358"},
        {"Wilson Evans Batten Catalogue", "WEB 15991"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.77656309),
        dec: Angle.Degrees(-20.30008863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3909"},
        {"Hipparcos Number", "HIP 3259"},
        {"Smithsonian Astrophysical Observation", "SAO 166489"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.37401717),
        dec: Angle.Degrees(-20.29962350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100621"},
        {"Hipparcos Number", "HIP 56463"},
        {"Smithsonian Astrophysical Observation", "SAO 180000"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.65216537),
        dec: Angle.Degrees(-20.29946696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37847"},
        {"Henry Draper 2", "HD 37847G"},
        {"Hipparcos Number", "HIP 26714"},
        {"Geneva Identification System", "GEN# +1.00037847"},
        {"Smithsonian Astrophysical Observation", "SAO 170678"},
        {"Wilson Evans Batten Catalogue", "WEB 5269"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.16542069),
        dec: Angle.Degrees(-20.29874699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3580"},
        {"Hipparcos Number", "HIP 3025"},
        {"Geneva Identification System", "GEN# +1.00003580"},
        {"Renson", "Renson 970"},
        {"Smithsonian Astrophysical Observation", "SAO 166438"},
        {"Wilson Evans Batten Catalogue", "WEB 542"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.63263751),
        dec: Angle.Degrees(-20.29659798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61187"},
        {"Hipparcos Number", "HIP 37080"},
        {"Geneva Identification System", "GEN# +1.00061187"},
        {"Smithsonian Astrophysical Observation", "SAO 174135"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.29992355),
        dec: Angle.Degrees(-20.29611688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115329",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16694 AB"},
        {"Henry Draper", "HD 220145"},
        {"Hipparcos Number", "HIP 115329"},
        {"Smithsonian Astrophysical Observation", "SAO 191844"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.39290539),
        dec: Angle.Degrees(-20.29542868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174383"},
        {"Hipparcos Number", "HIP 92491"},
        {"Geneva Identification System", "GEN# +1.00174383"},
        {"Smithsonian Astrophysical Observation", "SAO 187349"},
        {"Wilson Evans Batten Catalogue", "WEB 15983"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.74946969),
        dec: Angle.Degrees(-20.29521812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12683",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2079 B"},
        {"Hipparcos Number", "HIP 12683"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.74094151),
        dec: Angle.Degrees(-20.29442463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101695"},
        {"Hipparcos Number", "HIP 57079"},
        {"Geneva Identification System", "GEN# +1.00101695"},
        {"Smithsonian Astrophysical Observation", "SAO 180117"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.51472348),
        dec: Angle.Degrees(-20.29403646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112848"},
        {"Hipparcos Number", "HIP 63423"},
        {"Geneva Identification System", "GEN# +1.00112848"},
        {"Smithsonian Astrophysical Observation", "SAO 181297"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.95152039),
        dec: Angle.Degrees(-20.29174978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12681",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2079 A"},
        {"Henry Draper", "HD 16994"},
        {"Hipparcos Number", "HIP 12681"},
        {"Geneva Identification System", "GEN# +1.00016994"},
        {"Smithsonian Astrophysical Observation", "SAO 167995"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.73916631),
        dec: Angle.Degrees(-20.28927422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170496"},
        {"Hipparcos Number", "HIP 90721"},
        {"Smithsonian Astrophysical Observation", "SAO 186900"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.63826523),
        dec: Angle.Degrees(-20.28747529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120026"},
        {"Hipparcos Number", "HIP 67277"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.82016888),
        dec: Angle.Degrees(-20.28688778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216052"},
        {"Hipparcos Number", "HIP 112741"},
        {"Smithsonian Astrophysical Observation", "SAO 191434"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.48337796),
        dec: Angle.Degrees(-20.28506619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54255"},
        {"Hipparcos Number", "HIP 34352"},
        {"Smithsonian Astrophysical Observation", "SAO 172996"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.82360497),
        dec: Angle.Degrees(-20.28492623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48482"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.31630198),
        dec: Angle.Degrees(-20.28169318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5902"},
        {"Hipparcos Number", "HIP 4692"},
        {"Geneva Identification System", "GEN# +1.00005902"},
        {"Smithsonian Astrophysical Observation", "SAO 166736"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.07743634),
        dec: Angle.Degrees(-20.27689028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55039"},
        {"Hipparcos Number", "HIP 34644"},
        {"Smithsonian Astrophysical Observation", "SAO 173123"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.62562156),
        dec: Angle.Degrees(-20.27482681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216968"},
        {"Hipparcos Number", "HIP 113366"},
        {"Smithsonian Astrophysical Observation", "SAO 191526"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.40440306),
        dec: Angle.Degrees(-20.27456999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173787"},
        {"Hipparcos Number", "HIP 92235"},
        {"Geneva Identification System", "GEN# +1.00173787"},
        {"Smithsonian Astrophysical Observation", "SAO 187294"},
        {"Wilson Evans Batten Catalogue", "WEB 15916"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.96804524),
        dec: Angle.Degrees(-20.27450068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27927"},
        {"Hipparcos Number", "HIP 20501"},
        {"Geneva Identification System", "GEN# +1.00027927"},
        {"Smithsonian Astrophysical Observation", "SAO 169398"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.90077832),
        dec: Angle.Degrees(-20.27387072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30226"},
        {"Hipparcos Number", "HIP 22076"},
        {"Smithsonian Astrophysical Observation", "SAO 169724"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.23143917),
        dec: Angle.Degrees(-20.27380691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13327"},
        {"Hipparcos Number", "HIP 10097"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.45373875),
        dec: Angle.Degrees(-20.27267091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43396"},
        {"Hipparcos Number", "HIP 29679"},
        {"Geneva Identification System", "GEN# +1.00043396"},
        {"Smithsonian Astrophysical Observation", "SAO 171458"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.78500463),
        dec: Angle.Degrees(-20.27226037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37244",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6254 AB"},
        {"Henry Draper", "HD 61532"},
        {"Hipparcos Number", "HIP 37244"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.73738094),
        dec: Angle.Degrees(-20.26975036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25015"},
        {"Hipparcos Number", "HIP 18527"},
        {"Smithsonian Astrophysical Observation", "SAO 168988"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.43269129),
        dec: Angle.Degrees(-20.26805400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105957",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14988 AB"},
        {"Henry Draper", "HD 204204"},
        {"Hipparcos Number", "HIP 105957"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.87672262),
        dec: Angle.Degrees(-20.26778578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42878",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6969 AB"},
        {"Henry Draper", "HD 74612"},
        {"Hipparcos Number", "HIP 42878"},
        {"Smithsonian Astrophysical Observation", "SAO 176381"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.07683931),
        dec: Angle.Degrees(-20.26680961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191536"},
        {"Hipparcos Number", "HIP 99460"},
        {"Smithsonian Astrophysical Observation", "SAO 188998"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.79684230),
        dec: Angle.Degrees(-20.26508599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215600"},
        {"Hipparcos Number", "HIP 112443"},
        {"Geneva Identification System", "GEN# +1.00215600"},
        {"Smithsonian Astrophysical Observation", "SAO 191393"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.65659013),
        dec: Angle.Degrees(-20.26128808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74492",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9534 AB"},
        {"Henry Draper", "HD 134968"},
        {"Hipparcos Number", "HIP 74492"},
        {"Smithsonian Astrophysical Observation", "SAO 183272"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.32337903),
        dec: Angle.Degrees(-20.25418947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205306"},
        {"Hipparcos Number", "HIP 106568"},
        {"Geneva Identification System", "GEN# +1.00205306"},
        {"Smithsonian Astrophysical Observation", "SAO 190463"},
        {"Wilson Evans Batten Catalogue", "WEB 19280"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.72906270),
        dec: Angle.Degrees(-20.25256297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48315"},
        {"Hipparcos Number", "HIP 32065"},
        {"Smithsonian Astrophysical Observation", "SAO 172178"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.48826762),
        dec: Angle.Degrees(-20.24961785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71852"},
        {"Hipparcos Number", "HIP 41612"},
    },
    visualMagnitude: 9.53,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.24444572),
        dec: Angle.Degrees(-20.24801319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17692"},
        {"Hipparcos Number", "HIP 13193"},
        {"Smithsonian Astrophysical Observation", "SAO 168079"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.43626608),
        dec: Angle.Degrees(-20.24638071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17700"},
        {"Hipparcos Number", "HIP 13196"},
        {"Smithsonian Astrophysical Observation", "SAO 168080"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.44755449),
        dec: Angle.Degrees(-20.24604112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32789"},
        {"Hipparcos Number", "HIP 23631"},
        {"Geneva Identification System", "GEN# +1.00032789"},
        {"Smithsonian Astrophysical Observation", "SAO 170040"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.20722751),
        dec: Angle.Degrees(-20.24598740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27823"},
        {"Hipparcos Number", "HIP 20443"},
        {"Smithsonian Astrophysical Observation", "SAO 169383"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.69291177),
        dec: Angle.Degrees(-20.24285083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192154"},
        {"Hipparcos Number", "HIP 99730"},
        {"Smithsonian Astrophysical Observation", "SAO 189051"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.54252809),
        dec: Angle.Degrees(-20.24026960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174723"},
        {"Hipparcos Number", "HIP 92650"},
        {"Geneva Identification System", "GEN# +5.13940002"},
        {"Smithsonian Astrophysical Observation", "SAO 187395"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.17678584),
        dec: Angle.Degrees(-20.23901267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90085"},
        {"Hipparcos Number", "HIP 50901"},
        {"Smithsonian Astrophysical Observation", "SAO 155952"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.91129104),
        dec: Angle.Degrees(-20.23768709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212600"},
        {"Hipparcos Number", "HIP 110707"},
        {"Smithsonian Astrophysical Observation", "SAO 191131"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.45018547),
        dec: Angle.Degrees(-20.23699494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15145"},
        {"Hipparcos Number", "HIP 11335"},
        {"Smithsonian Astrophysical Observation", "SAO 167782"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.46525422),
        dec: Angle.Degrees(-20.23607188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20432"},
        {"Hipparcos Number", "HIP 15243"},
        {"Smithsonian Astrophysical Observation", "SAO 168428"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.14897957),
        dec: Angle.Degrees(-20.23476631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145998"},
        {"Hipparcos Number", "HIP 79606"},
        {"Smithsonian Astrophysical Observation", "SAO 184257"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.66737902),
        dec: Angle.Degrees(-20.23410109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94526"},
        {"Hipparcos Number", "HIP 53329"},
        {"Smithsonian Astrophysical Observation", "SAO 156315"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.61835879),
        dec: Angle.Degrees(-20.23401172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223561"},
        {"Hipparcos Number", "HIP 117569"},
        {"Fundamental Katalog 5th Edition", "FK5 6112"},
        {"Smithsonian Astrophysical Observation", "SAO 192194"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.64252154),
        dec: Angle.Degrees(-20.23317789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45981"},
        {"Hipparcos Number", "HIP 30957"},
        {"Smithsonian Astrophysical Observation", "SAO 171840"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.47153930),
        dec: Angle.Degrees(-20.23140194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191677"},
        {"Hipparcos Number", "HIP 99519"},
        {"Geneva Identification System", "GEN# +1.00191677"},
        {"Smithsonian Astrophysical Observation", "SAO 189005"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.95317027),
        dec: Angle.Degrees(-20.23102687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31582"},
        {"Smithsonian Astrophysical Observation", "SAO 172018"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.14540513),
        dec: Angle.Degrees(-20.23080376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58131"},
        {"Hipparcos Number", "HIP 35839"},
        {"Geneva Identification System", "GEN# +1.00058131"},
        {"Smithsonian Astrophysical Observation", "SAO 173609"},
        {"Wilson Evans Batten Catalogue", "WEB 7140"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.85212103),
        dec: Angle.Degrees(-20.23033528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79483"},
        {"Hipparcos Number", "HIP 45286"},
        {"Smithsonian Astrophysical Observation", "SAO 177132"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.44708835),
        dec: Angle.Degrees(-20.22901381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88395"},
        {"Hipparcos Number", "HIP 49886"},
        {"Smithsonian Astrophysical Observation", "SAO 155797"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.79583514),
        dec: Angle.Degrees(-20.22816835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107367"},
        {"Hipparcos Number", "HIP 60199"},
        {"Smithsonian Astrophysical Observation", "SAO 157221"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.17458184),
        dec: Angle.Degrees(-20.22726872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157202"},
        {"Hipparcos Number", "HIP 85023"},
        {"Smithsonian Astrophysical Observation", "SAO 185337"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.67463931),
        dec: Angle.Degrees(-20.22608044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98413"},
        {"Hipparcos Number", "HIP 55269"},
        {"Geneva Identification System", "GEN# +1.00098413"},
        {"Smithsonian Astrophysical Observation", "SAO 156602"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.78862381),
        dec: Angle.Degrees(-20.22563159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50707"},
        {"Hipparcos Number", "HIP 33092"},
        {"Fundamental Katalog 5th Edition", "FK5 2532"},
        {"Geneva Identification System", "GEN# +5.11210024"},
        {"Smithsonian Astrophysical Observation", "SAO 172520"},
        {"Wilson Evans Batten Catalogue", "WEB 6660"},
    },
    visualMagnitude: 4.82,
    bvColour: -0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.38712732),
        dec: Angle.Degrees(-20.22426366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133862"},
        {"Hipparcos Number", "HIP 73995"},
        {"Smithsonian Astrophysical Observation", "SAO 183194"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.82317412),
        dec: Angle.Degrees(-20.22282244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146834"},
        {"Hipparcos Number", "HIP 79945"},
        {"Geneva Identification System", "GEN# +1.00146834"},
        {"Smithsonian Astrophysical Observation", "SAO 184309"},
        {"Wilson Evans Batten Catalogue", "WEB 13532"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.78213060),
        dec: Angle.Degrees(-20.21803464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154831"},
        {"Hipparcos Number", "HIP 83873"},
        {"Smithsonian Astrophysical Observation", "SAO 185067"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.13529903),
        dec: Angle.Degrees(-20.21750278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5452",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 959 AB"},
        {"Henry Draper", "HD 6956"},
        {"Hipparcos Number", "HIP 5452"},
    },
    visualMagnitude: 9.34,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.44066910),
        dec: Angle.Degrees(-20.21661093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191624"},
        {"Hipparcos Number", "HIP 99501"},
        {"Smithsonian Astrophysical Observation", "SAO 189003"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.89722754),
        dec: Angle.Degrees(-20.21660684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135408"},
        {"Hipparcos Number", "HIP 74667"},
        {"Smithsonian Astrophysical Observation", "SAO 183315"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.87547759),
        dec: Angle.Degrees(-20.21625638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168451"},
        {"Hipparcos Number", "HIP 89893"},
        {"Geneva Identification System", "GEN# +1.00168451"},
        {"Smithsonian Astrophysical Observation", "SAO 186678"},
        {"Wilson Evans Batten Catalogue", "WEB 15348"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.13569471),
        dec: Angle.Degrees(-20.21625059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22755"},
        {"Hipparcos Number", "HIP 17010"},
        {"Smithsonian Astrophysical Observation", "SAO 168699"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.70553183),
        dec: Angle.Degrees(-20.21576290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157263"},
        {"Hipparcos Number", "HIP 85053"},
        {"Smithsonian Astrophysical Observation", "SAO 185343"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.73616240),
        dec: Angle.Degrees(-20.21519891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112326"},
        {"Hipparcos Number", "HIP 63129"},
        {"Smithsonian Astrophysical Observation", "SAO 157601"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.01783110),
        dec: Angle.Degrees(-20.21438739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204203"},
        {"Hipparcos Number", "HIP 105953"},
        {"Smithsonian Astrophysical Observation", "SAO 190356"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.87168675),
        dec: Angle.Degrees(-20.21255474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189242"},
        {"Hipparcos Number", "HIP 98413"},
        {"Geneva Identification System", "GEN# +1.00189242"},
        {"Smithsonian Astrophysical Observation", "SAO 188797"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.94143010),
        dec: Angle.Degrees(-20.21030980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1256"},
        {"Hipparcos Number", "HIP 1331"},
        {"Geneva Identification System", "GEN# +1.00001256"},
        {"Smithsonian Astrophysical Observation", "SAO 166167"},
        {"Wilson Evans Batten Catalogue", "WEB 239"},
    },
    visualMagnitude: 6.50,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.17644820),
        dec: Angle.Degrees(-20.21005714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137846"},
        {"Hipparcos Number", "HIP 75786"},
        {"Smithsonian Astrophysical Observation", "SAO 183509"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.22859465),
        dec: Angle.Degrees(-20.20871732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12236"},
        {"Hipparcos Number", "HIP 9322"},
        {"Smithsonian Astrophysical Observation", "SAO 167465"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.93121046),
        dec: Angle.Degrees(-20.20805903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124430"},
        {"Hipparcos Number", "HIP 69528"},
        {"Geneva Identification System", "GEN# +1.00124430"},
        {"Smithsonian Astrophysical Observation", "SAO 158441"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.49880428),
        dec: Angle.Degrees(-20.20798229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38216",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6398 A"},
        {"Henry Draper", "HD 63754"},
        {"Hipparcos Number", "HIP 38216"},
        {"Geneva Identification System", "GEN# +1.00063754"},
        {"Smithsonian Astrophysical Observation", "SAO 174617"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.43868792),
        dec: Angle.Degrees(-20.20731485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52854"},
    },
    visualMagnitude: 11.43,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.11800537),
        dec: Angle.Degrees(-20.20590020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161326"},
        {"Hipparcos Number", "HIP 86926"},
        {"Smithsonian Astrophysical Observation", "SAO 185711"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.41850935),
        dec: Angle.Degrees(-20.20448056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53670"},
        {"Hipparcos Number", "HIP 34165"},
        {"Smithsonian Astrophysical Observation", "SAO 172920"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.27314924),
        dec: Angle.Degrees(-20.20247479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43502"},
        {"Hipparcos Number", "HIP 29733"},
        {"Smithsonian Astrophysical Observation", "SAO 171468"},
        {"Wilson Evans Batten Catalogue", "WEB 5868"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.92410272),
        dec: Angle.Degrees(-20.20170411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100088"},
        {"Hipparcos Number", "HIP 56179"},
        {"Geneva Identification System", "GEN# +1.00100088"},
        {"Smithsonian Astrophysical Observation", "SAO 156728"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.73488730),
        dec: Angle.Degrees(-20.19995677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45778"},
        {"Hipparcos Number", "HIP 30842"},
        {"Geneva Identification System", "GEN# +1.00045778"},
        {"Smithsonian Astrophysical Observation", "SAO 171810"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.16460389),
        dec: Angle.Degrees(-20.19726448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96983"},
        {"Smithsonian Astrophysical Observation", "SAO 188476"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.69917496),
        dec: Angle.Degrees(-20.19583110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13407"},
        {"Hipparcos Number", "HIP 10151"},
        {"Smithsonian Astrophysical Observation", "SAO 167610"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.64588555),
        dec: Angle.Degrees(-20.19540362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201301"},
        {"Hipparcos Number", "HIP 104429"},
        {"Smithsonian Astrophysical Observation", "SAO 190065"},
        {"Wilson Evans Batten Catalogue", "WEB 19010"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.31421114),
        dec: Angle.Degrees(-20.19316102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154281"},
        {"Hipparcos Number", "HIP 83600"},
        {"Geneva Identification System", "GEN# +1.00154281"},
        {"Smithsonian Astrophysical Observation", "SAO 185009"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.31656948),
        dec: Angle.Degrees(-20.19163726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7907"},
        {"Hipparcos Number", "HIP 6113"},
        {"Smithsonian Astrophysical Observation", "SAO 166941"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.62011040),
        dec: Angle.Degrees(-20.19045832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207642"},
        {"Hipparcos Number", "HIP 107845"},
        {"Smithsonian Astrophysical Observation", "SAO 190680"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.73512597),
        dec: Angle.Degrees(-20.18881758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150514"},
        {"Hipparcos Number", "HIP 81785"},
        {"Geneva Identification System", "GEN# +1.00150514"},
        {"Smithsonian Astrophysical Observation", "SAO 184558"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.57253692),
        dec: Angle.Degrees(-20.18702858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91485"},
        {"Hipparcos Number", "HIP 51683"},
        {"Geneva Identification System", "GEN# +1.00091485"},
        {"Smithsonian Astrophysical Observation", "SAO 156062"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.37802782),
        dec: Angle.Degrees(-20.18121724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200868"},
        {"Hipparcos Number", "HIP 104204"},
        {"Smithsonian Astrophysical Observation", "SAO 190014"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.67295431),
        dec: Angle.Degrees(-20.18022290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116683"},
        {"Hipparcos Number", "HIP 65504"},
        {"Smithsonian Astrophysical Observation", "SAO 157925"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.38398598),
        dec: Angle.Degrees(-20.17856173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44913"},
        {"Hipparcos Number", "HIP 30406"},
        {"Smithsonian Astrophysical Observation", "SAO 171673"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.89938261),
        dec: Angle.Degrees(-20.17761390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202480"},
        {"Hipparcos Number", "HIP 105048"},
        {"Smithsonian Astrophysical Observation", "SAO 190191"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.16557667),
        dec: Angle.Degrees(-20.17457159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45404"},
        {"Hipparcos Number", "HIP 30645"},
        {"Smithsonian Astrophysical Observation", "SAO 171742"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.59803210),
        dec: Angle.Degrees(-20.17446120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29285"},
        {"Hipparcos Number", "HIP 21420"},
        {"Geneva Identification System", "GEN# +1.00029285"},
        {"Smithsonian Astrophysical Observation", "SAO 169595"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.97420446),
        dec: Angle.Degrees(-20.17330405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86625"},
        {"Hipparcos Number", "HIP 48962"},
        {"Geneva Identification System", "GEN# +1.00086625"},
        {"Smithsonian Astrophysical Observation", "SAO 155636"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.82480934),
        dec: Angle.Degrees(-20.17317584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10572"},
        {"Hipparcos Number", "HIP 7986"},
        {"Fundamental Katalog 5th Edition", "FK5 4153"},
        {"Smithsonian Astrophysical Observation", "SAO 167242"},
        {"Wilson Evans Batten Catalogue", "WEB 1713"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.64901509),
        dec: Angle.Degrees(-20.17255176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221206"},
        {"Hipparcos Number", "HIP 115995"},
        {"Smithsonian Astrophysical Observation", "SAO 191952"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.52150162),
        dec: Angle.Degrees(-20.17130151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212126"},
        {"Hipparcos Number", "HIP 110453"},
        {"Smithsonian Astrophysical Observation", "SAO 191091"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.59331145),
        dec: Angle.Degrees(-20.17129729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222563"},
        {"Hipparcos Number", "HIP 116900"},
        {"Smithsonian Astrophysical Observation", "SAO 192093"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.43909605),
        dec: Angle.Degrees(-20.17065624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142096"},
        {"Hipparcos Number", "HIP 77811"},
        {"Celescope Catalog", "CEL 4398"},
        {"Fundamental Katalog 5th Edition", "FK5 1415"},
        {"Geneva Identification System", "GEN# +1.00142096"},
        {"Renson", "Renson 40340"},
        {"Smithsonian Astrophysical Observation", "SAO 183895"},
        {"Wilson Evans Batten Catalogue", "WEB 13160"},
    },
    visualMagnitude: 5.04,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.33358671),
        dec: Angle.Degrees(-20.16699405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141225"},
        {"Hipparcos Number", "HIP 77446"},
        {"Smithsonian Astrophysical Observation", "SAO 183817"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.16889157),
        dec: Angle.Degrees(-20.16602247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76033",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9681 A"},
        {"Henry Draper", "HD 138268"},
        {"Hipparcos Number", "HIP 76033"},
        {"Geneva Identification System", "GEN# +1.00138268J"},
        {"Geneva Identification System 2", "GEN# +1.00138268A"},
        {"Smithsonian Astrophysical Observation", "SAO 159317"},
        {"Wilson Evans Batten Catalogue", "WEB 12923"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.93104588),
        dec: Angle.Degrees(-20.16484591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28275",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4567 AB"},
        {"Henry Draper", "HD 40501"},
        {"Hipparcos Number", "HIP 28275"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.61807686),
        dec: Angle.Degrees(-20.16479621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150527"},
        {"Hipparcos Number", "HIP 81796"},
        {"Smithsonian Astrophysical Observation", "SAO 184561"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.60248269),
        dec: Angle.Degrees(-20.16454888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76028",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9681 B"},
        {"Henry Draper", "HD 138268B"},
        {"Hipparcos Number", "HIP 76028"},
        {"Geneva Identification System", "GEN# +1.00138268B"},
        {"Smithsonian Astrophysical Observation", "SAO 159316"},
        {"Wilson Evans Batten Catalogue", "WEB 12924"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.92777887),
        dec: Angle.Degrees(-20.16430682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70075"},
        {"Hipparcos Number", "HIP 40777"},
        {"Renson", "Renson 19363"},
        {"Smithsonian Astrophysical Observation", "SAO 175589"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.84277135),
        dec: Angle.Degrees(-20.16427924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118514"},
        {"Hipparcos Number", "HIP 66489"},
        {"Smithsonian Astrophysical Observation", "SAO 158050"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.45580636),
        dec: Angle.Degrees(-20.16408447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25661"},
        {"Hipparcos Number", "HIP 18942"},
        {"Geneva Identification System", "GEN# +1.00025661"},
        {"Smithsonian Astrophysical Observation", "SAO 169078"},
        {"Wilson Evans Batten Catalogue", "WEB 3642"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.90322895),
        dec: Angle.Degrees(-20.15868068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52348"},
        {"Hipparcos Number", "HIP 33703"},
        {"Celescope Catalog", "CEL 1491"},
        {"Geneva Identification System", "GEN# +1.00052348"},
        {"Smithsonian Astrophysical Observation", "SAO 172718"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.03452285),
        dec: Angle.Degrees(-20.15843758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22433"},
        {"Hipparcos Number", "HIP 16776"},
        {"Smithsonian Astrophysical Observation", "SAO 168665"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.97855955),
        dec: Angle.Degrees(-20.15219105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8149",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1379 AB"},
        {"Henry Draper", "HD 10752"},
        {"Hipparcos Number", "HIP 8149"},
        {"Smithsonian Astrophysical Observation", "SAO 167264"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.19426007),
        dec: Angle.Degrees(-20.15090486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149580"},
        {"Hipparcos Number", "HIP 81325"},
        {"Smithsonian Astrophysical Observation", "SAO 184492"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.14597830),
        dec: Angle.Degrees(-20.14992654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36617"},
        {"Wilson Evans Batten Catalogue", "WEB 7277"},
    },
    visualMagnitude: 11.44,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.95454587),
        dec: Angle.Degrees(-20.14967257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97309"},
        {"Hipparcos Number", "HIP 54698"},
        {"Geneva Identification System", "GEN# +1.00097309"},
        {"Renson", "Renson 28050"},
        {"Smithsonian Astrophysical Observation", "SAO 156522"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.97388097),
        dec: Angle.Degrees(-20.14795843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132491"},
        {"Hipparcos Number", "HIP 73400"},
        {"Geneva Identification System", "GEN# +1.00132491"},
        {"Smithsonian Astrophysical Observation", "SAO 158958"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.00534965),
        dec: Angle.Degrees(-20.14765009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110902"},
        {"Hipparcos Number", "HIP 62264"},
        {"Celescope Catalog", "CEL 4151"},
        {"Geneva Identification System", "GEN# +1.00110902"},
        {"Smithsonian Astrophysical Observation", "SAO 157492"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.38677859),
        dec: Angle.Degrees(-20.14571001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25631"},
        {"Hipparcos Number", "HIP 18926"},
        {"Geneva Identification System", "GEN# +1.00025631"},
        {"Smithsonian Astrophysical Observation", "SAO 169071"},
        {"Wilson Evans Batten Catalogue", "WEB 3640"},
    },
    visualMagnitude: 6.47,
    bvColour: -0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.85311396),
        dec: Angle.Degrees(-20.14379271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177164"},
        {"Hipparcos Number", "HIP 93659"},
        {"Smithsonian Astrophysical Observation", "SAO 187635"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.07636163),
        dec: Angle.Degrees(-20.14258140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190595"},
        {"Hipparcos Number", "HIP 99039"},
        {"Smithsonian Astrophysical Observation", "SAO 188914"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.61869823),
        dec: Angle.Degrees(-20.14229868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113897"},
        {"Hipparcos Number", "HIP 64017"},
        {"Smithsonian Astrophysical Observation", "SAO 157728"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.76603193),
        dec: Angle.Degrees(-20.14055084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21919"},
        {"Smithsonian Astrophysical Observation", "SAO 169685"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.70394554),
        dec: Angle.Degrees(-20.14003709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216727"},
        {"Hipparcos Number", "HIP 113204"},
        {"Smithsonian Astrophysical Observation", "SAO 191496"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.87736753),
        dec: Angle.Degrees(-20.13936653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46601"},
        {"Hipparcos Number", "HIP 31275"},
        {"Geneva Identification System", "GEN# +1.00046601"},
        {"Smithsonian Astrophysical Observation", "SAO 171941"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.39052160),
        dec: Angle.Degrees(-20.13909760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94388"},
        {"Hipparcos Number", "HIP 53252"},
        {"Geneva Identification System", "GEN# +1.00094388"},
        {"Smithsonian Astrophysical Observation", "SAO 156301"},
        {"Wilson Evans Batten Catalogue", "WEB 9668"},
    },
    visualMagnitude: 5.23,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.37284019),
        dec: Angle.Degrees(-20.13815014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60553"},
        {"Hipparcos Number", "HIP 36808"},
        {"Celescope Catalog", "CEL 1932"},
        {"Geneva Identification System", "GEN# +1.00060553"},
        {"Smithsonian Astrophysical Observation", "SAO 174014"},
        {"Wilson Evans Batten Catalogue", "WEB 7313"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.55399386),
        dec: Angle.Degrees(-20.13741922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33302",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5602 A"},
        {"Henry Draper", "HD 51199"},
        {"Hipparcos Number", "HIP 33302"},
        {"Geneva Identification System", "GEN# +1.00051199"},
        {"Smithsonian Astrophysical Observation", "SAO 172579"},
        {"Wilson Evans Batten Catalogue", "WEB 6695"},
    },
    visualMagnitude: 4.66,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.90582904),
        dec: Angle.Degrees(-20.13659348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2395"},
        {"Hipparcos Number", "HIP 2184"},
        {"Geneva Identification System", "GEN# +1.00002395"},
        {"Smithsonian Astrophysical Observation", "SAO 166285"},
        {"Wilson Evans Batten Catalogue", "WEB 407"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.90640824),
        dec: Angle.Degrees(-20.13453647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51514"},
        {"Hipparcos Number", "HIP 33407"},
        {"Geneva Identification System", "GEN# +1.00051514"},
        {"Smithsonian Astrophysical Observation", "SAO 172615"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.22056223),
        dec: Angle.Degrees(-20.13271432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57029"},
        {"Hipparcos Number", "HIP 35413"},
        {"Celescope Catalog", "CEL 1758"},
        {"Geneva Identification System", "GEN# +1.00057029"},
        {"Smithsonian Astrophysical Observation", "SAO 173439"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.67253767),
        dec: Angle.Degrees(-20.13095168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61824"},
        {"Hipparcos Number", "HIP 37380"},
        {"Renson", "Renson 16980"},
        {"Smithsonian Astrophysical Observation", "SAO 174252"},
    },
    visualMagnitude: 9.48,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.09832660),
        dec: Angle.Degrees(-20.12895877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56279"},
        {"Hipparcos Number", "HIP 35110"},
        {"Celescope Catalog", "CEL 1719"},
        {"Geneva Identification System", "GEN# +1.00056279"},
        {"Smithsonian Astrophysical Observation", "SAO 173310"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.89528759),
        dec: Angle.Degrees(-20.12870870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177015"},
        {"Hipparcos Number", "HIP 93581"},
        {"Geneva Identification System", "GEN# +1.00177015"},
        {"Smithsonian Astrophysical Observation", "SAO 187618"},
        {"Wilson Evans Batten Catalogue", "WEB 16254"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.88803830),
        dec: Angle.Degrees(-20.12857212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17771"},
        {"Hipparcos Number", "HIP 13248"},
        {"Smithsonian Astrophysical Observation", "SAO 168088"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.62986315),
        dec: Angle.Degrees(-20.12701178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38382"},
        {"Hipparcos Number", "HIP 27075"},
        {"Fundamental Katalog 5th Edition", "FK5 4528"},
        {"Geneva Identification System", "GEN# +1.00038382"},
        {"Smithsonian Astrophysical Observation", "SAO 170756"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.11835896),
        dec: Angle.Degrees(-20.12666310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24436"},
        {"Hipparcos Number", "HIP 18124"},
        {"Smithsonian Astrophysical Observation", "SAO 168907"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.13822199),
        dec: Angle.Degrees(-20.12507287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114243"},
        {"Hipparcos Number", "HIP 64204"},
        {"Smithsonian Astrophysical Observation", "SAO 157757"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.37589271),
        dec: Angle.Degrees(-20.12362598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16356"},
        {"Hipparcos Number", "HIP 12170"},
        {"Smithsonian Astrophysical Observation", "SAO 167918"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.20912771),
        dec: Angle.Degrees(-20.12183758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33239"},
        {"Hipparcos Number", "HIP 23888"},
        {"Smithsonian Astrophysical Observation", "SAO 170097"},
        {"Wilson Evans Batten Catalogue", "WEB 4661"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.00142920),
        dec: Angle.Degrees(-20.12110758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45393",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7263 AB"},
        {"Henry Draper", "HD 79709"},
        {"Hipparcos Number", "HIP 45393"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.75731960),
        dec: Angle.Degrees(-20.12027839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27975"},
        {"Hipparcos Number", "HIP 20545"},
        {"Smithsonian Astrophysical Observation", "SAO 169411"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.03091994),
        dec: Angle.Degrees(-20.11824647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80063",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10005 AB"},
        {"Henry Draper", "HD 147103"},
        {"Hipparcos Number", "HIP 80063"},
        {"Geneva Identification System", "GEN# +1.00147103"},
        {"Renson", "Renson 41550"},
        {"Smithsonian Astrophysical Observation", "SAO 159864"},
        {"Wilson Evans Batten Catalogue", "WEB 13555"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.12612858),
        dec: Angle.Degrees(-20.11767154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18165"},
        {"Hipparcos Number", "HIP 13542"},
        {"Smithsonian Astrophysical Observation", "SAO 168133"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.60135733),
        dec: Angle.Degrees(-20.11710408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33072"},
        {"Hipparcos Number", "HIP 23806"},
        {"Smithsonian Astrophysical Observation", "SAO 170075"},
        {"Wilson Evans Batten Catalogue", "WEB 4645"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.74971487),
        dec: Angle.Degrees(-20.11504017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37579"},
        {"Hipparcos Number", "HIP 26547"},
        {"Smithsonian Astrophysical Observation", "SAO 170630"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.68297853),
        dec: Angle.Degrees(-20.11470589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80062",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10005 C"},
        {"Henry Draper", "HD 147104"},
        {"Hipparcos Number", "HIP 80062"},
        {"Geneva Identification System", "GEN# +1.00147104"},
        {"Smithsonian Astrophysical Observation", "SAO 159865"},
        {"Wilson Evans Batten Catalogue", "WEB 13556"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.12740185),
        dec: Angle.Degrees(-20.11439051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19814"},
        {"Hipparcos Number", "HIP 14771"},
        {"Geneva Identification System", "GEN# +1.00019814"},
        {"Smithsonian Astrophysical Observation", "SAO 168355"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.67297501),
        dec: Angle.Degrees(-20.11151235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22838"},
        {"Hipparcos Number", "HIP 17069"},
        {"Smithsonian Astrophysical Observation", "SAO 168713"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.87419141),
        dec: Angle.Degrees(-20.10997934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14046"},
        {"Hipparcos Number", "HIP 10565"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.00532730),
        dec: Angle.Degrees(-20.10996040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106405"},
        {"Hipparcos Number", "HIP 59694"},
        {"Smithsonian Astrophysical Observation", "SAO 157163"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.62216712),
        dec: Angle.Degrees(-20.10767555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7729"},
        {"Hipparcos Number", "HIP 5967"},
        {"Geneva Identification System", "GEN# +1.00007729"},
        {"Smithsonian Astrophysical Observation", "SAO 166922"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.17999502),
        dec: Angle.Degrees(-20.10613112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160767"},
        {"Hipparcos Number", "HIP 86675"},
        {"Smithsonian Astrophysical Observation", "SAO 185642"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.63458165),
        dec: Angle.Degrees(-20.10425928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146436"},
        {"Hipparcos Number", "HIP 79788"},
        {"Smithsonian Astrophysical Observation", "SAO 159829"},
        {"Wilson Evans Batten Catalogue", "WEB 13505"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.24667464),
        dec: Angle.Degrees(-20.10407073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151222"},
        {"Hipparcos Number", "HIP 82149"},
        {"Smithsonian Astrophysical Observation", "SAO 184634"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.73778764),
        dec: Angle.Degrees(-20.10350785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220321"},
        {"Hipparcos Number", "HIP 115438"},
        {"Fundamental Katalog 5th Edition", "FK5 1612"},
        {"Geneva Identification System", "GEN# +1.00220321"},
        {"Smithsonian Astrophysical Observation", "SAO 191858"},
        {"Wilson Evans Batten Catalogue", "WEB 20440"},
    },
    visualMagnitude: 3.96,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.74292280),
        dec: Angle.Degrees(-20.10034505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39036"},
        {"Hipparcos Number", "HIP 27481"},
        {"Smithsonian Astrophysical Observation", "SAO 170869"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.28305494),
        dec: Angle.Degrees(-20.09990018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112144"},
        {"Hipparcos Number", "HIP 62996"},
        {"Fundamental Katalog 5th Edition", "FK5 3028"},
        {"Smithsonian Astrophysical Observation", "SAO 157586"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.62591046),
        dec: Angle.Degrees(-20.09802190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33574"},
        {"Hipparcos Number", "HIP 24086"},
        {"Smithsonian Astrophysical Observation", "SAO 170148"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.61534204),
        dec: Angle.Degrees(-20.09325311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81619"},
        {"Hipparcos Number", "HIP 46278"},
        {"Smithsonian Astrophysical Observation", "SAO 155183"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.54320415),
        dec: Angle.Degrees(-20.09320856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5933"},
        {"Hipparcos Number", "HIP 4723"},
        {"Smithsonian Astrophysical Observation", "SAO 166742"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.16712669),
        dec: Angle.Degrees(-20.09021126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38482"},
        {"Hipparcos Number", "HIP 27152"},
        {"Smithsonian Astrophysical Observation", "SAO 170786"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.34257268),
        dec: Angle.Degrees(-20.09012077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196680"},
        {"Hipparcos Number", "HIP 101952"},
        {"Geneva Identification System", "GEN# +1.00196680"},
        {"Smithsonian Astrophysical Observation", "SAO 189533"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.90087900),
        dec: Angle.Degrees(-20.08963447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221546"},
        {"Hipparcos Number", "HIP 116236"},
        {"Geneva Identification System", "GEN# +1.00221546"},
        {"Smithsonian Astrophysical Observation", "SAO 191984"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.27257429),
        dec: Angle.Degrees(-20.08884988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48376"},
        {"Hipparcos Number", "HIP 32097"},
        {"Smithsonian Astrophysical Observation", "SAO 172188"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.58275714),
        dec: Angle.Degrees(-20.08838660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107844"},
        {"Hipparcos Number", "HIP 60457"},
        {"Smithsonian Astrophysical Observation", "SAO 157258"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.91503112),
        dec: Angle.Degrees(-20.08795354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202038"},
        {"Hipparcos Number", "HIP 104804"},
        {"Fundamental Katalog 5th Edition", "FK5 5874"},
        {"Smithsonian Astrophysical Observation", "SAO 190146"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.48897211),
        dec: Angle.Degrees(-20.08790662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165833"},
        {"Hipparcos Number", "HIP 88879"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.17321628),
        dec: Angle.Degrees(-20.08714722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222506"},
        {"Hipparcos Number", "HIP 116874"},
        {"Smithsonian Astrophysical Observation", "SAO 192087"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.34555037),
        dec: Angle.Degrees(-20.08562550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185767"},
        {"Hipparcos Number", "HIP 96873"},
        {"Smithsonian Astrophysical Observation", "SAO 188447"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.36871035),
        dec: Angle.Degrees(-20.08508866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205289"},
        {"Hipparcos Number", "HIP 106559"},
        {"Geneva Identification System", "GEN# +1.00205289"},
        {"Smithsonian Astrophysical Observation", "SAO 190461"},
        {"Wilson Evans Batten Catalogue", "WEB 19279"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.71278777),
        dec: Angle.Degrees(-20.08438179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70442"},
        {"Henry Draper 2", "HD 70443"},
        {"Hipparcos Number", "HIP 40944"},
        {"Fundamental Katalog 5th Edition", "FK5 2647"},
        {"Geneva Identification System", "GEN# +1.00070442"},
        {"Smithsonian Astrophysical Observation", "SAO 154150"},
        {"Wilson Evans Batten Catalogue", "WEB 7938"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.33843502),
        dec: Angle.Degrees(-20.07901245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109744"},
        {"Hipparcos Number", "HIP 61588"},
        {"Smithsonian Astrophysical Observation", "SAO 157400"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.30245846),
        dec: Angle.Degrees(-20.07889727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159650"},
        {"Hipparcos Number", "HIP 86180"},
        {"Smithsonian Astrophysical Observation", "SAO 185547"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.15356713),
        dec: Angle.Degrees(-20.07760800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102207"},
    },
    visualMagnitude: 12.38,
    bvColour: -0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.64387351),
        dec: Angle.Degrees(-20.07641421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 354.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146216"},
        {"Hipparcos Number", "HIP 79690"},
        {"Geneva Identification System", "GEN# +1.00146216"},
        {"Smithsonian Astrophysical Observation", "SAO 159818"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.96055348),
        dec: Angle.Degrees(-20.07638456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110981"},
        {"Hipparcos Number", "HIP 62300"},
        {"Geneva Identification System", "GEN# +1.00110981"},
        {"Smithsonian Astrophysical Observation", "SAO 157494"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.49399867),
        dec: Angle.Degrees(-20.07526335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199458"},
        {"Hipparcos Number", "HIP 103480"},
        {"Geneva Identification System", "GEN# +1.00199458"},
        {"Smithsonian Astrophysical Observation", "SAO 189882"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.48012165),
        dec: Angle.Degrees(-20.07447771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148970"},
        {"Hipparcos Number", "HIP 81004"},
        {"Smithsonian Astrophysical Observation", "SAO 159968"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.14072926),
        dec: Angle.Degrees(-20.07354710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123181"},
        {"Hipparcos Number", "HIP 68914"},
        {"Smithsonian Astrophysical Observation", "SAO 158352"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.62428360),
        dec: Angle.Degrees(-20.07291725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108012"},
        {"Hipparcos Number", "HIP 60545"},
        {"Smithsonian Astrophysical Observation", "SAO 157267"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.17649778),
        dec: Angle.Degrees(-20.07130279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172236"},
        {"Hipparcos Number", "HIP 91527"},
        {"Geneva Identification System", "GEN# +1.00172236"},
        {"Smithsonian Astrophysical Observation", "SAO 187108"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.97365923),
        dec: Angle.Degrees(-20.07120159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202223"},
        {"Hipparcos Number", "HIP 104902"},
        {"Smithsonian Astrophysical Observation", "SAO 190162"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.73764494),
        dec: Angle.Degrees(-20.07062336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216358"},
        {"Hipparcos Number", "HIP 112962"},
        {"Smithsonian Astrophysical Observation", "SAO 191459"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.15589766),
        dec: Angle.Degrees(-20.07046329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195566"},
        {"Hipparcos Number", "HIP 101374"},
        {"Smithsonian Astrophysical Observation", "SAO 189415"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.19590397),
        dec: Angle.Degrees(-20.06956004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29703"},
        {"Hipparcos Number", "HIP 21722"},
        {"Smithsonian Astrophysical Observation", "SAO 169643"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.95444957),
        dec: Angle.Degrees(-20.06673023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72749"},
        {"Hipparcos Number", "HIP 42022"},
        {"Smithsonian Astrophysical Observation", "SAO 154409"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.49130985),
        dec: Angle.Degrees(-20.06671118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184645"},
        {"Hipparcos Number", "HIP 96424"},
        {"Smithsonian Astrophysical Observation", "SAO 188329"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.05571213),
        dec: Angle.Degrees(-20.06504395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26280"},
        {"Hipparcos Number", "HIP 19349"},
        {"Geneva Identification System", "GEN# +1.00026280"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.17695991),
        dec: Angle.Degrees(-20.06418982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150513"},
        {"Hipparcos Number", "HIP 81783"},
        {"Smithsonian Astrophysical Observation", "SAO 160055"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.56644674),
        dec: Angle.Degrees(-20.06220523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6570"},
        {"Hipparcos Number", "HIP 5180"},
        {"Smithsonian Astrophysical Observation", "SAO 166800"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.56349696),
        dec: Angle.Degrees(-20.06020269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95580"},
        {"Hipparcos Number", "HIP 53902"},
        {"Geneva Identification System", "GEN# +1.00095580"},
        {"Smithsonian Astrophysical Observation", "SAO 156410"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.43350443),
        dec: Angle.Degrees(-20.05928469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113801"},
        {"Hipparcos Number", "HIP 63955"},
        {"Geneva Identification System", "GEN# +1.00113801"},
        {"Smithsonian Astrophysical Observation", "SAO 157721"},
        {"Wilson Evans Batten Catalogue", "WEB 11302"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.60339077),
        dec: Angle.Degrees(-20.05873502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1760"},
        {"Hipparcos Number", "HIP 1728"},
        {"Geneva Identification System", "GEN# +1.00001760"},
        {"Smithsonian Astrophysical Observation", "SAO 166210"},
        {"Wilson Evans Batten Catalogue", "WEB 312"},
    },
    visualMagnitude: 5.61,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.44264511),
        dec: Angle.Degrees(-20.05799253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96800"},
        {"Hipparcos Number", "HIP 54478"},
        {"Geneva Identification System", "GEN# +1.00096800"},
        {"Smithsonian Astrophysical Observation", "SAO 156489"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.18435905),
        dec: Angle.Degrees(-20.05768520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147010"},
        {"Hipparcos Number", "HIP 80024"},
        {"Geneva Identification System", "GEN# +1.00147010"},
        {"Renson", "Renson 41530"},
        {"Smithsonian Astrophysical Observation", "SAO 159860"},
        {"Wilson Evans Batten Catalogue", "WEB 13548"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.02291666),
        dec: Angle.Degrees(-20.05633793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17915"},
        {"Smithsonian Astrophysical Observation", "SAO 168867"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.46654876),
        dec: Angle.Degrees(-20.05484430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140528"},
        {"Hipparcos Number", "HIP 77116"},
        {"Smithsonian Astrophysical Observation", "SAO 159475"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.19157889),
        dec: Angle.Degrees(-20.05349323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32309"},
        {"Hipparcos Number", "HIP 23362"},
        {"Geneva Identification System", "GEN# +1.00032309"},
        {"Smithsonian Astrophysical Observation", "SAO 169981"},
        {"Wilson Evans Batten Catalogue", "WEB 4537"},
    },
    visualMagnitude: 4.91,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.35649111),
        dec: Angle.Degrees(-20.05188078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8177",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8177"},
        {"Smithsonian Astrophysical Observation", "SAO 167267"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.28390914),
        dec: Angle.Degrees(-20.05187466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8181",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8181"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.28973108),
        dec: Angle.Degrees(-20.05182413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26535"},
        {"Hipparcos Number", "HIP 19533"},
        {"Smithsonian Astrophysical Observation", "SAO 169201"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.76895486),
        dec: Angle.Degrees(-20.05143468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46394"},
        {"Hipparcos Number", "HIP 31166"},
        {"Smithsonian Astrophysical Observation", "SAO 171905"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.09563435),
        dec: Angle.Degrees(-20.05005385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36951",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36951"},
    },
    visualMagnitude: 11.21,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.94924270),
        dec: Angle.Degrees(-20.04838448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20941"},
        {"Hipparcos Number", "HIP 15678"},
        {"Smithsonian Astrophysical Observation", "SAO 168488"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.49997081),
        dec: Angle.Degrees(-20.04634996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225045"},
        {"Hipparcos Number", "HIP 238"},
        {"Geneva Identification System", "GEN# +1.00225045"},
        {"Smithsonian Astrophysical Observation", "SAO 166014"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.73927410),
        dec: Angle.Degrees(-20.04607402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224077"},
        {"Hipparcos Number", "HIP 117910"},
        {"Geneva Identification System", "GEN# +1.00224077"},
        {"Smithsonian Astrophysical Observation", "SAO 192233"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.74240273),
        dec: Angle.Degrees(-20.04569397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147009"},
        {"Hipparcos Number", "HIP 80019"},
        {"Geneva Identification System", "GEN# +1.00147009"},
        {"Smithsonian Astrophysical Observation", "SAO 159858"},
        {"Wilson Evans Batten Catalogue", "WEB 13547"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.01661553),
        dec: Angle.Degrees(-20.04480644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11298"},
        {"Hipparcos Number", "HIP 8573"},
        {"Smithsonian Astrophysical Observation", "SAO 167342"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.63788012),
        dec: Angle.Degrees(-20.04378760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15220"},
        {"Hipparcos Number", "HIP 11381"},
        {"Fundamental Katalog 5th Edition", "FK5 2167"},
        {"Geneva Identification System", "GEN# +1.00015220"},
        {"Smithsonian Astrophysical Observation", "SAO 167795"},
        {"Wilson Evans Batten Catalogue", "WEB 2375"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.64651715),
        dec: Angle.Degrees(-20.04286354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178521"},
        {"Hipparcos Number", "HIP 94127"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.41266706),
        dec: Angle.Degrees(-20.04108997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25118",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25118"},
        {"Smithsonian Astrophysical Observation", "SAO 170359"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.65227895),
        dec: Angle.Degrees(-20.04078636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105127"},
        {"Hipparcos Number", "HIP 59036"},
        {"Smithsonian Astrophysical Observation", "SAO 157083"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.55804037),
        dec: Angle.Degrees(-20.04005064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15017"},
        {"Hipparcos Number", "HIP 11241"},
        {"Smithsonian Astrophysical Observation", "SAO 167763"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.17354217),
        dec: Angle.Degrees(-20.03946141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40170"},
        {"Hipparcos Number", "HIP 28107"},
        {"Geneva Identification System", "GEN# +1.00040170"},
        {"Smithsonian Astrophysical Observation", "SAO 171038"},
        {"Wilson Evans Batten Catalogue", "WEB 5501"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.10615343),
        dec: Angle.Degrees(-20.03743398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147700"},
        {"Hipparcos Number", "HIP 80343"},
        {"Geneva Identification System", "GEN# +1.00147700"},
        {"Smithsonian Astrophysical Observation", "SAO 159892"},
        {"Wilson Evans Batten Catalogue", "WEB 13594"},
    },
    visualMagnitude: 4.48,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.02582204),
        dec: Angle.Degrees(-20.03721137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93997"},
        {"Hipparcos Number", "HIP 53012"},
        {"Smithsonian Astrophysical Observation", "SAO 156267"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.68519700),
        dec: Angle.Degrees(-20.03575174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224619"},
        {"Hipparcos Number", "HIP 118278"},
        {"Cincinnati Publication", "Ci 20 1468"},
        {"Cincinnati Publication 2", "Ci 18 3146"},
        {"Geneva Identification System", "GEN# +1.00224619"},
        {"Smithsonian Astrophysical Observation", "SAO 192293"},
        {"Wilson Evans Batten Catalogue", "WEB 20789"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.86715308),
        dec: Angle.Degrees(-20.03402321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 506.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -284.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11739"},
        {"Geneva Identification System", "GEN# -0.02000470"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.87785219),
        dec: Angle.Degrees(-20.02828076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20069"},
        {"Hipparcos Number", "HIP 14970"},
        {"Smithsonian Astrophysical Observation", "SAO 168384"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.25001016),
        dec: Angle.Degrees(-20.02709406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211363"},
        {"Hipparcos Number", "HIP 110012"},
        {"Smithsonian Astrophysical Observation", "SAO 191019"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.22907028),
        dec: Angle.Degrees(-20.02534859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120424"},
        {"Hipparcos Number", "HIP 67474"},
        {"Smithsonian Astrophysical Observation", "SAO 158183"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.40976063),
        dec: Angle.Degrees(-20.02475002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38882"},
        {"Hipparcos Number", "HIP 27400"},
        {"Geneva Identification System", "GEN# +1.00038882"},
        {"Smithsonian Astrophysical Observation", "SAO 170854"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.04274493),
        dec: Angle.Degrees(-20.02366448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35851"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.87176867),
        dec: Angle.Degrees(-20.02258203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -335.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41109"},
        {"Hipparcos Number", "HIP 28606"},
        {"Smithsonian Astrophysical Observation", "SAO 171157"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.56332799),
        dec: Angle.Degrees(-20.02085286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20291"},
        {"Hipparcos Number", "HIP 15147"},
        {"Fundamental Katalog 5th Edition", "FK5 2229"},
        {"Geneva Identification System", "GEN# +1.00020291"},
        {"Smithsonian Astrophysical Observation", "SAO 168410"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.81310654),
        dec: Angle.Degrees(-20.01902759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219243"},
        {"Hipparcos Number", "HIP 114740"},
        {"Smithsonian Astrophysical Observation", "SAO 191746"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.64643955),
        dec: Angle.Degrees(-20.01862897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29275"},
        {"Hipparcos Number", "HIP 21418"},
        {"Geneva Identification System", "GEN# +1.00029275"},
        {"Smithsonian Astrophysical Observation", "SAO 169594"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.95850639),
        dec: Angle.Degrees(-20.01510975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30213"},
        {"Hipparcos Number", "HIP 22064"},
        {"Geneva Identification System", "GEN# +1.00030213"},
        {"Smithsonian Astrophysical Observation", "SAO 169719"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.19302303),
        dec: Angle.Degrees(-20.01412926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131586"},
        {"Hipparcos Number", "HIP 72994"},
        {"Smithsonian Astrophysical Observation", "SAO 158890"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.77368917),
        dec: Angle.Degrees(-20.01337788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7380"},
        {"Hipparcos Number", "HIP 5727"},
        {"Smithsonian Astrophysical Observation", "SAO 166883"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.41630476),
        dec: Angle.Degrees(-20.01314731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49574"},
        {"Hipparcos Number", "HIP 32616"},
        {"Smithsonian Astrophysical Observation", "SAO 151950"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.07873147),
        dec: Angle.Degrees(-20.01300206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19676"},
        {"Hipparcos Number", "HIP 14678"},
        {"Smithsonian Astrophysical Observation", "SAO 168339"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.40368435),
        dec: Angle.Degrees(-20.01243034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145275"},
        {"Hipparcos Number", "HIP 79286"},
        {"Smithsonian Astrophysical Observation", "SAO 159753"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.72555202),
        dec: Angle.Degrees(-20.01180046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102225",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102225"},
        {"Geneva Identification System", "GEN# -0.02006008"},
        {"Smithsonian Astrophysical Observation", "SAO 189600"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.70324403),
        dec: Angle.Degrees(-20.01092219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174134"},
        {"Hipparcos Number", "HIP 92399"},
        {"Geneva Identification System", "GEN# +1.00174134"},
        {"Smithsonian Astrophysical Observation", "SAO 187326"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.44474689),
        dec: Angle.Degrees(-20.01067792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214671"},
        {"Hipparcos Number", "HIP 111908"},
        {"Smithsonian Astrophysical Observation", "SAO 191315"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.02844740),
        dec: Angle.Degrees(-20.00972948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208011"},
        {"Hipparcos Number", "HIP 108072"},
        {"Smithsonian Astrophysical Observation", "SAO 190716"},
        {"Wilson Evans Batten Catalogue", "WEB 19483"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.44356729),
        dec: Angle.Degrees(-20.00744955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138414"},
        {"Hipparcos Number", "HIP 76104"},
        {"Smithsonian Astrophysical Observation", "SAO 159328"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.14302652),
        dec: Angle.Degrees(-20.00723688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162010"},
        {"Hipparcos Number", "HIP 87246"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.39840757),
        dec: Angle.Degrees(-20.00667876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43768",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43768"},
        {"Renson", "Renson 21420"},
        {"Smithsonian Astrophysical Observation", "SAO 154739"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.73786647),
        dec: Angle.Degrees(-20.00625393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137463"},
        {"Hipparcos Number", "HIP 75607"},
        {"Geneva Identification System", "GEN# +1.00137463"},
        {"Smithsonian Astrophysical Observation", "SAO 159263"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.70979006),
        dec: Angle.Degrees(-20.00507919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44560"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.19238732),
        dec: Angle.Degrees(-20.00441308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208823"},
        {"Hipparcos Number", "HIP 108545"},
        {"Smithsonian Astrophysical Observation", "SAO 190795"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.82754680),
        dec: Angle.Degrees(-20.00433454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115694"},
        {"Hipparcos Number", "HIP 64981"},
        {"Fundamental Katalog 5th Edition", "FK5 5176"},
        {"Smithsonian Astrophysical Observation", "SAO 157850"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.76963197),
        dec: Angle.Degrees(-20.00350098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15996"},
        {"Hipparcos Number", "HIP 11907"},
        {"Geneva Identification System", "GEN# +1.00015996"},
        {"Smithsonian Astrophysical Observation", "SAO 167878"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.41768954),
        dec: Angle.Degrees(-20.00172697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135639"},
        {"Hipparcos Number", "HIP 74760"},
        {"Smithsonian Astrophysical Observation", "SAO 159144"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.18834926),
        dec: Angle.Degrees(-20.00134008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79581"},
        {"Hipparcos Number", "HIP 45346"},
        {"Geneva Identification System", "GEN# +1.00079581"},
        {"Smithsonian Astrophysical Observation", "SAO 155023"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.60938881),
        dec: Angle.Degrees(-19.99957941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58842"},
        {"Hipparcos Number", "HIP 36128"},
        {"Smithsonian Astrophysical Observation", "SAO 152880"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.62992570),
        dec: Angle.Degrees(-19.99928882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59006"},
        {"Hipparcos Number", "HIP 36195"},
        {"Smithsonian Astrophysical Observation", "SAO 152898"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.81289486),
        dec: Angle.Degrees(-19.99854636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161504"},
        {"Hipparcos Number", "HIP 87005"},
        {"Geneva Identification System", "GEN# +1.00161504"},
        {"Smithsonian Astrophysical Observation", "SAO 160813"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.67516509),
        dec: Angle.Degrees(-19.99835072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13988"},
        {"Hipparcos Number", "HIP 10523"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.90289922),
        dec: Angle.Degrees(-19.99806768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14175"},
        {"Hipparcos Number", "HIP 10658"},
        {"Smithsonian Astrophysical Observation", "SAO 167679"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.29599860),
        dec: Angle.Degrees(-19.99689775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159087"},
        {"Hipparcos Number", "HIP 85916"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.35937962),
        dec: Angle.Degrees(-19.99452352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201237"},
        {"Hipparcos Number", "HIP 104376"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.17407815),
        dec: Angle.Degrees(-19.99427784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2288"},
        {"Hipparcos Number", "HIP 2098"},
        {"Geneva Identification System", "GEN# +1.00002288"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.64037617),
        dec: Angle.Degrees(-19.99342015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56013"},
        {"Hipparcos Number", "HIP 35004"},
        {"Celescope Catalog", "CEL 1701"},
        {"Fundamental Katalog 5th Edition", "FK5 4653"},
        {"Geneva Identification System", "GEN# +1.00056013J"},
        {"Smithsonian Astrophysical Observation", "SAO 152608"},
        {"Wilson Evans Batten Catalogue", "WEB 7001"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.63426570),
        dec: Angle.Degrees(-19.99112977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117819"},
        {"Hipparcos Number", "HIP 66114"},
        {"Geneva Identification System", "GEN# +1.00117819"},
        {"Smithsonian Astrophysical Observation", "SAO 158003"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.29749995),
        dec: Angle.Degrees(-19.99015301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144689"},
        {"Hipparcos Number", "HIP 79030"},
        {"Smithsonian Astrophysical Observation", "SAO 159719"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.95929885),
        dec: Angle.Degrees(-19.98941616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26977"},
        {"Hipparcos Number", "HIP 19837"},
        {"Smithsonian Astrophysical Observation", "SAO 169265"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.79737254),
        dec: Angle.Degrees(-19.98910962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192351"},
        {"Hipparcos Number", "HIP 99810"},
        {"Smithsonian Astrophysical Observation", "SAO 189064"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.76902850),
        dec: Angle.Degrees(-19.98909621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177819"},
        {"Hipparcos Number", "HIP 93869"},
        {"Geneva Identification System", "GEN# +1.00177819"},
        {"Smithsonian Astrophysical Observation", "SAO 187689"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.75036646),
        dec: Angle.Degrees(-19.98485211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63358"},
        {"Hipparcos Number", "HIP 38038"},
        {"Celescope Catalog", "CEL 2032"},
        {"Geneva Identification System", "GEN# +1.00063358"},
        {"Smithsonian Astrophysical Observation", "SAO 153411"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.94175797),
        dec: Angle.Degrees(-19.98473138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93870"},
    },
    visualMagnitude: 11.06,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.75470985),
        dec: Angle.Degrees(-19.98465155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 575"},
        {"Hipparcos Number", "HIP 833"},
        {"Geneva Identification System", "GEN# +1.00000575"},
        {"Smithsonian Astrophysical Observation", "SAO 166091"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.54331677),
        dec: Angle.Degrees(-19.98355516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84809",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10466 A"},
        {"Henry Draper", "HD 156720"},
        {"Hipparcos Number", "HIP 84809"},
        {"Smithsonian Astrophysical Observation", "SAO 160464"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.00645983),
        dec: Angle.Degrees(-19.98135516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79482"},
        {"Hipparcos Number", "HIP 45293"},
        {"Smithsonian Astrophysical Observation", "SAO 155019"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.45558806),
        dec: Angle.Degrees(-19.97986677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16212",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2568 A"},
        {"Hipparcos Number", "HIP 16212"},
        {"Smithsonian Astrophysical Observation", "SAO 168572"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.22556413),
        dec: Angle.Degrees(-19.97974847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15468"},
        {"Hipparcos Number", "HIP 11565"},
        {"Geneva Identification System", "GEN# +1.00015468A"},
        {"Smithsonian Astrophysical Observation", "SAO 167819"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.25546592),
        dec: Angle.Degrees(-19.97961837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 612.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 186.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86031"},
        {"Hipparcos Number", "HIP 48664"},
        {"Smithsonian Astrophysical Observation", "SAO 155594"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.86819449),
        dec: Angle.Degrees(-19.97921629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127321"},
        {"Hipparcos Number", "HIP 70991"},
        {"Smithsonian Astrophysical Observation", "SAO 158609"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.80144225),
        dec: Angle.Degrees(-19.97767526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75062"},
    },
    visualMagnitude: 11.18,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.08552441),
        dec: Angle.Degrees(-19.97559706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 121.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103649"},
        {"Hipparcos Number", "HIP 58186"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.00277887),
        dec: Angle.Degrees(-19.97471505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159950"},
        {"Hipparcos Number", "HIP 86312"},
        {"Smithsonian Astrophysical Observation", "SAO 160707"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.53584218),
        dec: Angle.Degrees(-19.97442647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16216",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2568 BC"},
        {"Hipparcos Number", "HIP 16216"},
    },
    visualMagnitude: 11.41,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)28, 55.2900),
        dec: Angle.DegreesMinutesSeconds((int)-19, (int)58, 26.400)
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
    primaryId: "HIP 72871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131337"},
        {"Hipparcos Number", "HIP 72871"},
        {"Geneva Identification System", "GEN# +1.00131337"},
        {"Smithsonian Astrophysical Observation", "SAO 158880"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.41713599),
        dec: Angle.Degrees(-19.97247564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103116"},
        {"Hipparcos Number", "HIP 57887"},
        {"Smithsonian Astrophysical Observation", "SAO 156949"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.08366184),
        dec: Angle.Degrees(-19.97161391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70518",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9258 A"},
        {"Henry Draper", "HD 126367"},
        {"Hipparcos Number", "HIP 70518"},
        {"Geneva Identification System", "GEN# +1.00126367"},
        {"Smithsonian Astrophysical Observation", "SAO 158558"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.37460988),
        dec: Angle.Degrees(-19.96995233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88235",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10969 A"},
        {"Henry Draper", "HD 164263"},
        {"Hipparcos Number", "HIP 88235"},
        {"Smithsonian Astrophysical Observation", "SAO 160995"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.27471222),
        dec: Angle.Degrees(-19.96712478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43955"},
        {"Hipparcos Number", "HIP 29941"},
        {"Fundamental Katalog 5th Edition", "FK5 2483"},
        {"Geneva Identification System", "GEN# +1.00043955"},
        {"Smithsonian Astrophysical Observation", "SAO 151334"},
        {"Wilson Evans Batten Catalogue", "WEB 5936"},
    },
    visualMagnitude: 5.51,
    bvColour: -0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.55721559),
        dec: Angle.Degrees(-19.96699189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70513",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9258 BC"},
        {"Henry Draper", "HD 126366"},
        {"Hipparcos Number", "HIP 70513"},
        {"Geneva Identification System", "GEN# +1.00126366"},
        {"Renson", "Renson 36020"},
        {"Smithsonian Astrophysical Observation", "SAO 158556"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.36522325),
        dec: Angle.Degrees(-19.96581224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137054"},
        {"Hipparcos Number", "HIP 75414"},
        {"Smithsonian Astrophysical Observation", "SAO 159237"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.12492599),
        dec: Angle.Degrees(-19.96373489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125048"},
        {"Hipparcos Number", "HIP 69828"},
        {"Fundamental Katalog 5th Edition", "FK5 5262"},
        {"Smithsonian Astrophysical Observation", "SAO 158468"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.36550830),
        dec: Angle.Degrees(-19.96370811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219545"},
        {"Hipparcos Number", "HIP 114918"},
        {"Geneva Identification System", "GEN# +1.00219545"},
        {"Renson", "Renson 60290"},
        {"Smithsonian Astrophysical Observation", "SAO 191786"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.15956182),
        dec: Angle.Degrees(-19.96182601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74174"},
    },
    visualMagnitude: 11.43,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.33536779),
        dec: Angle.Degrees(-19.96173659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -498.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192773"},
        {"Hipparcos Number", "HIP 100000"},
        {"Smithsonian Astrophysical Observation", "SAO 189104"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.31547143),
        dec: Angle.Degrees(-19.96078578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59406"},
    },
    visualMagnitude: 11.67,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.79954834),
        dec: Angle.Degrees(-19.96012739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4470"},
        {"Hipparcos Number", "HIP 3646"},
        {"Geneva Identification System", "GEN# +1.00004470"},
        {"Smithsonian Astrophysical Observation", "SAO 166566"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.67264241),
        dec: Angle.Degrees(-19.95579256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46833"},
        {"Hipparcos Number", "HIP 31384"},
        {"Smithsonian Astrophysical Observation", "SAO 151661"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.69215318),
        dec: Angle.Degrees(-19.95300539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8129"},
        {"Hipparcos Number", "HIP 6273"},
        {"Geneva Identification System", "GEN# +1.00008129"},
        {"Smithsonian Astrophysical Observation", "SAO 166973"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.12483587),
        dec: Angle.Degrees(-19.94845905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37162"},
        {"Hipparcos Number", "HIP 26285"},
        {"Smithsonian Astrophysical Observation", "SAO 150595"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.94897220),
        dec: Angle.Degrees(-19.94678222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147195"},
        {"Hipparcos Number", "HIP 80109"},
        {"Geneva Identification System", "GEN# +1.00147195"},
        {"Smithsonian Astrophysical Observation", "SAO 159872"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.28465202),
        dec: Angle.Degrees(-19.94447528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2080"},
        {"Hipparcos Number", "HIP 1969"},
        {"Geneva Identification System", "GEN# +1.00002080"},
        {"Smithsonian Astrophysical Observation", "SAO 166253"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.23394803),
        dec: Angle.Degrees(-19.94367827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115202"},
        {"Hipparcos Number", "HIP 64725"},
        {"Geneva Identification System", "GEN# +1.00115202"},
        {"Smithsonian Astrophysical Observation", "SAO 157823"},
        {"Wilson Evans Batten Catalogue", "WEB 11443"},
    },
    visualMagnitude: 5.21,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.99409266),
        dec: Angle.Degrees(-19.94282246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 304.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128665"},
        {"Hipparcos Number", "HIP 71614"},
        {"Geneva Identification System", "GEN# +1.00128665"},
        {"Smithsonian Astrophysical Observation", "SAO 158694"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.69536536),
        dec: Angle.Degrees(-19.94150949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149330"},
        {"Hipparcos Number", "HIP 81173"},
        {"Smithsonian Astrophysical Observation", "SAO 159987"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.69810252),
        dec: Angle.Degrees(-19.94089492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119981"},
        {"Hipparcos Number", "HIP 67248"},
        {"Smithsonian Astrophysical Observation", "SAO 158158"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.74100131),
        dec: Angle.Degrees(-19.94062235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122681"},
        {"Hipparcos Number", "HIP 68693"},
        {"Smithsonian Astrophysical Observation", "SAO 158314"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.91735890),
        dec: Angle.Degrees(-19.94026235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41877"},
        {"Hipparcos Number", "HIP 28975"},
        {"Smithsonian Astrophysical Observation", "SAO 151130"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.71945773),
        dec: Angle.Degrees(-19.93971318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10430"},
        {"Hipparcos Number", "HIP 7875"},
        {"Smithsonian Astrophysical Observation", "SAO 167230"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.32737330),
        dec: Angle.Degrees(-19.93838099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111082"},
        {"Hipparcos Number", "HIP 62369"},
        {"Smithsonian Astrophysical Observation", "SAO 157505"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.73519370),
        dec: Angle.Degrees(-19.93567545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189004"},
        {"Hipparcos Number", "HIP 98329"},
        {"Smithsonian Astrophysical Observation", "SAO 188777"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.66619603),
        dec: Angle.Degrees(-19.93522070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58955"},
        {"Hipparcos Number", "HIP 36181"},
        {"Geneva Identification System", "GEN# +1.00058955"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.76833676),
        dec: Angle.Degrees(-19.93458200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2161"},
        {"Hipparcos Number", "HIP 2017"},
        {"Geneva Identification System", "GEN# +1.00002161"},
        {"Smithsonian Astrophysical Observation", "SAO 166259"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.40297399),
        dec: Angle.Degrees(-19.93402692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175043"},
        {"Hipparcos Number", "HIP 92776"},
        {"Geneva Identification System", "GEN# +2.67160046"},
        {"Smithsonian Astrophysical Observation", "SAO 161951"},
        {"New General Catalogue", "NGC 6716 46"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.57502661),
        dec: Angle.Degrees(-19.93297500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63270"},
        {"Hipparcos Number", "HIP 38000"},
        {"Celescope Catalog", "CEL 2028"},
        {"Geneva Identification System", "GEN# +1.00063270"},
        {"Smithsonian Astrophysical Observation", "SAO 153397"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.82775631),
        dec: Angle.Degrees(-19.93228103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114946"},
        {"Hipparcos Number", "HIP 64577"},
        {"Geneva Identification System", "GEN# +1.00114946"},
        {"Smithsonian Astrophysical Observation", "SAO 157806"},
        {"Wilson Evans Batten Catalogue", "WEB 11423"},
    },
    visualMagnitude: 5.31,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.54570701),
        dec: Angle.Degrees(-19.93133468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 159.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168522"},
        {"Hipparcos Number", "HIP 89917"},
        {"Smithsonian Astrophysical Observation", "SAO 161364"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.21659314),
        dec: Angle.Degrees(-19.93128425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1666"},
        {"Hipparcos Number", "HIP 1666"},
        {"Geneva Identification System", "GEN# +1.00001666"},
        {"Smithsonian Astrophysical Observation", "SAO 166202"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.21810349),
        dec: Angle.Degrees(-19.93107970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175091"},
        {"Hipparcos Number", "HIP 92792"},
        {"Geneva Identification System", "GEN# +2.67160003"},
        {"Smithsonian Astrophysical Observation", "SAO 161956"},
        {"New General Catalogue", "NGC 6716 3"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.62602305),
        dec: Angle.Degrees(-19.93005976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141494"},
        {"Hipparcos Number", "HIP 77561"},
        {"Smithsonian Astrophysical Observation", "SAO 159521"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.52655895),
        dec: Angle.Degrees(-19.92992972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105989"},
        {"Hipparcos Number", "HIP 59465"},
        {"Geneva Identification System", "GEN# +1.00105989"},
        {"Smithsonian Astrophysical Observation", "SAO 157137"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.95556463),
        dec: Angle.Degrees(-19.92928270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129138"},
        {"Hipparcos Number", "HIP 71816"},
        {"Smithsonian Astrophysical Observation", "SAO 158731"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.35580489),
        dec: Angle.Degrees(-19.92792409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37325"},
        {"Hipparcos Number", "HIP 26375"},
        {"Smithsonian Astrophysical Observation", "SAO 150618"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.24880815),
        dec: Angle.Degrees(-19.92791765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178248"},
        {"Hipparcos Number", "HIP 94021"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.13611917),
        dec: Angle.Degrees(-19.92487746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150453"},
        {"Hipparcos Number", "HIP 81754"},
        {"Geneva Identification System", "GEN# +1.00150453"},
        {"Smithsonian Astrophysical Observation", "SAO 160052"},
        {"Wilson Evans Batten Catalogue", "WEB 13817"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.47364200),
        dec: Angle.Degrees(-19.92447879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54639"},
        {"Hipparcos Number", "HIP 34490"},
        {"Smithsonian Astrophysical Observation", "SAO 152462"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.20539259),
        dec: Angle.Degrees(-19.92328146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222894"},
        {"Hipparcos Number", "HIP 117128"},
        {"Smithsonian Astrophysical Observation", "SAO 192120"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.18391029),
        dec: Angle.Degrees(-19.92168086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29184"},
        {"Hipparcos Number", "HIP 21363"},
        {"Geneva Identification System", "GEN# +1.00029184"},
        {"Smithsonian Astrophysical Observation", "SAO 169584"},
        {"Wilson Evans Batten Catalogue", "WEB 4103"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.75269677),
        dec: Angle.Degrees(-19.92152085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199948"},
        {"Hipparcos Number", "HIP 103712"},
        {"Smithsonian Astrophysical Observation", "SAO 189931"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.22658034),
        dec: Angle.Degrees(-19.91762376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74063"},
        {"Hipparcos Number", "HIP 42620"},
        {"Smithsonian Astrophysical Observation", "SAO 154545"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.28470003),
        dec: Angle.Degrees(-19.91585185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14628"},
        {"Hipparcos Number", "HIP 10963"},
        {"Geneva Identification System", "GEN# +1.00014628"},
        {"Smithsonian Astrophysical Observation", "SAO 167722"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.30736058),
        dec: Angle.Degrees(-19.91534674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120793"},
        {"Henry Draper 2", "HD 120794"},
        {"Hipparcos Number", "HIP 67694"},
        {"Smithsonian Astrophysical Observation", "SAO 158205"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.00277485),
        dec: Angle.Degrees(-19.91408535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139364"},
        {"Hipparcos Number", "HIP 76582"},
        {"Geneva Identification System", "GEN# +1.00139364"},
        {"Smithsonian Astrophysical Observation", "SAO 159402"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.60617038),
        dec: Angle.Degrees(-19.91292776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193190"},
        {"Hipparcos Number", "HIP 100216"},
        {"Smithsonian Astrophysical Observation", "SAO 189145"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.88830101),
        dec: Angle.Degrees(-19.91276107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193242"},
        {"Hipparcos Number", "HIP 100248"},
        {"Geneva Identification System", "GEN# +1.00193242"},
        {"Smithsonian Astrophysical Observation", "SAO 189153"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.97627871),
        dec: Angle.Degrees(-19.91269925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67688"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.99977380),
        dec: Angle.Degrees(-19.91072841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18943"},
        {"Hipparcos Number", "HIP 14138"},
        {"Smithsonian Astrophysical Observation", "SAO 168246"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.57604816),
        dec: Angle.Degrees(-19.90837132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 229.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99056"},
        {"Hipparcos Number", "HIP 55639"},
        {"Smithsonian Astrophysical Observation", "SAO 156650"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.97088183),
        dec: Angle.Degrees(-19.90835444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1546"},
        {"Geneva Identification System", "GEN# +9.80266087"},
    },
    visualMagnitude: 12.46,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.82072704),
        dec: Angle.Degrees(-19.90828575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 525.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160806"},
        {"Hipparcos Number", "HIP 86686"},
        {"Smithsonian Astrophysical Observation", "SAO 160768"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.67525044),
        dec: Angle.Degrees(-19.90688860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130563"},
        {"Hipparcos Number", "HIP 72501"},
        {"Smithsonian Astrophysical Observation", "SAO 158822"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.36520434),
        dec: Angle.Degrees(-19.90359264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120544"},
        {"Hipparcos Number", "HIP 67555"},
        {"Geneva Identification System", "GEN# +1.00120544"},
        {"Smithsonian Astrophysical Observation", "SAO 158192"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.64423741),
        dec: Angle.Degrees(-19.89791575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55395"},
        {"Hipparcos Number", "HIP 34771"},
        {"Celescope Catalog", "CEL 1658"},
        {"Geneva Identification System", "GEN# +1.00055395"},
        {"Renson", "Renson 15070"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.97292342),
        dec: Angle.Degrees(-19.89726785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107388"},
        {"Hipparcos Number", "HIP 60207"},
        {"Smithsonian Astrophysical Observation", "SAO 157223"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.19605519),
        dec: Angle.Degrees(-19.89591331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -357.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211083"},
        {"Hipparcos Number", "HIP 109866"},
        {"Smithsonian Astrophysical Observation", "SAO 190998"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.77087377),
        dec: Angle.Degrees(-19.89557032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82809"},
        {"Hipparcos Number", "HIP 46927"},
        {"Geneva Identification System", "GEN# +1.00082809"},
        {"Smithsonian Astrophysical Observation", "SAO 155296"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.47101335),
        dec: Angle.Degrees(-19.89553203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5077"},
        {"Hipparcos Number", "HIP 4091"},
        {"Smithsonian Astrophysical Observation", "SAO 166643"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.13036956),
        dec: Angle.Degrees(-19.89544701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91963"},
        {"Hipparcos Number", "HIP 51956"},
        {"Smithsonian Astrophysical Observation", "SAO 156102"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.20197041),
        dec: Angle.Degrees(-19.89301045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67140"},
        {"Hipparcos Number", "HIP 39634"},
        {"Smithsonian Astrophysical Observation", "SAO 153833"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.49514930),
        dec: Angle.Degrees(-19.89255020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163571"},
        {"Hipparcos Number", "HIP 87918"},
        {"Smithsonian Astrophysical Observation", "SAO 160938"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.39292547),
        dec: Angle.Degrees(-19.88955444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210281"},
        {"Hipparcos Number", "HIP 109391"},
        {"Smithsonian Astrophysical Observation", "SAO 190926"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.42428860),
        dec: Angle.Degrees(-19.88922328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220913"},
        {"Hipparcos Number", "HIP 115812"},
        {"Smithsonian Astrophysical Observation", "SAO 191925"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.93100708),
        dec: Angle.Degrees(-19.88753224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162836"},
        {"Hipparcos Number", "HIP 87606"},
        {"Smithsonian Astrophysical Observation", "SAO 160891"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.44624162),
        dec: Angle.Degrees(-19.88723967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16237"},
        {"Hipparcos Number", "HIP 12088"},
        {"Smithsonian Astrophysical Observation", "SAO 167899"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.95363997),
        dec: Angle.Degrees(-19.88626959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181512"},
        {"Hipparcos Number", "HIP 95142"},
        {"Smithsonian Astrophysical Observation", "SAO 162505"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.34985279),
        dec: Angle.Degrees(-19.88440247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27285"},
        {"Hipparcos Number", "HIP 20033"},
        {"Renson", "Renson 6990"},
        {"Smithsonian Astrophysical Observation", "SAO 169309"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.45060855),
        dec: Angle.Degrees(-19.88314890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66732"},
        {"Geneva Identification System", "GEN# +6.20056036"},
    },
    visualMagnitude: 11.57,
    bvColour: -0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.17222133),
        dec: Angle.Degrees(-19.88204430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222662"},
        {"Hipparcos Number", "HIP 116973"},
        {"Geneva Identification System", "GEN# +1.00222662"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.68320047),
        dec: Angle.Degrees(-19.88190179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -244.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97348",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12909 AB"},
        {"Henry Draper", "HD 186752"},
        {"Hipparcos Number", "HIP 97348"},
        {"Smithsonian Astrophysical Observation", "SAO 188563"},
        {"Wilson Evans Batten Catalogue", "WEB 17107"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.77824640),
        dec: Angle.Degrees(-19.88059098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56633"},
        {"Hipparcos Number", "HIP 35250"},
        {"Smithsonian Astrophysical Observation", "SAO 152666"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.25429884),
        dec: Angle.Degrees(-19.87918600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35245"},
        {"Hipparcos Number", "HIP 25115"},
    },
    visualMagnitude: 7.92,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.64702425),
        dec: Angle.Degrees(-19.87842009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49183"},
        {"Hipparcos Number", "HIP 32455"},
        {"Smithsonian Astrophysical Observation", "SAO 151907"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.60759109),
        dec: Angle.Degrees(-19.87790100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151376"},
        {"Hipparcos Number", "HIP 82218"},
        {"Smithsonian Astrophysical Observation", "SAO 160100"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.94728015),
        dec: Angle.Degrees(-19.87547515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112005"},
        {"Hipparcos Number", "HIP 62900"},
        {"Smithsonian Astrophysical Observation", "SAO 157575"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.37217346),
        dec: Angle.Degrees(-19.87371134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180631"},
        {"Hipparcos Number", "HIP 94845"},
        {"Smithsonian Astrophysical Observation", "SAO 162423"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.48266019),
        dec: Angle.Degrees(-19.87202789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218278"},
        {"Hipparcos Number", "HIP 114137"},
        {"Smithsonian Astrophysical Observation", "SAO 191657"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.73444579),
        dec: Angle.Degrees(-19.87090480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108044"},
        {"Hipparcos Number", "HIP 60565"},
        {"Smithsonian Astrophysical Observation", "SAO 157271"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.22606749),
        dec: Angle.Degrees(-19.87062299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98888"},
        {"Hipparcos Number", "HIP 55553"},
        {"Geneva Identification System", "GEN# +1.00098888"},
        {"Smithsonian Astrophysical Observation", "SAO 156638"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.68528992),
        dec: Angle.Degrees(-19.86744184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89911"},
        {"Hipparcos Number", "HIP 50790"},
        {"Geneva Identification System", "GEN# +9.00050027"},
        {"Geneva Identification System 2", "GEN# +9.05001440"},
        {"Renson", "Renson 25846"},
        {"Smithsonian Astrophysical Observation", "SAO 155935"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.55399807),
        dec: Angle.Degrees(-19.86659301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175141"},
        {"Hipparcos Number", "HIP 92823"},
        {"Geneva Identification System", "GEN# +2.67160055"},
        {"Wilson Evans Batten Catalogue", "WEB 16064"},
        {"New General Catalogue", "NGC 6716 55"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.69715713),
        dec: Angle.Degrees(-19.86356156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155845"},
        {"Hipparcos Number", "HIP 84367"},
        {"Geneva Identification System", "GEN# +1.00155845"},
        {"Smithsonian Astrophysical Observation", "SAO 160397"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.72314538),
        dec: Angle.Degrees(-19.86333787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109168"},
        {"Hipparcos Number", "HIP 61235"},
        {"Smithsonian Astrophysical Observation", "SAO 157353"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.21949190),
        dec: Angle.Degrees(-19.86049145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67670"},
        {"Hipparcos Number", "HIP 39852"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.12351992),
        dec: Angle.Degrees(-19.86023209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213863"},
        {"Hipparcos Number", "HIP 111452"},
        {"Geneva Identification System", "GEN# +1.00213863"},
        {"Smithsonian Astrophysical Observation", "SAO 191236"},
        {"Wilson Evans Batten Catalogue", "WEB 19927"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.67483414),
        dec: Angle.Degrees(-19.85978927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37324"},
        {"Hipparcos Number", "HIP 26376"},
        {"Smithsonian Astrophysical Observation", "SAO 150619"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.25081367),
        dec: Angle.Degrees(-19.85836565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189398"},
        {"Hipparcos Number", "HIP 98489"},
        {"Smithsonian Astrophysical Observation", "SAO 163171"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.12899714),
        dec: Angle.Degrees(-19.85706019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35244"},
        {"Hipparcos Number", "HIP 25117"},
        {"Smithsonian Astrophysical Observation", "SAO 150387"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.65144451),
        dec: Angle.Degrees(-19.85497680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5093",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 900 AB"},
        {"Henry Draper", "HD 6451"},
        {"Hipparcos Number", "HIP 5093"},
        {"Geneva Identification System", "GEN# +1.00006451J"},
        {"Renson", "Renson 1650"},
        {"Smithsonian Astrophysical Observation", "SAO 166788"},
        {"Wilson Evans Batten Catalogue", "WEB 1049"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.30479382),
        dec: Angle.Degrees(-19.85496030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200499"},
        {"Hipparcos Number", "HIP 104019"},
        {"Renson", "Renson 55890"},
        {"Smithsonian Astrophysical Observation", "SAO 189986"},
        {"Wilson Evans Batten Catalogue", "WEB 18946"},
    },
    visualMagnitude: 4.82,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.10135259),
        dec: Angle.Degrees(-19.85493122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53695"},
        {"Hipparcos Number", "HIP 34175"},
        {"Celescope Catalog", "CEL 1565"},
        {"Geneva Identification System", "GEN# +1.00053695"},
        {"Renson", "Renson 14747"},
        {"Smithsonian Astrophysical Observation", "SAO 152352"},
    },
    visualMagnitude: 9.21,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.31616543),
        dec: Angle.Degrees(-19.85423706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30622"},
        {"Hipparcos Number", "HIP 22315"},
        {"Smithsonian Astrophysical Observation", "SAO 149899"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.09750749),
        dec: Angle.Degrees(-19.85236543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90684"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.54392339),
        dec: Angle.Degrees(-19.85163300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203040"},
        {"Hipparcos Number", "HIP 105341"},
        {"Cincinnati Publication", "Ci 20 1278"},
        {"Geneva Identification System", "GEN# +1.00203040"},
        {"Smithsonian Astrophysical Observation", "SAO 190243"},
        {"Wilson Evans Batten Catalogue", "WEB 19133"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.05803606),
        dec: Angle.Degrees(-19.85053177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -721.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2695"},
        {"Hipparcos Number", "HIP 2379"},
        {"Smithsonian Astrophysical Observation", "SAO 166316"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.59004293),
        dec: Angle.Degrees(-19.85035198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40732"},
        {"Hipparcos Number", "HIP 28408"},
        {"Smithsonian Astrophysical Observation", "SAO 151009"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.00188885),
        dec: Angle.Degrees(-19.84869800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114029"},
        {"Hipparcos Number", "HIP 64079"},
        {"Smithsonian Astrophysical Observation", "SAO 157738"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.97445532),
        dec: Angle.Degrees(-19.84783307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89114",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11127 AB"},
        {"Henry Draper", "HD 166393"},
        {"Hipparcos Number", "HIP 89114"},
        {"Geneva Identification System", "GEN# +1.00166393J"},
        {"Smithsonian Astrophysical Observation", "SAO 161153"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.81161273),
        dec: Angle.Degrees(-19.84188262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107387"},
        {"Hipparcos Number", "HIP 60208"},
        {"Geneva Identification System", "GEN# +1.00107387"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.19862692),
        dec: Angle.Degrees(-19.84155138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143785"},
        {"Hipparcos Number", "HIP 78628"},
        {"Smithsonian Astrophysical Observation", "SAO 159655"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.77944940),
        dec: Angle.Degrees(-19.84070119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44571"},
        {"Hipparcos Number", "HIP 30233"},
        {"Smithsonian Astrophysical Observation", "SAO 151412"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.40784140),
        dec: Angle.Degrees(-19.84041061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67728"},
        {"Hipparcos Number", "HIP 39867"},
        {"Geneva Identification System", "GEN# +1.00067728"},
        {"Smithsonian Astrophysical Observation", "SAO 153881"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.15689015),
        dec: Angle.Degrees(-19.83990351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16702"},
        {"Smithsonian Astrophysical Observation", "SAO 168647"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.73809361),
        dec: Angle.Degrees(-19.83807681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151865"},
        {"Hipparcos Number", "HIP 82443"},
        {"Geneva Identification System", "GEN# +1.00151865J"},
        {"Smithsonian Astrophysical Observation", "SAO 160126"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.73210012),
        dec: Angle.Degrees(-19.83758916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147931"},
        {"Hipparcos Number", "HIP 80464"},
        {"Fundamental Katalog 5th Edition", "FK5 5449"},
        {"Smithsonian Astrophysical Observation", "SAO 159908"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.36144490),
        dec: Angle.Degrees(-19.83720918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4458"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.29256089),
        dec: Angle.Degrees(-19.83284079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217043"},
        {"Hipparcos Number", "HIP 113399"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.48660123),
        dec: Angle.Degrees(-19.82977502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85798"},
        {"Hipparcos Number", "HIP 48536"},
        {"Smithsonian Astrophysical Observation", "SAO 155577"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.48763327),
        dec: Angle.Degrees(-19.82875823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77748"},
        {"Hipparcos Number", "HIP 44483"},
        {"Smithsonian Astrophysical Observation", "SAO 154873"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.94801904),
        dec: Angle.Degrees(-19.82536695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101875"},
        {"Hipparcos Number", "HIP 57161"},
        {"Fundamental Katalog 5th Edition", "FK5 5038"},
        {"Smithsonian Astrophysical Observation", "SAO 156850"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.84579058),
        dec: Angle.Degrees(-19.82324695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9131"},
        {"Hipparcos Number", "HIP 6959"},
        {"Geneva Identification System", "GEN# +1.00009131"},
        {"Smithsonian Astrophysical Observation", "SAO 167085"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.39587104),
        dec: Angle.Degrees(-19.81972703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95533"},
        {"Hipparcos Number", "HIP 53882"},
        {"Smithsonian Astrophysical Observation", "SAO 156404"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.36239773),
        dec: Angle.Degrees(-19.81879531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -270.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35555"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.05389598),
        dec: Angle.Degrees(-19.81865820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24683"},
        {"Hipparcos Number", "HIP 18299"},
        {"Smithsonian Astrophysical Observation", "SAO 149248"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.69248492),
        dec: Angle.Degrees(-19.81144052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122491"},
        {"Hipparcos Number", "HIP 68597"},
        {"Geneva Identification System", "GEN# +1.00122491"},
        {"Smithsonian Astrophysical Observation", "SAO 158300"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.63551155),
        dec: Angle.Degrees(-19.80989127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8958"},
        {"Hipparcos Number", "HIP 6845"},
        {"Smithsonian Astrophysical Observation", "SAO 167064"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.01435437),
        dec: Angle.Degrees(-19.80732882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206317"},
        {"Hipparcos Number", "HIP 107111"},
        {"Smithsonian Astrophysical Observation", "SAO 190556"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.44126060),
        dec: Angle.Degrees(-19.80638155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78820",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9913 AB"},
        {"Henry Draper", "HD 144217"},
        {"Hipparcos Number", "HIP 78820"},
        {"Celescope Catalog", "CEL 4412"},
        {"Fundamental Katalog 5th Edition", "FK5 597"},
        {"Geneva Identification System", "GEN# +1.00144217J"},
        {"Smithsonian Astrophysical Observation", "SAO 159682"},
        {"Wilson Evans Batten Catalogue", "WEB 13322"},
    },
    visualMagnitude: 2.56,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.35931206),
        dec: Angle.Degrees(-19.80539286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21531"},
        {"Hipparcos Number", "HIP 16134"},
        {"Cincinnati Publication", "Ci 20 237"},
        {"Cincinnati Publication 2", "Ci 18 456"},
        {"Geneva Identification System", "GEN# +1.00021531"},
        {"Smithsonian Astrophysical Observation", "SAO 148971"},
        {"Wilson Evans Batten Catalogue", "WEB 3075"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.96697135),
        dec: Angle.Degrees(-19.80522105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 537.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 303.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43470"},
        {"Hipparcos Number", "HIP 29722"},
        {"Geneva Identification System", "GEN# +1.00043470"},
        {"Smithsonian Astrophysical Observation", "SAO 151284"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.91033179),
        dec: Angle.Degrees(-19.80457687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7642"},
        {"Hipparcos Number", "HIP 5915"},
        {"Geneva Identification System", "GEN# +1.00007642"},
        {"Smithsonian Astrophysical Observation", "SAO 166917"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.02179810),
        dec: Angle.Degrees(-19.80400911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94144",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12096 AB"},
        {"Henry Draper", "HD 178555"},
        {"Hipparcos Number", "HIP 94144"},
        {"Geneva Identification System", "GEN# +1.00178555J"},
        {"Smithsonian Astrophysical Observation", "SAO 162260"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.45055090),
        dec: Angle.Degrees(-19.80345573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90323"},
        {"Hipparcos Number", "HIP 51010"},
        {"Geneva Identification System", "GEN# +1.00090323"},
        {"Smithsonian Astrophysical Observation", "SAO 155967"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.31529964),
        dec: Angle.Degrees(-19.80324599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78821",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9913 C"},
        {"Henry Draper", "HD 144218"},
        {"Hipparcos Number", "HIP 78821"},
        {"Geneva Identification System", "GEN# +1.00144218"},
        {"Smithsonian Astrophysical Observation", "SAO 159683"},
        {"Wilson Evans Batten Catalogue", "WEB 13323"},
    },
    visualMagnitude: 4.90,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.36073017),
        dec: Angle.Degrees(-19.80184191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52388"},
        {"Hipparcos Number", "HIP 33713"},
        {"Smithsonian Astrophysical Observation", "SAO 152228"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.06260309),
        dec: Angle.Degrees(-19.80124232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126105"},
        {"Hipparcos Number", "HIP 70382"},
        {"Smithsonian Astrophysical Observation", "SAO 158538"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.00137386),
        dec: Angle.Degrees(-19.80077798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11533",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1892 AB"},
        {"Henry Draper", "HD 15445"},
        {"Hipparcos Number", "HIP 11533"},
        {"Smithsonian Astrophysical Observation", "SAO 167813"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.17447179),
        dec: Angle.Degrees(-19.79882912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174919"},
        {"Hipparcos Number", "HIP 92733"},
        {"Geneva Identification System", "GEN# +1.00174919"},
        {"Smithsonian Astrophysical Observation", "SAO 161947"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.45252520),
        dec: Angle.Degrees(-19.79708840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45715"},
        {"Hipparcos Number", "HIP 30796"},
        {"Smithsonian Astrophysical Observation", "SAO 151537"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.06614242),
        dec: Angle.Degrees(-19.79702830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47369"},
        {"Hipparcos Number", "HIP 31649"},
        {"Smithsonian Astrophysical Observation", "SAO 151721"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.36194517),
        dec: Angle.Degrees(-19.79500654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105672",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14937"},
        {"Aitken 2", "ADS 14937 AB"},
        {"Henry Draper", "HD 203650"},
        {"Hipparcos Number", "HIP 105672"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.05586071),
        dec: Angle.Degrees(-19.79344330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202590"},
        {"Hipparcos Number", "HIP 105089"},
        {"Smithsonian Astrophysical Observation", "SAO 190200"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.32442203),
        dec: Angle.Degrees(-19.79343067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109238"},
        {"Hipparcos Number", "HIP 61270"},
        {"Geneva Identification System", "GEN# +1.00109238"},
        {"Smithsonian Astrophysical Observation", "SAO 157359"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.34278349),
        dec: Angle.Degrees(-19.79248604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24173"},
        {"Hipparcos Number", "HIP 17948"},
        {"Smithsonian Astrophysical Observation", "SAO 149200"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.56163507),
        dec: Angle.Degrees(-19.79218881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74392",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9532 Aa"},
        {"Henry Draper", "HD 134759"},
        {"Hipparcos Number", "HIP 74392"},
        {"Fundamental Katalog 5th Edition", "FK5 559"},
        {"Geneva Identification System", "GEN# +1.00134759J"},
        {"Renson", "Renson 38230"},
        {"Smithsonian Astrophysical Observation", "SAO 159090"},
        {"Wilson Evans Batten Catalogue", "WEB 12698"},
    },
    visualMagnitude: 4.54,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.05546736),
        dec: Angle.Degrees(-19.79163143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153037"},
        {"Hipparcos Number", "HIP 83021"},
        {"Smithsonian Astrophysical Observation", "SAO 160190"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.47271442),
        dec: Angle.Degrees(-19.79156654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103722"},
        {"Hipparcos Number", "HIP 58236"},
        {"Smithsonian Astrophysical Observation", "SAO 157000"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.16936343),
        dec: Angle.Degrees(-19.78763775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64336"},
        {"Hipparcos Number", "HIP 38457"},
        {"Geneva Identification System", "GEN# +1.00064336"},
        {"Smithsonian Astrophysical Observation", "SAO 153530"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.16182509),
        dec: Angle.Degrees(-19.78732164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179997"},
        {"Hipparcos Number", "HIP 94637"},
        {"Fundamental Katalog 5th Edition", "FK5 5694"},
        {"Smithsonian Astrophysical Observation", "SAO 162368"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.85946585),
        dec: Angle.Degrees(-19.78690901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30426",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5023 AB"},
        {"Henry Draper", "HD 44953"},
        {"Hipparcos Number", "HIP 30426"},
        {"Geneva Identification System", "GEN# +1.00044953J"},
        {"Renson", "Renson 11930"},
        {"Smithsonian Astrophysical Observation", "SAO 151453"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.94857097),
        dec: Angle.Degrees(-19.78541168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171236"},
        {"Hipparcos Number", "HIP 91051"},
        {"Smithsonian Astrophysical Observation", "SAO 161619"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.60546640),
        dec: Angle.Degrees(-19.78463204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139395"},
        {"Hipparcos Number", "HIP 76589"},
        {"Smithsonian Astrophysical Observation", "SAO 159404"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.62678549),
        dec: Angle.Degrees(-19.78131517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193728"},
        {"Hipparcos Number", "HIP 100470"},
        {"Smithsonian Astrophysical Observation", "SAO 163501"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.61549186),
        dec: Angle.Degrees(-19.78118671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190876"},
        {"Hipparcos Number", "HIP 99153"},
        {"Smithsonian Astrophysical Observation", "SAO 163277"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.94074664),
        dec: Angle.Degrees(-19.77731863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113158"},
        {"Hipparcos Number", "HIP 63592"},
        {"Geneva Identification System", "GEN# +1.00113158"},
        {"Renson", "Renson 32850"},
        {"Smithsonian Astrophysical Observation", "SAO 157664"},
        {"Wilson Evans Batten Catalogue", "WEB 11254"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.47261488),
        dec: Angle.Degrees(-19.77454641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77434",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77434"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.10643557),
        dec: Angle.Degrees(-19.77402446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209718"},
        {"Hipparcos Number", "HIP 109087"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.46780893),
        dec: Angle.Degrees(-19.77383811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105730"},
        {"Hipparcos Number", "HIP 59336"},
        {"Wilson Evans Batten Catalogue", "WEB 10553"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.57862955),
        dec: Angle.Degrees(-19.76986535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76714",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9735"},
        {"Aitken 2", "ADS 9735 AB"},
        {"Henry Draper", "HD 139628"},
        {"Hipparcos Number", "HIP 76714"},
        {"Smithsonian Astrophysical Observation", "SAO 159421"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.97699228),
        dec: Angle.Degrees(-19.76908380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53015"},
        {"Hipparcos Number", "HIP 33939"},
        {"Smithsonian Astrophysical Observation", "SAO 152280"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.64955026),
        dec: Angle.Degrees(-19.76900627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204506"},
        {"Hipparcos Number", "HIP 106101"},
        {"Smithsonian Astrophysical Observation", "SAO 164428"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.38518744),
        dec: Angle.Degrees(-19.76856380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143956"},
        {"Hipparcos Number", "HIP 78702"},
        {"Geneva Identification System", "GEN# +1.00143956"},
        {"Smithsonian Astrophysical Observation", "SAO 159662"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.00101867),
        dec: Angle.Degrees(-19.76742642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87052"},
        {"Hipparcos Number", "HIP 49177"},
        {"Smithsonian Astrophysical Observation", "SAO 155674"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.54822995),
        dec: Angle.Degrees(-19.76680620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9233"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.68247119),
        dec: Angle.Degrees(-19.76431324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 429.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186648"},
        {"Hipparcos Number", "HIP 97290"},
        {"Fundamental Katalog 5th Edition", "FK5 1517"},
        {"Geneva Identification System", "GEN# +1.00186648"},
        {"Smithsonian Astrophysical Observation", "SAO 162964"},
        {"Wilson Evans Batten Catalogue", "WEB 17091"},
    },
    visualMagnitude: 4.87,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.59091351),
        dec: Angle.Degrees(-19.76089482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93353"},
        {"Hipparcos Number", "HIP 52698"},
        {"Smithsonian Astrophysical Observation", "SAO 156213"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.61943149),
        dec: Angle.Degrees(-19.76061598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110385"},
        {"Hipparcos Number", "HIP 61951"},
        {"Celescope Catalog", "CEL 4141"},
        {"Geneva Identification System", "GEN# +1.00110385"},
        {"Smithsonian Astrophysical Observation", "SAO 157451"},
        {"Wilson Evans Batten Catalogue", "WEB 11016"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.45627095),
        dec: Angle.Degrees(-19.75913355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18299"},
        {"Hipparcos Number", "HIP 13647"},
        {"Smithsonian Astrophysical Observation", "SAO 148671"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.92758579),
        dec: Angle.Degrees(-19.75645150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49668",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7655 A"},
        {"Henry Draper", "HD 87998"},
        {"Hipparcos Number", "HIP 49668"},
        {"Geneva Identification System", "GEN# +1.00087998"},
        {"Smithsonian Astrophysical Observation", "SAO 155757"},
        {"Wilson Evans Batten Catalogue", "WEB 9161"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.08946507),
        dec: Angle.Degrees(-19.75442036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -328.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165202"},
        {"Hipparcos Number", "HIP 88615"},
        {"Smithsonian Astrophysical Observation", "SAO 161056"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.38881853),
        dec: Angle.Degrees(-19.75420289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112528"},
        {"Hipparcos Number", "HIP 63247"},
        {"Geneva Identification System", "GEN# +1.00112528"},
        {"Renson", "Renson 32730"},
        {"Smithsonian Astrophysical Observation", "SAO 157619"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.39727862),
        dec: Angle.Degrees(-19.75047859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79181"},
        {"Hipparcos Number", "HIP 45158"},
        {"Fundamental Katalog 5th Edition", "FK5 1242"},
        {"Geneva Identification System", "GEN# +1.00079181"},
        {"Smithsonian Astrophysical Observation", "SAO 154989"},
        {"Wilson Evans Batten Catalogue", "WEB 8614"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.99487892),
        dec: Angle.Degrees(-19.74774055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183214"},
        {"Hipparcos Number", "HIP 95803"},
        {"Smithsonian Astrophysical Observation", "SAO 162660"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.30221785),
        dec: Angle.Degrees(-19.74721738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166787"},
        {"Hipparcos Number", "HIP 89262"},
        {"Geneva Identification System", "GEN# +1.00166787"},
        {"Smithsonian Astrophysical Observation", "SAO 161190"},
        {"Wilson Evans Batten Catalogue", "WEB 15172"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.23396799),
        dec: Angle.Degrees(-19.74521273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3595"},
        {"Hipparcos Number", "HIP 3038"},
        {"Smithsonian Astrophysical Observation", "SAO 166440"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.65625897),
        dec: Angle.Degrees(-19.74193790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78856"},
        {"Hipparcos Number", "HIP 44993"},
        {"Smithsonian Astrophysical Observation", "SAO 154964"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.46601688),
        dec: Angle.Degrees(-19.74160884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157688"},
        {"Hipparcos Number", "HIP 85275"},
        {"Geneva Identification System", "GEN# +1.00157688"},
        {"Smithsonian Astrophysical Observation", "SAO 160534"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.37196936),
        dec: Angle.Degrees(-19.74083087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137010"},
        {"Hipparcos Number", "HIP 75398"},
        {"Smithsonian Astrophysical Observation", "SAO 159232"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.08795587),
        dec: Angle.Degrees(-19.73875226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 230.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42394",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6903 A"},
        {"Henry Draper", "HD 73603"},
        {"Henry Draper 2", "HD 73603A"},
        {"Hipparcos Number", "HIP 42394"},
        {"Fundamental Katalog 5th Edition", "FK5 2678"},
        {"Geneva Identification System", "GEN# +1.00073603"},
        {"Smithsonian Astrophysical Observation", "SAO 154492"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.66786125),
        dec: Angle.Degrees(-19.73690927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16165"},
        {"Hipparcos Number", "HIP 12038"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.79794804),
        dec: Angle.Degrees(-19.73365198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169274"},
        {"Hipparcos Number", "HIP 90230"},
        {"Geneva Identification System", "GEN# +4.35330075"},
        {"Smithsonian Astrophysical Observation", "SAO 161436"},
    },
    visualMagnitude: 7.51,
    bvColour: 2.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.15974248),
        dec: Angle.Degrees(-19.73286969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139486"},
        {"Hipparcos Number", "HIP 76633"},
        {"Geneva Identification System", "GEN# +1.00139486"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.75027886),
        dec: Angle.Degrees(-19.73251008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30607"},
        {"Hipparcos Number", "HIP 22310"},
        {"Smithsonian Astrophysical Observation", "SAO 149898"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.08034156),
        dec: Angle.Degrees(-19.72980480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41450"},
        {"Hipparcos Number", "HIP 28772"},
        {"Smithsonian Astrophysical Observation", "SAO 151085"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.13198004),
        dec: Angle.Degrees(-19.72873104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43306"},
        {"Hipparcos Number", "HIP 29644"},
        {"Smithsonian Astrophysical Observation", "SAO 151268"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.70138559),
        dec: Angle.Degrees(-19.72827644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66834"},
        {"Hipparcos Number", "HIP 39524"},
        {"Geneva Identification System", "GEN# +1.00066834"},
        {"Smithsonian Astrophysical Observation", "SAO 153796"},
        {"Wilson Evans Batten Catalogue", "WEB 7725"},
    },
    visualMagnitude: 6.12,
    bvColour: -0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.17258828),
        dec: Angle.Degrees(-19.72815612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84620"},
        {"Hipparcos Number", "HIP 47938"},
        {"Geneva Identification System", "GEN# +1.00084620"},
        {"Smithsonian Astrophysical Observation", "SAO 155466"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.52881034),
        dec: Angle.Degrees(-19.72802840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110224"},
        {"Hipparcos Number", "HIP 61867"},
        {"Smithsonian Astrophysical Observation", "SAO 157442"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.18010081),
        dec: Angle.Degrees(-19.72788821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200330"},
        {"Hipparcos Number", "HIP 103922"},
        {"Smithsonian Astrophysical Observation", "SAO 164099"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.83381672),
        dec: Angle.Degrees(-19.72327652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123425"},
        {"Hipparcos Number", "HIP 69048"},
        {"Smithsonian Astrophysical Observation", "SAO 158371"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.00315226),
        dec: Angle.Degrees(-19.72214395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3996"},
        {"Hipparcos Number", "HIP 3328"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.60298264),
        dec: Angle.Degrees(-19.71719296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194169"},
        {"Hipparcos Number", "HIP 100685"},
        {"Geneva Identification System", "GEN# +1.00194169"},
        {"Smithsonian Astrophysical Observation", "SAO 163540"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.19441721),
        dec: Angle.Degrees(-19.70997027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49587",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7647 AB"},
        {"Henry Draper", "HD 87840"},
        {"Hipparcos Number", "HIP 49587"},
        {"Smithsonian Astrophysical Observation", "SAO 155744"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.84268286),
        dec: Angle.Degrees(-19.70872685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175808"},
        {"Hipparcos Number", "HIP 93091"},
        {"Smithsonian Astrophysical Observation", "SAO 162024"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.45148412),
        dec: Angle.Degrees(-19.70865047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152177"},
        {"Hipparcos Number", "HIP 82564"},
        {"Smithsonian Astrophysical Observation", "SAO 160138"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.14639286),
        dec: Angle.Degrees(-19.70609046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27922",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4503 A"},
        {"Henry Draper", "HD 39855"},
        {"Hipparcos Number", "HIP 27922"},
        {"Geneva Identification System", "GEN# +1.00039855"},
        {"Smithsonian Astrophysical Observation", "SAO 150931"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.62540918),
        dec: Angle.Degrees(-19.70428207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 748"},
        {"Hipparcos Number", "HIP 960"},
        {"Smithsonian Astrophysical Observation", "SAO 147139"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.96191971),
        dec: Angle.Degrees(-19.70326287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61068"},
        {"Hipparcos Number", "HIP 37036"},
        {"Celescope Catalog", "CEL 1949"},
        {"Fundamental Katalog 5th Edition", "FK5 1197"},
        {"Geneva Identification System", "GEN# +1.00061068"},
        {"Smithsonian Astrophysical Observation", "SAO 153149"},
        {"Wilson Evans Batten Catalogue", "WEB 7349"},
    },
    visualMagnitude: 5.69,
    bvColour: -0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.17099481),
        dec: Angle.Degrees(-19.70235325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112934",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112934"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.09257315),
        dec: Angle.Degrees(-19.70094347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112400"},
    },
    visualMagnitude: 11.12,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.50001794),
        dec: Angle.Degrees(-19.69635807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -307.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219179"},
        {"Hipparcos Number", "HIP 114705"},
        {"Smithsonian Astrophysical Observation", "SAO 165573"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.53142953),
        dec: Angle.Degrees(-19.69583777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97445"},
        {"Hipparcos Number", "HIP 54754"},
        {"Smithsonian Astrophysical Observation", "SAO 156534"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.15912510),
        dec: Angle.Degrees(-19.69574877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25397",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4034 A"},
        {"Henry Draper", "HD 35736"},
        {"Hipparcos Number", "HIP 25397"},
        {"Geneva Identification System", "GEN# +1.00035736A"},
        {"Smithsonian Astrophysical Observation", "SAO 150442"},
        {"Wilson Evans Batten Catalogue", "WEB 4923"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.49926259),
        dec: Angle.Degrees(-19.69535296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41085"},
        {"Hipparcos Number", "HIP 28601"},
        {"Smithsonian Astrophysical Observation", "SAO 151045"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.54885167),
        dec: Angle.Degrees(-19.69142582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45777"},
        {"Hipparcos Number", "HIP 30847"},
        {"Smithsonian Astrophysical Observation", "SAO 151548"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.17219477),
        dec: Angle.Degrees(-19.69125329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194872"},
        {"Hipparcos Number", "HIP 101004"},
        {"Smithsonian Astrophysical Observation", "SAO 163609"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.16200061),
        dec: Angle.Degrees(-19.69033989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220293"},
        {"Hipparcos Number", "HIP 115411"},
        {"Geneva Identification System", "GEN# +1.00220293"},
        {"Smithsonian Astrophysical Observation", "SAO 165660"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.68062686),
        dec: Angle.Degrees(-19.69010169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -227.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25396",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4034 B"},
        {"Henry Draper", "HD 35722"},
        {"Hipparcos Number", "HIP 25396"},
        {"Geneva Identification System", "GEN# +1.00035722"},
        {"Smithsonian Astrophysical Observation", "SAO 150441"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.49393207),
        dec: Angle.Degrees(-19.68986992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88655"},
        {"Hipparcos Number", "HIP 50043"},
        {"Geneva Identification System", "GEN# +1.00088655"},
        {"Smithsonian Astrophysical Observation", "SAO 155826"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.25411868),
        dec: Angle.Degrees(-19.68920306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90679"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.53352907),
        dec: Angle.Degrees(-19.68817713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35009"},
        {"Hipparcos Number", "HIP 24975"},
        {"Smithsonian Astrophysical Observation", "SAO 150364"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.23112837),
        dec: Angle.Degrees(-19.68741020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7525"},
        {"Hipparcos Number", "HIP 5853"},
        {"Smithsonian Astrophysical Observation", "SAO 147694"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.76577989),
        dec: Angle.Degrees(-19.68610645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173886"},
        {"Hipparcos Number", "HIP 92285"},
        {"Smithsonian Astrophysical Observation", "SAO 161845"},
        {"Wilson Evans Batten Catalogue", "WEB 15922"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.13094887),
        dec: Angle.Degrees(-19.68563366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203545"},
        {"Hipparcos Number", "HIP 105604"},
        {"Smithsonian Astrophysical Observation", "SAO 164355"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.83878678),
        dec: Angle.Degrees(-19.68136866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154910"},
        {"Hipparcos Number", "HIP 83923"},
        {"Smithsonian Astrophysical Observation", "SAO 160316"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.28693828),
        dec: Angle.Degrees(-19.68046979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64655"},
        {"Hipparcos Number", "HIP 38606"},
        {"Smithsonian Astrophysical Observation", "SAO 153568"},
    },
    visualMagnitude: 8.88,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.56227204),
        dec: Angle.Degrees(-19.68044955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125679"},
        {"Hipparcos Number", "HIP 70177"},
        {"Geneva Identification System", "GEN# +1.00125679"},
        {"Smithsonian Astrophysical Observation", "SAO 158509"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.37455395),
        dec: Angle.Degrees(-19.68013496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139997"},
        {"Hipparcos Number", "HIP 76880"},
        {"Fundamental Katalog 5th Edition", "FK5 1413"},
        {"Geneva Identification System", "GEN# +1.00139997"},
        {"Smithsonian Astrophysical Observation", "SAO 159442"},
        {"Wilson Evans Batten Catalogue", "WEB 13040"},
    },
    visualMagnitude: 4.75,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.48674445),
        dec: Angle.Degrees(-19.67857446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84788",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10463 AB"},
        {"Henry Draper", "HD 156700"},
        {"Hipparcos Number", "HIP 84788"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.96450694),
        dec: Angle.Degrees(-19.67843490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86066"},
        {"Hipparcos Number", "HIP 48683"},
        {"Smithsonian Astrophysical Observation", "SAO 155597"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.93154223),
        dec: Angle.Degrees(-19.67708465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113385"},
        {"Hipparcos Number", "HIP 63720"},
        {"Geneva Identification System", "GEN# +1.00113385"},
        {"Renson", "Renson 32885"},
        {"Smithsonian Astrophysical Observation", "SAO 157684"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.86860026),
        dec: Angle.Degrees(-19.67644347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89647",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11228 AB"},
        {"Henry Draper", "HD 167815"},
        {"Hipparcos Number", "HIP 89647"},
        {"Geneva Identification System", "GEN# +1.00167815J"},
        {"Smithsonian Astrophysical Observation", "SAO 161273"},
        {"Wilson Evans Batten Catalogue", "WEB 15271"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.41657844),
        dec: Angle.Degrees(-19.67217872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21763",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3380 AB"},
        {"Henry Draper", "HD 29755"},
        {"Hipparcos Number", "HIP 21763"},
        {"Geneva Identification System", "GEN# +1.00029755"},
        {"Smithsonian Astrophysical Observation", "SAO 149818"},
        {"Wilson Evans Batten Catalogue", "WEB 4186"},
    },
    visualMagnitude: 4.32,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.11039135),
        dec: Angle.Degrees(-19.67125686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138413"},
        {"Hipparcos Number", "HIP 76106"},
        {"Fundamental Katalog 5th Edition", "FK5 3224"},
        {"Geneva Identification System", "GEN# +1.00138413"},
        {"Renson", "Renson 39410"},
        {"Smithsonian Astrophysical Observation", "SAO 159330"},
        {"Wilson Evans Batten Catalogue", "WEB 12930"},
    },
    visualMagnitude: 5.50,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.15297100),
        dec: Angle.Degrees(-19.67036366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97"},
        {"Hipparcos Number", "HIP 484"},
        {"Geneva Identification System", "GEN# +1.00000097"},
        {"Smithsonian Astrophysical Observation", "SAO 147079"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.44169115),
        dec: Angle.Degrees(-19.66981225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6103"},
        {"Hipparcos Number", "HIP 4833"},
        {"Geneva Identification System", "GEN# +1.00006103"},
        {"Smithsonian Astrophysical Observation", "SAO 147578"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.52842868),
        dec: Angle.Degrees(-19.66954171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96030"},
        {"Hipparcos Number", "HIP 54128"},
        {"Smithsonian Astrophysical Observation", "SAO 156436"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.11490894),
        dec: Angle.Degrees(-19.66562067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54124"},
    },
    visualMagnitude: 11.21,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.10997938),
        dec: Angle.Degrees(-19.66437599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32368"},
        {"Hipparcos Number", "HIP 23411"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.47380692),
        dec: Angle.Degrees(-19.66270887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37364",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6273 A"},
        {"Henry Draper", "HD 61774"},
        {"Hipparcos Number", "HIP 37364"},
        {"Geneva Identification System", "GEN# +1.00061774"},
        {"Smithsonian Astrophysical Observation", "SAO 153225"},
    },
    visualMagnitude: 5.92,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.05638028),
        dec: Angle.Degrees(-19.66089028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5591"},
        {"Smithsonian Astrophysical Observation", "SAO 147660"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.92671617),
        dec: Angle.Degrees(-19.66040198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104337"},
        {"Hipparcos Number", "HIP 58587"},
        {"Fundamental Katalog 5th Edition", "FK5 2961"},
        {"Geneva Identification System", "GEN# +1.00104337"},
        {"Smithsonian Astrophysical Observation", "SAO 157042"},
        {"Wilson Evans Batten Catalogue", "WEB 10456"},
    },
    visualMagnitude: 5.28,
    bvColour: -0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.21320843),
        dec: Angle.Degrees(-19.65899848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48813"},
        {"Hipparcos Number", "HIP 32297"},
        {"Smithsonian Astrophysical Observation", "SAO 151863"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.12956693),
        dec: Angle.Degrees(-19.65886001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176350"},
        {"Hipparcos Number", "HIP 93336"},
        {"Smithsonian Astrophysical Observation", "SAO 162079"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.15027629),
        dec: Angle.Degrees(-19.65825153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15932"},
        {"Hipparcos Number", "HIP 11876"},
        {"Smithsonian Astrophysical Observation", "SAO 148461"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.30494843),
        dec: Angle.Degrees(-19.65750725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117697"},
    },
    visualMagnitude: 11.69,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.04445748),
        dec: Angle.Degrees(-19.65459561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224552"},
        {"Hipparcos Number", "HIP 118226"},
        {"Smithsonian Astrophysical Observation", "SAO 165977"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.71346949),
        dec: Angle.Degrees(-19.65220195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38264"},
        {"Hipparcos Number", "HIP 27014"},
        {"Geneva Identification System", "GEN# +1.00038264"},
        {"Smithsonian Astrophysical Observation", "SAO 150745"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.95040282),
        dec: Angle.Degrees(-19.65189041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93278"},
        {"Hipparcos Number", "HIP 52648"},
        {"Smithsonian Astrophysical Observation", "SAO 156204"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.47769926),
        dec: Angle.Degrees(-19.65057160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95939"},
        {"Hipparcos Number", "HIP 54075"},
        {"Geneva Identification System", "GEN# +1.00095939"},
        {"Smithsonian Astrophysical Observation", "SAO 156431"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.97604986),
        dec: Angle.Degrees(-19.64996369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134967"},
        {"Hipparcos Number", "HIP 74493"},
        {"Geneva Identification System", "GEN# +1.00134967"},
        {"Smithsonian Astrophysical Observation", "SAO 159105"},
        {"Wilson Evans Batten Catalogue", "WEB 12709"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.33007640),
        dec: Angle.Degrees(-19.64745418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193335"},
        {"Hipparcos Number", "HIP 100290"},
        {"Smithsonian Astrophysical Observation", "SAO 163462"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.11855249),
        dec: Angle.Degrees(-19.64708294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46853"},
        {"Hipparcos Number", "HIP 31392"},
        {"Smithsonian Astrophysical Observation", "SAO 151664"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.71327230),
        dec: Angle.Degrees(-19.64667534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85076"},
        {"Hipparcos Number", "HIP 48170"},
        {"Geneva Identification System", "GEN# +1.00085076"},
        {"Smithsonian Astrophysical Observation", "SAO 155509"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.27734615),
        dec: Angle.Degrees(-19.64660523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114719"},
        {"Geneva Identification System", "GEN# -0.02006558A"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.56814681),
        dec: Angle.Degrees(-19.64441927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 447.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198648"},
        {"Hipparcos Number", "HIP 103018"},
        {"Smithsonian Astrophysical Observation", "SAO 163943"},
    },
    visualMagnitude: 7.29,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.06704985),
        dec: Angle.Degrees(-19.64356888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8841"},
        {"Hipparcos Number", "HIP 6746"},
        {"Smithsonian Astrophysical Observation", "SAO 147813"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.71120570),
        dec: Angle.Degrees(-19.64245289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29556"},
        {"Hipparcos Number", "HIP 21618"},
        {"Smithsonian Astrophysical Observation", "SAO 149787"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.62010305),
        dec: Angle.Degrees(-19.64084548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132411"},
        {"Hipparcos Number", "HIP 73370"},
        {"Geneva Identification System", "GEN# +1.00132411"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.90964714),
        dec: Angle.Degrees(-19.64033149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49332"},
        {"Hipparcos Number", "HIP 32511"},
        {"Smithsonian Astrophysical Observation", "SAO 151929"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.77087739),
        dec: Angle.Degrees(-19.63911432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208247"},
        {"Hipparcos Number", "HIP 108203"},
        {"Smithsonian Astrophysical Observation", "SAO 164739"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.82720418),
        dec: Angle.Degrees(-19.63898156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39789"},
        {"Hipparcos Number", "HIP 27876"},
        {"Geneva Identification System", "GEN# +1.00039789"},
        {"Smithsonian Astrophysical Observation", "SAO 150925"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.48998156),
        dec: Angle.Degrees(-19.63877248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97864"},
        {"Hipparcos Number", "HIP 54960"},
        {"Fundamental Katalog 5th Edition", "FK5 2898"},
        {"Geneva Identification System", "GEN# +1.00097864"},
        {"Smithsonian Astrophysical Observation", "SAO 156564"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.82341847),
        dec: Angle.Degrees(-19.63755940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27231",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27231"},
    },
    visualMagnitude: 11.38,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.56736787),
        dec: Angle.Degrees(-19.63600560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5735"},
        {"Hipparcos Number", "HIP 4586"},
        {"Geneva Identification System", "GEN# +1.00005735"},
        {"Smithsonian Astrophysical Observation", "SAO 147549"},
        {"Wilson Evans Batten Catalogue", "WEB 843"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.68238100),
        dec: Angle.Degrees(-19.63262935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27653"},
        {"Hipparcos Number", "HIP 20294"},
        {"Smithsonian Astrophysical Observation", "SAO 149567"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.23759532),
        dec: Angle.Degrees(-19.63160795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112357"},
        {"Hipparcos Number", "HIP 63142"},
        {"Geneva Identification System", "GEN# +1.00112357"},
        {"Smithsonian Astrophysical Observation", "SAO 157608"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.07200450),
        dec: Angle.Degrees(-19.63155072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76336"},
        {"Smithsonian Astrophysical Observation", "SAO 159368"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.88505985),
        dec: Angle.Degrees(-19.62900016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27766"},
        {"Hipparcos Number", "HIP 20406"},
        {"Geneva Identification System", "GEN# +1.00027766"},
        {"Smithsonian Astrophysical Observation", "SAO 149586"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.53155869),
        dec: Angle.Degrees(-19.62596462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205888"},
        {"Hipparcos Number", "HIP 106876"},
        {"Geneva Identification System", "GEN# +1.00205888"},
        {"Smithsonian Astrophysical Observation", "SAO 164544"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.71047089),
        dec: Angle.Degrees(-19.62537058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206546"},
        {"Hipparcos Number", "HIP 107238"},
        {"Geneva Identification System", "GEN# +1.00206546"},
        {"Renson", "Renson 57480"},
        {"Smithsonian Astrophysical Observation", "SAO 164601"},
        {"Wilson Evans Batten Catalogue", "WEB 19369"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.80617707),
        dec: Angle.Degrees(-19.62093103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21759"},
        {"Hipparcos Number", "HIP 16286"},
        {"Smithsonian Astrophysical Observation", "SAO 148992"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.48477435),
        dec: Angle.Degrees(-19.62077277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 198.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203637"},
        {"Hipparcos Number", "HIP 105663"},
        {"Smithsonian Astrophysical Observation", "SAO 164362"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.03501183),
        dec: Angle.Degrees(-19.62072210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55445"},
        {"Hipparcos Number", "HIP 34794"},
        {"Smithsonian Astrophysical Observation", "SAO 152550"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.04520852),
        dec: Angle.Degrees(-19.62034941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200417"},
        {"Hipparcos Number", "HIP 103960"},
        {"Geneva Identification System", "GEN# +1.00200417"},
        {"Smithsonian Astrophysical Observation", "SAO 164105"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.96082270),
        dec: Angle.Degrees(-19.61834396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157172"},
        {"Hipparcos Number", "HIP 85017"},
        {"Geneva Identification System", "GEN# +1.00157172"},
        {"Smithsonian Astrophysical Observation", "SAO 160504"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.64401774),
        dec: Angle.Degrees(-19.61584444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126499"},
        {"Hipparcos Number", "HIP 70598"},
        {"Smithsonian Astrophysical Observation", "SAO 158564"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.60055984),
        dec: Angle.Degrees(-19.61317829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215721"},
        {"Hipparcos Number", "HIP 112529"},
        {"Fundamental Katalog 5th Edition", "FK5 1597"},
        {"Geneva Identification System", "GEN# +1.00215721"},
        {"Smithsonian Astrophysical Observation", "SAO 165293"},
        {"Wilson Evans Batten Catalogue", "WEB 20066"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.88828134),
        dec: Angle.Degrees(-19.61287445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -205.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16008"},
        {"Hipparcos Number", "HIP 11915"},
        {"Smithsonian Astrophysical Observation", "SAO 148468"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.45370630),
        dec: Angle.Degrees(-19.61189176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 218.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71312"},
        {"Hipparcos Number", "HIP 41339"},
        {"Smithsonian Astrophysical Observation", "SAO 154251"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.51975544),
        dec: Angle.Degrees(-19.61043933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208753"},
        {"Hipparcos Number", "HIP 108502"},
        {"Smithsonian Astrophysical Observation", "SAO 164782"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.71166662),
        dec: Angle.Degrees(-19.60976194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14943"},
    },
    visualMagnitude: 11.12,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.15969975),
        dec: Angle.Degrees(-19.60841894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82307",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10219 B"},
        {"Henry Draper", "HD 151576B"},
        {"Hipparcos Number", "HIP 82307"},
        {"Smithsonian Astrophysical Observation", "SAO 160110"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.25570113),
        dec: Angle.Degrees(-19.60744908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13316"},
        {"Hipparcos Number", "HIP 10087"},
        {"Smithsonian Astrophysical Observation", "SAO 148246"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.42418532),
        dec: Angle.Degrees(-19.60702790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9435"},
        {"Hipparcos Number", "HIP 7165"},
        {"Smithsonian Astrophysical Observation", "SAO 147870"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.08973266),
        dec: Angle.Degrees(-19.60687152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173425"},
        {"Hipparcos Number", "HIP 92079"},
        {"Geneva Identification System", "GEN# +1.00173425"},
        {"Smithsonian Astrophysical Observation", "SAO 161803"},
        {"Wilson Evans Batten Catalogue", "WEB 15870"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.50479832),
        dec: Angle.Degrees(-19.60636956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102828"},
        {"Hipparcos Number", "HIP 57722"},
        {"Geneva Identification System", "GEN# +1.00102828"},
        {"Smithsonian Astrophysical Observation", "SAO 156924"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.56605396),
        dec: Angle.Degrees(-19.60512003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133489"},
        {"Hipparcos Number", "HIP 73822"},
        {"Renson", "Renson 37884"},
        {"Smithsonian Astrophysical Observation", "SAO 159011"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.32237480),
        dec: Angle.Degrees(-19.60464991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95145"},
        {"Hipparcos Number", "HIP 53675"},
        {"Fundamental Katalog 5th Edition", "FK5 4970"},
        {"Smithsonian Astrophysical Observation", "SAO 156365"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.73621726),
        dec: Angle.Degrees(-19.60461967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9174"},
        {"Hipparcos Number", "HIP 6993"},
        {"Smithsonian Astrophysical Observation", "SAO 147845"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.50408540),
        dec: Angle.Degrees(-19.60405468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171877"},
        {"Hipparcos Number", "HIP 91344"},
        {"Smithsonian Astrophysical Observation", "SAO 161680"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.46731959),
        dec: Angle.Degrees(-19.60172180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19044"},
        {"Hipparcos Number", "HIP 14215"},
        {"Smithsonian Astrophysical Observation", "SAO 148738"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.82141329),
        dec: Angle.Degrees(-19.60061414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92257"},
        {"Hipparcos Number", "HIP 52115"},
        {"Smithsonian Astrophysical Observation", "SAO 156126"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.71346833),
        dec: Angle.Degrees(-19.60047729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90364"},
        {"Hipparcos Number", "HIP 51037"},
        {"Geneva Identification System", "GEN# +9.00050015"},
        {"Smithsonian Astrophysical Observation", "SAO 155973"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.40047819),
        dec: Angle.Degrees(-19.59970781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98008"},
        {"Hipparcos Number", "HIP 55049"},
        {"Smithsonian Astrophysical Observation", "SAO 156575"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.03936773),
        dec: Angle.Degrees(-19.59750967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79753"},
        {"Hipparcos Number", "HIP 45411"},
        {"Smithsonian Astrophysical Observation", "SAO 155030"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.80885705),
        dec: Angle.Degrees(-19.59608656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108932"},
        {"Hipparcos Number", "HIP 61083"},
        {"Smithsonian Astrophysical Observation", "SAO 157333"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.79053209),
        dec: Angle.Degrees(-19.59414504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22921"},
        {"Hipparcos Number", "HIP 17138"},
        {"Geneva Identification System", "GEN# +1.00022921"},
        {"Smithsonian Astrophysical Observation", "SAO 149095"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.05198686),
        dec: Angle.Degrees(-19.59286192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6531"},
        {"Hipparcos Number", "HIP 5159"},
        {"Geneva Identification System", "GEN# +1.00006531"},
        {"Smithsonian Astrophysical Observation", "SAO 147607"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.51048951),
        dec: Angle.Degrees(-19.58776944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50142"},
        {"Hipparcos Number", "HIP 32875"},
        {"Geneva Identification System", "GEN# +1.00050142"},
        {"Smithsonian Astrophysical Observation", "SAO 152012"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.75660841),
        dec: Angle.Degrees(-19.58712900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54935"},
        {"Hipparcos Number", "HIP 34600"},
        {"Celescope Catalog", "CEL 1635"},
        {"Wilson Evans Batten Catalogue", "WEB 6922"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.50027461),
        dec: Angle.Degrees(-19.58548364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23055"},
        {"Hipparcos Number", "HIP 17223"},
        {"Geneva Identification System", "GEN# +1.00023055"},
        {"Smithsonian Astrophysical Observation", "SAO 149114"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.34331348),
        dec: Angle.Degrees(-19.58439723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43969"},
    },
    visualMagnitude: 11.55,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.30935040),
        dec: Angle.Degrees(-19.58364878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -311.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83104"},
        {"Hipparcos Number", "HIP 47070"},
        {"Geneva Identification System", "GEN# +1.00083104A"},
        {"Smithsonian Astrophysical Observation", "SAO 155323"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.89091178),
        dec: Angle.Degrees(-19.58330800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7135"},
        {"Hipparcos Number", "HIP 5567"},
        {"Geneva Identification System", "GEN# +1.00007135"},
        {"Smithsonian Astrophysical Observation", "SAO 147657"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.85682522),
        dec: Angle.Degrees(-19.58277426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145554"},
        {"Hipparcos Number", "HIP 79410"},
        {"Geneva Identification System", "GEN# +1.00145554"},
        {"Smithsonian Astrophysical Observation", "SAO 159770"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.09099501),
        dec: Angle.Degrees(-19.57898823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8339"},
        {"Hipparcos Number", "HIP 6409"},
        {"Smithsonian Astrophysical Observation", "SAO 147764"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.58039290),
        dec: Angle.Degrees(-19.57867473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109796"},
        {"Hipparcos Number", "HIP 61620"},
        {"Geneva Identification System", "GEN# +1.00109796"},
        {"Smithsonian Astrophysical Observation", "SAO 157402"},
        {"Wilson Evans Batten Catalogue", "WEB 10962"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.41971846),
        dec: Angle.Degrees(-19.57782009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207190"},
        {"Hipparcos Number", "HIP 107599"},
        {"Geneva Identification System", "GEN# +1.00207190"},
        {"Smithsonian Astrophysical Observation", "SAO 164654"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.91744563),
        dec: Angle.Degrees(-19.57779239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98553"},
        {"Hipparcos Number", "HIP 55363"},
        {"Geneva Identification System", "GEN# +1.00098553"},
        {"Smithsonian Astrophysical Observation", "SAO 156614"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.04813448),
        dec: Angle.Degrees(-19.57773599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41817",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6862 AB"},
        {"Henry Draper", "HD 72310"},
        {"Hipparcos Number", "HIP 41817"},
        {"Geneva Identification System", "GEN# +1.00072310J"},
        {"Smithsonian Astrophysical Observation", "SAO 154359"},
        {"Wilson Evans Batten Catalogue", "WEB 8052"},
    },
    visualMagnitude: 5.42,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.87893332),
        dec: Angle.Degrees(-19.57743956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143899"},
        {"Hipparcos Number", "HIP 78681"},
        {"Geneva Identification System", "GEN# +1.00143899"},
        {"Smithsonian Astrophysical Observation", "SAO 159660"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.93244408),
        dec: Angle.Degrees(-19.57521017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190775"},
        {"Hipparcos Number", "HIP 99118"},
        {"Smithsonian Astrophysical Observation", "SAO 163274"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.83712047),
        dec: Angle.Degrees(-19.57251335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107892"},
        {"Hipparcos Number", "HIP 60486"},
        {"Geneva Identification System", "GEN# +1.00107892"},
        {"Smithsonian Astrophysical Observation", "SAO 157261"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.00947908),
        dec: Angle.Degrees(-19.57173750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184225"},
        {"Hipparcos Number", "HIP 96238"},
        {"Smithsonian Astrophysical Observation", "SAO 162770"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.53924140),
        dec: Angle.Degrees(-19.57081527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38314"},
        {"Hipparcos Number", "HIP 27043"},
        {"Geneva Identification System", "GEN# +1.00038314"},
        {"Smithsonian Astrophysical Observation", "SAO 150751"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.02622889),
        dec: Angle.Degrees(-19.57063520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13276"},
        {"Hipparcos Number", "HIP 10043"},
        {"Smithsonian Astrophysical Observation", "SAO 148240"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.32090373),
        dec: Angle.Degrees(-19.57020663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209951"},
        {"Hipparcos Number", "HIP 109204"},
        {"Smithsonian Astrophysical Observation", "SAO 164867"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.85539788),
        dec: Angle.Degrees(-19.57017627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82218"},
        {"Hipparcos Number", "HIP 46608"},
        {"Geneva Identification System", "GEN# +1.00082218"},
        {"Smithsonian Astrophysical Observation", "SAO 155244"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.55702922),
        dec: Angle.Degrees(-19.56558346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3458"},
        {"Hipparcos Number", "HIP 2945"},
        {"Geneva Identification System", "GEN# +1.00003458"},
        {"Smithsonian Astrophysical Observation", "SAO 147372"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.34562536),
        dec: Angle.Degrees(-19.56501498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87940"},
        {"Hipparcos Number", "HIP 49651"},
        {"Smithsonian Astrophysical Observation", "SAO 155753"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.03067535),
        dec: Angle.Degrees(-19.56452782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125217"},
        {"Hipparcos Number", "HIP 69908"},
        {"Smithsonian Astrophysical Observation", "SAO 158479"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.60948768),
        dec: Angle.Degrees(-19.56237495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94311"},
        {"Hipparcos Number", "HIP 53203"},
        {"Smithsonian Astrophysical Observation", "SAO 156294"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.22367091),
        dec: Angle.Degrees(-19.56135663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196472"},
        {"Hipparcos Number", "HIP 101840"},
        {"Smithsonian Astrophysical Observation", "SAO 163754"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.57054994),
        dec: Angle.Degrees(-19.56073738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117479"},
        {"Hipparcos Number", "HIP 65929"},
        {"Geneva Identification System", "GEN# +1.00117479"},
        {"Smithsonian Astrophysical Observation", "SAO 157974"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.73022544),
        dec: Angle.Degrees(-19.56005710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90259"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.25537043),
        dec: Angle.Degrees(-19.55724847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21689"},
        {"Hipparcos Number", "HIP 16251"},
        {"Geneva Identification System", "GEN# +1.00021689"},
        {"Smithsonian Astrophysical Observation", "SAO 148984"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.35685578),
        dec: Angle.Degrees(-19.55446657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83687"},
        {"Hipparcos Number", "HIP 47429"},
        {"Smithsonian Astrophysical Observation", "SAO 155380"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.95072598),
        dec: Angle.Degrees(-19.55413518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216906"},
        {"Hipparcos Number", "HIP 113338"},
        {"Smithsonian Astrophysical Observation", "SAO 165399"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.29061609),
        dec: Angle.Degrees(-19.55358541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88537"},
        {"Hipparcos Number", "HIP 49980"},
        {"Smithsonian Astrophysical Observation", "SAO 155812"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.06750481),
        dec: Angle.Degrees(-19.55235795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136205"},
        {"Hipparcos Number", "HIP 75027"},
        {"Geneva Identification System", "GEN# +1.00136205"},
        {"Smithsonian Astrophysical Observation", "SAO 159175"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.95895104),
        dec: Angle.Degrees(-19.55026804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13775"},
        {"Hipparcos Number", "HIP 10387"},
        {"Smithsonian Astrophysical Observation", "SAO 148279"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.44287989),
        dec: Angle.Degrees(-19.54426446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143048"},
        {"Hipparcos Number", "HIP 78261"},
        {"Smithsonian Astrophysical Observation", "SAO 159614"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.69063168),
        dec: Angle.Degrees(-19.54361832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204436"},
        {"Hipparcos Number", "HIP 106070"},
        {"Smithsonian Astrophysical Observation", "SAO 164422"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.27177915),
        dec: Angle.Degrees(-19.54117312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163891"},
        {"Hipparcos Number", "HIP 88073"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.81594007),
        dec: Angle.Degrees(-19.54062227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82951",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10266 AB"},
        {"Henry Draper", "HD 152909"},
        {"Hipparcos Number", "HIP 82951"},
        {"Geneva Identification System", "GEN# +1.00152909J"},
        {"Wilson Evans Batten Catalogue", "WEB 14023"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.26663364),
        dec: Angle.Degrees(-19.53983923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160107"},
        {"Hipparcos Number", "HIP 86365"},
        {"Smithsonian Astrophysical Observation", "SAO 160716"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.71560925),
        dec: Angle.Degrees(-19.53870289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8564"},
        {"Hipparcos Number", "HIP 6561"},
        {"Smithsonian Astrophysical Observation", "SAO 147787"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.08067117),
        dec: Angle.Degrees(-19.53490751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14376"},
        {"Hipparcos Number", "HIP 10787"},
        {"Smithsonian Astrophysical Observation", "SAO 148325"},
        {"Wilson Evans Batten Catalogue", "WEB 2272"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.72443327),
        dec: Angle.Degrees(-19.53456866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64542"},
        {"Hipparcos Number", "HIP 38555"},
        {"Smithsonian Astrophysical Observation", "SAO 153558"},
    },
    visualMagnitude: 8.98,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.41943855),
        dec: Angle.Degrees(-19.53151183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105240"},
        {"Hipparcos Number", "HIP 59089"},
        {"Smithsonian Astrophysical Observation", "SAO 157088"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.75979392),
        dec: Angle.Degrees(-19.53032384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84325"},
        {"Hipparcos Number", "HIP 47750"},
        {"Smithsonian Astrophysical Observation", "SAO 155440"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.02065548),
        dec: Angle.Degrees(-19.53018597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224640"},
        {"Hipparcos Number", "HIP 118290"},
        {"Smithsonian Astrophysical Observation", "SAO 165985"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.89150299),
        dec: Angle.Degrees(-19.53013816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198670"},
        {"Hipparcos Number", "HIP 103032"},
        {"Smithsonian Astrophysical Observation", "SAO 163945"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.11454823),
        dec: Angle.Degrees(-19.52986858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203209"},
        {"Hipparcos Number", "HIP 105436"},
        {"Smithsonian Astrophysical Observation", "SAO 164327"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.34699417),
        dec: Angle.Degrees(-19.52778611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59610"},
        {"Hipparcos Number", "HIP 36452"},
        {"Smithsonian Astrophysical Observation", "SAO 152968"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.50901656),
        dec: Angle.Degrees(-19.52664927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43236"},
        {"Hipparcos Number", "HIP 29604"},
        {"Geneva Identification System", "GEN# +1.00043236"},
        {"Smithsonian Astrophysical Observation", "SAO 151255"},
        {"Wilson Evans Batten Catalogue", "WEB 5826"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.57919895),
        dec: Angle.Degrees(-19.52538988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162434"},
        {"Hipparcos Number", "HIP 87410"},
        {"Geneva Identification System", "GEN# +1.00162434"},
        {"Smithsonian Astrophysical Observation", "SAO 160868"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.95211800),
        dec: Angle.Degrees(-19.52501274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90776"},
        {"Hipparcos Number", "HIP 51291"},
        {"Smithsonian Astrophysical Observation", "SAO 156005"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.15361231),
        dec: Angle.Degrees(-19.52474906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27237"},
        {"Hipparcos Number", "HIP 20005"},
        {"Geneva Identification System", "GEN# +1.00027237"},
        {"Smithsonian Astrophysical Observation", "SAO 149514"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.33901270),
        dec: Angle.Degrees(-19.52418448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63822"},
        {"Hipparcos Number", "HIP 38246"},
        {"Geneva Identification System", "GEN# +1.00063822"},
        {"Smithsonian Astrophysical Observation", "SAO 153468"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.52364147),
        dec: Angle.Degrees(-19.52356224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207878"},
        {"Hipparcos Number", "HIP 107989"},
        {"Smithsonian Astrophysical Observation", "SAO 164703"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.16817115),
        dec: Angle.Degrees(-19.52234624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127859"},
        {"Hipparcos Number", "HIP 71242"},
        {"Smithsonian Astrophysical Observation", "SAO 158643"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.54058338),
        dec: Angle.Degrees(-19.51917937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26004"},
        {"Hipparcos Number", "HIP 19149"},
        {"Geneva Identification System", "GEN# +1.00026004"},
        {"Smithsonian Astrophysical Observation", "SAO 149373"},
        {"Wilson Evans Batten Catalogue", "WEB 3679"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.56768625),
        dec: Angle.Degrees(-19.51330882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59936"},
        {"Hipparcos Number", "HIP 36586"},
        {"Smithsonian Astrophysical Observation", "SAO 153009"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.87573671),
        dec: Angle.Degrees(-19.51132514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206647"},
        {"Hipparcos Number", "HIP 107304"},
        {"Smithsonian Astrophysical Observation", "SAO 164610"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.00566123),
        dec: Angle.Degrees(-19.50862640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11506"},
        {"Hipparcos Number", "HIP 8770"},
        {"Geneva Identification System", "GEN# +1.00011506"},
        {"Smithsonian Astrophysical Observation", "SAO 148079"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.21050180),
        dec: Angle.Degrees(-19.50673557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202556"},
        {"Hipparcos Number", "HIP 105078"},
        {"Geneva Identification System", "GEN# +1.00202556"},
        {"Smithsonian Astrophysical Observation", "SAO 164276"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.30158121),
        dec: Angle.Degrees(-19.50595053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223254"},
        {"Hipparcos Number", "HIP 117377"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.99354596),
        dec: Angle.Degrees(-19.50586064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154584"},
        {"Hipparcos Number", "HIP 83761"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.77787559),
        dec: Angle.Degrees(-19.50571371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72297"},
        {"Hipparcos Number", "HIP 41804"},
        {"Geneva Identification System", "GEN# +1.00072297"},
        {"Smithsonian Astrophysical Observation", "SAO 154358"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.84967529),
        dec: Angle.Degrees(-19.50565610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62518"},
        {"Wilson Evans Batten Catalogue", "WEB 11097"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.18085432),
        dec: Angle.Degrees(-19.50561340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63734"},
        {"Hipparcos Number", "HIP 38209"},
        {"Smithsonian Astrophysical Observation", "SAO 153456"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.41999560),
        dec: Angle.Degrees(-19.50548358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 313300"},
        {"Hipparcos Number", "HIP 90153"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.96330352),
        dec: Angle.Degrees(-19.50452246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145631"},
        {"Hipparcos Number", "HIP 79439"},
        {"Geneva Identification System", "GEN# +1.00145631"},
        {"Smithsonian Astrophysical Observation", "SAO 159777"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.18376971),
        dec: Angle.Degrees(-19.50281447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32584"},
        {"Hipparcos Number", "HIP 23517"},
        {"Fundamental Katalog 5th Edition", "FK5 4465"},
        {"Smithsonian Astrophysical Observation", "SAO 150103"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.84203016),
        dec: Angle.Degrees(-19.50044985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224690"},
        {"Hipparcos Number", "HIP 2"},
        {"Smithsonian Astrophysical Observation", "SAO 165988"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.00379737),
        dec: Angle.Degrees(-19.49883745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 181.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25522"},
        {"Hipparcos Number", "HIP 18853"},
        {"Geneva Identification System", "GEN# +1.00025522"},
        {"Smithsonian Astrophysical Observation", "SAO 149329"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.62775851),
        dec: Angle.Degrees(-19.49827234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3018"},
        {"Hipparcos Number", "HIP 2627"},
        {"Smithsonian Astrophysical Observation", "SAO 147336"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.32973272),
        dec: Angle.Degrees(-19.49733319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188111"},
        {"Hipparcos Number", "HIP 97937"},
        {"Geneva Identification System", "GEN# +1.00188111"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.56157317),
        dec: Angle.Degrees(-19.49647577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43489"},
        {"Hipparcos Number", "HIP 29717"},
        {"Smithsonian Astrophysical Observation", "SAO 151280"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.89597391),
        dec: Angle.Degrees(-19.49443226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153941"},
        {"Hipparcos Number", "HIP 83452"},
        {"Smithsonian Astrophysical Observation", "SAO 160244"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.83028705),
        dec: Angle.Degrees(-19.49238432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47139"},
        {"Hipparcos Number", "HIP 31558"},
        {"Smithsonian Astrophysical Observation", "SAO 151692"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.08512797),
        dec: Angle.Degrees(-19.49211709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76917",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9748 A"},
        {"Henry Draper", "HD 140072"},
        {"Hipparcos Number", "HIP 76917"},
        {"Smithsonian Astrophysical Observation", "SAO 159450"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.58112833),
        dec: Angle.Degrees(-19.49127404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41513"},
        {"Hipparcos Number", "HIP 28800"},
        {"Smithsonian Astrophysical Observation", "SAO 151090"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.20464319),
        dec: Angle.Degrees(-19.49006932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221299"},
        {"Hipparcos Number", "HIP 116061"},
        {"Smithsonian Astrophysical Observation", "SAO 165733"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.75627155),
        dec: Angle.Degrees(-19.49001697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116061"},
        {"Hipparcos Number", "HIP 65183"},
        {"Geneva Identification System", "GEN# +1.00116061"},
        {"Smithsonian Astrophysical Observation", "SAO 157879"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.37423861),
        dec: Angle.Degrees(-19.48928681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213378"},
        {"Hipparcos Number", "HIP 111158"},
        {"Smithsonian Astrophysical Observation", "SAO 165140"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.79892784),
        dec: Angle.Degrees(-19.48557811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85752"},
        {"Hipparcos Number", "HIP 48507"},
        {"Geneva Identification System", "GEN# +1.00085752"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.38932079),
        dec: Angle.Degrees(-19.48505591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66015"},
        {"Hipparcos Number", "HIP 39188"},
        {"Geneva Identification System", "GEN# +1.00066015"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.22753035),
        dec: Angle.Degrees(-19.48234664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177559"},
        {"Hipparcos Number", "HIP 93785"},
        {"Geneva Identification System", "GEN# +1.00177559"},
        {"Smithsonian Astrophysical Observation", "SAO 162180"},
        {"Wilson Evans Batten Catalogue", "WEB 16302"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.49105295),
        dec: Angle.Degrees(-19.48129350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48538"},
        {"Hipparcos Number", "HIP 32179"},
        {"Smithsonian Astrophysical Observation", "SAO 151837"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.77817657),
        dec: Angle.Degrees(-19.47335866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28751"},
        {"Hipparcos Number", "HIP 21093"},
        {"Smithsonian Astrophysical Observation", "SAO 149701"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.80260310),
        dec: Angle.Degrees(-19.47328409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27926"},
        {"Hipparcos Number", "HIP 20505"},
        {"Smithsonian Astrophysical Observation", "SAO 149602"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.91730787),
        dec: Angle.Degrees(-19.47307659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158377"},
        {"Hipparcos Number", "HIP 85617"},
        {"Geneva Identification System", "GEN# +1.00158377"},
        {"Wilson Evans Batten Catalogue", "WEB 14448"},
    },
    visualMagnitude: 7.51,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.43192951),
        dec: Angle.Degrees(-19.47303050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22983"},
        {"Hipparcos Number", "HIP 17170"},
        {"Geneva Identification System", "GEN# +1.00022983"},
        {"Smithsonian Astrophysical Observation", "SAO 149100"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.16732486),
        dec: Angle.Degrees(-19.47301202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216269"},
        {"Hipparcos Number", "HIP 112902"},
        {"Geneva Identification System", "GEN# +1.00216269"},
        {"Smithsonian Astrophysical Observation", "SAO 165341"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.94550767),
        dec: Angle.Degrees(-19.47016512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102346"},
        {"Hipparcos Number", "HIP 57460"},
        {"Geneva Identification System", "GEN# +1.00102346"},
        {"Smithsonian Astrophysical Observation", "SAO 156880"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.67682577),
        dec: Angle.Degrees(-19.46974562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65279"},
        {"Smithsonian Astrophysical Observation", "SAO 157893"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.68765779),
        dec: Angle.Degrees(-19.46925387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76901",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76901"},
        {"Geneva Identification System", "GEN# +9.86768119"},
        {"Geneva Identification System 2", "GEN# +6.10010595"},
        {"Geneva Identification System 3", "GEN# +9.85803060"},
    },
    visualMagnitude: 11.83,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.53242620),
        dec: Angle.Degrees(-19.46924527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2032.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1039.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25754"},
        {"Hipparcos Number", "HIP 19001"},
        {"Smithsonian Astrophysical Observation", "SAO 149353"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.07438610),
        dec: Angle.Degrees(-19.46923781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41877"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.07742062),
        dec: Angle.Degrees(-19.46841603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34583"},
        {"Hipparcos Number", "HIP 24683"},
        {"Smithsonian Astrophysical Observation", "SAO 150313"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.42333315),
        dec: Angle.Degrees(-19.46836124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65718"},
        {"Hipparcos Number", "HIP 39050"},
        {"Smithsonian Astrophysical Observation", "SAO 153679"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.83841434),
        dec: Angle.Degrees(-19.46622184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205637"},
        {"Hipparcos Number", "HIP 106723"},
        {"Fundamental Katalog 5th Edition", "FK5 3724"},
        {"Geneva Identification System", "GEN# +1.00205637A"},
        {"Renson", "Renson 57290"},
        {"Smithsonian Astrophysical Observation", "SAO 164520"},
        {"Wilson Evans Batten Catalogue", "WEB 19295"},
    },
    visualMagnitude: 4.51,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.27009487),
        dec: Angle.Degrees(-19.46601352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50913"},
        {"Hipparcos Number", "HIP 33183"},
        {"Smithsonian Astrophysical Observation", "SAO 152079"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.59581911),
        dec: Angle.Degrees(-19.46525634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83474",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10318 AB"},
        {"Henry Draper", "HD 153997"},
        {"Hipparcos Number", "HIP 83474"},
        {"Renson", "Renson 43520"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.90108490),
        dec: Angle.Degrees(-19.46214487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79374",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Jabbah"},
        {"Aitken", "ADS 9951 AB"},
        {"Henry Draper", "HD 145502"},
        {"Hipparcos Number", "HIP 79374"},
        {"Geneva Identification System", "GEN# +1.00145502"},
        {"Smithsonian Astrophysical Observation", "SAO 159764"},
        {"Wilson Evans Batten Catalogue", "WEB 13419"},
    },
    visualMagnitude: 4.00,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.99891879),
        dec: Angle.Degrees(-19.46064684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218239"},
        {"Hipparcos Number", "HIP 114111"},
        {"Smithsonian Astrophysical Observation", "SAO 165497"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.66150226),
        dec: Angle.Degrees(-19.45980093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19701"},
        {"Hipparcos Number", "HIP 14692"},
        {"Smithsonian Astrophysical Observation", "SAO 148801"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.45267194),
        dec: Angle.Degrees(-19.45894740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79933"},
        {"Hipparcos Number", "HIP 45506"},
        {"Geneva Identification System", "GEN# +1.00079933"},
        {"Smithsonian Astrophysical Observation", "SAO 155050"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.10740051),
        dec: Angle.Degrees(-19.45890167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28479"},
        {"Hipparcos Number", "HIP 20892"},
        {"Geneva Identification System", "GEN# +1.00028479"},
        {"Smithsonian Astrophysical Observation", "SAO 149668"},
        {"Wilson Evans Batten Catalogue", "WEB 4011"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.16256011),
        dec: Angle.Degrees(-19.45859808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160545"},
        {"Hipparcos Number", "HIP 86555"},
        {"Geneva Identification System", "GEN# +1.00160545"},
        {"Smithsonian Astrophysical Observation", "SAO 160744"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.32476964),
        dec: Angle.Degrees(-19.45743111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144981"},
        {"Hipparcos Number", "HIP 79156"},
        {"Geneva Identification System", "GEN# +1.00144981"},
        {"Smithsonian Astrophysical Observation", "SAO 159736"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.33705738),
        dec: Angle.Degrees(-19.45715512)
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
    primaryId: "HIP 40235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68733"},
        {"Hipparcos Number", "HIP 40235"},
        {"Smithsonian Astrophysical Observation", "SAO 153988"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.27095477),
        dec: Angle.Degrees(-19.45710087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222369"},
        {"Hipparcos Number", "HIP 116782"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.01185957),
        dec: Angle.Degrees(-19.45702330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 275.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -290.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101476"},
        {"Hipparcos Number", "HIP 56945"},
        {"Smithsonian Astrophysical Observation", "SAO 156824"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.11636186),
        dec: Angle.Degrees(-19.45519765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74097"},
        {"Hipparcos Number", "HIP 42639"},
        {"Geneva Identification System", "GEN# +1.00074097"},
        {"Smithsonian Astrophysical Observation", "SAO 154547"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.33845882),
        dec: Angle.Degrees(-19.45357809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84424"},
        {"Hipparcos Number", "HIP 47814"},
        {"Smithsonian Astrophysical Observation", "SAO 155449"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.20330333),
        dec: Angle.Degrees(-19.45237683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143616"},
        {"Hipparcos Number", "HIP 78551"},
        {"Geneva Identification System", "GEN# +1.00143616"},
        {"Smithsonian Astrophysical Observation", "SAO 159645"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.56305212),
        dec: Angle.Degrees(-19.45224447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157301"},
        {"Hipparcos Number", "HIP 85080"},
        {"Smithsonian Astrophysical Observation", "SAO 160511"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.81732520),
        dec: Angle.Degrees(-19.44870892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52540"},
        {"Hipparcos Number", "HIP 33781"},
        {"Smithsonian Astrophysical Observation", "SAO 152239"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.21667736),
        dec: Angle.Degrees(-19.44440514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5487"},
        {"Hipparcos Number", "HIP 4410"},
        {"Geneva Identification System", "GEN# +1.00005487"},
        {"Smithsonian Astrophysical Observation", "SAO 147523"},
        {"Wilson Evans Batten Catalogue", "WEB 789"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.12622999),
        dec: Angle.Degrees(-19.44388456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212797"},
        {"Hipparcos Number", "HIP 110829"},
        {"Renson", "Renson 59027"},
        {"Smithsonian Astrophysical Observation", "SAO 165089"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.80017494),
        dec: Angle.Degrees(-19.44321461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152631"},
        {"Hipparcos Number", "HIP 82800"},
        {"Geneva Identification System", "GEN# +1.00152631"},
        {"Smithsonian Astrophysical Observation", "SAO 160161"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.82698225),
        dec: Angle.Degrees(-19.44088995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33423",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5623 AB"},
        {"Henry Draper", "HD 51573"},
        {"Hipparcos Number", "HIP 33423"},
        {"Smithsonian Astrophysical Observation", "SAO 152151"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.25722774),
        dec: Angle.Degrees(-19.43879262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197819"},
        {"Hipparcos Number", "HIP 102528"},
        {"Geneva Identification System", "GEN# +1.00197819"},
        {"Smithsonian Astrophysical Observation", "SAO 163869"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.65997298),
        dec: Angle.Degrees(-19.43811568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225227"},
        {"Hipparcos Number", "HIP 362"},
        {"Smithsonian Astrophysical Observation", "SAO 147068"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.15064352),
        dec: Angle.Degrees(-19.43786312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58609"},
        {"Hipparcos Number", "HIP 36034"},
        {"Smithsonian Astrophysical Observation", "SAO 152853"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.39059663),
        dec: Angle.Degrees(-19.43774845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155095"},
        {"Hipparcos Number", "HIP 83998"},
        {"Geneva Identification System", "GEN# +1.00155095"},
        {"Smithsonian Astrophysical Observation", "SAO 160326"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.56223880),
        dec: Angle.Degrees(-19.43626270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21841"},
        {"Hipparcos Number", "HIP 16348"},
        {"Geneva Identification System", "GEN# +1.00021841"},
        {"Smithsonian Astrophysical Observation", "SAO 149001"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.66689587),
        dec: Angle.Degrees(-19.43556805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212083"},
        {"Hipparcos Number", "HIP 110424"},
        {"Geneva Identification System", "GEN# +1.00212083"},
        {"Smithsonian Astrophysical Observation", "SAO 165023"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.49994460),
        dec: Angle.Degrees(-19.43526875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194213"},
        {"Hipparcos Number", "HIP 100713"},
        {"Smithsonian Astrophysical Observation", "SAO 163545"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.26835707),
        dec: Angle.Degrees(-19.43370508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22750"},
        {"Wilson Evans Batten Catalogue", "WEB 4402"},
    },
    visualMagnitude: 11.71,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.40624004),
        dec: Angle.Degrees(-19.43362903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24784"},
        {"Hipparcos Number", "HIP 18382"},
        {"Smithsonian Astrophysical Observation", "SAO 149260"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.94298198),
        dec: Angle.Degrees(-19.43340998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89981"},
        {"Hipparcos Number", "HIP 50832"},
        {"Smithsonian Astrophysical Observation", "SAO 155941"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.69275995),
        dec: Angle.Degrees(-19.43299254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166628"},
        {"Hipparcos Number", "HIP 89203"},
        {"Geneva Identification System", "GEN# +1.00166628"},
        {"Smithsonian Astrophysical Observation", "SAO 161172"},
        {"Wilson Evans Batten Catalogue", "WEB 15156"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.06125124),
        dec: Angle.Degrees(-19.43281715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42135"},
        {"Hipparcos Number", "HIP 29088"},
        {"Smithsonian Astrophysical Observation", "SAO 151151"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.03775703),
        dec: Angle.Degrees(-19.43175106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36854"},
        {"Hipparcos Number", "HIP 26085"},
        {"Smithsonian Astrophysical Observation", "SAO 150566"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.45394751),
        dec: Angle.Degrees(-19.43073896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10655"},
        {"Hipparcos Number", "HIP 8060"},
        {"Smithsonian Astrophysical Observation", "SAO 147982"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.88459570),
        dec: Angle.Degrees(-19.40356439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83125"},
        {"Smithsonian Astrophysical Observation", "SAO 160208"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.81834727),
        dec: Angle.Degrees(-19.42913074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81128"},
        {"Hipparcos Number", "HIP 46031"},
        {"Smithsonian Astrophysical Observation", "SAO 155140"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.82258347),
        dec: Angle.Degrees(-19.42753800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99096"},
    },
    visualMagnitude: 11.54,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.77151976),
        dec: Angle.Degrees(-19.42298424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -402.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -625.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5022"},
        {"Hipparcos Number", "HIP 4063"},
        {"Smithsonian Astrophysical Observation", "SAO 147486"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.01358443),
        dec: Angle.Degrees(-19.42289041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27765"},
        {"Hipparcos Number", "HIP 20411"},
        {"Smithsonian Astrophysical Observation", "SAO 149588"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.55652809),
        dec: Angle.Degrees(-19.42089658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22956"},
        {"Hipparcos Number", "HIP 17161"},
        {"Smithsonian Astrophysical Observation", "SAO 149099"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.13357663),
        dec: Angle.Degrees(-19.42054338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62292"},
        {"Hipparcos Number", "HIP 37556"},
        {"Smithsonian Astrophysical Observation", "SAO 153285"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.62393550),
        dec: Angle.Degrees(-19.41944214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6067"},
        {"Hipparcos Number", "HIP 4815"},
        {"Geneva Identification System", "GEN# +1.00006067"},
        {"Smithsonian Astrophysical Observation", "SAO 147574"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.44610978),
        dec: Angle.Degrees(-19.41895927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96838"},
        {"Hipparcos Number", "HIP 54493"},
        {"Smithsonian Astrophysical Observation", "SAO 156493"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.23757534),
        dec: Angle.Degrees(-19.41645158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207341"},
        {"Hipparcos Number", "HIP 107674"},
        {"Smithsonian Astrophysical Observation", "SAO 164669"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.17191742),
        dec: Angle.Degrees(-19.41354569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87415"},
        {"Hipparcos Number", "HIP 49347"},
        {"Smithsonian Astrophysical Observation", "SAO 155708"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.10807287),
        dec: Angle.Degrees(-19.41273082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60341"},
        {"Hipparcos Number", "HIP 36732"},
        {"Geneva Identification System", "GEN# +1.00060341"},
        {"Smithsonian Astrophysical Observation", "SAO 153062"},
        {"Wilson Evans Batten Catalogue", "WEB 7301"},
    },
    visualMagnitude: 5.64,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.33145749),
        dec: Angle.Degrees(-19.41235409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69354"},
        {"Hipparcos Number", "HIP 40487"},
        {"Smithsonian Astrophysical Observation", "SAO 154045"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.99726021),
        dec: Angle.Degrees(-19.40821676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137916"},
        {"Hipparcos Number", "HIP 75830"},
        {"Renson", "Renson 39210"},
        {"Smithsonian Astrophysical Observation", "SAO 159290"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.35169632),
        dec: Angle.Degrees(-19.40464559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
