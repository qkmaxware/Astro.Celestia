using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_34() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223098"},
        {"Hipparcos Number", "HIP 117270"},
        {"Smithsonian Astrophysical Observation", "SAO 214765"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.68610489),
        dec: Angle.Degrees(-32.00086344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143790"},
        {"Hipparcos Number", "HIP 78665"},
        {"Geneva Identification System", "GEN# +1.00143790"},
        {"Smithsonian Astrophysical Observation", "SAO 207282"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.89326968),
        dec: Angle.Degrees(-32.00046745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70363"},
        {"Hipparcos Number", "HIP 40865"},
        {"Smithsonian Astrophysical Observation", "SAO 199098"},
    },
    visualMagnitude: 8.77,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.08564686),
        dec: Angle.Degrees(-32.00017528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99240"},
        {"Hipparcos Number", "HIP 55714"},
        {"Geneva Identification System", "GEN# +1.00099240"},
        {"Smithsonian Astrophysical Observation", "SAO 202425"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.24532879),
        dec: Angle.Degrees(-31.99931739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225283"},
        {"Hipparcos Number", "HIP 396"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.22460634),
        dec: Angle.Degrees(-31.99660262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37963"},
        {"Hipparcos Number", "HIP 26739"},
        {"Smithsonian Astrophysical Observation", "SAO 196076"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.22674872),
        dec: Angle.Degrees(-31.99642439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204453"},
        {"Hipparcos Number", "HIP 106094"},
        {"Smithsonian Astrophysical Observation", "SAO 213038"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.36421182),
        dec: Angle.Degrees(-31.99440693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 319280"},
        {"Hipparcos Number", "HIP 89985"},
        {"Smithsonian Astrophysical Observation", "SAO 210036"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.39461068),
        dec: Angle.Degrees(-31.99440035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71690"},
        {"Hipparcos Number", "HIP 41485"},
        {"Smithsonian Astrophysical Observation", "SAO 199251"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.90721192),
        dec: Angle.Degrees(-31.99355947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202983"},
        {"Hipparcos Number", "HIP 105340"},
        {"Geneva Identification System", "GEN# +1.00202983"},
        {"Smithsonian Astrophysical Observation", "SAO 212914"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.05554812),
        dec: Angle.Degrees(-31.99288228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69163"},
    },
    visualMagnitude: 11.81,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.36453112),
        dec: Angle.Degrees(-30.92977310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -458.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174805"},
        {"Hipparcos Number", "HIP 92723"},
        {"Smithsonian Astrophysical Observation", "SAO 210686"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.42064538),
        dec: Angle.Degrees(-31.99196347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18209"},
        {"Hipparcos Number", "HIP 13546"},
        {"Smithsonian Astrophysical Observation", "SAO 193973"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.61462566),
        dec: Angle.Degrees(-31.99107004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214759"},
        {"Hipparcos Number", "HIP 111978"},
        {"Geneva Identification System", "GEN# +1.00214759"},
        {"Smithsonian Astrophysical Observation", "SAO 214006"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.22889218),
        dec: Angle.Degrees(-31.99010979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 343.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27147"},
        {"Hipparcos Number", "HIP 19885"},
        {"Smithsonian Astrophysical Observation", "SAO 194878"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.98470713),
        dec: Angle.Degrees(-31.98818743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218774"},
        {"Hipparcos Number", "HIP 114464"},
        {"Smithsonian Astrophysical Observation", "SAO 214367"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.72807510),
        dec: Angle.Degrees(-31.98670035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65924"},
        {"Hipparcos Number", "HIP 39099"},
        {"Smithsonian Astrophysical Observation", "SAO 198674"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.97913512),
        dec: Angle.Degrees(-31.98533976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90558"},
        {"Hipparcos Number", "HIP 51139"},
        {"Smithsonian Astrophysical Observation", "SAO 201397"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.70096447),
        dec: Angle.Degrees(-31.98499013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4274"},
        {"Geneva Identification System", "GEN# -0.03200361"},
        {"Smithsonian Astrophysical Observation", "SAO 192813"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.67245430),
        dec: Angle.Degrees(-31.98486349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55663"},
        {"Hipparcos Number", "HIP 34813"},
        {"Geneva Identification System", "GEN# +1.00055663"},
        {"Smithsonian Astrophysical Observation", "SAO 197691"},
        {"Wilson Evans Batten Catalogue", "WEB 6961"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.10030059),
        dec: Angle.Degrees(-31.98187391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223121"},
        {"Hipparcos Number", "HIP 117288"},
        {"Geneva Identification System", "GEN# +1.00223121"},
        {"Smithsonian Astrophysical Observation", "SAO 214768"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.73211614),
        dec: Angle.Degrees(-31.98167606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212147"},
        {"Hipparcos Number", "HIP 110480"},
        {"Smithsonian Astrophysical Observation", "SAO 213775"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.69051979),
        dec: Angle.Degrees(-31.98166587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102216"},
        {"Hipparcos Number", "HIP 57376"},
        {"Smithsonian Astrophysical Observation", "SAO 202782"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.44341469),
        dec: Angle.Degrees(-31.97903389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187741"},
        {"Hipparcos Number", "HIP 97824"},
        {"Smithsonian Astrophysical Observation", "SAO 211624"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.18473138),
        dec: Angle.Degrees(-31.97674117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40359"},
        {"Hipparcos Number", "HIP 28138"},
        {"Geneva Identification System", "GEN# +1.00040359"},
        {"Smithsonian Astrophysical Observation", "SAO 196335"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.20418412),
        dec: Angle.Degrees(-31.97627815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213865"},
        {"Hipparcos Number", "HIP 111461"},
        {"Smithsonian Astrophysical Observation", "SAO 213927"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.73227098),
        dec: Angle.Degrees(-31.97428467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87200"},
        {"Hipparcos Number", "HIP 49215"},
        {"Smithsonian Astrophysical Observation", "SAO 200993"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.68475326),
        dec: Angle.Degrees(-31.97054658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158563"},
        {"Hipparcos Number", "HIP 85752"},
        {"Geneva Identification System", "GEN# +1.00158563"},
        {"Smithsonian Astrophysical Observation", "SAO 208911"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.85000682),
        dec: Angle.Degrees(-31.96984534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 464"},
    },
    visualMagnitude: 12.04,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.38388036),
        dec: Angle.Degrees(-31.96763926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166790"},
        {"Hipparcos Number", "HIP 89330"},
        {"Smithsonian Astrophysical Observation", "SAO 209873"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.40556307),
        dec: Angle.Degrees(-31.96731517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77018"},
        {"Hipparcos Number", "HIP 44085"},
        {"Smithsonian Astrophysical Observation", "SAO 199847"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.69590698),
        dec: Angle.Degrees(-31.96600287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5824"},
        {"Hipparcos Number", "HIP 4631"},
        {"Geneva Identification System", "GEN# +1.00005824"},
        {"Smithsonian Astrophysical Observation", "SAO 192849"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.86071000),
        dec: Angle.Degrees(-31.96529292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152960"},
        {"Hipparcos Number", "HIP 83026"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.49700786),
        dec: Angle.Degrees(-31.96418245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216211"},
        {"Hipparcos Number", "HIP 112878"},
        {"Smithsonian Astrophysical Observation", "SAO 214141"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.87541190),
        dec: Angle.Degrees(-31.96093988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95857"},
        {"Hipparcos Number", "HIP 54030"},
        {"Fundamental Katalog 5th Edition", "FK5 2881"},
        {"Geneva Identification System", "GEN# +1.00095857"},
        {"Smithsonian Astrophysical Observation", "SAO 202039"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.81702176),
        dec: Angle.Degrees(-31.96078529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127774"},
        {"Hipparcos Number", "HIP 71236"},
        {"Fundamental Katalog 5th Edition", "FK5 5290"},
        {"Smithsonian Astrophysical Observation", "SAO 205704"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.52160883),
        dec: Angle.Degrees(-31.95745938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15070"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.55649230),
        dec: Angle.Degrees(-31.95575649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -326.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154307"},
        {"Hipparcos Number", "HIP 83668"},
        {"Geneva Identification System", "GEN# +1.00154307"},
        {"Smithsonian Astrophysical Observation", "SAO 208400"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.51088414),
        dec: Angle.Degrees(-31.95308642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40345"},
        {"Geneva Identification System", "GEN# -0.03105744"},
        {"Smithsonian Astrophysical Observation", "SAO 198976"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.56511458),
        dec: Angle.Degrees(-31.95307570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41708"},
        {"Smithsonian Astrophysical Observation", "SAO 199304"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.58049306),
        dec: Angle.Degrees(-31.95236959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59283"},
        {"Hipparcos Number", "HIP 36254"},
        {"Smithsonian Astrophysical Observation", "SAO 198022"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.97894798),
        dec: Angle.Degrees(-31.94808542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107602"},
        {"Hipparcos Number", "HIP 60317"},
        {"Geneva Identification System", "GEN# +1.00107602"},
        {"Smithsonian Astrophysical Observation", "SAO 203397"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.51922839),
        dec: Angle.Degrees(-31.94596158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53698"},
        {"Hipparcos Number", "HIP 34138"},
        {"Geneva Identification System", "GEN# +1.00053698"},
        {"Smithsonian Astrophysical Observation", "SAO 197542"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.18527048),
        dec: Angle.Degrees(-31.94546972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82895"},
        {"Hipparcos Number", "HIP 46934"},
        {"Geneva Identification System", "GEN# +1.00082895"},
        {"Smithsonian Astrophysical Observation", "SAO 200503"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.49038646),
        dec: Angle.Degrees(-31.94117363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71255"},
        {"Hipparcos Number", "HIP 41268"},
        {"Smithsonian Astrophysical Observation", "SAO 199198"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.29486943),
        dec: Angle.Degrees(-31.94020650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145902"},
        {"Hipparcos Number", "HIP 79603"},
        {"Smithsonian Astrophysical Observation", "SAO 207484"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.65916872),
        dec: Angle.Degrees(-31.93999144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59193"},
        {"Hipparcos Number", "HIP 36217"},
        {"Geneva Identification System", "GEN# +5.11400028"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.87744356),
        dec: Angle.Degrees(-31.93915163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204076"},
        {"Hipparcos Number", "HIP 105912"},
        {"Geneva Identification System", "GEN# +1.00204076"},
        {"Smithsonian Astrophysical Observation", "SAO 213008"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.75459593),
        dec: Angle.Degrees(-31.93899769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56375"},
        {"Hipparcos Number", "HIP 35081"},
        {"Geneva Identification System", "GEN# +5.11320021"},
        {"Smithsonian Astrophysical Observation", "SAO 197757"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.83252426),
        dec: Angle.Degrees(-31.93868675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23227"},
        {"Hipparcos Number", "HIP 17304"},
        {"Fundamental Katalog 5th Edition", "FK5 133"},
        {"Geneva Identification System", "GEN# +1.00023227"},
        {"Smithsonian Astrophysical Observation", "SAO 194467"},
        {"Wilson Evans Batten Catalogue", "WEB 3269"},
    },
    visualMagnitude: 4.99,
    bvColour: -0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.56207975),
        dec: Angle.Degrees(-31.93839587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181620"},
        {"Hipparcos Number", "HIP 95226"},
        {"Geneva Identification System", "GEN# +1.00181620"},
        {"Smithsonian Astrophysical Observation", "SAO 211215"},
        {"Wilson Evans Batten Catalogue", "WEB 16636"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.60695199),
        dec: Angle.Degrees(-31.93660026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54839"},
        {"Hipparcos Number", "HIP 34519"},
        {"Smithsonian Astrophysical Observation", "SAO 197637"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.28609470),
        dec: Angle.Degrees(-31.93357121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182048"},
        {"Hipparcos Number", "HIP 95380"},
        {"Smithsonian Astrophysical Observation", "SAO 211236"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.04729058),
        dec: Angle.Degrees(-31.93203875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197339"},
        {"Hipparcos Number", "HIP 102336"},
        {"Fundamental Katalog 5th Edition", "FK5 5822"},
        {"Smithsonian Astrophysical Observation", "SAO 212390"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.01706633),
        dec: Angle.Degrees(-31.92840592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120955"},
        {"Hipparcos Number", "HIP 67786"},
        {"Geneva Identification System", "GEN# +1.00120955A"},
        {"Smithsonian Astrophysical Observation", "SAO 204944"},
        {"Wilson Evans Batten Catalogue", "WEB 11913"},
    },
    visualMagnitude: 4.75,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.30228458),
        dec: Angle.Degrees(-31.92758624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211779"},
        {"Hipparcos Number", "HIP 110272"},
        {"Smithsonian Astrophysical Observation", "SAO 213744"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.04826079),
        dec: Angle.Degrees(-31.92744353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182137"},
        {"Hipparcos Number", "HIP 95420"},
        {"Smithsonian Astrophysical Observation", "SAO 211240"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.14822400),
        dec: Angle.Degrees(-31.92448038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58155"},
        {"Hipparcos Number", "HIP 35795"},
        {"Celescope Catalog", "CEL 1815"},
        {"Geneva Identification System", "GEN# +5.11400003"},
        {"Smithsonian Astrophysical Observation", "SAO 197925"},
        {"Wilson Evans Batten Catalogue", "WEB 7135"},
    },
    visualMagnitude: 5.40,
    bvColour: -0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.75292901),
        dec: Angle.Degrees(-31.92379021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206161"},
        {"Hipparcos Number", "HIP 107058"},
        {"Smithsonian Astrophysical Observation", "SAO 213199"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.24747404),
        dec: Angle.Degrees(-31.92304959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 318931"},
        {"Hipparcos Number", "HIP 88649"},
        {"Smithsonian Astrophysical Observation", "SAO 209699"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.48380659),
        dec: Angle.Degrees(-31.92235698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224113"},
        {"Hipparcos Number", "HIP 117931"},
        {"Fundamental Katalog 5th Edition", "FK5 3921"},
        {"Geneva Identification System", "GEN# +1.00224113"},
        {"Smithsonian Astrophysical Observation", "SAO 214860"},
        {"Wilson Evans Batten Catalogue", "WEB 20739"},
    },
    visualMagnitude: 6.09,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.81906097),
        dec: Angle.Degrees(-31.92146922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40522"},
        {"Hipparcos Number", "HIP 28235"},
        {"Geneva Identification System", "GEN# +1.00040522"},
        {"Smithsonian Astrophysical Observation", "SAO 196356"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.48547782),
        dec: Angle.Degrees(-31.92121169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178370"},
        {"Hipparcos Number", "HIP 94135"},
        {"Geneva Identification System", "GEN# +1.00178370"},
        {"Smithsonian Astrophysical Observation", "SAO 211001"},
        {"Wilson Evans Batten Catalogue", "WEB 16394"},
    },
    visualMagnitude: 9.52,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.42810109),
        dec: Angle.Degrees(-31.92089893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144734"},
        {"Hipparcos Number", "HIP 79078"},
        {"Smithsonian Astrophysical Observation", "SAO 207371"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.13584771),
        dec: Angle.Degrees(-31.91969803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128581"},
        {"Hipparcos Number", "HIP 71593"},
        {"Geneva Identification System", "GEN# +1.00128581"},
        {"Smithsonian Astrophysical Observation", "SAO 205792"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.63287148),
        dec: Angle.Degrees(-31.91759717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3999"},
        {"Hipparcos Number", "HIP 3320"},
        {"Geneva Identification System", "GEN# +1.00003999"},
        {"Smithsonian Astrophysical Observation", "SAO 192686"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.58354312),
        dec: Angle.Degrees(-31.91660971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94994"},
        {"Hipparcos Number", "HIP 53583"},
        {"Smithsonian Astrophysical Observation", "SAO 201944"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.41662566),
        dec: Angle.Degrees(-31.91623890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112064"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.46623203),
        dec: Angle.Degrees(-31.91538702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222432"},
        {"Hipparcos Number", "HIP 116821"},
        {"Smithsonian Astrophysical Observation", "SAO 214700"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.15988671),
        dec: Angle.Degrees(-31.91390343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24523"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.92366465),
        dec: Angle.Degrees(-31.91390329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 305.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203723"},
        {"Hipparcos Number", "HIP 105731"},
        {"Smithsonian Astrophysical Observation", "SAO 212979"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.22508690),
        dec: Angle.Degrees(-31.91324119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77843"},
        {"Hipparcos Number", "HIP 44505"},
        {"Fundamental Katalog 5th Edition", "FK5 4807"},
        {"Smithsonian Astrophysical Observation", "SAO 199941"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.00187246),
        dec: Angle.Degrees(-31.91116953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79293"},
        {"Hipparcos Number", "HIP 45173"},
        {"Smithsonian Astrophysical Observation", "SAO 200094"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.08374508),
        dec: Angle.Degrees(-31.91107672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56343"},
        {"Hipparcos Number", "HIP 120047"},
        {"Geneva Identification System", "GEN# +5.11320027"},
        {"Renson", "Renson 15355"},
    },
    visualMagnitude: 9.24,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.82776681),
        dec: Angle.Degrees(-31.90968610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117304"},
        {"Smithsonian Astrophysical Observation", "SAO 214770"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.77670116),
        dec: Angle.Degrees(-31.90939545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205860"},
        {"Hipparcos Number", "HIP 106880"},
        {"Geneva Identification System", "GEN# +1.00205860"},
        {"Smithsonian Astrophysical Observation", "SAO 213163"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.72785085),
        dec: Angle.Degrees(-31.90926489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33791"},
        {"Hipparcos Number", "HIP 24168"},
        {"Smithsonian Astrophysical Observation", "SAO 195629"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.84412195),
        dec: Angle.Degrees(-31.90858318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186500"},
        {"Hipparcos Number", "HIP 97260"},
        {"Fundamental Katalog 5th Edition", "FK5 1516"},
        {"Geneva Identification System", "GEN# +1.00186500"},
        {"Smithsonian Astrophysical Observation", "SAO 211541"},
        {"Wilson Evans Batten Catalogue", "WEB 17081"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.50506632),
        dec: Angle.Degrees(-31.90853854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62910"},
        {"Hipparcos Number", "HIP 37791"},
        {"Geneva Identification System", "GEN# +1.00062910"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.24259747),
        dec: Angle.Degrees(-31.90821897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210570"},
        {"Hipparcos Number", "HIP 109579"},
        {"Smithsonian Astrophysical Observation", "SAO 213630"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.96906769),
        dec: Angle.Degrees(-31.90735137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7366"},
        {"Hipparcos Number", "HIP 5703"},
        {"Smithsonian Astrophysical Observation", "SAO 192988"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.34346506),
        dec: Angle.Degrees(-31.90732815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151469"},
        {"Hipparcos Number", "HIP 82287"},
        {"Smithsonian Astrophysical Observation", "SAO 208057"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.20847111),
        dec: Angle.Degrees(-31.90697242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30575"},
        {"Hipparcos Number", "HIP 22254"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.86863399),
        dec: Angle.Degrees(-31.90456206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34088"},
        {"Hipparcos Number", "HIP 24355"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.38721179),
        dec: Angle.Degrees(-31.90426449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224863"},
        {"Hipparcos Number", "HIP 104"},
        {"Smithsonian Astrophysical Observation", "SAO 214922"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.32673657),
        dec: Angle.Degrees(-31.89961642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57481"},
    },
    visualMagnitude: 11.75,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.74178512),
        dec: Angle.Degrees(-31.89899627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 856"},
        {"Hipparcos Number", "HIP 1028"},
        {"Geneva Identification System", "GEN# +1.00000856"},
        {"Smithsonian Astrophysical Observation", "SAO 192403"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.20647423),
        dec: Angle.Degrees(-31.89768114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42044"},
        {"Hipparcos Number", "HIP 28999"},
        {"Geneva Identification System", "GEN# +1.00042044"},
        {"Smithsonian Astrophysical Observation", "SAO 196504"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.78238732),
        dec: Angle.Degrees(-31.89757330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58394"},
        {"Hipparcos Number", "HIP 35901"},
        {"Geneva Identification System", "GEN# +5.11400010"},
        {"Smithsonian Astrophysical Observation", "SAO 197949"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.01605532),
        dec: Angle.Degrees(-31.89236647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52596"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.31963968),
        dec: Angle.Degrees(-30.80692469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -233.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9742"},
        {"Hipparcos Number", "HIP 7361"},
        {"Geneva Identification System", "GEN# +1.00009742"},
        {"Smithsonian Astrophysical Observation", "SAO 193188"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.71180174),
        dec: Angle.Degrees(-31.89221429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58396"},
        {"Hipparcos Number", "HIP 35905"},
        {"Geneva Identification System", "GEN# +5.11400032"},
    },
    visualMagnitude: 9.35,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.02959684),
        dec: Angle.Degrees(-31.89156010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10811"},
        {"Hipparcos Number", "HIP 8189"},
        {"Geneva Identification System", "GEN# +1.00010811"},
        {"Smithsonian Astrophysical Observation", "SAO 193288"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.32143153),
        dec: Angle.Degrees(-31.89154828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7093"},
        {"Smithsonian Astrophysical Observation", "SAO 193160"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.85056466),
        dec: Angle.Degrees(-31.89147714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83365"},
        {"Hipparcos Number", "HIP 47190"},
        {"Geneva Identification System", "GEN# +1.00083365"},
        {"Smithsonian Astrophysical Observation", "SAO 200556"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.26325560),
        dec: Angle.Degrees(-31.88985524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82383J"},
        {"Hipparcos Number", "HIP 46657"},
        {"Geneva Identification System", "GEN# +1.00082384J"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.69200638),
        dec: Angle.Degrees(-31.88917107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143404"},
        {"Hipparcos Number", "HIP 78486"},
        {"Geneva Identification System", "GEN# +1.00143404"},
        {"Smithsonian Astrophysical Observation", "SAO 207234"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.33145077),
        dec: Angle.Degrees(-31.88913378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138792"},
        {"Hipparcos Number", "HIP 76326"},
        {"Smithsonian Astrophysical Observation", "SAO 206785"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.86700281),
        dec: Angle.Degrees(-31.88858561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47282"},
        {"Hipparcos Number", "HIP 31572"},
        {"Geneva Identification System", "GEN# +1.00047282"},
        {"Smithsonian Astrophysical Observation", "SAO 196995"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.11651837),
        dec: Angle.Degrees(-31.88690966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76298"},
        {"Hipparcos Number", "HIP 43720"},
        {"Smithsonian Astrophysical Observation", "SAO 199766"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.55864922),
        dec: Angle.Degrees(-31.88513246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31772"},
        {"Hipparcos Number", "HIP 23036"},
        {"Smithsonian Astrophysical Observation", "SAO 195428"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.31335843),
        dec: Angle.Degrees(-31.88510603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202513"},
        {"Hipparcos Number", "HIP 105085"},
        {"Smithsonian Astrophysical Observation", "SAO 212862"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.31828357),
        dec: Angle.Degrees(-31.88441936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224112"},
        {"Hipparcos Number", "HIP 117932"},
        {"Geneva Identification System", "GEN# +1.00224112"},
        {"Smithsonian Astrophysical Observation", "SAO 214861"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.81948838),
        dec: Angle.Degrees(-31.88427407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152180"},
        {"Hipparcos Number", "HIP 82596"},
        {"Geneva Identification System", "GEN# +1.00152180"},
        {"Smithsonian Astrophysical Observation", "SAO 208136"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.27712553),
        dec: Angle.Degrees(-31.88018599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109422"},
        {"Hipparcos Number", "HIP 61382"},
        {"Geneva Identification System", "GEN# +1.00109422"},
        {"Smithsonian Astrophysical Observation", "SAO 203601"},
        {"Wilson Evans Batten Catalogue", "WEB 10925"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.68110071),
        dec: Angle.Degrees(-31.87602357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -204.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123313"},
        {"Hipparcos Number", "HIP 69000"},
        {"Smithsonian Astrophysical Observation", "SAO 205204"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.89205301),
        dec: Angle.Degrees(-31.87566971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22322"},
        {"Hipparcos Number", "HIP 16672"},
        {"Geneva Identification System", "GEN# +1.00022322J"},
        {"Smithsonian Astrophysical Observation", "SAO 194379"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.63990978),
        dec: Angle.Degrees(-31.87479845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220705"},
        {"Hipparcos Number", "HIP 115676"},
        {"Smithsonian Astrophysical Observation", "SAO 214545"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.54135765),
        dec: Angle.Degrees(-31.87274292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114729"},
        {"Hipparcos Number", "HIP 64459"},
        {"Geneva Identification System", "GEN# +1.00114729"},
        {"Smithsonian Astrophysical Observation", "SAO 204237"},
        {"Wilson Evans Batten Catalogue", "WEB 11394"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.18498477),
        dec: Angle.Degrees(-31.87259921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -308.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45552"},
        {"Hipparcos Number", "HIP 30680"},
        {"Geneva Identification System", "GEN# +1.00045552"},
        {"Smithsonian Astrophysical Observation", "SAO 196828"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.70699789),
        dec: Angle.Degrees(-31.87196033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82513"},
        {"Hipparcos Number", "HIP 46734"},
        {"Geneva Identification System", "GEN# +1.00082513"},
        {"Renson", "Renson 23460"},
        {"Smithsonian Astrophysical Observation", "SAO 200459"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.88413622),
        dec: Angle.Degrees(-31.87183113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215601"},
        {"Hipparcos Number", "HIP 112457"},
        {"Geneva Identification System", "GEN# +1.00215601"},
        {"Smithsonian Astrophysical Observation", "SAO 214072"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.70022826),
        dec: Angle.Degrees(-31.87168465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222004"},
        {"Hipparcos Number", "HIP 116539"},
        {"Geneva Identification System", "GEN# +1.00222004"},
        {"Smithsonian Astrophysical Observation", "SAO 214659"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.27229795),
        dec: Angle.Degrees(-31.87113156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23069"},
        {"Hipparcos Number", "HIP 17194"},
        {"Geneva Identification System", "GEN# +1.00023069"},
        {"Smithsonian Astrophysical Observation", "SAO 194447"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.23283271),
        dec: Angle.Degrees(-31.87054252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126667"},
        {"Hipparcos Number", "HIP 70706"},
        {"Smithsonian Astrophysical Observation", "SAO 205579"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.92423238),
        dec: Angle.Degrees(-31.86582593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173770"},
        {"Hipparcos Number", "HIP 92280"},
        {"Geneva Identification System", "GEN# +1.00173770J"},
        {"Smithsonian Astrophysical Observation", "SAO 210588"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.09392316),
        dec: Angle.Degrees(-31.86495414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211173"},
        {"Hipparcos Number", "HIP 109933"},
        {"Geneva Identification System", "GEN# +1.00211173"},
        {"Smithsonian Astrophysical Observation", "SAO 213680"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.98743447),
        dec: Angle.Degrees(-31.86074433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100407"},
        {"Hipparcos Number", "HIP 56343"},
        {"Fundamental Katalog 5th Edition", "FK5 434"},
        {"Geneva Identification System", "GEN# +1.00100407"},
        {"Smithsonian Astrophysical Observation", "SAO 202558"},
        {"Wilson Evans Batten Catalogue", "WEB 10131"},
    },
    visualMagnitude: 3.54,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.25107936),
        dec: Angle.Degrees(-31.85752405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -209.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99781"},
        {"Hipparcos Number", "HIP 55993"},
        {"Smithsonian Astrophysical Observation", "SAO 202488"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.12382978),
        dec: Angle.Degrees(-31.85699558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147595"},
        {"Hipparcos Number", "HIP 80339"},
        {"Smithsonian Astrophysical Observation", "SAO 207627"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.01484800),
        dec: Angle.Degrees(-31.85669949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6560"},
        {"Hipparcos Number", "HIP 5156"},
        {"Geneva Identification System", "GEN# +1.00006560"},
        {"Smithsonian Astrophysical Observation", "SAO 192918"},
        {"Wilson Evans Batten Catalogue", "WEB 1074"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.50390444),
        dec: Angle.Degrees(-31.85467486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16369"},
        {"Hipparcos Number", "HIP 12149"},
        {"Smithsonian Astrophysical Observation", "SAO 193803"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.14794824),
        dec: Angle.Degrees(-31.85052894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151360"},
        {"Hipparcos Number", "HIP 82250"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.07051399),
        dec: Angle.Degrees(-31.85025820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2105"},
        {"Hipparcos Number", "HIP 1986"},
        {"Smithsonian Astrophysical Observation", "SAO 192510"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.28341446),
        dec: Angle.Degrees(-31.84905703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59499J"},
        {"Hipparcos Number", "HIP 36345"},
        {"Geneva Identification System", "GEN# +1.00059499J"},
    },
    visualMagnitude: 5.95,
    bvColour: -0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.21316505),
        dec: Angle.Degrees(-31.84841156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139899"},
        {"Hipparcos Number", "HIP 76862"},
        {"Smithsonian Astrophysical Observation", "SAO 206876"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.43630743),
        dec: Angle.Degrees(-31.84707372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112872"},
        {"Smithsonian Astrophysical Observation", "SAO 214139"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.86094884),
        dec: Angle.Degrees(-31.84474205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91320"},
        {"Hipparcos Number", "HIP 51581"},
        {"Geneva Identification System", "GEN# +1.00091320"},
        {"Smithsonian Astrophysical Observation", "SAO 201485"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.03502684),
        dec: Angle.Degrees(-31.84048580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39637"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.49798617),
        dec: Angle.Degrees(-31.84045528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95456"},
        {"Hipparcos Number", "HIP 53818"},
        {"Geneva Identification System", "GEN# +1.00095456"},
        {"Smithsonian Astrophysical Observation", "SAO 201998"},
        {"Wilson Evans Batten Catalogue", "WEB 9751"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.17015147),
        dec: Angle.Degrees(-31.83961881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92637"},
        {"Hipparcos Number", "HIP 52311"},
        {"Geneva Identification System", "GEN# +1.00092637"},
        {"Smithsonian Astrophysical Observation", "SAO 201637"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.33004263),
        dec: Angle.Degrees(-31.83937790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39377",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39377"},
        {"Smithsonian Astrophysical Observation", "SAO 198742"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.75691404),
        dec: Angle.Degrees(-31.83896900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47851"},
        {"Hipparcos Number", "HIP 31824"},
        {"Celescope Catalog", "CEL 1344"},
        {"Geneva Identification System", "GEN# +1.00047851A"},
        {"Smithsonian Astrophysical Observation", "SAO 197044"},
        {"Wilson Evans Batten Catalogue", "WEB 6399"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.81289838),
        dec: Angle.Degrees(-31.83559924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12359"},
        {"Hipparcos Number", "HIP 9373"},
        {"Smithsonian Astrophysical Observation", "SAO 193448"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.11683989),
        dec: Angle.Degrees(-31.83379153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51924"},
        {"Smithsonian Astrophysical Observation", "SAO 201554"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.10349609),
        dec: Angle.Degrees(-31.83302645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135447"},
        {"Hipparcos Number", "HIP 74723"},
        {"Smithsonian Astrophysical Observation", "SAO 206473"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.05687214),
        dec: Angle.Degrees(-31.83004222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47851B"},
        {"Hipparcos Number", "HIP 31825"},
    },
    visualMagnitude: 9.67,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)39, 15.9900),
        dec: Angle.DegreesMinutesSeconds((int)-31, (int)49, 47.100)
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
    primaryId: "HIP 2177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2381"},
        {"Hipparcos Number", "HIP 2177"},
        {"Geneva Identification System", "GEN# +1.00002381"},
        {"Smithsonian Astrophysical Observation", "SAO 192537"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.87494216),
        dec: Angle.Degrees(-31.82825252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158682"},
        {"Hipparcos Number", "HIP 85811"},
        {"Geneva Identification System", "GEN# +1.00158682"},
        {"Smithsonian Astrophysical Observation", "SAO 208927"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.00632279),
        dec: Angle.Degrees(-31.82716409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125563"},
        {"Hipparcos Number", "HIP 70126"},
        {"Smithsonian Astrophysical Observation", "SAO 205464"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.23274714),
        dec: Angle.Degrees(-31.82647183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130962"},
        {"Hipparcos Number", "HIP 72700"},
        {"Smithsonian Astrophysical Observation", "SAO 206019"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.96229352),
        dec: Angle.Degrees(-31.82532189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 520"},
        {"Hipparcos Number", "HIP 787"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.43155816),
        dec: Angle.Degrees(-31.82493921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 404.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -232.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70234"},
        {"Hipparcos Number", "HIP 40800"},
        {"Celescope Catalog", "CEL 2370"},
        {"Geneva Identification System", "GEN# +1.00070234"},
        {"Smithsonian Astrophysical Observation", "SAO 199086"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.90855859),
        dec: Angle.Degrees(-31.82347851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79381"},
        {"Hipparcos Number", "HIP 45215"},
        {"Smithsonian Astrophysical Observation", "SAO 200104"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.21378123),
        dec: Angle.Degrees(-31.82340528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152039"},
        {"Hipparcos Number", "HIP 82546"},
        {"Geneva Identification System", "GEN# +1.00152039"},
        {"Smithsonian Astrophysical Observation", "SAO 208120"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.08437719),
        dec: Angle.Degrees(-31.82052718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110419"},
        {"Hipparcos Number", "HIP 61984"},
        {"Smithsonian Astrophysical Observation", "SAO 203725"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.53719383),
        dec: Angle.Degrees(-31.81952114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181109"},
        {"Hipparcos Number", "HIP 95054"},
        {"Geneva Identification System", "GEN# +1.00181109"},
        {"Smithsonian Astrophysical Observation", "SAO 211191"},
        {"Wilson Evans Batten Catalogue", "WEB 16601"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.10915464),
        dec: Angle.Degrees(-31.81761893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148730"},
        {"Hipparcos Number", "HIP 80919"},
        {"Geneva Identification System", "GEN# +1.00148730"},
        {"Smithsonian Astrophysical Observation", "SAO 207735"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.86025582),
        dec: Angle.Degrees(-31.81720800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119482"},
        {"Hipparcos Number", "HIP 67026"},
        {"Geneva Identification System", "GEN# +1.00119482"},
        {"Smithsonian Astrophysical Observation", "SAO 204787"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.04174637),
        dec: Angle.Degrees(-31.81646702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47246"},
        {"Smithsonian Astrophysical Observation", "SAO 200577"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.45613881),
        dec: Angle.Degrees(-31.81395025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89709"},
        {"Hipparcos Number", "HIP 50641"},
        {"Geneva Identification System", "GEN# +1.00089709"},
        {"Smithsonian Astrophysical Observation", "SAO 201297"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.14255452),
        dec: Angle.Degrees(-31.81378590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8581"},
        {"Hipparcos Number", "HIP 6551"},
        {"Cincinnati Publication", "Ci 18 186"},
        {"Geneva Identification System", "GEN# +1.00008581"},
        {"Smithsonian Astrophysical Observation", "SAO 193096"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.05079037),
        dec: Angle.Degrees(-31.81177683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13300"},
        {"Hipparcos Number", "HIP 10039"},
        {"Smithsonian Astrophysical Observation", "SAO 193537"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.30183640),
        dec: Angle.Degrees(-31.80916981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58535"},
        {"Hipparcos Number", "HIP 35957"},
        {"Geneva Identification System", "GEN# +5.11400001"},
        {"Smithsonian Astrophysical Observation", "SAO 197964"},
        {"Wilson Evans Batten Catalogue", "WEB 7161"},
    },
    visualMagnitude: 5.35,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.18278416),
        dec: Angle.Degrees(-31.80892621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10462"},
        {"Hipparcos Number", "HIP 7885"},
        {"Geneva Identification System", "GEN# +1.00010462"},
        {"Smithsonian Astrophysical Observation", "SAO 193254"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.36338903),
        dec: Angle.Degrees(-31.80819044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53547"},
        {"Hipparcos Number", "HIP 34093"},
        {"Smithsonian Astrophysical Observation", "SAO 197532"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.03875708),
        dec: Angle.Degrees(-31.80409335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218350"},
        {"Hipparcos Number", "HIP 114191"},
        {"Geneva Identification System", "GEN# +1.00218350"},
        {"Smithsonian Astrophysical Observation", "SAO 214325"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.87296186),
        dec: Angle.Degrees(-31.80251735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51014"},
        {"Hipparcos Number", "HIP 33178"},
        {"Celescope Catalog", "CEL 1430"},
        {"Smithsonian Astrophysical Observation", "SAO 197335"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.58379588),
        dec: Angle.Degrees(-31.80162506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15156"},
        {"Hipparcos Number", "HIP 11311"},
        {"Geneva Identification System", "GEN# +1.00015156"},
        {"Smithsonian Astrophysical Observation", "SAO 193702"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.40516369),
        dec: Angle.Degrees(-31.79839796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81014"},
        {"Hipparcos Number", "HIP 45945"},
        {"Smithsonian Astrophysical Observation", "SAO 200283"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.54271391),
        dec: Angle.Degrees(-31.79807736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68462",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68462"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.23961621),
        dec: Angle.Degrees(-31.79744842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -692.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151015"},
        {"Hipparcos Number", "HIP 82083"},
        {"Smithsonian Astrophysical Observation", "SAO 208013"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.50060333),
        dec: Angle.Degrees(-31.79719446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208166"},
        {"Hipparcos Number", "HIP 108184"},
        {"Smithsonian Astrophysical Observation", "SAO 213391"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.77323610),
        dec: Angle.Degrees(-31.79661250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49095"},
        {"Hipparcos Number", "HIP 32366"},
        {"Cincinnati Publication", "Ci 20 397"},
        {"Geneva Identification System", "GEN# +1.00049095"},
        {"Smithsonian Astrophysical Observation", "SAO 197171"},
        {"Wilson Evans Batten Catalogue", "WEB 6529"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.34616795),
        dec: Angle.Degrees(-31.79292174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -204.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -304.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5288",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5288"},
        {"Smithsonian Astrophysical Observation", "SAO 192937"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.90846141),
        dec: Angle.Degrees(-31.79074759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44956"},
        {"Hipparcos Number", "HIP 30376"},
        {"Geneva Identification System", "GEN# +1.00044956"},
        {"Smithsonian Astrophysical Observation", "SAO 196759"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.81043243),
        dec: Angle.Degrees(-31.79031451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51411"},
        {"Hipparcos Number", "HIP 33330"},
        {"Celescope Catalog", "CEL 1444"},
        {"Geneva Identification System", "GEN# +1.00051411"},
        {"Smithsonian Astrophysical Observation", "SAO 197371"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.97824254),
        dec: Angle.Degrees(-31.79019560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27050"},
        {"Hipparcos Number", "HIP 19840"},
        {"Smithsonian Astrophysical Observation", "SAO 194868"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.80251915),
        dec: Angle.Degrees(-31.78972745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67798"},
    },
    visualMagnitude: 12.08,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.33299566),
        dec: Angle.Degrees(-30.77721184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179640"},
        {"Hipparcos Number", "HIP 94552"},
        {"Geneva Identification System", "GEN# +1.00179640"},
        {"Smithsonian Astrophysical Observation", "SAO 211080"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.66050601),
        dec: Angle.Degrees(-31.78875015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6323"},
        {"Hipparcos Number", "HIP 4981"},
        {"Geneva Identification System", "GEN# +1.00006323"},
        {"Smithsonian Astrophysical Observation", "SAO 192898"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.95990298),
        dec: Angle.Degrees(-31.78642995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94741"},
        {"Hipparcos Number", "HIP 53433"},
        {"Smithsonian Astrophysical Observation", "SAO 201908"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.96343014),
        dec: Angle.Degrees(-31.78631315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124504"},
        {"Hipparcos Number", "HIP 69602"},
        {"Geneva Identification System", "GEN# +1.00124504"},
        {"Smithsonian Astrophysical Observation", "SAO 205344"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.68622148),
        dec: Angle.Degrees(-31.78624020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142542"},
        {"Hipparcos Number", "HIP 78058"},
        {"Geneva Identification System", "GEN# +1.00142542"},
        {"Smithsonian Astrophysical Observation", "SAO 207134"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.05832091),
        dec: Angle.Degrees(-31.78589260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33042"},
        {"Geneva Identification System", "GEN# -0.03103760"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.25821414),
        dec: Angle.Degrees(-31.78075648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116659"},
        {"Smithsonian Astrophysical Observation", "SAO 214679"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.61083661),
        dec: Angle.Degrees(-31.77947372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25785"},
        {"Hipparcos Number", "HIP 18984"},
        {"Smithsonian Astrophysical Observation", "SAO 194727"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.00878947),
        dec: Angle.Degrees(-31.77878915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24033"},
        {"Henry Draper 2", "HD 24033A"},
        {"Hipparcos Number", "HIP 17793"},
        {"Smithsonian Astrophysical Observation", "SAO 194544"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.13429354),
        dec: Angle.Degrees(-31.77874754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113230"},
        {"Hipparcos Number", "HIP 63640"},
        {"Smithsonian Astrophysical Observation", "SAO 204066"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.65284742),
        dec: Angle.Degrees(-31.77840394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153441"},
        {"Hipparcos Number", "HIP 83251"},
        {"Smithsonian Astrophysical Observation", "SAO 208300"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.23311916),
        dec: Angle.Degrees(-31.77748599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102108"},
        {"Hipparcos Number", "HIP 57309"},
        {"Smithsonian Astrophysical Observation", "SAO 202767"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.26512177),
        dec: Angle.Degrees(-31.77663867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72709"},
        {"Hipparcos Number", "HIP 41963"},
        {"Renson", "Renson 20150"},
        {"Smithsonian Astrophysical Observation", "SAO 199358"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.30415768),
        dec: Angle.Degrees(-31.77529772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42731"},
        {"Hipparcos Number", "HIP 29325"},
        {"Smithsonian Astrophysical Observation", "SAO 196563"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.75682233),
        dec: Angle.Degrees(-31.77395249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45096"},
        {"Hipparcos Number", "HIP 30450"},
        {"Smithsonian Astrophysical Observation", "SAO 196772"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.01297550),
        dec: Angle.Degrees(-31.77330474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32515"},
        {"Hipparcos Number", "HIP 23446"},
        {"Fundamental Katalog 5th Edition", "FK5 1139"},
        {"Geneva Identification System", "GEN# +1.00032515"},
        {"Smithsonian Astrophysical Observation", "SAO 195509"},
        {"Wilson Evans Batten Catalogue", "WEB 4559"},
    },
    visualMagnitude: 5.92,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.59503803),
        dec: Angle.Degrees(-31.77154017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99128"},
        {"Hipparcos Number", "HIP 55658"},
        {"Smithsonian Astrophysical Observation", "SAO 202403"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.05241556),
        dec: Angle.Degrees(-31.77107418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106652"},
        {"Hipparcos Number", "HIP 59814"},
        {"Smithsonian Astrophysical Observation", "SAO 203289"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.99058015),
        dec: Angle.Degrees(-31.76992668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169560"},
        {"Hipparcos Number", "HIP 90391"},
        {"Smithsonian Astrophysical Observation", "SAO 210156"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.65738559),
        dec: Angle.Degrees(-31.76761520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54603"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.62604780),
        dec: Angle.Degrees(-31.76619005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110965"},
        {"Hipparcos Number", "HIP 62309"},
        {"Smithsonian Astrophysical Observation", "SAO 203789"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.51908538),
        dec: Angle.Degrees(-31.76317039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92056"},
        {"Hipparcos Number", "HIP 51977"},
        {"Smithsonian Astrophysical Observation", "SAO 201566"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.30358870),
        dec: Angle.Degrees(-31.76271002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147121"},
        {"Hipparcos Number", "HIP 80108"},
        {"Geneva Identification System", "GEN# +1.00147121"},
        {"Smithsonian Astrophysical Observation", "SAO 207584"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.28225117),
        dec: Angle.Degrees(-31.76264179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216729"},
        {"Hipparcos Number", "HIP 113213"},
        {"Geneva Identification System", "GEN# +1.00216729J"},
        {"Smithsonian Astrophysical Observation", "SAO 214185"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.90053766),
        dec: Angle.Degrees(-31.76166206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183177"},
        {"Hipparcos Number", "HIP 95838"},
        {"Smithsonian Astrophysical Observation", "SAO 211302"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.37944365),
        dec: Angle.Degrees(-31.76048083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89440"},
        {"Hipparcos Number", "HIP 50500"},
        {"Smithsonian Astrophysical Observation", "SAO 201267"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.68378789),
        dec: Angle.Degrees(-31.76027822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80773"},
        {"Hipparcos Number", "HIP 45837"},
        {"Wilson Evans Batten Catalogue", "WEB 8691"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.18468423),
        dec: Angle.Degrees(-31.76022116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92934"},
        {"Hipparcos Number", "HIP 52447"},
        {"Smithsonian Astrophysical Observation", "SAO 201672"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.82465040),
        dec: Angle.Degrees(-31.75962780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167291"},
        {"Hipparcos Number", "HIP 89510"},
        {"Smithsonian Astrophysical Observation", "SAO 209927"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.98356036),
        dec: Angle.Degrees(-31.75896956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109321"},
        {"Smithsonian Astrophysical Observation", "SAO 213586"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.21690566),
        dec: Angle.Degrees(-31.75786693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136988"},
        {"Hipparcos Number", "HIP 75438"},
        {"Smithsonian Astrophysical Observation", "SAO 206603"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.17986148),
        dec: Angle.Degrees(-31.75421431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98302"},
        {"Hipparcos Number", "HIP 55201"},
        {"Smithsonian Astrophysical Observation", "SAO 202299"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.53736586),
        dec: Angle.Degrees(-31.75221803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99150"},
    },
    visualMagnitude: 12.19,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.93658522),
        dec: Angle.Degrees(-31.75215970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 290.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -753.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48502"},
        {"Geneva Identification System", "GEN# -0.03107745A"},
        {"Smithsonian Astrophysical Observation", "SAO 200840"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.36739891),
        dec: Angle.Degrees(-31.75193178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12295"},
        {"Hipparcos Number", "HIP 9346"},
        {"Smithsonian Astrophysical Observation", "SAO 193441"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.99947980),
        dec: Angle.Degrees(-31.74998265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173145"},
        {"Hipparcos Number", "HIP 92011"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.31148803),
        dec: Angle.Degrees(-31.74959627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32844"},
        {"Hipparcos Number", "HIP 23623"},
        {"Geneva Identification System", "GEN# +1.00032844"},
        {"Smithsonian Astrophysical Observation", "SAO 195538"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.17919740),
        dec: Angle.Degrees(-31.74860719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35416"},
        {"Hipparcos Number", "HIP 25183"},
        {"Geneva Identification System", "GEN# +1.00035416"},
        {"Smithsonian Astrophysical Observation", "SAO 195796"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.80157145),
        dec: Angle.Degrees(-31.74857525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164200"},
        {"Hipparcos Number", "HIP 88259"},
        {"Geneva Identification System", "GEN# +1.00164200"},
        {"Smithsonian Astrophysical Observation", "SAO 209604"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.34668041),
        dec: Angle.Degrees(-31.74834308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155271"},
        {"Hipparcos Number", "HIP 84119"},
        {"Smithsonian Astrophysical Observation", "SAO 208515"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.95963303),
        dec: Angle.Degrees(-31.74764094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13278"},
        {"Hipparcos Number", "HIP 10015"},
        {"Smithsonian Astrophysical Observation", "SAO 193534"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.23692792),
        dec: Angle.Degrees(-31.74543178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121961"},
        {"Hipparcos Number", "HIP 68343"},
        {"Geneva Identification System", "GEN# +1.00121961"},
        {"Smithsonian Astrophysical Observation", "SAO 205066"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.84438758),
        dec: Angle.Degrees(-31.74382216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73439"},
        {"Hipparcos Number", "HIP 42290"},
        {"Smithsonian Astrophysical Observation", "SAO 199431"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.33381700),
        dec: Angle.Degrees(-31.74376285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156525"},
        {"Hipparcos Number", "HIP 84751"},
        {"Geneva Identification System", "GEN# +1.00156525"},
        {"Smithsonian Astrophysical Observation", "SAO 208688"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.85689231),
        dec: Angle.Degrees(-31.74107302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183502"},
        {"Hipparcos Number", "HIP 96004"},
        {"Smithsonian Astrophysical Observation", "SAO 211327"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.80913665),
        dec: Angle.Degrees(-31.74007176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167146"},
        {"Hipparcos Number", "HIP 89454"},
        {"Geneva Identification System", "GEN# +1.00167146"},
        {"Smithsonian Astrophysical Observation", "SAO 209915"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.83960273),
        dec: Angle.Degrees(-31.73960822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35339"},
        {"Hipparcos Number", "HIP 25124"},
        {"Geneva Identification System", "GEN# +1.00035339"},
        {"Smithsonian Astrophysical Observation", "SAO 195789"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.66656926),
        dec: Angle.Degrees(-31.73918672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58766"},
        {"Hipparcos Number", "HIP 36045"},
        {"Celescope Catalog", "CEL 1846"},
        {"Geneva Identification System", "GEN# +5.11400004"},
        {"Smithsonian Astrophysical Observation", "SAO 197986"},
        {"Wilson Evans Batten Catalogue", "WEB 7183"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.42910652),
        dec: Angle.Degrees(-31.73873180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76723"},
        {"Hipparcos Number", "HIP 43942"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.25455552),
        dec: Angle.Degrees(-31.73798311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110238"},
        {"Hipparcos Number", "HIP 61893"},
        {"Smithsonian Astrophysical Observation", "SAO 203705"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.24937866),
        dec: Angle.Degrees(-31.73775394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106824",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Samaya"},
        {"Henry Draper", "HD 205739"},
        {"Hipparcos Number", "HIP 106824"},
        {"Geneva Identification System", "GEN# +1.00205739"},
        {"Smithsonian Astrophysical Observation", "SAO 213152"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.53495597),
        dec: Angle.Degrees(-31.73728499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67286"},
    },
    visualMagnitude: 12.07,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.84869186),
        dec: Angle.Degrees(-31.73584984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68978"},
        {"Hipparcos Number", "HIP 40283"},
        {"Geneva Identification System", "GEN# +1.00068978"},
        {"Smithsonian Astrophysical Observation", "SAO 198958"},
        {"Wilson Evans Batten Catalogue", "WEB 7854"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.39469744),
        dec: Angle.Degrees(-31.73575187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -334.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 152.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26153"},
        {"Hipparcos Number", "HIP 19210"},
        {"Smithsonian Astrophysical Observation", "SAO 194772"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.76585544),
        dec: Angle.Degrees(-31.73163562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 190.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61595"},
        {"Hipparcos Number", "HIP 37224"},
        {"Geneva Identification System", "GEN# +1.00061595"},
        {"Smithsonian Astrophysical Observation", "SAO 198230"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.68536913),
        dec: Angle.Degrees(-31.73110264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30109"},
        {"Smithsonian Astrophysical Observation", "SAO 196697"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.04223419),
        dec: Angle.Degrees(-31.73054900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193109"},
        {"Hipparcos Number", "HIP 100224"},
        {"Geneva Identification System", "GEN# +1.00193109"},
        {"Smithsonian Astrophysical Observation", "SAO 212003"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.90626923),
        dec: Angle.Degrees(-31.72945724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92285"},
        {"Hipparcos Number", "HIP 52108"},
        {"Geneva Identification System", "GEN# +1.00092285"},
        {"Smithsonian Astrophysical Observation", "SAO 201588"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.69940822),
        dec: Angle.Degrees(-31.72917420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142851"},
        {"Hipparcos Number", "HIP 78196"},
        {"Geneva Identification System", "GEN# +1.00142851"},
        {"Smithsonian Astrophysical Observation", "SAO 207168"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.49731935),
        dec: Angle.Degrees(-31.72886405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41019"},
        {"Hipparcos Number", "HIP 28516"},
        {"Geneva Identification System", "GEN# +1.00041019"},
        {"Smithsonian Astrophysical Observation", "SAO 196409"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.28980882),
        dec: Angle.Degrees(-31.72649911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15987"},
        {"Hipparcos Number", "HIP 11885"},
        {"Smithsonian Astrophysical Observation", "SAO 193766"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.31768196),
        dec: Angle.Degrees(-31.72081269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128118"},
        {"Hipparcos Number", "HIP 71391"},
        {"Smithsonian Astrophysical Observation", "SAO 205734"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.98047579),
        dec: Angle.Degrees(-31.71701287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10356"},
        {"Hipparcos Number", "HIP 7823"},
        {"Geneva Identification System", "GEN# +1.00010356"},
        {"Smithsonian Astrophysical Observation", "SAO 193247"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.15177192),
        dec: Angle.Degrees(-31.71596357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70257"},
        {"Smithsonian Astrophysical Observation", "SAO 205489"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.62803450),
        dec: Angle.Degrees(-31.71377942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25129",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25129"},
        {"Geneva Identification System", "GEN# -0.03102404"},
        {"Smithsonian Astrophysical Observation", "SAO 195790"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.68102039),
        dec: Angle.Degrees(-31.71241222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72480"},
        {"Hipparcos Number", "HIP 41858"},
        {"Celescope Catalog", "CEL 2610"},
        {"Geneva Identification System", "GEN# +1.00072480"},
        {"Smithsonian Astrophysical Observation", "SAO 199339"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.01320548),
        dec: Angle.Degrees(-31.71139423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30060"},
        {"Hipparcos Number", "HIP 21933"},
        {"Fundamental Katalog 5th Edition", "FK5 4423"},
        {"Geneva Identification System", "GEN# +1.00030060"},
        {"Smithsonian Astrophysical Observation", "SAO 195248"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.73149252),
        dec: Angle.Degrees(-31.70877162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125887"},
        {"Hipparcos Number", "HIP 70307"},
        {"Smithsonian Astrophysical Observation", "SAO 205503"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.77558512),
        dec: Angle.Degrees(-31.70709902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31686"},
        {"Hipparcos Number", "HIP 22969"},
        {"Smithsonian Astrophysical Observation", "SAO 195416"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.13762481),
        dec: Angle.Degrees(-31.70686480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211669"},
        {"Hipparcos Number", "HIP 110197"},
        {"Smithsonian Astrophysical Observation", "SAO 213733"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.83075547),
        dec: Angle.Degrees(-31.70636085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50123"},
        {"Hipparcos Number", "HIP 32810"},
        {"Celescope Catalog", "CEL 1405"},
        {"Geneva Identification System", "GEN# +1.00050123A"},
        {"Smithsonian Astrophysical Observation", "SAO 197263"},
        {"Wilson Evans Batten Catalogue", "WEB 6608"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.59729100),
        dec: Angle.Degrees(-31.70609416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1853"},
        {"Hipparcos Number", "HIP 1789"},
        {"Smithsonian Astrophysical Observation", "SAO 192489"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.68725957),
        dec: Angle.Degrees(-31.70537565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20048"},
        {"Hipparcos Number", "HIP 14904"},
        {"Smithsonian Astrophysical Observation", "SAO 194151"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.08951570),
        dec: Angle.Degrees(-31.70414440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161840"},
        {"Hipparcos Number", "HIP 87220"},
        {"Geneva Identification System", "GEN# +1.00161840"},
        {"Smithsonian Astrophysical Observation", "SAO 209303"},
        {"Wilson Evans Batten Catalogue", "WEB 14715"},
    },
    visualMagnitude: 4.79,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.29363880),
        dec: Angle.Degrees(-31.70318435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32223"},
        {"Hipparcos Number", "HIP 23248"},
        {"Geneva Identification System", "GEN# +1.00032223"},
        {"Smithsonian Astrophysical Observation", "SAO 195472"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.04761617),
        dec: Angle.Degrees(-31.70178228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1463"},
        {"Hipparcos Number", "HIP 1494"},
        {"Geneva Identification System", "GEN# +1.00001463"},
        {"Smithsonian Astrophysical Observation", "SAO 192455"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.66049005),
        dec: Angle.Degrees(-31.70129030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157264"},
        {"Hipparcos Number", "HIP 85100"},
        {"Geneva Identification System", "GEN# +1.00157264"},
        {"Smithsonian Astrophysical Observation", "SAO 208761"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.88608520),
        dec: Angle.Degrees(-31.70032800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32504"},
        {"Hipparcos Number", "HIP 23439"},
        {"Smithsonian Astrophysical Observation", "SAO 195508"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.57619729),
        dec: Angle.Degrees(-31.69566451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24928"},
        {"Hipparcos Number", "HIP 18435"},
        {"Smithsonian Astrophysical Observation", "SAO 194636"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.11962649),
        dec: Angle.Degrees(-31.69546120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177472"},
        {"Hipparcos Number", "HIP 93799"},
        {"Smithsonian Astrophysical Observation", "SAO 210925"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.53923564),
        dec: Angle.Degrees(-31.69524901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37132"},
        {"Hipparcos Number", "HIP 26185"},
        {"Smithsonian Astrophysical Observation", "SAO 195979"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.73122042),
        dec: Angle.Degrees(-31.69448238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186808"},
        {"Hipparcos Number", "HIP 97407"},
        {"Smithsonian Astrophysical Observation", "SAO 211561"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.96794969),
        dec: Angle.Degrees(-31.69444646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56972"},
        {"Hipparcos Number", "HIP 35332"},
        {"Geneva Identification System", "GEN# +1.00056972"},
        {"Smithsonian Astrophysical Observation", "SAO 197811"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.47186129),
        dec: Angle.Degrees(-31.69422661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124738"},
        {"Hipparcos Number", "HIP 69702"},
        {"Smithsonian Astrophysical Observation", "SAO 205367"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.00961215),
        dec: Angle.Degrees(-31.69354748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28861"},
        {"Hipparcos Number", "HIP 21113"},
        {"Geneva Identification System", "GEN# +1.00028861"},
        {"Smithsonian Astrophysical Observation", "SAO 195098"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.87763926),
        dec: Angle.Degrees(-31.69344537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198615"},
        {"Hipparcos Number", "HIP 103042"},
        {"Smithsonian Astrophysical Observation", "SAO 212507"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.14330956),
        dec: Angle.Degrees(-31.69337617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80622"},
        {"Hipparcos Number", "HIP 45759"},
        {"Geneva Identification System", "GEN# +1.00080622"},
        {"Smithsonian Astrophysical Observation", "SAO 200243"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.96771282),
        dec: Angle.Degrees(-31.69239218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39123"},
        {"Hipparcos Number", "HIP 27471"},
        {"Geneva Identification System", "GEN# +1.00039123"},
        {"Smithsonian Astrophysical Observation", "SAO 196204"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.26690759),
        dec: Angle.Degrees(-31.69232822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179325"},
        {"Hipparcos Number", "HIP 94453"},
        {"Geneva Identification System", "GEN# +1.00179325"},
        {"Smithsonian Astrophysical Observation", "SAO 211060"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.35732546),
        dec: Angle.Degrees(-31.69232016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25176"},
        {"Geneva Identification System", "GEN# -0.03102409"},
        {"Smithsonian Astrophysical Observation", "SAO 195795"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.78261322),
        dec: Angle.Degrees(-31.69210113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104644"},
        {"Hipparcos Number", "HIP 58757"},
        {"Smithsonian Astrophysical Observation", "SAO 203066"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.75630730),
        dec: Angle.Degrees(-31.69161956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27286"},
        {"Wilson Evans Batten Catalogue", "WEB 5363"},
    },
    visualMagnitude: 11.18,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.73463019),
        dec: Angle.Degrees(-31.69123257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156572"},
        {"Hipparcos Number", "HIP 84778"},
        {"Geneva Identification System", "GEN# +1.00156572"},
        {"Smithsonian Astrophysical Observation", "SAO 208691"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.93142266),
        dec: Angle.Degrees(-31.69071676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106586"},
        {"Hipparcos Number", "HIP 59789"},
        {"Smithsonian Astrophysical Observation", "SAO 203285"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.89279052),
        dec: Angle.Degrees(-31.69018235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175390"},
        {"Hipparcos Number", "HIP 92972"},
        {"Geneva Identification System", "GEN# +1.00175390"},
        {"Smithsonian Astrophysical Observation", "SAO 210733"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.11346159),
        dec: Angle.Degrees(-31.68900191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37418"},
        {"Geneva Identification System", "GEN# +2.24390002"},
        {"Smithsonian Astrophysical Observation", "SAO 198287"},
        {"New General Catalogue", "NGC 2439 2"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.22250158),
        dec: Angle.Degrees(-31.68875841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224642"},
        {"Hipparcos Number", "HIP 118292"},
        {"Geneva Identification System", "GEN# +1.00224642"},
        {"Smithsonian Astrophysical Observation", "SAO 214899"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.89415060),
        dec: Angle.Degrees(-31.68836656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93657"},
        {"Hipparcos Number", "HIP 52841"},
        {"Geneva Identification System", "GEN# +1.00093657"},
        {"Smithsonian Astrophysical Observation", "SAO 201766"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.05888249),
        dec: Angle.Degrees(-31.68785403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95085"},
    },
    visualMagnitude: 11.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.17392854),
        dec: Angle.Degrees(-31.68725092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86951"},
        {"Hipparcos Number", "HIP 49096"},
        {"Smithsonian Astrophysical Observation", "SAO 200962"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.31327203),
        dec: Angle.Degrees(-31.68717567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39820"},
        {"Hipparcos Number", "HIP 27863"},
        {"Smithsonian Astrophysical Observation", "SAO 196288"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.42721915),
        dec: Angle.Degrees(-31.68585779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37417"},
        {"Geneva Identification System", "GEN# +2.24390004"},
        {"New General Catalogue", "NGC 2439 4"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)40, 53.2000),
        dec: Angle.DegreesMinutesSeconds((int)-31, (int)41, 07.700)
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
    primaryId: "HIP 68641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122510"},
        {"Hipparcos Number", "HIP 68641"},
        {"Geneva Identification System", "GEN# +1.00122510"},
        {"Smithsonian Astrophysical Observation", "SAO 205123"},
        {"Wilson Evans Batten Catalogue", "WEB 12017"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.75710980),
        dec: Angle.Degrees(-31.68419597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18205"},
        {"Smithsonian Astrophysical Observation", "SAO 194606"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.40095038),
        dec: Angle.Degrees(-31.68382125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37433"},
        {"Geneva Identification System", "GEN# +2.24390003"},
        {"New General Catalogue", "NGC 2439 3"},
    },
    visualMagnitude: 9.13,
    bvColour: 2.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.26096203),
        dec: Angle.Degrees(-31.68309012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129959"},
        {"Hipparcos Number", "HIP 72245"},
        {"Smithsonian Astrophysical Observation", "SAO 205927"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.61460815),
        dec: Angle.Degrees(-31.68211282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62735"},
        {"Hipparcos Number", "HIP 37709"},
        {"Geneva Identification System", "GEN# +1.00062735"},
        {"Smithsonian Astrophysical Observation", "SAO 198360"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.04028357),
        dec: Angle.Degrees(-31.68071845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179670"},
        {"Hipparcos Number", "HIP 94561"},
        {"Geneva Identification System", "GEN# +1.00179670"},
        {"Smithsonian Astrophysical Observation", "SAO 211081"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.67918254),
        dec: Angle.Degrees(-31.67908859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21999"},
        {"Hipparcos Number", "HIP 16433"},
        {"Smithsonian Astrophysical Observation", "SAO 194355"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.89570088),
        dec: Angle.Degrees(-31.67348959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71622"},
        {"Hipparcos Number", "HIP 41449"},
        {"Geneva Identification System", "GEN# +1.00071622"},
        {"Smithsonian Astrophysical Observation", "SAO 199246"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.81847379),
        dec: Angle.Degrees(-31.67272366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177847"},
        {"Hipparcos Number", "HIP 93931"},
        {"Smithsonian Astrophysical Observation", "SAO 210952"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.90325260),
        dec: Angle.Degrees(-31.67163543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21747"},
        {"Hipparcos Number", "HIP 16239"},
        {"Smithsonian Astrophysical Observation", "SAO 194328"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.32679288),
        dec: Angle.Degrees(-31.67119429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41883"},
        {"Hipparcos Number", "HIP 28923"},
        {"Smithsonian Astrophysical Observation", "SAO 196493"},
    },
    visualMagnitude: 8.86,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.57579638),
        dec: Angle.Degrees(-31.67072638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38536"},
        {"Hipparcos Number", "HIP 27133"},
        {"Geneva Identification System", "GEN# +1.00038536"},
        {"Smithsonian Astrophysical Observation", "SAO 196136"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.30456934),
        dec: Angle.Degrees(-31.66931836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125381"},
        {"Hipparcos Number", "HIP 70024"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.93441789),
        dec: Angle.Degrees(-31.66921816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103464"},
        {"Hipparcos Number", "HIP 58088"},
        {"Smithsonian Astrophysical Observation", "SAO 202932"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.69808042),
        dec: Angle.Degrees(-31.66814980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222003"},
        {"Hipparcos Number", "HIP 116546"},
        {"Smithsonian Astrophysical Observation", "SAO 214660"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.29102244),
        dec: Angle.Degrees(-31.66697486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99839"},
        {"Hipparcos Number", "HIP 56023"},
        {"Smithsonian Astrophysical Observation", "SAO 202496"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.23087754),
        dec: Angle.Degrees(-31.66602468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48485"},
        {"Hipparcos Number", "HIP 32096"},
        {"Celescope Catalog", "CEL 1362"},
        {"Geneva Identification System", "GEN# +1.00048485"},
        {"Smithsonian Astrophysical Observation", "SAO 197104"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.57946803),
        dec: Angle.Degrees(-31.66602214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29817"},
        {"Smithsonian Astrophysical Observation", "SAO 196645"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.19042763),
        dec: Angle.Degrees(-31.66468344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75142"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.34412200),
        dec: Angle.Degrees(-31.66373150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214122"},
        {"Hipparcos Number", "HIP 111600"},
        {"Geneva Identification System", "GEN# +1.00214122A"},
        {"Smithsonian Astrophysical Observation", "SAO 213948"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.14778918),
        dec: Angle.Degrees(-31.66369314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145825"},
        {"Hipparcos Number", "HIP 79578"},
        {"Geneva Identification System", "GEN# +1.00145825"},
        {"Smithsonian Astrophysical Observation", "SAO 207479"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.54994228),
        dec: Angle.Degrees(-31.66303691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21422"},
        {"Hipparcos Number", "HIP 16005"},
        {"Smithsonian Astrophysical Observation", "SAO 194292"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.53093688),
        dec: Angle.Degrees(-31.66123919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62058"},
        {"Hipparcos Number", "HIP 37415"},
        {"Geneva Identification System", "GEN# +2.24390001"},
        {"Smithsonian Astrophysical Observation", "SAO 198286"},
        {"Wilson Evans Batten Catalogue", "WEB 7402"},
        {"New General Catalogue", "NGC 2439 1"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.21915972),
        dec: Angle.Degrees(-31.66117313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128735"},
        {"Hipparcos Number", "HIP 71665"},
        {"Smithsonian Astrophysical Observation", "SAO 205809"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.86804140),
        dec: Angle.Degrees(-31.65999660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157017"},
        {"Hipparcos Number", "HIP 84987"},
        {"Geneva Identification System", "GEN# +1.00157017"},
        {"Smithsonian Astrophysical Observation", "SAO 208733"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.55634711),
        dec: Angle.Degrees(-31.65784947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139822"},
        {"Hipparcos Number", "HIP 76840"},
        {"Smithsonian Astrophysical Observation", "SAO 206871"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.33647646),
        dec: Angle.Degrees(-31.65655725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40895"},
        {"Smithsonian Astrophysical Observation", "SAO 199104"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.17942038),
        dec: Angle.Degrees(-31.65610334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62476"},
        {"Hipparcos Number", "HIP 37600"},
        {"Smithsonian Astrophysical Observation", "SAO 198336"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.72446115),
        dec: Angle.Degrees(-31.65544064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57547"},
        {"Hipparcos Number", "HIP 35568"},
        {"Geneva Identification System", "GEN# +1.00057547"},
        {"Smithsonian Astrophysical Observation", "SAO 197869"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.10312133),
        dec: Angle.Degrees(-31.65470370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49029"},
        {"Hipparcos Number", "HIP 32348"},
        {"Celescope Catalog", "CEL 1371"},
        {"Geneva Identification System", "GEN# +1.00049029"},
        {"Smithsonian Astrophysical Observation", "SAO 197165"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.28013683),
        dec: Angle.Degrees(-31.65432631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24349"},
        {"Hipparcos Number", "HIP 18030"},
        {"Smithsonian Astrophysical Observation", "SAO 194578"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.80320905),
        dec: Angle.Degrees(-31.65413505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165293"},
        {"Hipparcos Number", "HIP 88709"},
        {"Smithsonian Astrophysical Observation", "SAO 209719"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.64733935),
        dec: Angle.Degrees(-31.65410602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121688"},
        {"Hipparcos Number", "HIP 68186"},
        {"Geneva Identification System", "GEN# +1.00121688"},
        {"Smithsonian Astrophysical Observation", "SAO 205032"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.39170360),
        dec: Angle.Degrees(-31.65288213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206785"},
        {"Hipparcos Number", "HIP 107399"},
        {"Geneva Identification System", "GEN# +1.00206785"},
        {"Smithsonian Astrophysical Observation", "SAO 213260"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.30614942),
        dec: Angle.Degrees(-31.65287239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148769"},
        {"Hipparcos Number", "HIP 80942"},
        {"Smithsonian Astrophysical Observation", "SAO 207739"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.91711313),
        dec: Angle.Degrees(-31.65275636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146569"},
        {"Hipparcos Number", "HIP 79860"},
        {"Smithsonian Astrophysical Observation", "SAO 207524"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.52282291),
        dec: Angle.Degrees(-31.65171142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151579"},
        {"Hipparcos Number", "HIP 82347"},
        {"Smithsonian Astrophysical Observation", "SAO 208069"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.38852642),
        dec: Angle.Degrees(-31.65134990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103933"},
        {"Hipparcos Number", "HIP 58363"},
        {"Geneva Identification System", "GEN# +1.00103933"},
        {"Smithsonian Astrophysical Observation", "SAO 202991"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.51555167),
        dec: Angle.Degrees(-31.65084859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67947"},
        {"Hipparcos Number", "HIP 39918"},
        {"Geneva Identification System", "GEN# +1.00067947"},
        {"Smithsonian Astrophysical Observation", "SAO 198855"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.28952418),
        dec: Angle.Degrees(-31.64640438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54631"},
        {"Smithsonian Astrophysical Observation", "SAO 202170"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.72916137),
        dec: Angle.Degrees(-31.64606007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133729"},
        {"Hipparcos Number", "HIP 73969"},
        {"Smithsonian Astrophysical Observation", "SAO 206307"},
    },
    visualMagnitude: 9.15,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.74558082),
        dec: Angle.Degrees(-31.64415868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5301"},
        {"Hipparcos Number", "HIP 4265"},
        {"Geneva Identification System", "GEN# +1.00005301"},
        {"Smithsonian Astrophysical Observation", "SAO 192811"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.63887179),
        dec: Angle.Degrees(-31.64402951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137349"},
        {"Hipparcos Number", "HIP 75592"},
        {"Geneva Identification System", "GEN# +1.00137349"},
        {"Smithsonian Astrophysical Observation", "SAO 206654"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.65448826),
        dec: Angle.Degrees(-31.64401788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199553"},
        {"Hipparcos Number", "HIP 103563"},
        {"Geneva Identification System", "GEN# +1.00199553"},
        {"Smithsonian Astrophysical Observation", "SAO 212591"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.74550454),
        dec: Angle.Degrees(-31.64374628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196949"},
        {"Hipparcos Number", "HIP 102107"},
        {"Smithsonian Astrophysical Observation", "SAO 212350"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.38709220),
        dec: Angle.Degrees(-31.64306987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56046"},
        {"Hipparcos Number", "HIP 34964"},
        {"Geneva Identification System", "GEN# +5.11320010"},
        {"Smithsonian Astrophysical Observation", "SAO 197727"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.51108863),
        dec: Angle.Degrees(-31.64260979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 317604"},
        {"Hipparcos Number", "HIP 85329"},
        {"Geneva Identification System", "GEN# +1.00317604"},
        {"Smithsonian Astrophysical Observation", "SAO 208812"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.56579244),
        dec: Angle.Degrees(-31.64184974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214121"},
        {"Hipparcos Number", "HIP 111611"},
        {"Geneva Identification System", "GEN# +1.00214122B"},
        {"Geneva Identification System 2", "GEN# +1.00214121"},
        {"Smithsonian Astrophysical Observation", "SAO 213950"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.16357322),
        dec: Angle.Degrees(-31.64170364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18771"},
        {"Hipparcos Number", "HIP 13998"},
        {"Smithsonian Astrophysical Observation", "SAO 194026"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.05347384),
        dec: Angle.Degrees(-31.64046583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19577"},
        {"Hipparcos Number", "HIP 14564"},
        {"Smithsonian Astrophysical Observation", "SAO 194104"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.00623164),
        dec: Angle.Degrees(-31.64031410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2762"},
        {"Hipparcos Number", "HIP 2433"},
        {"Geneva Identification System", "GEN# +1.00002762"},
        {"Smithsonian Astrophysical Observation", "SAO 192582"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.75485915),
        dec: Angle.Degrees(-31.63868240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220863"},
        {"Hipparcos Number", "HIP 115794"},
        {"Smithsonian Astrophysical Observation", "SAO 214556"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.87829374),
        dec: Angle.Degrees(-31.63797131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64301"},
        {"Hipparcos Number", "HIP 38395"},
        {"Celescope Catalog", "CEL 2066"},
        {"Geneva Identification System", "GEN# +1.00064301J"},
        {"Smithsonian Astrophysical Observation", "SAO 198533"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.98855464),
        dec: Angle.Degrees(-31.63645520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151759"},
        {"Hipparcos Number", "HIP 82423"},
        {"Geneva Identification System", "GEN# +1.00151759"},
        {"Smithsonian Astrophysical Observation", "SAO 208085"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.66582216),
        dec: Angle.Degrees(-31.63639246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108920"},
        {"Hipparcos Number", "HIP 61082"},
        {"Geneva Identification System", "GEN# +1.00108920"},
        {"Smithsonian Astrophysical Observation", "SAO 203551"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.78452763),
        dec: Angle.Degrees(-31.63563483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162494"},
        {"Hipparcos Number", "HIP 87508"},
        {"Smithsonian Astrophysical Observation", "SAO 209398"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.18967893),
        dec: Angle.Degrees(-31.63545438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65787"},
        {"Smithsonian Astrophysical Observation", "SAO 204515"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.29986419),
        dec: Angle.Degrees(-31.63542622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3327"},
        {"Hipparcos Number", "HIP 2845"},
        {"Smithsonian Astrophysical Observation", "SAO 192628"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.01205465),
        dec: Angle.Degrees(-31.63357740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216761"},
        {"Hipparcos Number", "HIP 113234"},
        {"Geneva Identification System", "GEN# +1.00216761"},
        {"Smithsonian Astrophysical Observation", "SAO 214187"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.96476013),
        dec: Angle.Degrees(-31.63320469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96172"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.32558331),
        dec: Angle.Degrees(-31.63240235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84899"},
        {"Hipparcos Number", "HIP 48052"},
        {"Smithsonian Astrophysical Observation", "SAO 200740"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.92914870),
        dec: Angle.Degrees(-31.63165161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52517"},
        {"Hipparcos Number", "HIP 33699"},
        {"Smithsonian Astrophysical Observation", "SAO 197455"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.02882474),
        dec: Angle.Degrees(-31.62971530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64842"},
        {"Hipparcos Number", "HIP 38629"},
        {"Smithsonian Astrophysical Observation", "SAO 198577"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.65189014),
        dec: Angle.Degrees(-31.62928223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131350"},
        {"Hipparcos Number", "HIP 72905"},
        {"Geneva Identification System", "GEN# +1.00131350"},
        {"Smithsonian Astrophysical Observation", "SAO 206065"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.50823759),
        dec: Angle.Degrees(-31.62889827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108266"},
        {"Hipparcos Number", "HIP 60703"},
        {"Smithsonian Astrophysical Observation", "SAO 203468"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.62148339),
        dec: Angle.Degrees(-31.62874744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102021"},
        {"Hipparcos Number", "HIP 57246"},
        {"Smithsonian Astrophysical Observation", "SAO 202759"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.07967459),
        dec: Angle.Degrees(-31.62562253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6139"},
        {"Hipparcos Number", "HIP 4837"},
        {"Geneva Identification System", "GEN# +1.00006139"},
        {"Smithsonian Astrophysical Observation", "SAO 192878"},
        {"Wilson Evans Batten Catalogue", "WEB 930"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.55293732),
        dec: Angle.Degrees(-31.62316668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2557"},
        {"Hipparcos Number", "HIP 2276"},
        {"Geneva Identification System", "GEN# +1.00002557"},
        {"Smithsonian Astrophysical Observation", "SAO 192557"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.27375096),
        dec: Angle.Degrees(-31.62229073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122245"},
        {"Hipparcos Number", "HIP 68507"},
        {"Geneva Identification System", "GEN# +1.00122245"},
        {"Smithsonian Astrophysical Observation", "SAO 205102"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.35760396),
        dec: Angle.Degrees(-31.62056821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120759"},
        {"Hipparcos Number", "HIP 67696"},
        {"Geneva Identification System", "GEN# +1.00120759"},
        {"Smithsonian Astrophysical Observation", "SAO 204922"},
        {"Wilson Evans Batten Catalogue", "WEB 11906"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.00415628),
        dec: Angle.Degrees(-31.61913622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10735"},
        {"Hipparcos Number", "HIP 8117"},
        {"Smithsonian Astrophysical Observation", "SAO 193278"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.08663259),
        dec: Angle.Degrees(-31.61856429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117635"},
        {"Smithsonian Astrophysical Observation", "SAO 214818"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.84665193),
        dec: Angle.Degrees(-31.61807324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4660"},
        {"Hipparcos Number", "HIP 3769"},
        {"Smithsonian Astrophysical Observation", "SAO 192754"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.09806611),
        dec: Angle.Degrees(-31.61790456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38064"},
        {"Geneva Identification System", "GEN# -0.03105083"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.01663424),
        dec: Angle.Degrees(-31.61786168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63638"},
        {"Hipparcos Number", "HIP 38118"},
        {"Geneva Identification System", "GEN# +1.00063638"},
        {"Smithsonian Astrophysical Observation", "SAO 198469"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.17387021),
        dec: Angle.Degrees(-31.61783734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221522"},
        {"Hipparcos Number", "HIP 116235"},
        {"Smithsonian Astrophysical Observation", "SAO 214616"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.25649619),
        dec: Angle.Degrees(-31.61757465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89643"},
        {"Hipparcos Number", "HIP 50591"},
        {"Smithsonian Astrophysical Observation", "SAO 201288"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.02452274),
        dec: Angle.Degrees(-31.61577037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153855"},
        {"Hipparcos Number", "HIP 83448"},
        {"Geneva Identification System", "GEN# +1.00153855"},
        {"Smithsonian Astrophysical Observation", "SAO 208347"},
        {"Wilson Evans Batten Catalogue", "WEB 14104"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.82473389),
        dec: Angle.Degrees(-31.61460855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188432"},
        {"Hipparcos Number", "HIP 98108"},
        {"Geneva Identification System", "GEN# +1.00188432"},
        {"Smithsonian Astrophysical Observation", "SAO 211668"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.06952246),
        dec: Angle.Degrees(-31.61310091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146592"},
        {"Hipparcos Number", "HIP 79873"},
        {"Smithsonian Astrophysical Observation", "SAO 207527"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.55599593),
        dec: Angle.Degrees(-31.61222681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113820"},
        {"Hipparcos Number", "HIP 63981"},
        {"Smithsonian Astrophysical Observation", "SAO 204128"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.65779061),
        dec: Angle.Degrees(-31.61179438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184648"},
        {"Hipparcos Number", "HIP 96460"},
        {"Smithsonian Astrophysical Observation", "SAO 211407"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.16142265),
        dec: Angle.Degrees(-31.61124264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114937"},
        {"Hipparcos Number", "HIP 64579"},
        {"Smithsonian Astrophysical Observation", "SAO 204266"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.54853577),
        dec: Angle.Degrees(-31.60922942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185386"},
        {"Hipparcos Number", "HIP 96750"},
        {"Smithsonian Astrophysical Observation", "SAO 211460"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.01402844),
        dec: Angle.Degrees(-31.60877283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121415"},
        {"Hipparcos Number", "HIP 68039"},
        {"Smithsonian Astrophysical Observation", "SAO 204998"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.97405286),
        dec: Angle.Degrees(-31.60807823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70796"},
        {"Hipparcos Number", "HIP 41065"},
        {"Celescope Catalog", "CEL 2438"},
        {"Geneva Identification System", "GEN# +1.00070796"},
        {"Smithsonian Astrophysical Observation", "SAO 199148"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.69058070),
        dec: Angle.Degrees(-31.60755329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145010"},
        {"Hipparcos Number", "HIP 79198"},
        {"Smithsonian Astrophysical Observation", "SAO 207404"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.46612517),
        dec: Angle.Degrees(-31.60403719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93554"},
        {"Hipparcos Number", "HIP 52789"},
        {"Smithsonian Astrophysical Observation", "SAO 201750"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.88921037),
        dec: Angle.Degrees(-31.60322623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140329"},
        {"Hipparcos Number", "HIP 77059"},
        {"Smithsonian Astrophysical Observation", "SAO 206919"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.01707089),
        dec: Angle.Degrees(-31.60313195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23561"},
        {"Hipparcos Number", "HIP 17509"},
        {"Smithsonian Astrophysical Observation", "SAO 194502"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.24226719),
        dec: Angle.Degrees(-31.60102398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196917"},
        {"Hipparcos Number", "HIP 102092"},
        {"Fundamental Katalog 5th Edition", "FK5 3652"},
        {"Geneva Identification System", "GEN# +1.00196917"},
        {"Smithsonian Astrophysical Observation", "SAO 212345"},
        {"Wilson Evans Batten Catalogue", "WEB 18464"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.34826007),
        dec: Angle.Degrees(-31.59814237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222777"},
        {"Hipparcos Number", "HIP 117051"},
        {"Smithsonian Astrophysical Observation", "SAO 214739"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.92717130),
        dec: Angle.Degrees(-31.59460591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13351"},
        {"Hipparcos Number", "HIP 10083"},
        {"Smithsonian Astrophysical Observation", "SAO 193543"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.41635852),
        dec: Angle.Degrees(-31.59434884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153320"},
        {"Hipparcos Number", "HIP 83177"},
        {"Smithsonian Astrophysical Observation", "SAO 208283"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.99901590),
        dec: Angle.Degrees(-31.59335416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132852"},
        {"Hipparcos Number", "HIP 73573"},
        {"Smithsonian Astrophysical Observation", "SAO 206230"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.55987767),
        dec: Angle.Degrees(-31.59146758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47061"},
        {"Hipparcos Number", "HIP 31463"},
        {"Celescope Catalog", "CEL 1312"},
        {"Geneva Identification System", "GEN# +1.00047061"},
        {"Smithsonian Astrophysical Observation", "SAO 196976"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.86296000),
        dec: Angle.Degrees(-31.59143402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28699"},
    },
    visualMagnitude: 13.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.91074238),
        dec: Angle.Degrees(-31.59028423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35227"},
        {"Hipparcos Number", "HIP 25062"},
        {"Smithsonian Astrophysical Observation", "SAO 195779"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.48447694),
        dec: Angle.Degrees(-31.58998438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32856"},
        {"Hipparcos Number", "HIP 23628"},
        {"Geneva Identification System", "GEN# +1.00032856"},
        {"Smithsonian Astrophysical Observation", "SAO 195541"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.20209027),
        dec: Angle.Degrees(-31.58807026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60769"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.85111391),
        dec: Angle.Degrees(-31.58738681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89659"},
        {"Hipparcos Number", "HIP 50599"},
        {"Smithsonian Astrophysical Observation", "SAO 201292"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.04994065),
        dec: Angle.Degrees(-31.58295596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155128"},
        {"Hipparcos Number", "HIP 84055"},
        {"Smithsonian Astrophysical Observation", "SAO 208503"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.76433660),
        dec: Angle.Degrees(-31.58281743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 318301"},
        {"Hipparcos Number", "HIP 87022"},
        {"Geneva Identification System", "GEN# +2.64250050"},
        {"New General Catalogue", "NGC 6425 50"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.71892227),
        dec: Angle.Degrees(-31.58163801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26729"},
        {"Hipparcos Number", "HIP 19633"},
        {"Geneva Identification System", "GEN# +1.00026729"},
        {"Smithsonian Astrophysical Observation", "SAO 194827"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.09829565),
        dec: Angle.Degrees(-31.58085257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175759"},
        {"Hipparcos Number", "HIP 93120"},
        {"Geneva Identification System", "GEN# +1.00175759"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.54855959),
        dec: Angle.Degrees(-31.57905410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199591"},
        {"Hipparcos Number", "HIP 103585"},
        {"Smithsonian Astrophysical Observation", "SAO 212595"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.81878160),
        dec: Angle.Degrees(-31.57702129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5711"},
        {"Smithsonian Astrophysical Observation", "SAO 192990"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.36584367),
        dec: Angle.Degrees(-31.57453992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43784"},
        {"Hipparcos Number", "HIP 29821"},
        {"Smithsonian Astrophysical Observation", "SAO 196647"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.20762953),
        dec: Angle.Degrees(-31.57138560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22054"},
        {"Hipparcos Number", "HIP 16481"},
        {"Geneva Identification System", "GEN# +1.00022054"},
        {"Smithsonian Astrophysical Observation", "SAO 194360"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.05486599),
        dec: Angle.Degrees(-31.57057783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209786"},
        {"Hipparcos Number", "HIP 109151"},
        {"Smithsonian Astrophysical Observation", "SAO 213547"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.64585963),
        dec: Angle.Degrees(-31.56948973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190528"},
        {"Hipparcos Number", "HIP 99038"},
        {"Geneva Identification System", "GEN# +1.00190528"},
        {"Smithsonian Astrophysical Observation", "SAO 211810"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.61673517),
        dec: Angle.Degrees(-31.56882544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84274"},
        {"Hipparcos Number", "HIP 47678"},
        {"Smithsonian Astrophysical Observation", "SAO 200661"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.82546682),
        dec: Angle.Degrees(-31.56871638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113258"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.02431419),
        dec: Angle.Degrees(-31.56826106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31103"},
        {"Hipparcos Number", "HIP 22589"},
        {"Geneva Identification System", "GEN# +1.00031103"},
        {"Smithsonian Astrophysical Observation", "SAO 195358"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.91881683),
        dec: Angle.Degrees(-31.56726202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35974"},
        {"Hipparcos Number", "HIP 25490"},
        {"Geneva Identification System", "GEN# +1.00035974"},
        {"Smithsonian Astrophysical Observation", "SAO 195865"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.77789398),
        dec: Angle.Degrees(-31.56626467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17636"},
        {"Hipparcos Number", "HIP 13131"},
        {"Smithsonian Astrophysical Observation", "SAO 193929"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.22535003),
        dec: Angle.Degrees(-31.56584221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113283",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Fomalhaut B"},
        {"Henry Draper", "HD 216803"},
        {"Hipparcos Number", "HIP 113283"},
        {"Cincinnati Publication", "Ci 18 2996"},
        {"Geneva Identification System", "GEN# +1.00216803"},
        {"Smithsonian Astrophysical Observation", "SAO 214197"},
        {"Wilson Evans Batten Catalogue", "WEB 20154"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.09927760),
        dec: Angle.Degrees(-31.56517871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 330.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12732"},
        {"Hipparcos Number", "HIP 9650"},
        {"Smithsonian Astrophysical Observation", "SAO 193484"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.00607030),
        dec: Angle.Degrees(-31.56433615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95078"},
        {"Hipparcos Number", "HIP 53623"},
        {"Smithsonian Astrophysical Observation", "SAO 201953"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.55925164),
        dec: Angle.Degrees(-31.56359260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18001"},
        {"Hipparcos Number", "HIP 13411"},
        {"Geneva Identification System", "GEN# +1.00018001"},
        {"Smithsonian Astrophysical Observation", "SAO 193957"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.17120022),
        dec: Angle.Degrees(-31.56244034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20748"},
        {"Hipparcos Number", "HIP 15469"},
        {"Smithsonian Astrophysical Observation", "SAO 194230"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.86429178),
        dec: Angle.Degrees(-31.56109415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53622"},
        {"Smithsonian Astrophysical Observation", "SAO 201952"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.55793825),
        dec: Angle.Degrees(-31.56098906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113722"},
        {"Hipparcos Number", "HIP 63922"},
        {"Smithsonian Astrophysical Observation", "SAO 204122"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.49313009),
        dec: Angle.Degrees(-31.56019870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170144"},
        {"Hipparcos Number", "HIP 90605"},
        {"Geneva Identification System", "GEN# +1.00170144"},
        {"Smithsonian Astrophysical Observation", "SAO 210220"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.33024723),
        dec: Angle.Degrees(-31.55858203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95985"},
        {"Hipparcos Number", "HIP 54076"},
        {"Smithsonian Astrophysical Observation", "SAO 202049"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.98195915),
        dec: Angle.Degrees(-31.55754951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105917"},
        {"Hipparcos Number", "HIP 59436"},
        {"Smithsonian Astrophysical Observation", "SAO 203216"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.87769629),
        dec: Angle.Degrees(-31.55701667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212801"},
        {"Hipparcos Number", "HIP 110853"},
        {"Geneva Identification System", "GEN# +1.00212801"},
        {"Smithsonian Astrophysical Observation", "SAO 213830"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.87970022),
        dec: Angle.Degrees(-31.55412898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144550"},
        {"Hipparcos Number", "HIP 78998"},
        {"Geneva Identification System", "GEN# +1.00144550"},
        {"Smithsonian Astrophysical Observation", "SAO 207351"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.89334435),
        dec: Angle.Degrees(-31.55233177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6178"},
        {"Hipparcos Number", "HIP 4852"},
        {"Fundamental Katalog 5th Edition", "FK5 1026"},
        {"Geneva Identification System", "GEN# +1.00006178"},
        {"Renson", "Renson 1584"},
        {"Smithsonian Astrophysical Observation", "SAO 192884"},
        {"Wilson Evans Batten Catalogue", "WEB 938"},
    },
    visualMagnitude: 5.50,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.60990729),
        dec: Angle.Degrees(-31.55204219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39452"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.96129628),
        dec: Angle.Degrees(-31.55193915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 143.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8628"},
        {"Hipparcos Number", "HIP 6587"},
        {"Smithsonian Astrophysical Observation", "SAO 193099"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.15753043),
        dec: Angle.Degrees(-31.55046517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82314"},
        {"Hipparcos Number", "HIP 46617"},
        {"Geneva Identification System", "GEN# +1.00082314"},
        {"Smithsonian Astrophysical Observation", "SAO 200436"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.59150095),
        dec: Angle.Degrees(-31.55002771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69001"},
        {"Hipparcos Number", "HIP 40296"},
        {"Geneva Identification System", "GEN# +1.00069001"},
        {"Smithsonian Astrophysical Observation", "SAO 198961"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.43295794),
        dec: Angle.Degrees(-31.54925064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158705"},
        {"Hipparcos Number", "HIP 85816"},
        {"Geneva Identification System", "GEN# +1.00158705"},
        {"Smithsonian Astrophysical Observation", "SAO 208928"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.02968988),
        dec: Angle.Degrees(-31.54909465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208771"},
        {"Hipparcos Number", "HIP 108530"},
        {"Smithsonian Astrophysical Observation", "SAO 213451"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.79389640),
        dec: Angle.Degrees(-31.54799960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204802"},
        {"Hipparcos Number", "HIP 106304"},
        {"Geneva Identification System", "GEN# +1.00204802"},
        {"Smithsonian Astrophysical Observation", "SAO 213072"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.95618188),
        dec: Angle.Degrees(-31.54768860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143428"},
        {"Hipparcos Number", "HIP 78487"},
        {"Renson", "Renson 40610"},
        {"Smithsonian Astrophysical Observation", "SAO 207236"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.33595876),
        dec: Angle.Degrees(-31.54612814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66791"},
        {"Hipparcos Number", "HIP 39457"},
        {"Smithsonian Astrophysical Observation", "SAO 198755"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.97434257),
        dec: Angle.Degrees(-31.54461816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 148.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132761"},
        {"Hipparcos Number", "HIP 73535"},
        {"Geneva Identification System", "GEN# +1.00132761"},
        {"Smithsonian Astrophysical Observation", "SAO 206222"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.45293977),
        dec: Angle.Degrees(-31.54393363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 318064"},
        {"Hipparcos Number", "HIP 86512"},
        {"Wilson Evans Batten Catalogue", "WEB 14592"},
    },
    visualMagnitude: 11.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.20199192),
        dec: Angle.Degrees(-31.54214297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92397"},
        {"Smithsonian Astrophysical Observation", "SAO 210608"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.43508843),
        dec: Angle.Degrees(-31.54074370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163556"},
        {"Hipparcos Number", "HIP 87966"},
        {"Geneva Identification System", "GEN# +1.00163556"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.53284742),
        dec: Angle.Degrees(-31.53991351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109768"},
        {"Hipparcos Number", "HIP 61603"},
        {"Smithsonian Astrophysical Observation", "SAO 203641"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.35359300),
        dec: Angle.Degrees(-31.53736652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136500"},
        {"Hipparcos Number", "HIP 75200"},
        {"Smithsonian Astrophysical Observation", "SAO 206558"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.51148044),
        dec: Angle.Degrees(-31.53598297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34848"},
        {"Hipparcos Number", "HIP 24814"},
        {"Smithsonian Astrophysical Observation", "SAO 195743"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.78930947),
        dec: Angle.Degrees(-31.53476737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64898"},
        {"Hipparcos Number", "HIP 38652"},
        {"Celescope Catalog", "CEL 2092"},
        {"Geneva Identification System", "GEN# +1.00064898"},
        {"Smithsonian Astrophysical Observation", "SAO 198583"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.71353984),
        dec: Angle.Degrees(-31.53476516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158186"},
        {"Hipparcos Number", "HIP 85569"},
        {"Geneva Identification System", "GEN# +1.00158186"},
        {"Smithsonian Astrophysical Observation", "SAO 208869"},
        {"Wilson Evans Batten Catalogue", "WEB 14443"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.30385140),
        dec: Angle.Degrees(-31.53428573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214855"},
        {"Hipparcos Number", "HIP 112035"},
        {"Smithsonian Astrophysical Observation", "SAO 214013"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.38713770),
        dec: Angle.Degrees(-31.53278399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166058"},
        {"Hipparcos Number", "HIP 89035"},
        {"Smithsonian Astrophysical Observation", "SAO 209805"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.58385965),
        dec: Angle.Degrees(-31.53252500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40195"},
        {"Hipparcos Number", "HIP 28060"},
        {"Smithsonian Astrophysical Observation", "SAO 196322"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.99537314),
        dec: Angle.Degrees(-31.53205163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90169"},
        {"Hipparcos Number", "HIP 50924"},
        {"Smithsonian Astrophysical Observation", "SAO 201355"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.00536685),
        dec: Angle.Degrees(-31.52947058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79361"},
        {"Hipparcos Number", "HIP 45198"},
        {"Smithsonian Astrophysical Observation", "SAO 200100"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.15818923),
        dec: Angle.Degrees(-31.52931868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139105"},
        {"Hipparcos Number", "HIP 76499"},
        {"Smithsonian Astrophysical Observation", "SAO 206814"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.36328717),
        dec: Angle.Degrees(-31.52671946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53781"},
        {"Hipparcos Number", "HIP 34161"},
        {"Smithsonian Astrophysical Observation", "SAO 197545"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.25089501),
        dec: Angle.Degrees(-31.52606652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208886"},
        {"Hipparcos Number", "HIP 108597"},
        {"Geneva Identification System", "GEN# +1.00208886"},
        {"Smithsonian Astrophysical Observation", "SAO 213466"},
    },
    visualMagnitude: 7.06,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.98142431),
        dec: Angle.Degrees(-31.52568919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16087"},
        {"Hipparcos Number", "HIP 11950"},
        {"Geneva Identification System", "GEN# +1.00016087"},
        {"Smithsonian Astrophysical Observation", "SAO 193774"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.54393155),
        dec: Angle.Degrees(-31.52376733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163273"},
        {"Hipparcos Number", "HIP 87839"},
        {"Geneva Identification System", "GEN# +1.00163273"},
        {"Smithsonian Astrophysical Observation", "SAO 209502"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.17858376),
        dec: Angle.Degrees(-31.52171871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98753"},
        {"Hipparcos Number", "HIP 55469"},
        {"Geneva Identification System", "GEN# +1.00098753"},
        {"Smithsonian Astrophysical Observation", "SAO 202356"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.39771652),
        dec: Angle.Degrees(-31.52160721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191303"},
        {"Hipparcos Number", "HIP 99384"},
        {"Smithsonian Astrophysical Observation", "SAO 211875"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.57906517),
        dec: Angle.Degrees(-31.52125637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61478"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.95885668),
        dec: Angle.Degrees(-31.51975943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42833"},
        {"Hipparcos Number", "HIP 29380"},
        {"Geneva Identification System", "GEN# +1.00042833"},
        {"Smithsonian Astrophysical Observation", "SAO 196574"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.88695990),
        dec: Angle.Degrees(-31.51947740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135153"},
        {"Hipparcos Number", "HIP 74604"},
        {"Fundamental Katalog 5th Edition", "FK5 1399"},
        {"Geneva Identification System", "GEN# +1.00135153"},
        {"Smithsonian Astrophysical Observation", "SAO 206445"},
        {"Wilson Evans Batten Catalogue", "WEB 12732"},
    },
    visualMagnitude: 4.91,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.65552450),
        dec: Angle.Degrees(-31.51912564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28869"},
        {"Hipparcos Number", "HIP 21121"},
        {"Geneva Identification System", "GEN# +1.00028869"},
        {"Smithsonian Astrophysical Observation", "SAO 195103"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.89962035),
        dec: Angle.Degrees(-31.51898828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106179"},
        {"Hipparcos Number", "HIP 59580"},
        {"Smithsonian Astrophysical Observation", "SAO 203243"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.26888519),
        dec: Angle.Degrees(-31.51840144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10328"},
        {"Hipparcos Number", "HIP 7798"},
        {"Smithsonian Astrophysical Observation", "SAO 193243"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.09255114),
        dec: Angle.Degrees(-31.51802661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38610"},
        {"Hipparcos Number", "HIP 27184"},
        {"Geneva Identification System", "GEN# +1.00038610"},
        {"Smithsonian Astrophysical Observation", "SAO 196146"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.42062054),
        dec: Angle.Degrees(-31.51536543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158663"},
        {"Hipparcos Number", "HIP 85797"},
        {"Geneva Identification System", "GEN# +1.00158663"},
        {"Smithsonian Astrophysical Observation", "SAO 208924"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.96697619),
        dec: Angle.Degrees(-31.51494764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198696"},
        {"Hipparcos Number", "HIP 103082"},
        {"Geneva Identification System", "GEN# +1.00198696"},
        {"Smithsonian Astrophysical Observation", "SAO 212518"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.29584064),
        dec: Angle.Degrees(-31.51492287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59306"},
    },
    visualMagnitude: 10.77,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.50300106),
        dec: Angle.Degrees(-31.50997551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104701"},
        {"Hipparcos Number", "HIP 58787"},
        {"Smithsonian Astrophysical Observation", "SAO 203078"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.85611021),
        dec: Angle.Degrees(-31.50963787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85449"},
        {"Hipparcos Number", "HIP 48328"},
        {"Geneva Identification System", "GEN# +1.00085449"},
        {"Smithsonian Astrophysical Observation", "SAO 200804"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.76610378),
        dec: Angle.Degrees(-31.50963190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141641"},
        {"Hipparcos Number", "HIP 77657"},
        {"Geneva Identification System", "GEN# +1.00141641"},
        {"Renson", "Renson 40220"},
        {"Smithsonian Astrophysical Observation", "SAO 207045"},
    },
    visualMagnitude: 8.96,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.81037914),
        dec: Angle.Degrees(-31.50743818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115310"},
        {"Hipparcos Number", "HIP 64803"},
        {"Fundamental Katalog 5th Edition", "FK5 1342"},
        {"Geneva Identification System", "GEN# +1.00115310"},
        {"Smithsonian Astrophysical Observation", "SAO 204312"},
        {"Wilson Evans Batten Catalogue", "WEB 11454"},
    },
    visualMagnitude: 5.10,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.22129667),
        dec: Angle.Degrees(-31.50607670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199090"},
        {"Hipparcos Number", "HIP 103315"},
        {"Smithsonian Astrophysical Observation", "SAO 212550"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.97680001),
        dec: Angle.Degrees(-31.50565810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136931"},
        {"Hipparcos Number", "HIP 75404"},
        {"Smithsonian Astrophysical Observation", "SAO 206594"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.10957473),
        dec: Angle.Degrees(-31.50505168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10397"},
        {"Hipparcos Number", "HIP 7847"},
        {"Smithsonian Astrophysical Observation", "SAO 193250"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.22216221),
        dec: Angle.Degrees(-31.50471099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150418"},
        {"Hipparcos Number", "HIP 81775"},
        {"Smithsonian Astrophysical Observation", "SAO 207940"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.54321902),
        dec: Angle.Degrees(-31.50411175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98775"},
        {"Smithsonian Astrophysical Observation", "SAO 211775"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.91631221),
        dec: Angle.Degrees(-31.50347151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72673"},
        {"Hipparcos Number", "HIP 41926"},
        {"Cincinnati Publication", "Ci 20 476"},
        {"Geneva Identification System", "GEN# +1.00072673"},
        {"Smithsonian Astrophysical Observation", "SAO 199352"},
        {"Wilson Evans Batten Catalogue", "WEB 8069"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.21774079),
        dec: Angle.Degrees(-31.50270424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1113.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 761.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60837"},
        {"Hipparcos Number", "HIP 36897"},
        {"Smithsonian Astrophysical Observation", "SAO 198151"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.79000103),
        dec: Angle.Degrees(-31.50235473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 211.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210850"},
        {"Hipparcos Number", "HIP 109760"},
        {"Smithsonian Astrophysical Observation", "SAO 213652"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.47353754),
        dec: Angle.Degrees(-31.50209847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169378"},
        {"Hipparcos Number", "HIP 90322"},
        {"Smithsonian Astrophysical Observation", "SAO 210133"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.43424807),
        dec: Angle.Degrees(-31.50144664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49109"},
        {"Hipparcos Number", "HIP 32388"},
        {"Smithsonian Astrophysical Observation", "SAO 197180"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.39145239),
        dec: Angle.Degrees(-31.50084045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153318"},
        {"Hipparcos Number", "HIP 83182"},
        {"Smithsonian Astrophysical Observation", "SAO 208285"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.00991134),
        dec: Angle.Degrees(-31.50032559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200916"},
        {"Hipparcos Number", "HIP 104267"},
        {"Geneva Identification System", "GEN# +1.00200916"},
        {"Smithsonian Astrophysical Observation", "SAO 212726"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.84495210),
        dec: Angle.Degrees(-31.49963841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126369"},
        {"Hipparcos Number", "HIP 70540"},
        {"Smithsonian Astrophysical Observation", "SAO 205547"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.45425301),
        dec: Angle.Degrees(-31.49932375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39544"},
        {"Hipparcos Number", "HIP 27708"},
        {"Smithsonian Astrophysical Observation", "SAO 196256"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.00699519),
        dec: Angle.Degrees(-31.49769243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9026"},
        {"Hipparcos Number", "HIP 6866"},
        {"Geneva Identification System", "GEN# +1.00009026"},
        {"Smithsonian Astrophysical Observation", "SAO 193129"},
        {"Wilson Evans Batten Catalogue", "WEB 1500"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.08968229),
        dec: Angle.Degrees(-31.49576360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107006"},
        {"Hipparcos Number", "HIP 60007"},
        {"Geneva Identification System", "GEN# +1.00107006"},
        {"Smithsonian Astrophysical Observation", "SAO 203331"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.60279291),
        dec: Angle.Degrees(-31.49509042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56162"},
        {"Hipparcos Number", "HIP 35014"},
        {"Geneva Identification System", "GEN# +5.11320012J"},
        {"Smithsonian Astrophysical Observation", "SAO 197736"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.64545082),
        dec: Angle.Degrees(-31.49347258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201391"},
        {"Hipparcos Number", "HIP 104511"},
        {"Geneva Identification System", "GEN# +1.00201391"},
        {"Smithsonian Astrophysical Observation", "SAO 212766"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.54587667),
        dec: Angle.Degrees(-31.49174868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149513"},
        {"Hipparcos Number", "HIP 81324"},
        {"Smithsonian Astrophysical Observation", "SAO 207821"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.14542192),
        dec: Angle.Degrees(-31.49022080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221312"},
        {"Hipparcos Number", "HIP 116074"},
        {"Geneva Identification System", "GEN# +1.00221312"},
        {"Smithsonian Astrophysical Observation", "SAO 214598"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.80636963),
        dec: Angle.Degrees(-31.48987302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164418"},
        {"Hipparcos Number", "HIP 88336"},
        {"Geneva Identification System", "GEN# +1.00164418"},
        {"Smithsonian Astrophysical Observation", "SAO 209630"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.60479122),
        dec: Angle.Degrees(-31.48975340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30193"},
        {"Hipparcos Number", "HIP 22023"},
        {"Geneva Identification System", "GEN# +1.00030193"},
        {"Smithsonian Astrophysical Observation", "SAO 195257"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.02061184),
        dec: Angle.Degrees(-31.48606250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119377"},
        {"Hipparcos Number", "HIP 66965"},
        {"Smithsonian Astrophysical Observation", "SAO 204774"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.87420410),
        dec: Angle.Degrees(-31.48487855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35664"},
        {"Hipparcos Number", "HIP 25332"},
        {"Geneva Identification System", "GEN# +1.00035664"},
        {"Smithsonian Astrophysical Observation", "SAO 195831"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.26849437),
        dec: Angle.Degrees(-31.48473473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176494"},
        {"Hipparcos Number", "HIP 93450"},
        {"Smithsonian Astrophysical Observation", "SAO 210839"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.47514110),
        dec: Angle.Degrees(-31.48397379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132077"},
        {"Hipparcos Number", "HIP 73246"},
        {"Smithsonian Astrophysical Observation", "SAO 206145"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.54680642),
        dec: Angle.Degrees(-31.48377250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112305"},
        {"Hipparcos Number", "HIP 63123"},
        {"Smithsonian Astrophysical Observation", "SAO 203947"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.00632371),
        dec: Angle.Degrees(-31.48206193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89037"},
        {"Hipparcos Number", "HIP 50256"},
        {"Smithsonian Astrophysical Observation", "SAO 201218"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.92779786),
        dec: Angle.Degrees(-31.48120739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45364"},
        {"Hipparcos Number", "HIP 30579"},
        {"Geneva Identification System", "GEN# +1.00045364"},
        {"Smithsonian Astrophysical Observation", "SAO 196806"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.41016085),
        dec: Angle.Degrees(-31.48092438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118220",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118220"},
        {"Smithsonian Astrophysical Observation", "SAO 214893"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.70306107),
        dec: Angle.Degrees(-31.47977078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192089"},
        {"Hipparcos Number", "HIP 99739"},
        {"Smithsonian Astrophysical Observation", "SAO 211927"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.56396216),
        dec: Angle.Degrees(-31.47971981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117505"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.42578668),
        dec: Angle.Degrees(-31.47919583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131118"},
        {"Hipparcos Number", "HIP 72788"},
        {"Smithsonian Astrophysical Observation", "SAO 206036"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.16768351),
        dec: Angle.Degrees(-31.47878877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102787"},
        {"Hipparcos Number", "HIP 57691"},
        {"Smithsonian Astrophysical Observation", "SAO 202847"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.46971999),
        dec: Angle.Degrees(-31.47871621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212324"},
        {"Hipparcos Number", "HIP 110575"},
        {"Smithsonian Astrophysical Observation", "SAO 213786"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.00827494),
        dec: Angle.Degrees(-31.47848510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 475"},
        {"Hipparcos Number", "HIP 749"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.29783513),
        dec: Angle.Degrees(-31.47728797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137728"},
        {"Hipparcos Number", "HIP 75772"},
        {"Smithsonian Astrophysical Observation", "SAO 206688"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.19192598),
        dec: Angle.Degrees(-31.47566749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74977"},
        {"Hipparcos Number", "HIP 43051"},
        {"Smithsonian Astrophysical Observation", "SAO 199595"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.56641791),
        dec: Angle.Degrees(-31.47155084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114385"},
        {"Hipparcos Number", "HIP 64292"},
        {"Smithsonian Astrophysical Observation", "SAO 204192"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.65139337),
        dec: Angle.Degrees(-31.47065587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152635"},
        {"Hipparcos Number", "HIP 82848"},
        {"Geneva Identification System", "GEN# +1.00152635"},
        {"Smithsonian Astrophysical Observation", "SAO 208204"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.96771812),
        dec: Angle.Degrees(-31.46981084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167617"},
        {"Hipparcos Number", "HIP 89629"},
        {"Smithsonian Astrophysical Observation", "SAO 209956"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.36896998),
        dec: Angle.Degrees(-31.46967184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16785"},
        {"Hipparcos Number", "HIP 12463"},
        {"Geneva Identification System", "GEN# +1.00016785"},
        {"Smithsonian Astrophysical Observation", "SAO 193848"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.12753163),
        dec: Angle.Degrees(-31.46741192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112261"},
        {"Hipparcos Number", "HIP 63097"},
        {"Smithsonian Astrophysical Observation", "SAO 203941"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.91452117),
        dec: Angle.Degrees(-31.46275668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171033"},
        {"Hipparcos Number", "HIP 91002"},
        {"Smithsonian Astrophysical Observation", "SAO 210311"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.46225326),
        dec: Angle.Degrees(-31.46101777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60394"},
        {"Hipparcos Number", "HIP 36699"},
        {"Smithsonian Astrophysical Observation", "SAO 198114"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.23816912),
        dec: Angle.Degrees(-31.46077285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9290"},
        {"Hipparcos Number", "HIP 7045"},
        {"Geneva Identification System", "GEN# +1.00009290"},
        {"Smithsonian Astrophysical Observation", "SAO 193154"},
        {"Wilson Evans Batten Catalogue", "WEB 1521"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.70854339),
        dec: Angle.Degrees(-31.46053005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135728"},
        {"Hipparcos Number", "HIP 74836"},
        {"Geneva Identification System", "GEN# +1.00135728"},
        {"Renson", "Renson 38550"},
        {"Smithsonian Astrophysical Observation", "SAO 206494"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.41187680),
        dec: Angle.Degrees(-31.45891477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144115"},
        {"Hipparcos Number", "HIP 78817"},
        {"Renson", "Renson 40830"},
        {"Smithsonian Astrophysical Observation", "SAO 207315"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.34939449),
        dec: Angle.Degrees(-31.45684229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59550"},
        {"Hipparcos Number", "HIP 36362"},
        {"Geneva Identification System", "GEN# +1.00059550"},
        {"Smithsonian Astrophysical Observation", "SAO 198042"},
        {"Wilson Evans Batten Catalogue", "WEB 7235"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.27050532),
        dec: Angle.Degrees(-31.45622952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28510"},
        {"Hipparcos Number", "HIP 20870"},
        {"Geneva Identification System", "GEN# +1.00028510"},
        {"Smithsonian Astrophysical Observation", "SAO 195044"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.09185564),
        dec: Angle.Degrees(-31.45599021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197836"},
        {"Hipparcos Number", "HIP 102578"},
        {"Geneva Identification System", "GEN# +1.00197836"},
        {"Smithsonian Astrophysical Observation", "SAO 212431"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.81087617),
        dec: Angle.Degrees(-31.45584709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134612"},
        {"Hipparcos Number", "HIP 74365"},
        {"Smithsonian Astrophysical Observation", "SAO 206388"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.95775227),
        dec: Angle.Degrees(-31.45476410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83042"},
    },
    visualMagnitude: 9.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.53494255),
        dec: Angle.Degrees(-30.21621788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31652"},
        {"Smithsonian Astrophysical Observation", "SAO 197015"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.37311825),
        dec: Angle.Degrees(-31.45404857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61470"},
        {"Hipparcos Number", "HIP 37158"},
        {"Geneva Identification System", "GEN# +1.00061470"},
        {"Smithsonian Astrophysical Observation", "SAO 198216"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.54608889),
        dec: Angle.Degrees(-31.45324657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63488"},
    },
    visualMagnitude: 12.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.12877471),
        dec: Angle.Degrees(-31.45108102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36943"},
        {"Hipparcos Number", "HIP 26084"},
        {"Smithsonian Astrophysical Observation", "SAO 195964"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.44781001),
        dec: Angle.Degrees(-31.45081294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116820"},
        {"Hipparcos Number", "HIP 65567"},
        {"Smithsonian Astrophysical Observation", "SAO 204478"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.64796548),
        dec: Angle.Degrees(-31.45043133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1187"},
        {"Hipparcos Number", "HIP 1288"},
        {"Fundamental Katalog 5th Edition", "FK5 2014"},
        {"Geneva Identification System", "GEN# +1.00001187"},
        {"Smithsonian Astrophysical Observation", "SAO 192430"},
        {"Wilson Evans Batten Catalogue", "WEB 226"},
    },
    visualMagnitude: 5.66,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.03660680),
        dec: Angle.Degrees(-31.44632821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25334"},
        {"Hipparcos Number", "HIP 18695"},
        {"Smithsonian Astrophysical Observation", "SAO 194682"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.07906307),
        dec: Angle.Degrees(-31.44544857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209336"},
        {"Hipparcos Number", "HIP 108869"},
        {"Geneva Identification System", "GEN# +1.00209336"},
        {"Smithsonian Astrophysical Observation", "SAO 213500"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.81984222),
        dec: Angle.Degrees(-31.44514741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129"},
        {"Hipparcos Number", "HIP 509"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.52168260),
        dec: Angle.Degrees(-31.44433776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119376"},
        {"Hipparcos Number", "HIP 66961"},
        {"Geneva Identification System", "GEN# +1.00119376"},
        {"Smithsonian Astrophysical Observation", "SAO 204771"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.86282510),
        dec: Angle.Degrees(-31.44426213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114726"},
        {"Smithsonian Astrophysical Observation", "SAO 214398"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.59431131),
        dec: Angle.Degrees(-31.44397128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91643"},
        {"Smithsonian Astrophysical Observation", "SAO 210463"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.33201445),
        dec: Angle.Degrees(-31.44346453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163779"},
        {"Hipparcos Number", "HIP 88072"},
        {"Smithsonian Astrophysical Observation", "SAO 209558"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.81458138),
        dec: Angle.Degrees(-31.44212382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86248"},
        {"Hipparcos Number", "HIP 48745"},
        {"Geneva Identification System", "GEN# +1.00086248"},
        {"Smithsonian Astrophysical Observation", "SAO 200887"},
    },
    visualMagnitude: 9.63,
    bvColour: -0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.13858669),
        dec: Angle.Degrees(-31.44198055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39443"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.94913066),
        dec: Angle.Degrees(-31.44107195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70837"},
        {"Hipparcos Number", "HIP 41089"},
        {"Celescope Catalog", "CEL 2442"},
        {"Geneva Identification System", "GEN# +1.00070837"},
        {"Smithsonian Astrophysical Observation", "SAO 199153"},
    },
    visualMagnitude: 8.99,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.74510825),
        dec: Angle.Degrees(-31.44087630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23418"},
        {"Hipparcos Number", "HIP 17415"},
        {"Geneva Identification System", "GEN# +1.00023418"},
        {"Smithsonian Astrophysical Observation", "SAO 194487"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.97398458),
        dec: Angle.Degrees(-31.44065349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110360"},
        {"Smithsonian Astrophysical Observation", "SAO 213759"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.28229938),
        dec: Angle.Degrees(-31.44063178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41092"},
    },
    visualMagnitude: 9.41,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.74977526),
        dec: Angle.Degrees(-31.43844706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198005"},
        {"Hipparcos Number", "HIP 102690"},
        {"Smithsonian Astrophysical Observation", "SAO 212453"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.11585251),
        dec: Angle.Degrees(-31.43690712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31460"},
        {"Hipparcos Number", "HIP 22824"},
        {"Cincinnati Publication", "Ci 18 632"},
        {"Geneva Identification System", "GEN# +1.00031460"},
        {"Smithsonian Astrophysical Observation", "SAO 195394"},
        {"Wilson Evans Batten Catalogue", "WEB 4419"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.67724443),
        dec: Angle.Degrees(-31.43311321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -270.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123018"},
        {"Hipparcos Number", "HIP 68858"},
        {"Smithsonian Astrophysical Observation", "SAO 205177"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.50411436),
        dec: Angle.Degrees(-31.43169979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31845"},
        {"Smithsonian Astrophysical Observation", "SAO 197053"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.87613471),
        dec: Angle.Degrees(-31.43058495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57085"},
    },
    visualMagnitude: 11.60,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.54110387),
        dec: Angle.Degrees(-31.43029154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186696"},
        {"Hipparcos Number", "HIP 97346"},
        {"Smithsonian Astrophysical Observation", "SAO 211550"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.77544505),
        dec: Angle.Degrees(-31.42930194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180180"},
        {"Hipparcos Number", "HIP 94750"},
        {"Smithsonian Astrophysical Observation", "SAO 211123"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.19936994),
        dec: Angle.Degrees(-31.42854082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143165"},
        {"Hipparcos Number", "HIP 78371"},
        {"Smithsonian Astrophysical Observation", "SAO 207210"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.99906494),
        dec: Angle.Degrees(-31.42808525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54626"},
        {"Hipparcos Number", "HIP 34424"},
        {"Geneva Identification System", "GEN# +1.00054626"},
        {"Smithsonian Astrophysical Observation", "SAO 197616"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.04563297),
        dec: Angle.Degrees(-31.42783405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30774"},
        {"Hipparcos Number", "HIP 22395"},
        {"Geneva Identification System", "GEN# +1.00030774"},
        {"Smithsonian Astrophysical Observation", "SAO 195321"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.30527795),
        dec: Angle.Degrees(-31.42653624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83088"},
        {"Hipparcos Number", "HIP 47036"},
        {"Smithsonian Astrophysical Observation", "SAO 200529"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.79309402),
        dec: Angle.Degrees(-31.42426901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17563"},
        {"Hipparcos Number", "HIP 13082"},
        {"Geneva Identification System", "GEN# +1.00017563"},
        {"Smithsonian Astrophysical Observation", "SAO 193921"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.03743203),
        dec: Angle.Degrees(-31.42294229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43453"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.75502149),
        dec: Angle.Degrees(+00.49165164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8360"},
        {"Hipparcos Number", "HIP 6410"},
        {"Smithsonian Astrophysical Observation", "SAO 193074"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.58180437),
        dec: Angle.Degrees(-31.42221969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64613"},
    },
    visualMagnitude: 11.33,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.65156632),
        dec: Angle.Degrees(-31.41963089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131589"},
        {"Hipparcos Number", "HIP 73026"},
        {"Smithsonian Astrophysical Observation", "SAO 206094"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.86119548),
        dec: Angle.Degrees(-31.41821314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41977"},
        {"Hipparcos Number", "HIP 28967"},
        {"Geneva Identification System", "GEN# +1.00041977"},
        {"Smithsonian Astrophysical Observation", "SAO 196499"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.68984914),
        dec: Angle.Degrees(-31.41679247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109444"},
        {"Hipparcos Number", "HIP 61399"},
        {"Smithsonian Astrophysical Observation", "SAO 203606"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.72089682),
        dec: Angle.Degrees(-31.41550573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90725"},
        {"Smithsonian Astrophysical Observation", "SAO 210246"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.65169513),
        dec: Angle.Degrees(-31.41430701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93881"},
        {"Hipparcos Number", "HIP 52950"},
        {"Smithsonian Astrophysical Observation", "SAO 201801"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.44345799),
        dec: Angle.Degrees(-31.41425448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162272"},
        {"Hipparcos Number", "HIP 87395"},
        {"Smithsonian Astrophysical Observation", "SAO 209368"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.89886659),
        dec: Angle.Degrees(-31.41301601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29543"},
        {"Hipparcos Number", "HIP 21563"},
        {"Geneva Identification System", "GEN# +1.00029543"},
        {"Smithsonian Astrophysical Observation", "SAO 195176"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.43543692),
        dec: Angle.Degrees(-31.41054634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105330"},
        {"Hipparcos Number", "HIP 59135"},
        {"Fundamental Katalog 5th Edition", "FK5 2970"},
        {"Geneva Identification System", "GEN# +1.00105330"},
        {"Smithsonian Astrophysical Observation", "SAO 203150"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.89737564),
        dec: Angle.Degrees(-31.41029572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111296"},
        {"Hipparcos Number", "HIP 62511"},
        {"Geneva Identification System", "GEN# +1.00111296"},
        {"Smithsonian Astrophysical Observation", "SAO 203826"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.16299030),
        dec: Angle.Degrees(-31.40929509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118104"},
        {"Hipparcos Number", "HIP 66299"},
        {"Smithsonian Astrophysical Observation", "SAO 204625"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.81615512),
        dec: Angle.Degrees(-31.40858339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7752"},
        {"Hipparcos Number", "HIP 5974"},
        {"Geneva Identification System", "GEN# +1.00007752"},
        {"Smithsonian Astrophysical Observation", "SAO 193021"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.19604560),
        dec: Angle.Degrees(-31.40808055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42641"},
        {"Smithsonian Astrophysical Observation", "SAO 199507"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.34074155),
        dec: Angle.Degrees(-31.40561883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1734"},
        {"Geneva Identification System", "GEN# +6.00246239"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.48333925),
        dec: Angle.Degrees(-31.40558641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80300"},
        {"Hipparcos Number", "HIP 45626"},
        {"Smithsonian Astrophysical Observation", "SAO 200202"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.50266251),
        dec: Angle.Degrees(-31.40420538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85920"},
        {"Hipparcos Number", "HIP 48568"},
        {"Smithsonian Astrophysical Observation", "SAO 200851"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.58913464),
        dec: Angle.Degrees(-31.40404084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18047"},
        {"Hipparcos Number", "HIP 13441"},
        {"Geneva Identification System", "GEN# +1.00018047"},
        {"Smithsonian Astrophysical Observation", "SAO 193959"},
    },
    visualMagnitude: 8.45,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.26619529),
        dec: Angle.Degrees(-31.40385102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3315"},
        {"Hipparcos Number", "HIP 2842"},
        {"Smithsonian Astrophysical Observation", "SAO 192627"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.00470748),
        dec: Angle.Degrees(-31.40330285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223430"},
        {"Hipparcos Number", "HIP 117496"},
        {"Smithsonian Astrophysical Observation", "SAO 214797"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.38585741),
        dec: Angle.Degrees(-31.40289351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152521"},
        {"Hipparcos Number", "HIP 82792"},
        {"Geneva Identification System", "GEN# +1.00152521J"},
        {"Smithsonian Astrophysical Observation", "SAO 208187"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.78620595),
        dec: Angle.Degrees(-31.40248342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130327"},
        {"Hipparcos Number", "HIP 72411"},
        {"Smithsonian Astrophysical Observation", "SAO 205962"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.09089429),
        dec: Angle.Degrees(-31.40214310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37950"},
        {"Hipparcos Number", "HIP 26735"},
        {"Geneva Identification System", "GEN# +1.00037950"},
        {"Smithsonian Astrophysical Observation", "SAO 196073"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.20414145),
        dec: Angle.Degrees(-31.40186398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14851"},
        {"Hipparcos Number", "HIP 11104"},
        {"Smithsonian Astrophysical Observation", "SAO 193678"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.72953383),
        dec: Angle.Degrees(-31.40076593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173017"},
        {"Hipparcos Number", "HIP 91953"},
        {"Smithsonian Astrophysical Observation", "SAO 210517"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.15772663),
        dec: Angle.Degrees(-31.40057206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123244"},
        {"Hipparcos Number", "HIP 68965"},
        {"Geneva Identification System", "GEN# +1.00123244"},
        {"Smithsonian Astrophysical Observation", "SAO 205197"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.78130186),
        dec: Angle.Degrees(-31.40033519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13569"},
        {"Hipparcos Number", "HIP 10241"},
        {"Smithsonian Astrophysical Observation", "SAO 193566"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.92989821),
        dec: Angle.Degrees(-31.39849676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55246"},
        {"Hipparcos Number", "HIP 34665"},
        {"Smithsonian Astrophysical Observation", "SAO 197660"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.68241982),
        dec: Angle.Degrees(-31.39840473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43170"},
        {"Geneva Identification System", "GEN# -0.03006812"},
        {"Smithsonian Astrophysical Observation", "SAO 199624"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.89820555),
        dec: Angle.Degrees(-31.39805574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9784"},
        {"Hipparcos Number", "HIP 7381"},
        {"Smithsonian Astrophysical Observation", "SAO 193192"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.77564028),
        dec: Angle.Degrees(-31.39747653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95127"},
    },
    visualMagnitude: 10.76,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.28051449),
        dec: Angle.Degrees(-31.39729203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108105"},
        {"Hipparcos Number", "HIP 120212"},
        {"Geneva Identification System", "GEN# +1.00108105"},
        {"Wilson Evans Batten Catalogue", "WEB 10779"},
    },
    visualMagnitude: 12.24,
    bvColour: 3.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27, 48.0800),
        dec: Angle.DegreesMinutesSeconds((int)+00, (int)29, 35.300)
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
    primaryId: "HIP 23354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32370"},
        {"Hipparcos Number", "HIP 23354"},
        {"Smithsonian Astrophysical Observation", "SAO 195491"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.33785755),
        dec: Angle.Degrees(-31.39356128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7675"},
        {"Hipparcos Number", "HIP 5921"},
        {"Geneva Identification System", "GEN# +1.00007675"},
        {"Smithsonian Astrophysical Observation", "SAO 193015"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.04342839),
        dec: Angle.Degrees(-31.39251582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117866"},
        {"Hipparcos Number", "HIP 66150"},
        {"Smithsonian Astrophysical Observation", "SAO 204591"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.39196170),
        dec: Angle.Degrees(-31.39194390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60031"},
        {"Hipparcos Number", "HIP 36568"},
        {"Smithsonian Astrophysical Observation", "SAO 198079"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.83027466),
        dec: Angle.Degrees(-31.39171765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41758"},
        {"Hipparcos Number", "HIP 28867"},
        {"Fundamental Katalog 5th Edition", "FK5 4555"},
        {"Smithsonian Astrophysical Observation", "SAO 196485"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.42233403),
        dec: Angle.Degrees(-31.39125283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4261"},
        {"Hipparcos Number", "HIP 3506"},
        {"Fundamental Katalog 5th Edition", "FK5 4065"},
        {"Geneva Identification System", "GEN# +1.00004261"},
        {"Smithsonian Astrophysical Observation", "SAO 192712"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.19037409),
        dec: Angle.Degrees(-31.38942755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221029"},
        {"Hipparcos Number", "HIP 115897"},
        {"Smithsonian Astrophysical Observation", "SAO 214573"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.21218434),
        dec: Angle.Degrees(-31.38884904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117272"},
        {"Hipparcos Number", "HIP 65830"},
        {"Smithsonian Astrophysical Observation", "SAO 204523"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.42309734),
        dec: Angle.Degrees(-31.38824988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182964"},
        {"Hipparcos Number", "HIP 95747"},
        {"Geneva Identification System", "GEN# +1.00182964"},
        {"Smithsonian Astrophysical Observation", "SAO 211290"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.11495124),
        dec: Angle.Degrees(-31.38679966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8105"},
        {"Hipparcos Number", "HIP 6233"},
        {"Geneva Identification System", "GEN# +1.00008105"},
        {"Smithsonian Astrophysical Observation", "SAO 193055"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.98573319),
        dec: Angle.Degrees(-31.38637683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10798"},
        {"Hipparcos Number", "HIP 8168"},
        {"Geneva Identification System", "GEN# +1.00010798"},
        {"Smithsonian Astrophysical Observation", "SAO 193284"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.25750778),
        dec: Angle.Degrees(-31.38587807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 317935"},
        {"Hipparcos Number", "HIP 86223"},
        {"Geneva Identification System", "GEN# +1.00317935"},
        {"Smithsonian Astrophysical Observation", "SAO 209033"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.30583842),
        dec: Angle.Degrees(-31.38581733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110605"},
        {"Hipparcos Number", "HIP 62093"},
        {"Geneva Identification System", "GEN# +1.00110605"},
        {"Smithsonian Astrophysical Observation", "SAO 203748"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.88420524),
        dec: Angle.Degrees(-31.38580146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -228.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158103"},
        {"Hipparcos Number", "HIP 85524"},
        {"Geneva Identification System", "GEN# +1.00158103"},
        {"Smithsonian Astrophysical Observation", "SAO 208857"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.17016826),
        dec: Angle.Degrees(-31.38416122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182798"},
        {"Hipparcos Number", "HIP 95662"},
        {"Smithsonian Astrophysical Observation", "SAO 211281"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.88766148),
        dec: Angle.Degrees(-31.38384237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100289"},
        {"Hipparcos Number", "HIP 56278"},
        {"Geneva Identification System", "GEN# +1.00100289"},
        {"Smithsonian Astrophysical Observation", "SAO 202544"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.06038328),
        dec: Angle.Degrees(-31.38274868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40248"},
        {"Hipparcos Number", "HIP 28098"},
        {"Fundamental Katalog 5th Edition", "FK5 2454"},
        {"Geneva Identification System", "GEN# +1.00040248"},
        {"Smithsonian Astrophysical Observation", "SAO 196330"},
        {"Wilson Evans Batten Catalogue", "WEB 5498"},
    },
    visualMagnitude: 5.52,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.08726177),
        dec: Angle.Degrees(-31.38245487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195486"},
        {"Hipparcos Number", "HIP 101368"},
        {"Smithsonian Astrophysical Observation", "SAO 212221"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.17892836),
        dec: Angle.Degrees(-31.38235716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152721"},
        {"Hipparcos Number", "HIP 82888"},
        {"Smithsonian Astrophysical Observation", "SAO 208215"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.08309402),
        dec: Angle.Degrees(-31.38150846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120271"},
        {"Hipparcos Number", "HIP 67415"},
        {"Smithsonian Astrophysical Observation", "SAO 204869"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.24919550),
        dec: Angle.Degrees(-31.38080181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150878"},
        {"Hipparcos Number", "HIP 82001"},
        {"Fundamental Katalog 5th Edition", "FK5 5479"},
        {"Smithsonian Astrophysical Observation", "SAO 207990"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.27291429),
        dec: Angle.Degrees(-31.37996077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108185"},
        {"Smithsonian Astrophysical Observation", "SAO 213392"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.77380366),
        dec: Angle.Degrees(-31.37787032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115846"},
    },
    visualMagnitude: 11.46,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.03791292),
        dec: Angle.Degrees(-31.37696346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -236.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133075"},
        {"Hipparcos Number", "HIP 73666"},
        {"Geneva Identification System", "GEN# +1.00133075"},
        {"Smithsonian Astrophysical Observation", "SAO 206248"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.88311722),
        dec: Angle.Degrees(-31.37616151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117686"},
        {"Smithsonian Astrophysical Observation", "SAO 214832"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.00422810),
        dec: Angle.Degrees(-31.37572478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101276"},
        {"Smithsonian Astrophysical Observation", "SAO 212203"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.92722647),
        dec: Angle.Degrees(-31.37495863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149014"},
        {"Hipparcos Number", "HIP 81055"},
        {"Smithsonian Astrophysical Observation", "SAO 207763"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.32006729),
        dec: Angle.Degrees(-31.37379189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97683"},
        {"Hipparcos Number", "HIP 54875"},
        {"Smithsonian Astrophysical Observation", "SAO 202223"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.53422044),
        dec: Angle.Degrees(-31.37301053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154135"},
        {"Hipparcos Number", "HIP 83581"},
        {"Geneva Identification System", "GEN# +1.00154135"},
        {"Smithsonian Astrophysical Observation", "SAO 208381"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.23455291),
        dec: Angle.Degrees(-31.37265575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177122"},
        {"Hipparcos Number", "HIP 93685"},
        {"Geneva Identification System", "GEN# +1.00177122"},
        {"Smithsonian Astrophysical Observation", "SAO 210890"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.17283118),
        dec: Angle.Degrees(-31.37255509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77138"},
        {"Hipparcos Number", "HIP 44161"},
        {"Smithsonian Astrophysical Observation", "SAO 199862"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.91255477),
        dec: Angle.Degrees(-31.37247704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10959"},
        {"Hipparcos Number", "HIP 8301"},
        {"Geneva Identification System", "GEN# +1.00010959"},
        {"Smithsonian Astrophysical Observation", "SAO 193298"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.76489938),
        dec: Angle.Degrees(-31.37131898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81630"},
        {"Hipparcos Number", "HIP 46263"},
        {"Smithsonian Astrophysical Observation", "SAO 200364"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.49561304),
        dec: Angle.Degrees(-31.36901541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185865"},
        {"Hipparcos Number", "HIP 96945"},
        {"Geneva Identification System", "GEN# +1.00185865"},
        {"Smithsonian Astrophysical Observation", "SAO 211488"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.61967002),
        dec: Angle.Degrees(-31.36748546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85307"},
        {"Hipparcos Number", "HIP 48254"},
        {"Smithsonian Astrophysical Observation", "SAO 200790"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.55402752),
        dec: Angle.Degrees(-31.36607853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18968"},
        {"Hipparcos Number", "HIP 14121"},
        {"Smithsonian Astrophysical Observation", "SAO 194045"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.52814909),
        dec: Angle.Degrees(-31.36416587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154107"},
        {"Hipparcos Number", "HIP 83569"},
        {"Geneva Identification System", "GEN# +1.00154107"},
        {"Smithsonian Astrophysical Observation", "SAO 208379"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.19292019),
        dec: Angle.Degrees(-31.36280009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156506"},
        {"Hipparcos Number", "HIP 84734"},
        {"Geneva Identification System", "GEN# +1.00156506"},
        {"Smithsonian Astrophysical Observation", "SAO 208685"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.81926521),
        dec: Angle.Degrees(-31.36160329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171789"},
        {"Hipparcos Number", "HIP 91367"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.51402510),
        dec: Angle.Degrees(-31.35994178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39423"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.87830018),
        dec: Angle.Degrees(-31.35729997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98380"},
        {"Hipparcos Number", "HIP 55240"},
        {"Smithsonian Astrophysical Observation", "SAO 202311"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.69167187),
        dec: Angle.Degrees(-31.35702383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219910"},
        {"Hipparcos Number", "HIP 115176"},
        {"Smithsonian Astrophysical Observation", "SAO 214460"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.92611034),
        dec: Angle.Degrees(-31.35481767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4595"},
        {"Hipparcos Number", "HIP 3715"},
        {"Smithsonian Astrophysical Observation", "SAO 192746"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.92196312),
        dec: Angle.Degrees(-31.35294816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20504"},
        {"Hipparcos Number", "HIP 15265"},
        {"Fundamental Katalog 5th Edition", "FK5 1092"},
        {"Geneva Identification System", "GEN# +1.00020504"},
        {"Renson", "Renson 5110"},
        {"Smithsonian Astrophysical Observation", "SAO 194206"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.22941060),
        dec: Angle.Degrees(-31.35211781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75023"},
        {"Hipparcos Number", "HIP 43080"},
        {"Smithsonian Astrophysical Observation", "SAO 199600"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.62346640),
        dec: Angle.Degrees(-31.35067688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160564"},
        {"Hipparcos Number", "HIP 86617"},
        {"Smithsonian Astrophysical Observation", "SAO 209153"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.48943392),
        dec: Angle.Degrees(-31.35065601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37962"},
        {"Hipparcos Number", "HIP 26737"},
        {"Geneva Identification System", "GEN# +1.00037962"},
        {"Smithsonian Astrophysical Observation", "SAO 196074"},
        {"Wilson Evans Batten Catalogue", "WEB 5275"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.21669361),
        dec: Angle.Degrees(-31.35021979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -365.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86765"},
        {"Hipparcos Number", "HIP 49013"},
        {"Smithsonian Astrophysical Observation", "SAO 200944"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.98601502),
        dec: Angle.Degrees(-31.34956597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33613"},
        {"Hipparcos Number", "HIP 24057"},
        {"Renson", "Renson 8530"},
        {"Smithsonian Astrophysical Observation", "SAO 195614"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.53772390),
        dec: Angle.Degrees(-31.34911613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100842"},
        {"Smithsonian Astrophysical Observation", "SAO 212127"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.69757668),
        dec: Angle.Degrees(-31.34906578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32489"},
        {"Hipparcos Number", "HIP 23429"},
        {"Smithsonian Astrophysical Observation", "SAO 195505"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.53109555),
        dec: Angle.Degrees(-31.34888940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111965"},
        {"Hipparcos Number", "HIP 62890"},
        {"Smithsonian Astrophysical Observation", "SAO 203906"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.33248563),
        dec: Angle.Degrees(-31.34885394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91918"},
        {"Hipparcos Number", "HIP 51904"},
        {"Smithsonian Astrophysical Observation", "SAO 201548"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.06628008),
        dec: Angle.Degrees(-31.34818340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91707"},
        {"Hipparcos Number", "HIP 51777"},
        {"Geneva Identification System", "GEN# +1.00091707"},
        {"Smithsonian Astrophysical Observation", "SAO 201527"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.70366431),
        dec: Angle.Degrees(-31.34607221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150570"},
        {"Hipparcos Number", "HIP 81858"},
        {"Smithsonian Astrophysical Observation", "SAO 207957"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.78528590),
        dec: Angle.Degrees(-31.34518767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122244"},
        {"Hipparcos Number", "HIP 68502"},
        {"Smithsonian Astrophysical Observation", "SAO 205101"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.34633335),
        dec: Angle.Degrees(-31.34389861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144336"},
        {"Hipparcos Number", "HIP 78910"},
        {"Smithsonian Astrophysical Observation", "SAO 207333"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.61701900),
        dec: Angle.Degrees(-31.34252352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173409"},
        {"Hipparcos Number", "HIP 92115"},
        {"Geneva Identification System", "GEN# +1.00173409"},
        {"Smithsonian Astrophysical Observation", "SAO 210558"},
        {"Wilson Evans Batten Catalogue", "WEB 15876"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.61094866),
        dec: Angle.Degrees(-31.34223668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25757"},
        {"Hipparcos Number", "HIP 18961"},
        {"Smithsonian Astrophysical Observation", "SAO 194725"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.94287635),
        dec: Angle.Degrees(-31.34216677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7487"},
        {"Hipparcos Number", "HIP 5807"},
        {"Geneva Identification System", "GEN# +1.00007487"},
        {"Smithsonian Astrophysical Observation", "SAO 193003"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.62881676),
        dec: Angle.Degrees(-31.34205090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53091"},
        {"Smithsonian Astrophysical Observation", "SAO 201835"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.92573305),
        dec: Angle.Degrees(-31.34033859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197481"},
        {"Hipparcos Number", "HIP 102409"},
        {"Cincinnati Publication", "Ci 20 1225"},
        {"Geneva Identification System", "GEN# +1.00197481"},
        {"Smithsonian Astrophysical Observation", "SAO 212402"},
        {"Wilson Evans Batten Catalogue", "WEB 18541"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.28891788),
        dec: Angle.Degrees(-31.34002411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 280.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -360.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73241"},
        {"Hipparcos Number", "HIP 42198"},
        {"Celescope Catalog", "CEL 2691"},
        {"Geneva Identification System", "GEN# +1.00073241"},
        {"Smithsonian Astrophysical Observation", "SAO 199417"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.06987540),
        dec: Angle.Degrees(-31.33831157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93186"},
        {"Hipparcos Number", "HIP 52581"},
        {"Smithsonian Astrophysical Observation", "SAO 201709"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.27955232),
        dec: Angle.Degrees(-31.33737778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221351"},
        {"Hipparcos Number", "HIP 116115"},
        {"Geneva Identification System", "GEN# +1.00221351"},
        {"Smithsonian Astrophysical Observation", "SAO 214602"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.92088607),
        dec: Angle.Degrees(-31.33622609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5869"},
        {"Hipparcos Number", "HIP 4649"},
        {"Smithsonian Astrophysical Observation", "SAO 192853"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.93502301),
        dec: Angle.Degrees(-31.33618110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188474"},
        {"Hipparcos Number", "HIP 98130"},
        {"Smithsonian Astrophysical Observation", "SAO 211673"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.15311166),
        dec: Angle.Degrees(-31.33539380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 408.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152432"},
        {"Hipparcos Number", "HIP 82732"},
        {"Geneva Identification System", "GEN# +1.00152432"},
        {"Smithsonian Astrophysical Observation", "SAO 208175"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.65199987),
        dec: Angle.Degrees(-31.33461322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8698"},
        {"Smithsonian Astrophysical Observation", "SAO 193340"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.97548804),
        dec: Angle.Degrees(-31.33352533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71284"},
        {"Hipparcos Number", "HIP 41288"},
        {"Smithsonian Astrophysical Observation", "SAO 199203"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.35981952),
        dec: Angle.Degrees(-31.33260739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3913",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3913"},
        {"Geneva Identification System", "GEN# -0.03200327"},
        {"Smithsonian Astrophysical Observation", "SAO 192768"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.56074991),
        dec: Angle.Degrees(-31.33255899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 248.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62711"},
        {"Hipparcos Number", "HIP 37702"},
        {"Geneva Identification System", "GEN# +1.00062711"},
        {"Smithsonian Astrophysical Observation", "SAO 198358"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.02145622),
        dec: Angle.Degrees(-31.33253723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11787"},
        {"Hipparcos Number", "HIP 8933"},
        {"Smithsonian Astrophysical Observation", "SAO 193380"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.74447920),
        dec: Angle.Degrees(-31.32991763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162415"},
        {"Hipparcos Number", "HIP 87466"},
        {"Smithsonian Astrophysical Observation", "SAO 209391"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.07114469),
        dec: Angle.Degrees(-31.32811386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185744"},
        {"Hipparcos Number", "HIP 96898"},
        {"Geneva Identification System", "GEN# +1.00185744"},
        {"Smithsonian Astrophysical Observation", "SAO 211484"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.46206234),
        dec: Angle.Degrees(-31.32804693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155793"},
        {"Hipparcos Number", "HIP 84381"},
        {"Geneva Identification System", "GEN# +1.00155793"},
        {"Renson", "Renson 44000"},
        {"Smithsonian Astrophysical Observation", "SAO 208581"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.76505257),
        dec: Angle.Degrees(-31.32746880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96858"},
        {"Hipparcos Number", "HIP 54496"},
        {"Smithsonian Astrophysical Observation", "SAO 202136"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.24011325),
        dec: Angle.Degrees(-31.32745426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27489"},
        {"Hipparcos Number", "HIP 20140"},
        {"Geneva Identification System", "GEN# +1.00027489"},
        {"Smithsonian Astrophysical Observation", "SAO 194921"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.76869903),
        dec: Angle.Degrees(-31.32723559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220468"},
        {"Hipparcos Number", "HIP 115535"},
        {"Smithsonian Astrophysical Observation", "SAO 214521"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.04703216),
        dec: Angle.Degrees(-31.32492360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13875"},
        {"Hipparcos Number", "HIP 10427"},
        {"Smithsonian Astrophysical Observation", "SAO 193590"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.58632894),
        dec: Angle.Degrees(-31.32180373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120691"},
        {"Hipparcos Number", "HIP 67652"},
        {"Geneva Identification System", "GEN# +1.00120691"},
        {"Smithsonian Astrophysical Observation", "SAO 204913"},
        {"Wilson Evans Batten Catalogue", "WEB 11898"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.91219053),
        dec: Angle.Degrees(-31.31938678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -307.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18250"},
        {"Smithsonian Astrophysical Observation", "SAO 194616"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.55180883),
        dec: Angle.Degrees(-31.31681583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168310"},
        {"Hipparcos Number", "HIP 89880"},
        {"Geneva Identification System", "GEN# +1.00168310"},
        {"Smithsonian Astrophysical Observation", "SAO 210012"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.11084443),
        dec: Angle.Degrees(-31.31628253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19405"},
        {"Hipparcos Number", "HIP 14432"},
        {"Smithsonian Astrophysical Observation", "SAO 194084"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.57110743),
        dec: Angle.Degrees(-31.31427245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16146"},
        {"Hipparcos Number", "HIP 11991"},
        {"Smithsonian Astrophysical Observation", "SAO 193783"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.65892333),
        dec: Angle.Degrees(-31.31351505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189384"},
        {"Hipparcos Number", "HIP 98520"},
        {"Geneva Identification System", "GEN# +1.00189384"},
        {"Smithsonian Astrophysical Observation", "SAO 211732"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.22730249),
        dec: Angle.Degrees(-31.31211038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98740"},
        {"Hipparcos Number", "HIP 55465"},
        {"Smithsonian Astrophysical Observation", "SAO 202353"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.38262499),
        dec: Angle.Degrees(-31.31142326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98301"},
        {"Hipparcos Number", "HIP 55200"},
        {"Geneva Identification System", "GEN# +1.00098301"},
        {"Smithsonian Astrophysical Observation", "SAO 202298"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.53598827),
        dec: Angle.Degrees(-31.31125224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215739"},
        {"Hipparcos Number", "HIP 112546"},
        {"Smithsonian Astrophysical Observation", "SAO 214086"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.93120511),
        dec: Angle.Degrees(-31.31028049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33967"},
        {"Hipparcos Number", "HIP 24282"},
        {"Smithsonian Astrophysical Observation", "SAO 195653"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.16537841),
        dec: Angle.Degrees(-31.30885385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38244"},
        {"Smithsonian Astrophysical Observation", "SAO 198495"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.52250400),
        dec: Angle.Degrees(-31.30564747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149229"},
        {"Hipparcos Number", "HIP 81163"},
        {"Smithsonian Astrophysical Observation", "SAO 207786"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.65791295),
        dec: Angle.Degrees(-31.30137277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19218"},
        {"Geneva Identification System", "GEN# -0.03101701"},
    },
    visualMagnitude: 10.52,
    bvColour: -0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.78946860),
        dec: Angle.Degrees(-31.30099013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9318"},
        {"Hipparcos Number", "HIP 7073"},
        {"Smithsonian Astrophysical Observation", "SAO 193156"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.78812212),
        dec: Angle.Degrees(-31.30097076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117865"},
        {"Smithsonian Astrophysical Observation", "SAO 214848"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.59993966),
        dec: Angle.Degrees(-31.30041278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 458.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58285"},
        {"Hipparcos Number", "HIP 35859"},
        {"Celescope Catalog", "CEL 1824"},
        {"Geneva Identification System", "GEN# +1.00058285"},
        {"Smithsonian Astrophysical Observation", "SAO 197939"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.89438074),
        dec: Angle.Degrees(-31.29993519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22728"},
        {"Hipparcos Number", "HIP 16958"},
        {"Geneva Identification System", "GEN# +1.00022728"},
        {"Smithsonian Astrophysical Observation", "SAO 194416"},
        {"Wilson Evans Batten Catalogue", "WEB 3225"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.54134016),
        dec: Angle.Degrees(-31.29962054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51061"},
        {"Hipparcos Number", "HIP 33187"},
        {"Geneva Identification System", "GEN# +1.00051061"},
        {"Smithsonian Astrophysical Observation", "SAO 197336"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.60831933),
        dec: Angle.Degrees(-31.29765182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157058"},
        {"Hipparcos Number", "HIP 84995"},
        {"Geneva Identification System", "GEN# +1.00157058"},
        {"Smithsonian Astrophysical Observation", "SAO 208736"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.59258778),
        dec: Angle.Degrees(-31.29736178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137727"},
        {"Hipparcos Number", "HIP 75769"},
        {"Smithsonian Astrophysical Observation", "SAO 206686"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.18340897),
        dec: Angle.Degrees(-31.29399831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174727"},
        {"Hipparcos Number", "HIP 92698"},
        {"Smithsonian Astrophysical Observation", "SAO 210678"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.31798387),
        dec: Angle.Degrees(-31.29166528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46972"},
        {"Hipparcos Number", "HIP 31405"},
        {"Smithsonian Astrophysical Observation", "SAO 196964"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.74091394),
        dec: Angle.Degrees(-31.29146477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69285"},
    },
    visualMagnitude: 10.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.74033121),
        dec: Angle.Degrees(-31.29063408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -320.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109120"},
        {"Hipparcos Number", "HIP 61209"},
        {"Smithsonian Astrophysical Observation", "SAO 203573"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.13972672),
        dec: Angle.Degrees(-31.29012322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221578"},
        {"Hipparcos Number", "HIP 116261"},
        {"Fundamental Katalog 5th Edition", "FK5 6083"},
        {"Smithsonian Astrophysical Observation", "SAO 214622"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.35736370),
        dec: Angle.Degrees(-31.28946473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149070"},
        {"Hipparcos Number", "HIP 81082"},
        {"Geneva Identification System", "GEN# +1.00149070"},
        {"Smithsonian Astrophysical Observation", "SAO 207769"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.41950699),
        dec: Angle.Degrees(-31.28901979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195158"},
        {"Hipparcos Number", "HIP 101191"},
        {"Smithsonian Astrophysical Observation", "SAO 212192"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.67063503),
        dec: Angle.Degrees(-31.28785391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199637"},
        {"Hipparcos Number", "HIP 103613"},
        {"Smithsonian Astrophysical Observation", "SAO 212601"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.88947096),
        dec: Angle.Degrees(-31.28690375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94676"},
        {"Hipparcos Number", "HIP 53403"},
        {"Smithsonian Astrophysical Observation", "SAO 201898"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.83884528),
        dec: Angle.Degrees(-31.28585218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73073"},
        {"Hipparcos Number", "HIP 42127"},
        {"Smithsonian Astrophysical Observation", "SAO 199399"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.81240622),
        dec: Angle.Degrees(-31.28563339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121397"},
        {"Hipparcos Number", "HIP 68021"},
        {"Geneva Identification System", "GEN# +1.00121397"},
        {"Smithsonian Astrophysical Observation", "SAO 204994"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.93530940),
        dec: Angle.Degrees(-31.28499204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26807"},
        {"Hipparcos Number", "HIP 19703"},
        {"Geneva Identification System", "GEN# +1.00026807"},
        {"Smithsonian Astrophysical Observation", "SAO 194837"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.30883184),
        dec: Angle.Degrees(-31.28332465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133336"},
        {"Hipparcos Number", "HIP 73783"},
        {"Smithsonian Astrophysical Observation", "SAO 206274"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.21820771),
        dec: Angle.Degrees(-31.27896829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5206"},
        {"Smithsonian Astrophysical Observation", "SAO 192927"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.65180242),
        dec: Angle.Degrees(-31.27878945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15699"},
        {"Hipparcos Number", "HIP 11677"},
        {"Smithsonian Astrophysical Observation", "SAO 193745"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.65550104),
        dec: Angle.Degrees(-31.27829296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2583"},
        {"Hipparcos Number", "HIP 2295"},
        {"Smithsonian Astrophysical Observation", "SAO 192559"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.32326091),
        dec: Angle.Degrees(-31.27735792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34554"},
        {"Hipparcos Number", "HIP 24629"},
        {"Geneva Identification System", "GEN# +1.00034554"},
        {"Smithsonian Astrophysical Observation", "SAO 195714"},
        {"Wilson Evans Batten Catalogue", "WEB 4766"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.25099331),
        dec: Angle.Degrees(-31.27707479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 160.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50178"},
        {"Hipparcos Number", "HIP 32830"},
        {"Geneva Identification System", "GEN# +1.00050178"},
        {"Smithsonian Astrophysical Observation", "SAO 197270"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.66097625),
        dec: Angle.Degrees(-31.27639335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41258"},
        {"Smithsonian Astrophysical Observation", "SAO 199196"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.25999920),
        dec: Angle.Degrees(-31.27598423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84752"},
        {"Hipparcos Number", "HIP 47964"},
        {"Smithsonian Astrophysical Observation", "SAO 200720"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.62797621),
        dec: Angle.Degrees(-31.27454484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39454"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.97064632),
        dec: Angle.Degrees(-31.27303573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56582"},
        {"Hipparcos Number", "HIP 35174"},
        {"Geneva Identification System", "GEN# +5.11320022"},
        {"Smithsonian Astrophysical Observation", "SAO 197774"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.04790369),
        dec: Angle.Degrees(-31.27248731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18388"},
        {"Hipparcos Number", "HIP 13688"},
        {"Smithsonian Astrophysical Observation", "SAO 193991"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.07617926),
        dec: Angle.Degrees(-31.27153891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5876"},
        {"Hipparcos Number", "HIP 4663"},
        {"Smithsonian Astrophysical Observation", "SAO 192855"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.98051166),
        dec: Angle.Degrees(-31.27087188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84824"},
        {"Hipparcos Number", "HIP 47999"},
        {"Smithsonian Astrophysical Observation", "SAO 200729"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.76657255),
        dec: Angle.Degrees(-31.26812579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198340"},
        {"Hipparcos Number", "HIP 102892"},
        {"Smithsonian Astrophysical Observation", "SAO 212486"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.67433939),
        dec: Angle.Degrees(-31.26261846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171175"},
        {"Hipparcos Number", "HIP 91067"},
        {"Smithsonian Astrophysical Observation", "SAO 210328"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.63700169),
        dec: Angle.Degrees(-31.26225606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31730"},
        {"Hipparcos Number", "HIP 23000"},
        {"Geneva Identification System", "GEN# +1.00031730"},
        {"Smithsonian Astrophysical Observation", "SAO 195421"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.21442360),
        dec: Angle.Degrees(-31.26183777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141313"},
        {"Hipparcos Number", "HIP 77502"},
        {"Smithsonian Astrophysical Observation", "SAO 207017"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.38332741),
        dec: Angle.Degrees(-31.26106776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162815"},
        {"Hipparcos Number", "HIP 87657"},
        {"Geneva Identification System", "GEN# +1.00162815"},
        {"Smithsonian Astrophysical Observation", "SAO 209442"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.56528879),
        dec: Angle.Degrees(-31.26088265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184647"},
        {"Hipparcos Number", "HIP 96455"},
        {"Geneva Identification System", "GEN# +1.00184647"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.15406809),
        dec: Angle.Degrees(-31.25928827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49960"},
        {"Hipparcos Number", "HIP 32734"},
        {"Geneva Identification System", "GEN# +1.00049960"},
        {"Smithsonian Astrophysical Observation", "SAO 197256"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.41892448),
        dec: Angle.Degrees(-31.25916267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78162"},
        {"Hipparcos Number", "HIP 44644"},
        {"Smithsonian Astrophysical Observation", "SAO 199965"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.45369894),
        dec: Angle.Degrees(-31.25864772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8473"},
        {"Hipparcos Number", "HIP 6479"},
        {"Geneva Identification System", "GEN# +1.00008473"},
        {"Smithsonian Astrophysical Observation", "SAO 193086"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.82259543),
        dec: Angle.Degrees(-31.25859015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107042"},
    },
    visualMagnitude: 11.35,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.18065044),
        dec: Angle.Degrees(-31.25491120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102454"},
        {"Hipparcos Number", "HIP 57526"},
        {"Renson", "Renson 29530"},
        {"Smithsonian Astrophysical Observation", "SAO 202814"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.85923740),
        dec: Angle.Degrees(-31.25474988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19729"},
        {"Hipparcos Number", "HIP 14671"},
        {"Fundamental Katalog 5th Edition", "FK5 4288"},
        {"Geneva Identification System", "GEN# +1.00019729"},
        {"Smithsonian Astrophysical Observation", "SAO 194121"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.39085510),
        dec: Angle.Degrees(-31.25340628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139184"},
        {"Hipparcos Number", "HIP 76535"},
        {"Smithsonian Astrophysical Observation", "SAO 206821"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.46392924),
        dec: Angle.Degrees(-31.25205953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65570"},
        {"Hipparcos Number", "HIP 38947"},
        {"Renson", "Renson 17950"},
        {"Smithsonian Astrophysical Observation", "SAO 198642"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.52788619),
        dec: Angle.Degrees(-31.25159246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147297"},
        {"Hipparcos Number", "HIP 80198"},
        {"Geneva Identification System", "GEN# +1.00147297"},
        {"Smithsonian Astrophysical Observation", "SAO 207597"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.59029970),
        dec: Angle.Degrees(-31.25108578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172194"},
        {"Hipparcos Number", "HIP 91546"},
        {"Smithsonian Astrophysical Observation", "SAO 210428"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.03657950),
        dec: Angle.Degrees(-31.25032081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221962"},
        {"Hipparcos Number", "HIP 116515"},
        {"Smithsonian Astrophysical Observation", "SAO 214654"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.18182770),
        dec: Angle.Degrees(-31.25018754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31135"},
        {"Smithsonian Astrophysical Observation", "SAO 196910"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.98874952),
        dec: Angle.Degrees(-31.25001769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206551"},
        {"Hipparcos Number", "HIP 107261"},
        {"Smithsonian Astrophysical Observation", "SAO 213238"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.88260166),
        dec: Angle.Degrees(-31.24877841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194677"},
        {"Hipparcos Number", "HIP 100939"},
        {"Smithsonian Astrophysical Observation", "SAO 212145"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.99246860),
        dec: Angle.Degrees(-31.24657921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37850"},
        {"Hipparcos Number", "HIP 26674"},
        {"Smithsonian Astrophysical Observation", "SAO 196064"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.02672148),
        dec: Angle.Degrees(-31.24582222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194997"},
        {"Hipparcos Number", "HIP 101107"},
        {"Smithsonian Astrophysical Observation", "SAO 212177"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.42345236),
        dec: Angle.Degrees(-31.24463792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213513"},
        {"Hipparcos Number", "HIP 111265"},
        {"Smithsonian Astrophysical Observation", "SAO 213894"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.12626194),
        dec: Angle.Degrees(-31.24425041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77017"},
        {"Hipparcos Number", "HIP 44080"},
        {"Smithsonian Astrophysical Observation", "SAO 199846"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.69100456),
        dec: Angle.Degrees(-31.24417964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76263"},
        {"Hipparcos Number", "HIP 43710"},
        {"Smithsonian Astrophysical Observation", "SAO 199761"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.52636546),
        dec: Angle.Degrees(-31.24400545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75269"},
        {"Hipparcos Number", "HIP 43193"},
        {"Smithsonian Astrophysical Observation", "SAO 199632"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.99812515),
        dec: Angle.Degrees(-31.24273639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48766"},
        {"Geneva Identification System", "GEN# -0.03008053"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.19902595),
        dec: Angle.Degrees(-31.24266968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -280.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25623"},
        {"Hipparcos Number", "HIP 18879"},
        {"Geneva Identification System", "GEN# +1.00025623"},
        {"Smithsonian Astrophysical Observation", "SAO 194714"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.70719804),
        dec: Angle.Degrees(-31.24257180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20576"},
        {"Hipparcos Number", "HIP 15320"},
        {"Smithsonian Astrophysical Observation", "SAO 194212"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.41298826),
        dec: Angle.Degrees(-31.24159373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23035"},
        {"Hipparcos Number", "HIP 17175"},
        {"Smithsonian Astrophysical Observation", "SAO 194443"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.17293979),
        dec: Angle.Degrees(-31.24129636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145009"},
        {"Hipparcos Number", "HIP 79201"},
        {"Smithsonian Astrophysical Observation", "SAO 207406"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.47515933),
        dec: Angle.Degrees(-31.24062783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124227"},
        {"Hipparcos Number", "HIP 69441"},
        {"Geneva Identification System", "GEN# +1.00124227"},
        {"Smithsonian Astrophysical Observation", "SAO 205314"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.25299911),
        dec: Angle.Degrees(-31.23899846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204394"},
        {"Hipparcos Number", "HIP 106067"},
        {"Geneva Identification System", "GEN# +1.00204394"},
        {"Smithsonian Astrophysical Observation", "SAO 213034"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.26554098),
        dec: Angle.Degrees(-31.23853096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55970"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.04477749),
        dec: Angle.Degrees(-31.23825395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116980",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116980"},
        {"Smithsonian Astrophysical Observation", "SAO 214725"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.71456318),
        dec: Angle.Degrees(-31.23719338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99727"},
        {"Hipparcos Number", "HIP 55968"},
        {"Smithsonian Astrophysical Observation", "SAO 202485"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.03912385),
        dec: Angle.Degrees(-31.23654882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147956"},
        {"Hipparcos Number", "HIP 80504"},
        {"Smithsonian Astrophysical Observation", "SAO 207661"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.50716536),
        dec: Angle.Degrees(-31.23586897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117171"},
        {"Smithsonian Astrophysical Observation", "SAO 214753"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.33676914),
        dec: Angle.Degrees(-31.23460122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196253"},
        {"Hipparcos Number", "HIP 101722"},
        {"Smithsonian Astrophysical Observation", "SAO 212285"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.28779795),
        dec: Angle.Degrees(-31.23441215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199859"},
        {"Hipparcos Number", "HIP 103701"},
        {"Smithsonian Astrophysical Observation", "SAO 212624"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.21159901),
        dec: Angle.Degrees(-31.23292943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47108",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47108"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.01404050),
        dec: Angle.Degrees(-31.23232261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148074"},
        {"Hipparcos Number", "HIP 80556"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.70639582),
        dec: Angle.Degrees(-31.23104229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52491"},
        {"Hipparcos Number", "HIP 33691"},
        {"Geneva Identification System", "GEN# +1.00052491"},
        {"Smithsonian Astrophysical Observation", "SAO 197451"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.01139325),
        dec: Angle.Degrees(-31.22817287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15478"},
        {"Hipparcos Number", "HIP 11537"},
        {"Smithsonian Astrophysical Observation", "SAO 193730"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.18265123),
        dec: Angle.Degrees(-31.22711263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152520"},
        {"Hipparcos Number", "HIP 82791"},
        {"Geneva Identification System", "GEN# +1.00152520J"},
        {"Smithsonian Astrophysical Observation", "SAO 208186"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.78466324),
        dec: Angle.Degrees(-31.22269570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171964"},
        {"Hipparcos Number", "HIP 91432"},
        {"Smithsonian Astrophysical Observation", "SAO 210401"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.70343592),
        dec: Angle.Degrees(-31.22163048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101080"},
        {"Hipparcos Number", "HIP 56721"},
        {"Geneva Identification System", "GEN# +1.00101080"},
        {"Smithsonian Astrophysical Observation", "SAO 202646"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.44460917),
        dec: Angle.Degrees(-31.21850787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112815"},
        {"Smithsonian Astrophysical Observation", "SAO 214130"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.69509620),
        dec: Angle.Degrees(-31.21610981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34103"},
        {"Hipparcos Number", "HIP 24365"},
        {"Smithsonian Astrophysical Observation", "SAO 195664"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.41086768),
        dec: Angle.Degrees(-31.21574070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 888"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.72496614),
        dec: Angle.Degrees(-31.21515694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139613"},
        {"Hipparcos Number", "HIP 76739"},
        {"Geneva Identification System", "GEN# +1.00139613"},
        {"Smithsonian Astrophysical Observation", "SAO 206858"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.06483646),
        dec: Angle.Degrees(-31.21369404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225077"},
        {"Hipparcos Number", "HIP 257"},
        {"Geneva Identification System", "GEN# +4.09010134"},
        {"Renson", "Renson 61720"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.80301496),
        dec: Angle.Degrees(-31.21239379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135896"},
        {"Hipparcos Number", "HIP 74929"},
        {"Geneva Identification System", "GEN# +1.00135896"},
        {"Smithsonian Astrophysical Observation", "SAO 206509"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.67211538),
        dec: Angle.Degrees(-31.20933138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155651"},
        {"Hipparcos Number", "HIP 84318"},
        {"Smithsonian Astrophysical Observation", "SAO 208571"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.56904089),
        dec: Angle.Degrees(-31.20849596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30906"},
        {"Hipparcos Number", "HIP 22484"},
        {"Smithsonian Astrophysical Observation", "SAO 195337"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.55653866),
        dec: Angle.Degrees(-31.20818105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192652"},
        {"Hipparcos Number", "HIP 99981"},
        {"Fundamental Katalog 5th Edition", "FK5 5789"},
        {"Smithsonian Astrophysical Observation", "SAO 211961"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.24976906),
        dec: Angle.Degrees(-31.20789139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158020"},
        {"Hipparcos Number", "HIP 85482"},
        {"Geneva Identification System", "GEN# +1.00158020"},
        {"Smithsonian Astrophysical Observation", "SAO 208852"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.04928848),
        dec: Angle.Degrees(-31.20718055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178982"},
        {"Hipparcos Number", "HIP 94332"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.01643470),
        dec: Angle.Degrees(-31.20592704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181242"},
        {"Hipparcos Number", "HIP 95120"},
        {"Fundamental Katalog 5th Edition", "FK5 5703"},
        {"Smithsonian Astrophysical Observation", "SAO 211203"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.26232805),
        dec: Angle.Degrees(-31.20588973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94906"},
        {"Hipparcos Number", "HIP 53516"},
        {"Geneva Identification System", "GEN# +1.00094906"},
        {"Smithsonian Astrophysical Observation", "SAO 201929"},
        {"Wilson Evans Batten Catalogue", "WEB 9716"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.21729097),
        dec: Angle.Degrees(-31.20457451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111339"},
        {"Hipparcos Number", "HIP 62544"},
        {"Geneva Identification System", "GEN# +1.00111339"},
        {"Smithsonian Astrophysical Observation", "SAO 203832"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.23243202),
        dec: Angle.Degrees(-31.20427292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151395"},
        {"Hipparcos Number", "HIP 82254"},
        {"Geneva Identification System", "GEN# +1.00151395"},
        {"Smithsonian Astrophysical Observation", "SAO 208050"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.10274273),
        dec: Angle.Degrees(-31.20362438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215950"},
        {"Hipparcos Number", "HIP 112692"},
        {"Smithsonian Astrophysical Observation", "SAO 214108"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.32085845),
        dec: Angle.Degrees(-31.20360981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106921"},
        {"Hipparcos Number", "HIP 59945"},
        {"Geneva Identification System", "GEN# +1.00106921"},
        {"Smithsonian Astrophysical Observation", "SAO 203318"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.44263883),
        dec: Angle.Degrees(-31.20266809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111748"},
        {"Hipparcos Number", "HIP 62773"},
        {"Geneva Identification System", "GEN# +1.00111748"},
        {"Renson", "Renson 32430"},
        {"Smithsonian Astrophysical Observation", "SAO 203879"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.96088307),
        dec: Angle.Degrees(-31.20189822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89036"},
        {"Hipparcos Number", "HIP 50258"},
        {"Renson", "Renson 25480"},
        {"Smithsonian Astrophysical Observation", "SAO 201220"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.93292263),
        dec: Angle.Degrees(-31.20139945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127392"},
        {"Hipparcos Number", "HIP 71058"},
        {"Geneva Identification System", "GEN# +1.00127392"},
        {"Smithsonian Astrophysical Observation", "SAO 205654"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.97304636),
        dec: Angle.Degrees(-31.20043042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174870"},
        {"Hipparcos Number", "HIP 92748"},
        {"Smithsonian Astrophysical Observation", "SAO 210694"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.50154561),
        dec: Angle.Degrees(-31.19868504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164608"},
        {"Hipparcos Number", "HIP 88433"},
        {"Geneva Identification System", "GEN# +1.00164608"},
        {"Smithsonian Astrophysical Observation", "SAO 209647"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.82333634),
        dec: Angle.Degrees(-31.19863535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2225"},
        {"Hipparcos Number", "HIP 2041"},
        {"Geneva Identification System", "GEN# +1.00002225"},
        {"Smithsonian Astrophysical Observation", "SAO 192519"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.47614861),
        dec: Angle.Degrees(-31.19855774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116614"},
        {"Hipparcos Number", "HIP 65472"},
        {"Geneva Identification System", "GEN# +1.00116614"},
        {"Smithsonian Astrophysical Observation", "SAO 204451"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.29438900),
        dec: Angle.Degrees(-31.19850438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32928"},
        {"Hipparcos Number", "HIP 23667"},
        {"Smithsonian Astrophysical Observation", "SAO 195544"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.31147494),
        dec: Angle.Degrees(-31.19722020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65980"},
        {"Hipparcos Number", "HIP 39121"},
        {"Smithsonian Astrophysical Observation", "SAO 198680"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.05778957),
        dec: Angle.Degrees(-31.19653977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27711"},
        {"Hipparcos Number", "HIP 20316"},
        {"Smithsonian Astrophysical Observation", "SAO 194946"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.28342212),
        dec: Angle.Degrees(-31.19596918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203998"},
        {"Hipparcos Number", "HIP 105872"},
        {"Geneva Identification System", "GEN# +1.00203998"},
        {"Smithsonian Astrophysical Observation", "SAO 213000"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.62636098),
        dec: Angle.Degrees(-31.19007076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47195"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.28004846),
        dec: Angle.Degrees(+00.50563811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104868"},
        {"Hipparcos Number", "HIP 58878"},
        {"Geneva Identification System", "GEN# +1.00104868"},
        {"Smithsonian Astrophysical Observation", "SAO 203101"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.14297603),
        dec: Angle.Degrees(-31.18756648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5496"},
        {"Hipparcos Number", "HIP 4396"},
        {"Geneva Identification System", "GEN# +1.00005496"},
        {"Geneva Identification System 2", "GEN# +6.10166918"},
        {"Smithsonian Astrophysical Observation", "SAO 192825"},
    },
    visualMagnitude: 10.58,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.09398683),
        dec: Angle.Degrees(-31.18379326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202134"},
        {"Hipparcos Number", "HIP 104894"},
        {"Smithsonian Astrophysical Observation", "SAO 212824"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.71974606),
        dec: Angle.Degrees(-31.18355921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203897"},
        {"Hipparcos Number", "HIP 105821"},
        {"Geneva Identification System", "GEN# +1.00203897"},
        {"Smithsonian Astrophysical Observation", "SAO 212995"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.48343273),
        dec: Angle.Degrees(-31.18263466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46095"},
        {"Hipparcos Number", "HIP 30967"},
        {"Celescope Catalog", "CEL 1271"},
        {"Smithsonian Astrophysical Observation", "SAO 196879"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.50259101),
        dec: Angle.Degrees(-31.17448331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213467"},
        {"Hipparcos Number", "HIP 111228"},
        {"Cincinnati Publication", "Ci 18 2929"},
        {"Geneva Identification System", "GEN# +1.00213467"},
        {"Smithsonian Astrophysical Observation", "SAO 213889"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.03208563),
        dec: Angle.Degrees(-31.17321481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 290.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28726"},
    },
    visualMagnitude: 11.55,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.01460243),
        dec: Angle.Degrees(-31.17079856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25925"},
        {"Hipparcos Number", "HIP 19062"},
        {"Geneva Identification System", "GEN# +1.00025925"},
        {"Smithsonian Astrophysical Observation", "SAO 194748"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.27636219),
        dec: Angle.Degrees(-31.16965977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172483"},
        {"Hipparcos Number", "HIP 91681"},
        {"Geneva Identification System", "GEN# +1.00172483"},
        {"Smithsonian Astrophysical Observation", "SAO 210472"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.44498612),
        dec: Angle.Degrees(-31.16959136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225229"},
        {"Hipparcos Number", "HIP 366"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.15246785),
        dec: Angle.Degrees(-31.16905083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143147"},
        {"Hipparcos Number", "HIP 78352"},
        {"Geneva Identification System", "GEN# +1.00143147"},
        {"Smithsonian Astrophysical Observation", "SAO 207206"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.97007832),
        dec: Angle.Degrees(-31.16836221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34970"},
        {"Hipparcos Number", "HIP 24886"},
        {"Geneva Identification System", "GEN# +1.00034970"},
        {"Smithsonian Astrophysical Observation", "SAO 195757"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.01907969),
        dec: Angle.Degrees(-31.16744025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191271"},
        {"Hipparcos Number", "HIP 99374"},
        {"Geneva Identification System", "GEN# +1.00191271"},
        {"Smithsonian Astrophysical Observation", "SAO 211874"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.55078277),
        dec: Angle.Degrees(-31.16612422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55127"},
    },
    visualMagnitude: 11.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.29622750),
        dec: Angle.Degrees(-31.16407693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100339"},
        {"Smithsonian Astrophysical Observation", "SAO 212027"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.23469701),
        dec: Angle.Degrees(-31.16403817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54045"},
        {"Smithsonian Astrophysical Observation", "SAO 202042"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.89321477),
        dec: Angle.Degrees(-31.16333625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52555"},
        {"Geneva Identification System", "GEN# -0.03008687"},
        {"Geneva Identification System 2", "GEN# +6.00103942"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.18148035),
        dec: Angle.Degrees(-31.16250419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 208.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165770"},
        {"Hipparcos Number", "HIP 88914"},
        {"Smithsonian Astrophysical Observation", "SAO 209771"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.24624803),
        dec: Angle.Degrees(-31.15998946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94518"},
        {"Hipparcos Number", "HIP 53311"},
        {"Geneva Identification System", "GEN# +1.00094518"},
        {"Smithsonian Astrophysical Observation", "SAO 201876"},
        {"Wilson Evans Batten Catalogue", "WEB 9680"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.55117368),
        dec: Angle.Degrees(-31.15878375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -338.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45113"},
        {"Hipparcos Number", "HIP 30464"},
        {"Smithsonian Astrophysical Observation", "SAO 196777"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.06781863),
        dec: Angle.Degrees(-31.15866053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87771"},
        {"Hipparcos Number", "HIP 49515"},
        {"Smithsonian Astrophysical Observation", "SAO 201056"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.65184441),
        dec: Angle.Degrees(-31.15677124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140562"},
        {"Hipparcos Number", "HIP 77168"},
        {"Smithsonian Astrophysical Observation", "SAO 206938"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.35884775),
        dec: Angle.Degrees(-31.15493116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69446"},
        {"Hipparcos Number", "HIP 40480"},
        {"Smithsonian Astrophysical Observation", "SAO 199013"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.98434544),
        dec: Angle.Degrees(-31.15447038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29604"},
        {"Hipparcos Number", "HIP 21616"},
        {"Smithsonian Astrophysical Observation", "SAO 195187"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.61627855),
        dec: Angle.Degrees(-31.15359922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3811"},
        {"Hipparcos Number", "HIP 3180"},
        {"Geneva Identification System", "GEN# +1.00003811"},
        {"Smithsonian Astrophysical Observation", "SAO 192671"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.12763013),
        dec: Angle.Degrees(-31.15289358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45329"},
        {"Hipparcos Number", "HIP 30557"},
        {"Smithsonian Astrophysical Observation", "SAO 196802"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.35725176),
        dec: Angle.Degrees(-31.15222078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22477"},
        {"Hipparcos Number", "HIP 16763"},
        {"Geneva Identification System", "GEN# +1.00022477"},
        {"Smithsonian Astrophysical Observation", "SAO 194392"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.93066545),
        dec: Angle.Degrees(-31.14985501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108726"},
        {"Hipparcos Number", "HIP 60958"},
        {"Smithsonian Astrophysical Observation", "SAO 203526"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.43360775),
        dec: Angle.Degrees(-31.14891903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186335"},
        {"Hipparcos Number", "HIP 97158"},
        {"Smithsonian Astrophysical Observation", "SAO 211530"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.22665599),
        dec: Angle.Degrees(-31.14588582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75884"},
        {"Hipparcos Number", "HIP 43509"},
        {"Smithsonian Astrophysical Observation", "SAO 199713"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.93458298),
        dec: Angle.Degrees(-31.14440823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217745"},
        {"Hipparcos Number", "HIP 113838"},
        {"Geneva Identification System", "GEN# +1.00217745"},
        {"Smithsonian Astrophysical Observation", "SAO 214270"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.79472408),
        dec: Angle.Degrees(-31.14283901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138296"},
        {"Hipparcos Number", "HIP 76084"},
        {"Geneva Identification System", "GEN# +1.00138296"},
        {"Smithsonian Astrophysical Observation", "SAO 206739"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.08394159),
        dec: Angle.Degrees(-31.14268956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52516"},
        {"Hipparcos Number", "HIP 33705"},
        {"Geneva Identification System", "GEN# +1.00052516"},
        {"Smithsonian Astrophysical Observation", "SAO 197456"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.04066623),
        dec: Angle.Degrees(-31.14177272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105379"},
        {"Hipparcos Number", "HIP 59167"},
        {"Geneva Identification System", "GEN# +1.00105379"},
        {"Renson", "Renson 30460"},
        {"Smithsonian Astrophysical Observation", "SAO 203158"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.00598286),
        dec: Angle.Degrees(-31.14068997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51133"},
        {"Hipparcos Number", "HIP 33220"},
        {"Geneva Identification System", "GEN# +1.00051133"},
        {"Smithsonian Astrophysical Observation", "SAO 197342"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.69829800),
        dec: Angle.Degrees(-31.14066745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 164.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219247"},
        {"Hipparcos Number", "HIP 114748"},
        {"Smithsonian Astrophysical Observation", "SAO 214401"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.66543481),
        dec: Angle.Degrees(-31.14046257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141517"},
        {"Hipparcos Number", "HIP 77599"},
        {"Geneva Identification System", "GEN# +1.00141517"},
        {"Smithsonian Astrophysical Observation", "SAO 207031"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.63883310),
        dec: Angle.Degrees(-31.13860598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193615"},
        {"Hipparcos Number", "HIP 100444"},
        {"Smithsonian Astrophysical Observation", "SAO 212053"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.54405977),
        dec: Angle.Degrees(-31.13745327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97446"},
        {"Hipparcos Number", "HIP 54743"},
        {"Geneva Identification System", "GEN# +1.00097446"},
        {"Smithsonian Astrophysical Observation", "SAO 202203"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.12888352),
        dec: Angle.Degrees(-31.13562558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11933"},
        {"Hipparcos Number", "HIP 9046"},
        {"Smithsonian Astrophysical Observation", "SAO 193395"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.14083883),
        dec: Angle.Degrees(-31.13549605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72267"},
        {"Hipparcos Number", "HIP 41750"},
        {"Smithsonian Astrophysical Observation", "SAO 199313"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.70329488),
        dec: Angle.Degrees(-31.13448174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170723"},
        {"Hipparcos Number", "HIP 90879"},
        {"Geneva Identification System", "GEN# +1.00170723"},
        {"Smithsonian Astrophysical Observation", "SAO 210280"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.06979907),
        dec: Angle.Degrees(-31.13188606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148303"},
        {"Hipparcos Number", "HIP 80683"},
        {"Smithsonian Astrophysical Observation", "SAO 207691"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.08877628),
        dec: Angle.Degrees(-31.13043274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215283"},
        {"Hipparcos Number", "HIP 112270"},
        {"Geneva Identification System", "GEN# +1.00215283"},
        {"Smithsonian Astrophysical Observation", "SAO 214053"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.11817899),
        dec: Angle.Degrees(-31.12976221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94312"},
    },
    visualMagnitude: 12.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.94311187),
        dec: Angle.Degrees(-31.12939909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20080"},
        {"Hipparcos Number", "HIP 14940"},
        {"Smithsonian Astrophysical Observation", "SAO 194157"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.15633670),
        dec: Angle.Degrees(-31.12910178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220342"},
        {"Hipparcos Number", "HIP 115456"},
        {"Smithsonian Astrophysical Observation", "SAO 214507"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.81880635),
        dec: Angle.Degrees(-31.12765152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21220"},
        {"Hipparcos Number", "HIP 15866"},
        {"Geneva Identification System", "GEN# +1.00021220"},
        {"Smithsonian Astrophysical Observation", "SAO 194275"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.09786391),
        dec: Angle.Degrees(-31.12703054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217255"},
        {"Hipparcos Number", "HIP 113541"},
        {"Smithsonian Astrophysical Observation", "SAO 214225"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.94157355),
        dec: Angle.Degrees(-31.12644204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45251"},
    },
    visualMagnitude: 10.68,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.34303031),
        dec: Angle.Degrees(-31.12555201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -267.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29045"},
        {"Hipparcos Number", "HIP 21216"},
        {"Smithsonian Astrophysical Observation", "SAO 195115"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.26533147),
        dec: Angle.Degrees(-31.12527515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81984"},
        {"Hipparcos Number", "HIP 46440"},
        {"Smithsonian Astrophysical Observation", "SAO 200397"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.07315653),
        dec: Angle.Degrees(-31.12048710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114498"},
        {"Hipparcos Number", "HIP 64339"},
        {"Smithsonian Astrophysical Observation", "SAO 204211"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.82224447),
        dec: Angle.Degrees(-31.11993088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113590",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113590"},
        {"Cincinnati Publication", "Ci 20 1395"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.09867245),
        dec: Angle.Degrees(-31.11881014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -460.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187496"},
        {"Hipparcos Number", "HIP 97708"},
        {"Geneva Identification System", "GEN# +1.00187496"},
        {"Smithsonian Astrophysical Observation", "SAO 211606"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.85592689),
        dec: Angle.Degrees(-31.11869471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7402"},
        {"Hipparcos Number", "HIP 5739"},
        {"Geneva Identification System", "GEN# +1.00007402J"},
        {"Smithsonian Astrophysical Observation", "SAO 192994"},
        {"Wilson Evans Batten Catalogue", "WEB 1307"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.43495155),
        dec: Angle.Degrees(-31.11630112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12605"},
        {"Geneva Identification System", "GEN# -0.03101092"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.52306548),
        dec: Angle.Degrees(-31.11590429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 443.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20953"},
        {"Hipparcos Number", "HIP 15664"},
        {"Geneva Identification System", "GEN# +1.00020953"},
        {"Smithsonian Astrophysical Observation", "SAO 194251"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.43565533),
        dec: Angle.Degrees(-31.11325602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166081"},
        {"Hipparcos Number", "HIP 89036"},
        {"Geneva Identification System", "GEN# +1.00166081"},
        {"Smithsonian Astrophysical Observation", "SAO 209807"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.58710742),
        dec: Angle.Degrees(-31.11194910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220400"},
        {"Hipparcos Number", "HIP 115493"},
        {"Smithsonian Astrophysical Observation", "SAO 214513"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.93551468),
        dec: Angle.Degrees(-31.11075890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106651"},
        {"Hipparcos Number", "HIP 59817"},
        {"Smithsonian Astrophysical Observation", "SAO 203291"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.99513671),
        dec: Angle.Degrees(-31.11075286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100188"},
        {"Hipparcos Number", "HIP 56225"},
        {"Smithsonian Astrophysical Observation", "SAO 202534"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.89518151),
        dec: Angle.Degrees(-31.10969565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88066"},
        {"Hipparcos Number", "HIP 49690"},
        {"Geneva Identification System", "GEN# +1.00088066"},
        {"Smithsonian Astrophysical Observation", "SAO 201093"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.15554470),
        dec: Angle.Degrees(-31.10272788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15471"},
        {"Hipparcos Number", "HIP 11524"},
        {"Geneva Identification System", "GEN# +1.00015471"},
        {"Smithsonian Astrophysical Observation", "SAO 193727"},
        {"Wilson Evans Batten Catalogue", "WEB 2406"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.14773173),
        dec: Angle.Degrees(-31.10240175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78592"},
        {"Hipparcos Number", "HIP 44841"},
        {"Geneva Identification System", "GEN# +1.00078592"},
        {"Smithsonian Astrophysical Observation", "SAO 200010"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.04169716),
        dec: Angle.Degrees(-31.10228572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149848"},
        {"Hipparcos Number", "HIP 81480"},
        {"Smithsonian Astrophysical Observation", "SAO 207871"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.63079412),
        dec: Angle.Degrees(-31.10092844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64926"},
        {"Hipparcos Number", "HIP 38670"},
        {"Smithsonian Astrophysical Observation", "SAO 198585"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.76050305),
        dec: Angle.Degrees(-31.09907693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117975"},
        {"Smithsonian Astrophysical Observation", "SAO 214865"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.93088046),
        dec: Angle.Degrees(-31.09823702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 288.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70305"},
        {"Hipparcos Number", "HIP 40846"},
        {"Smithsonian Astrophysical Observation", "SAO 199093"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.02026482),
        dec: Angle.Degrees(-31.09778694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221322"},
        {"Hipparcos Number", "HIP 116083"},
        {"Geneva Identification System", "GEN# +1.00221322"},
        {"Smithsonian Astrophysical Observation", "SAO 214600"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.83311458),
        dec: Angle.Degrees(-31.09639056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62335"},
        {"Hipparcos Number", "HIP 37527"},
        {"Smithsonian Astrophysical Observation", "SAO 198314"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.53618389),
        dec: Angle.Degrees(-31.09569038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188299"},
        {"Hipparcos Number", "HIP 98051"},
        {"Smithsonian Astrophysical Observation", "SAO 211659"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.88921816),
        dec: Angle.Degrees(-31.09485275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178077"},
        {"Hipparcos Number", "HIP 94025"},
        {"Smithsonian Astrophysical Observation", "SAO 210976"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.14039396),
        dec: Angle.Degrees(-31.09465197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225120"},
        {"Hipparcos Number", "HIP 290"},
        {"Geneva Identification System", "GEN# +1.00225120"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.90411412),
        dec: Angle.Degrees(-31.09403248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106549"},
        {"Hipparcos Number", "HIP 59780"},
        {"Geneva Identification System", "GEN# +1.00106549J"},
        {"Smithsonian Astrophysical Observation", "SAO 203284"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.86232930),
        dec: Angle.Degrees(-31.09394854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86193"},
        {"Hipparcos Number", "HIP 48723"},
        {"Smithsonian Astrophysical Observation", "SAO 200880"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.06494089),
        dec: Angle.Degrees(-31.09147648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140105"},
        {"Hipparcos Number", "HIP 76980"},
        {"Geneva Identification System", "GEN# +1.00140105"},
        {"Smithsonian Astrophysical Observation", "SAO 206898"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.77346982),
        dec: Angle.Degrees(-31.09114927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49376"},
    },
    visualMagnitude: 11.99,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.21152357),
        dec: Angle.Degrees(-31.09047519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -259.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -256.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100503"},
        {"Hipparcos Number", "HIP 56404"},
        {"Geneva Identification System", "GEN# +1.00100503"},
        {"Smithsonian Astrophysical Observation", "SAO 202569"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.44684621),
        dec: Angle.Degrees(-31.08799787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78040"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.02129114),
        dec: Angle.Degrees(+00.56840159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100393"},
        {"Hipparcos Number", "HIP 56332"},
        {"Geneva Identification System", "GEN# +1.00100393"},
        {"Smithsonian Astrophysical Observation", "SAO 202554"},
        {"Wilson Evans Batten Catalogue", "WEB 10128"},
    },
    visualMagnitude: 5.13,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.22562476),
        dec: Angle.Degrees(-31.08723547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68027"},
        {"Hipparcos Number", "HIP 39945"},
        {"Smithsonian Astrophysical Observation", "SAO 198865"},
    },
    visualMagnitude: 8.39,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.37315013),
        dec: Angle.Degrees(-31.08567495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11993"},
        {"Hipparcos Number", "HIP 9092"},
        {"Smithsonian Astrophysical Observation", "SAO 193404"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.28426326),
        dec: Angle.Degrees(-31.08432343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142407"},
        {"Hipparcos Number", "HIP 77985"},
        {"Geneva Identification System", "GEN# +1.00142407"},
        {"Smithsonian Astrophysical Observation", "SAO 207119"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.87714588),
        dec: Angle.Degrees(-31.08370458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111737"},
        {"Hipparcos Number", "HIP 62767"},
        {"Smithsonian Astrophysical Observation", "SAO 203877"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.93648216),
        dec: Angle.Degrees(-31.08368736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55958"},
        {"Hipparcos Number", "HIP 34937"},
        {"Geneva Identification System", "GEN# +5.11210042"},
        {"Geneva Identification System 2", "GEN# +5.11320005"},
        {"Smithsonian Astrophysical Observation", "SAO 197719"},
        {"Wilson Evans Batten Catalogue", "WEB 6986"},
    },
    visualMagnitude: 6.57,
    bvColour: -0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.44681424),
        dec: Angle.Degrees(-31.08364341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112421"},
        {"Hipparcos Number", "HIP 63195"},
        {"Smithsonian Astrophysical Observation", "SAO 203961"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.19934145),
        dec: Angle.Degrees(-31.08241069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108504"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.72097166),
        dec: Angle.Degrees(-31.08188072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55694"},
        {"Hipparcos Number", "HIP 34841"},
        {"Geneva Identification System", "GEN# +5.11320023J"},
        {"Smithsonian Astrophysical Observation", "SAO 197695"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.14759623),
        dec: Angle.Degrees(-31.08135615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22262"},
        {"Hipparcos Number", "HIP 16628"},
        {"Geneva Identification System", "GEN# +1.00022262J"},
        {"Smithsonian Astrophysical Observation", "SAO 194375"},
        {"Wilson Evans Batten Catalogue", "WEB 3171"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.48672231),
        dec: Angle.Degrees(-31.08030021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67776"},
        {"Hipparcos Number", "HIP 39841"},
        {"Smithsonian Astrophysical Observation", "SAO 198841"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.09856978),
        dec: Angle.Degrees(-31.07886565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154604"},
        {"Hipparcos Number", "HIP 83812"},
        {"Smithsonian Astrophysical Observation", "SAO 208446"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.93416004),
        dec: Angle.Degrees(-31.07759123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80242"},
        {"Smithsonian Astrophysical Observation", "SAO 207609"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.72739055),
        dec: Angle.Degrees(-31.07723968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212905"},
        {"Hipparcos Number", "HIP 110903"},
        {"Smithsonian Astrophysical Observation", "SAO 213844"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.03845018),
        dec: Angle.Degrees(-31.07669470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65795"},
        {"Hipparcos Number", "HIP 39034"},
        {"Smithsonian Astrophysical Observation", "SAO 198663"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.79973942),
        dec: Angle.Degrees(-31.07653444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21733",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21733"},
    },
    visualMagnitude: 11.04,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.00533588),
        dec: Angle.Degrees(-31.07571886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 156.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147386"},
        {"Hipparcos Number", "HIP 80245"},
        {"Smithsonian Astrophysical Observation", "SAO 207610"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.73083223),
        dec: Angle.Degrees(-31.07409716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11183"},
        {"Hipparcos Number", "HIP 8480"},
        {"Geneva Identification System", "GEN# +1.00011183"},
        {"Smithsonian Astrophysical Observation", "SAO 193320"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.33067634),
        dec: Angle.Degrees(-31.07242337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16683",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16683"},
    },
    visualMagnitude: 11.42,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.66019057),
        dec: Angle.Degrees(-31.07183274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -503.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95444"},
    },
    visualMagnitude: 11.57,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.22411954),
        dec: Angle.Degrees(-31.07121893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48917"},
        {"Hipparcos Number", "HIP 32292"},
        {"Celescope Catalog", "CEL 1367"},
        {"Geneva Identification System", "GEN# +5.11210023"},
        {"Smithsonian Astrophysical Observation", "SAO 197149"},
        {"Wilson Evans Batten Catalogue", "WEB 6511"},
    },
    visualMagnitude: 5.23,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.11862078),
        dec: Angle.Degrees(-31.07053787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17025"},
        {"Hipparcos Number", "HIP 12694"},
        {"Geneva Identification System", "GEN# +1.00017025"},
        {"Smithsonian Astrophysical Observation", "SAO 193876"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.76497522),
        dec: Angle.Degrees(-31.06985920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13386"},
        {"Hipparcos Number", "HIP 10117"},
        {"Geneva Identification System", "GEN# +1.00013386"},
        {"Smithsonian Astrophysical Observation", "SAO 193547"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.53279991),
        dec: Angle.Degrees(-31.06944230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 240.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27862"},
        {"Hipparcos Number", "HIP 20432"},
        {"Smithsonian Astrophysical Observation", "SAO 194962"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.65216577),
        dec: Angle.Degrees(-31.06927187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90610"},
        {"Hipparcos Number", "HIP 51172"},
        {"Fundamental Katalog 5th Edition", "FK5 392"},
        {"Geneva Identification System", "GEN# +1.00090610"},
        {"Smithsonian Astrophysical Observation", "SAO 201405"},
        {"Wilson Evans Batten Catalogue", "WEB 9355"},
    },
    visualMagnitude: 4.28,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.78814953),
        dec: Angle.Degrees(-31.06780228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159108"},
        {"Hipparcos Number", "HIP 85961"},
        {"Geneva Identification System", "GEN# +1.00159108"},
        {"Smithsonian Astrophysical Observation", "SAO 208968"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.53093864),
        dec: Angle.Degrees(-31.06623934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79413"},
        {"Hipparcos Number", "HIP 45220"},
        {"Smithsonian Astrophysical Observation", "SAO 200105"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.23405932),
        dec: Angle.Degrees(-31.06609574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121848"},
        {"Hipparcos Number", "HIP 68278"},
        {"Smithsonian Astrophysical Observation", "SAO 205057"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.66503262),
        dec: Angle.Degrees(-31.06557722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17124"},
        {"Hipparcos Number", "HIP 12752"},
        {"Smithsonian Astrophysical Observation", "SAO 193881"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.97747967),
        dec: Angle.Degrees(-31.06298238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13030"},
        {"Hipparcos Number", "HIP 9860"},
        {"Geneva Identification System", "GEN# +1.00013030"},
        {"Smithsonian Astrophysical Observation", "SAO 193511"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.70629287),
        dec: Angle.Degrees(-31.06224304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37473"},
        {"Hipparcos Number", "HIP 26433"},
        {"Geneva Identification System", "GEN# +1.00037473"},
        {"Smithsonian Astrophysical Observation", "SAO 196028"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.38111684),
        dec: Angle.Degrees(-31.06183104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93745"},
        {"Hipparcos Number", "HIP 52888"},
        {"Geneva Identification System", "GEN# +1.00093745"},
        {"Smithsonian Astrophysical Observation", "SAO 201782"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.25165610),
        dec: Angle.Degrees(-31.05891883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200973"},
        {"Hipparcos Number", "HIP 104298"},
        {"Geneva Identification System", "GEN# +1.00200973"},
        {"Smithsonian Astrophysical Observation", "SAO 212731"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.93672651),
        dec: Angle.Degrees(-31.05701775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 240.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117582"},
        {"Hipparcos Number", "HIP 65990"},
        {"Smithsonian Astrophysical Observation", "SAO 204558"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.94985195),
        dec: Angle.Degrees(-31.05530886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25739"},
        {"Hipparcos Number", "HIP 18960"},
        {"Geneva Identification System", "GEN# +1.00025739"},
        {"Smithsonian Astrophysical Observation", "SAO 194724"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.93931134),
        dec: Angle.Degrees(-31.05452407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25983"},
        {"Hipparcos Number", "HIP 19091"},
        {"Geneva Identification System", "GEN# +1.00025983"},
        {"Smithsonian Astrophysical Observation", "SAO 194754"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.40263346),
        dec: Angle.Degrees(-31.05091174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124503"},
        {"Hipparcos Number", "HIP 69599"},
        {"Geneva Identification System", "GEN# +1.00124503"},
        {"Smithsonian Astrophysical Observation", "SAO 205343"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.68019046),
        dec: Angle.Degrees(-31.05060639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72468"},
        {"Hipparcos Number", "HIP 41851"},
        {"Smithsonian Astrophysical Observation", "SAO 199338"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.99741272),
        dec: Angle.Degrees(-31.04756447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60071"},
        {"Hipparcos Number", "HIP 36594"},
        {"Smithsonian Astrophysical Observation", "SAO 198087"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.89538084),
        dec: Angle.Degrees(-31.04739158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177074"},
        {"Hipparcos Number", "HIP 93667"},
        {"Geneva Identification System", "GEN# +1.00177074"},
        {"Smithsonian Astrophysical Observation", "SAO 210883"},
        {"Wilson Evans Batten Catalogue", "WEB 16273"},
    },
    visualMagnitude: 5.49,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.10439624),
        dec: Angle.Degrees(-31.04703255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14789"},
        {"Hipparcos Number", "HIP 11049"},
        {"Smithsonian Astrophysical Observation", "SAO 193668"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.56367923),
        dec: Angle.Degrees(-31.04636960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116930"},
        {"Hipparcos Number", "HIP 65634"},
        {"Geneva Identification System", "GEN# +1.00116930"},
        {"Smithsonian Astrophysical Observation", "SAO 204486"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.85047938),
        dec: Angle.Degrees(-31.03954944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97839"},
        {"Hipparcos Number", "HIP 54940"},
        {"Smithsonian Astrophysical Observation", "SAO 202239"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.76227244),
        dec: Angle.Degrees(-31.03915487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2348"},
        {"Hipparcos Number", "HIP 2157"},
        {"Geneva Identification System", "GEN# +1.00002348"},
        {"Smithsonian Astrophysical Observation", "SAO 192531"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.81096049),
        dec: Angle.Degrees(-31.03707613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206130"},
        {"Hipparcos Number", "HIP 107047"},
        {"Smithsonian Astrophysical Observation", "SAO 213194"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.20280367),
        dec: Angle.Degrees(-31.03669150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128239"},
        {"Hipparcos Number", "HIP 71442"},
        {"Geneva Identification System", "GEN# +1.00128239"},
        {"Smithsonian Astrophysical Observation", "SAO 205753"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.16064112),
        dec: Angle.Degrees(-31.03627381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200731"},
        {"Hipparcos Number", "HIP 104160"},
        {"Smithsonian Astrophysical Observation", "SAO 212711"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.55179117),
        dec: Angle.Degrees(-31.03618643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175794"},
        {"Hipparcos Number", "HIP 93134"},
        {"Geneva Identification System", "GEN# +1.00175794"},
        {"Smithsonian Astrophysical Observation", "SAO 210773"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.58879917),
        dec: Angle.Degrees(-31.03585600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1909"},
        {"Hipparcos Number", "HIP 1830"},
        {"Geneva Identification System", "GEN# +1.00001909"},
        {"Renson", "Renson 420"},
        {"Smithsonian Astrophysical Observation", "SAO 192495"},
        {"Wilson Evans Batten Catalogue", "WEB 327"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.80247078),
        dec: Angle.Degrees(-31.03578185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61708"},
        {"Hipparcos Number", "HIP 37286"},
        {"Smithsonian Astrophysical Observation", "SAO 198247"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.84421245),
        dec: Angle.Degrees(-31.03480134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125067"},
        {"Hipparcos Number", "HIP 69863"},
        {"Smithsonian Astrophysical Observation", "SAO 205399"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.45525042),
        dec: Angle.Degrees(-31.03209334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40887"},
        {"Hipparcos Number", "HIP 28442"},
        {"Cincinnati Publication", "Ci 20 362"},
        {"Cincinnati Publication 2", "Ci 18 752"},
        {"Geneva Identification System", "GEN# +1.00040887"},
        {"Wilson Evans Batten Catalogue", "WEB 5560"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.08251352),
        dec: Angle.Degrees(-31.03118047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -378.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1015.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43865"},
        {"Hipparcos Number", "HIP 29862"},
        {"Smithsonian Astrophysical Observation", "SAO 196657"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.32344169),
        dec: Angle.Degrees(-31.02376235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41706"},
        {"Smithsonian Astrophysical Observation", "SAO 199302"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.57435663),
        dec: Angle.Degrees(-31.02334416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1039"},
        {"Hipparcos Number", "HIP 1166"},
        {"Smithsonian Astrophysical Observation", "SAO 192413"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.64829759),
        dec: Angle.Degrees(-31.02320999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101878"},
        {"Hipparcos Number", "HIP 57171"},
        {"Smithsonian Astrophysical Observation", "SAO 202745"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.87451569),
        dec: Angle.Degrees(-31.02282457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25148"},
        {"Hipparcos Number", "HIP 18572"},
        {"Smithsonian Astrophysical Observation", "SAO 194662"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.63746389),
        dec: Angle.Degrees(-31.02230760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76468"},
        {"Hipparcos Number", "HIP 43809"},
        {"Smithsonian Astrophysical Observation", "SAO 199787"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.84023843),
        dec: Angle.Degrees(-31.02005092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36093"},
        {"Hipparcos Number", "HIP 25570"},
        {"Smithsonian Astrophysical Observation", "SAO 195876"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.97978458),
        dec: Angle.Degrees(-31.01928439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23318"},
        {"Hipparcos Number", "HIP 17373"},
        {"Smithsonian Astrophysical Observation", "SAO 194477"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.79174482),
        dec: Angle.Degrees(-31.01927056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138549"},
        {"Hipparcos Number", "HIP 76200"},
        {"Geneva Identification System", "GEN# +1.00138549"},
        {"Smithsonian Astrophysical Observation", "SAO 206764"},
        {"Wilson Evans Batten Catalogue", "WEB 12939"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.47369832),
        dec: Angle.Degrees(-31.01896187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28705"},
        {"Smithsonian Astrophysical Observation", "SAO 196455"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.94433440),
        dec: Angle.Degrees(-31.01837809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77591"},
        {"Hipparcos Number", "HIP 44393"},
        {"Geneva Identification System", "GEN# +1.00077591"},
        {"Smithsonian Astrophysical Observation", "SAO 199908"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.64394863),
        dec: Angle.Degrees(-31.01763915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179500"},
        {"Hipparcos Number", "HIP 94506"},
        {"Smithsonian Astrophysical Observation", "SAO 211070"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.52219107),
        dec: Angle.Degrees(-31.01689295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213136"},
        {"Hipparcos Number", "HIP 111051"},
        {"Geneva Identification System", "GEN# +1.00213136"},
        {"Smithsonian Astrophysical Observation", "SAO 213866"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.46558286),
        dec: Angle.Degrees(-31.01333213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22716"},
        {"Hipparcos Number", "HIP 16953"},
        {"Smithsonian Astrophysical Observation", "SAO 194413"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.52241166),
        dec: Angle.Degrees(-31.01063266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43974"},
        {"Hipparcos Number", "HIP 29912"},
        {"Smithsonian Astrophysical Observation", "SAO 196665"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.46499306),
        dec: Angle.Degrees(-31.00918334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98415"},
        {"Hipparcos Number", "HIP 55258"},
        {"Smithsonian Astrophysical Observation", "SAO 202316"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.76947217),
        dec: Angle.Degrees(-31.00638027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223992"},
        {"Hipparcos Number", "HIP 117862"},
        {"Smithsonian Astrophysical Observation", "SAO 214847"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.59339322),
        dec: Angle.Degrees(-31.00589511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165598"},
        {"Hipparcos Number", "HIP 88837"},
        {"Geneva Identification System", "GEN# +1.00165598"},
        {"Smithsonian Astrophysical Observation", "SAO 209751"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.01153521),
        dec: Angle.Degrees(-31.00131559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193282"},
        {"Hipparcos Number", "HIP 100292"},
        {"Smithsonian Astrophysical Observation", "SAO 212018"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.12288188),
        dec: Angle.Degrees(-30.99963115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52140"},
        {"Hipparcos Number", "HIP 33591"},
        {"Celescope Catalog", "CEL 1475"},
        {"Geneva Identification System", "GEN# +5.11210041A"},
        {"Smithsonian Astrophysical Observation", "SAO 197432"},
        {"Wilson Evans Batten Catalogue", "WEB 6755"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.68210351),
        dec: Angle.Degrees(-30.99805276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98104"},
        {"Smithsonian Astrophysical Observation", "SAO 211667"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.06086429),
        dec: Angle.Degrees(-30.99709606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89585"},
        {"Hipparcos Number", "HIP 50559"},
        {"Geneva Identification System", "GEN# +1.00089585"},
        {"Smithsonian Astrophysical Observation", "SAO 201283"},
        {"Wilson Evans Batten Catalogue", "WEB 9276"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.91360541),
        dec: Angle.Degrees(-30.99569949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10617"},
    },
    visualMagnitude: 12.02,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.16971499),
        dec: Angle.Degrees(-30.98900065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 683.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 251.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 317520"},
        {"Hipparcos Number", "HIP 85281"},
        {"Geneva Identification System", "GEN# +1.00317520"},
        {"Smithsonian Astrophysical Observation", "SAO 208795"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.38534199),
        dec: Angle.Degrees(-30.98695739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4983"},
        {"Hipparcos Number", "HIP 4026"},
        {"Geneva Identification System", "GEN# +1.00004983"},
        {"Smithsonian Astrophysical Observation", "SAO 192781"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.89914167),
        dec: Angle.Degrees(-30.98600690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99045"},
        {"Hipparcos Number", "HIP 55620"},
        {"Smithsonian Astrophysical Observation", "SAO 202397"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.92953087),
        dec: Angle.Degrees(-30.98515792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202173"},
        {"Hipparcos Number", "HIP 104906"},
        {"Geneva Identification System", "GEN# +1.00202173"},
        {"Smithsonian Astrophysical Observation", "SAO 212828"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.75916299),
        dec: Angle.Degrees(-30.98309862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161212"},
        {"Hipparcos Number", "HIP 86915"},
        {"Smithsonian Astrophysical Observation", "SAO 209227"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.38866385),
        dec: Angle.Degrees(-30.98208346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108991"},
        {"Hipparcos Number", "HIP 61133"},
        {"Smithsonian Astrophysical Observation", "SAO 203557"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.91028000),
        dec: Angle.Degrees(-30.98188407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74787"},
        {"Hipparcos Number", "HIP 42930"},
        {"Smithsonian Astrophysical Observation", "SAO 199575"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.25306609),
        dec: Angle.Degrees(-30.97809341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196387"},
        {"Hipparcos Number", "HIP 101830"},
        {"Smithsonian Astrophysical Observation", "SAO 212301"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.53881362),
        dec: Angle.Degrees(-30.97798255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135271"},
        {"Hipparcos Number", "HIP 74651"},
        {"Smithsonian Astrophysical Observation", "SAO 206454"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.80820452),
        dec: Angle.Degrees(-30.97773659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84823"},
        {"Hipparcos Number", "HIP 47996"},
        {"Smithsonian Astrophysical Observation", "SAO 200728"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.75962516),
        dec: Angle.Degrees(-30.97356186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127646"},
        {"Hipparcos Number", "HIP 71167"},
        {"Smithsonian Astrophysical Observation", "SAO 205688"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.33374553),
        dec: Angle.Degrees(-30.97292834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178076"},
        {"Hipparcos Number", "HIP 94020"},
        {"Smithsonian Astrophysical Observation", "SAO 210975"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.13208817),
        dec: Angle.Degrees(-30.97250951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30859"},
        {"Hipparcos Number", "HIP 22457"},
        {"Smithsonian Astrophysical Observation", "SAO 195331"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.48401189),
        dec: Angle.Degrees(-30.97057881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83399"},
        {"Hipparcos Number", "HIP 47210"},
        {"Smithsonian Astrophysical Observation", "SAO 200565"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.32053925),
        dec: Angle.Degrees(-30.97013393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162185"},
        {"Hipparcos Number", "HIP 87364"},
        {"Geneva Identification System", "GEN# +1.00162185"},
        {"Smithsonian Astrophysical Observation", "SAO 209353"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.77023744),
        dec: Angle.Degrees(-30.97009465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129927"},
        {"Hipparcos Number", "HIP 72216"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.54373810),
        dec: Angle.Degrees(-30.97005307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8878"},
        {"Hipparcos Number", "HIP 6761"},
        {"Smithsonian Astrophysical Observation", "SAO 193121"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.74394812),
        dec: Angle.Degrees(-30.96953367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66760"},
        {"Hipparcos Number", "HIP 39450"},
        {"Smithsonian Astrophysical Observation", "SAO 198753"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.96341276),
        dec: Angle.Degrees(-30.96806201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19319"},
        {"Smithsonian Astrophysical Observation", "SAO 194793"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.11560038),
        dec: Angle.Degrees(-30.96701316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76913"},
        {"Hipparcos Number", "HIP 44045"},
        {"Geneva Identification System", "GEN# +1.00076913"},
        {"Smithsonian Astrophysical Observation", "SAO 199834"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.55472951),
        dec: Angle.Degrees(-30.96700828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55817"},
        {"Hipparcos Number", "HIP 34898"},
        {"Celescope Catalog", "CEL 1683"},
        {"Smithsonian Astrophysical Observation", "SAO 197706"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.30446015),
        dec: Angle.Degrees(-30.96642322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121730"},
        {"Hipparcos Number", "HIP 68212"},
        {"Geneva Identification System", "GEN# +1.00121730"},
        {"Smithsonian Astrophysical Observation", "SAO 205042"},
        {"Wilson Evans Batten Catalogue", "WEB 11967"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.48020783),
        dec: Angle.Degrees(-30.96459165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105433"},
        {"Hipparcos Number", "HIP 59197"},
        {"Fundamental Katalog 5th Edition", "FK5 5074"},
        {"Smithsonian Astrophysical Observation", "SAO 203163"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.09028748),
        dec: Angle.Degrees(-30.96366139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59890"},
        {"Hipparcos Number", "HIP 36514"},
        {"Geneva Identification System", "GEN# +1.00059890"},
        {"Smithsonian Astrophysical Observation", "SAO 198064"},
        {"Wilson Evans Batten Catalogue", "WEB 7263"},
    },
    visualMagnitude: 4.65,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.67754202),
        dec: Angle.Degrees(-30.96228313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128444"},
        {"Hipparcos Number", "HIP 71528"},
        {"Smithsonian Astrophysical Observation", "SAO 205776"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.43886978),
        dec: Angle.Degrees(-30.96197168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174249"},
        {"Hipparcos Number", "HIP 92485"},
        {"Smithsonian Astrophysical Observation", "SAO 210631"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.74143699),
        dec: Angle.Degrees(-30.96139087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148440"},
        {"Hipparcos Number", "HIP 80758"},
        {"Geneva Identification System", "GEN# +1.00148440"},
        {"Smithsonian Astrophysical Observation", "SAO 207706"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.33406944),
        dec: Angle.Degrees(-30.96092365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6758"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.74111947),
        dec: Angle.Degrees(-30.96056363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48949"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.79108457),
        dec: Angle.Degrees(-30.95884104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124872"},
        {"Hipparcos Number", "HIP 69771"},
        {"Geneva Identification System", "GEN# +1.00124872"},
        {"Smithsonian Astrophysical Observation", "SAO 205382"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.18424907),
        dec: Angle.Degrees(-30.95859902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5024"},
        {"Hipparcos Number", "HIP 4052"},
        {"Geneva Identification System", "GEN# +1.00005024"},
        {"Smithsonian Astrophysical Observation", "SAO 192783"},
        {"Wilson Evans Batten Catalogue", "WEB 726"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.97727097),
        dec: Angle.Degrees(-30.95854248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49468"},
        {"Hipparcos Number", "HIP 32517"},
        {"Smithsonian Astrophysical Observation", "SAO 197208"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.79022834),
        dec: Angle.Degrees(-30.95771291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81132"},
        {"Hipparcos Number", "HIP 46003"},
        {"Smithsonian Astrophysical Observation", "SAO 200302"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.73480564),
        dec: Angle.Degrees(-30.95690062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36296"},
        {"Hipparcos Number", "HIP 25710"},
        {"Smithsonian Astrophysical Observation", "SAO 195902"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.35199743),
        dec: Angle.Degrees(-30.95619658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106208"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.68613384),
        dec: Angle.Degrees(-30.95578595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197499"},
        {"Hipparcos Number", "HIP 102418"},
        {"Geneva Identification System", "GEN# +1.00197499"},
        {"Smithsonian Astrophysical Observation", "SAO 212405"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.30817730),
        dec: Angle.Degrees(-30.95548849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203086"},
        {"Hipparcos Number", "HIP 105395"},
        {"Smithsonian Astrophysical Observation", "SAO 212930"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.22111825),
        dec: Angle.Degrees(-30.95529298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102214"},
        {"Hipparcos Number", "HIP 57368"},
        {"Smithsonian Astrophysical Observation", "SAO 202780"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.41487492),
        dec: Angle.Degrees(-30.95510781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34475"},
        {"Hipparcos Number", "HIP 24566"},
        {"Smithsonian Astrophysical Observation", "SAO 195700"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.05871162),
        dec: Angle.Degrees(-30.95228288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19049"},
        {"Hipparcos Number", "HIP 14190"},
        {"Renson", "Renson 4780"},
        {"Smithsonian Astrophysical Observation", "SAO 194055"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.73742564),
        dec: Angle.Degrees(-30.94991547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142689"},
        {"Hipparcos Number", "HIP 78112"},
        {"Smithsonian Astrophysical Observation", "SAO 207148"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.25005808),
        dec: Angle.Degrees(-30.94978968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49131"},
        {"Hipparcos Number", "HIP 32385"},
        {"Celescope Catalog", "CEL 1373"},
        {"Geneva Identification System", "GEN# +1.00049131"},
        {"Smithsonian Astrophysical Observation", "SAO 197177"},
        {"Wilson Evans Batten Catalogue", "WEB 6531"},
    },
    visualMagnitude: 5.62,
    bvColour: -0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.37996161),
        dec: Angle.Degrees(-30.94899076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217221"},
        {"Hipparcos Number", "HIP 113528"},
        {"Geneva Identification System", "GEN# +1.00217221"},
        {"Smithsonian Astrophysical Observation", "SAO 214223"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.89063322),
        dec: Angle.Degrees(-30.94870770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42141"},
        {"Smithsonian Astrophysical Observation", "SAO 199401"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.85040867),
        dec: Angle.Degrees(-30.94807630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72568"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.56583579),
        dec: Angle.Degrees(-30.94727051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44934"},
        {"Hipparcos Number", "HIP 30378"},
        {"Geneva Identification System", "GEN# +1.00044934"},
        {"Smithsonian Astrophysical Observation", "SAO 196758"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.81573750),
        dec: Angle.Degrees(-30.94550983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8498"},
        {"Hipparcos Number", "HIP 6502"},
        {"Fundamental Katalog 5th Edition", "FK5 1036"},
        {"Geneva Identification System", "GEN# +1.00008498"},
        {"Smithsonian Astrophysical Observation", "SAO 193090"},
        {"Wilson Evans Batten Catalogue", "WEB 1433"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.87903356),
        dec: Angle.Degrees(-30.94550599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143649"},
        {"Hipparcos Number", "HIP 78601"},
        {"Geneva Identification System", "GEN# +1.00143649"},
        {"Smithsonian Astrophysical Observation", "SAO 207266"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.71593792),
        dec: Angle.Degrees(-30.94430165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15826"},
        {"Hipparcos Number", "HIP 11766"},
        {"Smithsonian Astrophysical Observation", "SAO 193754"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.96350783),
        dec: Angle.Degrees(-30.94386191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168493"},
        {"Hipparcos Number", "HIP 89960"},
        {"Smithsonian Astrophysical Observation", "SAO 210026"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.31855029),
        dec: Angle.Degrees(-30.94142777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30315"},
        {"Hipparcos Number", "HIP 22089"},
        {"Geneva Identification System", "GEN# +1.00030315"},
        {"Smithsonian Astrophysical Observation", "SAO 195266"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.28379647),
        dec: Angle.Degrees(-30.94118491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60521"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.09504445),
        dec: Angle.Degrees(-30.94104277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185131"},
        {"Hipparcos Number", "HIP 96633"},
        {"Geneva Identification System", "GEN# +1.00185131"},
        {"Smithsonian Astrophysical Observation", "SAO 211436"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.71248487),
        dec: Angle.Degrees(-30.93926987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3011"},
        {"Hipparcos Number", "HIP 2617"},
        {"Smithsonian Astrophysical Observation", "SAO 192604"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.30856916),
        dec: Angle.Degrees(-30.93899507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56998"},
        {"Hipparcos Number", "HIP 35342"},
        {"Geneva Identification System", "GEN# +5.11320013"},
        {"Smithsonian Astrophysical Observation", "SAO 197816"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.51109255),
        dec: Angle.Degrees(-30.93780950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176614"},
        {"Hipparcos Number", "HIP 93491"},
        {"Smithsonian Astrophysical Observation", "SAO 210848"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.59592456),
        dec: Angle.Degrees(-30.93759177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6068"},
        {"Hipparcos Number", "HIP 4799"},
        {"Geneva Identification System", "GEN# +1.00006068"},
        {"Smithsonian Astrophysical Observation", "SAO 192872"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.39842482),
        dec: Angle.Degrees(-30.93739073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85433"},
        {"Hipparcos Number", "HIP 48325"},
        {"Smithsonian Astrophysical Observation", "SAO 200803"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.75809494),
        dec: Angle.Degrees(-30.93684826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139520"},
        {"Hipparcos Number", "HIP 76706"},
        {"Smithsonian Astrophysical Observation", "SAO 206845"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.94158546),
        dec: Angle.Degrees(-30.93615534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1104"},
        {"Hipparcos Number", "HIP 1223"},
        {"Geneva Identification System", "GEN# +1.00001104"},
        {"Smithsonian Astrophysical Observation", "SAO 192423"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.81027616),
        dec: Angle.Degrees(-30.93505699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14680"},
        {"Hipparcos Number", "HIP 10977"},
        {"Cincinnati Publication", "Ci 20 168"},
        {"Geneva Identification System", "GEN# +1.00014680"},
        {"Smithsonian Astrophysical Observation", "SAO 193659"},
        {"Wilson Evans Batten Catalogue", "WEB 2307"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.34841642),
        dec: Angle.Degrees(-30.93390739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 550.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75514"},
        {"Hipparcos Number", "HIP 43316"},
        {"Geneva Identification System", "GEN# +1.00075514"},
        {"Smithsonian Astrophysical Observation", "SAO 199668"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.36362267),
        dec: Angle.Degrees(-30.93378652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129161"},
        {"Hipparcos Number", "HIP 71853"},
        {"Geneva Identification System", "GEN# +1.00129161J"},
        {"Renson", "Renson 36810"},
        {"Smithsonian Astrophysical Observation", "SAO 205841"},
        {"Wilson Evans Batten Catalogue", "WEB 12375"},
    },
    visualMagnitude: 6.38,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.46353219),
        dec: Angle.Degrees(-30.93311972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16415"},
        {"Hipparcos Number", "HIP 12192"},
        {"Smithsonian Astrophysical Observation", "SAO 193810"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.25868794),
        dec: Angle.Degrees(-30.93299809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158123"},
        {"Hipparcos Number", "HIP 85531"},
        {"Geneva Identification System", "GEN# +1.00158123"},
        {"Smithsonian Astrophysical Observation", "SAO 208859"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.18978032),
        dec: Angle.Degrees(-30.93155078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6880"},
        {"Hipparcos Number", "HIP 5389"},
        {"Geneva Identification System", "GEN# +1.00006880"},
        {"Smithsonian Astrophysical Observation", "SAO 192951"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.24086217),
        dec: Angle.Degrees(-30.92902482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102335"},
        {"Hipparcos Number", "HIP 57444"},
        {"Smithsonian Astrophysical Observation", "SAO 202794"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.64021445),
        dec: Angle.Degrees(-30.92861018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188921"},
        {"Hipparcos Number", "HIP 98326"},
        {"Smithsonian Astrophysical Observation", "SAO 211705"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.66043190),
        dec: Angle.Degrees(-30.92761707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8171"},
        {"Geneva Identification System", "GEN# -0.03100721"},
        {"Smithsonian Astrophysical Observation", "SAO 193285"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.26428532),
        dec: Angle.Degrees(-30.92695006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90111"},
        {"Hipparcos Number", "HIP 50896"},
        {"Smithsonian Astrophysical Observation", "SAO 201347"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.89595875),
        dec: Angle.Degrees(-30.92596487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69445"},
        {"Hipparcos Number", "HIP 40476"},
        {"Geneva Identification System", "GEN# +1.00069445"},
        {"Smithsonian Astrophysical Observation", "SAO 199010"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.96905389),
        dec: Angle.Degrees(-30.92591456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196619"},
        {"Hipparcos Number", "HIP 101957"},
        {"Geneva Identification System", "GEN# +1.00196619"},
        {"Smithsonian Astrophysical Observation", "SAO 212320"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.90856391),
        dec: Angle.Degrees(-30.92356554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208293"},
        {"Hipparcos Number", "HIP 108264"},
        {"Geneva Identification System", "GEN# +1.00208293"},
        {"Smithsonian Astrophysical Observation", "SAO 213408"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.99942046),
        dec: Angle.Degrees(-30.92347830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62334"},
        {"Hipparcos Number", "HIP 37529"},
        {"Smithsonian Astrophysical Observation", "SAO 198316"},
    },
    visualMagnitude: 9.15,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.54208624),
        dec: Angle.Degrees(-30.92258017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89212"},
        {"Hipparcos Number", "HIP 50361"},
        {"Smithsonian Astrophysical Observation", "SAO 201240"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.24649883),
        dec: Angle.Degrees(-30.92218097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83826"},
        {"Hipparcos Number", "HIP 47451"},
        {"Smithsonian Astrophysical Observation", "SAO 200614"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.07047177),
        dec: Angle.Degrees(-30.92174647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26107"},
        {"Hipparcos Number", "HIP 19190"},
        {"Smithsonian Astrophysical Observation", "SAO 194764"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.68648446),
        dec: Angle.Degrees(-30.92003405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13194"},
        {"Geneva Identification System", "GEN# -0.03101135"},
        {"Smithsonian Astrophysical Observation", "SAO 193937"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.43862558),
        dec: Angle.Degrees(-30.91963593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38950"},
        {"Hipparcos Number", "HIP 27391"},
        {"Smithsonian Astrophysical Observation", "SAO 196183"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.01028408),
        dec: Angle.Degrees(-30.91894578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133652"},
        {"Hipparcos Number", "HIP 73937"},
        {"Geneva Identification System", "GEN# +1.00133652"},
        {"Renson", "Renson 37900"},
        {"Smithsonian Astrophysical Observation", "SAO 206300"},
    },
    visualMagnitude: 5.97,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.63838694),
        dec: Angle.Degrees(-30.91841299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64974"},
        {"Hipparcos Number", "HIP 38686"},
        {"Smithsonian Astrophysical Observation", "SAO 198591"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.80777774),
        dec: Angle.Degrees(-30.91771061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7786"},
        {"Hipparcos Number", "HIP 5990"},
        {"Geneva Identification System", "GEN# +1.00007786"},
        {"Smithsonian Astrophysical Observation", "SAO 193023"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.26371676),
        dec: Angle.Degrees(-30.91769528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106409"},
        {"Hipparcos Number", "HIP 59691"},
        {"Smithsonian Astrophysical Observation", "SAO 203265"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.61390214),
        dec: Angle.Degrees(-30.91568434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
