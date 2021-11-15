using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_80() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41140"},
        {"Hipparcos Number", "HIP 28728"},
        {"Geneva Identification System", "GEN# +1.00041140"},
        {"Smithsonian Astrophysical Observation", "SAO 77916"},
        {"Wilson Evans Batten Catalogue", "WEB 5622"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.02392283),
        dec: Angle.Degrees(+21.49417748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343222"},
        {"Hipparcos Number", "HIP 92347"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.30989454),
        dec: Angle.Degrees(+21.49461725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87800",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10904 A"},
        {"Henry Draper", "HD 163609"},
        {"Hipparcos Number", "HIP 87800"},
        {"Geneva Identification System", "GEN# +1.00163609"},
        {"Smithsonian Astrophysical Observation", "SAO 85554"},
        {"Wilson Evans Batten Catalogue", "WEB 14816"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.03671107),
        dec: Angle.Degrees(+21.49480722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33090"},
        {"Hipparcos Number", "HIP 23946"},
        {"Geneva Identification System", "GEN# +1.00033090"},
        {"Smithsonian Astrophysical Observation", "SAO 76980"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.19423976),
        dec: Angle.Degrees(+21.49566358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190337"},
        {"Hipparcos Number", "HIP 98780"},
        {"Smithsonian Astrophysical Observation", "SAO 88131"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.92595005),
        dec: Angle.Degrees(+21.49647896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153847"},
        {"Hipparcos Number", "HIP 83270"},
        {"Geneva Identification System", "GEN# +1.00153847"},
        {"Smithsonian Astrophysical Observation", "SAO 84759"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.28001700),
        dec: Angle.Degrees(+21.49732211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52765"},
        {"Geneva Identification System", "GEN# +0.02202271"},
        {"Wilson Evans Batten Catalogue", "WEB 9604"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.83102609),
        dec: Angle.Degrees(+21.49763751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -380.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80732"},
        {"Hipparcos Number", "HIP 45936"},
        {"Smithsonian Astrophysical Observation", "SAO 80787"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.49716251),
        dec: Angle.Degrees(+21.49858359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46309"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.65514046),
        dec: Angle.Degrees(+21.49897511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8045"},
        {"Smithsonian Astrophysical Observation", "SAO 74892"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.82645001),
        dec: Angle.Degrees(+21.50030413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65884",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65884"},
        {"Smithsonian Astrophysical Observation", "SAO 82864"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.57905091),
        dec: Angle.Degrees(+21.50038361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345240"},
        {"Hipparcos Number", "HIP 98018"},
        {"Smithsonian Astrophysical Observation", "SAO 87921"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.77733796),
        dec: Angle.Degrees(+21.50135846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160935"},
        {"Hipparcos Number", "HIP 86596"},
        {"Smithsonian Astrophysical Observation", "SAO 85324"},
        {"Wilson Evans Batten Catalogue", "WEB 14602"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.44881515),
        dec: Angle.Degrees(+21.50177438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71070"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.00896404),
        dec: Angle.Degrees(+21.50580038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150464"},
        {"Hipparcos Number", "HIP 81629"},
        {"Smithsonian Astrophysical Observation", "SAO 84530"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.11425047),
        dec: Angle.Degrees(+21.50658944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89999",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11287 AB"},
        {"Henry Draper", "HD 169031"},
        {"Hipparcos Number", "HIP 89999"},
        {"Smithsonian Astrophysical Observation", "SAO 85969"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.45185748),
        dec: Angle.Degrees(+21.50778869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95046"},
        {"Hipparcos Number", "HIP 53659"},
        {"Geneva Identification System", "GEN# +1.00095046"},
        {"Smithsonian Astrophysical Observation", "SAO 81605"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.67154709),
        dec: Angle.Degrees(+21.50891359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284676"},
        {"Hipparcos Number", "HIP 21856"},
        {"Smithsonian Astrophysical Observation", "SAO 76716"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.49849808),
        dec: Angle.Degrees(+21.50895254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217115"},
        {"Hipparcos Number", "HIP 113410"},
        {"Smithsonian Astrophysical Observation", "SAO 90903"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.52665958),
        dec: Angle.Degrees(+21.51325417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60033"},
        {"Smithsonian Astrophysical Observation", "SAO 82230"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.67556116),
        dec: Angle.Degrees(+21.51354575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176818"},
        {"Hipparcos Number", "HIP 93395"},
        {"Geneva Identification System", "GEN# +1.00176818"},
        {"Smithsonian Astrophysical Observation", "SAO 86702"},
        {"Wilson Evans Batten Catalogue", "WEB 16196"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.32396142),
        dec: Angle.Degrees(+21.51386806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87550"},
        {"Hipparcos Number", "HIP 49484"},
        {"Smithsonian Astrophysical Observation", "SAO 81181"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.54472941),
        dec: Angle.Degrees(+21.51448508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244331"},
        {"Hipparcos Number", "HIP 25809"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.68783906),
        dec: Angle.Degrees(+21.51536117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182570"},
        {"Hipparcos Number", "HIP 95414"},
        {"Geneva Identification System", "GEN# +1.00182570"},
        {"Smithsonian Astrophysical Observation", "SAO 87167"},
        {"Wilson Evans Batten Catalogue", "WEB 16681"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.13886726),
        dec: Angle.Degrees(+21.51591288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15513"},
        {"Smithsonian Astrophysical Observation", "SAO 75867"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.98191327),
        dec: Angle.Degrees(+21.51649358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172133"},
        {"Hipparcos Number", "HIP 91328"},
        {"Smithsonian Astrophysical Observation", "SAO 86257"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.41969100),
        dec: Angle.Degrees(+21.51668930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193706"},
        {"Hipparcos Number", "HIP 100346"},
        {"Geneva Identification System", "GEN# +1.00193706"},
        {"Smithsonian Astrophysical Observation", "SAO 88555"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.25449652),
        dec: Angle.Degrees(+21.51756020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29512"},
        {"Hipparcos Number", "HIP 21706"},
        {"Geneva Identification System", "GEN# +1.00029512"},
        {"Smithsonian Astrophysical Observation", "SAO 76692"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.91107521),
        dec: Angle.Degrees(+21.51756429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77377"},
        {"Hipparcos Number", "HIP 44408"},
        {"Geneva Identification System", "GEN# +1.00077377"},
        {"Smithsonian Astrophysical Observation", "SAO 80596"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.68816253),
        dec: Angle.Degrees(+21.51922946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157151"},
        {"Hipparcos Number", "HIP 84877"},
        {"Smithsonian Astrophysical Observation", "SAO 85020"},
        {"Wilson Evans Batten Catalogue", "WEB 14331"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.19424082),
        dec: Angle.Degrees(+21.51945950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110196"},
        {"Hipparcos Number", "HIP 61832"},
        {"Geneva Identification System", "GEN# +1.00110196"},
        {"Smithsonian Astrophysical Observation", "SAO 82433"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.07113706),
        dec: Angle.Degrees(+21.52010044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193248"},
        {"Hipparcos Number", "HIP 100118"},
        {"Geneva Identification System", "GEN# +1.00193248"},
        {"Renson", "Renson 53940"},
        {"Smithsonian Astrophysical Observation", "SAO 88495"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.65006397),
        dec: Angle.Degrees(+21.52066541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344172"},
        {"Hipparcos Number", "HIP 94840"},
        {"Geneva Identification System", "GEN# +1.00344172"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.46174126),
        dec: Angle.Degrees(+21.52142915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6329"},
        {"Hipparcos Number", "HIP 5040"},
        {"Smithsonian Astrophysical Observation", "SAO 74473"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.13324666),
        dec: Angle.Degrees(+21.52219954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170697"},
        {"Hipparcos Number", "HIP 90667"},
        {"Smithsonian Astrophysical Observation", "SAO 86129"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.49470607),
        dec: Angle.Degrees(+21.52319455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134869"},
        {"Hipparcos Number", "HIP 74342"},
        {"Smithsonian Astrophysical Observation", "SAO 83709"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.90641593),
        dec: Angle.Degrees(+21.52642706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84335"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.62562246),
        dec: Angle.Degrees(+21.53283273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34690"},
        {"Smithsonian Astrophysical Observation", "SAO 79139"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.77447030),
        dec: Angle.Degrees(+21.53366762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110752",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110752"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.55970812),
        dec: Angle.Degrees(+21.53564542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 152.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58551"},
        {"Hipparcos Number", "HIP 36152"},
        {"Geneva Identification System", "GEN# +1.00058551"},
        {"Smithsonian Astrophysical Observation", "SAO 79386"},
        {"Wilson Evans Batten Catalogue", "WEB 7200"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.71020387),
        dec: Angle.Degrees(+21.53571074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -312.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19615",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3050 AB"},
        {"Henry Draper", "HD 26478"},
        {"Hipparcos Number", "HIP 19615"},
        {"Smithsonian Astrophysical Observation", "SAO 76496"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.04716199),
        dec: Angle.Degrees(+21.53584226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29150"},
        {"Hipparcos Number", "HIP 21436"},
        {"Geneva Identification System", "GEN# +1.00029150"},
        {"Smithsonian Astrophysical Observation", "SAO 76668"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.05810082),
        dec: Angle.Degrees(+21.53664526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83405"},
        {"Hipparcos Number", "HIP 47329"},
        {"Smithsonian Astrophysical Observation", "SAO 80946"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.67199358),
        dec: Angle.Degrees(+21.53952991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66374"},
        {"Geneva Identification System", "GEN# +0.02202606"},
        {"Smithsonian Astrophysical Observation", "SAO 82897"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.09729264),
        dec: Angle.Degrees(+21.54021857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344738"},
        {"Hipparcos Number", "HIP 96798"},
        {"Smithsonian Astrophysical Observation", "SAO 87549"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.14960190),
        dec: Angle.Degrees(+21.54040702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120666"},
        {"Hipparcos Number", "HIP 67551"},
        {"Smithsonian Astrophysical Observation", "SAO 83025"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.62726324),
        dec: Angle.Degrees(+21.54079572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248434"},
        {"Hipparcos Number", "HIP 27683"},
        {"Wilson Evans Batten Catalogue", "WEB 5434"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.91048230),
        dec: Angle.Degrees(+21.54114121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87520"},
        {"Smithsonian Astrophysical Observation", "SAO 85500"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.21074121),
        dec: Angle.Degrees(+21.54207680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1194",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 190 AB"},
        {"Henry Draper", "HD 1059"},
        {"Hipparcos Number", "HIP 1194"},
        {"Smithsonian Astrophysical Observation", "SAO 73839"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.73466695),
        dec: Angle.Degrees(+21.54219599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102091"},
        {"Hipparcos Number", "HIP 57318"},
        {"Geneva Identification System", "GEN# +1.00102091"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.28626184),
        dec: Angle.Degrees(+21.54606549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105045"},
        {"Hipparcos Number", "HIP 58990"},
        {"Geneva Identification System", "GEN# +1.00105045"},
        {"Smithsonian Astrophysical Observation", "SAO 82131"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.42182448),
        dec: Angle.Degrees(+21.54690562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109464"},
        {"Hipparcos Number", "HIP 61389"},
        {"Geneva Identification System", "GEN# +1.00109464"},
        {"Smithsonian Astrophysical Observation", "SAO 82387"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.69943329),
        dec: Angle.Degrees(+21.54772173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58899"},
        {"Hipparcos Number", "HIP 36307"},
        {"Geneva Identification System", "GEN# +1.00058899"},
        {"Smithsonian Astrophysical Observation", "SAO 79410"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.10337380),
        dec: Angle.Degrees(+21.54945528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221218"},
        {"Hipparcos Number", "HIP 115991"},
        {"Renson", "Renson 60652"},
        {"Smithsonian Astrophysical Observation", "SAO 91307"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.50778947),
        dec: Angle.Degrees(+21.54958490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18502"},
        {"Smithsonian Astrophysical Observation", "SAO 76351"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.34898551),
        dec: Angle.Degrees(+21.55376841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83762"},
        {"Geneva Identification System", "GEN# +9.80170017"},
    },
    visualMagnitude: 11.61,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.78241673),
        dec: Angle.Degrees(+21.55408273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -465.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112974"},
        {"Hipparcos Number", "HIP 63460"},
        {"Geneva Identification System", "GEN# +1.00112974"},
        {"Smithsonian Astrophysical Observation", "SAO 82602"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.06451421),
        dec: Angle.Degrees(+21.55421936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179648"},
        {"Hipparcos Number", "HIP 94382"},
        {"Geneva Identification System", "GEN# +1.00179648"},
        {"Smithsonian Astrophysical Observation", "SAO 86930"},
        {"Wilson Evans Batten Catalogue", "WEB 16448"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.15301833),
        dec: Angle.Degrees(+21.55456041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132145"},
        {"Hipparcos Number", "HIP 73156"},
        {"Fundamental Katalog 5th Edition", "FK5 1392"},
        {"Geneva Identification System", "GEN# +1.00132145"},
        {"Smithsonian Astrophysical Observation", "SAO 83596"},
        {"Wilson Evans Batten Catalogue", "WEB 12536"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.26503895),
        dec: Angle.Degrees(+21.55548460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122518"},
        {"Hipparcos Number", "HIP 68547"},
        {"Geneva Identification System", "GEN# +1.00122518"},
        {"Smithsonian Astrophysical Observation", "SAO 83134"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.48979449),
        dec: Angle.Degrees(+21.55609551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345513"},
        {"Hipparcos Number", "HIP 98395"},
        {"Geneva Identification System", "GEN# +1.00345513"},
        {"Smithsonian Astrophysical Observation", "SAO 88025"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.87664045),
        dec: Angle.Degrees(+21.55716726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43259"},
        {"Smithsonian Astrophysical Observation", "SAO 80440"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.18210212),
        dec: Angle.Degrees(+21.55826980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285036"},
        {"Hipparcos Number", "HIP 22970"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.13984256),
        dec: Angle.Degrees(+21.56029093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154184"},
        {"Hipparcos Number", "HIP 83423"},
        {"Smithsonian Astrophysical Observation", "SAO 84790"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.77095441),
        dec: Angle.Degrees(+21.56218259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7500"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.16399501),
        dec: Angle.Degrees(+21.56310778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 262.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42379"},
        {"Hipparcos Number", "HIP 29360"},
        {"Geneva Identification System", "GEN# +1.00042379"},
        {"Smithsonian Astrophysical Observation", "SAO 78074"},
        {"Wilson Evans Batten Catalogue", "WEB 5763"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.82535336),
        dec: Angle.Degrees(+21.56379542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156165"},
        {"Hipparcos Number", "HIP 84387"},
        {"Smithsonian Astrophysical Observation", "SAO 84952"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.78757899),
        dec: Angle.Degrees(+21.56436438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159442"},
        {"Hipparcos Number", "HIP 85942"},
        {"Smithsonian Astrophysical Observation", "SAO 85210"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.47931849),
        dec: Angle.Degrees(+21.56506215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85110"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.90998671),
        dec: Angle.Degrees(+21.56536616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146010"},
        {"Hipparcos Number", "HIP 79472"},
        {"Fundamental Katalog 5th Edition", "FK5 3284"},
        {"Geneva Identification System", "GEN# +1.00146010"},
        {"Smithsonian Astrophysical Observation", "SAO 84250"},
        {"Wilson Evans Batten Catalogue", "WEB 13444"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.28326286),
        dec: Angle.Degrees(+21.56614788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142656"},
        {"Hipparcos Number", "HIP 77947"},
        {"Geneva Identification System", "GEN# +1.00142656"},
        {"Smithsonian Astrophysical Observation", "SAO 84074"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.76576590),
        dec: Angle.Degrees(+21.56634415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14056"},
        {"Hipparcos Number", "HIP 10652"},
        {"Cincinnati Publication", "Ci 20 163"},
        {"Geneva Identification System", "GEN# +1.00014056"},
        {"Smithsonian Astrophysical Observation", "SAO 75261"},
        {"Wilson Evans Batten Catalogue", "WEB 2241"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.27850478),
        dec: Angle.Degrees(+21.56660724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 474.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192993"},
        {"Hipparcos Number", "HIP 99992"},
        {"Smithsonian Astrophysical Observation", "SAO 88455"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.28732245),
        dec: Angle.Degrees(+21.56688224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15766"},
        {"Smithsonian Astrophysical Observation", "SAO 75905"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.79709916),
        dec: Angle.Degrees(+21.56801288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185757"},
        {"Hipparcos Number", "HIP 96744"},
        {"Smithsonian Astrophysical Observation", "SAO 87529"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.99458242),
        dec: Angle.Degrees(+21.56805984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196462"},
        {"Hipparcos Number", "HIP 101711"},
        {"Smithsonian Astrophysical Observation", "SAO 88900"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.24825376),
        dec: Angle.Degrees(+21.56913744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 452"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.35565957),
        dec: Angle.Degrees(+21.56940242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33239",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5564 A"},
        {"Henry Draper", "HD 50634"},
        {"Hipparcos Number", "HIP 33239"},
        {"Smithsonian Astrophysical Observation", "SAO 78858"},
        {"Wilson Evans Batten Catalogue", "WEB 6682"},
    },
    visualMagnitude: 6.98,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.73647621),
        dec: Angle.Degrees(+21.57137242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117008"},
        {"Hipparcos Number", "HIP 65605"},
        {"Geneva Identification System", "GEN# +1.00117008"},
        {"Smithsonian Astrophysical Observation", "SAO 82843"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.77389214),
        dec: Angle.Degrees(+21.57141572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31382"},
        {"Hipparcos Number", "HIP 22947"},
        {"Geneva Identification System", "GEN# +1.00031382"},
        {"Smithsonian Astrophysical Observation", "SAO 76850"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.05908151),
        dec: Angle.Degrees(+21.57240743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83907"},
        {"Hipparcos Number", "HIP 47578"},
        {"Smithsonian Astrophysical Observation", "SAO 80976"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.52127684),
        dec: Angle.Degrees(+21.57308982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62334"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.61088652),
        dec: Angle.Degrees(+21.57341180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185874"},
        {"Hipparcos Number", "HIP 96791"},
        {"Smithsonian Astrophysical Observation", "SAO 87546"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.13474094),
        dec: Angle.Degrees(+21.57618919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117586"},
        {"Geneva Identification System", "GEN# +9.80068045"},
    },
    visualMagnitude: 10.77,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.69864881),
        dec: Angle.Degrees(+21.57668084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 352.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109031"},
        {"Hipparcos Number", "HIP 61120"},
        {"Geneva Identification System", "GEN# +1.00109031"},
        {"Smithsonian Astrophysical Observation", "SAO 82352"},
        {"Wilson Evans Batten Catalogue", "WEB 10882"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.89069032),
        dec: Angle.Degrees(+21.57686424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100414"},
        {"Hipparcos Number", "HIP 56374"},
        {"Geneva Identification System", "GEN# +1.00100414"},
        {"Smithsonian Astrophysical Observation", "SAO 81876"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.33937791),
        dec: Angle.Degrees(+21.57748328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27176"},
        {"Hipparcos Number", "HIP 20087"},
        {"Celescope Catalog", "CEL 382"},
        {"Fundamental Katalog 5th Edition", "FK5 2313"},
        {"Geneva Identification System", "GEN# +5.20250024"},
        {"Renson", "Renson 6950"},
        {"Smithsonian Astrophysical Observation", "SAO 76541"},
        {"Wilson Evans Batten Catalogue", "WEB 3836"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.59642362),
        dec: Angle.Degrees(+21.57937928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67228"},
        {"Hipparcos Number", "HIP 39780"},
        {"Fundamental Katalog 5th Edition", "FK5 2630"},
        {"Geneva Identification System", "GEN# +1.00067228"},
        {"Smithsonian Astrophysical Observation", "SAO 79959"},
        {"Wilson Evans Batten Catalogue", "WEB 7762"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.94100510),
        dec: Angle.Degrees(+21.58197937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65364"},
        {"Smithsonian Astrophysical Observation", "SAO 82818"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.94251630),
        dec: Angle.Degrees(+21.58200917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -245.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112197"},
        {"Hipparcos Number", "HIP 63006"},
        {"Geneva Identification System", "GEN# +1.00112197"},
        {"Renson", "Renson 32583"},
        {"Smithsonian Astrophysical Observation", "SAO 82558"},
        {"Wilson Evans Batten Catalogue", "WEB 11172"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.65791578),
        dec: Angle.Degrees(+21.58489854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78278"},
        {"Hipparcos Number", "HIP 44812"},
        {"Geneva Identification System", "GEN# +6.20058043"},
        {"Wilson Evans Batten Catalogue", "WEB 8565"},
    },
    visualMagnitude: 10.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.98801928),
        dec: Angle.Degrees(+21.58690575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10959",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1796 AB"},
        {"Hipparcos Number", "HIP 10959"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.29768962),
        dec: Angle.Degrees(+21.58929102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126720"},
        {"Hipparcos Number", "HIP 70613"},
        {"Smithsonian Astrophysical Observation", "SAO 83355"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.65902906),
        dec: Angle.Degrees(+21.58958181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32301"},
        {"Hipparcos Number", "HIP 23497"},
        {"Fundamental Katalog 5th Edition", "FK5 184"},
        {"Geneva Identification System", "GEN# +5.20250129"},
        {"Smithsonian Astrophysical Observation", "SAO 76920"},
        {"Wilson Evans Batten Catalogue", "WEB 4575"},
    },
    visualMagnitude: 4.62,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.77376699),
        dec: Angle.Degrees(+21.59006170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205224"},
        {"Hipparcos Number", "HIP 106425"},
        {"Smithsonian Astrophysical Observation", "SAO 89796"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.33803647),
        dec: Angle.Degrees(+21.59028774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48177"},
        {"Hipparcos Number", "HIP 32164"},
        {"Smithsonian Astrophysical Observation", "SAO 78668"},
    },
    visualMagnitude: 9.04,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.74546360),
        dec: Angle.Degrees(+21.59284979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150781"},
        {"Hipparcos Number", "HIP 81799"},
        {"Smithsonian Astrophysical Observation", "SAO 84550"},
        {"Wilson Evans Batten Catalogue", "WEB 13821"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.60868084),
        dec: Angle.Degrees(+21.59287730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76353"},
        {"Smithsonian Astrophysical Observation", "SAO 83899"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.91940085),
        dec: Angle.Degrees(+21.59330899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51751",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7836 C"},
        {"Hipparcos Number", "HIP 51751"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.59682342),
        dec: Angle.Degrees(+21.59345361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15398"},
        {"Hipparcos Number", "HIP 11584"},
        {"Geneva Identification System", "GEN# +1.00015398"},
        {"Smithsonian Astrophysical Observation", "SAO 75400"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.32270854),
        dec: Angle.Degrees(+21.59385941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51752",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7836 A"},
        {"Henry Draper", "HD 91527"},
        {"Hipparcos Number", "HIP 51752"},
        {"Smithsonian Astrophysical Observation", "SAO 81420"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.60004258),
        dec: Angle.Degrees(+21.59401051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18106"},
        {"Hipparcos Number", "HIP 13589"},
        {"Smithsonian Astrophysical Observation", "SAO 75634"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.77001343),
        dec: Angle.Degrees(+21.59539005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88267",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10993 AB"},
        {"Henry Draper", "HD 164669"},
        {"Hipparcos Number", "HIP 88267"},
    },
    visualMagnitude: 4.26,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.37667886),
        dec: Angle.Degrees(+21.59568814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50693"},
        {"Hipparcos Number", "HIP 33262"},
        {"Smithsonian Astrophysical Observation", "SAO 78864"},
    },
    visualMagnitude: 8.71,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.79976841),
        dec: Angle.Degrees(+21.59723814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217924"},
        {"Hipparcos Number", "HIP 113884"},
        {"Geneva Identification System", "GEN# +1.00217924"},
        {"Smithsonian Astrophysical Observation", "SAO 90982"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.96078627),
        dec: Angle.Degrees(+21.59840434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192836"},
        {"Hipparcos Number", "HIP 99913"},
        {"Geneva Identification System", "GEN# +1.00192836"},
        {"Smithsonian Astrophysical Observation", "SAO 88433"},
        {"Wilson Evans Batten Catalogue", "WEB 17970"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.08242795),
        dec: Angle.Degrees(+21.59876279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92242"},
        {"Hipparcos Number", "HIP 52153"},
        {"Geneva Identification System", "GEN# +1.00092242"},
        {"Smithsonian Astrophysical Observation", "SAO 81453"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.82322915),
        dec: Angle.Degrees(+21.59975605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206430"},
        {"Hipparcos Number", "HIP 107100"},
        {"Smithsonian Astrophysical Observation", "SAO 89911"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.41005301),
        dec: Angle.Degrees(+21.60222426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91856"},
        {"Hipparcos Number", "HIP 51942"},
        {"Cincinnati Publication", "Ci 18 1280"},
        {"Geneva Identification System", "GEN# +1.00091856"},
        {"Smithsonian Astrophysical Observation", "SAO 81433"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.17167451),
        dec: Angle.Degrees(+21.60351218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -243.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40443"},
        {"Hipparcos Number", "HIP 28374"},
        {"Geneva Identification System", "GEN# +1.00040443"},
        {"Smithsonian Astrophysical Observation", "SAO 77813"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.91505025),
        dec: Angle.Degrees(+21.60426769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169888"},
        {"Hipparcos Number", "HIP 90338"},
        {"Smithsonian Astrophysical Observation", "SAO 86037"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.48628532),
        dec: Angle.Degrees(+21.60589192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163382"},
        {"Hipparcos Number", "HIP 87717"},
        {"Geneva Identification System", "GEN# +1.00163382"},
        {"Smithsonian Astrophysical Observation", "SAO 85539"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.76844001),
        dec: Angle.Degrees(+21.61008785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40266"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.34379786),
        dec: Angle.Degrees(+21.61058407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161198"},
        {"Hipparcos Number", "HIP 86722"},
        {"Cincinnati Publication", "Ci 20 1060"},
        {"Geneva Identification System", "GEN# +1.00161198"},
        {"Smithsonian Astrophysical Observation", "SAO 85357"},
        {"Wilson Evans Batten Catalogue", "WEB 14623"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.81550264),
        dec: Angle.Degrees(+21.61071579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -619.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61924"},
    },
    visualMagnitude: 11.69,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.36114699),
        dec: Angle.Degrees(+21.61399210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17046"},
        {"Hipparcos Number", "HIP 12819"},
        {"Geneva Identification System", "GEN# +1.00017046"},
        {"Smithsonian Astrophysical Observation", "SAO 75547"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.20054912),
        dec: Angle.Degrees(+21.61414301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51594"},
        {"Hipparcos Number", "HIP 33599"},
        {"Smithsonian Astrophysical Observation", "SAO 78935"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.71630523),
        dec: Angle.Degrees(+21.61465481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90511"},
        {"Hipparcos Number", "HIP 51187"},
        {"Smithsonian Astrophysical Observation", "SAO 81357"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.84071084),
        dec: Angle.Degrees(+21.61545208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13892",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2253 AB"},
        {"Henry Draper", "HD 18484"},
        {"Hipparcos Number", "HIP 13892"},
        {"Smithsonian Astrophysical Observation", "SAO 75671"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.72102934),
        dec: Angle.Degrees(+21.61777032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99457"},
        {"Hipparcos Number", "HIP 55842"},
        {"Smithsonian Astrophysical Observation", "SAO 81829"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.67676760),
        dec: Angle.Degrees(+21.61839154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28226"},
        {"Hipparcos Number", "HIP 20842"},
        {"Geneva Identification System", "GEN# +5.20250067"},
        {"Renson", "Renson 7200"},
        {"Smithsonian Astrophysical Observation", "SAO 76618"},
        {"Wilson Evans Batten Catalogue", "WEB 3997"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.00300662),
        dec: Angle.Degrees(+21.62000558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143514"},
        {"Hipparcos Number", "HIP 78368"},
        {"Smithsonian Astrophysical Observation", "SAO 84132"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.99173870),
        dec: Angle.Degrees(+21.62197386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36707"},
        {"Hipparcos Number", "HIP 26159"},
        {"Smithsonian Astrophysical Observation", "SAO 77269"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.65242973),
        dec: Angle.Degrees(+21.62229832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223130"},
        {"Hipparcos Number", "HIP 117284"},
        {"Geneva Identification System", "GEN# +1.00223130"},
        {"Smithsonian Astrophysical Observation", "SAO 91481"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.72112824),
        dec: Angle.Degrees(+21.62252831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75600"},
    },
    visualMagnitude: 11.20,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.69169304),
        dec: Angle.Degrees(+21.62304826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183459"},
        {"Hipparcos Number", "HIP 95784"},
        {"Geneva Identification System", "GEN# +1.00183459"},
        {"Smithsonian Astrophysical Observation", "SAO 87265"},
        {"Wilson Evans Batten Catalogue", "WEB 16765"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.23191433),
        dec: Angle.Degrees(+21.62421204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4432"},
        {"Hipparcos Number", "HIP 3650"},
        {"Geneva Identification System", "GEN# +1.00004432"},
        {"Smithsonian Astrophysical Observation", "SAO 74261"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.68668468),
        dec: Angle.Degrees(+21.62437691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54559"},
        {"Geneva Identification System", "GEN# +6.20030280"},
    },
    visualMagnitude: 10.99,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.46826095),
        dec: Angle.Degrees(+21.62556331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82071"},
        {"Fundamental Katalog 5th Edition", "FK5 5480"},
        {"Smithsonian Astrophysical Observation", "SAO 84586"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.45582576),
        dec: Angle.Degrees(+21.62558534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198268"},
        {"Hipparcos Number", "HIP 102701"},
        {"Smithsonian Astrophysical Observation", "SAO 89150"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.13875191),
        dec: Angle.Degrees(+21.62667175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60556"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.20471536),
        dec: Angle.Degrees(+21.62760922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74746"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.13825010),
        dec: Angle.Degrees(+21.63079908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28676"},
        {"Hipparcos Number", "HIP 21158"},
        {"Geneva Identification System", "GEN# +1.00028676"},
        {"Smithsonian Astrophysical Observation", "SAO 76645"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.03294912),
        dec: Angle.Degrees(+21.63236503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104175"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.60402015),
        dec: Angle.Degrees(+21.63523107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111255"},
        {"Hipparcos Number", "HIP 62441"},
        {"Geneva Identification System", "GEN# +1.00111255"},
        {"Smithsonian Astrophysical Observation", "SAO 82497"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.96270777),
        dec: Angle.Degrees(+21.63663042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66595"},
        {"Geneva Identification System", "GEN# +0.02202613"},
        {"Smithsonian Astrophysical Observation", "SAO 82925"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.76172830),
        dec: Angle.Degrees(+21.63901303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111542"},
        {"Hipparcos Number", "HIP 62616"},
        {"Geneva Identification System", "GEN# +1.00111542"},
        {"Renson", "Renson 32370"},
        {"Smithsonian Astrophysical Observation", "SAO 82520"},
        {"Wilson Evans Batten Catalogue", "WEB 11112"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.45821238),
        dec: Angle.Degrees(+21.64082269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259736"},
        {"Hipparcos Number", "HIP 31366"},
        {"Smithsonian Astrophysical Observation", "SAO 78517"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.65243229),
        dec: Angle.Degrees(+21.64223584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32481"},
        {"Hipparcos Number", "HIP 23592"},
        {"Smithsonian Astrophysical Observation", "SAO 76940"},
        {"Wilson Evans Batten Catalogue", "WEB 4596"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.09192933),
        dec: Angle.Degrees(+21.64356134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19971"},
        {"Hipparcos Number", "HIP 14993"},
        {"Smithsonian Astrophysical Observation", "SAO 75799"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.31198027),
        dec: Angle.Degrees(+21.64480951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44974"},
        {"Hipparcos Number", "HIP 30588"},
        {"Fundamental Katalog 5th Edition", "FK5 4584"},
        {"Geneva Identification System", "GEN# +1.00044974"},
        {"Smithsonian Astrophysical Observation", "SAO 78355"},
        {"Wilson Evans Batten Catalogue", "WEB 6097"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.42805341),
        dec: Angle.Degrees(+21.64505491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165524"},
        {"Hipparcos Number", "HIP 88604"},
        {"Geneva Identification System", "GEN# +1.00165524"},
        {"Smithsonian Astrophysical Observation", "SAO 85718"},
        {"Wilson Evans Batten Catalogue", "WEB 15006"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.37553926),
        dec: Angle.Degrees(+21.64661981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347302"},
        {"Hipparcos Number", "HIP 102091"},
        {"Smithsonian Astrophysical Observation", "SAO 89008"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.34587700),
        dec: Angle.Degrees(+21.64852209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148529"},
        {"Hipparcos Number", "HIP 80639"},
        {"Geneva Identification System", "GEN# +1.00148529"},
        {"Smithsonian Astrophysical Observation", "SAO 84392"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.97493506),
        dec: Angle.Degrees(+21.65297259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183013"},
        {"Hipparcos Number", "HIP 95608"},
        {"Celescope Catalog", "CEL 4752"},
        {"Geneva Identification System", "GEN# +1.00183013"},
        {"Smithsonian Astrophysical Observation", "SAO 87216"},
        {"Wilson Evans Batten Catalogue", "WEB 16721"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.68611543),
        dec: Angle.Degrees(+21.65313192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42965"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.36652011),
        dec: Angle.Degrees(+21.65362177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38390"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.96027171),
        dec: Angle.Degrees(+21.65390120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147507"},
        {"Hipparcos Number", "HIP 80156"},
        {"Geneva Identification System", "GEN# +1.00147507"},
        {"Smithsonian Astrophysical Observation", "SAO 84326"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.42306386),
        dec: Angle.Degrees(+21.65404142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170897"},
        {"Hipparcos Number", "HIP 90751"},
        {"Geneva Identification System", "GEN# +1.00170897"},
        {"Smithsonian Astrophysical Observation", "SAO 86145"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.74575371),
        dec: Angle.Degrees(+21.65472965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29976"},
        {"Hipparcos Number", "HIP 22042"},
        {"Smithsonian Astrophysical Observation", "SAO 76733"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.09495775),
        dec: Angle.Degrees(+21.65761507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10966"},
        {"Hipparcos Number", "HIP 8384"},
        {"Geneva Identification System", "GEN# +1.00010966"},
        {"Smithsonian Astrophysical Observation", "SAO 74941"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.02125811),
        dec: Angle.Degrees(+21.65876124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18803"},
        {"Smithsonian Astrophysical Observation", "SAO 76398"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.43794534),
        dec: Angle.Degrees(+21.65939250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86738"},
        {"Smithsonian Astrophysical Observation", "SAO 85361"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.85823806),
        dec: Angle.Degrees(+21.66213276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37214"},
        {"Geneva Identification System", "GEN# +0.02101652"},
        {"Smithsonian Astrophysical Observation", "SAO 79575"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.66453421),
        dec: Angle.Degrees(+21.66593682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40325"},
        {"Smithsonian Astrophysical Observation", "SAO 80028"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.51161456),
        dec: Angle.Degrees(+21.66797151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223755"},
        {"Hipparcos Number", "HIP 117710"},
        {"Geneva Identification System", "GEN# +1.00223755"},
        {"Smithsonian Astrophysical Observation", "SAO 91548"},
        {"Wilson Evans Batten Catalogue", "WEB 20715"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.09759194),
        dec: Angle.Degrees(+21.67111367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38678",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6455 A"},
        {"Henry Draper", "HD 64535"},
        {"Hipparcos Number", "HIP 38678"},
        {"Geneva Identification System", "GEN# +1.00064535J"},
        {"Smithsonian Astrophysical Observation", "SAO 79794"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.78579901),
        dec: Angle.Degrees(+21.67132485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78749"},
        {"Hipparcos Number", "HIP 45046"},
        {"Geneva Identification System", "GEN# +1.00078749"},
        {"Smithsonian Astrophysical Observation", "SAO 80677"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.62486531),
        dec: Angle.Degrees(+21.67136463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284884"},
        {"Hipparcos Number", "HIP 22855"},
        {"Smithsonian Astrophysical Observation", "SAO 76832"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.76382088),
        dec: Angle.Degrees(+21.67164060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80520"},
        {"Hipparcos Number", "HIP 45844"},
        {"Smithsonian Astrophysical Observation", "SAO 80774"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.20138522),
        dec: Angle.Degrees(+21.67181303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83056"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.57081737),
        dec: Angle.Degrees(+21.67268119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344502"},
        {"Hipparcos Number", "HIP 95890"},
        {"Geneva Identification System", "GEN# +1.00344502"},
        {"Wilson Evans Batten Catalogue", "WEB 16789"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.52338993),
        dec: Angle.Degrees(+21.67660689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151952"},
        {"Hipparcos Number", "HIP 82368"},
        {"Smithsonian Astrophysical Observation", "SAO 84627"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.45810143),
        dec: Angle.Degrees(+21.67778819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103843",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14570 C"},
        {"Henry Draper", "HD 200372"},
        {"Hipparcos Number", "HIP 103843"},
        {"Smithsonian Astrophysical Observation", "SAO 89395"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.63081937),
        dec: Angle.Degrees(+21.68086326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77411"},
        {"Smithsonian Astrophysical Observation", "SAO 84008"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.05397176),
        dec: Angle.Degrees(+21.68792241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150256"},
        {"Hipparcos Number", "HIP 81515"},
        {"Geneva Identification System", "GEN# +1.00150256"},
        {"Smithsonian Astrophysical Observation", "SAO 84505"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.75757207),
        dec: Angle.Degrees(+21.68801709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29158"},
        {"Hipparcos Number", "HIP 21442"},
        {"Geneva Identification System", "GEN# +1.00029158"},
        {"Smithsonian Astrophysical Observation", "SAO 76669"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.07317115),
        dec: Angle.Degrees(+21.68938095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86897"},
        {"Hipparcos Number", "HIP 49172"},
        {"Smithsonian Astrophysical Observation", "SAO 81150"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.52415299),
        dec: Angle.Degrees(+21.69115762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103852",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14570 AB"},
        {"Henry Draper", "HD 200392"},
        {"Hipparcos Number", "HIP 103852"},
        {"Smithsonian Astrophysical Observation", "SAO 89397"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.65034802),
        dec: Angle.Degrees(+21.69117163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49120"},
        {"Hipparcos Number", "HIP 32571"},
        {"Smithsonian Astrophysical Observation", "SAO 78750"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.94796366),
        dec: Angle.Degrees(+21.69157348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101025"},
        {"Hipparcos Number", "HIP 56717"},
        {"Geneva Identification System", "GEN# +1.00101025"},
        {"Smithsonian Astrophysical Observation", "SAO 81909"},
        {"Wilson Evans Batten Catalogue", "WEB 10199"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.42675065),
        dec: Angle.Degrees(+21.69174277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76310"},
        {"Hipparcos Number", "HIP 43855"},
        {"Geneva Identification System", "GEN# +1.00076310"},
        {"Renson", "Renson 21390"},
        {"Smithsonian Astrophysical Observation", "SAO 80514"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.99577532),
        dec: Angle.Degrees(+21.69223595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93700"},
        {"Hipparcos Number", "HIP 52930"},
        {"Renson", "Renson 27095"},
        {"Smithsonian Astrophysical Observation", "SAO 81538"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.37353888),
        dec: Angle.Degrees(+21.69436613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154890"},
        {"Hipparcos Number", "HIP 83775"},
        {"Smithsonian Astrophysical Observation", "SAO 84855"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.83422072),
        dec: Angle.Degrees(+21.69491874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341481"},
        {"Hipparcos Number", "HIP 88249"},
        {"Smithsonian Astrophysical Observation", "SAO 85641"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.30333391),
        dec: Angle.Degrees(+21.69505294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121996"},
        {"Hipparcos Number", "HIP 68276"},
        {"Fundamental Katalog 5th Edition", "FK5 3113"},
        {"Geneva Identification System", "GEN# +1.00121996"},
        {"Smithsonian Astrophysical Observation", "SAO 83103"},
        {"Wilson Evans Batten Catalogue", "WEB 11978"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.66220328),
        dec: Angle.Degrees(+21.69632104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178476"},
        {"Hipparcos Number", "HIP 93975"},
        {"Geneva Identification System", "GEN# +1.00178476"},
        {"Smithsonian Astrophysical Observation", "SAO 86843"},
        {"Wilson Evans Batten Catalogue", "WEB 16354"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.01456055),
        dec: Angle.Degrees(+21.69874452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109216"},
        {"Hipparcos Number", "HIP 61239"},
        {"Geneva Identification System", "GEN# +1.00109216"},
        {"Smithsonian Astrophysical Observation", "SAO 82373"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.23827609),
        dec: Angle.Degrees(+21.69973581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140514"},
        {"Hipparcos Number", "HIP 76984"},
        {"Geneva Identification System", "GEN# +1.00140514"},
        {"Smithsonian Astrophysical Observation", "SAO 83962"},
        {"Wilson Evans Batten Catalogue", "WEB 13059"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.79358431),
        dec: Angle.Degrees(+21.70149197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215595"},
        {"Hipparcos Number", "HIP 112401"},
        {"Smithsonian Astrophysical Observation", "SAO 90769"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.50499010),
        dec: Angle.Degrees(+21.70193940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199123"},
        {"Hipparcos Number", "HIP 103197"},
        {"Smithsonian Astrophysical Observation", "SAO 89264"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.61718803),
        dec: Angle.Degrees(+21.70308359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210129"},
        {"Hipparcos Number", "HIP 109240"},
        {"Geneva Identification System", "GEN# +1.00210129"},
        {"Smithsonian Astrophysical Observation", "SAO 90252"},
        {"Wilson Evans Batten Catalogue", "WEB 19632"},
    },
    visualMagnitude: 5.79,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.95971953),
        dec: Angle.Degrees(+21.70309155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32991"},
        {"Hipparcos Number", "HIP 23883"},
        {"Geneva Identification System", "GEN# +1.00032991"},
        {"Smithsonian Astrophysical Observation", "SAO 76972"},
        {"Wilson Evans Batten Catalogue", "WEB 4658"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.98097847),
        dec: Angle.Degrees(+21.70483596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35888"},
        {"Smithsonian Astrophysical Observation", "SAO 79359"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.98199267),
        dec: Angle.Degrees(+21.70499729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5563"},
        {"Smithsonian Astrophysical Observation", "SAO 74542"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.83554201),
        dec: Angle.Degrees(+21.70534566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111573"},
        {"Smithsonian Astrophysical Observation", "SAO 90631"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.05012162),
        dec: Angle.Degrees(+21.70570598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130483"},
        {"Hipparcos Number", "HIP 72382"},
        {"Geneva Identification System", "GEN# +1.00130483"},
        {"Smithsonian Astrophysical Observation", "SAO 83529"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.99830739),
        dec: Angle.Degrees(+21.70679734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8848"},
        {"Hipparcos Number", "HIP 6808"},
        {"Smithsonian Astrophysical Observation", "SAO 74736"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.90119364),
        dec: Angle.Degrees(+21.70817144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38871",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38871"},
        {"Smithsonian Astrophysical Observation", "SAO 79820"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.32317539),
        dec: Angle.Degrees(+21.70928605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344590"},
        {"Hipparcos Number", "HIP 96261"},
        {"Geneva Identification System", "GEN# +1.00344590"},
        {"Renson", "Renson 50940"},
        {"Smithsonian Astrophysical Observation", "SAO 87370"},
        {"Wilson Evans Batten Catalogue", "WEB 16873"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.58873438),
        dec: Angle.Degrees(+21.70991497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47052"},
        {"Hipparcos Number", "HIP 31663"},
        {"Smithsonian Astrophysical Observation", "SAO 78560"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.40594425),
        dec: Angle.Degrees(+21.71023511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142179"},
        {"Hipparcos Number", "HIP 77741"},
        {"Geneva Identification System", "GEN# +1.00142179"},
        {"Smithsonian Astrophysical Observation", "SAO 84048"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.07926921),
        dec: Angle.Degrees(+21.71039453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1615"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.05211081),
        dec: Angle.Degrees(+21.71268094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1006"},
    },
    visualMagnitude: 11.67,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.13913761),
        dec: Angle.Degrees(+21.71414164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -289.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50275"},
        {"Hipparcos Number", "HIP 33086"},
        {"Smithsonian Astrophysical Observation", "SAO 78834"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.35927816),
        dec: Angle.Degrees(+21.71830298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284387"},
        {"Hipparcos Number", "HIP 20526"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.97616849),
        dec: Angle.Degrees(+21.71940013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158210"},
        {"Hipparcos Number", "HIP 85402"},
        {"Geneva Identification System", "GEN# +1.00158210"},
        {"Smithsonian Astrophysical Observation", "SAO 85102"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.77786851),
        dec: Angle.Degrees(+21.71958938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70131"},
        {"Smithsonian Astrophysical Observation", "SAO 83301"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.25959767),
        dec: Angle.Degrees(+21.72022784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101950",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14123 A"},
        {"Henry Draper", "HD 196882"},
        {"Hipparcos Number", "HIP 101950"},
        {"Geneva Identification System", "GEN# +1.00196882A"},
        {"Smithsonian Astrophysical Observation", "SAO 88967"},
        {"Wilson Evans Batten Catalogue", "WEB 18428"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.89278553),
        dec: Angle.Degrees(+21.72131515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222019"},
        {"Hipparcos Number", "HIP 116527"},
        {"Smithsonian Astrophysical Observation", "SAO 91379"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.23547006),
        dec: Angle.Degrees(+21.72311738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6917",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1176 A"},
        {"Henry Draper", "HD 8997"},
        {"Hipparcos Number", "HIP 6917"},
        {"Cincinnati Publication", "Ci 20 105"},
        {"Geneva Identification System", "GEN# +1.00008997"},
        {"Smithsonian Astrophysical Observation", "SAO 74742"},
        {"Wilson Evans Batten Catalogue", "WEB 1505"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.26920867),
        dec: Angle.Degrees(+21.72361547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 455.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14310"},
        {"Smithsonian Astrophysical Observation", "SAO 75717"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.14806671),
        dec: Angle.Degrees(+21.72399708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6301"},
        {"Wilson Evans Batten Catalogue", "WEB 1406"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.21817894),
        dec: Angle.Degrees(+21.72868698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22060"},
        {"Hipparcos Number", "HIP 16643"},
        {"Smithsonian Astrophysical Observation", "SAO 75995"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.53647369),
        dec: Angle.Degrees(+21.72899535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104612"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.87055085),
        dec: Angle.Degrees(+21.73360785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62957"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.52068231),
        dec: Angle.Degrees(+21.73508853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204415"},
        {"Hipparcos Number", "HIP 105978"},
        {"Geneva Identification System", "GEN# +1.00204415"},
        {"Smithsonian Astrophysical Observation", "SAO 89721"},
        {"Wilson Evans Batten Catalogue", "WEB 19212"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.95054950),
        dec: Angle.Degrees(+21.73580717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27808"},
        {"Hipparcos Number", "HIP 20557"},
        {"Geneva Identification System", "GEN# +5.20250048"},
        {"Smithsonian Astrophysical Observation", "SAO 76593"},
        {"Wilson Evans Batten Catalogue", "WEB 3931"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.06041707),
        dec: Angle.Degrees(+21.73635708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285019"},
        {"Hipparcos Number", "HIP 23167"},
        {"Smithsonian Astrophysical Observation", "SAO 76870"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.76120307),
        dec: Angle.Degrees(+21.73661280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341534"},
        {"Hipparcos Number", "HIP 88519"},
        {"Smithsonian Astrophysical Observation", "SAO 85703"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.14132874),
        dec: Angle.Degrees(+21.73956200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124139"},
        {"Hipparcos Number", "HIP 69308"},
        {"Geneva Identification System", "GEN# +1.00124139"},
        {"Smithsonian Astrophysical Observation", "SAO 83208"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.79830931),
        dec: Angle.Degrees(+21.74176959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149560"},
        {"Hipparcos Number", "HIP 81177"},
        {"Smithsonian Astrophysical Observation", "SAO 84461"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.71244526),
        dec: Angle.Degrees(+21.74247228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223792"},
        {"Hipparcos Number", "HIP 117735"},
        {"Smithsonian Astrophysical Observation", "SAO 91552"},
        {"Wilson Evans Batten Catalogue", "WEB 20720"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.16754899),
        dec: Angle.Degrees(+21.74260042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171681"},
        {"Hipparcos Number", "HIP 91127"},
        {"Smithsonian Astrophysical Observation", "SAO 86218"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.82349823),
        dec: Angle.Degrees(+21.74354691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3577"},
        {"Hipparcos Number", "HIP 3052"},
        {"Geneva Identification System", "GEN# +1.00003577"},
        {"Smithsonian Astrophysical Observation", "SAO 74166"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.68932309),
        dec: Angle.Degrees(+21.74468998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101059"},
        {"Hipparcos Number", "HIP 56732"},
        {"Geneva Identification System", "GEN# +1.00101059"},
        {"Smithsonian Astrophysical Observation", "SAO 81912"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.47459042),
        dec: Angle.Degrees(+21.74509058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 638",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 638"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.95053905),
        dec: Angle.Degrees(+21.74565092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58707",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8400 AB"},
        {"Henry Draper", "HD 104558"},
        {"Hipparcos Number", "HIP 58707"},
        {"Smithsonian Astrophysical Observation", "SAO 82112"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.62135308),
        dec: Angle.Degrees(+21.74680895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14715",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2375 AB"},
        {"Henry Draper", "HD 19616"},
        {"Hipparcos Number", "HIP 14715"},
        {"Smithsonian Astrophysical Observation", "SAO 75764"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.52719511),
        dec: Angle.Degrees(+21.74716264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111630"},
        {"Smithsonian Astrophysical Observation", "SAO 90645"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.21544461),
        dec: Angle.Degrees(+21.74842618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67793"},
        {"Geneva Identification System", "GEN# +0.02202644"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.32143616),
        dec: Angle.Degrees(+21.75005050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183282"},
        {"Hipparcos Number", "HIP 95705"},
        {"Geneva Identification System", "GEN# +1.00183282"},
        {"Smithsonian Astrophysical Observation", "SAO 87242"},
        {"Wilson Evans Batten Catalogue", "WEB 16744"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.00407157),
        dec: Angle.Degrees(+21.75410045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147697"},
        {"Hipparcos Number", "HIP 80226"},
        {"Smithsonian Astrophysical Observation", "SAO 84334"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.65958730),
        dec: Angle.Degrees(+21.75670837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189088"},
        {"Hipparcos Number", "HIP 98214"},
        {"Smithsonian Astrophysical Observation", "SAO 87977"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.37187357),
        dec: Angle.Degrees(+21.75692966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11315"},
    },
    visualMagnitude: 11.42,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.41510402),
        dec: Angle.Degrees(+21.76059338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32921",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5511 A"},
        {"Henry Draper", "HD 49908"},
        {"Hipparcos Number", "HIP 32921"},
        {"Fundamental Katalog 5th Edition", "FK5 2530"},
        {"Geneva Identification System", "GEN# +1.00049908"},
        {"Smithsonian Astrophysical Observation", "SAO 78805"},
        {"Wilson Evans Batten Catalogue", "WEB 6625"},
    },
    visualMagnitude: 5.28,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.88770733),
        dec: Angle.Degrees(+21.76123162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37439"},
        {"Hipparcos Number", "HIP 26616"},
        {"Celescope Catalog", "CEL 894"},
        {"Geneva Identification System", "GEN# +1.00037439"},
        {"Smithsonian Astrophysical Observation", "SAO 77358"},
        {"Wilson Evans Batten Catalogue", "WEB 5249"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.86294295),
        dec: Angle.Degrees(+21.76300696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201294"},
        {"Hipparcos Number", "HIP 104327"},
        {"Geneva Identification System", "GEN# +1.00201294"},
        {"Smithsonian Astrophysical Observation", "SAO 89476"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.00545106),
        dec: Angle.Degrees(+21.76475246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169414"},
        {"Hipparcos Number", "HIP 90139"},
        {"Fundamental Katalog 5th Edition", "FK5 690"},
        {"Geneva Identification System", "GEN# +1.00169414"},
        {"Smithsonian Astrophysical Observation", "SAO 86003"},
        {"Wilson Evans Batten Catalogue", "WEB 15411"},
    },
    visualMagnitude: 3.85,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.92402821),
        dec: Angle.Degrees(+21.77034249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187075"},
        {"Hipparcos Number", "HIP 97359"},
        {"Geneva Identification System", "GEN# +1.00187075"},
        {"Smithsonian Astrophysical Observation", "SAO 87719"},
        {"Wilson Evans Batten Catalogue", "WEB 17109"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.82721186),
        dec: Angle.Degrees(+21.77150528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129618"},
        {"Hipparcos Number", "HIP 71954"},
        {"Geneva Identification System", "GEN# +1.00129618"},
        {"Smithsonian Astrophysical Observation", "SAO 83479"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.74598593),
        dec: Angle.Degrees(+21.77267058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27309"},
        {"Hipparcos Number", "HIP 20186"},
        {"Geneva Identification System", "GEN# +1.00027309"},
        {"Renson", "Renson 7010"},
        {"Smithsonian Astrophysical Observation", "SAO 76551"},
        {"Wilson Evans Batten Catalogue", "WEB 3847"},
    },
    visualMagnitude: 5.34,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.90286245),
        dec: Angle.Degrees(+21.77359174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1358",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 226 AB"},
        {"Hipparcos Number", "HIP 1358"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.25579433),
        dec: Angle.Degrees(+21.77421126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103955"},
        {"Hipparcos Number", "HIP 58383"},
        {"Geneva Identification System", "GEN# +1.00103955"},
        {"Smithsonian Astrophysical Observation", "SAO 82081"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.57738045),
        dec: Angle.Degrees(+21.77571656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341755"},
        {"Hipparcos Number", "HIP 89120"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.82906018),
        dec: Angle.Degrees(+21.77605496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2891"},
        {"Hipparcos Number", "HIP 2549"},
        {"Smithsonian Astrophysical Observation", "SAO 74078"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.09879150),
        dec: Angle.Degrees(+21.77818654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99120"},
        {"Hipparcos Number", "HIP 55681"},
        {"Geneva Identification System", "GEN# +1.00099120"},
        {"Smithsonian Astrophysical Observation", "SAO 81808"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.13900210),
        dec: Angle.Degrees(+21.77932705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178541"},
        {"Hipparcos Number", "HIP 93984"},
        {"Smithsonian Astrophysical Observation", "SAO 86851"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.03538058),
        dec: Angle.Degrees(+21.77971205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22339"},
        {"Hipparcos Number", "HIP 16828"},
        {"Smithsonian Astrophysical Observation", "SAO 76022"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.12598913),
        dec: Angle.Degrees(+21.78018794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79991"},
        {"Hipparcos Number", "HIP 45611"},
        {"Geneva Identification System", "GEN# +1.00079991"},
        {"Smithsonian Astrophysical Observation", "SAO 80747"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.45749789),
        dec: Angle.Degrees(+21.78159828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221104"},
        {"Hipparcos Number", "HIP 115904"},
        {"Smithsonian Astrophysical Observation", "SAO 91294"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.24799254),
        dec: Angle.Degrees(+21.78278394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78174"},
        {"Smithsonian Astrophysical Observation", "SAO 84099"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.42767576),
        dec: Angle.Degrees(+21.78479434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243528"},
        {"Hipparcos Number", "HIP 25390"},
        {"Smithsonian Astrophysical Observation", "SAO 77162"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.47452707),
        dec: Angle.Degrees(+21.78592612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181632"},
        {"Hipparcos Number", "HIP 95058"},
        {"Smithsonian Astrophysical Observation", "SAO 87092"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.11834805),
        dec: Angle.Degrees(+21.78833487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79955"},
        {"Fundamental Katalog 5th Edition", "FK5 5439"},
        {"Smithsonian Astrophysical Observation", "SAO 84301"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.80229776),
        dec: Angle.Degrees(+21.78862687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59233"},
        {"Cincinnati Publication", "Ci 20 685"},
        {"Geneva Identification System", "GEN# +0.02202442"},
        {"Smithsonian Astrophysical Observation", "SAO 82153"},
        {"Wilson Evans Batten Catalogue", "WEB 10537"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.22879843),
        dec: Angle.Degrees(+21.78864381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -392.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87994"},
        {"Hipparcos Number", "HIP 49735"},
        {"Smithsonian Astrophysical Observation", "SAO 81206"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.29351867),
        dec: Angle.Degrees(+21.79037349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33415"},
        {"Hipparcos Number", "HIP 24129"},
        {"Geneva Identification System", "GEN# +1.00033415"},
        {"Smithsonian Astrophysical Observation", "SAO 77016"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.74162396),
        dec: Angle.Degrees(+21.79094059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78269",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9865 A"},
        {"Henry Draper", "HD 143314"},
        {"Hipparcos Number", "HIP 78269"},
        {"Smithsonian Astrophysical Observation", "SAO 84115"},
    },
    visualMagnitude: 8.46,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.72223658),
        dec: Angle.Degrees(+21.79119856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34469"},
        {"Hipparcos Number", "HIP 24761"},
        {"Geneva Identification System", "GEN# +1.00034469"},
        {"Smithsonian Astrophysical Observation", "SAO 77092"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.63179381),
        dec: Angle.Degrees(+21.79243083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208550"},
        {"Hipparcos Number", "HIP 108311"},
        {"Smithsonian Astrophysical Observation", "SAO 90116"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.13503300),
        dec: Angle.Degrees(+21.79369187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4030"},
        {"Hipparcos Number", "HIP 3377"},
        {"Smithsonian Astrophysical Observation", "SAO 74219"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.73480516),
        dec: Angle.Degrees(+21.79465092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108943"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.07552455),
        dec: Angle.Degrees(+21.79510448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346049"},
        {"Hipparcos Number", "HIP 99497"},
        {"Smithsonian Astrophysical Observation", "SAO 88323"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.88634437),
        dec: Angle.Degrees(+21.79604852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52422"},
        {"Hipparcos Number", "HIP 33890"},
        {"Smithsonian Astrophysical Observation", "SAO 78992"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.52304766),
        dec: Angle.Degrees(+21.79808607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78272",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9865 BC"},
        {"Henry Draper", "HD 143315"},
        {"Hipparcos Number", "HIP 78272"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.73695920),
        dec: Angle.Degrees(+21.79855919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196505"},
        {"Hipparcos Number", "HIP 101741"},
        {"Smithsonian Astrophysical Observation", "SAO 88905"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.31766366),
        dec: Angle.Degrees(+21.80385693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45879"},
        {"Hipparcos Number", "HIP 31053"},
        {"Geneva Identification System", "GEN# +1.00045879"},
        {"Smithsonian Astrophysical Observation", "SAO 78460"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.74022864),
        dec: Angle.Degrees(+21.80473553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69339"},
        {"Smithsonian Astrophysical Observation", "SAO 83212"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.88014908),
        dec: Angle.Degrees(+21.80494304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6214"},
        {"Hipparcos Number", "HIP 4947"},
        {"Smithsonian Astrophysical Observation", "SAO 74454"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.86346789),
        dec: Angle.Degrees(+21.80517211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94835"},
        {"Hipparcos Number", "HIP 53537"},
        {"Cincinnati Publication", "Ci 18 1330"},
        {"Geneva Identification System", "GEN# +1.00094835"},
        {"Smithsonian Astrophysical Observation", "SAO 81595"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.29023159),
        dec: Angle.Degrees(+21.80537901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108988"},
        {"Smithsonian Astrophysical Observation", "SAO 90209"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.19115908),
        dec: Angle.Degrees(+21.80930555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200426"},
        {"Hipparcos Number", "HIP 103870"},
        {"Smithsonian Astrophysical Observation", "SAO 89402"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.70030264),
        dec: Angle.Degrees(+21.80998761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181725"},
        {"Hipparcos Number", "HIP 95095"},
        {"Smithsonian Astrophysical Observation", "SAO 87098"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.19688378),
        dec: Angle.Degrees(+21.81158414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147546"},
        {"Hipparcos Number", "HIP 80164"},
        {"Smithsonian Astrophysical Observation", "SAO 84327"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.46666822),
        dec: Angle.Degrees(+21.81218217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82105"},
        {"Hipparcos Number", "HIP 46621"},
        {"Smithsonian Astrophysical Observation", "SAO 80864"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.59825471),
        dec: Angle.Degrees(+21.81274377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33018"},
        {"Hipparcos Number", "HIP 23909"},
        {"Smithsonian Astrophysical Observation", "SAO 76975"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.05811613),
        dec: Angle.Degrees(+21.81334235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180889"},
        {"Hipparcos Number", "HIP 94812"},
        {"Geneva Identification System", "GEN# +1.00180889"},
        {"Smithsonian Astrophysical Observation", "SAO 87031"},
        {"Wilson Evans Batten Catalogue", "WEB 16546"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.38267963),
        dec: Angle.Degrees(+21.81386311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70916"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.53619839),
        dec: Angle.Degrees(+21.81527576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211923"},
        {"Hipparcos Number", "HIP 110274"},
        {"Smithsonian Astrophysical Observation", "SAO 90426"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.05226228),
        dec: Angle.Degrees(+21.81702279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196821"},
        {"Hipparcos Number", "HIP 101919"},
        {"Geneva Identification System", "GEN# +1.00196821"},
        {"Renson", "Renson 54920"},
        {"Smithsonian Astrophysical Observation", "SAO 88959"},
        {"Wilson Evans Batten Catalogue", "WEB 18418"},
    },
    visualMagnitude: 6.08,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.79428967),
        dec: Angle.Degrees(+21.81740583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51085"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.56186330),
        dec: Angle.Degrees(+21.81759157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119618"},
        {"Hipparcos Number", "HIP 67010"},
        {"Geneva Identification System", "GEN# +1.00119618"},
        {"Smithsonian Astrophysical Observation", "SAO 82971"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.99632214),
        dec: Angle.Degrees(+21.81810011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218302"},
        {"Hipparcos Number", "HIP 114117"},
        {"Smithsonian Astrophysical Observation", "SAO 91014"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.66970644),
        dec: Angle.Degrees(+21.81859712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257520"},
        {"Hipparcos Number", "HIP 30771"},
        {"Smithsonian Astrophysical Observation", "SAO 78401"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.98928122),
        dec: Angle.Degrees(+21.81937145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24543"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.98229450),
        dec: Angle.Degrees(+21.82194201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 245.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16423"},
        {"Smithsonian Astrophysical Observation", "SAO 75975"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.86803190),
        dec: Angle.Degrees(+21.82202825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144889"},
        {"Hipparcos Number", "HIP 78985"},
        {"Geneva Identification System", "GEN# +1.00144889"},
        {"Smithsonian Astrophysical Observation", "SAO 84202"},
        {"Wilson Evans Batten Catalogue", "WEB 13352"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.84244021),
        dec: Angle.Degrees(+21.82271909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87371"},
        {"Hipparcos Number", "HIP 49399"},
        {"Smithsonian Astrophysical Observation", "SAO 81170"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.27345033),
        dec: Angle.Degrees(+21.82419623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73819"},
        {"Smithsonian Astrophysical Observation", "SAO 83651"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.31848453),
        dec: Angle.Degrees(+21.82569374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171426"},
        {"Hipparcos Number", "HIP 91006"},
        {"Smithsonian Astrophysical Observation", "SAO 86196"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.47528475),
        dec: Angle.Degrees(+21.82745551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343425"},
        {"Hipparcos Number", "HIP 92982"},
        {"Smithsonian Astrophysical Observation", "SAO 86601"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.14412213),
        dec: Angle.Degrees(+21.82759748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99444"},
        {"Hipparcos Number", "HIP 55838"},
        {"Smithsonian Astrophysical Observation", "SAO 81827"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.66815130),
        dec: Angle.Degrees(+21.82893541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38853"},
        {"Hipparcos Number", "HIP 27519"},
        {"Smithsonian Astrophysical Observation", "SAO 77607"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.40815672),
        dec: Angle.Degrees(+21.82901834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145273"},
        {"Hipparcos Number", "HIP 79159"},
        {"Smithsonian Astrophysical Observation", "SAO 84216"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.34179091),
        dec: Angle.Degrees(+21.82959053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33658"},
        {"Hipparcos Number", "HIP 24285"},
        {"Smithsonian Astrophysical Observation", "SAO 77033"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.17959122),
        dec: Angle.Degrees(+21.83008361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110349"},
        {"Hipparcos Number", "HIP 61914"},
        {"Smithsonian Astrophysical Observation", "SAO 82441"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.34474983),
        dec: Angle.Degrees(+21.83040557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60633"},
        {"Geneva Identification System", "GEN# +0.02202471"},
        {"Smithsonian Astrophysical Observation", "SAO 82301"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.39599310),
        dec: Angle.Degrees(+21.83271632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107511"},
        {"Smithsonian Astrophysical Observation", "SAO 89977"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.61872380),
        dec: Angle.Degrees(+21.83392899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37783"},
        {"Smithsonian Astrophysical Observation", "SAO 79661"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.20265772),
        dec: Angle.Degrees(+21.83467291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39507"},
        {"Hipparcos Number", "HIP 27877"},
        {"Fundamental Katalog 5th Edition", "FK5 4536"},
        {"Smithsonian Astrophysical Observation", "SAO 77699"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.49323187),
        dec: Angle.Degrees(+21.83630339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53163"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.13953929),
        dec: Angle.Degrees(+21.84054569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184385"},
        {"Hipparcos Number", "HIP 96183"},
        {"Fundamental Katalog 5th Edition", "FK5 5721"},
        {"Geneva Identification System", "GEN# +1.00184385"},
        {"Smithsonian Astrophysical Observation", "SAO 87351"},
        {"Wilson Evans Batten Catalogue", "WEB 16854"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.35652595),
        dec: Angle.Degrees(+21.84082728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -204.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74146"},
        {"Smithsonian Astrophysical Observation", "SAO 83688"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.26187357),
        dec: Angle.Degrees(+21.84099391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22637"},
        {"Hipparcos Number", "HIP 17043"},
        {"Geneva Identification System", "GEN# +5.20223307"},
        {"Smithsonian Astrophysical Observation", "SAO 76050"},
        {"Wilson Evans Batten Catalogue", "WEB 3239"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.80495415),
        dec: Angle.Degrees(+21.84335278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82582"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.23237477),
        dec: Angle.Degrees(+21.84501524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41130"},
        {"Cincinnati Publication", "Ci 18 986"},
        {"Geneva Identification System", "GEN# +0.02201921"},
        {"Smithsonian Astrophysical Observation", "SAO 80147"},
        {"Wilson Evans Batten Catalogue", "WEB 7964"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.87801748),
        dec: Angle.Degrees(+21.84995388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 298.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39410"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.85082577),
        dec: Angle.Degrees(+21.85030261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134589"},
        {"Hipparcos Number", "HIP 74222"},
        {"Smithsonian Astrophysical Observation", "SAO 83696"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.52506040),
        dec: Angle.Degrees(+21.85097069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99505"},
        {"Hipparcos Number", "HIP 55868"},
        {"Fundamental Katalog 5th Edition", "FK5 5009"},
        {"Geneva Identification System", "GEN# +1.00099505"},
        {"Smithsonian Astrophysical Observation", "SAO 81832"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.76356325),
        dec: Angle.Degrees(+21.85269772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190150"},
        {"Hipparcos Number", "HIP 98696"},
        {"Smithsonian Astrophysical Observation", "SAO 88113"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.69343619),
        dec: Angle.Degrees(+21.85443475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46804",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7419 A"},
        {"Henry Draper", "HD 82394"},
        {"Hipparcos Number", "HIP 46804"},
        {"Geneva Identification System", "GEN# +1.00082394J"},
        {"Smithsonian Astrophysical Observation", "SAO 80892"},
        {"Wilson Evans Batten Catalogue", "WEB 8825"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.05510568),
        dec: Angle.Degrees(+21.85642634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74465"},
        {"Hipparcos Number", "HIP 42927"},
        {"Smithsonian Astrophysical Observation", "SAO 80395"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.22830852),
        dec: Angle.Degrees(+21.85645062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6554"},
        {"Wilson Evans Batten Catalogue", "WEB 1441"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.05704477),
        dec: Angle.Degrees(+21.85804537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76515"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.40676892),
        dec: Angle.Degrees(+21.85881026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76475"},
        {"Hipparcos Number", "HIP 43950"},
        {"Fundamental Katalog 5th Edition", "FK5 2708"},
        {"Geneva Identification System", "GEN# +1.00076475"},
        {"Smithsonian Astrophysical Observation", "SAO 80529"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.27144406),
        dec: Angle.Degrees(+21.86045428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12123"},
        {"Hipparcos Number", "HIP 9293"},
        {"Smithsonian Astrophysical Observation", "SAO 75072"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.85091568),
        dec: Angle.Degrees(+21.86092029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209181"},
        {"Hipparcos Number", "HIP 108679"},
        {"Smithsonian Astrophysical Observation", "SAO 90169"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.24149697),
        dec: Angle.Degrees(+21.86513204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170756"},
        {"Hipparcos Number", "HIP 90697"},
        {"Geneva Identification System", "GEN# +1.00170756"},
        {"Smithsonian Astrophysical Observation", "SAO 86134"},
        {"Wilson Evans Batten Catalogue", "WEB 15537"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.56766780),
        dec: Angle.Degrees(+21.86683572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42475"},
        {"Hipparcos Number", "HIP 29416"},
        {"Geneva Identification System", "GEN# +1.00042475"},
        {"Smithsonian Astrophysical Observation", "SAO 78092"},
        {"Wilson Evans Batten Catalogue", "WEB 5776"},
    },
    visualMagnitude: 6.93,
    bvColour: 2.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.96422435),
        dec: Angle.Degrees(+21.86824073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198759"},
        {"Hipparcos Number", "HIP 102981"},
        {"Geneva Identification System", "GEN# +1.00198759"},
        {"Smithsonian Astrophysical Observation", "SAO 89220"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.95771986),
        dec: Angle.Degrees(+21.86870061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95034"},
        {"Hipparcos Number", "HIP 53652"},
        {"Geneva Identification System", "GEN# +1.00095034"},
        {"Smithsonian Astrophysical Observation", "SAO 81603"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.65330063),
        dec: Angle.Degrees(+21.86933700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119666"},
        {"Hipparcos Number", "HIP 67037"},
        {"Geneva Identification System", "GEN# +1.00119666"},
        {"Smithsonian Astrophysical Observation", "SAO 82976"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.07251504),
        dec: Angle.Degrees(+21.86967254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212833"},
        {"Hipparcos Number", "HIP 110791"},
        {"Smithsonian Astrophysical Observation", "SAO 90512"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.69375619),
        dec: Angle.Degrees(+21.86967952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207517"},
        {"Hipparcos Number", "HIP 107699"},
        {"Smithsonian Astrophysical Observation", "SAO 90024"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.25162590),
        dec: Angle.Degrees(+21.86980917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101110"},
        {"Hipparcos Number", "HIP 56761"},
        {"Geneva Identification System", "GEN# +1.00101110"},
        {"Smithsonian Astrophysical Observation", "SAO 81915"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.54893923),
        dec: Angle.Degrees(+21.87168473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66048"},
        {"Hipparcos Number", "HIP 39344"},
        {"Smithsonian Astrophysical Observation", "SAO 79884"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.63950006),
        dec: Angle.Degrees(+21.87203262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107569"},
        {"Hipparcos Number", "HIP 60290"},
        {"Geneva Identification System", "GEN# +1.00107569"},
        {"Smithsonian Astrophysical Observation", "SAO 82267"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.43801418),
        dec: Angle.Degrees(+21.87271944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41690"},
        {"Hipparcos Number", "HIP 29041"},
        {"Celescope Catalog", "CEL 1082"},
        {"Geneva Identification System", "GEN# +1.00041690J"},
        {"Smithsonian Astrophysical Observation", "SAO 77990"},
        {"Wilson Evans Batten Catalogue", "WEB 5685"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.91206017),
        dec: Angle.Degrees(+21.87318226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124713"},
        {"Hipparcos Number", "HIP 69592"},
        {"Fundamental Katalog 5th Edition", "FK5 3130"},
        {"Geneva Identification System", "GEN# +1.00124713"},
        {"Smithsonian Astrophysical Observation", "SAO 83242"},
        {"Wilson Evans Batten Catalogue", "WEB 12118"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.67057143),
        dec: Angle.Degrees(+21.87340987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191877"},
        {"Hipparcos Number", "HIP 99479"},
        {"Geneva Identification System", "GEN# +1.00191877"},
        {"Smithsonian Astrophysical Observation", "SAO 88315"},
        {"Wilson Evans Batten Catalogue", "WEB 17780"},
    },
    visualMagnitude: 6.24,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.83758369),
        dec: Angle.Degrees(+21.87496544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56122"},
        {"Smithsonian Astrophysical Observation", "SAO 81857"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.57054960),
        dec: Angle.Degrees(+21.87544003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144045"},
        {"Hipparcos Number", "HIP 78625"},
        {"Smithsonian Astrophysical Observation", "SAO 84164"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.76931521),
        dec: Angle.Degrees(+21.87968091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167193"},
        {"Hipparcos Number", "HIP 89298"},
        {"Geneva Identification System", "GEN# +1.00167193"},
        {"Smithsonian Astrophysical Observation", "SAO 85836"},
        {"Wilson Evans Batten Catalogue", "WEB 15181"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.31886640),
        dec: Angle.Degrees(+21.88020909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109519"},
        {"Hipparcos Number", "HIP 61420"},
        {"Geneva Identification System", "GEN# +1.00109519"},
        {"Smithsonian Astrophysical Observation", "SAO 82394"},
        {"Wilson Evans Batten Catalogue", "WEB 10933"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.78397424),
        dec: Angle.Degrees(+21.88143144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85873",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85873"},
        {"Smithsonian Astrophysical Observation", "SAO 85195"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.22040875),
        dec: Angle.Degrees(+21.88259548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86942",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10774 B"},
        {"Henry Draper", "HD 161658B"},
        {"Hipparcos Number", "HIP 86942"},
        {"Geneva Identification System", "GEN# +0.02103209"},
        {"Smithsonian Astrophysical Observation", "SAO 85388"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.48311081),
        dec: Angle.Degrees(+21.88287136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284196"},
        {"Hipparcos Number", "HIP 19542"},
        {"Geneva Identification System", "GEN# +1.00284196"},
        {"Smithsonian Astrophysical Observation", "SAO 76487"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.78542299),
        dec: Angle.Degrees(+21.88513213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136731"},
        {"Hipparcos Number", "HIP 75167"},
        {"Geneva Identification System", "GEN# +1.00136731"},
        {"Smithsonian Astrophysical Observation", "SAO 83786"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.40911618),
        dec: Angle.Degrees(+21.88623409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10007"},
        {"Hipparcos Number", "HIP 7609"},
        {"Geneva Identification System", "GEN# +1.00010007"},
        {"Smithsonian Astrophysical Observation", "SAO 74841"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.50959966),
        dec: Angle.Degrees(+21.88642577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86941",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10774 A"},
        {"Henry Draper", "HD 161658"},
        {"Hipparcos Number", "HIP 86941"},
        {"Geneva Identification System", "GEN# +1.00161658A"},
        {"Smithsonian Astrophysical Observation", "SAO 85387"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.47825197),
        dec: Angle.Degrees(+21.88816298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8876"},
        {"Smithsonian Astrophysical Observation", "SAO 75009"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.58210164),
        dec: Angle.Degrees(+21.88906283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58364"},
        {"Hipparcos Number", "HIP 36086"},
        {"Geneva Identification System", "GEN# +1.00058364"},
        {"Smithsonian Astrophysical Observation", "SAO 79381"},
        {"Wilson Evans Batten Catalogue", "WEB 7187"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.52713262),
        dec: Angle.Degrees(+21.89118646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19665"},
        {"Hipparcos Number", "HIP 14767"},
        {"Smithsonian Astrophysical Observation", "SAO 75773"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.66629487),
        dec: Angle.Degrees(+21.89283559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144544"},
        {"Hipparcos Number", "HIP 78839"},
        {"Geneva Identification System", "GEN# +1.00144544"},
        {"Smithsonian Astrophysical Observation", "SAO 84189"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.40805909),
        dec: Angle.Degrees(+21.89309264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113516"},
        {"Hipparcos Number", "HIP 63757"},
        {"Geneva Identification System", "GEN# +1.00113516"},
        {"Smithsonian Astrophysical Observation", "SAO 82634"},
        {"Wilson Evans Batten Catalogue", "WEB 11278"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.02494645),
        dec: Angle.Degrees(+21.89494956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195575"},
        {"Hipparcos Number", "HIP 101263"},
        {"Smithsonian Astrophysical Observation", "SAO 88798"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.88343763),
        dec: Angle.Degrees(+21.89508707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72886",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72886"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.45245293),
        dec: Angle.Degrees(+21.89604857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14222"},
        {"Hipparcos Number", "HIP 10767"},
        {"Fundamental Katalog 5th Edition", "FK5 4214"},
        {"Geneva Identification System", "GEN# +1.00014222"},
        {"Smithsonian Astrophysical Observation", "SAO 75273"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.64347478),
        dec: Angle.Degrees(+21.89760087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346429"},
        {"Hipparcos Number", "HIP 100220"},
    },
    visualMagnitude: 9.35,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.90155567),
        dec: Angle.Degrees(+21.89829618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70577"},
        {"Smithsonian Astrophysical Observation", "SAO 83351"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.54775546),
        dec: Angle.Degrees(+21.90088209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14277"},
        {"Hipparcos Number", "HIP 10801"},
        {"Smithsonian Astrophysical Observation", "SAO 75278"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.75295075),
        dec: Angle.Degrees(+21.90476725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39950"},
    },
    visualMagnitude: 11.84,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.37981064),
        dec: Angle.Degrees(+21.90494855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -318.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64669"},
        {"Smithsonian Astrophysical Observation", "SAO 82739"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.83107685),
        dec: Angle.Degrees(+21.90655317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347427"},
        {"Hipparcos Number", "HIP 102346"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.05379096),
        dec: Angle.Degrees(+21.90712263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 123.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284253"},
        {"Hipparcos Number", "HIP 19934"},
        {"Geneva Identification System", "GEN# +5.20250021"},
        {"Smithsonian Astrophysical Observation", "SAO 76529"},
        {"Wilson Evans Batten Catalogue", "WEB 3805"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.13921642),
        dec: Angle.Degrees(+21.90756081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94426",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12176 AB"},
        {"Henry Draper", "HD 179783"},
        {"Hipparcos Number", "HIP 94426"},
        {"Smithsonian Astrophysical Observation", "SAO 86942"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.28304252),
        dec: Angle.Degrees(+21.90774374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136656"},
        {"Hipparcos Number", "HIP 75135"},
        {"Smithsonian Astrophysical Observation", "SAO 83781"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.30862927),
        dec: Angle.Degrees(+21.90799513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63225"},
        {"Hipparcos Number", "HIP 38113"},
        {"Smithsonian Astrophysical Observation", "SAO 79707"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.16042699),
        dec: Angle.Degrees(+21.90807088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185530"},
        {"Hipparcos Number", "HIP 96625"},
        {"Geneva Identification System", "GEN# +1.00185530"},
        {"Smithsonian Astrophysical Observation", "SAO 87495"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.69285497),
        dec: Angle.Degrees(+21.90890522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346933"},
        {"Hipparcos Number", "HIP 101508"},
        {"Geneva Identification System", "GEN# +1.00346933"},
        {"Smithsonian Astrophysical Observation", "SAO 88849"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.55066106),
        dec: Angle.Degrees(+21.90933116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70204"},
        {"Hipparcos Number", "HIP 40950"},
        {"Smithsonian Astrophysical Observation", "SAO 80125"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.36725208),
        dec: Angle.Degrees(+21.90941787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54017"},
        {"Hipparcos Number", "HIP 34418"},
        {"Smithsonian Astrophysical Observation", "SAO 79092"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.03360782),
        dec: Angle.Degrees(+21.91285338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89086"},
        {"Hipparcos Number", "HIP 50364"},
        {"Geneva Identification System", "GEN# +1.00089086"},
        {"Smithsonian Astrophysical Observation", "SAO 81268"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.25153111),
        dec: Angle.Degrees(+21.91309429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202585"},
        {"Hipparcos Number", "HIP 105018"},
        {"Smithsonian Astrophysical Observation", "SAO 89572"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.07346021),
        dec: Angle.Degrees(+21.91359807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98502"},
        {"Hipparcos Number", "HIP 55353"},
        {"Smithsonian Astrophysical Observation", "SAO 81777"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.02507714),
        dec: Angle.Degrees(+21.91404741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9260",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9260"},
        {"Smithsonian Astrophysical Observation", "SAO 75069"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.76122388),
        dec: Angle.Degrees(+21.91422004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44928"},
        {"Hipparcos Number", "HIP 30560"},
        {"Smithsonian Astrophysical Observation", "SAO 78347"},
    },
    visualMagnitude: 8.67,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.36204361),
        dec: Angle.Degrees(+21.91456688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10088"},
        {"Hipparcos Number", "HIP 7685"},
        {"Celescope Catalog", "CEL 152"},
        {"Geneva Identification System", "GEN# +1.00010088"},
        {"Renson", "Renson 2520"},
        {"Smithsonian Astrophysical Observation", "SAO 74848"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.73592673),
        dec: Angle.Degrees(+21.91860626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114637"},
        {"Hipparcos Number", "HIP 64365"},
        {"Geneva Identification System", "GEN# +1.00114637"},
        {"Smithsonian Astrophysical Observation", "SAO 82699"},
        {"Wilson Evans Batten Catalogue", "WEB 11376"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.88481624),
        dec: Angle.Degrees(+21.91872836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85124",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10521 AB"},
        {"Henry Draper", "HD 157683"},
        {"Hipparcos Number", "HIP 85124"},
        {"Smithsonian Astrophysical Observation", "SAO 85060"},
        {"Wilson Evans Batten Catalogue", "WEB 14373"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.95432526),
        dec: Angle.Degrees(+21.91928261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3448"},
        {"Hipparcos Number", "HIP 2952"},
        {"Geneva Identification System", "GEN# +1.00003448"},
        {"Renson", "Renson 930"},
        {"Smithsonian Astrophysical Observation", "SAO 74150"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.37335236),
        dec: Angle.Degrees(+21.91983088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69265"},
        {"Hipparcos Number", "HIP 40565"},
        {"Smithsonian Astrophysical Observation", "SAO 80064"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.23596255),
        dec: Angle.Degrees(+21.91986210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28343"},
        {"Hipparcos Number", "HIP 20917"},
        {"Geneva Identification System", "GEN# +1.00028343"},
        {"Smithsonian Astrophysical Observation", "SAO 76626"},
        {"Wilson Evans Batten Catalogue", "WEB 4018"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.25069146),
        dec: Angle.Degrees(+21.92227514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 175.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 676",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 676"},
        {"Smithsonian Astrophysical Observation", "SAO 73764"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.09403593),
        dec: Angle.Degrees(+21.92431268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 233.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125770"},
        {"Hipparcos Number", "HIP 70130"},
        {"Smithsonian Astrophysical Observation", "SAO 83300"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.25697590),
        dec: Angle.Degrees(+21.92593860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68175"},
        {"Smithsonian Astrophysical Observation", "SAO 83094"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.35661825),
        dec: Angle.Degrees(+21.92695364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102031",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14148 AB"},
        {"Henry Draper", "HD 197075"},
        {"Hipparcos Number", "HIP 102031"},
        {"Smithsonian Astrophysical Observation", "SAO 88991"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.14906770),
        dec: Angle.Degrees(+21.92704669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66375"},
        {"Smithsonian Astrophysical Observation", "SAO 82898"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.10720328),
        dec: Angle.Degrees(+21.92867212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86529"},
        {"Smithsonian Astrophysical Observation", "SAO 85306"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.24894514),
        dec: Angle.Degrees(+21.92874420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203786"},
        {"Hipparcos Number", "HIP 105645"},
        {"Renson", "Renson 56730"},
        {"Smithsonian Astrophysical Observation", "SAO 89675"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.97796448),
        dec: Angle.Degrees(+21.93079554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201564"},
        {"Hipparcos Number", "HIP 104474"},
        {"Smithsonian Astrophysical Observation", "SAO 89495"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.45976451),
        dec: Angle.Degrees(+21.93183307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4224"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.47306825),
        dec: Angle.Degrees(+21.93216327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25539",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4048 A"},
        {"Henry Draper", "HD 35708"},
        {"Hipparcos Number", "HIP 25539"},
        {"Celescope Catalog", "CEL 713"},
        {"Geneva Identification System", "GEN# +1.00035708"},
        {"Smithsonian Astrophysical Observation", "SAO 77184"},
        {"Wilson Evans Batten Catalogue", "WEB 4955"},
    },
    visualMagnitude: 4.88,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.90868350),
        dec: Angle.Degrees(+21.93698219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222811"},
        {"Hipparcos Number", "HIP 117049"},
        {"Fundamental Katalog 5th Edition", "FK5 6101"},
        {"Smithsonian Astrophysical Observation", "SAO 91450"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.92605994),
        dec: Angle.Degrees(+21.94019459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83188"},
        {"Hipparcos Number", "HIP 47197"},
        {"Smithsonian Astrophysical Observation", "SAO 80933"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.28654504),
        dec: Angle.Degrees(+21.94022783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100607"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.02233823),
        dec: Angle.Degrees(+21.94106941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156967"},
        {"Hipparcos Number", "HIP 84768"},
        {"Smithsonian Astrophysical Observation", "SAO 85007"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.89870815),
        dec: Angle.Degrees(+21.94277122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207719"},
        {"Hipparcos Number", "HIP 107815"},
        {"Smithsonian Astrophysical Observation", "SAO 90047"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.63536576),
        dec: Angle.Degrees(+21.94312397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246997"},
        {"Hipparcos Number", "HIP 27098"},
        {"Smithsonian Astrophysical Observation", "SAO 77491"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.19082175),
        dec: Angle.Degrees(+21.94373180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206403"},
        {"Hipparcos Number", "HIP 107084"},
        {"Smithsonian Astrophysical Observation", "SAO 89907"},
        {"Wilson Evans Batten Catalogue", "WEB 19342"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.34525844),
        dec: Angle.Degrees(+21.94403115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4598",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4598"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.71621587),
        dec: Angle.Degrees(+21.94461058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59034"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.55344134),
        dec: Angle.Degrees(+21.94541740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81662",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10155 A"},
        {"Henry Draper", "HD 150554"},
        {"Hipparcos Number", "HIP 81662"},
        {"Smithsonian Astrophysical Observation", "SAO 84534"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.23541321),
        dec: Angle.Degrees(+21.94814346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108863"},
        {"Hipparcos Number", "HIP 61020"},
        {"Geneva Identification System", "GEN# +1.00108863"},
        {"Smithsonian Astrophysical Observation", "SAO 82342"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.58315413),
        dec: Angle.Degrees(+21.94832580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58599"},
        {"Smithsonian Astrophysical Observation", "SAO 82099"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.24342066),
        dec: Angle.Degrees(+21.94908302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87015"},
        {"Hipparcos Number", "HIP 49220"},
        {"Fundamental Katalog 5th Edition", "FK5 2807"},
        {"Geneva Identification System", "GEN# +1.00087015"},
        {"Smithsonian Astrophysical Observation", "SAO 81154"},
        {"Wilson Evans Batten Catalogue", "WEB 9114"},
    },
    visualMagnitude: 5.68,
    bvColour: -0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.70399581),
        dec: Angle.Degrees(+21.94927070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30588"},
        {"Hipparcos Number", "HIP 22443"},
        {"Smithsonian Astrophysical Observation", "SAO 76776"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.44114582),
        dec: Angle.Degrees(+21.94970380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109846",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15772 AB"},
        {"Hipparcos Number", "HIP 109846"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.70628684),
        dec: Angle.Degrees(+21.94974630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215385"},
        {"Hipparcos Number", "HIP 112274"},
        {"Smithsonian Astrophysical Observation", "SAO 90754"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.12158855),
        dec: Angle.Degrees(+21.95185510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38063"},
        {"Hipparcos Number", "HIP 27023"},
        {"Geneva Identification System", "GEN# +1.00038063"},
        {"Smithsonian Astrophysical Observation", "SAO 77469"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.97183411),
        dec: Angle.Degrees(+21.95194898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25836"},
        {"Hipparcos Number", "HIP 19163"},
        {"Smithsonian Astrophysical Observation", "SAO 76456"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.64207008),
        dec: Angle.Degrees(+21.95650713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41431",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41431"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.75374026),
        dec: Angle.Degrees(+21.95680372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18459"},
        {"Smithsonian Astrophysical Observation", "SAO 76337"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.16542376),
        dec: Angle.Degrees(+21.95773414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106784"},
        {"Smithsonian Astrophysical Observation", "SAO 89855"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.43175441),
        dec: Angle.Degrees(+21.95786864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168720"},
        {"Hipparcos Number", "HIP 89861"},
        {"Geneva Identification System", "GEN# +1.00168720"},
        {"Smithsonian Astrophysical Observation", "SAO 85941"},
        {"Wilson Evans Batten Catalogue", "WEB 15343"},
    },
    visualMagnitude: 4.92,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.07459830),
        dec: Angle.Degrees(+21.96144090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16432"},
        {"Hipparcos Number", "HIP 12332"},
        {"Fundamental Katalog 5th Edition", "FK5 89"},
        {"Geneva Identification System", "GEN# +1.00016432"},
        {"Smithsonian Astrophysical Observation", "SAO 75495"},
        {"Wilson Evans Batten Catalogue", "WEB 2529"},
    },
    visualMagnitude: 5.45,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.70416245),
        dec: Angle.Degrees(+21.96144509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115268",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16686 AB"},
        {"Henry Draper", "HD 220076"},
        {"Hipparcos Number", "HIP 115268"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.20365623),
        dec: Angle.Degrees(+21.96271798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67536",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67536"},
        {"Smithsonian Astrophysical Observation", "SAO 83020"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.58006711),
        dec: Angle.Degrees(+21.96489884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126495"},
        {"Hipparcos Number", "HIP 70507"},
        {"Smithsonian Astrophysical Observation", "SAO 83341"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.34458201),
        dec: Angle.Degrees(+21.96582902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55847"},
        {"Hipparcos Number", "HIP 35106"},
        {"Smithsonian Astrophysical Observation", "SAO 79216"},
        {"Wilson Evans Batten Catalogue", "WEB 7016"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.89034016),
        dec: Angle.Degrees(+21.96665960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95650"},
        {"Hipparcos Number", "HIP 53985"},
        {"Geneva Identification System", "GEN# +1.00095650"},
        {"Wilson Evans Batten Catalogue", "WEB 9766"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.65938435),
        dec: Angle.Degrees(+21.96726447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89224"},
        {"Hipparcos Number", "HIP 50444"},
        {"Geneva Identification System", "GEN# +1.00089224"},
        {"Smithsonian Astrophysical Observation", "SAO 81276"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.49558724),
        dec: Angle.Degrees(+21.96859259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61011"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.55738770),
        dec: Angle.Degrees(+21.96969483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57673"},
        {"Hipparcos Number", "HIP 35807"},
        {"Smithsonian Astrophysical Observation", "SAO 79344"},
    },
    visualMagnitude: 8.71,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.77588434),
        dec: Angle.Degrees(+21.97059386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192561"},
        {"Hipparcos Number", "HIP 99788"},
        {"Smithsonian Astrophysical Observation", "SAO 88398"},
        {"Wilson Evans Batten Catalogue", "WEB 17922"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.69471275),
        dec: Angle.Degrees(+21.97542280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129132"},
        {"Hipparcos Number", "HIP 71729"},
        {"Geneva Identification System", "GEN# +1.00129132"},
        {"Smithsonian Astrophysical Observation", "SAO 83458"},
        {"Wilson Evans Batten Catalogue", "WEB 12359"},
        {"Wilson Evans Batten Catalogue 2", "WEB 12360"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.09118199),
        dec: Angle.Degrees(+21.97576982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122364"},
        {"Hipparcos Number", "HIP 68467"},
        {"Geneva Identification System", "GEN# +1.00122364"},
        {"Smithsonian Astrophysical Observation", "SAO 83127"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.26510237),
        dec: Angle.Degrees(+21.97637002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6715"},
        {"Hipparcos Number", "HIP 5335"},
        {"Cincinnati Publication", "Ci 18 148"},
        {"Geneva Identification System", "GEN# +1.00006715"},
        {"Smithsonian Astrophysical Observation", "SAO 74509"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.05096881),
        dec: Angle.Degrees(+21.97712274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 400.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114596"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.22791506),
        dec: Angle.Degrees(+21.97731741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73111"},
        {"Hipparcos Number", "HIP 42293"},
        {"Smithsonian Astrophysical Observation", "SAO 80293"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.33826942),
        dec: Angle.Degrees(+21.98006872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40057"},
        {"Hipparcos Number", "HIP 28188"},
        {"Smithsonian Astrophysical Observation", "SAO 77766"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.35757774),
        dec: Angle.Degrees(+21.98105118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183418"},
        {"Hipparcos Number", "HIP 95768"},
        {"Geneva Identification System", "GEN# +1.00183418"},
        {"Smithsonian Astrophysical Observation", "SAO 87259"},
        {"Wilson Evans Batten Catalogue", "WEB 16758"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.16898176),
        dec: Angle.Degrees(+21.98131644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58187",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8352 A"},
        {"Henry Draper", "HD 103628"},
        {"Hipparcos Number", "HIP 58187"},
        {"Geneva Identification System", "GEN# +1.00103628A"},
        {"Smithsonian Astrophysical Observation", "SAO 82058"},
        {"Wilson Evans Batten Catalogue", "WEB 10414"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.00374840),
        dec: Angle.Degrees(+21.98190738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35550",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Wasat"},
        {"Aitken", "ADS 5983"},
        {"Aitken 2", "ADS 5983 A"},
        {"Henry Draper", "HD 56986"},
        {"Hipparcos Number", "HIP 35550"},
        {"Fundamental Katalog 5th Edition", "FK5 279"},
        {"Geneva Identification System", "GEN# +1.00056986"},
        {"Renson", "Renson 15560"},
        {"Smithsonian Astrophysical Observation", "SAO 79294"},
        {"Wilson Evans Batten Catalogue", "WEB 7084"},
    },
    visualMagnitude: 3.50,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.03078890),
        dec: Angle.Degrees(+21.98233941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58192",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8352 B"},
        {"Hipparcos Number", "HIP 58192"},
        {"Geneva Identification System", "GEN# +1.00103628B"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.00725511),
        dec: Angle.Degrees(+21.98275045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13483"},
        {"Hipparcos Number", "HIP 10276"},
        {"Geneva Identification System", "GEN# +1.00013483"},
        {"Smithsonian Astrophysical Observation", "SAO 75201"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.07542121),
        dec: Angle.Degrees(+21.98282126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173650"},
        {"Hipparcos Number", "HIP 92036"},
        {"Geneva Identification System", "GEN# +1.00173650"},
        {"Renson", "Renson 48660"},
        {"Smithsonian Astrophysical Observation", "SAO 86405"},
        {"Wilson Evans Batten Catalogue", "WEB 15858"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.39839498),
        dec: Angle.Degrees(+21.98467809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187319"},
        {"Hipparcos Number", "HIP 97471"},
        {"Smithsonian Astrophysical Observation", "SAO 87750"},
        {"Wilson Evans Batten Catalogue", "WEB 17133"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.17084485),
        dec: Angle.Degrees(+21.98480342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116175"},
    },
    visualMagnitude: 10.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.09374183),
        dec: Angle.Degrees(+21.98586843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 198.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34452"},
        {"Smithsonian Astrophysical Observation", "SAO 79100"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.12897430),
        dec: Angle.Degrees(+21.98596458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11465"},
        {"Hipparcos Number", "HIP 8802"},
        {"Smithsonian Astrophysical Observation", "SAO 74999"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.28510397),
        dec: Angle.Degrees(+21.98642396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55463"},
        {"Smithsonian Astrophysical Observation", "SAO 81788"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.37585996),
        dec: Angle.Degrees(+21.98776233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257331"},
        {"Hipparcos Number", "HIP 30723"},
        {"Smithsonian Astrophysical Observation", "SAO 78387"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.81652039),
        dec: Angle.Degrees(+21.99061692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216634"},
        {"Hipparcos Number", "HIP 113099"},
        {"Smithsonian Astrophysical Observation", "SAO 90866"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.56392276),
        dec: Angle.Degrees(+21.99135417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26328",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4200 AB"},
        {"Aitken 2", "ADS 4200"},
        {"Henry Draper", "HD 37013"},
        {"Hipparcos Number", "HIP 26328"},
        {"Smithsonian Astrophysical Observation", "SAO 77313"},
        {"Wilson Evans Batten Catalogue", "WEB 5181"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.11004406),
        dec: Angle.Degrees(+21.99331440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110789"},
        {"Hipparcos Number", "HIP 62162"},
        {"Fundamental Katalog 5th Edition", "FK5 5125"},
        {"Geneva Identification System", "GEN# +1.00110789"},
        {"Smithsonian Astrophysical Observation", "SAO 82466"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.09458248),
        dec: Angle.Degrees(+21.99396394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84276"},
        {"Smithsonian Astrophysical Observation", "SAO 84935"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.41934049),
        dec: Angle.Degrees(+21.99604612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78715"},
        {"Hipparcos Number", "HIP 45033"},
        {"Geneva Identification System", "GEN# +1.00078715"},
        {"Smithsonian Astrophysical Observation", "SAO 80674"},
        {"Wilson Evans Batten Catalogue", "WEB 8596"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.58690182),
        dec: Angle.Degrees(+21.99640459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168243"},
        {"Hipparcos Number", "HIP 89671"},
        {"Smithsonian Astrophysical Observation", "SAO 85903"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.48915932),
        dec: Angle.Degrees(+21.99641188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112594"},
        {"Smithsonian Astrophysical Observation", "SAO 90798"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.05873957),
        dec: Angle.Degrees(+21.99775544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23454"},
        {"Hipparcos Number", "HIP 17589"},
        {"Geneva Identification System", "GEN# +1.00023454"},
        {"Smithsonian Astrophysical Observation", "SAO 76166"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.52027839),
        dec: Angle.Degrees(+21.99881076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68887"},
        {"Smithsonian Astrophysical Observation", "SAO 83164"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.56867283),
        dec: Angle.Degrees(+21.99895953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41728"},
        {"Hipparcos Number", "HIP 29061"},
        {"Smithsonian Astrophysical Observation", "SAO 77997"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.95247764),
        dec: Angle.Degrees(+22.00276436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47429"},
        {"Hipparcos Number", "HIP 31848"},
        {"Smithsonian Astrophysical Observation", "SAO 78600"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.87729741),
        dec: Angle.Degrees(+22.00276717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60897"},
        {"Geneva Identification System", "GEN# +0.02202476"},
        {"Smithsonian Astrophysical Observation", "SAO 82329"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.20060162),
        dec: Angle.Degrees(+22.00341039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18475"},
        {"Hipparcos Number", "HIP 13890"},
        {"Geneva Identification System", "GEN# +1.00018475"},
        {"Smithsonian Astrophysical Observation", "SAO 75670"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.71600031),
        dec: Angle.Degrees(+22.00456320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185193"},
        {"Hipparcos Number", "HIP 96499"},
        {"Geneva Identification System", "GEN# +1.00185193"},
        {"Smithsonian Astrophysical Observation", "SAO 87459"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.27747074),
        dec: Angle.Degrees(+22.00595088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150304"},
        {"Hipparcos Number", "HIP 81555"},
        {"Geneva Identification System", "GEN# +1.00150304"},
        {"Smithsonian Astrophysical Observation", "SAO 84517"},
        {"Wilson Evans Batten Catalogue", "WEB 13777"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.84155780),
        dec: Angle.Degrees(+22.00618198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15717"},
        {"Hipparcos Number", "HIP 11797"},
        {"Geneva Identification System", "GEN# +1.00015717"},
        {"Smithsonian Astrophysical Observation", "SAO 75427"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.05044497),
        dec: Angle.Degrees(+22.00702188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43538"},
        {"Smithsonian Astrophysical Observation", "SAO 80469"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.01204197),
        dec: Angle.Degrees(+22.00757511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345235"},
        {"Hipparcos Number", "HIP 98035"},
        {"Geneva Identification System", "GEN# +1.00345235"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.82680142),
        dec: Angle.Degrees(+22.00866795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25680"},
        {"Hipparcos Number", "HIP 19076"},
        {"Geneva Identification System", "GEN# +1.00025680"},
        {"Smithsonian Astrophysical Observation", "SAO 76438"},
        {"Wilson Evans Batten Catalogue", "WEB 3664"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.33395641),
        dec: Angle.Degrees(+22.00922152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10065"},
        {"Smithsonian Astrophysical Observation", "SAO 75173"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.38759247),
        dec: Angle.Degrees(+22.00973476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224370"},
        {"Hipparcos Number", "HIP 118088"},
        {"Geneva Identification System", "GEN# +1.00224370"},
        {"Smithsonian Astrophysical Observation", "SAO 91601"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.31117063),
        dec: Angle.Degrees(+22.01031668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170671"},
        {"Hipparcos Number", "HIP 90654"},
        {"Smithsonian Astrophysical Observation", "SAO 86125"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.46425112),
        dec: Angle.Degrees(+22.01114462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211528"},
        {"Hipparcos Number", "HIP 110040"},
        {"Smithsonian Astrophysical Observation", "SAO 90392"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.33383565),
        dec: Angle.Degrees(+22.01117190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95997",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12546 AB"},
        {"Henry Draper", "HD 344494"},
        {"Hipparcos Number", "HIP 95997"},
        {"Smithsonian Astrophysical Observation", "SAO 87307"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.78987251),
        dec: Angle.Degrees(+22.01140990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89524"},
        {"Hipparcos Number", "HIP 50608"},
        {"Smithsonian Astrophysical Observation", "SAO 81302"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.06423722),
        dec: Angle.Degrees(+22.01150301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 342941"},
        {"Hipparcos Number", "HIP 92010"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.30393787),
        dec: Angle.Degrees(+22.01193614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168830"},
        {"Hipparcos Number", "HIP 89930"},
        {"Smithsonian Astrophysical Observation", "SAO 85954"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.24664717),
        dec: Angle.Degrees(+22.01293012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195694"},
        {"Hipparcos Number", "HIP 101312"},
        {"Smithsonian Astrophysical Observation", "SAO 88809"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.02652432),
        dec: Angle.Degrees(+22.01413931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134045"},
        {"Hipparcos Number", "HIP 73979"},
        {"Geneva Identification System", "GEN# +1.00134045"},
        {"Smithsonian Astrophysical Observation", "SAO 83667"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.78318957),
        dec: Angle.Degrees(+22.01784664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119535"},
        {"Hipparcos Number", "HIP 66964"},
        {"Geneva Identification System", "GEN# +1.00119535"},
        {"Smithsonian Astrophysical Observation", "SAO 82965"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.87204985),
        dec: Angle.Degrees(+22.01838660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133071"},
        {"Hipparcos Number", "HIP 73552"},
        {"Smithsonian Astrophysical Observation", "SAO 83622"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.48173088),
        dec: Angle.Degrees(+22.01895363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16365"},
        {"Hipparcos Number", "HIP 12278"},
        {"Smithsonian Astrophysical Observation", "SAO 75487"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.54166801),
        dec: Angle.Degrees(+22.02009297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29097"},
        {"Hipparcos Number", "HIP 21399"},
        {"Smithsonian Astrophysical Observation", "SAO 76665"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.90304474),
        dec: Angle.Degrees(+22.02073661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26037"},
        {"Hipparcos Number", "HIP 19299"},
        {"Smithsonian Astrophysical Observation", "SAO 76468"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.05936186),
        dec: Angle.Degrees(+22.02123617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100517"},
        {"Hipparcos Number", "HIP 56431"},
        {"Geneva Identification System", "GEN# +1.00100517"},
        {"Smithsonian Astrophysical Observation", "SAO 81880"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.54968856),
        dec: Angle.Degrees(+22.02367098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16144"},
        {"Cincinnati Publication", "Ci 20 234"},
    },
    visualMagnitude: 11.41,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.00877986),
        dec: Angle.Degrees(+22.02385871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 341.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -321.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207266"},
        {"Hipparcos Number", "HIP 107573"},
        {"Geneva Identification System", "GEN# +1.00207266"},
        {"Smithsonian Astrophysical Observation", "SAO 89994"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.80480366),
        dec: Angle.Degrees(+22.02442081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56790"},
        {"Hipparcos Number", "HIP 35481"},
        {"Geneva Identification System", "GEN# +1.00056790"},
        {"Smithsonian Astrophysical Observation", "SAO 79285"},
        {"Wilson Evans Batten Catalogue", "WEB 7074"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.84947971),
        dec: Angle.Degrees(+22.02455190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95242"},
        {"Hipparcos Number", "HIP 53766"},
        {"Geneva Identification System", "GEN# +1.00095242"},
        {"Smithsonian Astrophysical Observation", "SAO 81615"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.01070625),
        dec: Angle.Degrees(+22.02609265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203206"},
        {"Hipparcos Number", "HIP 105344"},
        {"Geneva Identification System", "GEN# +1.00203206"},
        {"Smithsonian Astrophysical Observation", "SAO 89628"},
        {"Wilson Evans Batten Catalogue", "WEB 19134"},
    },
    visualMagnitude: 6.29,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.05862783),
        dec: Angle.Degrees(+22.02617225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106224"},
        {"Hipparcos Number", "HIP 59596"},
        {"Geneva Identification System", "GEN# +1.00106224"},
        {"Smithsonian Astrophysical Observation", "SAO 82191"},
        {"Wilson Evans Batten Catalogue", "WEB 10592"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.32352850),
        dec: Angle.Degrees(+22.02647911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47358"},
        {"Hipparcos Number", "HIP 31813"},
        {"Fundamental Katalog 5th Edition", "FK5 2513"},
        {"Geneva Identification System", "GEN# +1.00047358"},
        {"Smithsonian Astrophysical Observation", "SAO 78586"},
        {"Wilson Evans Batten Catalogue", "WEB 6389"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.77204904),
        dec: Angle.Degrees(+22.03093990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24154"},
        {"Hipparcos Number", "HIP 18059"},
        {"Fundamental Katalog 5th Edition", "FK5 4350"},
        {"Geneva Identification System", "GEN# +1.00024154"},
        {"Smithsonian Astrophysical Observation", "SAO 76275"},
        {"Wilson Evans Batten Catalogue", "WEB 3482"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.90255161),
        dec: Angle.Degrees(+22.03142901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70146"},
        {"Hipparcos Number", "HIP 40920"},
        {"Geneva Identification System", "GEN# +1.00070146"},
        {"Smithsonian Astrophysical Observation", "SAO 80119"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.27049753),
        dec: Angle.Degrees(+22.03175061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346672"},
        {"Hipparcos Number", "HIP 101000"},
        {"Smithsonian Astrophysical Observation", "SAO 88721"},
    },
    visualMagnitude: 9.16,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.15625364),
        dec: Angle.Degrees(+22.03187899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23312"},
        {"Hipparcos Number", "HIP 17511"},
        {"Geneva Identification System", "GEN# +5.20223314"},
        {"Smithsonian Astrophysical Observation", "SAO 76134"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.24546103),
        dec: Angle.Degrees(+22.03255788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169780"},
        {"Hipparcos Number", "HIP 90296"},
        {"Geneva Identification System", "GEN# +1.00169780"},
        {"Smithsonian Astrophysical Observation", "SAO 86028"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.37201905),
        dec: Angle.Degrees(+22.03350599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3347"},
        {"Hipparcos Number", "HIP 2875"},
        {"Smithsonian Astrophysical Observation", "SAO 74139"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.11169196),
        dec: Angle.Degrees(+22.03370592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48549"},
        {"Hipparcos Number", "HIP 32331"},
        {"Geneva Identification System", "GEN# +1.00048549"},
        {"Smithsonian Astrophysical Observation", "SAO 78697"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.23176859),
        dec: Angle.Degrees(+22.03372898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209060"},
        {"Hipparcos Number", "HIP 108618"},
        {"Geneva Identification System", "GEN# +1.00209060"},
        {"Smithsonian Astrophysical Observation", "SAO 90160"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.05235919),
        dec: Angle.Degrees(+22.03538799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158789"},
        {"Hipparcos Number", "HIP 85655"},
        {"Smithsonian Astrophysical Observation", "SAO 85153"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.57768817),
        dec: Angle.Degrees(+22.03545194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51567",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7817 B"},
        {"Hipparcos Number", "HIP 51567"},
        {"Geneva Identification System", "GEN# +1.09119220"},
        {"Smithsonian Astrophysical Observation", "SAO 81400"},
        {"Wilson Evans Batten Catalogue", "WEB 9412"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.99720691),
        dec: Angle.Degrees(+22.03607450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8509"},
        {"Hipparcos Number", "HIP 6577"},
        {"Geneva Identification System", "GEN# +1.00008509"},
        {"Smithsonian Astrophysical Observation", "SAO 74695"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.12802371),
        dec: Angle.Degrees(+22.03827389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51566",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7817 A"},
        {"Henry Draper", "HD 91192"},
        {"Hipparcos Number", "HIP 51566"},
        {"Geneva Identification System", "GEN# +1.00091192A"},
        {"Smithsonian Astrophysical Observation", "SAO 81399"},
        {"Wilson Evans Batten Catalogue", "WEB 9409"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.99560663),
        dec: Angle.Degrees(+22.03943963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21049"},
        {"Hipparcos Number", "HIP 15882"},
        {"Fundamental Katalog 5th Edition", "FK5 4310"},
        {"Geneva Identification System", "GEN# +1.00021049"},
        {"Smithsonian Astrophysical Observation", "SAO 75917"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.14361598),
        dec: Angle.Degrees(+22.04036143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62280"},
        {"Geneva Identification System", "GEN# +0.02202509"},
        {"Smithsonian Astrophysical Observation", "SAO 82479"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.44823679),
        dec: Angle.Degrees(+22.04047101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122694"},
        {"Hipparcos Number", "HIP 68635"},
        {"Geneva Identification System", "GEN# +1.00122694"},
        {"Smithsonian Astrophysical Observation", "SAO 83139"},
        {"Wilson Evans Batten Catalogue", "WEB 12018"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.74043953),
        dec: Angle.Degrees(+22.04252113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112735"},
        {"Hipparcos Number", "HIP 63330"},
        {"Geneva Identification System", "GEN# +1.00112735"},
        {"Smithsonian Astrophysical Observation", "SAO 82591"},
        {"Wilson Evans Batten Catalogue", "WEB 11216"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.67035441),
        dec: Angle.Degrees(+22.04348459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -247.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12811"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.16183514),
        dec: Angle.Degrees(+22.04352804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89362"},
        {"Hipparcos Number", "HIP 50522"},
        {"Smithsonian Astrophysical Observation", "SAO 81286"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.79185938),
        dec: Angle.Degrees(+22.04387375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48137"},
        {"Smithsonian Astrophysical Observation", "SAO 81023"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.20505117),
        dec: Angle.Degrees(+22.04404074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36215"},
    },
    visualMagnitude: 11.25,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.86990214),
        dec: Angle.Degrees(+22.04422148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -264.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44946",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Nahn"},
        {"Henry Draper", "HD 78515"},
        {"Hipparcos Number", "HIP 44946"},
        {"Fundamental Katalog 5th Edition", "FK5 1239"},
        {"Geneva Identification System", "GEN# +1.00078515J"},
        {"Smithsonian Astrophysical Observation", "SAO 80666"},
        {"Wilson Evans Batten Catalogue", "WEB 8585"},
    },
    visualMagnitude: 5.16,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.33972475),
        dec: Angle.Degrees(+22.04544728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132879"},
        {"Hipparcos Number", "HIP 73464"},
        {"Smithsonian Astrophysical Observation", "SAO 83616"},
        {"Wilson Evans Batten Catalogue", "WEB 12572"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.21783189),
        dec: Angle.Degrees(+22.04557338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221279"},
        {"Hipparcos Number", "HIP 116040"},
        {"Geneva Identification System", "GEN# +1.00221279"},
        {"Smithsonian Astrophysical Observation", "SAO 91311"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.68167728),
        dec: Angle.Degrees(+22.04740138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41801"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.84058658),
        dec: Angle.Degrees(+22.04759998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167715"},
        {"Hipparcos Number", "HIP 89484"},
        {"Geneva Identification System", "GEN# +1.00167715"},
        {"Smithsonian Astrophysical Observation", "SAO 85867"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.91305812),
        dec: Angle.Degrees(+22.05068893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96497"},
        {"Hipparcos Number", "HIP 54375"},
        {"Geneva Identification System", "GEN# +1.00096497"},
        {"Smithsonian Astrophysical Observation", "SAO 81677"},
        {"Wilson Evans Batten Catalogue", "WEB 9821"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.87052922),
        dec: Angle.Degrees(+22.05296611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97305"},
        {"Hipparcos Number", "HIP 54723"},
        {"Smithsonian Astrophysical Observation", "SAO 81715"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.05521576),
        dec: Angle.Degrees(+22.05543999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195560"},
        {"Hipparcos Number", "HIP 101251"},
        {"Geneva Identification System", "GEN# +1.00195560"},
        {"Smithsonian Astrophysical Observation", "SAO 88793"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.85585686),
        dec: Angle.Degrees(+22.05592181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284138"},
        {"Hipparcos Number", "HIP 19075"},
        {"Smithsonian Astrophysical Observation", "SAO 76439"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.33259117),
        dec: Angle.Degrees(+22.05778819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16174"},
        {"Smithsonian Astrophysical Observation", "SAO 75944"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.09392363),
        dec: Angle.Degrees(+22.05908685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284194"},
        {"Hipparcos Number", "HIP 19558"},
        {"Smithsonian Astrophysical Observation", "SAO 76488"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.84092495),
        dec: Angle.Degrees(+22.06112731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47740"},
        {"Fundamental Katalog 5th Edition", "FK5 4864"},
        {"Smithsonian Astrophysical Observation", "SAO 80990"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.97921369),
        dec: Angle.Degrees(+22.06734957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164306"},
        {"Hipparcos Number", "HIP 88108"},
        {"Smithsonian Astrophysical Observation", "SAO 85612"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.91720148),
        dec: Angle.Degrees(+22.07074851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66347"},
        {"Hipparcos Number", "HIP 39447"},
        {"Geneva Identification System", "GEN# +1.00066347"},
        {"Smithsonian Astrophysical Observation", "SAO 79903"},
        {"Wilson Evans Batten Catalogue", "WEB 7716"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.96043031),
        dec: Angle.Degrees(+22.07081459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96573"},
        {"Hipparcos Number", "HIP 54393"},
        {"Smithsonian Astrophysical Observation", "SAO 81683"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.94714404),
        dec: Angle.Degrees(+22.07121623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39392"},
        {"Hipparcos Number", "HIP 27828"},
        {"Smithsonian Astrophysical Observation", "SAO 77679"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.32934165),
        dec: Angle.Degrees(+22.07233959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92051"},
        {"Hipparcos Number", "HIP 52042"},
        {"Smithsonian Astrophysical Observation", "SAO 81446"},
    },
    visualMagnitude: 8.97,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.50087946),
        dec: Angle.Degrees(+22.07406632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343531"},
        {"Hipparcos Number", "HIP 93136"},
        {"Smithsonian Astrophysical Observation", "SAO 86640"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.59380398),
        dec: Angle.Degrees(+22.07500046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72205"},
        {"Smithsonian Astrophysical Observation", "SAO 83508"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.51427433),
        dec: Angle.Degrees(+22.07713335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127666"},
        {"Hipparcos Number", "HIP 71072"},
        {"Geneva Identification System", "GEN# +1.00127666"},
        {"Smithsonian Astrophysical Observation", "SAO 83391"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.00907102),
        dec: Angle.Degrees(+22.07983610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347287"},
        {"Hipparcos Number", "HIP 102279"},
        {"Renson", "Renson 55060"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.85796508),
        dec: Angle.Degrees(+22.08100302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25604"},
        {"Hipparcos Number", "HIP 19038"},
        {"Fundamental Katalog 5th Edition", "FK5 1112"},
        {"Geneva Identification System", "GEN# +1.00025604"},
        {"Smithsonian Astrophysical Observation", "SAO 76430"},
        {"Wilson Evans Batten Catalogue", "WEB 3661"},
    },
    visualMagnitude: 4.36,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.17357446),
        dec: Angle.Degrees(+22.08206790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108846"},
        {"Smithsonian Astrophysical Observation", "SAO 90193"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.73679805),
        dec: Angle.Degrees(+22.08296391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61778"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.93475160),
        dec: Angle.Degrees(+22.08336786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114631",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16602 AB"},
        {"Henry Draper", "HD 219111"},
        {"Hipparcos Number", "HIP 114631"},
        {"Smithsonian Astrophysical Observation", "SAO 91098"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.32397815),
        dec: Angle.Degrees(+22.08401156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83692",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10343 A"},
        {"Henry Draper", "HD 154733"},
        {"Hipparcos Number", "HIP 83692"},
        {"Fundamental Katalog 5th Edition", "FK5 3360"},
        {"Geneva Identification System", "GEN# +1.00154733"},
        {"Smithsonian Astrophysical Observation", "SAO 84835"},
        {"Wilson Evans Batten Catalogue", "WEB 14152"},
    },
    visualMagnitude: 5.56,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.57545246),
        dec: Angle.Degrees(+22.08424707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65527",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65527"},
        {"Geneva Identification System", "GEN# +0.02202578"},
    },
    visualMagnitude: 10.82,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.48803256),
        dec: Angle.Degrees(+22.08634695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15632"},
        {"Hipparcos Number", "HIP 11728"},
        {"Geneva Identification System", "GEN# +1.00015632"},
        {"Smithsonian Astrophysical Observation", "SAO 75417"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.85031895),
        dec: Angle.Degrees(+22.08732063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102714"},
        {"Hipparcos Number", "HIP 57673"},
        {"Smithsonian Astrophysical Observation", "SAO 82007"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.43426832),
        dec: Angle.Degrees(+22.08867074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177596"},
        {"Hipparcos Number", "HIP 93677"},
        {"Geneva Identification System", "GEN# +1.00177596"},
        {"Smithsonian Astrophysical Observation", "SAO 86771"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.15267462),
        dec: Angle.Degrees(+22.09039552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93552"},
        {"Hipparcos Number", "HIP 52846"},
        {"Smithsonian Astrophysical Observation", "SAO 81530"},
        {"Wilson Evans Batten Catalogue", "WEB 9619"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.08275483),
        dec: Angle.Degrees(+22.09163880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155228"},
        {"Hipparcos Number", "HIP 83942"},
        {"Geneva Identification System", "GEN# +1.00155228"},
        {"Smithsonian Astrophysical Observation", "SAO 84877"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.36318168),
        dec: Angle.Degrees(+22.09195186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104452"},
        {"Hipparcos Number", "HIP 58661"},
        {"Geneva Identification System", "GEN# +1.00104452"},
        {"Smithsonian Astrophysical Observation", "SAO 82106"},
        {"Wilson Evans Batten Catalogue", "WEB 10466"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.43458077),
        dec: Angle.Degrees(+22.09432783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2372"},
        {"Hipparcos Number", "HIP 2193"},
        {"Smithsonian Astrophysical Observation", "SAO 74012"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.92769708),
        dec: Angle.Degrees(+22.09566223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52473"},
        {"Hipparcos Number", "HIP 33911"},
        {"Geneva Identification System", "GEN# +1.00052473"},
        {"Smithsonian Astrophysical Observation", "SAO 78996"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.56897142),
        dec: Angle.Degrees(+22.09622520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34559"},
        {"Hipparcos Number", "HIP 24822"},
        {"Fundamental Katalog 5th Edition", "FK5 2398"},
        {"Geneva Identification System", "GEN# +1.00034559"},
        {"Smithsonian Astrophysical Observation", "SAO 77097"},
        {"Wilson Evans Batten Catalogue", "WEB 4803"},
    },
    visualMagnitude: 4.96,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.81912416),
        dec: Angle.Degrees(+22.09669104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69988"},
        {"Smithsonian Astrophysical Observation", "SAO 83290"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.81654266),
        dec: Angle.Degrees(+22.09878699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215041"},
        {"Hipparcos Number", "HIP 112075"},
        {"Smithsonian Astrophysical Observation", "SAO 90721"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.51106100),
        dec: Angle.Degrees(+22.10019954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41513"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.99230582),
        dec: Angle.Degrees(+22.10210548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5931"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.06509254),
        dec: Angle.Degrees(+22.10414374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12413"},
        {"Hipparcos Number", "HIP 9492"},
        {"Fundamental Katalog 5th Edition", "FK5 4183"},
        {"Geneva Identification System", "GEN# +1.00012413"},
        {"Smithsonian Astrophysical Observation", "SAO 75101"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.52988525),
        dec: Angle.Degrees(+22.10422589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111463"},
        {"Fundamental Katalog 5th Edition", "FK5 5991"},
        {"Smithsonian Astrophysical Observation", "SAO 90616"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.74170589),
        dec: Angle.Degrees(+22.10429543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37986"},
        {"Smithsonian Astrophysical Observation", "SAO 79689"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.78185935),
        dec: Angle.Degrees(+22.10614249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212416"},
        {"Hipparcos Number", "HIP 110559"},
        {"Smithsonian Astrophysical Observation", "SAO 90467"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.95068720),
        dec: Angle.Degrees(+22.10649267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153062"},
        {"Hipparcos Number", "HIP 82889"},
        {"Smithsonian Astrophysical Observation", "SAO 84703"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.08389173),
        dec: Angle.Degrees(+22.10696060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91234",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11498 A"},
        {"Henry Draper", "HD 171948"},
        {"Hipparcos Number", "HIP 91234"},
        {"Smithsonian Astrophysical Observation", "SAO 86239"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.15428615),
        dec: Angle.Degrees(+22.10760395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112196"},
        {"Hipparcos Number", "HIP 63008"},
        {"Geneva Identification System", "GEN# +1.00112196"},
        {"Smithsonian Astrophysical Observation", "SAO 82559"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.66659563),
        dec: Angle.Degrees(+22.10801238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42743"},
        {"Smithsonian Astrophysical Observation", "SAO 80375"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.66909041),
        dec: Angle.Degrees(+22.10900463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85344"},
        {"Smithsonian Astrophysical Observation", "SAO 85087"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.59688825),
        dec: Angle.Degrees(+22.10985186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30075",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4932 AB"},
        {"Henry Draper", "HD 43907"},
        {"Hipparcos Number", "HIP 30075"},
        {"Geneva Identification System", "GEN# +1.00043907"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.93846461),
        dec: Angle.Degrees(+22.11078629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187712"},
        {"Hipparcos Number", "HIP 97641"},
        {"Geneva Identification System", "GEN# +1.00187712"},
        {"Smithsonian Astrophysical Observation", "SAO 87803"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.67313128),
        dec: Angle.Degrees(+22.11292260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17649"},
        {"Hipparcos Number", "HIP 13253"},
        {"Smithsonian Astrophysical Observation", "SAO 75600"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.64134544),
        dec: Angle.Degrees(+22.11393230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202865"},
        {"Hipparcos Number", "HIP 105161"},
        {"Smithsonian Astrophysical Observation", "SAO 89597"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.54434080),
        dec: Angle.Degrees(+22.11427446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57828"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.88974645),
        dec: Angle.Degrees(+22.11453170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195133"},
        {"Hipparcos Number", "HIP 101016"},
        {"Smithsonian Astrophysical Observation", "SAO 88729"},
    },
    visualMagnitude: 8.75,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.19459588),
        dec: Angle.Degrees(+22.11513403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114240"},
    },
    visualMagnitude: 11.15,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.06124070),
        dec: Angle.Degrees(+22.11608668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33466"},
        {"Hipparcos Number", "HIP 24158"},
        {"Smithsonian Astrophysical Observation", "SAO 77022"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.82446981),
        dec: Angle.Degrees(+22.11688130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37123"},
        {"Hipparcos Number", "HIP 26389"},
        {"Geneva Identification System", "GEN# +1.00037123"},
        {"Smithsonian Astrophysical Observation", "SAO 77324"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.27268306),
        dec: Angle.Degrees(+22.11692231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61717"},
        {"Hipparcos Number", "HIP 37476"},
        {"Smithsonian Astrophysical Observation", "SAO 79615"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.39432196),
        dec: Angle.Degrees(+22.11745269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46386"},
        {"Hipparcos Number", "HIP 31316"},
        {"Geneva Identification System", "GEN# +1.00046386"},
        {"Smithsonian Astrophysical Observation", "SAO 78507"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.51516226),
        dec: Angle.Degrees(+22.11774440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268231"},
        {"Hipparcos Number", "HIP 33962"},
        {"Smithsonian Astrophysical Observation", "SAO 79001"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.70778307),
        dec: Angle.Degrees(+22.11968598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218486"},
        {"Hipparcos Number", "HIP 114243"},
        {"Smithsonian Astrophysical Observation", "SAO 91032"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.06461372),
        dec: Angle.Degrees(+22.12012999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116985",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116985"},
        {"Smithsonian Astrophysical Observation", "SAO 91441"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.74688865),
        dec: Angle.Degrees(+22.12294196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343965"},
        {"Hipparcos Number", "HIP 94327"},
        {"Smithsonian Astrophysical Observation", "SAO 86918"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.98944937),
        dec: Angle.Degrees(+22.12296272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85557"},
        {"Hipparcos Number", "HIP 48472"},
        {"Geneva Identification System", "GEN# +1.00085557"},
        {"Smithsonian Astrophysical Observation", "SAO 81066"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.26841792),
        dec: Angle.Degrees(+22.12331940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109055"},
        {"Hipparcos Number", "HIP 61138"},
        {"Geneva Identification System", "GEN# +1.00109055"},
        {"Smithsonian Astrophysical Observation", "SAO 82356"},
        {"Wilson Evans Batten Catalogue", "WEB 10887"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.92209565),
        dec: Angle.Degrees(+22.12344140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46401"},
        {"Hipparcos Number", "HIP 31323"},
        {"Geneva Identification System", "GEN# +1.00046401"},
        {"Smithsonian Astrophysical Observation", "SAO 78508"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.52959890),
        dec: Angle.Degrees(+22.12422561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4703"},
        {"Hipparcos Number", "HIP 3841"},
        {"Smithsonian Astrophysical Observation", "SAO 74291"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.32006206),
        dec: Angle.Degrees(+22.12819784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67769"},
        {"Geneva Identification System", "GEN# +0.02202643"},
        {"Smithsonian Astrophysical Observation", "SAO 83050"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.25693735),
        dec: Angle.Degrees(+22.12830067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195034"},
        {"Hipparcos Number", "HIP 100963"},
        {"Geneva Identification System", "GEN# +1.00195034"},
        {"Smithsonian Astrophysical Observation", "SAO 88711"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.04929063),
        dec: Angle.Degrees(+22.12958535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48075"},
        {"Hipparcos Number", "HIP 32122"},
        {"Smithsonian Astrophysical Observation", "SAO 78661"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.63845508),
        dec: Angle.Degrees(+22.13057783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48263"},
        {"Smithsonian Astrophysical Observation", "SAO 81042"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.59019928),
        dec: Angle.Degrees(+22.13104675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158573"},
        {"Hipparcos Number", "HIP 85567"},
        {"Geneva Identification System", "GEN# +1.00158573"},
        {"Smithsonian Astrophysical Observation", "SAO 85134"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.30339143),
        dec: Angle.Degrees(+22.13273404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115419",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115419"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.70297596),
        dec: Angle.Degrees(+22.13332142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 200.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33300"},
        {"Hipparcos Number", "HIP 24063"},
        {"Smithsonian Astrophysical Observation", "SAO 77003"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.55392464),
        dec: Angle.Degrees(+22.13666675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25266"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.05328857),
        dec: Angle.Degrees(+22.13794724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98295",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13184 AB"},
        {"Henry Draper", "HD 345343"},
        {"Hipparcos Number", "HIP 98295"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.57365614),
        dec: Angle.Degrees(+22.13828269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210264"},
        {"Hipparcos Number", "HIP 109319"},
        {"Geneva Identification System", "GEN# +1.00210264"},
        {"Smithsonian Astrophysical Observation", "SAO 90266"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.20998559),
        dec: Angle.Degrees(+22.13878476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243252"},
        {"Hipparcos Number", "HIP 25264"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.05137501),
        dec: Angle.Degrees(+22.14032340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36232",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6087 A"},
        {"Henry Draper", "HD 58712"},
        {"Hipparcos Number", "HIP 36232"},
        {"Geneva Identification System", "GEN# +1.00058712A"},
        {"Smithsonian Astrophysical Observation", "SAO 79401"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.91892864),
        dec: Angle.Degrees(+22.14147150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142637"},
        {"Hipparcos Number", "HIP 77930"},
        {"Geneva Identification System", "GEN# +1.00142637"},
        {"Smithsonian Astrophysical Observation", "SAO 84072"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.72884666),
        dec: Angle.Degrees(+22.14256420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43479"},
        {"Hipparcos Number", "HIP 29867"},
        {"Geneva Identification System", "GEN# +1.00043479"},
        {"Smithsonian Astrophysical Observation", "SAO 78182"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.33482467),
        dec: Angle.Degrees(+22.14398597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341475"},
        {"Hipparcos Number", "HIP 88008"},
        {"Geneva Identification System", "GEN# +1.00341475"},
        {"Smithsonian Astrophysical Observation", "SAO 85600"},
        {"Wilson Evans Batten Catalogue", "WEB 14863"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.66048231),
        dec: Angle.Degrees(+22.14640784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31221"},
        {"Hipparcos Number", "HIP 22838"},
        {"Geneva Identification System", "GEN# +1.00031221"},
        {"Smithsonian Astrophysical Observation", "SAO 76830"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.70583754),
        dec: Angle.Degrees(+22.14655054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263885"},
        {"Hipparcos Number", "HIP 32587"},
        {"Smithsonian Astrophysical Observation", "SAO 78754"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.98907564),
        dec: Angle.Degrees(+22.14744310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80688"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.11880290),
        dec: Angle.Degrees(+22.14759350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47031"},
        {"Hipparcos Number", "HIP 31651"},
        {"Geneva Identification System", "GEN# +1.00047031"},
        {"Smithsonian Astrophysical Observation", "SAO 78558"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.37210751),
        dec: Angle.Degrees(+22.14882420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195874"},
        {"Hipparcos Number", "HIP 101418"},
        {"Smithsonian Astrophysical Observation", "SAO 88826"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.28835995),
        dec: Angle.Degrees(+22.14935024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190066"},
        {"Hipparcos Number", "HIP 98661"},
        {"Geneva Identification System", "GEN# +1.00190066"},
        {"Smithsonian Astrophysical Observation", "SAO 88105"},
        {"Wilson Evans Batten Catalogue", "WEB 17458"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.59210822),
        dec: Angle.Degrees(+22.15148634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108548",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108548"},
        {"Smithsonian Astrophysical Observation", "SAO 90150"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.83987623),
        dec: Angle.Degrees(+22.15328820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191359"},
        {"Hipparcos Number", "HIP 99243"},
        {"Smithsonian Astrophysical Observation", "SAO 88244"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.17906246),
        dec: Angle.Degrees(+22.15351625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83974"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.48560630),
        dec: Angle.Degrees(+22.15357242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187882"},
        {"Hipparcos Number", "HIP 97729"},
        {"Geneva Identification System", "GEN# +1.00187882"},
        {"Smithsonian Astrophysical Observation", "SAO 87828"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.90492950),
        dec: Angle.Degrees(+22.15623492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220017"},
        {"Hipparcos Number", "HIP 115239"},
        {"Geneva Identification System", "GEN# +1.00220017"},
        {"Smithsonian Astrophysical Observation", "SAO 91183"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.12040379),
        dec: Angle.Degrees(+22.15697214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9796"},
        {"Smithsonian Astrophysical Observation", "SAO 75139"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.49445812),
        dec: Angle.Degrees(+22.15809900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184740"},
        {"Hipparcos Number", "HIP 96330"},
        {"Geneva Identification System", "GEN# +1.00184740"},
        {"Smithsonian Astrophysical Observation", "SAO 87390"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.78309436),
        dec: Angle.Degrees(+22.15860009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204245"},
        {"Hipparcos Number", "HIP 105895"},
        {"Smithsonian Astrophysical Observation", "SAO 89711"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.70986663),
        dec: Angle.Degrees(+22.16382164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87583"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.37736599),
        dec: Angle.Degrees(+22.16417009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108008"},
        {"Hipparcos Number", "HIP 60531"},
        {"Smithsonian Astrophysical Observation", "SAO 82294"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.12670326),
        dec: Angle.Degrees(+22.16506461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123282"},
        {"Hipparcos Number", "HIP 68880"},
        {"Geneva Identification System", "GEN# +1.00123282"},
        {"Smithsonian Astrophysical Observation", "SAO 83163"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.55650456),
        dec: Angle.Degrees(+22.16771796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59942"},
        {"Smithsonian Astrophysical Observation", "SAO 82220"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.43738513),
        dec: Angle.Degrees(+22.16772944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83534"},
        {"Hipparcos Number", "HIP 47407"},
        {"Smithsonian Astrophysical Observation", "SAO 80957"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.89616665),
        dec: Angle.Degrees(+22.16853303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242917"},
        {"Hipparcos Number", "HIP 25070"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.50473439),
        dec: Angle.Degrees(+22.16882770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343306"},
        {"Hipparcos Number", "HIP 92657"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.22418226),
        dec: Angle.Degrees(+22.16966339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284766"},
        {"Hipparcos Number", "HIP 22291"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.00867106),
        dec: Angle.Degrees(+22.16991520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43385"},
        {"Hipparcos Number", "HIP 29827"},
        {"Geneva Identification System", "GEN# +1.00043385"},
        {"Smithsonian Astrophysical Observation", "SAO 78174"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.21767348),
        dec: Angle.Degrees(+22.17060189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93859",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12050 AB"},
        {"Henry Draper", "HD 178211"},
        {"Hipparcos Number", "HIP 93859"},
        {"Geneva Identification System", "GEN# +1.00178211"},
        {"Smithsonian Astrophysical Observation", "SAO 86821"},
        {"Wilson Evans Batten Catalogue", "WEB 16325"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.72083592),
        dec: Angle.Degrees(+22.17263654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73000"},
        {"Hipparcos Number", "HIP 42235"},
        {"Smithsonian Astrophysical Observation", "SAO 80284"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.16662041),
        dec: Angle.Degrees(+22.17298207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107512",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15311 AD"},
        {"Henry Draper", "HD 207147"},
        {"Hipparcos Number", "HIP 107512"},
        {"Smithsonian Astrophysical Observation", "SAO 89978"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.61996087),
        dec: Angle.Degrees(+22.17447428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82556"},
        {"Hipparcos Number", "HIP 46882"},
        {"Smithsonian Astrophysical Observation", "SAO 80901"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.31285833),
        dec: Angle.Degrees(+22.17502421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162556"},
        {"Hipparcos Number", "HIP 87334"},
        {"Geneva Identification System", "GEN# +1.00162556"},
        {"Smithsonian Astrophysical Observation", "SAO 85467"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.68151317),
        dec: Angle.Degrees(+22.17511255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117898"},
        {"Smithsonian Astrophysical Observation", "SAO 91571"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.71479796),
        dec: Angle.Degrees(+22.17515862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157912"},
        {"Hipparcos Number", "HIP 85255"},
        {"Smithsonian Astrophysical Observation", "SAO 85066"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.32043172),
        dec: Angle.Degrees(+22.17905954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204585"},
        {"Hipparcos Number", "HIP 106062"},
        {"Geneva Identification System", "GEN# +1.00204585A"},
        {"Smithsonian Astrophysical Observation", "SAO 89737"},
        {"Wilson Evans Batten Catalogue", "WEB 19224"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.24898803),
        dec: Angle.Degrees(+22.17940400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98217"},
        {"Hipparcos Number", "HIP 55193"},
        {"Geneva Identification System", "GEN# +1.00098217"},
        {"Smithsonian Astrophysical Observation", "SAO 81760"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.50583906),
        dec: Angle.Degrees(+22.17997352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63092"},
        {"Geneva Identification System", "GEN# +0.02202523"},
        {"Smithsonian Astrophysical Observation", "SAO 82571"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.90973553),
        dec: Angle.Degrees(+22.18090562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129025"},
        {"Hipparcos Number", "HIP 71687"},
        {"Smithsonian Astrophysical Observation", "SAO 83455"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.94612013),
        dec: Angle.Degrees(+22.18136657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78800",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9917 AB"},
        {"Henry Draper", "HD 144447"},
        {"Hipparcos Number", "HIP 78800"},
        {"Smithsonian Astrophysical Observation", "SAO 84186"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.31115842),
        dec: Angle.Degrees(+22.18201537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65781",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8918 A"},
        {"Henry Draper", "HD 117318A"},
        {"Henry Draper 2", "HD 117318"},
        {"Hipparcos Number", "HIP 65781"},
        {"Cincinnati Publication", "Ci 18 1742"},
        {"Smithsonian Astrophysical Observation", "SAO 82862"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.27628180),
        dec: Angle.Degrees(+22.18269320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -232.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72044"},
        {"Geneva Identification System", "GEN# +0.02202742"},
        {"Wilson Evans Batten Catalogue", "WEB 12399"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.04995691),
        dec: Angle.Degrees(+22.18503524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 117.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46030"},
        {"Hipparcos Number", "HIP 31139"},
        {"Smithsonian Astrophysical Observation", "SAO 78467"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.99770515),
        dec: Angle.Degrees(+22.18575237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182146"},
        {"Hipparcos Number", "HIP 95229"},
        {"Smithsonian Astrophysical Observation", "SAO 87129"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.62825443),
        dec: Angle.Degrees(+22.18805579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162384"},
        {"Hipparcos Number", "HIP 87276"},
        {"Smithsonian Astrophysical Observation", "SAO 85453"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.49543172),
        dec: Angle.Degrees(+22.18908841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74867"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.49184101),
        dec: Angle.Degrees(+22.18973710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 266.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42049"},
        {"Hipparcos Number", "HIP 29196"},
        {"Geneva Identification System", "GEN# +1.00042049"},
        {"Smithsonian Astrophysical Observation", "SAO 78045"},
        {"Wilson Evans Batten Catalogue", "WEB 5724"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.38517315),
        dec: Angle.Degrees(+22.19027415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202330"},
        {"Hipparcos Number", "HIP 104866"},
        {"Smithsonian Astrophysical Observation", "SAO 89555"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.64232582),
        dec: Angle.Degrees(+22.19246416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108069"},
        {"Smithsonian Astrophysical Observation", "SAO 90080"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.43057596),
        dec: Angle.Degrees(+22.19304071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224129"},
        {"Hipparcos Number", "HIP 117946"},
        {"Cincinnati Publication", "Ci 18 3132"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.86027750),
        dec: Angle.Degrees(+22.19364366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 204.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48994"},
        {"Hipparcos Number", "HIP 32523"},
        {"Smithsonian Astrophysical Observation", "SAO 78742"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.80462925),
        dec: Angle.Degrees(+22.19470490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206367"},
        {"Hipparcos Number", "HIP 107064"},
        {"Smithsonian Astrophysical Observation", "SAO 89903"},
        {"Wilson Evans Batten Catalogue", "WEB 19338"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.26308994),
        dec: Angle.Degrees(+22.19481556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149009"},
        {"Hipparcos Number", "HIP 80898"},
        {"Geneva Identification System", "GEN# +1.00149009"},
        {"Smithsonian Astrophysical Observation", "SAO 84423"},
        {"Wilson Evans Batten Catalogue", "WEB 13682"},
    },
    visualMagnitude: 5.76,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.80599042),
        dec: Angle.Degrees(+22.19543891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92254"},
        {"Hipparcos Number", "HIP 52158"},
        {"Geneva Identification System", "GEN# +1.00092254"},
        {"Smithsonian Astrophysical Observation", "SAO 81454"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.83925426),
        dec: Angle.Degrees(+22.19678163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181751"},
        {"Hipparcos Number", "HIP 95109"},
        {"Smithsonian Astrophysical Observation", "SAO 87102"},
    },
    visualMagnitude: 6.56,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.22625358),
        dec: Angle.Degrees(+22.19880716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27946"},
        {"Hipparcos Number", "HIP 20641"},
        {"Geneva Identification System", "GEN# +5.20250055"},
        {"Smithsonian Astrophysical Observation", "SAO 76602"},
        {"Wilson Evans Batten Catalogue", "WEB 3955"},
    },
    visualMagnitude: 5.27,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.35393596),
        dec: Angle.Degrees(+22.20011240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182619"},
        {"Hipparcos Number", "HIP 95428"},
        {"Geneva Identification System", "GEN# +1.00182619"},
        {"Smithsonian Astrophysical Observation", "SAO 87170"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.17411989),
        dec: Angle.Degrees(+22.20173004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145146"},
        {"Hipparcos Number", "HIP 79091"},
        {"Smithsonian Astrophysical Observation", "SAO 84208"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.16415313),
        dec: Angle.Degrees(+22.20383948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82603"},
        {"Smithsonian Astrophysical Observation", "SAO 84664"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.30101468),
        dec: Angle.Degrees(+22.20399678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92612"},
        {"Hipparcos Number", "HIP 52345"},
        {"Smithsonian Astrophysical Observation", "SAO 81479"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.47129306),
        dec: Angle.Degrees(+22.20438135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106858"},
        {"Hipparcos Number", "HIP 59911"},
        {"Geneva Identification System", "GEN# +1.00106858"},
        {"Smithsonian Astrophysical Observation", "SAO 82217"},
        {"Wilson Evans Batten Catalogue", "WEB 10643"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.33288158),
        dec: Angle.Degrees(+22.20858924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344579"},
        {"Hipparcos Number", "HIP 96122"},
        {"Smithsonian Astrophysical Observation", "SAO 87335"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.16244401),
        dec: Angle.Degrees(+22.20967303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101688"},
        {"Hipparcos Number", "HIP 57082"},
        {"Geneva Identification System", "GEN# +1.00101688"},
        {"Smithsonian Astrophysical Observation", "SAO 81949"},
        {"Wilson Evans Batten Catalogue", "WEB 10274"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.52187873),
        dec: Angle.Degrees(+22.21119174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76025"},
        {"Hipparcos Number", "HIP 43727"},
        {"Fundamental Katalog 5th Edition", "FK5 4795"},
        {"Geneva Identification System", "GEN# +1.00076025"},
        {"Smithsonian Astrophysical Observation", "SAO 80496"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.57824463),
        dec: Angle.Degrees(+22.21177214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62690"},
        {"Geneva Identification System", "GEN# +0.02302505"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.69075546),
        dec: Angle.Degrees(+22.21256231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112755"},
        {"Hipparcos Number", "HIP 63339"},
        {"Smithsonian Astrophysical Observation", "SAO 82594"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.69272994),
        dec: Angle.Degrees(+22.21377563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182695"},
        {"Hipparcos Number", "HIP 95462"},
        {"Smithsonian Astrophysical Observation", "SAO 87181"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.28683982),
        dec: Angle.Degrees(+22.21580802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165625"},
        {"Hipparcos Number", "HIP 88657"},
        {"Geneva Identification System", "GEN# +1.00165625"},
        {"Smithsonian Astrophysical Observation", "SAO 85725"},
        {"Wilson Evans Batten Catalogue", "WEB 15018"},
    },
    visualMagnitude: 4.96,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.50795297),
        dec: Angle.Degrees(+22.21889206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69606"},
        {"Hipparcos Number", "HIP 40696"},
        {"Smithsonian Astrophysical Observation", "SAO 80082"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.60917772),
        dec: Angle.Degrees(+22.22046599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284487"},
        {"Hipparcos Number", "HIP 21115"},
    },
    visualMagnitude: 11.47,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.87935245),
        dec: Angle.Degrees(+22.22085947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150296"},
        {"Hipparcos Number", "HIP 81543"},
        {"Smithsonian Astrophysical Observation", "SAO 84513"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.82263801),
        dec: Angle.Degrees(+22.22116622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47481"},
        {"Hipparcos Number", "HIP 31880"},
        {"Smithsonian Astrophysical Observation", "SAO 78604"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.96818045),
        dec: Angle.Degrees(+22.22213193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192424"},
        {"Hipparcos Number", "HIP 99717"},
        {"Smithsonian Astrophysical Observation", "SAO 88384"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.51884608),
        dec: Angle.Degrees(+22.22263805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51509"},
        {"Smithsonian Astrophysical Observation", "SAO 81392"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.78565685),
        dec: Angle.Degrees(+22.22402197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61997"},
        {"Hipparcos Number", "HIP 37579"},
        {"Geneva Identification System", "GEN# +1.00061997"},
        {"Smithsonian Astrophysical Observation", "SAO 79628"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.67915533),
        dec: Angle.Degrees(+22.22411376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40"},
        {"Hipparcos Number", "HIP 460"},
        {"Smithsonian Astrophysical Observation", "SAO 73735"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.36976446),
        dec: Angle.Degrees(+22.22467477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110293"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.10453371),
        dec: Angle.Degrees(+22.22799291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190789"},
        {"Hipparcos Number", "HIP 99000"},
        {"Smithsonian Astrophysical Observation", "SAO 88181"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.48559781),
        dec: Angle.Degrees(+22.22934463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75811"},
        {"Smithsonian Astrophysical Observation", "SAO 83846"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.30224901),
        dec: Angle.Degrees(+22.22992045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284316"},
        {"Hipparcos Number", "HIP 20278"},
        {"Geneva Identification System", "GEN# +1.00284316"},
        {"Smithsonian Astrophysical Observation", "SAO 76562"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.19617971),
        dec: Angle.Degrees(+22.23134988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119007"},
        {"Hipparcos Number", "HIP 66699"},
        {"Geneva Identification System", "GEN# +1.00119007"},
        {"Smithsonian Astrophysical Observation", "SAO 82940"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.08804679),
        dec: Angle.Degrees(+22.23255874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345020"},
        {"Hipparcos Number", "HIP 97413"},
        {"Smithsonian Astrophysical Observation", "SAO 87730"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.98169797),
        dec: Angle.Degrees(+22.23343330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250642"},
        {"Hipparcos Number", "HIP 28625"},
        {"Geneva Identification System", "GEN# +1.00250642"},
        {"Wilson Evans Batten Catalogue", "WEB 5594"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.65245039),
        dec: Angle.Degrees(+22.23415230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22715",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3494 A"},
        {"Henry Draper", "HD 30973"},
        {"Hipparcos Number", "HIP 22715"},
        {"Smithsonian Astrophysical Observation", "SAO 76806"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.26932070),
        dec: Angle.Degrees(+22.23548477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106296",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106296"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.93540708),
        dec: Angle.Degrees(+22.23575309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343646"},
        {"Hipparcos Number", "HIP 93435"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.43846962),
        dec: Angle.Degrees(+22.23583048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143992"},
        {"Hipparcos Number", "HIP 78590"},
        {"Geneva Identification System", "GEN# +1.00143992"},
        {"Smithsonian Astrophysical Observation", "SAO 84162"},
        {"Wilson Evans Batten Catalogue", "WEB 13283"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.69260680),
        dec: Angle.Degrees(+22.23852598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220540"},
        {"Hipparcos Number", "HIP 115558"},
        {"Smithsonian Astrophysical Observation", "SAO 91243"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.11392308),
        dec: Angle.Degrees(+22.23932460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147430"},
        {"Hipparcos Number", "HIP 80111"},
        {"Geneva Identification System", "GEN# +1.00147430"},
        {"Smithsonian Astrophysical Observation", "SAO 84315"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.29465305),
        dec: Angle.Degrees(+22.23985645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222067"},
        {"Hipparcos Number", "HIP 116564"},
        {"Smithsonian Astrophysical Observation", "SAO 91384"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.32828872),
        dec: Angle.Degrees(+22.24039208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210373"},
        {"Hipparcos Number", "HIP 109387"},
        {"Smithsonian Astrophysical Observation", "SAO 90278"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.41433465),
        dec: Angle.Degrees(+22.24224290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59177",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59177"},
        {"Smithsonian Astrophysical Observation", "SAO 82147"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.03569681),
        dec: Angle.Degrees(+22.24227112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83146"},
        {"Hipparcos Number", "HIP 47179"},
        {"Smithsonian Astrophysical Observation", "SAO 80929"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.21849922),
        dec: Angle.Degrees(+22.24414327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23950"},
        {"Hipparcos Number", "HIP 17921"},
        {"Celescope Catalog", "CEL 366"},
        {"Geneva Identification System", "GEN# +5.20223325"},
        {"Renson", "Renson 6130"},
        {"Smithsonian Astrophysical Observation", "SAO 76250"},
        {"Wilson Evans Batten Catalogue", "WEB 3449"},
    },
    visualMagnitude: 6.05,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.47940839),
        dec: Angle.Degrees(+22.24426286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16730"},
        {"Hipparcos Number", "HIP 12556"},
        {"Smithsonian Astrophysical Observation", "SAO 75521"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.37734695),
        dec: Angle.Degrees(+22.24460643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180140"},
        {"Hipparcos Number", "HIP 94546"},
        {"Smithsonian Astrophysical Observation", "SAO 86971"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.64696530),
        dec: Angle.Degrees(+22.24505296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59756"},
        {"Geneva Identification System", "GEN# +0.02302436"},
        {"Smithsonian Astrophysical Observation", "SAO 82204"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.80916817),
        dec: Angle.Degrees(+22.24539842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43275"},
        {"Smithsonian Astrophysical Observation", "SAO 80442"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.24356403),
        dec: Angle.Degrees(+22.24584585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51748"},
        {"Hipparcos Number", "HIP 33656"},
        {"Smithsonian Astrophysical Observation", "SAO 78952"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.88131334),
        dec: Angle.Degrees(+22.24660233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63689"},
        {"Hipparcos Number", "HIP 38321"},
        {"Geneva Identification System", "GEN# +1.00063689"},
        {"Smithsonian Astrophysical Observation", "SAO 79744"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.76035240),
        dec: Angle.Degrees(+22.24839999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267095"},
        {"Hipparcos Number", "HIP 33564"},
        {"Smithsonian Astrophysical Observation", "SAO 78926"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.61514916),
        dec: Angle.Degrees(+22.25187721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15038"},
        {"Smithsonian Astrophysical Observation", "SAO 75804"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.45911582),
        dec: Angle.Degrees(+22.25260987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284382"},
        {"Hipparcos Number", "HIP 20391"},
        {"Smithsonian Astrophysical Observation", "SAO 76568"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.49753428),
        dec: Angle.Degrees(+22.25631937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96691",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12752 AB"},
        {"Henry Draper", "HD 185661"},
        {"Hipparcos Number", "HIP 96691"},
        {"Smithsonian Astrophysical Observation", "SAO 87508"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.85961488),
        dec: Angle.Degrees(+22.25645188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77391"},
        {"Hipparcos Number", "HIP 44414"},
        {"Geneva Identification System", "GEN# +1.00077391"},
        {"Smithsonian Astrophysical Observation", "SAO 80597"},
        {"Wilson Evans Batten Catalogue", "WEB 8515"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.71141630),
        dec: Angle.Degrees(+22.25860389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127739"},
        {"Hipparcos Number", "HIP 71115"},
        {"Fundamental Katalog 5th Edition", "FK5 3151"},
        {"Geneva Identification System", "GEN# +1.00127739"},
        {"Smithsonian Astrophysical Observation", "SAO 83395"},
        {"Wilson Evans Batten Catalogue", "WEB 12297"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.13592482),
        dec: Angle.Degrees(+22.25996072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61490"},
        {"Geneva Identification System", "GEN# +0.02302477"},
        {"Smithsonian Astrophysical Observation", "SAO 82396"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.98141346),
        dec: Angle.Degrees(+22.26235292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176971"},
        {"Hipparcos Number", "HIP 93443"},
        {"Geneva Identification System", "GEN# +1.00176971"},
        {"Smithsonian Astrophysical Observation", "SAO 86716"},
        {"Wilson Evans Batten Catalogue", "WEB 16217"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.45592960),
        dec: Angle.Degrees(+22.26437745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343525"},
        {"Hipparcos Number", "HIP 93326"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.13104924),
        dec: Angle.Degrees(+22.26554486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79446"},
        {"Smithsonian Astrophysical Observation", "SAO 84245"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.19799837),
        dec: Angle.Degrees(+22.26641263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126169"},
        {"Hipparcos Number", "HIP 70326"},
        {"Smithsonian Astrophysical Observation", "SAO 83322"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.83985158),
        dec: Angle.Degrees(+22.27195237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284991"},
        {"Hipparcos Number", "HIP 22918"},
        {"Smithsonian Astrophysical Observation", "SAO 76844"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.97949203),
        dec: Angle.Degrees(+22.27197088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160425"},
        {"Hipparcos Number", "HIP 86366"},
        {"Geneva Identification System", "GEN# +1.00160425"},
        {"Smithsonian Astrophysical Observation", "SAO 85280"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.71719049),
        dec: Angle.Degrees(+22.27470246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14710"},
        {"Hipparcos Number", "HIP 11114"},
        {"Smithsonian Astrophysical Observation", "SAO 75325"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.75145119),
        dec: Angle.Degrees(+22.27495574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8544",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1457 AB"},
        {"Hipparcos Number", "HIP 8544"},
        {"Smithsonian Astrophysical Observation", "SAO 74966"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.53575113),
        dec: Angle.Degrees(+22.27535660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285165"},
        {"Hipparcos Number", "HIP 23656"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.26163406),
        dec: Angle.Degrees(+22.27599714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193668"},
        {"Hipparcos Number", "HIP 100313"},
        {"Smithsonian Astrophysical Observation", "SAO 88544"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.17545776),
        dec: Angle.Degrees(+22.27678620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15908"},
        {"Smithsonian Astrophysical Observation", "SAO 75919"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.21529017),
        dec: Angle.Degrees(+22.27823741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55005"},
        {"Hipparcos Number", "HIP 34779"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.00427945),
        dec: Angle.Degrees(+22.27910367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68581"},
        {"Hipparcos Number", "HIP 40306"},
        {"Smithsonian Astrophysical Observation", "SAO 80026"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.46088417),
        dec: Angle.Degrees(+22.27971479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113867"},
        {"Hipparcos Number", "HIP 63951"},
        {"Geneva Identification System", "GEN# +1.00113867"},
        {"Smithsonian Astrophysical Observation", "SAO 82652"},
        {"Wilson Evans Batten Catalogue", "WEB 11305"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.59461429),
        dec: Angle.Degrees(+22.27984442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187881"},
        {"Hipparcos Number", "HIP 97719"},
        {"Geneva Identification System", "GEN# +1.00187881"},
        {"Smithsonian Astrophysical Observation", "SAO 87824"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.88374343),
        dec: Angle.Degrees(+22.28086312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96912",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12799 AB"},
        {"Henry Draper", "HD 344813"},
        {"Hipparcos Number", "HIP 96912"},
        {"Smithsonian Astrophysical Observation", "SAO 87586"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.50270548),
        dec: Angle.Degrees(+22.28275721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1048"},
        {"Hipparcos Number", "HIP 1193"},
        {"Geneva Identification System", "GEN# +1.00001048"},
        {"Renson", "Renson 180"},
        {"Smithsonian Astrophysical Observation", "SAO 73838"},
        {"Wilson Evans Batten Catalogue", "WEB 212"},
    },
    visualMagnitude: 6.25,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.73279426),
        dec: Angle.Degrees(+22.28425185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284540"},
        {"Hipparcos Number", "HIP 21503"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.27802291),
        dec: Angle.Degrees(+22.28426636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34053"},
        {"Hipparcos Number", "HIP 24512"},
        {"Geneva Identification System", "GEN# +1.00034053"},
        {"Smithsonian Astrophysical Observation", "SAO 77057"},
        {"Wilson Evans Batten Catalogue", "WEB 4750"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.86525046),
        dec: Angle.Degrees(+22.28487452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67420"},
        {"Smithsonian Astrophysical Observation", "SAO 83010"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.26550908),
        dec: Angle.Degrees(+22.28658912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192850"},
        {"Hipparcos Number", "HIP 99915"},
        {"Smithsonian Astrophysical Observation", "SAO 88434"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.08627349),
        dec: Angle.Degrees(+22.28723908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59560"},
        {"Hipparcos Number", "HIP 36573"},
        {"Geneva Identification System", "GEN# +1.00059560"},
        {"Smithsonian Astrophysical Observation", "SAO 79465"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.83912897),
        dec: Angle.Degrees(+22.28790155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63753"},
        {"Geneva Identification System", "GEN# +0.02302532"},
        {"Smithsonian Astrophysical Observation", "SAO 82633"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.00887915),
        dec: Angle.Degrees(+22.29074373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27934"},
        {"Hipparcos Number", "HIP 20635"},
        {"Geneva Identification System", "GEN# +5.20250054"},
        {"Smithsonian Astrophysical Observation", "SAO 76601"},
        {"Wilson Evans Batten Catalogue", "WEB 3954"},
    },
    visualMagnitude: 4.21,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.34207825),
        dec: Angle.Degrees(+22.29398098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29689"},
        {"Geneva Identification System", "GEN# +0.02201244"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.82299812),
        dec: Angle.Degrees(+22.29495251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225149"},
        {"Hipparcos Number", "HIP 304"},
        {"Geneva Identification System", "GEN# +1.00225149"},
        {"Smithsonian Astrophysical Observation", "SAO 73719"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.96979503),
        dec: Angle.Degrees(+22.29607151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75359"},
        {"Smithsonian Astrophysical Observation", "SAO 83801"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.99706751),
        dec: Angle.Degrees(+22.29955293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135991"},
        {"Hipparcos Number", "HIP 74821"},
        {"Geneva Identification System", "GEN# +1.00135991"},
        {"Smithsonian Astrophysical Observation", "SAO 83749"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.36535241),
        dec: Angle.Degrees(+22.29971697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72646",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72646"},
        {"Smithsonian Astrophysical Observation", "SAO 83556"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.79408881),
        dec: Angle.Degrees(+22.29995851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43078"},
        {"Hipparcos Number", "HIP 29687"},
        {"Geneva Identification System", "GEN# +1.00043078"},
        {"Smithsonian Astrophysical Observation", "SAO 78145"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.81432061),
        dec: Angle.Degrees(+22.30113790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111462",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16081 A"},
        {"Henry Draper", "HD 213994"},
        {"Hipparcos Number", "HIP 111462"},
        {"Smithsonian Astrophysical Observation", "SAO 90615"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.74082645),
        dec: Angle.Degrees(+22.30135047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186343"},
        {"Hipparcos Number", "HIP 97019"},
        {"Geneva Identification System", "GEN# +1.00186343"},
        {"Renson", "Renson 51370"},
        {"Smithsonian Astrophysical Observation", "SAO 87617"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.76939330),
        dec: Angle.Degrees(+22.30218788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3384"},
        {"Hipparcos Number", "HIP 2915"},
        {"Smithsonian Astrophysical Observation", "SAO 74146"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.23270552),
        dec: Angle.Degrees(+22.30360409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158672"},
        {"Hipparcos Number", "HIP 85616"},
        {"Smithsonian Astrophysical Observation", "SAO 85149"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.43186422),
        dec: Angle.Degrees(+22.30495268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35255"},
        {"Hipparcos Number", "HIP 25274"},
        {"Smithsonian Astrophysical Observation", "SAO 77147"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.07993122),
        dec: Angle.Degrees(+22.30565834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46018"},
        {"Smithsonian Astrophysical Observation", "SAO 80794"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.77671645),
        dec: Angle.Degrees(+22.30611122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37203",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37203"},
        {"Smithsonian Astrophysical Observation", "SAO 79573"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.63614442),
        dec: Angle.Degrees(+22.30815651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49406"},
        {"Hipparcos Number", "HIP 32693"},
        {"Smithsonian Astrophysical Observation", "SAO 78774"},
        {"Wilson Evans Batten Catalogue", "WEB 6587"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.31390350),
        dec: Angle.Degrees(+22.31083769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116234"},
        {"Hipparcos Number", "HIP 65216"},
        {"Geneva Identification System", "GEN# +1.00116234"},
        {"Smithsonian Astrophysical Observation", "SAO 82798"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.48597250),
        dec: Angle.Degrees(+22.31091775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251177"},
        {"Hipparcos Number", "HIP 28806"},
        {"Geneva Identification System", "GEN# +1.00251177"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.22622011),
        dec: Angle.Degrees(+22.31287896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134963"},
        {"Hipparcos Number", "HIP 74385"},
        {"Geneva Identification System", "GEN# +1.00134963"},
        {"Smithsonian Astrophysical Observation", "SAO 83714"},
        {"Wilson Evans Batten Catalogue", "WEB 12696"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.01691648),
        dec: Angle.Degrees(+22.31349801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86368"},
        {"Hipparcos Number", "HIP 48900"},
        {"Geneva Identification System", "GEN# +1.00086368"},
        {"Smithsonian Astrophysical Observation", "SAO 81122"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.62685700),
        dec: Angle.Degrees(+22.31375552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82398"},
    },
    visualMagnitude: 11.26,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.54817879),
        dec: Angle.Degrees(+22.31478642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -367.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284764"},
        {"Hipparcos Number", "HIP 22355"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.18703923),
        dec: Angle.Degrees(+22.31521117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171314"},
        {"Hipparcos Number", "HIP 90959"},
        {"Cincinnati Publication", "Ci 18 2433"},
        {"Cincinnati Publication 2", "Ci 20 1093"},
        {"Geneva Identification System", "GEN# +1.00171314"},
        {"Smithsonian Astrophysical Observation", "SAO 86187"},
        {"Wilson Evans Batten Catalogue", "WEB 15600"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.32446321),
        dec: Angle.Degrees(+22.31540247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -473.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162570"},
        {"Hipparcos Number", "HIP 87341"},
        {"Geneva Identification System", "GEN# +1.00162570"},
        {"Smithsonian Astrophysical Observation", "SAO 85468"},
        {"Wilson Evans Batten Catalogue", "WEB 14736"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.70155128),
        dec: Angle.Degrees(+22.31638065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188235"},
        {"Hipparcos Number", "HIP 97883"},
        {"Smithsonian Astrophysical Observation", "SAO 87881"},
        {"Wilson Evans Batten Catalogue", "WEB 17222"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.35777895),
        dec: Angle.Degrees(+22.31675235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141972"},
        {"Hipparcos Number", "HIP 77640"},
        {"Geneva Identification System", "GEN# +1.00141972"},
        {"Smithsonian Astrophysical Observation", "SAO 84033"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.76932340),
        dec: Angle.Degrees(+22.31771420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7227"},
        {"Smithsonian Astrophysical Observation", "SAO 74784"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.28678105),
        dec: Angle.Degrees(+22.31876013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223650"},
        {"Hipparcos Number", "HIP 117634"},
        {"Smithsonian Astrophysical Observation", "SAO 91539"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.84417509),
        dec: Angle.Degrees(+22.32081787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140157"},
        {"Hipparcos Number", "HIP 76848"},
        {"Smithsonian Astrophysical Observation", "SAO 83944"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.37004934),
        dec: Angle.Degrees(+22.32423353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86907"},
        {"Smithsonian Astrophysical Observation", "SAO 85384"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.36611788),
        dec: Angle.Degrees(+22.32513427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284588"},
        {"Hipparcos Number", "HIP 21656"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.74548172),
        dec: Angle.Degrees(+22.32516581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199697"},
        {"Hipparcos Number", "HIP 103511"},
        {"Fundamental Katalog 5th Edition", "FK5 1549"},
        {"Geneva Identification System", "GEN# +1.00199697"},
        {"Smithsonian Astrophysical Observation", "SAO 89332"},
        {"Wilson Evans Batten Catalogue", "WEB 18828"},
    },
    visualMagnitude: 5.30,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.56813667),
        dec: Angle.Degrees(+22.32591754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116958"},
        {"Hipparcos Number", "HIP 65579"},
        {"Smithsonian Astrophysical Observation", "SAO 82838"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.67430261),
        dec: Angle.Degrees(+22.32597731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221626"},
        {"Hipparcos Number", "HIP 116282"},
        {"Geneva Identification System", "GEN# +1.00221626"},
        {"Smithsonian Astrophysical Observation", "SAO 91343"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.40275354),
        dec: Angle.Degrees(+22.32897675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20859",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3235 AB"},
        {"Henry Draper", "HD 28249"},
        {"Hipparcos Number", "HIP 20859"},
        {"Smithsonian Astrophysical Observation", "SAO 76620"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.05064434),
        dec: Angle.Degrees(+22.33279794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15733"},
        {"Hipparcos Number", "HIP 11814"},
        {"Geneva Identification System", "GEN# +1.00015733"},
        {"Smithsonian Astrophysical Observation", "SAO 75430"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.09574168),
        dec: Angle.Degrees(+22.33407733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64092"},
        {"Hipparcos Number", "HIP 38495"},
        {"Smithsonian Astrophysical Observation", "SAO 79768"},
        {"Wilson Evans Batten Catalogue", "WEB 7565"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.25421349),
        dec: Angle.Degrees(+22.33453707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5585"},
        {"Smithsonian Astrophysical Observation", "SAO 74547"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.91095104),
        dec: Angle.Degrees(+22.33562180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36853"},
    },
    visualMagnitude: 11.53,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.66250460),
        dec: Angle.Degrees(+22.33786439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140629"},
        {"Hipparcos Number", "HIP 77045"},
        {"Smithsonian Astrophysical Observation", "SAO 83970"},
        {"Wilson Evans Batten Catalogue", "WEB 13066"},
        {"Wilson Evans Batten Catalogue 2", "WEB 13068"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.99141413),
        dec: Angle.Degrees(+22.33978877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46372"},
        {"Hipparcos Number", "HIP 31308"},
        {"Smithsonian Astrophysical Observation", "SAO 78503"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.48897908),
        dec: Angle.Degrees(+22.34014835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60914"},
        {"Hipparcos Number", "HIP 37121"},
        {"Geneva Identification System", "GEN# +1.00060914"},
        {"Smithsonian Astrophysical Observation", "SAO 79558"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.41732612),
        dec: Angle.Degrees(+22.34016135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84555"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.27143310),
        dec: Angle.Degrees(+22.34258594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284667"},
        {"Hipparcos Number", "HIP 22222"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.69104922),
        dec: Angle.Degrees(+22.34315687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193988"},
        {"Hipparcos Number", "HIP 100472"},
        {"Smithsonian Astrophysical Observation", "SAO 88593"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.62665999),
        dec: Angle.Degrees(+22.34421556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9109"},
        {"Hipparcos Number", "HIP 7001"},
        {"Smithsonian Astrophysical Observation", "SAO 74760"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.52839703),
        dec: Angle.Degrees(+22.34829580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49222"},
        {"Hipparcos Number", "HIP 32620"},
        {"Smithsonian Astrophysical Observation", "SAO 78759"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.08767238),
        dec: Angle.Degrees(+22.35000089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199838"},
        {"Hipparcos Number", "HIP 103568"},
        {"Smithsonian Astrophysical Observation", "SAO 89347"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.76476249),
        dec: Angle.Degrees(+22.35041843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94720"},
        {"Hipparcos Number", "HIP 53472"},
        {"Fundamental Katalog 5th Edition", "FK5 2873"},
        {"Geneva Identification System", "GEN# +1.00094720"},
        {"Smithsonian Astrophysical Observation", "SAO 81589"},
        {"Wilson Evans Batten Catalogue", "WEB 9705"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.07031513),
        dec: Angle.Degrees(+22.35166259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284248"},
        {"Hipparcos Number", "HIP 19797"},
        {"Cincinnati Publication", "Ci 20 287"},
        {"Geneva Identification System", "GEN# +1.00284248"},
        {"Geneva Identification System 2", "GEN# +0.02100607"},
        {"Smithsonian Astrophysical Observation", "SAO 76518"},
        {"Wilson Evans Batten Catalogue", "WEB 3781"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.64686180),
        dec: Angle.Degrees(+22.35191638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 425.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -301.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74740"},
        {"Hipparcos Number", "HIP 43078"},
        {"Smithsonian Astrophysical Observation", "SAO 80414"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.62052626),
        dec: Angle.Degrees(+22.35220066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160135"},
        {"Hipparcos Number", "HIP 86245"},
        {"Smithsonian Astrophysical Observation", "SAO 85260"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.36186564),
        dec: Angle.Degrees(+22.35317882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27129"},
        {"Hipparcos Number", "HIP 20038"},
        {"Geneva Identification System", "GEN# +1.00027129"},
        {"Smithsonian Astrophysical Observation", "SAO 76536"},
        {"Wilson Evans Batten Catalogue", "WEB 3824"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.46363598),
        dec: Angle.Degrees(+22.35410201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39223"},
        {"Smithsonian Astrophysical Observation", "SAO 79867"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.34326608),
        dec: Angle.Degrees(+22.35836833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114978"},
        {"Smithsonian Astrophysical Observation", "SAO 91144"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.31319210),
        dec: Angle.Degrees(+22.36168588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33465"},
        {"Hipparcos Number", "HIP 24163"},
        {"Geneva Identification System", "GEN# +1.00033465"},
        {"Smithsonian Astrophysical Observation", "SAO 77024"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.83367339),
        dec: Angle.Degrees(+22.36272398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103441"},
        {"Cincinnati Publication", "Ci 20 1248"},
    },
    visualMagnitude: 11.98,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.35362622),
        dec: Angle.Degrees(+22.36324373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 773.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -211.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54427"},
        {"Hipparcos Number", "HIP 34583"},
        {"Smithsonian Astrophysical Observation", "SAO 79126"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.43501202),
        dec: Angle.Degrees(+22.36462422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146298"},
        {"Hipparcos Number", "HIP 79620"},
        {"Smithsonian Astrophysical Observation", "SAO 84260"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.72029387),
        dec: Angle.Degrees(+22.36636684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224369"},
        {"Hipparcos Number", "HIP 118094"},
        {"Geneva Identification System", "GEN# +1.00224369"},
        {"Smithsonian Astrophysical Observation", "SAO 91604"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.33373884),
        dec: Angle.Degrees(+22.36811103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1480"},
        {"Hipparcos Number", "HIP 1530"},
        {"Smithsonian Astrophysical Observation", "SAO 73885"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.76375244),
        dec: Angle.Degrees(+22.36870452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80350",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80350"},
        {"Smithsonian Astrophysical Observation", "SAO 84353"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.04280502),
        dec: Angle.Degrees(+22.36973815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14211"},
        {"Geneva Identification System", "GEN# +6.20030411"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.80701078),
        dec: Angle.Degrees(+22.36973896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56962"},
        {"Geneva Identification System", "GEN# +0.02302373"},
        {"Smithsonian Astrophysical Observation", "SAO 81939"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.15975891),
        dec: Angle.Degrees(+22.37144455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18831"},
        {"Hipparcos Number", "HIP 14152"},
        {"Geneva Identification System", "GEN# +1.00018831"},
        {"Smithsonian Astrophysical Observation", "SAO 75699"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.61393624),
        dec: Angle.Degrees(+22.37357797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8151"},
        {"Hipparcos Number", "HIP 6327"},
        {"Geneva Identification System", "GEN# +1.00008151"},
        {"Smithsonian Astrophysical Observation", "SAO 74651"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.31238418),
        dec: Angle.Degrees(+22.37467280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124347"},
        {"Hipparcos Number", "HIP 69407"},
        {"Geneva Identification System", "GEN# +1.00124347"},
        {"Smithsonian Astrophysical Observation", "SAO 83220"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.15681701),
        dec: Angle.Degrees(+22.37510396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1832"},
        {"Hipparcos Number", "HIP 1813"},
        {"Cincinnati Publication", "Ci 18 38"},
        {"Geneva Identification System", "GEN# +1.00001832"},
        {"Smithsonian Astrophysical Observation", "SAO 73940"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.75033827),
        dec: Angle.Degrees(+22.37553791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102014"},
        {"Hipparcos Number", "HIP 57262"},
        {"Geneva Identification System", "GEN# +1.00102014"},
        {"Smithsonian Astrophysical Observation", "SAO 81964"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.14542401),
        dec: Angle.Degrees(+22.37779672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203050"},
        {"Hipparcos Number", "HIP 105255"},
        {"Smithsonian Astrophysical Observation", "SAO 89614"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.80222760),
        dec: Angle.Degrees(+22.37788763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68352"},
        {"Hipparcos Number", "HIP 40216"},
        {"Geneva Identification System", "GEN# +1.00068352"},
        {"Smithsonian Astrophysical Observation", "SAO 80015"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.20521939),
        dec: Angle.Degrees(+22.37984133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172200"},
        {"Hipparcos Number", "HIP 91357"},
        {"Geneva Identification System", "GEN# +1.00172200"},
        {"Smithsonian Astrophysical Observation", "SAO 86262"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.48919511),
        dec: Angle.Degrees(+22.38118452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148052"},
        {"Hipparcos Number", "HIP 80406"},
        {"Geneva Identification System", "GEN# +1.00148052"},
        {"Smithsonian Astrophysical Observation", "SAO 84360"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.18847449),
        dec: Angle.Degrees(+22.38298429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179370"},
        {"Hipparcos Number", "HIP 94287"},
        {"Smithsonian Astrophysical Observation", "SAO 86909"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.87009864),
        dec: Angle.Degrees(+22.38315088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151045"},
        {"Hipparcos Number", "HIP 81925"},
        {"Smithsonian Astrophysical Observation", "SAO 84570"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.00439287),
        dec: Angle.Degrees(+22.38429161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211515"},
        {"Hipparcos Number", "HIP 110032"},
        {"Smithsonian Astrophysical Observation", "SAO 90388"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.29366012),
        dec: Angle.Degrees(+22.38749539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202798"},
        {"Hipparcos Number", "HIP 105129"},
        {"Geneva Identification System", "GEN# +1.00202798"},
        {"Smithsonian Astrophysical Observation", "SAO 89592"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.43668772),
        dec: Angle.Degrees(+22.38829523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56627"},
        {"Geneva Identification System", "GEN# +0.02302365"},
        {"Smithsonian Astrophysical Observation", "SAO 81898"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.16423970),
        dec: Angle.Degrees(+22.38893798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215012"},
        {"Hipparcos Number", "HIP 112058"},
        {"Smithsonian Astrophysical Observation", "SAO 90718"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.45663035),
        dec: Angle.Degrees(+22.38932301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217511"},
        {"Hipparcos Number", "HIP 113651"},
        {"Fundamental Katalog 5th Edition", "FK5 6039"},
        {"Geneva Identification System", "GEN# +1.00217511"},
        {"Smithsonian Astrophysical Observation", "SAO 90944"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.25862366),
        dec: Angle.Degrees(+22.39117394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198346"},
        {"Hipparcos Number", "HIP 102736"},
        {"Geneva Identification System", "GEN# +1.00198346"},
        {"Smithsonian Astrophysical Observation", "SAO 89162"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.26394023),
        dec: Angle.Degrees(+22.39119939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83580",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83580"},
        {"Smithsonian Astrophysical Observation", "SAO 84811"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.23312514),
        dec: Angle.Degrees(+22.39233646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192871"},
        {"Hipparcos Number", "HIP 99923"},
        {"Geneva Identification System", "GEN# +1.00192871"},
        {"Smithsonian Astrophysical Observation", "SAO 88437"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.10682980),
        dec: Angle.Degrees(+22.39649209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166027"},
        {"Hipparcos Number", "HIP 88826"},
        {"Smithsonian Astrophysical Observation", "SAO 85754"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.97971513),
        dec: Angle.Degrees(+22.39812757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 342924"},
        {"Hipparcos Number", "HIP 91917"},
        {"Smithsonian Astrophysical Observation", "SAO 86383"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.07765950),
        dec: Angle.Degrees(+22.39814921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130583"},
        {"Hipparcos Number", "HIP 72418"},
        {"Smithsonian Astrophysical Observation", "SAO 83534"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.10608421),
        dec: Angle.Degrees(+22.39873935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10019"},
        {"Smithsonian Astrophysical Observation", "SAO 75164"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.25614312),
        dec: Angle.Degrees(+22.39924649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62141"},
        {"Hipparcos Number", "HIP 37636"},
        {"Geneva Identification System", "GEN# +1.00062141"},
        {"Smithsonian Astrophysical Observation", "SAO 79641"},
        {"Wilson Evans Batten Catalogue", "WEB 7442"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.84247968),
        dec: Angle.Degrees(+22.39943231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2365"},
        {"Smithsonian Astrophysical Observation", "SAO 74043"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.54877006),
        dec: Angle.Degrees(+22.40029589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40724"},
        {"Hipparcos Number", "HIP 28561"},
        {"Geneva Identification System", "GEN# +1.00040724"},
        {"Smithsonian Astrophysical Observation", "SAO 77858"},
        {"Wilson Evans Batten Catalogue", "WEB 5581"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.42345796),
        dec: Angle.Degrees(+22.40104371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 342264"},
        {"Hipparcos Number", "HIP 90482"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.94019288),
        dec: Angle.Degrees(+22.40148646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11014"},
        {"Hipparcos Number", "HIP 8418"},
        {"Geneva Identification System", "GEN# +1.00011014"},
        {"Smithsonian Astrophysical Observation", "SAO 74945"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.15221036),
        dec: Angle.Degrees(+22.40172765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78066"},
        {"Hipparcos Number", "HIP 44731"},
        {"Smithsonian Astrophysical Observation", "SAO 80635"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.72500239),
        dec: Angle.Degrees(+22.40192882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216633"},
        {"Hipparcos Number", "HIP 113097"},
        {"Smithsonian Astrophysical Observation", "SAO 90865"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.56183186),
        dec: Angle.Degrees(+22.40196487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7893"},
        {"Hipparcos Number", "HIP 6152"},
        {"Smithsonian Astrophysical Observation", "SAO 74631"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.73697095),
        dec: Angle.Degrees(+22.40940765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35545"},
        {"Smithsonian Astrophysical Observation", "SAO 79293"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.02591424),
        dec: Angle.Degrees(+22.41049554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41891"},
        {"Geneva Identification System", "GEN# +0.02201950"},
        {"Smithsonian Astrophysical Observation", "SAO 80239"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.13545551),
        dec: Angle.Degrees(+22.41123356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 342500"},
        {"Hipparcos Number", "HIP 90846"},
        {"Smithsonian Astrophysical Observation", "SAO 86162"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.98805278),
        dec: Angle.Degrees(+22.41176718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2700"},
        {"Geneva Identification System", "GEN# +0.02100064"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.56758525),
        dec: Angle.Degrees(+22.41344155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26571"},
        {"Hipparcos Number", "HIP 19672"},
        {"Geneva Identification System", "GEN# +1.00026571"},
        {"Renson", "Renson 6780"},
        {"Smithsonian Astrophysical Observation", "SAO 76505"},
        {"Wilson Evans Batten Catalogue", "WEB 3755"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.21353012),
        dec: Angle.Degrees(+22.41348359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133598"},
        {"Hipparcos Number", "HIP 73770"},
        {"Smithsonian Astrophysical Observation", "SAO 83647"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.19378838),
        dec: Angle.Degrees(+22.41537142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141476"},
        {"Hipparcos Number", "HIP 77437"},
        {"Smithsonian Astrophysical Observation", "SAO 84011"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.12009387),
        dec: Angle.Degrees(+22.41555663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15562"},
    },
    visualMagnitude: 13.63,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.12050269),
        dec: Angle.Degrees(+22.41578055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14809",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2383 A"},
        {"Hipparcos Number", "HIP 14809"},
        {"Smithsonian Astrophysical Observation", "SAO 75775"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.80752876),
        dec: Angle.Degrees(+22.41616905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5665"},
        {"Hipparcos Number", "HIP 4574"},
        {"Smithsonian Astrophysical Observation", "SAO 74407"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.63964181),
        dec: Angle.Degrees(+22.41997717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78166"},
        {"Smithsonian Astrophysical Observation", "SAO 84097"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.41717034),
        dec: Angle.Degrees(+22.42071056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17317"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.60005036),
        dec: Angle.Degrees(+22.42124648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25322"},
        {"Hipparcos Number", "HIP 18833"},
        {"Geneva Identification System", "GEN# +1.00025322"},
        {"Smithsonian Astrophysical Observation", "SAO 76406"},
        {"Wilson Evans Batten Catalogue", "WEB 3626"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.56383364),
        dec: Angle.Degrees(+22.42243239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14807",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2383 B"},
        {"Hipparcos Number", "HIP 14807"},
    },
    visualMagnitude: 10.55,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.80124805),
        dec: Angle.Degrees(+22.42330730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268340"},
        {"Hipparcos Number", "HIP 33999"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.81346275),
        dec: Angle.Degrees(+22.42341784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180811"},
        {"Hipparcos Number", "HIP 94787"},
        {"Geneva Identification System", "GEN# +1.00180811"},
        {"Smithsonian Astrophysical Observation", "SAO 87027"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.29655826),
        dec: Angle.Degrees(+22.42608011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108862"},
        {"Hipparcos Number", "HIP 61023"},
        {"Geneva Identification System", "GEN# +1.00108862"},
        {"Smithsonian Astrophysical Observation", "SAO 82343"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.58806344),
        dec: Angle.Degrees(+22.42646987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207490"},
        {"Hipparcos Number", "HIP 107683"},
        {"Smithsonian Astrophysical Observation", "SAO 90020"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.19578764),
        dec: Angle.Degrees(+22.42802392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188507"},
        {"Hipparcos Number", "HIP 97979"},
        {"Geneva Identification System", "GEN# +1.00188507"},
        {"Smithsonian Astrophysical Observation", "SAO 87913"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.68485070),
        dec: Angle.Degrees(+22.42924620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165824"},
        {"Hipparcos Number", "HIP 88747"},
        {"Smithsonian Astrophysical Observation", "SAO 85741"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.75823817),
        dec: Angle.Degrees(+22.43097783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86165"},
        {"Smithsonian Astrophysical Observation", "SAO 85241"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.12262453),
        dec: Angle.Degrees(+22.43124801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14877"},
        {"Hipparcos Number", "HIP 11237"},
        {"Geneva Identification System", "GEN# +1.00014877"},
        {"Smithsonian Astrophysical Observation", "SAO 75344"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.16533648),
        dec: Angle.Degrees(+22.43384685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150600"},
        {"Hipparcos Number", "HIP 81697"},
        {"Smithsonian Astrophysical Observation", "SAO 84539"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.32939615),
        dec: Angle.Degrees(+22.43692348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160403"},
        {"Hipparcos Number", "HIP 86361"},
        {"Smithsonian Astrophysical Observation", "SAO 85277"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.70043463),
        dec: Angle.Degrees(+22.43705704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36836"},
        {"Hipparcos Number", "HIP 26240"},
        {"Smithsonian Astrophysical Observation", "SAO 77286"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.85788629),
        dec: Angle.Degrees(+22.43812725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189657"},
        {"Hipparcos Number", "HIP 98473"},
        {"Smithsonian Astrophysical Observation", "SAO 88047"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.08713611),
        dec: Angle.Degrees(+22.44005532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157925"},
        {"Hipparcos Number", "HIP 85261"},
        {"Smithsonian Astrophysical Observation", "SAO 85069"},
        {"Wilson Evans Batten Catalogue", "WEB 14395"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.33393618),
        dec: Angle.Degrees(+22.44122022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180939"},
        {"Hipparcos Number", "HIP 94822"},
        {"Smithsonian Astrophysical Observation", "SAO 87035"},
        {"Wilson Evans Batten Catalogue", "WEB 16548"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.41662798),
        dec: Angle.Degrees(+22.44123257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9881"},
        {"Hipparcos Number", "HIP 7520"},
        {"Smithsonian Astrophysical Observation", "SAO 74822"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.20852250),
        dec: Angle.Degrees(+22.44159526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41687"},
        {"Smithsonian Astrophysical Observation", "SAO 80211"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.47352407),
        dec: Angle.Degrees(+22.44232823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51132"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.68814544),
        dec: Angle.Degrees(+22.44405766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150047"},
        {"Hipparcos Number", "HIP 81411"},
        {"Smithsonian Astrophysical Observation", "SAO 84489"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.40694126),
        dec: Angle.Degrees(+22.44489216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138038"},
        {"Hipparcos Number", "HIP 75774"},
        {"Smithsonian Astrophysical Observation", "SAO 83843"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.19295230),
        dec: Angle.Degrees(+22.44558003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143370"},
        {"Hipparcos Number", "HIP 78302"},
        {"Geneva Identification System", "GEN# +1.00143370"},
        {"Smithsonian Astrophysical Observation", "SAO 84125"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.82879862),
        dec: Angle.Degrees(+22.44704867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8247"},
        {"Smithsonian Astrophysical Observation", "SAO 74919"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.54587687),
        dec: Angle.Degrees(+22.44871620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26737"},
        {"Hipparcos Number", "HIP 19789"},
        {"Celescope Catalog", "CEL 375"},
        {"Geneva Identification System", "GEN# +5.20250016"},
        {"Smithsonian Astrophysical Observation", "SAO 76515"},
        {"Wilson Evans Batten Catalogue", "WEB 3777"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.62650138),
        dec: Angle.Degrees(+22.45194749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186021"},
        {"Hipparcos Number", "HIP 96856"},
        {"Geneva Identification System", "GEN# +1.00186021"},
        {"Smithsonian Astrophysical Observation", "SAO 87569"},
        {"Wilson Evans Batten Catalogue", "WEB 17000"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.31103737),
        dec: Angle.Degrees(+22.45278133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104539",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14710 A"},
        {"Henry Draper", "HD 201671"},
        {"Hipparcos Number", "HIP 104539"},
        {"Geneva Identification System", "GEN# +1.00201671"},
        {"Renson", "Renson 56240"},
        {"Smithsonian Astrophysical Observation", "SAO 89505"},
        {"Wilson Evans Batten Catalogue", "WEB 19025"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.63358351),
        dec: Angle.Degrees(+22.45466435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164809"},
        {"Hipparcos Number", "HIP 88305"},
        {"Geneva Identification System", "GEN# +1.00164809"},
        {"Smithsonian Astrophysical Observation", "SAO 85662"},
        {"Wilson Evans Batten Catalogue", "WEB 14926"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.50202873),
        dec: Angle.Degrees(+22.45564951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78252"},
        {"Hipparcos Number", "HIP 44808"},
        {"Geneva Identification System", "GEN# +1.00078252"},
        {"Smithsonian Astrophysical Observation", "SAO 80651"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.97373840),
        dec: Angle.Degrees(+22.45641819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50130"},
        {"Geneva Identification System", "GEN# +0.02302195"},
        {"Wilson Evans Batten Catalogue", "WEB 9215"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.50750946),
        dec: Angle.Degrees(+22.45666143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66948"},
        {"Hipparcos Number", "HIP 39681"},
        {"Geneva Identification System", "GEN# +1.00066948"},
        {"Smithsonian Astrophysical Observation", "SAO 79948"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.64372708),
        dec: Angle.Degrees(+22.45685540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284661"},
        {"Hipparcos Number", "HIP 22056"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.15072251),
        dec: Angle.Degrees(+22.45691034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104536",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14710 B"},
        {"Henry Draper", "HD 201670"},
        {"Hipparcos Number", "HIP 104536"},
        {"Geneva Identification System", "GEN# +1.00201670"},
        {"Smithsonian Astrophysical Observation", "SAO 89504"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.62884393),
        dec: Angle.Degrees(+22.45713422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30574",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5042 AB"},
        {"Henry Draper", "HD 44941"},
        {"Hipparcos Number", "HIP 30574"},
        {"Smithsonian Astrophysical Observation", "SAO 78352"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.39248770),
        dec: Angle.Degrees(+22.45783549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36160"},
        {"Hipparcos Number", "HIP 25806"},
        {"Geneva Identification System", "GEN# +1.00036160"},
        {"Smithsonian Astrophysical Observation", "SAO 77220"},
        {"Wilson Evans Batten Catalogue", "WEB 5013"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.68050245),
        dec: Angle.Degrees(+22.46230458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123471"},
        {"Hipparcos Number", "HIP 68983"},
        {"Geneva Identification System", "GEN# +1.00123471"},
        {"Smithsonian Astrophysical Observation", "SAO 83177"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.84203394),
        dec: Angle.Degrees(+22.46249756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108880"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.83752738),
        dec: Angle.Degrees(+22.46275405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83525"},
        {"Smithsonian Astrophysical Observation", "SAO 84801"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.05081056),
        dec: Angle.Degrees(+22.46289070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107685"},
        {"Hipparcos Number", "HIP 60347"},
        {"Geneva Identification System", "GEN# +5.21110090"},
        {"Smithsonian Astrophysical Observation", "SAO 82272"},
        {"Wilson Evans Batten Catalogue", "WEB 10732"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.60318223),
        dec: Angle.Degrees(+22.46416514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163547"},
        {"Hipparcos Number", "HIP 87777"},
        {"Fundamental Katalog 5th Edition", "FK5 3427"},
        {"Geneva Identification System", "GEN# +1.00163547"},
        {"Smithsonian Astrophysical Observation", "SAO 85552"},
        {"Wilson Evans Batten Catalogue", "WEB 14812"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.96171591),
        dec: Angle.Degrees(+22.46422113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37230"},
        {"Hipparcos Number", "HIP 26484"},
        {"Smithsonian Astrophysical Observation", "SAO 77340"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.49359942),
        dec: Angle.Degrees(+22.46522631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5213"},
        {"Hipparcos Number", "HIP 4238"},
        {"Geneva Identification System", "GEN# +1.00005213"},
        {"Smithsonian Astrophysical Observation", "SAO 74350"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.52299038),
        dec: Angle.Degrees(+22.46557834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48310"},
        {"Hipparcos Number", "HIP 32234"},
        {"Smithsonian Astrophysical Observation", "SAO 78679"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.93854024),
        dec: Angle.Degrees(+22.46563613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12017"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.75224490),
        dec: Angle.Degrees(+22.46613445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111082",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15992 AB"},
        {"Henry Draper", "HD 213315"},
        {"Hipparcos Number", "HIP 111082"},
        {"Geneva Identification System", "GEN# +1.00213315J"},
        {"Smithsonian Astrophysical Observation", "SAO 90555"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.56047440),
        dec: Angle.Degrees(+22.46671294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44228",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7129 AB"},
        {"Henry Draper", "HD 77024"},
        {"Hipparcos Number", "HIP 44228"},
        {"Smithsonian Astrophysical Observation", "SAO 80570"},
        {"Wilson Evans Batten Catalogue", "WEB 8488"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.12493803),
        dec: Angle.Degrees(+22.46888071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186903"},
        {"Hipparcos Number", "HIP 97289"},
        {"Smithsonian Astrophysical Observation", "SAO 87694"},
        {"Wilson Evans Batten Catalogue", "WEB 17088"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.58120305),
        dec: Angle.Degrees(+22.46942695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218574"},
        {"Hipparcos Number", "HIP 114293"},
        {"Renson", "Renson 60180"},
        {"Smithsonian Astrophysical Observation", "SAO 91041"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.21619632),
        dec: Angle.Degrees(+22.47084255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122081"},
        {"Hipparcos Number", "HIP 68324"},
        {"Geneva Identification System", "GEN# +1.00122081"},
        {"Smithsonian Astrophysical Observation", "SAO 83110"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.79094812),
        dec: Angle.Degrees(+22.47171053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224070"},
        {"Hipparcos Number", "HIP 117897"},
        {"Smithsonian Astrophysical Observation", "SAO 91570"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.71329621),
        dec: Angle.Degrees(+22.47222735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106930"},
        {"Smithsonian Astrophysical Observation", "SAO 89877"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.83434963),
        dec: Angle.Degrees(+22.47382261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116093"},
        {"Hipparcos Number", "HIP 65150"},
        {"Smithsonian Astrophysical Observation", "SAO 82794"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.26487181),
        dec: Angle.Degrees(+22.47383330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115835",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115835"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.00439208),
        dec: Angle.Degrees(+22.47469457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51419"},
        {"Hipparcos Number", "HIP 33537"},
        {"Geneva Identification System", "GEN# +1.00051419"},
        {"Smithsonian Astrophysical Observation", "SAO 78921"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.54883196),
        dec: Angle.Degrees(+22.47564759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206618"},
        {"Hipparcos Number", "HIP 107196"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.68625711),
        dec: Angle.Degrees(+22.47627577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77608"},
        {"Smithsonian Astrophysical Observation", "SAO 84031"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.66293227),
        dec: Angle.Degrees(+22.47639059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83304"},
        {"Wilson Evans Batten Catalogue", "WEB 14079"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.37187065),
        dec: Angle.Degrees(+22.47747155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24740"},
        {"Hipparcos Number", "HIP 18471"},
        {"Fundamental Katalog 5th Edition", "FK5 2283"},
        {"Geneva Identification System", "GEN# +1.00024740"},
        {"Smithsonian Astrophysical Observation", "SAO 76339"},
        {"Wilson Evans Batten Catalogue", "WEB 3560"},
    },
    visualMagnitude: 5.62,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.21680322),
        dec: Angle.Degrees(+22.47825021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80828"},
        {"Smithsonian Astrophysical Observation", "SAO 84414"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.59637106),
        dec: Angle.Degrees(+22.48322642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137945"},
        {"Hipparcos Number", "HIP 75725"},
        {"Smithsonian Astrophysical Observation", "SAO 83836"},
        {"Wilson Evans Batten Catalogue", "WEB 12894"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.05484673),
        dec: Angle.Degrees(+22.48346416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139511"},
        {"Hipparcos Number", "HIP 76533"},
        {"Smithsonian Astrophysical Observation", "SAO 83916"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.45486909),
        dec: Angle.Degrees(+22.48371348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70956"},
        {"Hipparcos Number", "HIP 41291"},
        {"Smithsonian Astrophysical Observation", "SAO 80174"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.36907068),
        dec: Angle.Degrees(+22.48453597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139073"},
        {"Hipparcos Number", "HIP 76320"},
        {"Smithsonian Astrophysical Observation", "SAO 83897"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.83900516),
        dec: Angle.Degrees(+22.48755997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62366",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62366"},
        {"Smithsonian Astrophysical Observation", "SAO 82491"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.71672523),
        dec: Angle.Degrees(+22.48810822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -256.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222078"},
        {"Hipparcos Number", "HIP 116565"},
        {"Smithsonian Astrophysical Observation", "SAO 91385"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.33748604),
        dec: Angle.Degrees(+22.48946645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13903"},
        {"Hipparcos Number", "HIP 10563"},
        {"Geneva Identification System", "GEN# +1.00013903"},
        {"Smithsonian Astrophysical Observation", "SAO 75242"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.99050150),
        dec: Angle.Degrees(+22.49416266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186412"},
        {"Hipparcos Number", "HIP 97050"},
        {"Geneva Identification System", "GEN# +1.00186412"},
        {"Smithsonian Astrophysical Observation", "SAO 87627"},
        {"Wilson Evans Batten Catalogue", "WEB 17029"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.85434022),
        dec: Angle.Degrees(+22.49500125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122768"},
        {"Hipparcos Number", "HIP 68665"},
        {"Geneva Identification System", "GEN# +1.00122768"},
        {"Smithsonian Astrophysical Observation", "SAO 83145"},
        {"Wilson Evans Batten Catalogue", "WEB 12020"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.84165424),
        dec: Angle.Degrees(+22.49580195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119126"},
        {"Hipparcos Number", "HIP 66763"},
        {"Geneva Identification System", "GEN# +1.00119126"},
        {"Smithsonian Astrophysical Observation", "SAO 82946"},
        {"Wilson Evans Batten Catalogue", "WEB 11775"},
    },
    visualMagnitude: 5.63,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.25982195),
        dec: Angle.Degrees(+22.49583157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3491"},
        {"Hipparcos Number", "HIP 2989"},
        {"Smithsonian Astrophysical Observation", "SAO 74160"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.50304481),
        dec: Angle.Degrees(+22.49627308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343945"},
        {"Hipparcos Number", "HIP 94197"},
    },
    visualMagnitude: 11.77,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.65654759),
        dec: Angle.Degrees(+22.49790736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221615"},
        {"Hipparcos Number", "HIP 116264"},
        {"Fundamental Katalog 5th Edition", "FK5 3889"},
        {"Geneva Identification System", "GEN# +1.00221615"},
        {"Smithsonian Astrophysical Observation", "SAO 91340"},
        {"Wilson Evans Batten Catalogue", "WEB 20546"},
    },
    visualMagnitude: 5.33,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.36703214),
        dec: Angle.Degrees(+22.49881721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118244"},
        {"Hipparcos Number", "HIP 66290"},
        {"Geneva Identification System", "GEN# +1.00118244"},
        {"Smithsonian Astrophysical Observation", "SAO 82888"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.79822754),
        dec: Angle.Degrees(+22.49941820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 128.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16979"},
        {"Smithsonian Astrophysical Observation", "SAO 76039"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.59402326),
        dec: Angle.Degrees(+22.49978748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184849"},
        {"Hipparcos Number", "HIP 96373"},
        {"Geneva Identification System", "GEN# +1.00184849"},
        {"Smithsonian Astrophysical Observation", "SAO 87409"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.90744499),
        dec: Angle.Degrees(+22.50191224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66072"},
        {"Geneva Identification System", "GEN# +0.02302581"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.17406307),
        dec: Angle.Degrees(+22.50201918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67395"},
        {"Smithsonian Astrophysical Observation", "SAO 83006"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.18553788),
        dec: Angle.Degrees(+22.50385797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47507",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47507"},
        {"Geneva Identification System", "GEN# +0.02302134"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.28538447),
        dec: Angle.Degrees(+22.50465102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39048"},
        {"Hipparcos Number", "HIP 27627"},
        {"Smithsonian Astrophysical Observation", "SAO 77628"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.73736219),
        dec: Angle.Degrees(+22.50556682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16428"},
        {"Smithsonian Astrophysical Observation", "SAO 75976"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.87982931),
        dec: Angle.Degrees(+22.50582635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95197",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12355 AB"},
        {"Henry Draper", "HD 182032"},
        {"Hipparcos Number", "HIP 95197"},
        {"Geneva Identification System", "GEN# +1.00182032J"},
        {"Smithsonian Astrophysical Observation", "SAO 87120"},
        {"Wilson Evans Batten Catalogue", "WEB 16631"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.48858675),
        dec: Angle.Degrees(+22.50643646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89416"},
        {"Hipparcos Number", "HIP 50557"},
        {"Geneva Identification System", "GEN# +1.00089416"},
        {"Smithsonian Astrophysical Observation", "SAO 81291"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.91193190),
        dec: Angle.Degrees(+22.50664225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29655",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Propus"},
        {"Aitken", "ADS 4841 A"},
        {"Henry Draper", "HD 42995"},
        {"Henry Draper 2", "HD 42995A"},
        {"Hipparcos Number", "HIP 29655"},
        {"Geneva Identification System", "GEN# +1.00042995"},
        {"Smithsonian Astrophysical Observation", "SAO 78135"},
        {"Wilson Evans Batten Catalogue", "WEB 5839"},
    },
    visualMagnitude: 3.31,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.71956952),
        dec: Angle.Degrees(+22.50682376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42056"},
        {"Smithsonian Astrophysical Observation", "SAO 80257"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.58340549),
        dec: Angle.Degrees(+22.50810227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55562"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.71156000),
        dec: Angle.Degrees(+22.50953073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32811"},
        {"Hipparcos Number", "HIP 23784"},
        {"Smithsonian Astrophysical Observation", "SAO 76962"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.67052974),
        dec: Angle.Degrees(+22.51077311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27388"},
        {"Smithsonian Astrophysical Observation", "SAO 77572"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.00584002),
        dec: Angle.Degrees(+22.51080756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117528"},
        {"Hipparcos Number", "HIP 65899"},
        {"Smithsonian Astrophysical Observation", "SAO 82866"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.62820380),
        dec: Angle.Degrees(+22.51318681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30343",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tejat"},
        {"Aitken", "ADS 4990 A"},
        {"Henry Draper", "HD 44478"},
        {"Hipparcos Number", "HIP 30343"},
        {"Fundamental Katalog 5th Edition", "FK5 241"},
        {"Geneva Identification System", "GEN# +1.00044478"},
        {"Smithsonian Astrophysical Observation", "SAO 78297"},
        {"Wilson Evans Batten Catalogue", "WEB 6038"},
    },
    visualMagnitude: 2.87,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.73996302),
        dec: Angle.Degrees(+22.51385027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119901"},
        {"Hipparcos Number", "HIP 67156"},
        {"Smithsonian Astrophysical Observation", "SAO 82986"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.43232760),
        dec: Angle.Degrees(+22.51477034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 256847"},
        {"Hipparcos Number", "HIP 30571"},
        {"Smithsonian Astrophysical Observation", "SAO 78351"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.39105857),
        dec: Angle.Degrees(+22.51642467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66052"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.13001732),
        dec: Angle.Degrees(+22.51669281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39645"},
        {"Hipparcos Number", "HIP 27956"},
        {"Geneva Identification System", "GEN# +1.00039645"},
        {"Smithsonian Astrophysical Observation", "SAO 77710"},
        {"Wilson Evans Batten Catalogue", "WEB 5478"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.72500353),
        dec: Angle.Degrees(+22.51992455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47261"},
        {"Geneva Identification System", "GEN# +0.02302124"},
        {"Wilson Evans Batten Catalogue", "WEB 8885"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.49325152),
        dec: Angle.Degrees(+22.52341474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109843",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15771 A"},
        {"Henry Draper", "HD 211153"},
        {"Hipparcos Number", "HIP 109843"},
        {"Smithsonian Astrophysical Observation", "SAO 90349"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.70237715),
        dec: Angle.Degrees(+22.52344128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120065"},
        {"Hipparcos Number", "HIP 67242"},
        {"Geneva Identification System", "GEN# +1.00120065"},
        {"Smithsonian Astrophysical Observation", "SAO 82994"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.69926976),
        dec: Angle.Degrees(+22.52371623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103993"},
        {"Smithsonian Astrophysical Observation", "SAO 89426"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.04710291),
        dec: Angle.Degrees(+22.52451768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68714"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.00632547),
        dec: Angle.Degrees(+22.52585874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -314.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118670"},
        {"Hipparcos Number", "HIP 66511"},
        {"Geneva Identification System", "GEN# +1.00118670"},
        {"Smithsonian Astrophysical Observation", "SAO 82915"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.50419415),
        dec: Angle.Degrees(+22.52755034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38504"},
        {"Hipparcos Number", "HIP 27320"},
        {"Smithsonian Astrophysical Observation", "SAO 77556"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.81253791),
        dec: Angle.Degrees(+22.52903280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59160"},
        {"Geneva Identification System", "GEN# +6.91123002"},
    },
    visualMagnitude: 10.99,
    bvColour: -0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.99031003),
        dec: Angle.Degrees(+22.53110117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202712"},
        {"Hipparcos Number", "HIP 105071"},
        {"Geneva Identification System", "GEN# +1.00202712"},
        {"Smithsonian Astrophysical Observation", "SAO 89580"},
        {"Wilson Evans Batten Catalogue", "WEB 19086"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.27746502),
        dec: Angle.Degrees(+22.53124787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28216"},
    },
    visualMagnitude: 10.77,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.42663018),
        dec: Angle.Degrees(+22.53236405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23913"},
        {"Hipparcos Number", "HIP 17892"},
        {"Celescope Catalog", "CEL 361"},
        {"Geneva Identification System", "GEN# +5.20223323"},
        {"Smithsonian Astrophysical Observation", "SAO 76242"},
        {"Wilson Evans Batten Catalogue", "WEB 3444"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.40903653),
        dec: Angle.Degrees(+22.53359202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32408"},
        {"Hipparcos Number", "HIP 23561"},
        {"Smithsonian Astrophysical Observation", "SAO 76932"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.98780093),
        dec: Angle.Degrees(+22.53363100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182078"},
        {"Hipparcos Number", "HIP 95213"},
        {"Geneva Identification System", "GEN# +1.00182078"},
        {"Smithsonian Astrophysical Observation", "SAO 87124"},
        {"Wilson Evans Batten Catalogue", "WEB 16634"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.55158909),
        dec: Angle.Degrees(+22.53627769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167133"},
        {"Hipparcos Number", "HIP 89266"},
        {"Smithsonian Astrophysical Observation", "SAO 85829"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.23902012),
        dec: Angle.Degrees(+22.53699001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111109",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 57"},
        {"Hipparcos Number", "HIP 111109"},
        {"Geneva Identification System", "GEN# +0.02104772J"},
        {"Smithsonian Astrophysical Observation", "SAO 90559"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.63027493),
        dec: Angle.Degrees(+22.53736374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45954"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.58218204),
        dec: Angle.Degrees(+22.53785010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172245"},
        {"Hipparcos Number", "HIP 91382"},
        {"Smithsonian Astrophysical Observation", "SAO 86265"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.56884242),
        dec: Angle.Degrees(+22.53785274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347600"},
        {"Hipparcos Number", "HIP 102902"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.70143704),
        dec: Angle.Degrees(+22.53830186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147588"},
        {"Hipparcos Number", "HIP 80175"},
        {"Geneva Identification System", "GEN# +1.00147588"},
        {"Smithsonian Astrophysical Observation", "SAO 84329"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.49298269),
        dec: Angle.Degrees(+22.54007349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36101"},
        {"Hipparcos Number", "HIP 25779"},
        {"Smithsonian Astrophysical Observation", "SAO 77214"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.56414754),
        dec: Angle.Degrees(+22.54027629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202769"},
        {"Hipparcos Number", "HIP 105111"},
        {"Geneva Identification System", "GEN# +1.00202769"},
        {"Smithsonian Astrophysical Observation", "SAO 89584"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.38560830),
        dec: Angle.Degrees(+22.54172316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116496"},
        {"Hipparcos Number", "HIP 65353"},
        {"Smithsonian Astrophysical Observation", "SAO 82817"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.91371111),
        dec: Angle.Degrees(+22.54382991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62772"},
        {"Geneva Identification System", "GEN# +0.02302508"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.94670254),
        dec: Angle.Degrees(+22.54429535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76218"},
        {"Smithsonian Astrophysical Observation", "SAO 83888"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.54352774),
        dec: Angle.Degrees(+22.54465686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31000",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5129 A"},
        {"Henry Draper", "HD 45769"},
        {"Hipparcos Number", "HIP 31000"},
        {"Smithsonian Astrophysical Observation", "SAO 78445"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.59114186),
        dec: Angle.Degrees(+22.54493978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109360",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15673 AB"},
        {"Henry Draper", "HD 210342"},
        {"Hipparcos Number", "HIP 109360"},
        {"Smithsonian Astrophysical Observation", "SAO 90274"},
        {"Wilson Evans Batten Catalogue", "WEB 19652"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.34166818),
        dec: Angle.Degrees(+22.54623112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69412"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.17659701),
        dec: Angle.Degrees(+22.54678795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58560"},
        {"Smithsonian Astrophysical Observation", "SAO 82096"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.12008988),
        dec: Angle.Degrees(+22.54836877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 312.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74662",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9555 A"},
        {"Henry Draper", "HD 135633"},
        {"Hipparcos Number", "HIP 74662"},
        {"Geneva Identification System", "GEN# +1.00135633A"},
        {"Smithsonian Astrophysical Observation", "SAO 83732"},
        {"Wilson Evans Batten Catalogue", "WEB 12739"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.86368490),
        dec: Angle.Degrees(+22.54913703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110640",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15915 AB"},
        {"Hipparcos Number", "HIP 110640"},
        {"Geneva Identification System", "GEN# +0.02104747"},
        {"Smithsonian Astrophysical Observation", "SAO 90482"},
        {"Wilson Evans Batten Catalogue", "WEB 19826"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.19019395),
        dec: Angle.Degrees(+22.55129424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6498"},
        {"Hipparcos Number", "HIP 5182"},
        {"Smithsonian Astrophysical Observation", "SAO 74489"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.56477740),
        dec: Angle.Degrees(+22.55172026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116701"},
        {"Smithsonian Astrophysical Observation", "SAO 91401"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.73979725),
        dec: Angle.Degrees(+22.55237960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38910"},
        {"Hipparcos Number", "HIP 27550"},
        {"Smithsonian Astrophysical Observation", "SAO 77614"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.51101893),
        dec: Angle.Degrees(+22.55545974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36708"},
        {"Smithsonian Astrophysical Observation", "SAO 79494"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.26065138),
        dec: Angle.Degrees(+22.55619560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38492"},
        {"Geneva Identification System", "GEN# +0.02201802"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.24857913),
        dec: Angle.Degrees(+22.55653022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 784"},
        {"Hipparcos Number", "HIP 989"},
        {"Smithsonian Astrophysical Observation", "SAO 73809"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.06609863),
        dec: Angle.Degrees(+22.55671394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9956"},
        {"Hipparcos Number", "HIP 7583"},
        {"Geneva Identification System", "GEN# +1.00009956"},
        {"Smithsonian Astrophysical Observation", "SAO 74834"},
        {"Wilson Evans Batten Catalogue", "WEB 1622"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.41117090),
        dec: Angle.Degrees(+22.55713587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43595"},
        {"Geneva Identification System", "GEN# +9.80009031"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.18592051),
        dec: Angle.Degrees(+22.55894483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183440"},
        {"Hipparcos Number", "HIP 95775"},
        {"Smithsonian Astrophysical Observation", "SAO 87262"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.19573230),
        dec: Angle.Degrees(+22.56018815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50633"},
        {"Hipparcos Number", "HIP 33251"},
        {"Smithsonian Astrophysical Observation", "SAO 78861"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.76852359),
        dec: Angle.Degrees(+22.56033719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341736"},
        {"Hipparcos Number", "HIP 89260"},
        {"Smithsonian Astrophysical Observation", "SAO 85827"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.23127412),
        dec: Angle.Degrees(+22.56124695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31363"},
        {"Hipparcos Number", "HIP 22935"},
        {"Smithsonian Astrophysical Observation", "SAO 76846"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.02754384),
        dec: Angle.Degrees(+22.57668755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173526"},
        {"Hipparcos Number", "HIP 91988"},
        {"Geneva Identification System", "GEN# +1.00173526"},
        {"Smithsonian Astrophysical Observation", "SAO 86397"},
        {"Wilson Evans Batten Catalogue", "WEB 15847"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.23634987),
        dec: Angle.Degrees(+22.56222301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123628"},
        {"Hipparcos Number", "HIP 69069"},
        {"Geneva Identification System", "GEN# +1.00123628"},
        {"Smithsonian Astrophysical Observation", "SAO 83191"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.07435899),
        dec: Angle.Degrees(+22.56306932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44301"},
        {"Hipparcos Number", "HIP 30268"},
        {"Smithsonian Astrophysical Observation", "SAO 78277"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.50558711),
        dec: Angle.Degrees(+22.56434255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134063"},
        {"Hipparcos Number", "HIP 73991"},
        {"Geneva Identification System", "GEN# +1.00134063"},
        {"Smithsonian Astrophysical Observation", "SAO 83668"},
        {"Wilson Evans Batten Catalogue", "WEB 12636"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.81431964),
        dec: Angle.Degrees(+22.56445034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245009"},
        {"Hipparcos Number", "HIP 26187"},
        {"Smithsonian Astrophysical Observation", "SAO 77273"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.73331101),
        dec: Angle.Degrees(+22.56864019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13430"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.23940828),
        dec: Angle.Degrees(+22.56949157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87298"},
        {"Hipparcos Number", "HIP 49365"},
        {"Smithsonian Astrophysical Observation", "SAO 81168"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.15304143),
        dec: Angle.Degrees(+22.56960674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181410"},
        {"Hipparcos Number", "HIP 94969"},
        {"Smithsonian Astrophysical Observation", "SAO 87068"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.88287813),
        dec: Angle.Degrees(+22.57075982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138541"},
        {"Hipparcos Number", "HIP 76061"},
        {"Smithsonian Astrophysical Observation", "SAO 83869"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.01185560),
        dec: Angle.Degrees(+22.57115373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64767"},
        {"Hipparcos Number", "HIP 38785"},
        {"Cincinnati Publication", "Ci 18 942"},
        {"Smithsonian Astrophysical Observation", "SAO 79810"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.08198273),
        dec: Angle.Degrees(+22.57203611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208863"},
        {"Hipparcos Number", "HIP 108491"},
        {"Geneva Identification System", "GEN# +1.00208863"},
        {"Smithsonian Astrophysical Observation", "SAO 90146"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.67229792),
        dec: Angle.Degrees(+22.57223068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14531"},
        {"Smithsonian Astrophysical Observation", "SAO 75741"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.91117963),
        dec: Angle.Degrees(+22.57239623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197247"},
        {"Hipparcos Number", "HIP 102137"},
        {"Smithsonian Astrophysical Observation", "SAO 89018"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.45624866),
        dec: Angle.Degrees(+22.57255679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110687",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15924 A"},
        {"Henry Draper", "HD 212638"},
        {"Hipparcos Number", "HIP 110687"},
        {"Smithsonian Astrophysical Observation", "SAO 90494"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.37408336),
        dec: Angle.Degrees(+22.57417302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107935",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107935"},
        {"Geneva Identification System", "GEN# +0.02104633"},
        {"Wilson Evans Batten Catalogue", "WEB 19465"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.01160687),
        dec: Angle.Degrees(+22.57484671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52759",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7926 AB"},
        {"Henry Draper", "HD 93392"},
        {"Hipparcos Number", "HIP 52759"},
        {"Smithsonian Astrophysical Observation", "SAO 81520"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.82062845),
        dec: Angle.Degrees(+22.57555890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6848"},
        {"Hipparcos Number", "HIP 5431"},
        {"Fundamental Katalog 5th Edition", "FK5 4105"},
        {"Smithsonian Astrophysical Observation", "SAO 74522"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.35030488),
        dec: Angle.Degrees(+22.57754758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48451"},
        {"Hipparcos Number", "HIP 32285"},
        {"Smithsonian Astrophysical Observation", "SAO 78689"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.10272678),
        dec: Angle.Degrees(+22.57914449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28355",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28355"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.87124746),
        dec: Angle.Degrees(+22.58078173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93881",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12053 B"},
        {"Hipparcos Number", "HIP 93881"},
        {"Geneva Identification System", "GEN# +1.00178277B"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.78228591),
        dec: Angle.Degrees(+22.58165386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80969"},
        {"Smithsonian Astrophysical Observation", "SAO 84433"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.00894003),
        dec: Angle.Degrees(+22.58227198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93885",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12053 A"},
        {"Henry Draper", "HD 178277"},
        {"Hipparcos Number", "HIP 93885"},
        {"Geneva Identification System", "GEN# +1.00178277A"},
        {"Smithsonian Astrophysical Observation", "SAO 86828"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.78336508),
        dec: Angle.Degrees(+22.58429868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199398"},
        {"Hipparcos Number", "HIP 103345"},
        {"Smithsonian Astrophysical Observation", "SAO 89301"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.05641346),
        dec: Angle.Degrees(+22.58476422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35616"},
        {"Smithsonian Astrophysical Observation", "SAO 79306"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.24312050),
        dec: Angle.Degrees(+22.58544513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184961"},
        {"Hipparcos Number", "HIP 96417"},
        {"Fundamental Katalog 5th Edition", "FK5 3564"},
        {"Geneva Identification System", "GEN# +1.00184961"},
        {"Renson", "Renson 51030"},
        {"Smithsonian Astrophysical Observation", "SAO 87426"},
        {"Wilson Evans Batten Catalogue", "WEB 16916"},
    },
    visualMagnitude: 6.33,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.03479104),
        dec: Angle.Degrees(+22.58578091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252705"},
        {"Hipparcos Number", "HIP 29296"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.64486511),
        dec: Angle.Degrees(+22.58585346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82404"},
        {"Smithsonian Astrophysical Observation", "SAO 84634"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.58778292),
        dec: Angle.Degrees(+22.58634016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78668"},
        {"Smithsonian Astrophysical Observation", "SAO 84173"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.89813975),
        dec: Angle.Degrees(+22.58683719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23965"},
        {"Hipparcos Number", "HIP 17928"},
        {"Geneva Identification System", "GEN# +1.00023965"},
        {"Smithsonian Astrophysical Observation", "SAO 76254"},
        {"Wilson Evans Batten Catalogue", "WEB 3452"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.51401484),
        dec: Angle.Degrees(+22.59178984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31856"},
        {"Hipparcos Number", "HIP 23247"},
        {"Smithsonian Astrophysical Observation", "SAO 76882"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.04096785),
        dec: Angle.Degrees(+22.59277505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105910"},
        {"Hipparcos Number", "HIP 59421"},
        {"Geneva Identification System", "GEN# +1.00105910"},
        {"Smithsonian Astrophysical Observation", "SAO 82173"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.84083201),
        dec: Angle.Degrees(+22.59364933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5674"},
        {"Hipparcos Number", "HIP 4579"},
        {"Smithsonian Astrophysical Observation", "SAO 74410"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.65904039),
        dec: Angle.Degrees(+22.59546896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95559"},
        {"Hipparcos Number", "HIP 53923"},
        {"Smithsonian Astrophysical Observation", "SAO 81634"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.50982062),
        dec: Angle.Degrees(+22.59595973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13111"},
        {"Geneva Identification System", "GEN# +0.02200396"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.15580363),
        dec: Angle.Degrees(+22.59930911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -358.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344635"},
        {"Hipparcos Number", "HIP 96447"},
        {"Geneva Identification System", "GEN# +1.00344635"},
        {"Smithsonian Astrophysical Observation", "SAO 87444"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.12997276),
        dec: Angle.Degrees(+22.60047919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17284"},
        {"Hipparcos Number", "HIP 12998"},
        {"Geneva Identification System", "GEN# +1.00017284"},
        {"Smithsonian Astrophysical Observation", "SAO 75569"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.78399893),
        dec: Angle.Degrees(+22.60391466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47396"},
        {"Hipparcos Number", "HIP 31829"},
        {"Wilson Evans Batten Catalogue", "WEB 6396"},
    },
    visualMagnitude: 10.33,
    bvColour: 2.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.82410712),
        dec: Angle.Degrees(+22.60510378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166869"},
        {"Hipparcos Number", "HIP 89154"},
        {"Smithsonian Astrophysical Observation", "SAO 85812"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.93099194),
        dec: Angle.Degrees(+22.60827943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345214"},
        {"Hipparcos Number", "HIP 97905"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.44162174),
        dec: Angle.Degrees(+22.60946203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84879"},
        {"Hipparcos Number", "HIP 48144"},
        {"Smithsonian Astrophysical Observation", "SAO 81025"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.21935799),
        dec: Angle.Degrees(+22.60948946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187811"},
        {"Hipparcos Number", "HIP 97679"},
        {"Fundamental Katalog 5th Edition", "FK5 3585"},
        {"Geneva Identification System", "GEN# +1.00187811"},
        {"Smithsonian Astrophysical Observation", "SAO 87813"},
        {"Wilson Evans Batten Catalogue", "WEB 17181"},
    },
    visualMagnitude: 4.90,
    bvColour: -0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.76705681),
        dec: Angle.Degrees(+22.61008676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77468"},
        {"Hipparcos Number", "HIP 44456"},
        {"Geneva Identification System", "GEN# +1.00077468"},
        {"Smithsonian Astrophysical Observation", "SAO 80602"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.85149004),
        dec: Angle.Degrees(+22.61133183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86756",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10743 AB"},
        {"Henry Draper", "HD 161258"},
        {"Hipparcos Number", "HIP 86756"},
        {"Smithsonian Astrophysical Observation", "SAO 85363"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.91153825),
        dec: Angle.Degrees(+22.61202252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3599"},
        {"Smithsonian Astrophysical Observation", "SAO 74256"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.52663784),
        dec: Angle.Degrees(+22.61562707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31916"},
        {"Hipparcos Number", "HIP 23284"},
        {"Geneva Identification System", "GEN# +1.00031916"},
        {"Smithsonian Astrophysical Observation", "SAO 76888"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.13974459),
        dec: Angle.Degrees(+22.61574854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113866"},
        {"Hipparcos Number", "HIP 63950"},
        {"Geneva Identification System", "GEN# +1.00113866"},
        {"Smithsonian Astrophysical Observation", "SAO 82651"},
        {"Wilson Evans Batten Catalogue", "WEB 11304"},
    },
    visualMagnitude: 5.53,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.59410061),
        dec: Angle.Degrees(+22.61629063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111154"},
        {"Hipparcos Number", "HIP 62384"},
        {"Geneva Identification System", "GEN# +1.00111154"},
        {"Smithsonian Astrophysical Observation", "SAO 82493"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.77807647),
        dec: Angle.Degrees(+22.61684990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85516"},
        {"Hipparcos Number", "HIP 48462"},
        {"Smithsonian Astrophysical Observation", "SAO 81065"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.21429355),
        dec: Angle.Degrees(+22.62017645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119287"},
        {"Hipparcos Number", "HIP 66856"},
        {"Geneva Identification System", "GEN# +1.00119287"},
        {"Smithsonian Astrophysical Observation", "SAO 82952"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.52224543),
        dec: Angle.Degrees(+22.62023068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346009"},
        {"Hipparcos Number", "HIP 99434"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.73417179),
        dec: Angle.Degrees(+22.62184579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4030",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 701 AB"},
        {"Henry Draper", "HD 4934"},
        {"Hipparcos Number", "HIP 4030"},
        {"Smithsonian Astrophysical Observation", "SAO 74322"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.90410784),
        dec: Angle.Degrees(+22.62343661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104782",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104782"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.40524900),
        dec: Angle.Degrees(+22.62618218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12355"},
        {"Hipparcos Number", "HIP 9454"},
        {"Smithsonian Astrophysical Observation", "SAO 75095"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.40003238),
        dec: Angle.Degrees(+22.62835311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13801"},
        {"Hipparcos Number", "HIP 10468"},
        {"Geneva Identification System", "GEN# +1.00013801"},
        {"Smithsonian Astrophysical Observation", "SAO 75228"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.73815627),
        dec: Angle.Degrees(+22.62896891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109485"},
        {"Hipparcos Number", "HIP 61394"},
        {"Fundamental Katalog 5th Edition", "FK5 1323"},
        {"Geneva Identification System", "GEN# +1.00109485"},
        {"Renson", "Renson 31747"},
        {"Smithsonian Astrophysical Observation", "SAO 82390"},
        {"Wilson Evans Batten Catalogue", "WEB 10928"},
    },
    visualMagnitude: 4.80,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.71299083),
        dec: Angle.Degrees(+22.62918961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153834"},
        {"Hipparcos Number", "HIP 83254"},
        {"Geneva Identification System", "GEN# +1.00153834"},
        {"Smithsonian Astrophysical Observation", "SAO 84758"},
        {"Wilson Evans Batten Catalogue", "WEB 14071"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.24225416),
        dec: Angle.Degrees(+22.63215190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81360"},
        {"Hipparcos Number", "HIP 46240"},
        {"Smithsonian Astrophysical Observation", "SAO 80823"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.40914514),
        dec: Angle.Degrees(+22.63225353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66875"},
        {"Hipparcos Number", "HIP 39659"},
        {"Geneva Identification System", "GEN# +1.00066875"},
        {"Smithsonian Astrophysical Observation", "SAO 79940"},
        {"Wilson Evans Batten Catalogue", "WEB 7745"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.57666469),
        dec: Angle.Degrees(+22.63551163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209708"},
        {"Hipparcos Number", "HIP 109004"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.24483791),
        dec: Angle.Degrees(+22.63691792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252866"},
        {"Hipparcos Number", "HIP 29342"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.80335075),
        dec: Angle.Degrees(+22.63734121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53257"},
        {"Hipparcos Number", "HIP 34182"},
        {"Geneva Identification System", "GEN# +1.00053257"},
        {"Smithsonian Astrophysical Observation", "SAO 79042"},
        {"Wilson Evans Batten Catalogue", "WEB 6846"},
    },
    visualMagnitude: 6.00,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.32654307),
        dec: Angle.Degrees(+22.63748109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113365"},
        {"Hipparcos Number", "HIP 63677"},
        {"Fundamental Katalog 5th Edition", "FK5 5152"},
        {"Geneva Identification System", "GEN# +1.00113365"},
        {"Smithsonian Astrophysical Observation", "SAO 82622"},
        {"Wilson Evans Batten Catalogue", "WEB 11266"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.74782527),
        dec: Angle.Degrees(+22.63758861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105680"},
        {"Hipparcos Number", "HIP 59303"},
        {"Geneva Identification System", "GEN# +1.00105680"},
        {"Renson", "Renson 30570"},
        {"Smithsonian Astrophysical Observation", "SAO 82158"},
        {"Wilson Evans Batten Catalogue", "WEB 10549"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.49772072),
        dec: Angle.Degrees(+22.63960068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10503"},
        {"Smithsonian Astrophysical Observation", "SAO 75233"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.84869679),
        dec: Angle.Degrees(+22.63963850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80003"},
        {"Cincinnati Publication", "Ci 20 982"},
        {"Geneva Identification System", "GEN# +9.80168042"},
        {"Wilson Evans Batten Catalogue", "WEB 13545"},
    },
    visualMagnitude: 11.52,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.96534278),
        dec: Angle.Degrees(+22.64006127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -451.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115557"},
        {"Hipparcos Number", "HIP 64848"},
        {"Smithsonian Astrophysical Observation", "SAO 82759"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.39275493),
        dec: Angle.Degrees(+22.64175927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
