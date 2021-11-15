using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_6() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197849"},
        {"Hipparcos Number", "HIP 102825"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.46818274),
        dec: Angle.Degrees(-65.55876627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21351"},
        {"Hipparcos Number", "HIP 15745"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.71796957),
        dec: Angle.Degrees(-65.55678419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32848"},
        {"Hipparcos Number", "HIP 23340"},
        {"Smithsonian Astrophysical Observation", "SAO 249169"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.30740770),
        dec: Angle.Degrees(-65.55286641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126611"},
        {"Hipparcos Number", "HIP 70853"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.33519832),
        dec: Angle.Degrees(-65.55000060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43551"},
        {"Hipparcos Number", "HIP 29415"},
        {"Smithsonian Astrophysical Observation", "SAO 249473"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.96417171),
        dec: Angle.Degrees(-65.54844040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105071"},
        {"Hipparcos Number", "HIP 59003"},
        {"Celescope Catalog", "CEL 4054"},
        {"Geneva Identification System", "GEN# +1.00105071"},
        {"Smithsonian Astrophysical Observation", "SAO 251734"},
        {"Wilson Evans Batten Catalogue", "WEB 10508"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.47344937),
        dec: Angle.Degrees(-65.54687537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214635"},
        {"Hipparcos Number", "HIP 112002"},
        {"Geneva Identification System", "GEN# +1.00214635"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.30591446),
        dec: Angle.Degrees(-65.54287047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121796"},
        {"Hipparcos Number", "HIP 68388"},
        {"Smithsonian Astrophysical Observation", "SAO 252546"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.99361791),
        dec: Angle.Degrees(-65.54208057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137700"},
        {"Hipparcos Number", "HIP 75998"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.81222005),
        dec: Angle.Degrees(-65.54097106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89360"},
        {"Hipparcos Number", "HIP 50317"},
        {"Smithsonian Astrophysical Observation", "SAO 250903"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.12843920),
        dec: Angle.Degrees(-65.54023930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43639"},
        {"Hipparcos Number", "HIP 29444"},
        {"Geneva Identification System", "GEN# +1.00043639"},
        {"Smithsonian Astrophysical Observation", "SAO 249478"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.05866394),
        dec: Angle.Degrees(-65.53435724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 167.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199491"},
        {"Hipparcos Number", "HIP 103721"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.26516601),
        dec: Angle.Degrees(-65.53388074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177345"},
        {"Hipparcos Number", "HIP 94063"},
        {"Geneva Identification System", "GEN# +1.00177345"},
        {"Smithsonian Astrophysical Observation", "SAO 254471"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.23811275),
        dec: Angle.Degrees(-65.53335098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170808"},
        {"Hipparcos Number", "HIP 91193"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.05018826),
        dec: Angle.Degrees(-65.53242786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187892"},
        {"Hipparcos Number", "HIP 98139"},
        {"Smithsonian Astrophysical Observation", "SAO 254686"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.17432331),
        dec: Angle.Degrees(-65.53228231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43618"},
        {"Hipparcos Number", "HIP 29439"},
        {"Geneva Identification System", "GEN# +1.00043618"},
        {"Smithsonian Astrophysical Observation", "SAO 249477"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.04667717),
        dec: Angle.Degrees(-65.53151686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 150.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19399"},
        {"Hipparcos Number", "HIP 14238"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.90215730),
        dec: Angle.Degrees(-65.52859014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144420"},
        {"Hipparcos Number", "HIP 79227"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.53633792),
        dec: Angle.Degrees(-65.52766358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110400"},
    },
    visualMagnitude: 12.11,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.42922717),
        dec: Angle.Degrees(-65.52618602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 148.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81536"},
        {"Hipparcos Number", "HIP 46010"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.75186361),
        dec: Angle.Degrees(-65.52580510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71240"},
        {"Hipparcos Number", "HIP 41017"},
        {"Renson", "Renson 19680"},
        {"Smithsonian Astrophysical Observation", "SAO 250208"},
    },
    visualMagnitude: 8.25,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.55912330),
        dec: Angle.Degrees(-65.52435930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72881"},
        {"Hipparcos Number", "HIP 41800"},
        {"Geneva Identification System", "GEN# +1.00072881"},
        {"Renson", "Renson 20200"},
        {"Smithsonian Astrophysical Observation", "SAO 250257"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.84011537),
        dec: Angle.Degrees(-65.52278731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224609"},
        {"Hipparcos Number", "HIP 118270"},
        {"Smithsonian Astrophysical Observation", "SAO 255617"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.83215675),
        dec: Angle.Degrees(-65.52241248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82486"},
        {"Hipparcos Number", "HIP 46510"},
        {"Smithsonian Astrophysical Observation", "SAO 250596"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.29550330),
        dec: Angle.Degrees(-65.52104856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216942"},
        {"Hipparcos Number", "HIP 113435"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.61088071),
        dec: Angle.Degrees(-65.51863165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62963"},
        {"Hipparcos Number", "HIP 37516"},
        {"Geneva Identification System", "GEN# +1.00062963"},
        {"Smithsonian Astrophysical Observation", "SAO 249928"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.49979293),
        dec: Angle.Degrees(-65.51854057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125073"},
        {"Hipparcos Number", "HIP 70036"},
        {"Smithsonian Astrophysical Observation", "SAO 252702"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.96539411),
        dec: Angle.Degrees(-65.51778101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63911"},
        {"Geneva Identification System", "GEN# -0.06402149"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.45085189),
        dec: Angle.Degrees(-65.51294457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88322"},
        {"Hipparcos Number", "HIP 49695"},
        {"Smithsonian Astrophysical Observation", "SAO 250833"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.17432959),
        dec: Angle.Degrees(-65.51111372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99438"},
        {"Hipparcos Number", "HIP 55770"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.41443992),
        dec: Angle.Degrees(-65.51030496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96548"},
        {"Hipparcos Number", "HIP 54283"},
        {"Celescope Catalog", "CEL 3808"},
        {"Geneva Identification System", "GEN# +1.00096548"},
        {"Smithsonian Astrophysical Observation", "SAO 251264"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.57169314),
        dec: Angle.Degrees(-65.50978461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106731"},
        {"Hipparcos Number", "HIP 59864"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.15686765),
        dec: Angle.Degrees(-65.50565657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207015"},
        {"Hipparcos Number", "HIP 107678"},
        {"Smithsonian Astrophysical Observation", "SAO 255076"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.18382851),
        dec: Angle.Degrees(-65.50287048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117111"},
        {"Hipparcos Number", "HIP 65848"},
        {"Geneva Identification System", "GEN# +1.00117111"},
        {"Wilson Evans Batten Catalogue", "WEB 11650"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.47740249),
        dec: Angle.Degrees(-65.50199115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148890"},
        {"Hipparcos Number", "HIP 81252"},
        {"Fundamental Katalog 5th Edition", "FK5 3312"},
        {"Geneva Identification System", "GEN# +1.00148890"},
        {"Smithsonian Astrophysical Observation", "SAO 253614"},
        {"Wilson Evans Batten Catalogue", "WEB 13732"},
    },
    visualMagnitude: 5.50,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.93654572),
        dec: Angle.Degrees(-65.49532908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82989"},
        {"Hipparcos Number", "HIP 46814"},
        {"Geneva Identification System", "GEN# +1.00082989"},
        {"Renson", "Renson 23660"},
        {"Smithsonian Astrophysical Observation", "SAO 250616"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.10084487),
        dec: Angle.Degrees(-65.49455464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222782"},
        {"Hipparcos Number", "HIP 117065"},
        {"Smithsonian Astrophysical Observation", "SAO 255555"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.98842879),
        dec: Angle.Degrees(-65.49058640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79337"},
        {"Hipparcos Number", "HIP 45016"},
        {"Geneva Identification System", "GEN# +1.00079337"},
        {"Smithsonian Astrophysical Observation", "SAO 250466"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.53244437),
        dec: Angle.Degrees(-65.48965108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161955"},
        {"Hipparcos Number", "HIP 87564"},
        {"Geneva Identification System", "GEN# +1.00161955"},
        {"Smithsonian Astrophysical Observation", "SAO 254063"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.32590763),
        dec: Angle.Degrees(-65.48844303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140081"},
        {"Hipparcos Number", "HIP 77189"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.42532281),
        dec: Angle.Degrees(-65.48543349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125833"},
        {"Hipparcos Number", "HIP 70462"},
        {"Geneva Identification System", "GEN# +1.00125833J"},
        {"Wilson Evans Batten Catalogue", "WEB 12224"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.19415310),
        dec: Angle.Degrees(-65.48405309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93147"},
        {"Hipparcos Number", "HIP 52474"},
        {"Smithsonian Astrophysical Observation", "SAO 251094"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.91398883),
        dec: Angle.Degrees(-65.47935821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41010"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.53789644),
        dec: Angle.Degrees(-65.47688286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174731"},
        {"Hipparcos Number", "HIP 92990"},
        {"Smithsonian Astrophysical Observation", "SAO 254411"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.16933079),
        dec: Angle.Degrees(-65.47619536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179255"},
        {"Hipparcos Number", "HIP 94723"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.11601412),
        dec: Angle.Degrees(-65.47072111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58942"},
        {"Hipparcos Number", "HIP 35805"},
        {"Smithsonian Astrophysical Observation", "SAO 249841"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.77453176),
        dec: Angle.Degrees(-65.46992997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76491"},
        {"Hipparcos Number", "HIP 43610"},
        {"Smithsonian Astrophysical Observation", "SAO 250366"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.22700525),
        dec: Angle.Degrees(-65.46970357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49006"},
        {"Hipparcos Number", "HIP 32035"},
        {"Geneva Identification System", "GEN# +1.00049006"},
        {"Smithsonian Astrophysical Observation", "SAO 249624"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.37519437),
        dec: Angle.Degrees(-65.46849056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4089"},
        {"Hipparcos Number", "HIP 3330"},
        {"Fundamental Katalog 5th Edition", "FK5 2047"},
        {"Geneva Identification System", "GEN# +1.00004089"},
        {"Smithsonian Astrophysical Observation", "SAO 248237"},
        {"Wilson Evans Batten Catalogue", "WEB 591"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.61790472),
        dec: Angle.Degrees(-65.46813002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185750"},
        {"Hipparcos Number", "HIP 97176"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.26678912),
        dec: Angle.Degrees(-65.46734274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4271"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.66170110),
        dec: Angle.Degrees(-65.46368843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62178"},
        {"Hipparcos Number", "HIP 37156"},
        {"Smithsonian Astrophysical Observation", "SAO 249906"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.53645969),
        dec: Angle.Degrees(-65.46180900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127907"},
        {"Hipparcos Number", "HIP 71465"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.23147037),
        dec: Angle.Degrees(-65.46046420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5405"},
        {"Hipparcos Number", "HIP 4273"},
        {"Smithsonian Astrophysical Observation", "SAO 248280"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.66774534),
        dec: Angle.Degrees(-65.45998762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6311"},
        {"Hipparcos Number", "HIP 4879"},
        {"Geneva Identification System", "GEN# +1.00006311"},
        {"Smithsonian Astrophysical Observation", "SAO 248308"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.67872783),
        dec: Angle.Degrees(-65.45611076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18292"},
        {"Hipparcos Number", "HIP 13429"},
        {"Smithsonian Astrophysical Observation", "SAO 248676"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.22769897),
        dec: Angle.Degrees(-65.45525503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118360"},
        {"Hipparcos Number", "HIP 66542"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.60453806),
        dec: Angle.Degrees(-65.45283132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36705"},
        {"Henry Draper 2", "HD 36705A"},
        {"Hipparcos Number", "HIP 25647"},
        {"Geneva Identification System", "GEN# +1.00036705"},
        {"Smithsonian Astrophysical Observation", "SAO 249286"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.18659539),
        dec: Angle.Degrees(-65.44893735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 150.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12452"},
        {"Hipparcos Number", "HIP 9308"},
        {"Geneva Identification System", "GEN# +1.00012452"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.89851771),
        dec: Angle.Degrees(-65.44835430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69445"},
    },
    visualMagnitude: 12.07,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.26472458),
        dec: Angle.Degrees(-65.44796517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85685"},
        {"Hipparcos Number", "HIP 48297"},
        {"Smithsonian Astrophysical Observation", "SAO 250722"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.70418153),
        dec: Angle.Degrees(-65.44657880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4394"},
        {"Geneva Identification System", "GEN# -0.06600071"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.08013332),
        dec: Angle.Degrees(-65.44535008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 257.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -223.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149679"},
        {"Hipparcos Number", "HIP 81654"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.20421776),
        dec: Angle.Degrees(-65.44473741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77390"},
        {"Geneva Identification System", "GEN# +1.00140484"},
        {"Smithsonian Astrophysical Observation", "SAO 253297"},
    },
    visualMagnitude: 5.54,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.97123090),
        dec: Angle.Degrees(-65.44218988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66482"},
        {"Hipparcos Number", "HIP 39065"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.89241849),
        dec: Angle.Degrees(-65.43625739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213366"},
        {"Hipparcos Number", "HIP 111286"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.16960010),
        dec: Angle.Degrees(-65.43536476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198736"},
        {"Hipparcos Number", "HIP 103320"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.99149208),
        dec: Angle.Degrees(-65.43293427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222744"},
        {"Hipparcos Number", "HIP 117045"},
        {"Geneva Identification System", "GEN# +1.00222744"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.90761753),
        dec: Angle.Degrees(-65.43115294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80742"},
        {"Hipparcos Number", "HIP 45647"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.56948557),
        dec: Angle.Degrees(-65.43082702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75795"},
        {"Hipparcos Number", "HIP 43231"},
        {"Smithsonian Astrophysical Observation", "SAO 250332"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.09515989),
        dec: Angle.Degrees(-65.43048178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196624"},
        {"Hipparcos Number", "HIP 102192"},
        {"Geneva Identification System", "GEN# +1.00196624"},
        {"Renson", "Renson 54850"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.58569486),
        dec: Angle.Degrees(-65.42964981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89518"},
        {"Hipparcos Number", "HIP 50403"},
        {"Smithsonian Astrophysical Observation", "SAO 250907"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.38156052),
        dec: Angle.Degrees(-65.42950716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86837"},
        {"Hipparcos Number", "HIP 48909"},
        {"Smithsonian Astrophysical Observation", "SAO 250769"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.65568105),
        dec: Angle.Degrees(-65.42902264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96920"},
        {"Hipparcos Number", "HIP 54449"},
        {"Smithsonian Astrophysical Observation", "SAO 251284"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.11000398),
        dec: Angle.Degrees(-65.42856265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97320"},
        {"Hipparcos Number", "HIP 54641"},
        {"Geneva Identification System", "GEN# +1.00097320"},
        {"Wilson Evans Batten Catalogue", "WEB 9860"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.75212771),
        dec: Angle.Degrees(-65.42666383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12270"},
        {"Hipparcos Number", "HIP 9149"},
        {"Geneva Identification System", "GEN# +1.00012270"},
        {"Smithsonian Astrophysical Observation", "SAO 248472"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.47237594),
        dec: Angle.Degrees(-65.42468427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89821",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89821"},
        {"Smithsonian Astrophysical Observation", "SAO 254208"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.95522599),
        dec: Angle.Degrees(-65.42414058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213756"},
        {"Hipparcos Number", "HIP 111509"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.87701994),
        dec: Angle.Degrees(-65.42057432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168477"},
        {"Hipparcos Number", "HIP 90237"},
        {"Smithsonian Astrophysical Observation", "SAO 254232"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.17040857),
        dec: Angle.Degrees(-65.41995647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29907"},
        {"Hipparcos Number", "HIP 21609"},
        {"Cincinnati Publication", "Ci 20 302"},
        {"Geneva Identification System", "GEN# +1.00029907"},
        {"Wilson Evans Batten Catalogue", "WEB 4151"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.58905075),
        dec: Angle.Degrees(-65.41904103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 732.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1249.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128571"},
        {"Hipparcos Number", "HIP 71755"},
        {"Geneva Identification System", "GEN# +1.00128571"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.16338070),
        dec: Angle.Degrees(-65.41838699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122453"},
        {"Hipparcos Number", "HIP 68750"},
        {"Smithsonian Astrophysical Observation", "SAO 252584"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.08695033),
        dec: Angle.Degrees(-65.41596737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96309"},
        {"Hipparcos Number", "HIP 54176"},
        {"Geneva Identification System", "GEN# +1.00096309"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.23414232),
        dec: Angle.Degrees(-65.41514225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22383"},
        {"Hipparcos Number", "HIP 16484"},
        {"Smithsonian Astrophysical Observation", "SAO 248831"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.06343013),
        dec: Angle.Degrees(-65.41433265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127281"},
        {"Hipparcos Number", "HIP 71160"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.31651839),
        dec: Angle.Degrees(-65.40644128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103270"},
        {"Hipparcos Number", "HIP 57963"},
        {"Celescope Catalog", "CEL 4004"},
        {"Geneva Identification System", "GEN# +1.00103270"},
        {"Smithsonian Astrophysical Observation", "SAO 251625"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.33456811),
        dec: Angle.Degrees(-65.40441059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103137"},
        {"Hipparcos Number", "HIP 57884"},
        {"Geneva Identification System", "GEN# +1.00103137"},
        {"Wilson Evans Batten Catalogue", "WEB 10377"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.07387933),
        dec: Angle.Degrees(-65.40418512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100264"},
        {"Hipparcos Number", "HIP 56232"},
        {"Geneva Identification System", "GEN# +1.00100264"},
        {"Smithsonian Astrophysical Observation", "SAO 251442"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.91219416),
        dec: Angle.Degrees(-65.40282515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2148"},
        {"Hipparcos Number", "HIP 1985"},
        {"Geneva Identification System", "GEN# +1.00002148"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.27702416),
        dec: Angle.Degrees(-65.39891755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91797"},
        {"Hipparcos Number", "HIP 51722"},
        {"Geneva Identification System", "GEN# +3.26020003"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.52201827),
        dec: Angle.Degrees(-65.39840167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101379J"},
        {"Henry Draper 2", "HD 101380"},
        {"Henry Draper 3", "HD 101379"},
        {"Hipparcos Number", "HIP 56862"},
        {"Celescope Catalog", "CEL 3949"},
        {"Smithsonian Astrophysical Observation", "SAO 251522"},
        {"Wilson Evans Batten Catalogue", "WEB 10240"},
    },
    visualMagnitude: 5.01,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.87347083),
        dec: Angle.Degrees(-65.39774890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118228"},
        {"Hipparcos Number", "HIP 66455"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.35179389),
        dec: Angle.Degrees(-65.39755057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198342"},
        {"Hipparcos Number", "HIP 103090"},
        {"Smithsonian Astrophysical Observation", "SAO 254890"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.31764590),
        dec: Angle.Degrees(-65.39681231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12696"},
        {"Hipparcos Number", "HIP 9471"},
        {"Geneva Identification System", "GEN# +1.00012696"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.46388306),
        dec: Angle.Degrees(-65.39615957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119298"},
        {"Hipparcos Number", "HIP 67049"},
    },
    visualMagnitude: 9.31,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.11308939),
        dec: Angle.Degrees(-65.39533757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104145"},
        {"Hipparcos Number", "HIP 58476"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.87114064),
        dec: Angle.Degrees(-65.39484936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133121"},
        {"Hipparcos Number", "HIP 73892"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.53556189),
        dec: Angle.Degrees(-65.38937898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57489"},
        {"Hipparcos Number", "HIP 35232"},
        {"Smithsonian Astrophysical Observation", "SAO 249807"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.22343261),
        dec: Angle.Degrees(-65.38645933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104824"},
        {"Hipparcos Number", "HIP 58853"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.05764168),
        dec: Angle.Degrees(-65.38531731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101903"},
        {"Hipparcos Number", "HIP 57145"},
        {"Smithsonian Astrophysical Observation", "SAO 251553"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.79510925),
        dec: Angle.Degrees(-65.37890237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83017"},
        {"Hipparcos Number", "HIP 46827"},
        {"Smithsonian Astrophysical Observation", "SAO 250617"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.13494441),
        dec: Angle.Degrees(-65.37835305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111766"},
        {"Cincinnati Publication", "Ci 20 1374"},
        {"Geneva Identification System", "GEN# +9.86119021"},
    },
    visualMagnitude: 11.50,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.61911518),
        dec: Angle.Degrees(-65.37811571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 833.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29032"},
        {"Hipparcos Number", "HIP 20954"},
        {"Smithsonian Astrophysical Observation", "SAO 249039"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.38705999),
        dec: Angle.Degrees(-65.37761182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33616"},
        {"Hipparcos Number", "HIP 23782"},
        {"Smithsonian Astrophysical Observation", "SAO 249195"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.66196819),
        dec: Angle.Degrees(-65.37630975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151441"},
        {"Hipparcos Number", "HIP 82517"},
        {"Fundamental Katalog 5th Edition", "FK5 3337"},
        {"Geneva Identification System", "GEN# +1.00151441"},
        {"Smithsonian Astrophysical Observation", "SAO 253717"},
        {"Wilson Evans Batten Catalogue", "WEB 13931"},
    },
    visualMagnitude: 6.12,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.97451958),
        dec: Angle.Degrees(-65.37542484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216924"},
        {"Hipparcos Number", "HIP 113430"},
        {"Geneva Identification System", "GEN# +1.00216924"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.59291602),
        dec: Angle.Degrees(-65.37154086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47149"},
        {"Hipparcos Number", "HIP 31160"},
        {"Smithsonian Astrophysical Observation", "SAO 249581"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.08075920),
        dec: Angle.Degrees(-65.37094702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187861"},
        {"Hipparcos Number", "HIP 98117"},
        {"Wilson Evans Batten Catalogue", "WEB 17293"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.11242478),
        dec: Angle.Degrees(-65.36873310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91698"},
        {"Hipparcos Number", "HIP 51680"},
        {"Celescope Catalog", "CEL 3579"},
        {"Geneva Identification System", "GEN# +3.26020001"},
        {"Smithsonian Astrophysical Observation", "SAO 251013"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.36911823),
        dec: Angle.Degrees(-65.36842710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203608"},
        {"Hipparcos Number", "HIP 105858"},
        {"Cincinnati Publication", "Ci 20 1280"},
        {"Fundamental Katalog 5th Edition", "FK5 805"},
        {"Geneva Identification System", "GEN# +1.00203608"},
        {"Smithsonian Astrophysical Observation", "SAO 254999"},
        {"Wilson Evans Batten Catalogue", "WEB 19198"},
    },
    visualMagnitude: 4.21,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.61038385),
        dec: Angle.Degrees(-65.36814438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 800.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144888"},
        {"Hipparcos Number", "HIP 79406"},
        {"Smithsonian Astrophysical Observation", "SAO 253458"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.08175318),
        dec: Angle.Degrees(-65.36502063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189566"},
        {"Hipparcos Number", "HIP 98891"},
        {"Geneva Identification System", "GEN# +1.00189566"},
        {"Smithsonian Astrophysical Observation", "SAO 254720"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.22561904),
        dec: Angle.Degrees(-65.36175403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -267.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20342"},
        {"Hipparcos Number", "HIP 14942"},
        {"Renson", "Renson 5070"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.15810383),
        dec: Angle.Degrees(-65.35861461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 569"},
        {"Hipparcos Number", "HIP 809"},
        {"Geneva Identification System", "GEN# +1.00000569"},
        {"Smithsonian Astrophysical Observation", "SAO 248131"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.49206123),
        dec: Angle.Degrees(-65.35709708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212105"},
        {"Hipparcos Number", "HIP 110567"},
        {"Geneva Identification System", "GEN# +1.00212105"},
        {"Smithsonian Astrophysical Observation", "SAO 255210"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.98165985),
        dec: Angle.Degrees(-65.35392561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152994"},
        {"Hipparcos Number", "HIP 83303"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.36585832),
        dec: Angle.Degrees(-65.34734413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218026"},
        {"Hipparcos Number", "HIP 114057"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.47979661),
        dec: Angle.Degrees(-65.33996765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15194"},
        {"Hipparcos Number", "HIP 11177"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.97502077),
        dec: Angle.Degrees(-65.33591859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194088"},
        {"Hipparcos Number", "HIP 100911"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.90095278),
        dec: Angle.Degrees(-65.33207572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16865"},
        {"Hipparcos Number", "HIP 12356"},
        {"Smithsonian Astrophysical Observation", "SAO 248614"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.76790773),
        dec: Angle.Degrees(-65.33187622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216518"},
        {"Hipparcos Number", "HIP 113160"},
        {"Smithsonian Astrophysical Observation", "SAO 255351"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.73043378),
        dec: Angle.Degrees(-65.33114660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159775"},
        {"Hipparcos Number", "HIP 86544"},
        {"Geneva Identification System", "GEN# +1.00159775"},
        {"Smithsonian Astrophysical Observation", "SAO 253995"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.29434961),
        dec: Angle.Degrees(-65.32776630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67278"},
        {"Hipparcos Number", "HIP 39379"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.76469239),
        dec: Angle.Degrees(-65.32584378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117979"},
        {"Hipparcos Number", "HIP 66341"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.94491961),
        dec: Angle.Degrees(-65.32448033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103924"},
        {"Hipparcos Number", "HIP 58350"},
        {"Geneva Identification System", "GEN# +1.00103924"},
        {"Smithsonian Astrophysical Observation", "SAO 251661"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.49336815),
        dec: Angle.Degrees(-65.32211180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117432"},
        {"Hipparcos Number", "HIP 66005"},
        {"Smithsonian Astrophysical Observation", "SAO 252345"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.99095111),
        dec: Angle.Degrees(-65.32181831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156479"},
        {"Hipparcos Number", "HIP 85005"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.61419175),
        dec: Angle.Degrees(-65.31941732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110737"},
        {"Hipparcos Number", "HIP 62205"},
        {"Geneva Identification System", "GEN# +1.00110737"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.23925543),
        dec: Angle.Degrees(-65.31925064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154291"},
        {"Hipparcos Number", "HIP 83928"},
        {"Smithsonian Astrophysical Observation", "SAO 253813"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.32562214),
        dec: Angle.Degrees(-65.31875159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195476"},
        {"Hipparcos Number", "HIP 101595"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.84752469),
        dec: Angle.Degrees(-65.31639831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47121"},
        {"Hipparcos Number", "HIP 31150"},
        {"Geneva Identification System", "GEN# +1.00047121"},
        {"Smithsonian Astrophysical Observation", "SAO 249579"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.04137612),
        dec: Angle.Degrees(-65.31587583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223606"},
        {"Hipparcos Number", "HIP 117613"},
        {"Geneva Identification System", "GEN# +1.00223606"},
        {"Smithsonian Astrophysical Observation", "SAO 255584"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.79002541),
        dec: Angle.Degrees(-65.31524723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30229"},
        {"Hipparcos Number", "HIP 21814"},
        {"Geneva Identification System", "GEN# +1.00030229"},
        {"Smithsonian Astrophysical Observation", "SAO 249079"},
        {"Wilson Evans Batten Catalogue", "WEB 4193"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.30163921),
        dec: Angle.Degrees(-65.31209287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205311"},
        {"Hipparcos Number", "HIP 106744"},
        {"Smithsonian Astrophysical Observation", "SAO 255036"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.34829292),
        dec: Angle.Degrees(-65.31165516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152138"},
        {"Hipparcos Number", "HIP 82872"},
        {"Smithsonian Astrophysical Observation", "SAO 253737"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.04198977),
        dec: Angle.Degrees(-65.31029028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206652"},
        {"Hipparcos Number", "HIP 107490"},
        {"Geneva Identification System", "GEN# +1.00206652"},
    },
    visualMagnitude: 9.25,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.57346613),
        dec: Angle.Degrees(-65.30788817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42465"},
        {"Hipparcos Number", "HIP 28891"},
        {"Geneva Identification System", "GEN# +1.00042465"},
        {"Smithsonian Astrophysical Observation", "SAO 249445"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.49462470),
        dec: Angle.Degrees(-65.30722937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113904"},
        {"Henry Draper 2", "HD 113904A"},
        {"Hipparcos Number", "HIP 64094"},
        {"Geneva Identification System", "GEN# +1.00113904"},
        {"Smithsonian Astrophysical Observation", "SAO 252162"},
        {"Wilson Evans Batten Catalogue", "WEB 11329"},
    },
    visualMagnitude: 5.44,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.02982892),
        dec: Angle.Degrees(-65.30601741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94989"},
        {"Hipparcos Number", "HIP 53489"},
        {"Geneva Identification System", "GEN# +1.00094989"},
        {"Smithsonian Astrophysical Observation", "SAO 251188"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.13602527),
        dec: Angle.Degrees(-65.30260312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219682"},
        {"Hipparcos Number", "HIP 115096"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.68774568),
        dec: Angle.Degrees(-65.30234806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204535"},
        {"Hipparcos Number", "HIP 106342"},
        {"Smithsonian Astrophysical Observation", "SAO 255016"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.06104342),
        dec: Angle.Degrees(-65.30215860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9908"},
        {"Hipparcos Number", "HIP 7360"},
        {"Geneva Identification System", "GEN# +1.00009908"},
        {"Smithsonian Astrophysical Observation", "SAO 248404"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.70474811),
        dec: Angle.Degrees(-65.29893831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10004"},
        {"Hipparcos Number", "HIP 7426"},
        {"Geneva Identification System", "GEN# +1.00010004"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.91976291),
        dec: Angle.Degrees(-65.29353386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64979"},
        {"Hipparcos Number", "HIP 38411"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.04180619),
        dec: Angle.Degrees(-65.29154773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114569"},
        {"Hipparcos Number", "HIP 64458"},
        {"Geneva Identification System", "GEN# +1.00114569"},
    },
    visualMagnitude: 8.08,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.18348710),
        dec: Angle.Degrees(-65.29140434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24674"},
        {"Hipparcos Number", "HIP 18032"},
        {"Geneva Identification System", "GEN# +1.00024674"},
        {"Smithsonian Astrophysical Observation", "SAO 248897"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.81330794),
        dec: Angle.Degrees(-65.29088548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189274"},
        {"Hipparcos Number", "HIP 98741"},
        {"Geneva Identification System", "GEN# +1.00189274"},
        {"Smithsonian Astrophysical Observation", "SAO 254716"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.83227003),
        dec: Angle.Degrees(-65.28969300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208304"},
        {"Hipparcos Number", "HIP 108445"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.52022961),
        dec: Angle.Degrees(-65.28601352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25120"},
        {"Hipparcos Number", "HIP 18343"},
        {"Geneva Identification System", "GEN# +1.00025120"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.82636608),
        dec: Angle.Degrees(-65.28490212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23345"},
        {"Hipparcos Number", "HIP 17153"},
        {"Smithsonian Astrophysical Observation", "SAO 248863"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.10861737),
        dec: Angle.Degrees(-65.28478365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77209"},
        {"Hipparcos Number", "HIP 43998"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.39065934),
        dec: Angle.Degrees(-65.28217166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115149"},
        {"Hipparcos Number", "HIP 64790"},
        {"Geneva Identification System", "GEN# +1.00115149"},
        {"Smithsonian Astrophysical Observation", "SAO 252236"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.18769159),
        dec: Angle.Degrees(-65.13812590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129043"},
        {"Hipparcos Number", "HIP 71988"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.84165129),
        dec: Angle.Degrees(-65.28081280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109478"},
        {"Hipparcos Number", "HIP 61457"},
        {"Geneva Identification System", "GEN# +1.00109478"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.91239769),
        dec: Angle.Degrees(-65.27802505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116832"},
        {"Smithsonian Astrophysical Observation", "SAO 255544"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.19888518),
        dec: Angle.Degrees(-65.27652271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186138"},
        {"Hipparcos Number", "HIP 97344"},
        {"Geneva Identification System", "GEN# +1.00186138"},
        {"Smithsonian Astrophysical Observation", "SAO 254645"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.76507812),
        dec: Angle.Degrees(-65.27575126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133456"},
        {"Hipparcos Number", "HIP 74047"},
        {"Geneva Identification System", "GEN# +1.00133456"},
        {"Smithsonian Astrophysical Observation", "SAO 253024"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.98645795),
        dec: Angle.Degrees(-65.27543844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48654"},
        {"Hipparcos Number", "HIP 31866"},
        {"Smithsonian Astrophysical Observation", "SAO 249617"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.92336142),
        dec: Angle.Degrees(-65.27443933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203451"},
        {"Hipparcos Number", "HIP 105778"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.34693925),
        dec: Angle.Degrees(-65.27304388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81870"},
        {"Hipparcos Number", "HIP 46208"},
        {"Geneva Identification System", "GEN# +1.00081870"},
        {"Smithsonian Astrophysical Observation", "SAO 250576"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.31925871),
        dec: Angle.Degrees(-65.27036804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220158"},
        {"Hipparcos Number", "HIP 115385"},
        {"Geneva Identification System", "GEN# +1.00220158"},
        {"Smithsonian Astrophysical Observation", "SAO 255469"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.60567108),
        dec: Angle.Degrees(-65.26180207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170196"},
        {"Hipparcos Number", "HIP 90927"},
        {"Smithsonian Astrophysical Observation", "SAO 254280"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.22077794),
        dec: Angle.Degrees(-65.26155654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39902"},
        {"Hipparcos Number", "HIP 27603"},
        {"Geneva Identification System", "GEN# +1.00039902"},
        {"Smithsonian Astrophysical Observation", "SAO 249373"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.66252356),
        dec: Angle.Degrees(-65.26019512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82820"},
        {"Geneva Identification System", "GEN# +6.20145002"},
    },
    visualMagnitude: 11.55,
    bvColour: 1.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.88100559),
        dec: Angle.Degrees(-65.25537729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -263.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 309769"},
        {"Hipparcos Number", "HIP 47686"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.84885903),
        dec: Angle.Degrees(-65.25516689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98658"},
        {"Hipparcos Number", "HIP 55355"},
    },
    visualMagnitude: 8.42,
    bvColour: 2.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.02599061),
        dec: Angle.Degrees(-65.25198512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29339"},
        {"Hipparcos Number", "HIP 21203"},
        {"Smithsonian Astrophysical Observation", "SAO 249051"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.19678895),
        dec: Angle.Degrees(-65.25143638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 271749"},
        {"Hipparcos Number", "HIP 28436"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.07625937),
        dec: Angle.Degrees(-65.24990011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172801"},
        {"Hipparcos Number", "HIP 92148"},
        {"Smithsonian Astrophysical Observation", "SAO 254364"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.71779737),
        dec: Angle.Degrees(-65.24960411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134938"},
        {"Hipparcos Number", "HIP 74712"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.03297968),
        dec: Angle.Degrees(-65.24658352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103225"},
        {"Hipparcos Number", "HIP 57940"},
        {"Geneva Identification System", "GEN# +1.00103225"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.23189872),
        dec: Angle.Degrees(-65.24161325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223188"},
        {"Hipparcos Number", "HIP 117353"},
        {"Geneva Identification System", "GEN# +1.00223188"},
        {"Smithsonian Astrophysical Observation", "SAO 255569"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.91624782),
        dec: Angle.Degrees(-65.24060553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208937"},
        {"Hipparcos Number", "HIP 108778"},
        {"Fundamental Katalog 5th Edition", "FK5 5947"},
        {"Smithsonian Astrophysical Observation", "SAO 255130"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.52871579),
        dec: Angle.Degrees(-65.23936493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17877"},
        {"Hipparcos Number", "HIP 13132"},
        {"Smithsonian Astrophysical Observation", "SAO 248657"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.22698989),
        dec: Angle.Degrees(-65.23895878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74791"},
        {"Hipparcos Number", "HIP 42722"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.59954389),
        dec: Angle.Degrees(-65.23830526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89324"},
    },
    visualMagnitude: 12.03,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.39402699),
        dec: Angle.Degrees(-65.23702819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34543"},
        {"Hipparcos Number", "HIP 24337"},
        {"Geneva Identification System", "GEN# +1.00034543"},
        {"Smithsonian Astrophysical Observation", "SAO 249221"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.35476591),
        dec: Angle.Degrees(-65.23614393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140643"},
        {"Hipparcos Number", "HIP 77444"},
        {"Geneva Identification System", "GEN# +1.00140643"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.15058671),
        dec: Angle.Degrees(-65.23268245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -289.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -295.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211617"},
        {"Hipparcos Number", "HIP 110306"},
        {"Fundamental Katalog 5th Edition", "FK5 5972"},
        {"Geneva Identification System", "GEN# +1.00211617"},
        {"Renson", "Renson 58740"},
        {"Smithsonian Astrophysical Observation", "SAO 255201"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.13055229),
        dec: Angle.Degrees(-65.23237386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128982"},
        {"Hipparcos Number", "HIP 71963"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.77165274),
        dec: Angle.Degrees(-65.22898573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90425"},
        {"Hipparcos Number", "HIP 50952"},
        {"Geneva Identification System", "GEN# +1.00090425"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.09246046),
        dec: Angle.Degrees(-65.22840506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179419"},
        {"Hipparcos Number", "HIP 94770"},
        {"Fundamental Katalog 5th Edition", "FK5 3538"},
        {"Geneva Identification System", "GEN# +1.00179419"},
        {"Smithsonian Astrophysical Observation", "SAO 254514"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.25219158),
        dec: Angle.Degrees(-65.22764410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57999"},
        {"Hipparcos Number", "HIP 35441"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.75695258),
        dec: Angle.Degrees(-65.22564854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39334"},
    },
    visualMagnitude: 11.68,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.61840536),
        dec: Angle.Degrees(-65.22024028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97522"},
        {"Hipparcos Number", "HIP 54727"},
        {"Celescope Catalog", "CEL 3847"},
        {"Geneva Identification System", "GEN# +1.00097522"},
        {"Smithsonian Astrophysical Observation", "SAO 251315"},
        {"Wilson Evans Batten Catalogue", "WEB 9880"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.06769638),
        dec: Angle.Degrees(-65.21893061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9187"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.57712919),
        dec: Angle.Degrees(-65.21856738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 196.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148276"},
        {"Hipparcos Number", "HIP 80916"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.85253177),
        dec: Angle.Degrees(-65.21818160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80918"},
    },
    visualMagnitude: 10.28,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.85605729),
        dec: Angle.Degrees(-65.21592015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124880"},
        {"Hipparcos Number", "HIP 69938"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.68553684),
        dec: Angle.Degrees(-65.21368543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113708"},
        {"Hipparcos Number", "HIP 63991"},
        {"Geneva Identification System", "GEN# +1.00113708"},
        {"Smithsonian Astrophysical Observation", "SAO 252152"},
        {"Wilson Evans Batten Catalogue", "WEB 11310"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.70142069),
        dec: Angle.Degrees(-65.21213997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120785"},
        {"Hipparcos Number", "HIP 67833"},
        {"Geneva Identification System", "GEN# +1.00120785"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.42347249),
        dec: Angle.Degrees(-65.21205178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7974"},
        {"Hipparcos Number", "HIP 6039"},
        {"Smithsonian Astrophysical Observation", "SAO 248354"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.39579095),
        dec: Angle.Degrees(-65.21178029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108002"},
        {"Hipparcos Number", "HIP 60570"},
        {"Celescope Catalog", "CEL 4101"},
        {"Geneva Identification System", "GEN# +1.00108002"},
        {"Smithsonian Astrophysical Observation", "SAO 251889"},
        {"Wilson Evans Batten Catalogue", "WEB 10769"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.23318515),
        dec: Angle.Degrees(-65.21101270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103079"},
        {"Hipparcos Number", "HIP 57851"},
        {"Celescope Catalog", "CEL 3998"},
        {"Geneva Identification System", "GEN# +1.00103079"},
        {"Smithsonian Astrophysical Observation", "SAO 251617"},
        {"Wilson Evans Batten Catalogue", "WEB 10376"},
    },
    visualMagnitude: 4.89,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.96363695),
        dec: Angle.Degrees(-65.20589445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152493"},
        {"Hipparcos Number", "HIP 83053"},
        {"Geneva Identification System", "GEN# +1.00152493"},
        {"Renson", "Renson 43190"},
        {"Smithsonian Astrophysical Observation", "SAO 253753"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.56468155),
        dec: Angle.Degrees(-65.20441240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29322"},
        {"Cincinnati Publication", "Ci 20 381"},
    },
    visualMagnitude: 11.29,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.74846460),
        dec: Angle.Degrees(-65.20393725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -756.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166252"},
        {"Hipparcos Number", "HIP 89394"},
        {"Geneva Identification System", "GEN# +1.00166252"},
        {"Smithsonian Astrophysical Observation", "SAO 254181"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.64187082),
        dec: Angle.Degrees(-65.19897292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181794"},
        {"Hipparcos Number", "HIP 95567"},
        {"Smithsonian Astrophysical Observation", "SAO 254570"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.59041787),
        dec: Angle.Degrees(-65.19631341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106616"},
        {"Hipparcos Number", "HIP 59823"},
        {"Celescope Catalog", "CEL 4080"},
        {"Geneva Identification System", "GEN# +1.00106616"},
        {"Smithsonian Astrophysical Observation", "SAO 251818"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.00800241),
        dec: Angle.Degrees(-65.19260776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79606"},
        {"Hipparcos Number", "HIP 45140"},
        {"Geneva Identification System", "GEN# +1.00079606"},
        {"Renson", "Renson 22620"},
        {"Smithsonian Astrophysical Observation", "SAO 250478"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.96051921),
        dec: Angle.Degrees(-65.19239989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169351"},
        {"Hipparcos Number", "HIP 90582"},
        {"Geneva Identification System", "GEN# +1.00169351"},
        {"Smithsonian Astrophysical Observation", "SAO 254256"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.25742791),
        dec: Angle.Degrees(-65.18868142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25171"},
        {"Hipparcos Number", "HIP 18387"},
        {"Geneva Identification System", "GEN# +1.00025171"},
        {"Smithsonian Astrophysical Observation", "SAO 248911"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.95516702),
        dec: Angle.Degrees(-65.18687266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19524"},
        {"Hipparcos Number", "HIP 14333"},
        {"Geneva Identification System", "GEN# +1.00019524"},
        {"Smithsonian Astrophysical Observation", "SAO 248726"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.20921228),
        dec: Angle.Degrees(-65.18480702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91094"},
        {"Hipparcos Number", "HIP 51327"},
        {"Geneva Identification System", "GEN# +1.00091094"},
        {"Smithsonian Astrophysical Observation", "SAO 250981"},
        {"Wilson Evans Batten Catalogue", "WEB 9375"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.26529712),
        dec: Angle.Degrees(-65.17633489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34349"},
        {"Hipparcos Number", "HIP 24221"},
        {"Geneva Identification System", "GEN# +1.00034349"},
        {"Smithsonian Astrophysical Observation", "SAO 249218"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.01253399),
        dec: Angle.Degrees(-65.17585190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130739"},
        {"Hipparcos Number", "HIP 72822"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.27324168),
        dec: Angle.Degrees(-65.17092570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39567"},
        {"Hipparcos Number", "HIP 27436"},
        {"Smithsonian Astrophysical Observation", "SAO 249362"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.14637931),
        dec: Angle.Degrees(-65.16842098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121601"},
        {"Hipparcos Number", "HIP 68285"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.67809443),
        dec: Angle.Degrees(-65.16783530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88894"},
        {"Hipparcos Number", "HIP 50038"},
        {"Smithsonian Astrophysical Observation", "SAO 250872"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.23906042),
        dec: Angle.Degrees(-65.16649408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164392"},
        {"Hipparcos Number", "HIP 88620"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.40329523),
        dec: Angle.Degrees(-65.16524432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115864"},
        {"Hipparcos Number", "HIP 65188"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.38527162),
        dec: Angle.Degrees(-65.16315798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177247"},
        {"Hipparcos Number", "HIP 94008"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.10096303),
        dec: Angle.Degrees(-65.15803021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141413"},
        {"Hipparcos Number", "HIP 77785"},
        {"Geneva Identification System", "GEN# +1.00141413"},
        {"Smithsonian Astrophysical Observation", "SAO 253323"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.23616420),
        dec: Angle.Degrees(-65.15251720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117960"},
        {"Hipparcos Number", "HIP 66333"},
        {"Geneva Identification System", "GEN# +1.00117960"},
        {"Smithsonian Astrophysical Observation", "SAO 252377"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.91017185),
        dec: Angle.Degrees(-65.15195812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88471"},
        {"Hipparcos Number", "HIP 49799"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.47552451),
        dec: Angle.Degrees(-65.14935200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198193"},
        {"Hipparcos Number", "HIP 103008"},
        {"Smithsonian Astrophysical Observation", "SAO 254887"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.05438643),
        dec: Angle.Degrees(-65.14484048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89805"},
        {"Hipparcos Number", "HIP 50562"},
        {"Smithsonian Astrophysical Observation", "SAO 250921"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.92517522),
        dec: Angle.Degrees(-65.13724358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12992"},
        {"Hipparcos Number", "HIP 9686"},
        {"Geneva Identification System", "GEN# +1.00012992"},
        {"Smithsonian Astrophysical Observation", "SAO 248489"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.14718233),
        dec: Angle.Degrees(-65.13702141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 310331"},
        {"Hipparcos Number", "HIP 53536"},
        {"Geneva Identification System", "GEN# +1.00310331"},
        {"Wilson Evans Batten Catalogue", "WEB 9720"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.28842726),
        dec: Angle.Degrees(-65.13476179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38667"},
        {"Hipparcos Number", "HIP 26897"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.65288587),
        dec: Angle.Degrees(-65.13011355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117216"},
        {"Hipparcos Number", "HIP 65904"},
        {"Geneva Identification System", "GEN# +1.00117216"},
        {"Wilson Evans Batten Catalogue", "WEB 11659"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.65041611),
        dec: Angle.Degrees(-65.13000270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33985"},
        {"Hipparcos Number", "HIP 23984"},
        {"Smithsonian Astrophysical Observation", "SAO 249204"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.33321623),
        dec: Angle.Degrees(-65.12931808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 271671"},
        {"Hipparcos Number", "HIP 27948"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.71092989),
        dec: Angle.Degrees(-65.12503418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 238.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3444"},
        {"Hipparcos Number", "HIP 2889"},
        {"Geneva Identification System", "GEN# +1.00003444"},
        {"Smithsonian Astrophysical Observation", "SAO 248225"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.15663761),
        dec: Angle.Degrees(-65.12442483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1926"},
        {"Hipparcos Number", "HIP 1823"},
        {"Geneva Identification System", "GEN# +1.00001926"},
        {"Smithsonian Astrophysical Observation", "SAO 248177"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.77034239),
        dec: Angle.Degrees(-65.12101551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9477"},
        {"Hipparcos Number", "HIP 7082"},
        {"Geneva Identification System", "GEN# +1.00009477"},
        {"Smithsonian Astrophysical Observation", "SAO 248394"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.81247885),
        dec: Angle.Degrees(-65.11866698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 277.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9405"},
        {"Hipparcos Number", "HIP 7030"},
        {"Geneva Identification System", "GEN# +1.00009405"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.64829346),
        dec: Angle.Degrees(-65.11736596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29254"},
        {"Hipparcos Number", "HIP 21150"},
        {"Smithsonian Astrophysical Observation", "SAO 249048"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.01376418),
        dec: Angle.Degrees(-65.11500473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138497"},
        {"Hipparcos Number", "HIP 76396"},
        {"Renson", "Renson 39430"},
        {"Smithsonian Astrophysical Observation", "SAO 253221"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.04959809),
        dec: Angle.Degrees(-65.11449348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1706"},
        {"Hipparcos Number", "HIP 1672"},
        {"Smithsonian Astrophysical Observation", "SAO 248168"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.23037842),
        dec: Angle.Degrees(-65.11352579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162702"},
        {"Hipparcos Number", "HIP 87878"},
        {"Geneva Identification System", "GEN# +1.00162702"},
        {"Smithsonian Astrophysical Observation", "SAO 254082"},
        {"Wilson Evans Batten Catalogue", "WEB 14834"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.27335906),
        dec: Angle.Degrees(-65.11346309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44778"},
        {"Hipparcos Number", "HIP 29995"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.71096651),
        dec: Angle.Degrees(-65.11344672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27865"},
        {"Hipparcos Number", "HIP 20172"},
        {"Smithsonian Astrophysical Observation", "SAO 248995"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.86193139),
        dec: Angle.Degrees(-65.10613573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209720"},
        {"Hipparcos Number", "HIP 109233"},
        {"Smithsonian Astrophysical Observation", "SAO 255148"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.94014003),
        dec: Angle.Degrees(-65.10315684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138242"},
        {"Hipparcos Number", "HIP 76254"},
        {"Smithsonian Astrophysical Observation", "SAO 253216"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.64219911),
        dec: Angle.Degrees(-65.10307699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19088"},
        {"Hipparcos Number", "HIP 14041"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.21449848),
        dec: Angle.Degrees(-65.10269269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38893"},
        {"Hipparcos Number", "HIP 27047"},
        {"Geneva Identification System", "GEN# +1.00038893"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.03798124),
        dec: Angle.Degrees(-65.10200163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92664"},
        {"Hipparcos Number", "HIP 52221"},
        {"Celescope Catalog", "CEL 3632"},
        {"Geneva Identification System", "GEN# +1.00092664"},
        {"Geneva Identification System 2", "GEN# +3.26020027"},
        {"Renson", "Renson 26750"},
        {"Smithsonian Astrophysical Observation", "SAO 251059"},
        {"Wilson Evans Batten Catalogue", "WEB 9514"},
    },
    visualMagnitude: 5.51,
    bvColour: -0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.04776480),
        dec: Angle.Degrees(-65.10024026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84191"},
        {"Hipparcos Number", "HIP 47470"},
        {"Smithsonian Astrophysical Observation", "SAO 250661"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.14786377),
        dec: Angle.Degrees(-65.09838070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131470"},
        {"Hipparcos Number", "HIP 73149"},
        {"Smithsonian Astrophysical Observation", "SAO 252966"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.23690736),
        dec: Angle.Degrees(-65.09791545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163927"},
        {"Hipparcos Number", "HIP 88443"},
        {"Geneva Identification System", "GEN# +1.00163927"},
        {"Smithsonian Astrophysical Observation", "SAO 254121"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.84814026),
        dec: Angle.Degrees(-65.09447580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132988"},
        {"Hipparcos Number", "HIP 73838"},
        {"Renson", "Renson 37760"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.35296093),
        dec: Angle.Degrees(-65.09107729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200923"},
        {"Hipparcos Number", "HIP 104464"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.42312442),
        dec: Angle.Degrees(-65.08890600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50159"},
        {"Hipparcos Number", "HIP 32529"},
        {"Smithsonian Astrophysical Observation", "SAO 249644"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.81437045),
        dec: Angle.Degrees(-65.08874426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42989"},
        {"Hipparcos Number", "HIP 29157"},
        {"Fundamental Katalog 5th Edition", "FK5 4561"},
        {"Smithsonian Astrophysical Observation", "SAO 249460"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.25872024),
        dec: Angle.Degrees(-65.08641374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119942"},
        {"Hipparcos Number", "HIP 67360"},
        {"Smithsonian Astrophysical Observation", "SAO 252458"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.09362664),
        dec: Angle.Degrees(-65.08575919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145671"},
        {"Hipparcos Number", "HIP 79735"},
        {"Geneva Identification System", "GEN# +1.00145671"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.09549161),
        dec: Angle.Degrees(-65.08520936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92570"},
        {"Hipparcos Number", "HIP 52171"},
        {"Geneva Identification System", "GEN# +3.26020025"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.87796484),
        dec: Angle.Degrees(-65.08332997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216436"},
        {"Hipparcos Number", "HIP 113113"},
        {"Geneva Identification System", "GEN# +1.00216436"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.58962516),
        dec: Angle.Degrees(-65.08141707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 319.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -205.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116748"},
        {"Hipparcos Number", "HIP 65624"},
        {"Renson", "Renson 33690"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.81938270),
        dec: Angle.Degrees(-65.08071495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159753"},
        {"Hipparcos Number", "HIP 86536"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.27167382),
        dec: Angle.Degrees(-65.07841283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173168"},
        {"Hipparcos Number", "HIP 92294"},
        {"Geneva Identification System", "GEN# +1.00173168"},
        {"Smithsonian Astrophysical Observation", "SAO 254374"},
        {"Wilson Evans Batten Catalogue", "WEB 15924"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.15815797),
        dec: Angle.Degrees(-65.07748945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135716"},
        {"Hipparcos Number", "HIP 75052"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.04125442),
        dec: Angle.Degrees(-65.07644124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82357"},
        {"Geneva Identification System", "GEN# +6.20145001"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.42698852),
        dec: Angle.Degrees(-65.07581337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196318"},
        {"Hipparcos Number", "HIP 102007"},
        {"Smithsonian Astrophysical Observation", "SAO 254845"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.06863499),
        dec: Angle.Degrees(-65.07244080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85123"},
        {"Hipparcos Number", "HIP 48002"},
        {"Geneva Identification System", "GEN# +1.00085123"},
        {"Smithsonian Astrophysical Observation", "SAO 250695"},
        {"Wilson Evans Batten Catalogue", "WEB 8979"},
    },
    visualMagnitude: 2.92,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.77557340),
        dec: Angle.Degrees(-65.07201888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150389"},
        {"Hipparcos Number", "HIP 82009"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.28836884),
        dec: Angle.Degrees(-65.07061574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139339"},
        {"Hipparcos Number", "HIP 76843"},
        {"Geneva Identification System", "GEN# +1.00139339"},
        {"Smithsonian Astrophysical Observation", "SAO 253254"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.35626717),
        dec: Angle.Degrees(-65.06808597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 307760"},
        {"Hipparcos Number", "HIP 51031"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.38730831),
        dec: Angle.Degrees(-65.06628991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120928"},
        {"Hipparcos Number", "HIP 67912"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.64433962),
        dec: Angle.Degrees(-65.06515981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1445"},
        {"Hipparcos Number", "HIP 1458"},
        {"Smithsonian Astrophysical Observation", "SAO 248158"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.54249865),
        dec: Angle.Degrees(-65.06328937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206382"},
        {"Hipparcos Number", "HIP 107349"},
    },
    visualMagnitude: 10.16,
    bvColour: 2.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.12993217),
        dec: Angle.Degrees(-65.05939599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207495"},
        {"Hipparcos Number", "HIP 107922"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.97409679),
        dec: Angle.Degrees(-65.05808759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96358"},
        {"Hipparcos Number", "HIP 54194"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.31100948),
        dec: Angle.Degrees(-65.05404074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80060"},
        {"Hipparcos Number", "HIP 45340"},
        {"Geneva Identification System", "GEN# +1.00080060"},
        {"Smithsonian Astrophysical Observation", "SAO 250505"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.59489373),
        dec: Angle.Degrees(-65.05396982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101055"},
        {"Hipparcos Number", "HIP 56678"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.32097724),
        dec: Angle.Degrees(-65.05126889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137355"},
        {"Hipparcos Number", "HIP 75812"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.30478173),
        dec: Angle.Degrees(-65.05030169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98525"},
        {"Hipparcos Number", "HIP 55273"},
        {"Smithsonian Astrophysical Observation", "SAO 251356"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.80290266),
        dec: Angle.Degrees(-65.04937350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149238"},
        {"Hipparcos Number", "HIP 81424"},
        {"Geneva Identification System", "GEN# +1.00149238"},
        {"Smithsonian Astrophysical Observation", "SAO 253629"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.44822806),
        dec: Angle.Degrees(-65.04648650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158785"},
        {"Hipparcos Number", "HIP 86105"},
        {"Geneva Identification System", "GEN# +1.00158785"},
        {"Smithsonian Astrophysical Observation", "SAO 253967"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.96000253),
        dec: Angle.Degrees(-65.04521898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126466"},
        {"Hipparcos Number", "HIP 70773"},
        {"Geneva Identification System", "GEN# +1.00126466"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.11995517),
        dec: Angle.Degrees(-65.04453743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49800"},
        {"Hipparcos Number", "HIP 32374"},
        {"Smithsonian Astrophysical Observation", "SAO 249640"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.35534560),
        dec: Angle.Degrees(-65.04422538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124895"},
        {"Hipparcos Number", "HIP 69937"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.68474597),
        dec: Angle.Degrees(-65.04347814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92385"},
        {"Hipparcos Number", "HIP 52059"},
        {"Celescope Catalog", "CEL 3607"},
        {"Geneva Identification System", "GEN# +3.26020017"},
        {"Renson", "Renson 26620"},
        {"Smithsonian Astrophysical Observation", "SAO 251042"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.57323935),
        dec: Angle.Degrees(-65.04196364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91711"},
        {"Hipparcos Number", "HIP 51692"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.39574734),
        dec: Angle.Degrees(-65.04122278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7517"},
        {"Hipparcos Number", "HIP 5729"},
        {"Smithsonian Astrophysical Observation", "SAO 248337"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.41762357),
        dec: Angle.Degrees(-65.03771097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142514"},
        {"Henry Draper 2", "HD 142514A"},
        {"Hipparcos Number", "HIP 78279"},
        {"Geneva Identification System", "GEN# +1.00142514"},
        {"Smithsonian Astrophysical Observation", "SAO 253362"},
        {"Wilson Evans Batten Catalogue", "WEB 13236"},
    },
    visualMagnitude: 5.74,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.74233223),
        dec: Angle.Degrees(-65.03756903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115266"},
        {"Hipparcos Number", "HIP 64840"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.37812873),
        dec: Angle.Degrees(-65.03580528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147263"},
        {"Hipparcos Number", "HIP 80438"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.29014546),
        dec: Angle.Degrees(-65.03387507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114739"},
        {"Hipparcos Number", "HIP 64552"},
        {"Geneva Identification System", "GEN# +1.00114739"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.47297613),
        dec: Angle.Degrees(-65.03347998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195805"},
        {"Hipparcos Number", "HIP 101725"},
        {"Smithsonian Astrophysical Observation", "SAO 254831"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.29591603),
        dec: Angle.Degrees(-65.03325086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65117"},
        {"Hipparcos Number", "HIP 38486"},
        {"Smithsonian Astrophysical Observation", "SAO 249992"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.22406457),
        dec: Angle.Degrees(-65.03112602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183581"},
        {"Hipparcos Number", "HIP 96284"},
        {"Geneva Identification System", "GEN# +1.00183581"},
        {"Smithsonian Astrophysical Observation", "SAO 254595"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.66469474),
        dec: Angle.Degrees(-65.03075458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37351"},
        {"Hipparcos Number", "HIP 26030"},
        {"Geneva Identification System", "GEN# +1.00037351"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.30656958),
        dec: Angle.Degrees(-65.02303174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77077"},
        {"Hipparcos Number", "HIP 43914"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.19067914),
        dec: Angle.Degrees(-65.02130258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211224"},
        {"Hipparcos Number", "HIP 110072"},
        {"Geneva Identification System", "GEN# +1.00211224"},
        {"Smithsonian Astrophysical Observation", "SAO 255184"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.43822374),
        dec: Angle.Degrees(-65.01860374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100101"},
        {"Hipparcos Number", "HIP 56133"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.59681274),
        dec: Angle.Degrees(-65.01755931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32255"},
        {"Hipparcos Number", "HIP 23028"},
        {"Smithsonian Astrophysical Observation", "SAO 249154"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.27707392),
        dec: Angle.Degrees(-65.01602366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107223"},
        {"Hipparcos Number", "HIP 60137"},
        {"Geneva Identification System", "GEN# +1.00107223"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.99079640),
        dec: Angle.Degrees(-65.01401826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47672"},
        {"Hipparcos Number", "HIP 31428"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.78043163),
        dec: Angle.Degrees(-65.01164706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21576"},
        {"Hipparcos Number", "HIP 15924"},
        {"Smithsonian Astrophysical Observation", "SAO 248801"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.28755775),
        dec: Angle.Degrees(-65.00529089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191468"},
        {"Hipparcos Number", "HIP 99724"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.53228406),
        dec: Angle.Degrees(-65.00472494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4839"},
        {"Hipparcos Number", "HIP 3851"},
        {"Smithsonian Astrophysical Observation", "SAO 248261"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.36595437),
        dec: Angle.Degrees(-65.00449365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86101"},
        {"Hipparcos Number", "HIP 48526"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.45600237),
        dec: Angle.Degrees(-65.00448863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88689"},
        {"Hipparcos Number", "HIP 49912"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.85837203),
        dec: Angle.Degrees(-65.00407400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131782"},
        {"Hipparcos Number", "HIP 73295"},
        {"Geneva Identification System", "GEN# +1.00131782"},
        {"Smithsonian Astrophysical Observation", "SAO 252979"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.68744156),
        dec: Angle.Degrees(-65.00372239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141450"},
        {"Hipparcos Number", "HIP 77800"},
        {"Smithsonian Astrophysical Observation", "SAO 253326"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.29879685),
        dec: Angle.Degrees(-65.00286418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157321"},
        {"Hipparcos Number", "HIP 85420"},
        {"Geneva Identification System", "GEN# +1.00157321"},
        {"Smithsonian Astrophysical Observation", "SAO 253924"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.82937696),
        dec: Angle.Degrees(-65.00206635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36750"},
        {"Hipparcos Number", "HIP 25692"},
        {"Smithsonian Astrophysical Observation", "SAO 249291"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.29670067),
        dec: Angle.Degrees(-64.99984386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83359"},
        {"Hipparcos Number", "HIP 47017"},
        {"Geneva Identification System", "GEN# +1.00083359"},
        {"Smithsonian Astrophysical Observation", "SAO 250629"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.73544336),
        dec: Angle.Degrees(-64.99956286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84074"},
        {"Hipparcos Number", "HIP 47418"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.93527196),
        dec: Angle.Degrees(-64.99557729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154824"},
        {"Hipparcos Number", "HIP 84174"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.10469401),
        dec: Angle.Degrees(-64.99417280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13368"},
        {"Hipparcos Number", "HIP 9953"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.03107779),
        dec: Angle.Degrees(-64.99412760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83946"},
        {"Hipparcos Number", "HIP 47351"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.72563577),
        dec: Angle.Degrees(-64.99086063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177853"},
        {"Hipparcos Number", "HIP 94219"},
        {"Geneva Identification System", "GEN# +1.00177853"},
        {"Smithsonian Astrophysical Observation", "SAO 254479"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.70576689),
        dec: Angle.Degrees(-64.99079497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22208"},
        {"Hipparcos Number", "HIP 16355"},
        {"Smithsonian Astrophysical Observation", "SAO 248822"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.68315604),
        dec: Angle.Degrees(-64.98672918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145114"},
        {"Hipparcos Number", "HIP 79507"},
        {"Smithsonian Astrophysical Observation", "SAO 253460"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.36673662),
        dec: Angle.Degrees(-64.98563142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107854"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.76811268),
        dec: Angle.Degrees(-64.97843192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30630"},
        {"Hipparcos Number", "HIP 22072"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.21414871),
        dec: Angle.Degrees(-64.97617605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92478"},
        {"Hipparcos Number", "HIP 52132"},
        {"Celescope Catalog", "CEL 3618"},
        {"Geneva Identification System", "GEN# +3.26020019"},
        {"Smithsonian Astrophysical Observation", "SAO 251046"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.76049959),
        dec: Angle.Degrees(-64.97498220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128898"},
        {"Hipparcos Number", "HIP 71908"},
        {"Fundamental Katalog 5th Edition", "FK5 539"},
        {"Geneva Identification System", "GEN# +1.00128898A"},
        {"Renson", "Renson 36710"},
        {"Smithsonian Astrophysical Observation", "SAO 252853"},
        {"Wilson Evans Batten Catalogue", "WEB 12383"},
    },
    visualMagnitude: 3.18,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.62785433),
        dec: Angle.Degrees(-64.97456957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134187"},
        {"Hipparcos Number", "HIP 74375"},
        {"Geneva Identification System", "GEN# +1.00134187"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.98329081),
        dec: Angle.Degrees(-64.97214110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27305"},
        {"Hipparcos Number", "HIP 19773"},
        {"Geneva Identification System", "GEN# +1.00027305"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.59189128),
        dec: Angle.Degrees(-64.96750325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212581"},
        {"Henry Draper 2", "HD 212581A"},
        {"Hipparcos Number", "HIP 110838"},
        {"Geneva Identification System", "GEN# +1.00212581"},
        {"Smithsonian Astrophysical Observation", "SAO 255222"},
        {"Wilson Evans Batten Catalogue", "WEB 19851"},
    },
    visualMagnitude: 4.51,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.83280453),
        dec: Angle.Degrees(-64.96637927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110715"},
        {"Hipparcos Number", "HIP 62193"},
        {"Geneva Identification System", "GEN# +1.00110715"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.20349803),
        dec: Angle.Degrees(-64.96436518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107357"},
        {"Hipparcos Number", "HIP 60211"},
        {"Geneva Identification System", "GEN# +1.00107357"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.20483156),
        dec: Angle.Degrees(-64.96038980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96850"},
        {"Hipparcos Number", "HIP 54405"},
        {"Geneva Identification System", "GEN# +1.00096850"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.99282154),
        dec: Angle.Degrees(-64.95597989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55597"},
        {"Celescope Catalog", "CEL 3892"},
        {"Geneva Identification System", "GEN# +1.00099104"},
    },
    visualMagnitude: 5.09,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.83929752),
        dec: Angle.Degrees(-64.95473134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157461"},
        {"Hipparcos Number", "HIP 85477"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.01995625),
        dec: Angle.Degrees(-64.95103486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83523"},
        {"Hipparcos Number", "HIP 47115"},
        {"Geneva Identification System", "GEN# +1.00083523"},
        {"Smithsonian Astrophysical Observation", "SAO 250636"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.02179812),
        dec: Angle.Degrees(-64.95034746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105939"},
        {"Hipparcos Number", "HIP 59457"},
        {"Geneva Identification System", "GEN# +1.00105939"},
        {"Smithsonian Astrophysical Observation", "SAO 251782"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.93451338),
        dec: Angle.Degrees(-64.94867427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75573"},
        {"Hipparcos Number", "HIP 43140"},
        {"Smithsonian Astrophysical Observation", "SAO 250329"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.80698752),
        dec: Angle.Degrees(-64.94337714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65389"},
        {"Hipparcos Number", "HIP 38605"},
        {"Smithsonian Astrophysical Observation", "SAO 250007"},
    },
    visualMagnitude: 8.97,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.55944032),
        dec: Angle.Degrees(-64.94152708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198969"},
        {"Hipparcos Number", "HIP 103437"},
        {"Geneva Identification System", "GEN# +1.00198969"},
        {"Smithsonian Astrophysical Observation", "SAO 254904"},
        {"Wilson Evans Batten Catalogue", "WEB 18812"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.34280763),
        dec: Angle.Degrees(-64.93805285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134147"},
        {"Hipparcos Number", "HIP 74344"},
        {"Geneva Identification System", "GEN# +1.00134147"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.90941867),
        dec: Angle.Degrees(-64.93660181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118242"},
        {"Hipparcos Number", "HIP 66457"},
        {"Geneva Identification System", "GEN# +1.00118242J"},
        {"Smithsonian Astrophysical Observation", "SAO 252388"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.35701475),
        dec: Angle.Degrees(-64.93575353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126077"},
        {"Hipparcos Number", "HIP 70565"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.51096821),
        dec: Angle.Degrees(-64.92993480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82068"},
        {"Hipparcos Number", "HIP 46328"},
        {"Geneva Identification System", "GEN# +1.00082068"},
        {"Smithsonian Astrophysical Observation", "SAO 250583"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.68408799),
        dec: Angle.Degrees(-64.92985680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157634"},
        {"Hipparcos Number", "HIP 85557"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.26612553),
        dec: Angle.Degrees(-64.92869391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122165"},
        {"Hipparcos Number", "HIP 68574"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.58455390),
        dec: Angle.Degrees(-64.92527148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176021"},
        {"Hipparcos Number", "HIP 93507"},
        {"Cincinnati Publication", "Ci 20 1121"},
        {"Geneva Identification System", "GEN# +1.00176021"},
        {"Smithsonian Astrophysical Observation", "SAO 254445"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.65679561),
        dec: Angle.Degrees(-64.92469089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -235.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -285.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77796"},
        {"Hipparcos Number", "HIP 44297"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.32883143),
        dec: Angle.Degrees(-64.92427996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88306"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.50328937),
        dec: Angle.Degrees(-64.92293486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141236"},
        {"Hipparcos Number", "HIP 77711"},
    },
    visualMagnitude: 8.93,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.99546271),
        dec: Angle.Degrees(-64.92285231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111580"},
        {"Hipparcos Number", "HIP 62725"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.80344774),
        dec: Angle.Degrees(-64.92070579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110946"},
        {"Hipparcos Number", "HIP 62339"},
        {"Geneva Identification System", "GEN# +1.00110946"},
        {"Wilson Evans Batten Catalogue", "WEB 11071"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.61971700),
        dec: Angle.Degrees(-64.91766465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108611"},
        {"Hipparcos Number", "HIP 60913"},
        {"Geneva Identification System", "GEN# +1.00108611"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.25959502),
        dec: Angle.Degrees(-64.91681592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121098"},
        {"Hipparcos Number", "HIP 68005"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.89427547),
        dec: Angle.Degrees(-64.91288511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38043"},
        {"Hipparcos Number", "HIP 26489"},
        {"Geneva Identification System", "GEN# +1.00038043"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.50904926),
        dec: Angle.Degrees(-64.90935699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197359"},
        {"Hipparcos Number", "HIP 102540"},
        {"Smithsonian Astrophysical Observation", "SAO 254867"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.69270026),
        dec: Angle.Degrees(-64.90925595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10746"},
        {"Hipparcos Number", "HIP 8015"},
        {"Smithsonian Astrophysical Observation", "SAO 248424"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.73096101),
        dec: Angle.Degrees(-64.90873577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216246"},
        {"Hipparcos Number", "HIP 112975"},
        {"Smithsonian Astrophysical Observation", "SAO 255343"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.20025113),
        dec: Angle.Degrees(-64.90792976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186632"},
        {"Hipparcos Number", "HIP 97564"},
        {"Smithsonian Astrophysical Observation", "SAO 254659"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.45445602),
        dec: Angle.Degrees(-64.90647918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15236"},
        {"Hipparcos Number", "HIP 11214"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.08627361),
        dec: Angle.Degrees(-64.90452536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116254"},
        {"Hipparcos Number", "HIP 65383"},
        {"Geneva Identification System", "GEN# +1.00116254"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.99364892),
        dec: Angle.Degrees(-64.90312868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18390"},
        {"Hipparcos Number", "HIP 13511"},
        {"Geneva Identification System", "GEN# +1.00018390"},
        {"Smithsonian Astrophysical Observation", "SAO 248679"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.50404970),
        dec: Angle.Degrees(-64.90004388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174100"},
        {"Hipparcos Number", "HIP 92707"},
        {"Smithsonian Astrophysical Observation", "SAO 254403"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.35879793),
        dec: Angle.Degrees(-64.89737938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7598"},
        {"Hipparcos Number", "HIP 5805"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.62092184),
        dec: Angle.Degrees(-64.89601893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220264"},
        {"Hipparcos Number", "HIP 115452"},
        {"Smithsonian Astrophysical Observation", "SAO 255476"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.79569895),
        dec: Angle.Degrees(-64.89232289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175882"},
        {"Hipparcos Number", "HIP 93463"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.52127678),
        dec: Angle.Degrees(-64.89146256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184995"},
        {"Hipparcos Number", "HIP 96865"},
        {"Smithsonian Astrophysical Observation", "SAO 254625"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.34372954),
        dec: Angle.Degrees(-64.88889808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99856"},
        {"Hipparcos Number", "HIP 55995"},
        {"Geneva Identification System", "GEN# +1.00099856"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.12671791),
        dec: Angle.Degrees(-64.88719638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182548"},
        {"Hipparcos Number", "HIP 95840"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.38587220),
        dec: Angle.Degrees(-64.88451855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127658"},
        {"Hipparcos Number", "HIP 71337"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.83192263),
        dec: Angle.Degrees(-64.88425330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11743"},
        {"Hipparcos Number", "HIP 8790"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.25766077),
        dec: Angle.Degrees(-64.88381884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105017"},
        {"Hipparcos Number", "HIP 58970"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.37136537),
        dec: Angle.Degrees(-64.88165671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47855"},
        {"Hipparcos Number", "HIP 31512"},
        {"Geneva Identification System", "GEN# +1.00047855"},
        {"Smithsonian Astrophysical Observation", "SAO 249598"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.97816712),
        dec: Angle.Degrees(-64.88111057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114775"},
        {"Hipparcos Number", "HIP 64563"},
    },
    visualMagnitude: 8.99,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.50888610),
        dec: Angle.Degrees(-64.87872222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56644"},
        {"Hipparcos Number", "HIP 34901"},
        {"Smithsonian Astrophysical Observation", "SAO 249788"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.31614547),
        dec: Angle.Degrees(-64.87352222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172555"},
        {"Hipparcos Number", "HIP 92024"},
        {"Fundamental Katalog 5th Edition", "FK5 3489"},
        {"Geneva Identification System", "GEN# +1.00172555"},
        {"Smithsonian Astrophysical Observation", "SAO 254358"},
        {"Wilson Evans Batten Catalogue", "WEB 15854"},
    },
    visualMagnitude: 4.78,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.36190079),
        dec: Angle.Degrees(-64.87089771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87677"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.62000431),
        dec: Angle.Degrees(-64.86704816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3472"},
        {"Hipparcos Number", "HIP 2913"},
        {"Geneva Identification System", "GEN# +1.00003472"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.22828907),
        dec: Angle.Degrees(-64.86698429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171381"},
        {"Hipparcos Number", "HIP 91456"},
        {"Smithsonian Astrophysical Observation", "SAO 254321"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.79730575),
        dec: Angle.Degrees(-64.86309645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41687"},
        {"Hipparcos Number", "HIP 28579"},
        {"Geneva Identification System", "GEN# +1.00041687"},
        {"Smithsonian Astrophysical Observation", "SAO 249425"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.47419732),
        dec: Angle.Degrees(-64.86041492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20014"},
        {"Hipparcos Number", "HIP 14659"},
        {"Geneva Identification System", "GEN# +1.00020014"},
        {"Smithsonian Astrophysical Observation", "SAO 248746"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.34764401),
        dec: Angle.Degrees(-64.85454147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142676"},
        {"Hipparcos Number", "HIP 78346"},
        {"Smithsonian Astrophysical Observation", "SAO 253368"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.95845818),
        dec: Angle.Degrees(-64.85413758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90708"},
        {"Hipparcos Number", "HIP 51100"},
        {"Geneva Identification System", "GEN# +1.00090708"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.60448080),
        dec: Angle.Degrees(-64.85380681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29306"},
        {"Hipparcos Number", "HIP 21184"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.12144621),
        dec: Angle.Degrees(-64.85339679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52761"},
        {"Hipparcos Number", "HIP 33503"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.45913839),
        dec: Angle.Degrees(-64.85307854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66677",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 12.84,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)40, 08.1000),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)50, 51.800)
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
    primaryId: "HIP 83888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154223"},
        {"Hipparcos Number", "HIP 83888"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.18326997),
        dec: Angle.Degrees(-64.84651255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60993"},
        {"Geneva Identification System", "GEN# +2.44630013"},
        {"New General Catalogue", "NGC 4463 13"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.51756540),
        dec: Angle.Degrees(-64.84609433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66658"},
        {"Hipparcos Number", "HIP 39146"},
        {"Geneva Identification System", "GEN# +1.00066658"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.09901665),
        dec: Angle.Degrees(-64.84318985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152083"},
        {"Hipparcos Number", "HIP 82838"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.93125039),
        dec: Angle.Degrees(-64.84187044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57367"},
        {"Cincinnati Publication", "Ci 20 658"},
        {"Geneva Identification System", "GEN# +9.86145141"},
    },
    visualMagnitude: 11.50,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.41359792),
        dec: Angle.Degrees(-64.84067419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2665.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -346.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96568"},
        {"Hipparcos Number", "HIP 54289"},
        {"Celescope Catalog", "CEL 3809"},
        {"Geneva Identification System", "GEN# +1.00096568"},
        {"Smithsonian Astrophysical Observation", "SAO 251267"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.60133089),
        dec: Angle.Degrees(-64.83995575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189914"},
        {"Hipparcos Number", "HIP 99043"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.62443757),
        dec: Angle.Degrees(-64.83920450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36403"},
    },
    visualMagnitude: 11.98,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.36600471),
        dec: Angle.Degrees(-64.83878315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2166"},
        {"Hipparcos Number", "HIP 1991"},
        {"Smithsonian Astrophysical Observation", "SAO 248181"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.29872534),
        dec: Angle.Degrees(-64.83850162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121643"},
        {"Hipparcos Number", "HIP 68295"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.71193125),
        dec: Angle.Degrees(-64.83723772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24293"},
        {"Hipparcos Number", "HIP 17748"},
        {"Geneva Identification System", "GEN# +1.00024293"},
        {"Smithsonian Astrophysical Observation", "SAO 248888"},
        {"Wilson Evans Batten Catalogue", "WEB 3396"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.00276867),
        dec: Angle.Degrees(-64.83682576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 332.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205417"},
        {"Hipparcos Number", "HIP 106818"},
        {"Geneva Identification System", "GEN# +1.00205417"},
        {"Smithsonian Astrophysical Observation", "SAO 255040"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.51168571),
        dec: Angle.Degrees(-64.82414493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19398"},
        {"Hipparcos Number", "HIP 14246"},
        {"Geneva Identification System", "GEN# +1.00019398"},
        {"Smithsonian Astrophysical Observation", "SAO 248720"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.92640836),
        dec: Angle.Degrees(-64.82270749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179213"},
        {"Hipparcos Number", "HIP 94693"},
        {"Renson", "Renson 49790"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.02253165),
        dec: Angle.Degrees(-64.82214402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4178"},
        {"Hipparcos Number", "HIP 3395"},
        {"Smithsonian Astrophysical Observation", "SAO 248240"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.81962358),
        dec: Angle.Degrees(-64.81946211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191716"},
        {"Hipparcos Number", "HIP 99831"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.83750234),
        dec: Angle.Degrees(-64.81941046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90399"},
        {"Hipparcos Number", "HIP 50932"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.02912415),
        dec: Angle.Degrees(-64.81515160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73742"},
        {"Hipparcos Number", "HIP 42188"},
        {"Celescope Catalog", "CEL 2711"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.03338565),
        dec: Angle.Degrees(-64.81367195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210938"},
        {"Hipparcos Number", "HIP 109925"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.96806645),
        dec: Angle.Degrees(-64.81232808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214954"},
        {"Hipparcos Number", "HIP 112201"},
        {"Geneva Identification System", "GEN# +1.00214954"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.86929877),
        dec: Angle.Degrees(-64.81191481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60971",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60971"},
        {"Geneva Identification System", "GEN# +2.44630001"},
        {"New General Catalogue", "NGC 4463 1"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.48063611),
        dec: Angle.Degrees(-64.81132555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125588"},
        {"Hipparcos Number", "HIP 70301"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.76099006),
        dec: Angle.Degrees(-64.81069611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130634"},
        {"Hipparcos Number", "HIP 72751"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.09283579),
        dec: Angle.Degrees(-64.81036989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94535"},
        {"Hipparcos Number", "HIP 53241"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.35471007),
        dec: Angle.Degrees(-64.80824195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149066"},
        {"Hipparcos Number", "HIP 81345"},
        {"Renson", "Renson 42140"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.19888939),
        dec: Angle.Degrees(-64.80754161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188769"},
        {"Hipparcos Number", "HIP 98533"},
        {"Geneva Identification System", "GEN# +1.00188769"},
        {"Smithsonian Astrophysical Observation", "SAO 254704"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.25254060),
        dec: Angle.Degrees(-64.80729222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23817"},
        {"Hipparcos Number", "HIP 17440"},
        {"Fundamental Katalog 5th Edition", "FK5 141"},
        {"Geneva Identification System", "GEN# +1.00023817"},
        {"Smithsonian Astrophysical Observation", "SAO 248877"},
        {"Wilson Evans Batten Catalogue", "WEB 3302"},
    },
    visualMagnitude: 3.84,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.04814541),
        dec: Angle.Degrees(-64.80709398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 308.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171023"},
        {"Hipparcos Number", "HIP 91278"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.28690702),
        dec: Angle.Degrees(-64.80554832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162686"},
        {"Hipparcos Number", "HIP 87858"},
        {"Fundamental Katalog 5th Edition", "FK5 5582"},
        {"Smithsonian Astrophysical Observation", "SAO 254080"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.21611200),
        dec: Angle.Degrees(-64.80539315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223669"},
        {"Hipparcos Number", "HIP 117661"},
        {"Geneva Identification System", "GEN# +1.00223669"},
        {"Smithsonian Astrophysical Observation", "SAO 255585"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.93845256),
        dec: Angle.Degrees(-64.80388542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106588"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.81241942),
        dec: Angle.Degrees(-64.80186655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203262"},
        {"Hipparcos Number", "HIP 105664"},
        {"Smithsonian Astrophysical Observation", "SAO 254991"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.03692995),
        dec: Angle.Degrees(-64.79910467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104523"},
        {"Hipparcos Number", "HIP 58687"},
        {"Geneva Identification System", "GEN# +1.00104523"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.53812580),
        dec: Angle.Degrees(-64.79803814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75891"},
        {"Hipparcos Number", "HIP 43300"},
        {"Smithsonian Astrophysical Observation", "SAO 250338"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.31415303),
        dec: Angle.Degrees(-64.79779996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121903"},
        {"Hipparcos Number", "HIP 68436"},
        {"Fundamental Katalog 5th Edition", "FK5 5242"},
        {"Geneva Identification System", "GEN# +1.00121903"},
        {"Smithsonian Astrophysical Observation", "SAO 252553"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.15664335),
        dec: Angle.Degrees(-64.79448420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109151"},
        {"Hipparcos Number", "HIP 61249"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.27857585),
        dec: Angle.Degrees(-64.79422792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113375"},
        {"Hipparcos Number", "HIP 63788"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.11214462),
        dec: Angle.Degrees(-64.79037489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173363"},
        {"Hipparcos Number", "HIP 92378"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.38490024),
        dec: Angle.Degrees(-64.79009367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108719"},
        {"Hipparcos Number", "HIP 60974"},
        {"Geneva Identification System", "GEN# +2.44630005"},
        {"New General Catalogue", "NGC 4463 5"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.48127950),
        dec: Angle.Degrees(-64.79002015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44752"},
        {"Hipparcos Number", "HIP 29984"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.68782136),
        dec: Angle.Degrees(-64.78962185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12466"},
        {"Hipparcos Number", "HIP 9324"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.93859143),
        dec: Angle.Degrees(-64.78784891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117011"},
        {"Geneva Identification System", "GEN# +6.20145144"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.77655461),
        dec: Angle.Degrees(-64.78679329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113191"},
        {"Hipparcos Number", "HIP 63681"},
        {"Geneva Identification System", "GEN# +1.00113191"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.75993915),
        dec: Angle.Degrees(-64.78451059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81558"},
        {"Hipparcos Number", "HIP 46035"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.84013159),
        dec: Angle.Degrees(-64.78080941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124489"},
        {"Hipparcos Number", "HIP 69741"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.11366244),
        dec: Angle.Degrees(-64.78061238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3420"},
        {"Hipparcos Number", "HIP 2869"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.09423301),
        dec: Angle.Degrees(-64.77921102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15615"},
        {"Hipparcos Number", "HIP 11447"},
        {"Smithsonian Astrophysical Observation", "SAO 248566"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.92616299),
        dec: Angle.Degrees(-64.77813890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68635"},
        {"Hipparcos Number", "HIP 39922"},
        {"Fundamental Katalog 5th Edition", "FK5 4735"},
        {"Smithsonian Astrophysical Observation", "SAO 250135"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.30063061),
        dec: Angle.Degrees(-64.77623804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123349"},
        {"Hipparcos Number", "HIP 69159"},
        {"Geneva Identification System", "GEN# +1.00123349"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.35971440),
        dec: Angle.Degrees(-64.77613538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87595"},
        {"Hipparcos Number", "HIP 49286"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.90631167),
        dec: Angle.Degrees(-64.76976819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198222"},
        {"Hipparcos Number", "HIP 103029"},
        {"Geneva Identification System", "GEN# +1.00198222"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.09395327),
        dec: Angle.Degrees(-64.76763780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102370"},
        {"Hipparcos Number", "HIP 57451"},
        {"Celescope Catalog", "CEL 3977"},
        {"Geneva Identification System", "GEN# +1.00102370"},
        {"Smithsonian Astrophysical Observation", "SAO 251582"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.65173543),
        dec: Angle.Degrees(-64.76597448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117670"},
        {"Hipparcos Number", "HIP 66155"},
        {"Geneva Identification System", "GEN# +1.00117670"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.40893529),
        dec: Angle.Degrees(-64.76428784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7621"},
        {"Hipparcos Number", "HIP 5817"},
        {"Geneva Identification System", "GEN# +1.00007621"},
        {"Smithsonian Astrophysical Observation", "SAO 248339"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.66766837),
        dec: Angle.Degrees(-64.76344898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -307.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39327"},
        {"Hipparcos Number", "HIP 27304"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.76908384),
        dec: Angle.Degrees(-64.76239897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5773"},
        {"Hipparcos Number", "HIP 4548"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.55169187),
        dec: Angle.Degrees(-64.76164552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129646"},
        {"Hipparcos Number", "HIP 72266"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.67784455),
        dec: Angle.Degrees(-64.76140830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85027"},
        {"Hipparcos Number", "HIP 47967"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.64041028),
        dec: Angle.Degrees(-64.75914957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37859"},
    },
    visualMagnitude: 11.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.41292938),
        dec: Angle.Degrees(-64.75862628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76415"},
        {"Hipparcos Number", "HIP 43576"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.12087796),
        dec: Angle.Degrees(-64.75515681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121520"},
        {"Hipparcos Number", "HIP 68229"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.50867611),
        dec: Angle.Degrees(-64.74956359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155655"},
        {"Hipparcos Number", "HIP 84598"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.39940013),
        dec: Angle.Degrees(-64.74885132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68223"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.49496660),
        dec: Angle.Degrees(-64.74416501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124300"},
        {"Hipparcos Number", "HIP 69640"},
        {"Geneva Identification System", "GEN# +1.00124300"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.79908156),
        dec: Angle.Degrees(-64.74038079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107720"},
        {"Hipparcos Number", "HIP 60394"},
        {"Geneva Identification System", "GEN# +1.00107720"},
        {"Smithsonian Astrophysical Observation", "SAO 251876"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.75021236),
        dec: Angle.Degrees(-64.73032052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2516"},
        {"Hipparcos Number", "HIP 2234"},
        {"Geneva Identification System", "GEN# +1.00002516"},
        {"Smithsonian Astrophysical Observation", "SAO 248194"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.08259849),
        dec: Angle.Degrees(-64.72962406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110310"},
        {"Hipparcos Number", "HIP 61959"},
        {"Geneva Identification System", "GEN# +1.00110310"},
        {"Smithsonian Astrophysical Observation", "SAO 251995"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.46919247),
        dec: Angle.Degrees(-64.72873801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209295"},
        {"Hipparcos Number", "HIP 108976"},
        {"Fundamental Katalog 5th Edition", "FK5 3766"},
        {"Geneva Identification System", "GEN# +1.00209295"},
        {"Smithsonian Astrophysical Observation", "SAO 255138"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.15997637),
        dec: Angle.Degrees(-64.72819460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171548"},
        {"Hipparcos Number", "HIP 91534"},
        {"Smithsonian Astrophysical Observation", "SAO 254324"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.01304692),
        dec: Angle.Degrees(-64.72565378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160635"},
        {"Hipparcos Number", "HIP 86929"},
        {"Fundamental Katalog 5th Edition", "FK5 661"},
        {"Geneva Identification System", "GEN# +1.00160635"},
        {"Smithsonian Astrophysical Observation", "SAO 254020"},
        {"Wilson Evans Batten Catalogue", "WEB 14663"},
    },
    visualMagnitude: 3.61,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.43334347),
        dec: Angle.Degrees(-64.72373450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148908"},
        {"Hipparcos Number", "HIP 81249"},
        {"Geneva Identification System", "GEN# +1.00148908"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.92462929),
        dec: Angle.Degrees(-64.72130313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128418"},
        {"Hipparcos Number", "HIP 71677"},
        {"Smithsonian Astrophysical Observation", "SAO 252836"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.91126415),
        dec: Angle.Degrees(-64.71366715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207229"},
        {"Hipparcos Number", "HIP 107773"},
        {"Fundamental Katalog 5th Edition", "FK5 3742"},
        {"Geneva Identification System", "GEN# +1.00207229"},
        {"Smithsonian Astrophysical Observation", "SAO 255080"},
        {"Wilson Evans Batten Catalogue", "WEB 19435"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.50054328),
        dec: Angle.Degrees(-64.71244360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65731"},
        {"Hipparcos Number", "HIP 38736"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.95788287),
        dec: Angle.Degrees(-64.71015793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22624"},
        {"Hipparcos Number", "HIP 16670"},
        {"Geneva Identification System", "GEN# +1.00022624"},
        {"Smithsonian Astrophysical Observation", "SAO 248844"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.63899826),
        dec: Angle.Degrees(-64.70943957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81806"},
        {"Hipparcos Number", "HIP 46173"},
        {"Smithsonian Astrophysical Observation", "SAO 250570"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.23487248),
        dec: Angle.Degrees(-64.70821306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33010"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.17687054),
        dec: Angle.Degrees(-64.70785446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101425"},
        {"Hipparcos Number", "HIP 56894"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.94467882),
        dec: Angle.Degrees(-64.70146067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6495"},
        {"Hipparcos Number", "HIP 5043"},
        {"Smithsonian Astrophysical Observation", "SAO 248313"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.14229534),
        dec: Angle.Degrees(-64.70119640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48003"},
        {"Hipparcos Number", "HIP 31580"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.13902327),
        dec: Angle.Degrees(-64.69853736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118473"},
        {"Hipparcos Number", "HIP 66590"},
        {"Renson", "Renson 34220"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.75198592),
        dec: Angle.Degrees(-64.69470826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53103"},
        {"Hipparcos Number", "HIP 33633"},
        {"Smithsonian Astrophysical Observation", "SAO 249699"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.80405660),
        dec: Angle.Degrees(-64.69320442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58963"},
        {"Hipparcos Number", "HIP 35841"},
        {"Smithsonian Astrophysical Observation", "SAO 249842"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.86028593),
        dec: Angle.Degrees(-64.69204089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119941"},
        {"Hipparcos Number", "HIP 67356"},
        {"Geneva Identification System", "GEN# +1.00119941"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.07819084),
        dec: Angle.Degrees(-64.69115278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98586"},
        {"Hipparcos Number", "HIP 55309"},
        {"Geneva Identification System", "GEN# +1.00098586"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.90400480),
        dec: Angle.Degrees(-64.68938212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221740"},
        {"Hipparcos Number", "HIP 116399"},
        {"Geneva Identification System", "GEN# +1.00221740"},
        {"Smithsonian Astrophysical Observation", "SAO 255520"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.80397121),
        dec: Angle.Degrees(-64.68915931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78232"},
        {"Hipparcos Number", "HIP 44485"},
        {"Smithsonian Astrophysical Observation", "SAO 250428"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.95656823),
        dec: Angle.Degrees(-64.68521880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105274"},
        {"Hipparcos Number", "HIP 59111"},
        {"Geneva Identification System", "GEN# +1.00105274"},
        {"Smithsonian Astrophysical Observation", "SAO 251749"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.81741886),
        dec: Angle.Degrees(-64.68179312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202299"},
        {"Hipparcos Number", "HIP 105148"},
        {"Geneva Identification System", "GEN# +1.00202299"},
        {"Smithsonian Astrophysical Observation", "SAO 254966"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.50193998),
        dec: Angle.Degrees(-64.68151068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89715"},
        {"Hipparcos Number", "HIP 50520"},
        {"Celescope Catalog", "CEL 3501"},
        {"Geneva Identification System", "GEN# +1.00089715"},
        {"Smithsonian Astrophysical Observation", "SAO 250917"},
    },
    visualMagnitude: 5.66,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.77133097),
        dec: Angle.Degrees(-64.67628786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117025"},
        {"Hipparcos Number", "HIP 65783"},
        {"Geneva Identification System", "GEN# +1.00117025"},
        {"Renson", "Renson 33750"},
        {"Smithsonian Astrophysical Observation", "SAO 252329"},
        {"Wilson Evans Batten Catalogue", "WEB 11640"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.28326682),
        dec: Angle.Degrees(-64.67577724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119661"},
        {"Hipparcos Number", "HIP 67226"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.63127021),
        dec: Angle.Degrees(-64.67553174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40342"},
        {"Hipparcos Number", "HIP 27840"},
        {"Smithsonian Astrophysical Observation", "SAO 249386"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.36027396),
        dec: Angle.Degrees(-64.66814993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169096"},
        {"Hipparcos Number", "HIP 90469"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.90942035),
        dec: Angle.Degrees(-64.66743570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56440"},
        {"Hipparcos Number", "HIP 34827"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.12054782),
        dec: Angle.Degrees(-64.66325386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147731"},
        {"Hipparcos Number", "HIP 80633"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.96338179),
        dec: Angle.Degrees(-64.66177614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76989"},
        {"Hipparcos Number", "HIP 43860"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.02842782),
        dec: Angle.Degrees(-64.66068723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73781"},
        {"Hipparcos Number", "HIP 42203"},
        {"Celescope Catalog", "CEL 2713"},
        {"Smithsonian Astrophysical Observation", "SAO 250280"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.07764443),
        dec: Angle.Degrees(-64.65860817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84794"},
        {"Hipparcos Number", "HIP 47827"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.23256111),
        dec: Angle.Degrees(-64.65341259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92715"},
        {"Hipparcos Number", "HIP 52261"},
        {"Celescope Catalog", "CEL 3634"},
        {"Geneva Identification System", "GEN# +3.26020028"},
        {"Smithsonian Astrophysical Observation", "SAO 251062"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.17553921),
        dec: Angle.Degrees(-64.65321843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22236"},
        {"Hipparcos Number", "HIP 16396"},
        {"Geneva Identification System", "GEN# +1.00022236"},
        {"Smithsonian Astrophysical Observation", "SAO 248828"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.78346750),
        dec: Angle.Degrees(-64.65179209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214990B"},
        {"Hipparcos Number", "HIP 112216"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.91202250),
        dec: Angle.Degrees(-64.64924669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21818"},
        {"Hipparcos Number", "HIP 16098"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.84691675),
        dec: Angle.Degrees(-64.64920279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146349"},
        {"Hipparcos Number", "HIP 80017"},
        {"Geneva Identification System", "GEN# +1.00146349J"},
        {"Smithsonian Astrophysical Observation", "SAO 253500"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.00201867),
        dec: Angle.Degrees(-64.64873515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214990"},
        {"Hipparcos Number", "HIP 112220"},
        {"Geneva Identification System", "GEN# +1.00214990"},
        {"Smithsonian Astrophysical Observation", "SAO 255296"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.91853070),
        dec: Angle.Degrees(-64.64815979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39133"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.07767063),
        dec: Angle.Degrees(-64.64791219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107270"},
        {"Hipparcos Number", "HIP 60165"},
        {"Geneva Identification System", "GEN# +1.00107270"},
        {"Smithsonian Astrophysical Observation", "SAO 251852"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.06658385),
        dec: Angle.Degrees(-64.64778627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87713"},
        {"Hipparcos Number", "HIP 49360"},
        {"Smithsonian Astrophysical Observation", "SAO 250802"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.14204211),
        dec: Angle.Degrees(-64.64775928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86471"},
        {"Hipparcos Number", "HIP 48719"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.05719346),
        dec: Angle.Degrees(-64.64530645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57260"},
        {"Hipparcos Number", "HIP 35155"},
        {"Smithsonian Astrophysical Observation", "SAO 249802"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.99325141),
        dec: Angle.Degrees(-64.64407346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172021"},
        {"Hipparcos Number", "HIP 91733"},
        {"Geneva Identification System", "GEN# +1.00172021"},
        {"Smithsonian Astrophysical Observation", "SAO 254343"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.59428923),
        dec: Angle.Degrees(-64.64297471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36566"},
    },
    visualMagnitude: 11.39,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.82266466),
        dec: Angle.Degrees(-64.64271871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118199"},
        {"Hipparcos Number", "HIP 66418"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.24697056),
        dec: Angle.Degrees(-64.63761483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -217.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103655"},
        {"Hipparcos Number", "HIP 58182"},
        {"Geneva Identification System", "GEN# +1.00103655"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.99623328),
        dec: Angle.Degrees(-64.63316268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219234"},
        {"Hipparcos Number", "HIP 114794"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.80361231),
        dec: Angle.Degrees(-64.63273865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58853"},
        {"Hipparcos Number", "HIP 35789"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.72974570),
        dec: Angle.Degrees(-64.63231011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155151"},
        {"Hipparcos Number", "HIP 84327"},
        {"Smithsonian Astrophysical Observation", "SAO 253839"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.59332738),
        dec: Angle.Degrees(-64.63092365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104013"},
        {"Hipparcos Number", "HIP 58411"},
        {"Geneva Identification System", "GEN# +5.30980001"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.64893040),
        dec: Angle.Degrees(-64.62992612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67420"},
        {"Hipparcos Number", "HIP 39445"},
        {"Smithsonian Astrophysical Observation", "SAO 250097"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.95822121),
        dec: Angle.Degrees(-64.62919420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63294"},
        {"Hipparcos Number", "HIP 37687"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.97464923),
        dec: Angle.Degrees(-64.62356346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161864"},
        {"Hipparcos Number", "HIP 87501"},
        {"Smithsonian Astrophysical Observation", "SAO 254060"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.17039775),
        dec: Angle.Degrees(-64.62064797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190984"},
        {"Hipparcos Number", "HIP 99496"},
        {"Geneva Identification System", "GEN# +1.00190984"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.87797984),
        dec: Angle.Degrees(-64.62057872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88895"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.21470658),
        dec: Angle.Degrees(-64.61744120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93600"},
        {"Hipparcos Number", "HIP 52716"},
        {"Geneva Identification System", "GEN# +3.26020050"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.66920019),
        dec: Angle.Degrees(-64.61592704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96287"},
        {"Hipparcos Number", "HIP 54168"},
        {"Celescope Catalog", "CEL 3795"},
        {"Geneva Identification System", "GEN# +1.00096287"},
        {"Smithsonian Astrophysical Observation", "SAO 251252"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.20820768),
        dec: Angle.Degrees(-64.61575105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111409"},
        {"Hipparcos Number", "HIP 62624"},
        {"Geneva Identification System", "GEN# +1.00111409"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.48113489),
        dec: Angle.Degrees(-64.61370876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105211"},
        {"Henry Draper 2", "HD 105211A"},
        {"Henry Draper 3", "HD 105211B"},
        {"Hipparcos Number", "HIP 59072"},
        {"Celescope Catalog", "CEL 4056"},
        {"Fundamental Katalog 5th Edition", "FK5 2969"},
        {"Geneva Identification System", "GEN# +1.00105211"},
        {"Smithsonian Astrophysical Observation", "SAO 251742"},
        {"Wilson Evans Batten Catalogue", "WEB 10519"},
    },
    visualMagnitude: 4.14,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.72022021),
        dec: Angle.Degrees(-64.61363898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9517"},
        {"Hipparcos Number", "HIP 7112"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.90258145),
        dec: Angle.Degrees(-64.61008744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196238"},
        {"Hipparcos Number", "HIP 101962"},
        {"Geneva Identification System", "GEN# +1.00196238"},
        {"Smithsonian Astrophysical Observation", "SAO 254842"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.93082320),
        dec: Angle.Degrees(-64.60716431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208593"},
        {"Hipparcos Number", "HIP 108575"},
        {"Renson", "Renson 58010"},
        {"Smithsonian Astrophysical Observation", "SAO 255120"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.91723664),
        dec: Angle.Degrees(-64.60674319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36401"},
        {"Hipparcos Number", "HIP 25466"},
        {"Smithsonian Astrophysical Observation", "SAO 249277"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.68733042),
        dec: Angle.Degrees(-64.60487567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165961"},
        {"Hipparcos Number", "HIP 89258"},
        {"Geneva Identification System", "GEN# +1.00165961"},
        {"Smithsonian Astrophysical Observation", "SAO 254172"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.22075190),
        dec: Angle.Degrees(-63.61594218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74584"},
        {"Hipparcos Number", "HIP 42617"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.28318542),
        dec: Angle.Degrees(-64.60247301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71863"},
        {"Hipparcos Number", "HIP 41321"},
        {"Geneva Identification System", "GEN# +1.00071863"},
        {"Smithsonian Astrophysical Observation", "SAO 250226"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.46507032),
        dec: Angle.Degrees(-64.60065452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208295"},
        {"Hipparcos Number", "HIP 108429"},
        {"Smithsonian Astrophysical Observation", "SAO 255110"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.47237886),
        dec: Angle.Degrees(-64.59930458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32339"},
        {"Hipparcos Number", "HIP 23072"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.46407466),
        dec: Angle.Degrees(-64.59840609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103066"},
        {"Hipparcos Number", "HIP 57848"},
        {"Celescope Catalog", "CEL 3997"},
        {"Geneva Identification System", "GEN# +1.00103066"},
        {"Smithsonian Astrophysical Observation", "SAO 251616"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.95410671),
        dec: Angle.Degrees(-64.59565443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210429"},
        {"Hipparcos Number", "HIP 109628"},
        {"Smithsonian Astrophysical Observation", "SAO 255168"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.11793649),
        dec: Angle.Degrees(-64.59524250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91043"},
        {"Hipparcos Number", "HIP 51300"},
        {"Geneva Identification System", "GEN# +1.00091043"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.18217807),
        dec: Angle.Degrees(-64.59421587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104049"},
        {"Hipparcos Number", "HIP 58432"},
        {"Geneva Identification System", "GEN# +5.30980005"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.71555361),
        dec: Angle.Degrees(-64.59337473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169530"},
        {"Hipparcos Number", "HIP 90643"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.42782700),
        dec: Angle.Degrees(-64.59311734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173865"},
        {"Hipparcos Number", "HIP 92597"},
        {"Geneva Identification System", "GEN# +1.00173865"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.02714692),
        dec: Angle.Degrees(-64.59245388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193440"},
        {"Hipparcos Number", "HIP 100614"},
        {"Smithsonian Astrophysical Observation", "SAO 254783"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.02880714),
        dec: Angle.Degrees(-64.58997343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212788"},
        {"Hipparcos Number", "HIP 110939"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.16836391),
        dec: Angle.Degrees(-64.58682110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88079"},
        {"Hipparcos Number", "HIP 49553"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.76788668),
        dec: Angle.Degrees(-64.58658302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152841"},
        {"Hipparcos Number", "HIP 83206"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.07242811),
        dec: Angle.Degrees(-64.58288769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98560"},
        {"Hipparcos Number", "HIP 55280"},
        {"Geneva Identification System", "GEN# +1.00098560"},
        {"Smithsonian Astrophysical Observation", "SAO 251357"},
        {"Wilson Evans Batten Catalogue", "WEB 9959"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.82018140),
        dec: Angle.Degrees(-64.58259742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -301.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32108"},
        {"Hipparcos Number", "HIP 22933"},
        {"Smithsonian Astrophysical Observation", "SAO 249150"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.02253235),
        dec: Angle.Degrees(-64.58103507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9020"},
        {"Hipparcos Number", "HIP 6765"},
        {"Smithsonian Astrophysical Observation", "SAO 248385"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.75774107),
        dec: Angle.Degrees(-64.57971035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118666"},
        {"Hipparcos Number", "HIP 66681"},
        {"Geneva Identification System", "GEN# +1.00118666"},
        {"Smithsonian Astrophysical Observation", "SAO 252400"},
        {"Wilson Evans Batten Catalogue", "WEB 11762"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.04500863),
        dec: Angle.Degrees(-64.57655426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52399"},
        {"Hipparcos Number", "HIP 33388"},
        {"Smithsonian Astrophysical Observation", "SAO 249688"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.15161008),
        dec: Angle.Degrees(-64.57615968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132209"},
        {"Hipparcos Number", "HIP 73483"},
        {"Geneva Identification System", "GEN# +1.00132209"},
        {"Smithsonian Astrophysical Observation", "SAO 252990"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.25943468),
        dec: Angle.Degrees(-64.57589788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106523"},
        {"Hipparcos Number", "HIP 59770"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.84535765),
        dec: Angle.Degrees(-64.57504556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115793"},
        {"Hipparcos Number", "HIP 65147"},
        {"Geneva Identification System", "GEN# +1.00115793"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.24853484),
        dec: Angle.Degrees(-64.57457190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223055"},
        {"Hipparcos Number", "HIP 117253"},
        {"Geneva Identification System", "GEN# +1.00223055"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.63263604),
        dec: Angle.Degrees(-64.57360548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146226"},
        {"Hipparcos Number", "HIP 79960"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.82004302),
        dec: Angle.Degrees(-64.57149542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10435"},
        {"Hipparcos Number", "HIP 7750"},
        {"Geneva Identification System", "GEN# +1.00010435"},
        {"Smithsonian Astrophysical Observation", "SAO 248414"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.94626527),
        dec: Angle.Degrees(-64.57128601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25876"},
        {"Hipparcos Number", "HIP 18812"},
        {"Smithsonian Astrophysical Observation", "SAO 248931"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.46320717),
        dec: Angle.Degrees(-64.57090894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156887"},
        {"Hipparcos Number", "HIP 85193"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.15154562),
        dec: Angle.Degrees(-64.56987086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28915"},
        {"Hipparcos Number", "HIP 20914"},
        {"Smithsonian Astrophysical Observation", "SAO 249036"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.23466804),
        dec: Angle.Degrees(-64.56580333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19939"},
        {"Hipparcos Number", "HIP 14619"},
        {"Geneva Identification System", "GEN# +1.00019939"},
        {"Smithsonian Astrophysical Observation", "SAO 248744"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.20902306),
        dec: Angle.Degrees(-64.56545641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143853"},
        {"Hipparcos Number", "HIP 78928"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.68786129),
        dec: Angle.Degrees(-64.56157666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113689"},
        {"Hipparcos Number", "HIP 63979"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.65669605),
        dec: Angle.Degrees(-64.56017104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35979"},
    },
    visualMagnitude: 11.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.21837970),
        dec: Angle.Degrees(-63.01180267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66383",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66383"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.15376810),
        dec: Angle.Degrees(-64.55830885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211333"},
        {"Hipparcos Number", "HIP 110117"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.58657725),
        dec: Angle.Degrees(-64.55761314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138680"},
        {"Hipparcos Number", "HIP 76483"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.31415931),
        dec: Angle.Degrees(-64.55316443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46011"},
        {"Hipparcos Number", "HIP 30624"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.53708459),
        dec: Angle.Degrees(-64.55308095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172211"},
        {"Hipparcos Number", "HIP 91854"},
        {"Geneva Identification System", "GEN# +1.00172211"},
        {"Smithsonian Astrophysical Observation", "SAO 254353"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.90549491),
        dec: Angle.Degrees(-64.55131121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152924"},
        {"Hipparcos Number", "HIP 83243"},
        {"Geneva Identification System", "GEN# +1.00152924"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.19325121),
        dec: Angle.Degrees(-64.55037588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164871"},
        {"Hipparcos Number", "HIP 88815"},
        {"Geneva Identification System", "GEN# +1.00164871"},
        {"Smithsonian Astrophysical Observation", "SAO 254141"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.95156071),
        dec: Angle.Degrees(-64.55003748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145065"},
        {"Hipparcos Number", "HIP 79468"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.25926794),
        dec: Angle.Degrees(-64.54802083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93714"},
        {"Hipparcos Number", "HIP 52799"},
        {"Celescope Catalog", "CEL 3713"},
        {"Geneva Identification System", "GEN# +3.26020053"},
        {"Smithsonian Astrophysical Observation", "SAO 251126"},
        {"Wilson Evans Batten Catalogue", "WEB 9614"},
    },
    visualMagnitude: 6.54,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.91638663),
        dec: Angle.Degrees(-64.54718562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33293"},
        {"Hipparcos Number", "HIP 23625"},
        {"Geneva Identification System", "GEN# +1.00033293"},
        {"Smithsonian Astrophysical Observation", "SAO 249182"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.18743297),
        dec: Angle.Degrees(-64.54578850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45462"},
        {"Hipparcos Number", "HIP 30336"},
        {"Smithsonian Astrophysical Observation", "SAO 249530"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.71604557),
        dec: Angle.Degrees(-64.54352108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129615"},
        {"Hipparcos Number", "HIP 72242"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.61149944),
        dec: Angle.Degrees(-64.54301636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94066"},
        {"Hipparcos Number", "HIP 52970"},
        {"Geneva Identification System", "GEN# +3.26020061"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.50161878),
        dec: Angle.Degrees(-64.54137693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134276"},
        {"Hipparcos Number", "HIP 74398"},
        {"Smithsonian Astrophysical Observation", "SAO 253051"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.08147722),
        dec: Angle.Degrees(-64.54076095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89079"},
        {"Hipparcos Number", "HIP 50161"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.58909589),
        dec: Angle.Degrees(-64.54067140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123100"},
        {"Hipparcos Number", "HIP 69053"},
        {"Geneva Identification System", "GEN# +1.00123100"},
        {"Smithsonian Astrophysical Observation", "SAO 252610"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.01588526),
        dec: Angle.Degrees(-64.53962952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104810"},
        {"Hipparcos Number", "HIP 58835"},
        {"Celescope Catalog", "CEL 4050"},
        {"Geneva Identification System", "GEN# +1.00104810"},
        {"Renson", "Renson 30330"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.01711984),
        dec: Angle.Degrees(-64.53895302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116243"},
        {"Hipparcos Number", "HIP 65387"},
        {"Geneva Identification System", "GEN# +1.00116243"},
        {"Smithsonian Astrophysical Observation", "SAO 252293"},
        {"Wilson Evans Batten Catalogue", "WEB 11540"},
    },
    visualMagnitude: 4.52,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.00184737),
        dec: Angle.Degrees(-64.53561699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184628"},
        {"Hipparcos Number", "HIP 96711"},
        {"Smithsonian Astrophysical Observation", "SAO 254621"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.90073108),
        dec: Angle.Degrees(-64.53546805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33076"},
        {"Hipparcos Number", "HIP 23506"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.81164178),
        dec: Angle.Degrees(-64.53531265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198282"},
        {"Hipparcos Number", "HIP 103046"},
        {"Geneva Identification System", "GEN# +1.00198282"},
        {"Smithsonian Astrophysical Observation", "SAO 254888"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.16547234),
        dec: Angle.Degrees(-64.53472583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178907"},
        {"Hipparcos Number", "HIP 94581"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.73066190),
        dec: Angle.Degrees(-64.53217626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137066"},
        {"Hipparcos Number", "HIP 75665"},
        {"Fundamental Katalog 5th Edition", "FK5 3217"},
        {"Geneva Identification System", "GEN# +1.00137066"},
        {"Smithsonian Astrophysical Observation", "SAO 253174"},
    },
    visualMagnitude: 5.71,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.88792069),
        dec: Angle.Degrees(-64.53145700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76486",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76486"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.32421059),
        dec: Angle.Degrees(-64.53116228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77373"},
        {"Hipparcos Number", "HIP 44081"},
        {"Smithsonian Astrophysical Observation", "SAO 250407"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.69184332),
        dec: Angle.Degrees(-64.53051138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158948"},
        {"Hipparcos Number", "HIP 86188"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.17493876),
        dec: Angle.Degrees(-64.53047037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120418"},
        {"Hipparcos Number", "HIP 67617"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.82911978),
        dec: Angle.Degrees(-64.52636447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114263"},
        {"Hipparcos Number", "HIP 64301"},
        {"Celescope Catalog", "CEL 4209"},
        {"Geneva Identification System", "GEN# +1.00114263"},
        {"Smithsonian Astrophysical Observation", "SAO 252178"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.68462631),
        dec: Angle.Degrees(-64.52564713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49078"},
        {"Henry Draper 2", "HD 49078A"},
        {"Hipparcos Number", "HIP 32079"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.53064611),
        dec: Angle.Degrees(-64.52396361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9858"},
        {"Hipparcos Number", "HIP 7326"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.58443640),
        dec: Angle.Degrees(-64.51878597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165539"},
        {"Hipparcos Number", "HIP 89103"},
        {"Smithsonian Astrophysical Observation", "SAO 254160"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.77972518),
        dec: Angle.Degrees(-64.51662517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87751"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.86477579),
        dec: Angle.Degrees(-62.99213083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93540"},
        {"Hipparcos Number", "HIP 52678"},
        {"Celescope Catalog", "CEL 3697"},
        {"Geneva Identification System", "GEN# +3.26020048"},
        {"Geneva Identification System 2", "GEN# +1.00093540"},
        {"Smithsonian Astrophysical Observation", "SAO 251115"},
        {"Wilson Evans Batten Catalogue", "WEB 9591"},
    },
    visualMagnitude: 5.33,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.56907694),
        dec: Angle.Degrees(-64.51458587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106000"},
        {"Hipparcos Number", "HIP 59488"},
        {"Geneva Identification System", "GEN# +1.00106000"},
        {"Smithsonian Astrophysical Observation", "SAO 251785"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.00320098),
        dec: Angle.Degrees(-64.51040261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60150"},
        {"Hipparcos Number", "HIP 36346"},
        {"Fundamental Katalog 5th Edition", "FK5 2584"},
        {"Geneva Identification System", "GEN# +1.00060150"},
        {"Smithsonian Astrophysical Observation", "SAO 249864"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.21417299),
        dec: Angle.Degrees(-64.50978410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4003"},
        {"Hipparcos Number", "HIP 3274"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.42653042),
        dec: Angle.Degrees(-64.50833899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12210",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12210"},
    },
    visualMagnitude: 11.81,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.30323678),
        dec: Angle.Degrees(-64.50716369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -282.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69053"},
        {"Hipparcos Number", "HIP 40079"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.80034712),
        dec: Angle.Degrees(-64.50644225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70102"},
        {"Hipparcos Number", "HIP 40509"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.06162391),
        dec: Angle.Degrees(-64.50618528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88495"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.06092591),
        dec: Angle.Degrees(-64.50011378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78632"},
        {"Hipparcos Number", "HIP 44665"},
        {"Geneva Identification System", "GEN# +1.00078632"},
        {"Smithsonian Astrophysical Observation", "SAO 250441"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.53170821),
        dec: Angle.Degrees(-64.49992086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84851"},
        {"Hipparcos Number", "HIP 47876"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.36028741),
        dec: Angle.Degrees(-64.49991229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171971"},
        {"Hipparcos Number", "HIP 91711"},
        {"Smithsonian Astrophysical Observation", "SAO 254341"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.54066180),
        dec: Angle.Degrees(-64.49873715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92467"},
        {"Hipparcos Number", "HIP 52116"},
        {"Celescope Catalog", "CEL 3615"},
        {"Geneva Identification System", "GEN# +3.26020018"},
        {"Smithsonian Astrophysical Observation", "SAO 251043"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.71416743),
        dec: Angle.Degrees(-64.49803905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216170"},
        {"Hipparcos Number", "HIP 112916"},
        {"Smithsonian Astrophysical Observation", "SAO 255337"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.00595244),
        dec: Angle.Degrees(-64.49791196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16299"},
        {"Hipparcos Number", "HIP 11938"},
        {"Smithsonian Astrophysical Observation", "SAO 248600"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.50964355),
        dec: Angle.Degrees(-64.49210852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54400"},
        {"Hipparcos Number", "HIP 34092"},
        {"Smithsonian Astrophysical Observation", "SAO 249722"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.03626965),
        dec: Angle.Degrees(-64.48998046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86634"},
        {"Hipparcos Number", "HIP 48806"},
        {"Fundamental Katalog 5th Edition", "FK5 2801"},
        {"Geneva Identification System", "GEN# +1.00086634"},
        {"Smithsonian Astrophysical Observation", "SAO 250760"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.31411698),
        dec: Angle.Degrees(-64.48956138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83919"},
        {"Hipparcos Number", "HIP 47343"},
        {"Smithsonian Astrophysical Observation", "SAO 250649"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.70754292),
        dec: Angle.Degrees(-64.48925790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70027"},
        {"Hipparcos Number", "HIP 40475"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.96257456),
        dec: Angle.Degrees(-64.48515945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116457"},
        {"Hipparcos Number", "HIP 65479"},
        {"Fundamental Katalog 5th Edition", "FK5 3071"},
        {"Geneva Identification System", "GEN# +1.00116457"},
        {"Smithsonian Astrophysical Observation", "SAO 252304"},
        {"Wilson Evans Batten Catalogue", "WEB 11554"},
    },
    visualMagnitude: 5.32,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.30889897),
        dec: Angle.Degrees(-64.48509219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62563"},
        {"Hipparcos Number", "HIP 37377"},
        {"Smithsonian Astrophysical Observation", "SAO 249916"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.08870669),
        dec: Angle.Degrees(-64.48351162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119764"},
        {"Hipparcos Number", "HIP 67262"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.79448543),
        dec: Angle.Degrees(-64.48273100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40455"},
        {"Hipparcos Number", "HIP 27897"},
        {"Geneva Identification System", "GEN# +1.00040455"},
        {"Smithsonian Astrophysical Observation", "SAO 249391"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.54974811),
        dec: Angle.Degrees(-64.48240057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94174"},
        {"Hipparcos Number", "HIP 53016"},
        {"Geneva Identification System", "GEN# +3.26020063"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.69186216),
        dec: Angle.Degrees(-64.47947932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95230"},
        {"Hipparcos Number", "HIP 53626"},
        {"Geneva Identification System", "GEN# +1.00095230"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.56803034),
        dec: Angle.Degrees(-64.47680736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213157"},
        {"Hipparcos Number", "HIP 111160"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.80520719),
        dec: Angle.Degrees(-64.47614127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225092"},
        {"Hipparcos Number", "HIP 265"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.83539281),
        dec: Angle.Degrees(-64.47608070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92783"},
        {"Hipparcos Number", "HIP 52293"},
        {"Celescope Catalog", "CEL 3641"},
        {"Geneva Identification System", "GEN# +3.26020029"},
        {"Smithsonian Astrophysical Observation", "SAO 251066"},
        {"Wilson Evans Batten Catalogue", "WEB 9521"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.27682668),
        dec: Angle.Degrees(-64.47440681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148359"},
        {"Hipparcos Number", "HIP 80948"},
        {"Smithsonian Astrophysical Observation", "SAO 253586"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.93576264),
        dec: Angle.Degrees(-64.47337401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123008"},
        {"Hipparcos Number", "HIP 68995"},
        {"Geneva Identification System", "GEN# +1.00123008"},
        {"Smithsonian Astrophysical Observation", "SAO 252603"},
        {"Wilson Evans Batten Catalogue", "WEB 12055"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.87771221),
        dec: Angle.Degrees(-64.46909797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34573"},
        {"Hipparcos Number", "HIP 24383"},
        {"Smithsonian Astrophysical Observation", "SAO 249222"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.46276899),
        dec: Angle.Degrees(-64.46907024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125244"},
        {"Hipparcos Number", "HIP 70098"},
        {"Cincinnati Publication", "Ci 20 847"},
        {"Geneva Identification System", "GEN# +1.00125244"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.16016970),
        dec: Angle.Degrees(-64.46824403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92938"},
        {"Hipparcos Number", "HIP 52370"},
        {"Celescope Catalog", "CEL 3654"},
        {"Geneva Identification System", "GEN# +1.00092938"},
        {"Geneva Identification System 2", "GEN# +3.26020033"},
        {"Renson", "Renson 26840"},
        {"Smithsonian Astrophysical Observation", "SAO 251078"},
        {"Wilson Evans Batten Catalogue", "WEB 9531"},
    },
    visualMagnitude: 4.76,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.55893343),
        dec: Angle.Degrees(-64.46645380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224788"},
        {"Hipparcos Number", "HIP 60"},
        {"Fundamental Katalog 5th Edition", "FK5 4001"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.17542318),
        dec: Angle.Degrees(-64.46582516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143324"},
        {"Hipparcos Number", "HIP 78675"},
        {"Smithsonian Astrophysical Observation", "SAO 253401"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.92258451),
        dec: Angle.Degrees(-64.46501818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101530"},
        {"Hipparcos Number", "HIP 56950"},
        {"Geneva Identification System", "GEN# +1.00101530"},
        {"Smithsonian Astrophysical Observation", "SAO 251531"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.12082680),
        dec: Angle.Degrees(-64.46423063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135804"},
        {"Hipparcos Number", "HIP 75082"},
        {"Geneva Identification System", "GEN# +1.00135804"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.14023589),
        dec: Angle.Degrees(-64.46194637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86983"},
        {"Hipparcos Number", "HIP 48985"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.91406127),
        dec: Angle.Degrees(-64.46099024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117074"},
        {"Hipparcos Number", "HIP 65815"},
        {"Geneva Identification System", "GEN# +1.00117074"},
        {"Smithsonian Astrophysical Observation", "SAO 252332"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.37607967),
        dec: Angle.Degrees(-64.46001751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215742"},
        {"Hipparcos Number", "HIP 112642"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.19954878),
        dec: Angle.Degrees(-64.45771961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106635"},
        {"Hipparcos Number", "HIP 59830"},
        {"Celescope Catalog", "CEL 4082"},
        {"Geneva Identification System", "GEN# +1.00106635"},
        {"Smithsonian Astrophysical Observation", "SAO 251819"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.03092191),
        dec: Angle.Degrees(-64.45426614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71843"},
        {"Hipparcos Number", "HIP 41318"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.45684148),
        dec: Angle.Degrees(-64.44933479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15144"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.80800177),
        dec: Angle.Degrees(-64.44513912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20586"},
        {"Hipparcos Number", "HIP 15140"},
        {"Geneva Identification System", "GEN# +1.00020586"},
        {"Renson", "Renson 5140"},
        {"Smithsonian Astrophysical Observation", "SAO 248764"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.79612383),
        dec: Angle.Degrees(-64.44374285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30207"},
        {"Hipparcos Number", "HIP 21811"},
        {"Renson", "Renson 7780"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.27824308),
        dec: Angle.Degrees(-64.44286147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42754"},
        {"Hipparcos Number", "HIP 29058"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.95034968),
        dec: Angle.Degrees(-64.44169688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113457"},
        {"Hipparcos Number", "HIP 63839"},
        {"Celescope Catalog", "CEL 4196"},
        {"Geneva Identification System", "GEN# +1.00113457"},
        {"Smithsonian Astrophysical Observation", "SAO 252144"},
        {"Wilson Evans Batten Catalogue", "WEB 11287"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.25871258),
        dec: Angle.Degrees(-64.44154317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82502"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.93022192),
        dec: Angle.Degrees(-64.43982167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -483.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105273"},
        {"Hipparcos Number", "HIP 59112"},
        {"Geneva Identification System", "GEN# +1.00105273"},
        {"Smithsonian Astrophysical Observation", "SAO 251748"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.81862987),
        dec: Angle.Degrees(-64.43966701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83420"},
        {"Hipparcos Number", "HIP 47055"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.85250864),
        dec: Angle.Degrees(-64.43874009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18423"},
        {"Hipparcos Number", "HIP 13537"},
        {"Geneva Identification System", "GEN# +1.00018423"},
        {"Smithsonian Astrophysical Observation", "SAO 248681"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.58663837),
        dec: Angle.Degrees(-64.43556911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132906"},
        {"Hipparcos Number", "HIP 73788"},
        {"Smithsonian Astrophysical Observation", "SAO 253008"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.23059506),
        dec: Angle.Degrees(-64.43252236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87654"},
        {"Hipparcos Number", "HIP 49327"},
        {"Geneva Identification System", "GEN# +1.00087654"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.03230940),
        dec: Angle.Degrees(-64.43141884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191585"},
        {"Hipparcos Number", "HIP 99772"},
        {"Smithsonian Astrophysical Observation", "SAO 254757"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.64550692),
        dec: Angle.Degrees(-64.42970045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197165"},
        {"Hipparcos Number", "HIP 102443"},
        {"Smithsonian Astrophysical Observation", "SAO 254864"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.37646259),
        dec: Angle.Degrees(-64.42743810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25743"},
        {"Hipparcos Number", "HIP 18738"},
        {"Geneva Identification System", "GEN# +1.00025743"},
        {"Smithsonian Astrophysical Observation", "SAO 248926"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.20815265),
        dec: Angle.Degrees(-64.42214525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37363"},
        {"Hipparcos Number", "HIP 26056"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.36531606),
        dec: Angle.Degrees(-64.41836490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138211"},
        {"Hipparcos Number", "HIP 76231"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.58397758),
        dec: Angle.Degrees(-64.41603746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128363"},
        {"Hipparcos Number", "HIP 71645"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.81632894),
        dec: Angle.Degrees(-64.41545383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134037"},
        {"Hipparcos Number", "HIP 74290"},
        {"Smithsonian Astrophysical Observation", "SAO 253044"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.75464187),
        dec: Angle.Degrees(-64.41489005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94422"},
        {"Hipparcos Number", "HIP 53164"},
        {"Geneva Identification System", "GEN# +3.26020064"},
        {"Smithsonian Astrophysical Observation", "SAO 251159"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.14021233),
        dec: Angle.Degrees(-64.41407210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202876"},
        {"Hipparcos Number", "HIP 105468"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.44147646),
        dec: Angle.Degrees(-64.40964655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62870"},
        {"Smithsonian Astrophysical Observation", "SAO 252065"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.28150524),
        dec: Angle.Degrees(-64.40932529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106343"},
        {"Hipparcos Number", "HIP 59678"},
        {"Celescope Catalog", "CEL 4073"},
        {"Geneva Identification System", "GEN# +1.00106343"},
        {"Smithsonian Astrophysical Observation", "SAO 251803"},
        {"Wilson Evans Batten Catalogue", "WEB 10603"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.57055472),
        dec: Angle.Degrees(-64.40851906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140360"},
        {"Hipparcos Number", "HIP 77306"},
    },
    visualMagnitude: 8.37,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.74452773),
        dec: Angle.Degrees(-64.40786004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203230"},
        {"Hipparcos Number", "HIP 105643"},
        {"Geneva Identification System", "GEN# +1.00203230"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.96781417),
        dec: Angle.Degrees(-64.40518935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63668"},
        {"Hipparcos Number", "HIP 37888"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.47638313),
        dec: Angle.Degrees(-64.40482531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146753"},
        {"Hipparcos Number", "HIP 80177"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.50026105),
        dec: Angle.Degrees(-64.40471504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222820"},
        {"Hipparcos Number", "HIP 117088"},
        {"Fundamental Katalog 5th Edition", "FK5 3904"},
        {"Geneva Identification System", "GEN# +1.00222820"},
        {"Smithsonian Astrophysical Observation", "SAO 255557"},
    },
    visualMagnitude: 5.73,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.05010877),
        dec: Angle.Degrees(-64.40453515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88635"},
        {"Hipparcos Number", "HIP 49875"},
        {"Smithsonian Astrophysical Observation", "SAO 250855"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.76188399),
        dec: Angle.Degrees(-64.40394400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70201"},
        {"Hipparcos Number", "HIP 40547"},
        {"Smithsonian Astrophysical Observation", "SAO 250172"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.19668781),
        dec: Angle.Degrees(-64.40318656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83834"},
        {"Hipparcos Number", "HIP 47301"},
        {"Geneva Identification System", "GEN# +1.00083834"},
        {"Smithsonian Astrophysical Observation", "SAO 250647"},
        {"Wilson Evans Batten Catalogue", "WEB 8891"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.59135858),
        dec: Angle.Degrees(-64.40249586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143028"},
        {"Hipparcos Number", "HIP 78526"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.47099143),
        dec: Angle.Degrees(-64.40023568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218962"},
        {"Hipparcos Number", "HIP 114620"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.30520209),
        dec: Angle.Degrees(-64.39935255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17557"},
        {"Hipparcos Number", "HIP 12909"},
        {"Smithsonian Astrophysical Observation", "SAO 248646"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.49173951),
        dec: Angle.Degrees(-64.39665900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88864"},
        {"Hipparcos Number", "HIP 50020"},
        {"Geneva Identification System", "GEN# +1.00088864"},
        {"Smithsonian Astrophysical Observation", "SAO 250869"},
        {"Wilson Evans Batten Catalogue", "WEB 9197"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.18398897),
        dec: Angle.Degrees(-64.39463944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93030"},
        {"Hipparcos Number", "HIP 52419"},
        {"Celescope Catalog", "CEL 3659"},
        {"Fundamental Katalog 5th Edition", "FK5 406"},
        {"Geneva Identification System", "GEN# +3.26020037"},
        {"Renson", "Renson 26850"},
        {"Smithsonian Astrophysical Observation", "SAO 251083"},
        {"Wilson Evans Batten Catalogue", "WEB 9545"},
    },
    visualMagnitude: 2.74,
    bvColour: -0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.73927802),
        dec: Angle.Degrees(-64.39447937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194420"},
        {"Hipparcos Number", "HIP 101064"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.32481278),
        dec: Angle.Degrees(-64.39423070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32714"},
        {"Hipparcos Number", "HIP 23280"},
        {"Smithsonian Astrophysical Observation", "SAO 249165"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.13609035),
        dec: Angle.Degrees(-64.39421498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213956"},
        {"Hipparcos Number", "HIP 111621"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.19136073),
        dec: Angle.Degrees(-64.38972877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95185"},
        {"Hipparcos Number", "HIP 53611"},
        {"Fundamental Katalog 5th Edition", "FK5 4967"},
        {"Geneva Identification System", "GEN# +1.00095185"},
        {"Smithsonian Astrophysical Observation", "SAO 251200"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.52050740),
        dec: Angle.Degrees(-64.38856307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42649"},
        {"Hipparcos Number", "HIP 29004"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.79733741),
        dec: Angle.Degrees(-64.38838301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31146"},
        {"Hipparcos Number", "HIP 22364"},
        {"Fundamental Katalog 5th Edition", "FK5 4440"},
        {"Smithsonian Astrophysical Observation", "SAO 249118"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.21969611),
        dec: Angle.Degrees(-64.38814618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11394"},
        {"Hipparcos Number", "HIP 8512"},
        {"Geneva Identification System", "GEN# +1.00011394"},
        {"Wilson Evans Batten Catalogue", "WEB 1810"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.44989873),
        dec: Angle.Degrees(-64.38591376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88528"},
        {"Hipparcos Number", "HIP 49833"},
        {"Celescope Catalog", "CEL 3456"},
        {"Geneva Identification System", "GEN# +1.00088528"},
        {"Smithsonian Astrophysical Observation", "SAO 250849"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.60119265),
        dec: Angle.Degrees(-64.38427558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93607"},
        {"Hipparcos Number", "HIP 52736"},
        {"Celescope Catalog", "CEL 3700"},
        {"Geneva Identification System", "GEN# +3.26020051"},
        {"Smithsonian Astrophysical Observation", "SAO 251120"},
        {"Wilson Evans Batten Catalogue", "WEB 9600"},
    },
    visualMagnitude: 4.87,
    bvColour: -0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.71351737),
        dec: Angle.Degrees(-64.38349702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1407"},
        {"Geneva Identification System", "GEN# +6.20145161"},
    },
    visualMagnitude: 11.30,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.40185144),
        dec: Angle.Degrees(-64.37859014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168176"},
        {"Hipparcos Number", "HIP 90090"},
        {"Smithsonian Astrophysical Observation", "SAO 254221"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.76962712),
        dec: Angle.Degrees(-64.37815988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216620"},
        {"Hipparcos Number", "HIP 113215"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.91580740),
        dec: Angle.Degrees(-64.37709897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67893"},
        {"Hipparcos Number", "HIP 39642"},
        {"Geneva Identification System", "GEN# +1.00067893"},
        {"Smithsonian Astrophysical Observation", "SAO 250109"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.51434266),
        dec: Angle.Degrees(-64.37693987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123230"},
        {"Hipparcos Number", "HIP 69101"},
        {"Geneva Identification System", "GEN# +1.00123230"},
        {"Smithsonian Astrophysical Observation", "SAO 252621"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.17743125),
        dec: Angle.Degrees(-64.37497585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125319"},
        {"Hipparcos Number", "HIP 70148"},
        {"Geneva Identification System", "GEN# +1.00125319"},
        {"Smithsonian Astrophysical Observation", "SAO 252711"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.29710305),
        dec: Angle.Degrees(-64.37334627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224685"},
        {"Hipparcos Number", "HIP 118321"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.97823891),
        dec: Angle.Degrees(-64.37257220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 216.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60674"},
        {"Hipparcos Number", "HIP 36576"},
        {"Geneva Identification System", "GEN# +1.00060674"},
        {"Smithsonian Astrophysical Observation", "SAO 249874"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.85033172),
        dec: Angle.Degrees(-64.37241939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221269"},
        {"Hipparcos Number", "HIP 116079"},
        {"Geneva Identification System", "GEN# +1.00221269"},
        {"Smithsonian Astrophysical Observation", "SAO 255506"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.82669883),
        dec: Angle.Degrees(-64.37147961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1782"},
        {"Hipparcos Number", "HIP 1726"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.43618850),
        dec: Angle.Degrees(-64.37143104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112703"},
        {"Hipparcos Number", "HIP 63411"},
        {"Geneva Identification System", "GEN# +1.00112703"},
        {"Smithsonian Astrophysical Observation", "SAO 252117"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.90601827),
        dec: Angle.Degrees(-64.37126613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -383.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8810"},
        {"Hipparcos Number", "HIP 6631"},
        {"Fundamental Katalog 5th Edition", "FK5 1038"},
        {"Geneva Identification System", "GEN# +1.00008810"},
        {"Smithsonian Astrophysical Observation", "SAO 248381"},
        {"Wilson Evans Batten Catalogue", "WEB 1450"},
    },
    visualMagnitude: 5.92,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.27198122),
        dec: Angle.Degrees(-64.36943630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119817"},
        {"Hipparcos Number", "HIP 67296"},
        {"Smithsonian Astrophysical Observation", "SAO 252449"},
    },
    visualMagnitude: 8.45,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.87192342),
        dec: Angle.Degrees(-64.36500303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150746"},
        {"Hipparcos Number", "HIP 82164"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.79670478),
        dec: Angle.Degrees(-64.36411660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112272"},
        {"Hipparcos Number", "HIP 63170"},
        {"Geneva Identification System", "GEN# +1.00112272"},
        {"Smithsonian Astrophysical Observation", "SAO 252099"},
        {"Wilson Evans Batten Catalogue", "WEB 11198"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.14060972),
        dec: Angle.Degrees(-64.36086707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124947"},
        {"Hipparcos Number", "HIP 69954"},
        {"Geneva Identification System", "GEN# +1.00124947"},
        {"Smithsonian Astrophysical Observation", "SAO 252698"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.72641546),
        dec: Angle.Degrees(-64.35987711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48920"},
        {"Hipparcos Number", "HIP 32011"},
        {"Geneva Identification System", "GEN# +1.00048920"},
        {"Smithsonian Astrophysical Observation", "SAO 249623"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.31639306),
        dec: Angle.Degrees(-64.35961368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7112"},
        {"Hipparcos Number", "HIP 5462"},
        {"Smithsonian Astrophysical Observation", "SAO 248331"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.48587624),
        dec: Angle.Degrees(-64.35923278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13578"},
        {"Hipparcos Number", "HIP 10116"},
        {"Geneva Identification System", "GEN# +1.00013578"},
        {"Smithsonian Astrophysical Observation", "SAO 248504"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.53232462),
        dec: Angle.Degrees(-64.35511762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 351.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122596"},
        {"Hipparcos Number", "HIP 68804"},
        {"Smithsonian Astrophysical Observation", "SAO 252588"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.29249197),
        dec: Angle.Degrees(-64.35280953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11266"},
        {"Hipparcos Number", "HIP 8407"},
        {"Geneva Identification System", "GEN# +1.00011266"},
        {"Smithsonian Astrophysical Observation", "SAO 248438"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.11688300),
        dec: Angle.Degrees(-64.35260971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90731"},
        {"Hipparcos Number", "HIP 51131"},
        {"Geneva Identification System", "GEN# +1.00090731"},
        {"Smithsonian Astrophysical Observation", "SAO 250958"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.68518977),
        dec: Angle.Degrees(-64.35173058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128794"},
        {"Hipparcos Number", "HIP 71847"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.44654795),
        dec: Angle.Degrees(-64.34902450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186812"},
        {"Hipparcos Number", "HIP 97661"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.72310159),
        dec: Angle.Degrees(-64.34895270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27056"},
        {"Hipparcos Number", "HIP 19630"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.09512483),
        dec: Angle.Degrees(-64.34193812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108501"},
        {"Hipparcos Number", "HIP 60851"},
        {"Geneva Identification System", "GEN# +1.00108501"},
        {"Smithsonian Astrophysical Observation", "SAO 251920"},
        {"Wilson Evans Batten Catalogue", "WEB 10827"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.08046209),
        dec: Angle.Degrees(-64.34096078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209974"},
        {"Hipparcos Number", "HIP 109359"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.33969527),
        dec: Angle.Degrees(-64.34018708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222830"},
        {"Hipparcos Number", "HIP 117096"},
        {"Smithsonian Astrophysical Observation", "SAO 255558"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.07282204),
        dec: Angle.Degrees(-64.33965925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104035"},
        {"Hipparcos Number", "HIP 58427"},
        {"Celescope Catalog", "CEL 4025"},
        {"Geneva Identification System", "GEN# +1.00104035"},
        {"Smithsonian Astrophysical Observation", "SAO 251664"},
        {"Wilson Evans Batten Catalogue", "WEB 10441"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.69861981),
        dec: Angle.Degrees(-64.33955671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82281"},
        {"Hipparcos Number", "HIP 46428"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.02259545),
        dec: Angle.Degrees(-64.33792300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74562"},
        {"Hipparcos Number", "HIP 42610"},
        {"Celescope Catalog", "CEL 2792"},
        {"Smithsonian Astrophysical Observation", "SAO 250303"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.26487314),
        dec: Angle.Degrees(-64.33486564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125208"},
        {"Hipparcos Number", "HIP 70080"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.11910144),
        dec: Angle.Degrees(-64.33436047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86772"},
        {"Hipparcos Number", "HIP 48888"},
        {"Smithsonian Astrophysical Observation", "SAO 250767"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.56975554),
        dec: Angle.Degrees(-64.33393260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98884",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98884"},
    },
    visualMagnitude: 11.68,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.21016080),
        dec: Angle.Degrees(-64.33357071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35568"},
        {"Hipparcos Number", "HIP 24986"},
        {"Geneva Identification System", "GEN# +1.00035568"},
        {"Smithsonian Astrophysical Observation", "SAO 249258"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.25436580),
        dec: Angle.Degrees(-64.33315480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 167.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20271"},
        {"Hipparcos Number", "HIP 14884"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.02445996),
        dec: Angle.Degrees(-64.33260178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21827"},
        {"Hipparcos Number", "HIP 16099"},
        {"Smithsonian Astrophysical Observation", "SAO 248811"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.84957687),
        dec: Angle.Degrees(-64.33098014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24202"},
        {"Hipparcos Number", "HIP 17683"},
        {"Geneva Identification System", "GEN# +1.00024202"},
        {"Wilson Evans Batten Catalogue", "WEB 3370"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.82074917),
        dec: Angle.Degrees(-64.33018220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 329.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 266.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136976"},
        {"Hipparcos Number", "HIP 75624"},
        {"Geneva Identification System", "GEN# +1.00136976"},
        {"Smithsonian Astrophysical Observation", "SAO 253170"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.77688755),
        dec: Angle.Degrees(-64.32991421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130764"},
        {"Hipparcos Number", "HIP 72816"},
        {"Smithsonian Astrophysical Observation", "SAO 252932"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.25252663),
        dec: Angle.Degrees(-64.32530164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160675"},
        {"Hipparcos Number", "HIP 86935"},
        {"Geneva Identification System", "GEN# +1.00160675"},
        {"Smithsonian Astrophysical Observation", "SAO 254021"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.45669466),
        dec: Angle.Degrees(-64.32523706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36369"},
        {"Hipparcos Number", "HIP 25459"},
        {"Smithsonian Astrophysical Observation", "SAO 249276"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.67263682),
        dec: Angle.Degrees(-64.32440526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14877"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.01382448),
        dec: Angle.Degrees(-64.32422363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174454"},
        {"Hipparcos Number", "HIP 92844"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.77874606),
        dec: Angle.Degrees(-64.32408755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171942"},
        {"Hipparcos Number", "HIP 91701"},
        {"Geneva Identification System", "GEN# +1.00171942"},
        {"Smithsonian Astrophysical Observation", "SAO 254338"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.51170791),
        dec: Angle.Degrees(-64.32300369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 271044"},
        {"Hipparcos Number", "HIP 24055"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.53672676),
        dec: Angle.Degrees(-64.31790696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190880"},
        {"Hipparcos Number", "HIP 99442"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.75442781),
        dec: Angle.Degrees(-64.31616671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27545"},
        {"Hipparcos Number", "HIP 19945"},
        {"Geneva Identification System", "GEN# +1.00027545"},
        {"Smithsonian Astrophysical Observation", "SAO 248978"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.16375868),
        dec: Angle.Degrees(-64.31565296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114738"},
        {"Hipparcos Number", "HIP 64546"},
        {"Geneva Identification System", "GEN# +1.00114738"},
        {"Smithsonian Astrophysical Observation", "SAO 252214"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.44602598),
        dec: Angle.Degrees(-64.31323355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41371"},
        {"Hipparcos Number", "HIP 28420"},
        {"Smithsonian Astrophysical Observation", "SAO 249415"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.03215688),
        dec: Angle.Degrees(-64.31008159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6914"},
        {"Hipparcos Number", "HIP 5337"},
        {"Smithsonian Astrophysical Observation", "SAO 248326"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.05595976),
        dec: Angle.Degrees(-64.30985215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161441"},
        {"Hipparcos Number", "HIP 87286"},
        {"Geneva Identification System", "GEN# +1.00161441"},
        {"Smithsonian Astrophysical Observation", "SAO 254047"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.53068676),
        dec: Angle.Degrees(-64.30513938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95752"},
        {"Hipparcos Number", "HIP 53909"},
        {"Geneva Identification System", "GEN# +1.00095752"},
        {"Smithsonian Astrophysical Observation", "SAO 251226"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.45722223),
        dec: Angle.Degrees(-64.30391944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100717",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100717"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.28543329),
        dec: Angle.Degrees(-64.30029664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15646"},
        {"Hipparcos Number", "HIP 11479"},
        {"Fundamental Katalog 5th Edition", "FK5 2170"},
        {"Geneva Identification System", "GEN# +1.00015646"},
        {"Smithsonian Astrophysical Observation", "SAO 248567"},
        {"Wilson Evans Batten Catalogue", "WEB 2398"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.01808014),
        dec: Angle.Degrees(-64.29978331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224392"},
        {"Hipparcos Number", "HIP 118121"},
        {"Geneva Identification System", "GEN# +1.00224392"},
        {"Smithsonian Astrophysical Observation", "SAO 255609"},
        {"Wilson Evans Batten Catalogue", "WEB 20767"},
    },
    visualMagnitude: 5.00,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.39571557),
        dec: Angle.Degrees(-64.29808259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217488"},
        {"Hipparcos Number", "HIP 113759"},
        {"Geneva Identification System", "GEN# +1.00217488"},
        {"Smithsonian Astrophysical Observation", "SAO 255381"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.56662795),
        dec: Angle.Degrees(-64.29784942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13878"},
        {"Hipparcos Number", "HIP 10289"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.12806015),
        dec: Angle.Degrees(-64.29611873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103867"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.69566456),
        dec: Angle.Degrees(-64.29470934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64930"},
        {"Hipparcos Number", "HIP 38407"},
        {"Smithsonian Astrophysical Observation", "SAO 249989"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.03049275),
        dec: Angle.Degrees(-64.29421903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2849"},
        {"Hipparcos Number", "HIP 2449"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.79371440),
        dec: Angle.Degrees(-64.29356616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177927"},
        {"Hipparcos Number", "HIP 94249"},
        {"Smithsonian Astrophysical Observation", "SAO 254484"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.77335754),
        dec: Angle.Degrees(-64.29096704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91997"},
        {"Hipparcos Number", "HIP 51848"},
        {"Geneva Identification System", "GEN# +3.26020012"},
        {"Smithsonian Astrophysical Observation", "SAO 251026"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.89407328),
        dec: Angle.Degrees(-64.29073714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212727"},
        {"Hipparcos Number", "HIP 110914"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.06474301),
        dec: Angle.Degrees(-64.28968805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78446"},
        {"Hipparcos Number", "HIP 44590"},
        {"Smithsonian Astrophysical Observation", "SAO 250435"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.26039646),
        dec: Angle.Degrees(-64.28944566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145161"},
        {"Hipparcos Number", "HIP 79502"},
        {"Smithsonian Astrophysical Observation", "SAO 253461"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.35559753),
        dec: Angle.Degrees(-64.28583199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125432"},
        {"Hipparcos Number", "HIP 70213"},
        {"Smithsonian Astrophysical Observation", "SAO 252716"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.47783615),
        dec: Angle.Degrees(-64.28482323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127024"},
        {"Hipparcos Number", "HIP 71050"},
        {"Geneva Identification System", "GEN# +1.00127024"},
        {"Smithsonian Astrophysical Observation", "SAO 252772"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.95383913),
        dec: Angle.Degrees(-64.28347838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16891"},
        {"Hipparcos Number", "HIP 12389"},
        {"Geneva Identification System", "GEN# +1.00016891"},
        {"Smithsonian Astrophysical Observation", "SAO 248616"},
        {"Wilson Evans Batten Catalogue", "WEB 2538"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.88207190),
        dec: Angle.Degrees(-64.28176927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42229"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.15398277),
        dec: Angle.Degrees(-64.27354910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18755"},
        {"Hipparcos Number", "HIP 13795"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.40433684),
        dec: Angle.Degrees(-64.27319236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186252"},
        {"Hipparcos Number", "HIP 97373"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.86386045),
        dec: Angle.Degrees(-64.26789090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93549"},
        {"Hipparcos Number", "HIP 52701"},
        {"Celescope Catalog", "CEL 3698"},
        {"Geneva Identification System", "GEN# +3.26020049"},
        {"Geneva Identification System 2", "GEN# +1.00093549"},
        {"Smithsonian Astrophysical Observation", "SAO 251117"},
        {"Wilson Evans Batten Catalogue", "WEB 9597"},
    },
    visualMagnitude: 5.23,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.62337904),
        dec: Angle.Degrees(-64.26326386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 308149"},
        {"Hipparcos Number", "HIP 53945"},
        {"Geneva Identification System", "GEN# +1.00308149"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.56696417),
        dec: Angle.Degrees(-64.26291568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93738"},
        {"Hipparcos Number", "HIP 52815"},
        {"Celescope Catalog", "CEL 3715"},
        {"Geneva Identification System", "GEN# +3.26020054"},
        {"Smithsonian Astrophysical Observation", "SAO 251128"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.97312616),
        dec: Angle.Degrees(-64.26286554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65752",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65752"},
        {"Smithsonian Astrophysical Observation", "SAO 252324"},
    },
    visualMagnitude: 8.82,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.17762314),
        dec: Angle.Degrees(-64.25229570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85703"},
        {"Hipparcos Number", "HIP 48326"},
        {"Smithsonian Astrophysical Observation", "SAO 250724"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.76391096),
        dec: Angle.Degrees(-64.25156027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149237"},
        {"Hipparcos Number", "HIP 81422"},
        {"Geneva Identification System", "GEN# +1.00149237"},
        {"Smithsonian Astrophysical Observation", "SAO 253631"},
        {"Wilson Evans Batten Catalogue", "WEB 13759"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.44233665),
        dec: Angle.Degrees(-64.24918493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93163"},
        {"Hipparcos Number", "HIP 52487"},
        {"Celescope Catalog", "CEL 3676"},
        {"Geneva Identification System", "GEN# +3.26020040"},
        {"Smithsonian Astrophysical Observation", "SAO 251095"},
        {"Wilson Evans Batten Catalogue", "WEB 9559"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.96339384),
        dec: Angle.Degrees(-64.24905176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104388"},
        {"Hipparcos Number", "HIP 58613"},
        {"Celescope Catalog", "CEL 4033"},
        {"Geneva Identification System", "GEN# +1.00104388"},
        {"Smithsonian Astrophysical Observation", "SAO 251682"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.29825752),
        dec: Angle.Degrees(-64.24834404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116953"},
        {"Hipparcos Number", "HIP 65745"},
        {"Geneva Identification System", "GEN# +1.00116953"},
        {"Smithsonian Astrophysical Observation", "SAO 252323"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.15691125),
        dec: Angle.Degrees(-64.24442038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224378"},
        {"Hipparcos Number", "HIP 118096"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.33961333),
        dec: Angle.Degrees(-64.24312196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13935",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13935"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.88488850),
        dec: Angle.Degrees(-64.24297301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 189.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160"},
        {"Hipparcos Number", "HIP 519"},
        {"Geneva Identification System", "GEN# +1.00000160J"},
        {"Smithsonian Astrophysical Observation", "SAO 248117"},
        {"Wilson Evans Batten Catalogue", "WEB 91"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.57000983),
        dec: Angle.Degrees(-64.24051492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59760"},
        {"Hipparcos Number", "HIP 36192"},
        {"Smithsonian Astrophysical Observation", "SAO 249855"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.79922646),
        dec: Angle.Degrees(-64.24043871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159348"},
        {"Hipparcos Number", "HIP 86358"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.69648741),
        dec: Angle.Degrees(-64.24022629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46491"},
        {"Hipparcos Number", "HIP 30901"},
        {"Geneva Identification System", "GEN# +1.00046491"},
        {"Smithsonian Astrophysical Observation", "SAO 249563"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.29297516),
        dec: Angle.Degrees(-64.23737342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12809"},
        {"Hipparcos Number", "HIP 9580"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.77967437),
        dec: Angle.Degrees(-64.23451942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113466"},
        {"Hipparcos Number", "HIP 63847"},
        {"Geneva Identification System", "GEN# +1.00113466"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.27223504),
        dec: Angle.Degrees(-64.23198201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88145"},
        {"Hipparcos Number", "HIP 49631"},
        {"Geneva Identification System", "GEN# +1.00088145"},
        {"Smithsonian Astrophysical Observation", "SAO 250825"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.93463528),
        dec: Angle.Degrees(-64.23174628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122098"},
        {"Hipparcos Number", "HIP 68540"},
        {"Geneva Identification System", "GEN# +1.00122098"},
        {"Smithsonian Astrophysical Observation", "SAO 252560"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.47547699),
        dec: Angle.Degrees(-64.22963982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37297"},
        {"Hipparcos Number", "HIP 26001"},
        {"Fundamental Katalog 5th Edition", "FK5 2418"},
        {"Geneva Identification System", "GEN# +1.00037297"},
        {"Smithsonian Astrophysical Observation", "SAO 249309"},
        {"Wilson Evans Batten Catalogue", "WEB 5062"},
    },
    visualMagnitude: 5.34,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.24801962),
        dec: Angle.Degrees(-64.22751422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26491"},
        {"Hipparcos Number", "HIP 19233"},
        {"Geneva Identification System", "GEN# +1.00026491"},
        {"Smithsonian Astrophysical Observation", "SAO 248945"},
        {"Wilson Evans Batten Catalogue", "WEB 3691"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.83871877),
        dec: Angle.Degrees(-64.22310952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 185.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 336.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112795"},
        {"Hipparcos Number", "HIP 63470"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.08479921),
        dec: Angle.Degrees(-64.22251163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61448"},
        {"Geneva Identification System", "GEN# -0.06302356"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.88532241),
        dec: Angle.Degrees(-64.22124266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91944"},
        {"Hipparcos Number", "HIP 51822"},
        {"Geneva Identification System", "GEN# +3.26020009"},
        {"Smithsonian Astrophysical Observation", "SAO 251024"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.81024249),
        dec: Angle.Degrees(-64.22117607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121475"},
        {"Hipparcos Number", "HIP 68195"},
        {"Geneva Identification System", "GEN# +1.00121475"},
        {"Smithsonian Astrophysical Observation", "SAO 252532"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.42727298),
        dec: Angle.Degrees(-64.21894480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115977"},
        {"Hipparcos Number", "HIP 65242"},
        {"Geneva Identification System", "GEN# +1.00115977"},
    },
    visualMagnitude: 7.70,
    bvColour: 2.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.54104644),
        dec: Angle.Degrees(-64.21882819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108020"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.26075656),
        dec: Angle.Degrees(-64.21736183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88845"},
        {"Hipparcos Number", "HIP 50018"},
        {"Smithsonian Astrophysical Observation", "SAO 250868"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.17885142),
        dec: Angle.Degrees(-64.21643106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136860"},
        {"Hipparcos Number", "HIP 75582"},
        {"Smithsonian Astrophysical Observation", "SAO 253161"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.62421049),
        dec: Angle.Degrees(-64.21272306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110610"},
        {"Hipparcos Number", "HIP 62138"},
        {"Fundamental Katalog 5th Edition", "FK5 5123"},
        {"Geneva Identification System", "GEN# +1.00110610"},
        {"Smithsonian Astrophysical Observation", "SAO 252007"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.03267094),
        dec: Angle.Degrees(-64.21148524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10938"},
    },
    visualMagnitude: 10.92,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.22423353),
        dec: Angle.Degrees(-64.21034241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -266.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127489"},
        {"Hipparcos Number", "HIP 71264"},
        {"Geneva Identification System", "GEN# +1.00127489"},
        {"Smithsonian Astrophysical Observation", "SAO 252793"},
        {"Wilson Evans Batten Catalogue", "WEB 12313"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.62192007),
        dec: Angle.Degrees(-64.20202807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124154"},
        {"Hipparcos Number", "HIP 69543"},
        {"Geneva Identification System", "GEN# +1.00124154"},
        {"Smithsonian Astrophysical Observation", "SAO 252657"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.54598851),
        dec: Angle.Degrees(-64.20096176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198609"},
        {"Hipparcos Number", "HIP 103231"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.70726109),
        dec: Angle.Degrees(-64.19990916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79865"},
        {"Hipparcos Number", "HIP 45261"},
        {"Smithsonian Astrophysical Observation", "SAO 250493"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.37585498),
        dec: Angle.Degrees(-64.19798120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198398"},
        {"Hipparcos Number", "HIP 103105"},
        {"Renson", "Renson 55220"},
        {"Smithsonian Astrophysical Observation", "SAO 254891"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.35669775),
        dec: Angle.Degrees(-64.19732097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79966"},
        {"Hipparcos Number", "HIP 45303"},
        {"Geneva Identification System", "GEN# +1.00079966"},
        {"Smithsonian Astrophysical Observation", "SAO 250499"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.50017553),
        dec: Angle.Degrees(-64.19716979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23593"},
        {"Hipparcos Number", "HIP 17329"},
        {"Smithsonian Astrophysical Observation", "SAO 248870"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.64330280),
        dec: Angle.Degrees(-64.19538847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191647"},
        {"Hipparcos Number", "HIP 99794"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.71346935),
        dec: Angle.Degrees(-64.19132147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123207"},
        {"Hipparcos Number", "HIP 69097"},
        {"Geneva Identification System", "GEN# +1.00123207"},
        {"Smithsonian Astrophysical Observation", "SAO 252619"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.16688914),
        dec: Angle.Degrees(-64.19043295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194663"},
        {"Hipparcos Number", "HIP 101182"},
        {"Geneva Identification System", "GEN# +1.00194663"},
        {"Smithsonian Astrophysical Observation", "SAO 254803"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.64052805),
        dec: Angle.Degrees(-64.19019460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28370"},
        {"Hipparcos Number", "HIP 20555"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.05416281),
        dec: Angle.Degrees(-64.18938473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197002"},
        {"Hipparcos Number", "HIP 102354"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.08783743),
        dec: Angle.Degrees(-64.18930159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152322"},
        {"Hipparcos Number", "HIP 82954"},
        {"Geneva Identification System", "GEN# +1.00152322"},
        {"Smithsonian Astrophysical Observation", "SAO 253746"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.27521498),
        dec: Angle.Degrees(-64.18877396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20560"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.06365969),
        dec: Angle.Degrees(-64.18727293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70200"},
        {"Hipparcos Number", "HIP 40556"},
        {"Geneva Identification System", "GEN# +1.00070200"},
        {"Smithsonian Astrophysical Observation", "SAO 250174"},
    },
    visualMagnitude: 6.67,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.22062177),
        dec: Angle.Degrees(-64.18709878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193200"},
        {"Hipparcos Number", "HIP 100494"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.67687311),
        dec: Angle.Degrees(-64.18624917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106909"},
        {"Hipparcos Number", "HIP 59976"},
        {"Geneva Identification System", "GEN# +1.00106909"},
        {"Smithsonian Astrophysical Observation", "SAO 251835"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.50328154),
        dec: Angle.Degrees(-64.18620834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196403"},
        {"Hipparcos Number", "HIP 102039"},
        {"Smithsonian Astrophysical Observation", "SAO 254847"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.18447635),
        dec: Angle.Degrees(-64.18453440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217098"},
        {"Hipparcos Number", "HIP 113520"},
        {"Smithsonian Astrophysical Observation", "SAO 255366"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.86354547),
        dec: Angle.Degrees(-64.18230412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141171"},
        {"Hipparcos Number", "HIP 77675"},
        {"Fundamental Katalog 5th Edition", "FK5 5402"},
        {"Geneva Identification System", "GEN# +1.00141171"},
        {"Smithsonian Astrophysical Observation", "SAO 253315"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.86955271),
        dec: Angle.Degrees(-64.18168074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100100"},
        {"Hipparcos Number", "HIP 56138"},
        {"Smithsonian Astrophysical Observation", "SAO 251429"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.60769403),
        dec: Angle.Degrees(-64.18140892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139471"},
        {"Hipparcos Number", "HIP 76894"},
        {"Smithsonian Astrophysical Observation", "SAO 253259"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.50737597),
        dec: Angle.Degrees(-64.18027855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155325"},
        {"Hipparcos Number", "HIP 84400"},
        {"Renson", "Renson 43890"},
        {"Smithsonian Astrophysical Observation", "SAO 253847"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.82825632),
        dec: Angle.Degrees(-64.17398380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91056"},
        {"Hipparcos Number", "HIP 51313"},
        {"Smithsonian Astrophysical Observation", "SAO 250979"},
        {"Wilson Evans Batten Catalogue", "WEB 9371"},
    },
    visualMagnitude: 5.27,
    bvColour: 1.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.21915426),
        dec: Angle.Degrees(-64.17228466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97583"},
        {"Hipparcos Number", "HIP 54767"},
        {"Fundamental Katalog 5th Edition", "FK5 2893"},
        {"Geneva Identification System", "GEN# +1.00097583A"},
        {"Smithsonian Astrophysical Observation", "SAO 251320"},
        {"Wilson Evans Batten Catalogue", "WEB 9886"},
    },
    visualMagnitude: 5.22,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.18862745),
        dec: Angle.Degrees(-64.16978296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145766"},
        {"Hipparcos Number", "HIP 79751"},
        {"Geneva Identification System", "GEN# +1.00145766"},
        {"Smithsonian Astrophysical Observation", "SAO 253480"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.16174883),
        dec: Angle.Degrees(-64.16440890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144717"},
        {"Hipparcos Number", "HIP 79321"},
        {"Geneva Identification System", "GEN# +1.00144717"},
        {"Smithsonian Astrophysical Observation", "SAO 253450"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.82712556),
        dec: Angle.Degrees(-64.16369975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5232"},
        {"Hipparcos Number", "HIP 4150"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.26151187),
        dec: Angle.Degrees(-64.16361487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119841"},
        {"Hipparcos Number", "HIP 67299"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.88105289),
        dec: Angle.Degrees(-64.16045473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123941"},
        {"Hipparcos Number", "HIP 69430"},
        {"Smithsonian Astrophysical Observation", "SAO 252648"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.22937424),
        dec: Angle.Degrees(-64.16006488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131441"},
        {"Hipparcos Number", "HIP 73127"},
        {"Smithsonian Astrophysical Observation", "SAO 252963"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.18335630),
        dec: Angle.Degrees(-64.15963934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204652"},
        {"Hipparcos Number", "HIP 106389"},
        {"Smithsonian Astrophysical Observation", "SAO 255019"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.21577365),
        dec: Angle.Degrees(-64.14991111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214634"},
        {"Hipparcos Number", "HIP 111998"},
        {"Smithsonian Astrophysical Observation", "SAO 255285"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.28582338),
        dec: Angle.Degrees(-64.14750114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127850"},
        {"Hipparcos Number", "HIP 71437"},
        {"Geneva Identification System", "GEN# +1.00127850"},
        {"Smithsonian Astrophysical Observation", "SAO 252816"},
        {"Wilson Evans Batten Catalogue", "WEB 12326"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.12735259),
        dec: Angle.Degrees(-64.14649791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64530"},
        {"Hipparcos Number", "HIP 38258"},
        {"Smithsonian Astrophysical Observation", "SAO 249979"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.56648089),
        dec: Angle.Degrees(-64.14390391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205982"},
        {"Hipparcos Number", "HIP 107104"},
        {"Geneva Identification System", "GEN# +1.00205982"},
        {"Smithsonian Astrophysical Observation", "SAO 255051"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.41939156),
        dec: Angle.Degrees(-64.14387249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91906"},
        {"Hipparcos Number", "HIP 51794"},
        {"Geneva Identification System", "GEN# +3.26020008"},
        {"Smithsonian Astrophysical Observation", "SAO 251022"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.73539820),
        dec: Angle.Degrees(-64.13402404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184357"},
        {"Hipparcos Number", "HIP 96594"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.54761526),
        dec: Angle.Degrees(-64.13321410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208469"},
        {"Hipparcos Number", "HIP 108493"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.68187350),
        dec: Angle.Degrees(-64.13031308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 307860"},
        {"Hipparcos Number", "HIP 51797"},
        {"Geneva Identification System", "GEN# +3.26020078"},
        {"Smithsonian Astrophysical Observation", "SAO 251023"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.74526385),
        dec: Angle.Degrees(-64.12876148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81784"},
    },
    visualMagnitude: 11.26,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.57203699),
        dec: Angle.Degrees(-64.12869891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136130"},
        {"Hipparcos Number", "HIP 75236"},
        {"Geneva Identification System", "GEN# +1.00136130"},
        {"Smithsonian Astrophysical Observation", "SAO 253127"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.61001938),
        dec: Angle.Degrees(-64.12864989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57375"},
        {"Hipparcos Number", "HIP 35211"},
        {"Geneva Identification System", "GEN# +1.00057375"},
        {"Smithsonian Astrophysical Observation", "SAO 249805"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.15497585),
        dec: Angle.Degrees(-64.12593008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 182.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169863"},
        {"Hipparcos Number", "HIP 90773"},
        {"Smithsonian Astrophysical Observation", "SAO 254270"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.79554583),
        dec: Angle.Degrees(-64.12538829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111905"},
        {"Hipparcos Number", "HIP 62901"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.37790726),
        dec: Angle.Degrees(-64.12287982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29815"},
        {"Hipparcos Number", "HIP 21545"},
        {"Smithsonian Astrophysical Observation", "SAO 249068"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.39004246),
        dec: Angle.Degrees(-64.12244094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201467"},
        {"Hipparcos Number", "HIP 104724"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.22024212),
        dec: Angle.Degrees(-64.12076660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126579"},
        {"Hipparcos Number", "HIP 70821"},
        {"Smithsonian Astrophysical Observation", "SAO 252754"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.24797493),
        dec: Angle.Degrees(-64.11768027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145283"},
        {"Hipparcos Number", "HIP 79573"},
        {"Smithsonian Astrophysical Observation", "SAO 253467"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.53758822),
        dec: Angle.Degrees(-64.11699753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121902"},
        {"Hipparcos Number", "HIP 68427"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.13196597),
        dec: Angle.Degrees(-64.11693596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90564"},
        {"Hipparcos Number", "HIP 51025"},
        {"Geneva Identification System", "GEN# +1.00090564"},
        {"Smithsonian Astrophysical Observation", "SAO 250949"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.36288417),
        dec: Angle.Degrees(-64.11637124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92536"},
        {"Hipparcos Number", "HIP 52160"},
        {"Celescope Catalog", "CEL 3622"},
        {"Geneva Identification System", "GEN# +3.26020022"},
        {"Smithsonian Astrophysical Observation", "SAO 251050"},
    },
    visualMagnitude: 6.33,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.84522693),
        dec: Angle.Degrees(-64.11181305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83855"},
        {"Hipparcos Number", "HIP 47321"},
        {"Smithsonian Astrophysical Observation", "SAO 250648"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.63334318),
        dec: Angle.Degrees(-64.10981639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92837"},
        {"Hipparcos Number", "HIP 52328"},
        {"Celescope Catalog", "CEL 3648"},
        {"Geneva Identification System", "GEN# +3.26020031"},
        {"Smithsonian Astrophysical Observation", "SAO 251070"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.39649374),
        dec: Angle.Degrees(-64.10641631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70982"},
        {"Hipparcos Number", "HIP 40926"},
        {"Geneva Identification System", "GEN# +1.00070982"},
        {"Smithsonian Astrophysical Observation", "SAO 250202"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.28186889),
        dec: Angle.Degrees(-64.10595398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38821",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38821"},
    },
    visualMagnitude: 11.87,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)56, 44.1000),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)06, 16.000)
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
    primaryId: "HIP 38820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38820"},
    },
    visualMagnitude: 11.52,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.17932494),
        dec: Angle.Degrees(-64.10022761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127160"},
        {"Hipparcos Number", "HIP 71124"},
        {"Geneva Identification System", "GEN# +1.00127160"},
        {"Smithsonian Astrophysical Observation", "SAO 252778"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.16290390),
        dec: Angle.Degrees(-64.09674610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122966"},
        {"Hipparcos Number", "HIP 68973"},
        {"Geneva Identification System", "GEN# +1.00122966"},
        {"Smithsonian Astrophysical Observation", "SAO 252601"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.81254981),
        dec: Angle.Degrees(-64.09595952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37107"},
        {"Hipparcos Number", "HIP 25879"},
        {"Geneva Identification System", "GEN# +1.00037107"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.86548550),
        dec: Angle.Degrees(-64.09487194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54844"},
        {"Hipparcos Number", "HIP 34256"},
        {"Smithsonian Astrophysical Observation", "SAO 249736"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.51283902),
        dec: Angle.Degrees(-64.08255235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78569"},
        {"Hipparcos Number", "HIP 44642"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.45006179),
        dec: Angle.Degrees(-64.08202070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28471"},
        {"Hipparcos Number", "HIP 20625"},
        {"Geneva Identification System", "GEN# +1.00028471"},
        {"Smithsonian Astrophysical Observation", "SAO 249019"},
        {"Wilson Evans Batten Catalogue", "WEB 3952"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.28847164),
        dec: Angle.Degrees(-64.08085158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 321.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133479"},
        {"Hipparcos Number", "HIP 74035"},
        {"Smithsonian Astrophysical Observation", "SAO 253023"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.95541337),
        dec: Angle.Degrees(-64.07968221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189010"},
        {"Hipparcos Number", "HIP 98631"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.49176200),
        dec: Angle.Degrees(-64.07650652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35537"},
        {"Hipparcos Number", "HIP 24983"},
        {"Fundamental Katalog 5th Edition", "FK5 4487"},
        {"Geneva Identification System", "GEN# +1.00035537"},
        {"Smithsonian Astrophysical Observation", "SAO 249257"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.24527726),
        dec: Angle.Degrees(-64.07507491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5619"},
        {"Hipparcos Number", "HIP 4441"},
        {"Smithsonian Astrophysical Observation", "SAO 248286"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.19621592),
        dec: Angle.Degrees(-64.07505203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156478"},
        {"Hipparcos Number", "HIP 84989"},
        {"Smithsonian Astrophysical Observation", "SAO 253887"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.56458360),
        dec: Angle.Degrees(-64.07170771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18866"},
        {"Hipparcos Number", "HIP 13884"},
        {"Fundamental Katalog 5th Edition", "FK5 2212"},
        {"Geneva Identification System", "GEN# +1.00018866"},
        {"Renson", "Renson 4730"},
        {"Smithsonian Astrophysical Observation", "SAO 248701"},
        {"Wilson Evans Batten Catalogue", "WEB 2742"},
    },
    visualMagnitude: 4.98,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.69902505),
        dec: Angle.Degrees(-64.07129717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118736"},
        {"Hipparcos Number", "HIP 66721"},
        {"Geneva Identification System", "GEN# +1.00118736"},
        {"Smithsonian Astrophysical Observation", "SAO 252406"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.15692583),
        dec: Angle.Degrees(-64.06958604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87076"},
        {"Smithsonian Astrophysical Observation", "SAO 254030"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.90562762),
        dec: Angle.Degrees(-64.06898238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24558"},
        {"Hipparcos Number", "HIP 17970"},
        {"Geneva Identification System", "GEN# +1.00024558"},
        {"Smithsonian Astrophysical Observation", "SAO 248892"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.63042607),
        dec: Angle.Degrees(-64.06888406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 317.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 155.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202847"},
        {"Hipparcos Number", "HIP 105449"},
        {"Smithsonian Astrophysical Observation", "SAO 254983"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.37483814),
        dec: Angle.Degrees(-64.06863262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4944"},
        {"Hipparcos Number", "HIP 3924"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.60079553),
        dec: Angle.Degrees(-64.06781229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15101"},
        {"Hipparcos Number", "HIP 11129"},
        {"Geneva Identification System", "GEN# +1.00015101"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.80496830),
        dec: Angle.Degrees(-64.06671321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70916"},
        {"Hipparcos Number", "HIP 40894"},
        {"Geneva Identification System", "GEN# +1.00070916"},
        {"Smithsonian Astrophysical Observation", "SAO 250197"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.17777719),
        dec: Angle.Degrees(-64.06610907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 153.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148752"},
        {"Hipparcos Number", "HIP 81148"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.60354790),
        dec: Angle.Degrees(-64.06570733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44662"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.51612393),
        dec: Angle.Degrees(-64.06440698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147172"},
        {"Hipparcos Number", "HIP 80367"},
        {"Smithsonian Astrophysical Observation", "SAO 253534"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.08321242),
        dec: Angle.Degrees(-64.06173269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153645"},
        {"Hipparcos Number", "HIP 83585"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.24920274),
        dec: Angle.Degrees(-64.05813982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147787"},
        {"Henry Draper 2", "HD 147787A"},
        {"Henry Draper 3", "HD 147787B"},
        {"Hipparcos Number", "HIP 80645"},
        {"Geneva Identification System", "GEN# +1.00147787A"},
        {"Smithsonian Astrophysical Observation", "SAO 253555"},
        {"Wilson Evans Batten Catalogue", "WEB 13638"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.98864198),
        dec: Angle.Degrees(-64.05800515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37931"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.59732452),
        dec: Angle.Degrees(-64.05716305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 168.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118385"},
        {"Hipparcos Number", "HIP 66546"},
        {"Geneva Identification System", "GEN# +1.00118385"},
        {"Smithsonian Astrophysical Observation", "SAO 252392"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.61864679),
        dec: Angle.Degrees(-64.05563438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66189"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.49599200),
        dec: Angle.Degrees(-64.05555196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110660"},
        {"Hipparcos Number", "HIP 62169"},
        {"Geneva Identification System", "GEN# +1.00110660"},
        {"Wilson Evans Batten Catalogue", "WEB 11046"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.10636321),
        dec: Angle.Degrees(-64.05527112)
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
    primaryId: "HIP 81689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149785"},
        {"Hipparcos Number", "HIP 81689"},
        {"Smithsonian Astrophysical Observation", "SAO 253652"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.30597681),
        dec: Angle.Degrees(-64.05417569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115863"},
        {"Hipparcos Number", "HIP 65176"},
        {"Smithsonian Astrophysical Observation", "SAO 252277"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.34800142),
        dec: Angle.Degrees(-64.04963879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200115"},
        {"Hipparcos Number", "HIP 104037"},
        {"Smithsonian Astrophysical Observation", "SAO 254930"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.16423000),
        dec: Angle.Degrees(-64.04757288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88170"},
        {"Smithsonian Astrophysical Observation", "SAO 254101"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.11103084),
        dec: Angle.Degrees(-64.04707212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68901"},
        {"Hipparcos Number", "HIP 40031"},
        {"Smithsonian Astrophysical Observation", "SAO 250140"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.65081888),
        dec: Angle.Degrees(-64.04681023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15936"},
        {"Hipparcos Number", "HIP 11697"},
        {"Smithsonian Astrophysical Observation", "SAO 248583"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.71970662),
        dec: Angle.Degrees(-64.04569241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103558"},
        {"Hipparcos Number", "HIP 58126"},
        {"Geneva Identification System", "GEN# +1.00103558"},
        {"Smithsonian Astrophysical Observation", "SAO 251642"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.83567384),
        dec: Angle.Degrees(-64.04561663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140136"},
        {"Hipparcos Number", "HIP 77198"},
        {"Smithsonian Astrophysical Observation", "SAO 253282"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.44730791),
        dec: Angle.Degrees(-64.04508110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98363"},
        {"Hipparcos Number", "HIP 55188"},
        {"Smithsonian Astrophysical Observation", "SAO 251348"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.49239629),
        dec: Angle.Degrees(-64.04259598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195085"},
        {"Hipparcos Number", "HIP 101376"},
        {"Renson", "Renson 54380"},
        {"Smithsonian Astrophysical Observation", "SAO 254812"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.20101273),
        dec: Angle.Degrees(-64.04137216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172782"},
        {"Hipparcos Number", "HIP 92121"},
        {"Geneva Identification System", "GEN# +1.00172782"},
        {"Smithsonian Astrophysical Observation", "SAO 254363"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.63033310),
        dec: Angle.Degrees(-64.04132298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222151"},
        {"Hipparcos Number", "HIP 116672"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.66566049),
        dec: Angle.Degrees(-64.03641025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196460"},
        {"Hipparcos Number", "HIP 102068"},
        {"Smithsonian Astrophysical Observation", "SAO 254849"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.27065187),
        dec: Angle.Degrees(-64.03555048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78964"},
        {"Hipparcos Number", "HIP 44814"},
        {"Geneva Identification System", "GEN# +1.00078964"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.99268776),
        dec: Angle.Degrees(-64.03528643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78977"},
        {"Hipparcos Number", "HIP 44817"},
        {"Geneva Identification System", "GEN# +1.00078977"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.99882840),
        dec: Angle.Degrees(-64.03408689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39963"},
        {"Henry Draper 2", "HD 39964"},
        {"Hipparcos Number", "HIP 27660"},
        {"Geneva Identification System", "GEN# +1.00039963"},
        {"Smithsonian Astrophysical Observation", "SAO 249376"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.84625475),
        dec: Angle.Degrees(-64.03360643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132905"},
        {"Hipparcos Number", "HIP 73776"},
        {"Geneva Identification System", "GEN# +1.00132905"},
        {"Smithsonian Astrophysical Observation", "SAO 253005"},
        {"Wilson Evans Batten Catalogue", "WEB 12609"},
    },
    visualMagnitude: 5.16,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.20020549),
        dec: Angle.Degrees(-64.03137307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83297"},
        {"Hipparcos Number", "HIP 46985"},
        {"Smithsonian Astrophysical Observation", "SAO 250627"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.64566463),
        dec: Angle.Degrees(-64.03085196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44577"},
        {"Hipparcos Number", "HIP 29907"},
        {"Celescope Catalog", "CEL 1182"},
        {"Geneva Identification System", "GEN# +1.00044577"},
        {"Smithsonian Astrophysical Observation", "SAO 249502"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.45745818),
        dec: Angle.Degrees(-64.03025515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51160"},
        {"Hipparcos Number", "HIP 32941"},
        {"Smithsonian Astrophysical Observation", "SAO 249665"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.93047937),
        dec: Angle.Degrees(-64.03012958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201020"},
        {"Hipparcos Number", "HIP 104501"},
        {"Fundamental Katalog 5th Edition", "FK5 3691"},
        {"Renson", "Renson 56050"},
        {"Smithsonian Astrophysical Observation", "SAO 254948"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.53101088),
        dec: Angle.Degrees(-64.02531782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60644",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tupa"},
        {"Henry Draper", "HD 108147"},
        {"Hipparcos Number", "HIP 60644"},
        {"Geneva Identification System", "GEN# +1.00108147"},
        {"Smithsonian Astrophysical Observation", "SAO 251899"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.44379342),
        dec: Angle.Degrees(-64.02194007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13216"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.52959353),
        dec: Angle.Degrees(-64.01938943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127785"},
        {"Hipparcos Number", "HIP 71400"},
        {"Geneva Identification System", "GEN# +1.00127785"},
        {"Smithsonian Astrophysical Observation", "SAO 252813"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.01310283),
        dec: Angle.Degrees(-64.01546271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210274"},
        {"Hipparcos Number", "HIP 109547"},
        {"Smithsonian Astrophysical Observation", "SAO 255165"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.84895144),
        dec: Angle.Degrees(-64.01434357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18676"},
        {"Hipparcos Number", "HIP 13737"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.22053810),
        dec: Angle.Degrees(-64.01323036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113860"},
        {"Hipparcos Number", "HIP 64063"},
        {"Geneva Identification System", "GEN# +1.00113860"},
        {"Smithsonian Astrophysical Observation", "SAO 252161"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.93418608),
        dec: Angle.Degrees(-64.01179355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129738"},
        {"Hipparcos Number", "HIP 72305"},
        {"Geneva Identification System", "GEN# +1.00129738"},
        {"Renson", "Renson 36990"},
        {"Smithsonian Astrophysical Observation", "SAO 252881"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.78892067),
        dec: Angle.Degrees(-64.01050215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2227"},
        {"Hipparcos Number", "HIP 2019"},
        {"Geneva Identification System", "GEN# +1.00002227"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.40842775),
        dec: Angle.Degrees(-64.00946608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55024"},
        {"Hipparcos Number", "HIP 34319"},
        {"Smithsonian Astrophysical Observation", "SAO 249741"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.72181893),
        dec: Angle.Degrees(-64.00417932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106983"},
        {"Hipparcos Number", "HIP 60009"},
        {"Celescope Catalog", "CEL 4089"},
        {"Geneva Identification System", "GEN# +1.00106983A"},
        {"Smithsonian Astrophysical Observation", "SAO 251841"},
        {"Wilson Evans Batten Catalogue", "WEB 10664"},
    },
    visualMagnitude: 4.06,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.60955300),
        dec: Angle.Degrees(-64.00304555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18448"},
        {"Hipparcos Number", "HIP 13568"},
        {"Geneva Identification System", "GEN# +1.00018448"},
        {"Smithsonian Astrophysical Observation", "SAO 248682"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.69756321),
        dec: Angle.Degrees(-64.00238398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175147"},
        {"Hipparcos Number", "HIP 93151"},
        {"Smithsonian Astrophysical Observation", "SAO 254422"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.61811243),
        dec: Angle.Degrees(-64.00130917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153954"},
        {"Hipparcos Number", "HIP 83746"},
        {"Smithsonian Astrophysical Observation", "SAO 253796"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.73984922),
        dec: Angle.Degrees(-63.99095402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165776"},
        {"Hipparcos Number", "HIP 89200"},
        {"Smithsonian Astrophysical Observation", "SAO 254167"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.05638258),
        dec: Angle.Degrees(-63.98681648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60472"},
        {"Geneva Identification System", "GEN# +6.90226015"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.96488027),
        dec: Angle.Degrees(-63.98631903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107838"},
        {"Hipparcos Number", "HIP 60469"},
        {"Geneva Identification System", "GEN# +1.00107838"},
        {"Renson", "Renson 31260"},
        {"Smithsonian Astrophysical Observation", "SAO 251881"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.95105938),
        dec: Angle.Degrees(-63.98602575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123996"},
        {"Hipparcos Number", "HIP 69450"},
        {"Smithsonian Astrophysical Observation", "SAO 252650"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.29461101),
        dec: Angle.Degrees(-63.98598087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118551"},
        {"Hipparcos Number", "HIP 66631"},
        {"Geneva Identification System", "GEN# +1.00118551"},
        {"Renson", "Renson 34262"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.86618764),
        dec: Angle.Degrees(-63.98566657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6294"},
        {"Hipparcos Number", "HIP 4880"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.67911751),
        dec: Angle.Degrees(-63.98449550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187788"},
        {"Hipparcos Number", "HIP 98065"},
        {"Smithsonian Astrophysical Observation", "SAO 254685"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.95783920),
        dec: Angle.Degrees(-63.98402509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85330"},
        {"Hipparcos Number", "HIP 48100"},
        {"Smithsonian Astrophysical Observation", "SAO 250704"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.10910239),
        dec: Angle.Degrees(-63.98378740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82902"},
        {"Hipparcos Number", "HIP 46784"},
        {"Smithsonian Astrophysical Observation", "SAO 250613"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.01018847),
        dec: Angle.Degrees(-63.98359565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106603"},
        {"Hipparcos Number", "HIP 59809"},
        {"Geneva Identification System", "GEN# +1.00106603"},
        {"Renson", "Renson 30840"},
        {"Smithsonian Astrophysical Observation", "SAO 251817"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.97976031),
        dec: Angle.Degrees(-63.98099162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222781"},
        {"Hipparcos Number", "HIP 117067"},
        {"Smithsonian Astrophysical Observation", "SAO 255556"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.99177226),
        dec: Angle.Degrees(-63.97926713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217688"},
        {"Hipparcos Number", "HIP 113867"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.89580361),
        dec: Angle.Degrees(-63.97814055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80254"},
        {"Hipparcos Number", "HIP 45446"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.92124121),
        dec: Angle.Degrees(-63.97481914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115115"},
        {"Hipparcos Number", "HIP 64770"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.10957707),
        dec: Angle.Degrees(-63.97375943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94684"},
        {"Hipparcos Number", "HIP 53330"},
        {"Smithsonian Astrophysical Observation", "SAO 251174"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.61798387),
        dec: Angle.Degrees(-63.97269518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99453"},
        {"Hipparcos Number", "HIP 55779"},
        {"Geneva Identification System", "GEN# +1.00099453"},
        {"Smithsonian Astrophysical Observation", "SAO 251402"},
        {"Wilson Evans Batten Catalogue", "WEB 10028"},
    },
    visualMagnitude: 5.18,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.43151730),
        dec: Angle.Degrees(-63.97231572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -314.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187114"},
        {"Hipparcos Number", "HIP 97799"},
        {"Smithsonian Astrophysical Observation", "SAO 254672"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.09678612),
        dec: Angle.Degrees(-63.97094775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53332"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.62095539),
        dec: Angle.Degrees(-63.96917648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199773"},
        {"Hipparcos Number", "HIP 103842"},
        {"Smithsonian Astrophysical Observation", "SAO 254922"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.62589319),
        dec: Angle.Degrees(-63.96379600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34365"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.85052454),
        dec: Angle.Degrees(-63.96362788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 305.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21989"},
        {"Hipparcos Number", "HIP 16222"},
        {"Geneva Identification System", "GEN# +1.00021989"},
        {"Smithsonian Astrophysical Observation", "SAO 248818"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.24417899),
        dec: Angle.Degrees(-63.96172068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8788"},
        {"Hipparcos Number", "HIP 6622"},
        {"Smithsonian Astrophysical Observation", "SAO 248379"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.24899390),
        dec: Angle.Degrees(-63.96116055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93194"},
        {"Hipparcos Number", "HIP 52502"},
        {"Celescope Catalog", "CEL 3678"},
        {"Geneva Identification System", "GEN# +3.26020041"},
        {"Smithsonian Astrophysical Observation", "SAO 251096"},
        {"Wilson Evans Batten Catalogue", "WEB 9563"},
    },
    visualMagnitude: 4.80,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.02890478),
        dec: Angle.Degrees(-63.96110070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222743"},
        {"Hipparcos Number", "HIP 117048"},
        {"Geneva Identification System", "GEN# +1.00222743"},
        {"Smithsonian Astrophysical Observation", "SAO 255552"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.91492092),
        dec: Angle.Degrees(-63.96075529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4317"},
        {"Hipparcos Number", "HIP 3508"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.19587721),
        dec: Angle.Degrees(-63.96042400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162075"},
        {"Hipparcos Number", "HIP 87600"},
        {"Smithsonian Astrophysical Observation", "SAO 254064"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.41570745),
        dec: Angle.Degrees(-63.95972727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31930"},
        {"Hipparcos Number", "HIP 22870"},
        {"Geneva Identification System", "GEN# +1.00031930"},
        {"Smithsonian Astrophysical Observation", "SAO 249146"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.79387977),
        dec: Angle.Degrees(-63.95898855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5562"},
        {"Hipparcos Number", "HIP 4395"},
        {"Geneva Identification System", "GEN# +1.00005562"},
        {"Smithsonian Astrophysical Observation", "SAO 248283"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.08678605),
        dec: Angle.Degrees(-63.95878686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 316.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 165.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135553"},
        {"Hipparcos Number", "HIP 74963"},
        {"Geneva Identification System", "GEN# +1.00135553"},
        {"Smithsonian Astrophysical Observation", "SAO 253103"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.78263349),
        dec: Angle.Degrees(-63.95875261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100666"},
        {"Hipparcos Number", "HIP 56457"},
        {"Geneva Identification System", "GEN# +1.00100666"},
        {"Renson", "Renson 28940"},
        {"Smithsonian Astrophysical Observation", "SAO 251462"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.63772502),
        dec: Angle.Degrees(-63.95531750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215131"},
        {"Hipparcos Number", "HIP 112281"},
        {"Smithsonian Astrophysical Observation", "SAO 255300"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.14137719),
        dec: Angle.Degrees(-63.95389461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186811"},
        {"Hipparcos Number", "HIP 97643"},
        {"Geneva Identification System", "GEN# +1.00186811"},
        {"Smithsonian Astrophysical Observation", "SAO 254668"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.67661111),
        dec: Angle.Degrees(-63.95248176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124967"},
        {"Hipparcos Number", "HIP 69960"},
        {"Smithsonian Astrophysical Observation", "SAO 252699"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.74040941),
        dec: Angle.Degrees(-63.94900876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62092"},
        {"Hipparcos Number", "HIP 37152"},
        {"Smithsonian Astrophysical Observation", "SAO 249903"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.52341386),
        dec: Angle.Degrees(-63.94626583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146380"},
        {"Hipparcos Number", "HIP 80023"},
        {"Smithsonian Astrophysical Observation", "SAO 253506"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.01970927),
        dec: Angle.Degrees(-63.94057527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190983"},
        {"Hipparcos Number", "HIP 99480"},
        {"Geneva Identification System", "GEN# +1.00190983"},
        {"Smithsonian Astrophysical Observation", "SAO 254741"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.84495454),
        dec: Angle.Degrees(-63.94049856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91452"},
        {"Hipparcos Number", "HIP 51554"},
        {"Geneva Identification System", "GEN# +1.00091452"},
        {"Smithsonian Astrophysical Observation", "SAO 251005"},
        {"Wilson Evans Batten Catalogue", "WEB 9405"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.96085729),
        dec: Angle.Degrees(-63.94047089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45079"},
        {"Hipparcos Number", "HIP 30157"},
        {"Smithsonian Astrophysical Observation", "SAO 249518"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.18908397),
        dec: Angle.Degrees(-63.93067013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173544"},
        {"Hipparcos Number", "HIP 92438"},
        {"Geneva Identification System", "GEN# +1.00173544"},
        {"Smithsonian Astrophysical Observation", "SAO 254382"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.57728336),
        dec: Angle.Degrees(-63.93023546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43493"},
        {"Hipparcos Number", "HIP 29411"},
        {"Smithsonian Astrophysical Observation", "SAO 249471"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.95660994),
        dec: Angle.Degrees(-63.92936739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129883"},
        {"Hipparcos Number", "HIP 72379"},
        {"Smithsonian Astrophysical Observation", "SAO 252889"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.99063211),
        dec: Angle.Degrees(-63.92839215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200751"},
        {"Hipparcos Number", "HIP 104364"},
        {"Geneva Identification System", "GEN# +1.00200751"},
        {"Smithsonian Astrophysical Observation", "SAO 254941"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.13627084),
        dec: Angle.Degrees(-63.92827112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26318"},
        {"Hipparcos Number", "HIP 19096"},
        {"Smithsonian Astrophysical Observation", "SAO 248941"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.41278150),
        dec: Angle.Degrees(-63.92798143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36876"},
        {"Hipparcos Number", "HIP 25781"},
        {"Geneva Identification System", "GEN# +1.00036876"},
        {"Smithsonian Astrophysical Observation", "SAO 249297"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.56610896),
        dec: Angle.Degrees(-63.92782972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132322"},
        {"Hipparcos Number", "HIP 73520"},
        {"Geneva Identification System", "GEN# +1.00132322"},
        {"Renson", "Renson 37580"},
        {"Smithsonian Astrophysical Observation", "SAO 252993"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.39976012),
        dec: Angle.Degrees(-63.92692797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77170"},
        {"Hipparcos Number", "HIP 44003"},
        {"Geneva Identification System", "GEN# +1.00077170"},
        {"Smithsonian Astrophysical Observation", "SAO 250399"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.39856088),
        dec: Angle.Degrees(-63.92540527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206911"},
        {"Hipparcos Number", "HIP 107614"},
        {"Geneva Identification System", "GEN# +1.00206911"},
        {"Smithsonian Astrophysical Observation", "SAO 255073"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.94634586),
        dec: Angle.Degrees(-63.92407511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82348"},
        {"Hipparcos Number", "HIP 46459"},
        {"Smithsonian Astrophysical Observation", "SAO 250589"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.12574071),
        dec: Angle.Degrees(-63.92370526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129614"},
        {"Hipparcos Number", "HIP 72232"},
        {"Smithsonian Astrophysical Observation", "SAO 252876"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.58120654),
        dec: Angle.Degrees(-63.92176731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47478"},
        {"Hipparcos Number", "HIP 31335"},
        {"Smithsonian Astrophysical Observation", "SAO 249587"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.56018527),
        dec: Angle.Degrees(-63.91813380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184356"},
        {"Hipparcos Number", "HIP 96590"},
        {"Fundamental Katalog 5th Edition", "FK5 5727"},
        {"Smithsonian Astrophysical Observation", "SAO 254609"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.54452290),
        dec: Angle.Degrees(-63.91545917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20060"},
        {"Hipparcos Number", "HIP 14709"},
        {"Geneva Identification System", "GEN# +1.00020060J"},
        {"Smithsonian Astrophysical Observation", "SAO 248748"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.51360075),
        dec: Angle.Degrees(-63.91363390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142587"},
        {"Hipparcos Number", "HIP 78292"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.79984798),
        dec: Angle.Degrees(-63.91321713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27670"},
        {"Hipparcos Number", "HIP 20034"},
        {"Smithsonian Astrophysical Observation", "SAO 248987"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.45692845),
        dec: Angle.Degrees(-63.90972930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130846"},
        {"Hipparcos Number", "HIP 72851"},
        {"Smithsonian Astrophysical Observation", "SAO 252937"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.35541322),
        dec: Angle.Degrees(-63.90928309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98625"},
        {"Hipparcos Number", "HIP 55340"},
        {"Geneva Identification System", "GEN# +1.00098625"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.99123327),
        dec: Angle.Degrees(-63.90915940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3063"},
        {"Hipparcos Number", "HIP 2614"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.29871645),
        dec: Angle.Degrees(-63.90826167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20031"},
        {"Geneva Identification System", "GEN# +6.00003350"},
    },
    visualMagnitude: 11.44,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.44053565),
        dec: Angle.Degrees(-63.90510257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179065"},
        {"Hipparcos Number", "HIP 94626"},
        {"Smithsonian Astrophysical Observation", "SAO 254507"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.83891725),
        dec: Angle.Degrees(-63.90347915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83504"},
        {"Hipparcos Number", "HIP 47120"},
        {"Geneva Identification System", "GEN# +1.00083504"},
        {"Smithsonian Astrophysical Observation", "SAO 250635"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.03150075),
        dec: Angle.Degrees(-63.90206438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124299"},
        {"Hipparcos Number", "HIP 69638"},
        {"Geneva Identification System", "GEN# +1.00124299"},
        {"Smithsonian Astrophysical Observation", "SAO 252666"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.78745207),
        dec: Angle.Degrees(-63.90016806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88980"},
        {"Hipparcos Number", "HIP 50102"},
        {"Geneva Identification System", "GEN# +1.00088980"},
        {"Smithsonian Astrophysical Observation", "SAO 250881"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.44155122),
        dec: Angle.Degrees(-63.89994979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58575"},
        {"Hipparcos Number", "HIP 35694"},
        {"Smithsonian Astrophysical Observation", "SAO 249834"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.46942396),
        dec: Angle.Degrees(-63.89942692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5712"},
        {"Hipparcos Number", "HIP 4499"},
        {"Smithsonian Astrophysical Observation", "SAO 248289"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.41258328),
        dec: Angle.Degrees(-63.89234066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121209"},
        {"Hipparcos Number", "HIP 68056"},
        {"Smithsonian Astrophysical Observation", "SAO 252525"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.02271426),
        dec: Angle.Degrees(-63.89162573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193531"},
        {"Hipparcos Number", "HIP 100629"},
        {"Smithsonian Astrophysical Observation", "SAO 254785"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.06627691),
        dec: Angle.Degrees(-63.89019174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120417"},
        {"Hipparcos Number", "HIP 67611"},
        {"Smithsonian Astrophysical Observation", "SAO 252478"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.80962578),
        dec: Angle.Degrees(-63.88999475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209929"},
        {"Hipparcos Number", "HIP 109328"},
        {"Smithsonian Astrophysical Observation", "SAO 255154"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.23695961),
        dec: Angle.Degrees(-63.88907428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23399"},
        {"Hipparcos Number", "HIP 17202"},
        {"Smithsonian Astrophysical Observation", "SAO 248865"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.27718639),
        dec: Angle.Degrees(-63.88709710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218914"},
        {"Hipparcos Number", "HIP 114580"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.17778103),
        dec: Angle.Degrees(-63.88691085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84556"},
        {"Hipparcos Number", "HIP 47699"},
        {"Smithsonian Astrophysical Observation", "SAO 250678"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.87845165),
        dec: Angle.Degrees(-63.88605695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167425"},
        {"Henry Draper 2", "HD 167425A"},
        {"Hipparcos Number", "HIP 89805"},
        {"Geneva Identification System", "GEN# +1.00167425"},
        {"Smithsonian Astrophysical Observation", "SAO 254209"},
        {"Wilson Evans Batten Catalogue", "WEB 15322"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.91699348),
        dec: Angle.Degrees(-63.88589103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -276.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115034"},
        {"Hipparcos Number", "HIP 64716"},
        {"Geneva Identification System", "GEN# +1.00115034"},
        {"Smithsonian Astrophysical Observation", "SAO 252231"},
        {"Wilson Evans Batten Catalogue", "WEB 11442"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.96384634),
        dec: Angle.Degrees(-63.88424892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82907"},
        {"Smithsonian Astrophysical Observation", "SAO 253743"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.13702491),
        dec: Angle.Degrees(-63.88375702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117705"},
        {"Hipparcos Number", "HIP 66164"},
        {"Geneva Identification System", "GEN# +1.00117705"},
        {"Smithsonian Astrophysical Observation", "SAO 252367"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.43979397),
        dec: Angle.Degrees(-63.88334870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93777"},
        {"Hipparcos Number", "HIP 52830"},
        {"Geneva Identification System", "GEN# +3.26020055"},
        {"Smithsonian Astrophysical Observation", "SAO 251130"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.02951562),
        dec: Angle.Degrees(-63.88007794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178534"},
        {"Hipparcos Number", "HIP 94432"},
        {"Geneva Identification System", "GEN# +1.00178534"},
        {"Smithsonian Astrophysical Observation", "SAO 254493"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.30364199),
        dec: Angle.Degrees(-63.87702820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117024"},
        {"Hipparcos Number", "HIP 65777"},
        {"Geneva Identification System", "GEN# +1.00117024"},
        {"Smithsonian Astrophysical Observation", "SAO 252328"},
        {"Wilson Evans Batten Catalogue", "WEB 11639"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.27259559),
        dec: Angle.Degrees(-63.87402592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218379"},
        {"Hipparcos Number", "HIP 114269"},
        {"Smithsonian Astrophysical Observation", "SAO 255411"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.15162472),
        dec: Angle.Degrees(-63.87111045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120741"},
        {"Hipparcos Number", "HIP 67788"},
        {"Smithsonian Astrophysical Observation", "SAO 252499"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.30807292),
        dec: Angle.Degrees(-63.87072351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107821"},
        {"Hipparcos Number", "HIP 60459"},
        {"Geneva Identification System", "GEN# +1.00107821"},
        {"Smithsonian Astrophysical Observation", "SAO 251879"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.92600078),
        dec: Angle.Degrees(-63.87005201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203530"},
        {"Hipparcos Number", "HIP 105803"},
        {"Smithsonian Astrophysical Observation", "SAO 254998"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.41085273),
        dec: Angle.Degrees(-63.86978512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19242"},
        {"Hipparcos Number", "HIP 14156"},
        {"Smithsonian Astrophysical Observation", "SAO 248712"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.62443377),
        dec: Angle.Degrees(-63.86892819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9678"},
        {"Hipparcos Number", "HIP 7225"},
        {"Smithsonian Astrophysical Observation", "SAO 248400"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.27659175),
        dec: Angle.Degrees(-63.86841324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180528"},
        {"Hipparcos Number", "HIP 95123"},
        {"Geneva Identification System", "GEN# +1.00180528"},
        {"Smithsonian Astrophysical Observation", "SAO 254539"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.26639459),
        dec: Angle.Degrees(-63.86563206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155243"},
        {"Hipparcos Number", "HIP 84349"},
        {"Fundamental Katalog 5th Edition", "FK5 5522"},
        {"Smithsonian Astrophysical Observation", "SAO 253845"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.67571149),
        dec: Angle.Degrees(-63.86540219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191488"},
        {"Hipparcos Number", "HIP 99709"},
        {"Smithsonian Astrophysical Observation", "SAO 254754"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.49692651),
        dec: Angle.Degrees(-63.86524899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220282"},
        {"Hipparcos Number", "HIP 115458"},
        {"Smithsonian Astrophysical Observation", "SAO 255477"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.82591734),
        dec: Angle.Degrees(-63.86487264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80059"},
        {"Hipparcos Number", "HIP 45353"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.63714161),
        dec: Angle.Degrees(-63.86405423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44880"},
        {"Hipparcos Number", "HIP 30064"},
        {"Smithsonian Astrophysical Observation", "SAO 249509"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.91030610),
        dec: Angle.Degrees(-63.82369106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119888"},
        {"Hipparcos Number", "HIP 67324"},
        {"Smithsonian Astrophysical Observation", "SAO 252453"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.98682482),
        dec: Angle.Degrees(-63.86214674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167301"},
        {"Hipparcos Number", "HIP 89758"},
        {"Smithsonian Astrophysical Observation", "SAO 254204"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.75533350),
        dec: Angle.Degrees(-63.85357340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137801"},
        {"Hipparcos Number", "HIP 76018"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.89972503),
        dec: Angle.Degrees(-63.85185557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157875"},
        {"Hipparcos Number", "HIP 85659"},
        {"Smithsonian Astrophysical Observation", "SAO 253942"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.58216006),
        dec: Angle.Degrees(-63.85177128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150960"},
        {"Hipparcos Number", "HIP 82270"},
        {"Smithsonian Astrophysical Observation", "SAO 253702"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.15083653),
        dec: Angle.Degrees(-63.84937280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73156"},
        {"Hipparcos Number", "HIP 41969"},
        {"Smithsonian Astrophysical Observation", "SAO 250267"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.32886915),
        dec: Angle.Degrees(-63.84450513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148587"},
        {"Hipparcos Number", "HIP 81041"},
        {"Cincinnati Publication", "Ci 20 996"},
        {"Geneva Identification System", "GEN# +1.00148587"},
        {"Smithsonian Astrophysical Observation", "SAO 253594"},
        {"Wilson Evans Batten Catalogue", "WEB 13706"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.27579606),
        dec: Angle.Degrees(-63.84179085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -450.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139212"},
        {"Hipparcos Number", "HIP 76770"},
        {"Smithsonian Astrophysical Observation", "SAO 253248"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.11924985),
        dec: Angle.Degrees(-63.83805657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154112"},
        {"Hipparcos Number", "HIP 83817"},
        {"Smithsonian Astrophysical Observation", "SAO 253804"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.94742443),
        dec: Angle.Degrees(-63.83659547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87896"},
        {"Hipparcos Number", "HIP 49462"},
        {"Geneva Identification System", "GEN# +1.00087896"},
        {"Smithsonian Astrophysical Observation", "SAO 250811"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.47049780),
        dec: Angle.Degrees(-63.83508256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25472"},
        {"Hipparcos Number", "HIP 18598"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.69069503),
        dec: Angle.Degrees(-63.83493929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93874"},
        {"Hipparcos Number", "HIP 52867"},
        {"Geneva Identification System", "GEN# +3.26020058"},
        {"Smithsonian Astrophysical Observation", "SAO 251135"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.17491745),
        dec: Angle.Degrees(-63.83303758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204289"},
        {"Hipparcos Number", "HIP 106179"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.59374623),
        dec: Angle.Degrees(-63.83181480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101684"},
        {"Hipparcos Number", "HIP 57033"},
        {"Geneva Identification System", "GEN# +1.00101684"},
        {"Smithsonian Astrophysical Observation", "SAO 251542"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.40840257),
        dec: Angle.Degrees(-63.82938188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45796"},
        {"Hipparcos Number", "HIP 30524"},
        {"Celescope Catalog", "CEL 1243"},
        {"Geneva Identification System", "GEN# +1.00045796"},
        {"Smithsonian Astrophysical Observation", "SAO 249542"},
        {"Wilson Evans Batten Catalogue", "WEB 6082"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.23252208),
        dec: Angle.Degrees(-63.82817363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157537"},
        {"Hipparcos Number", "HIP 85493"},
        {"Smithsonian Astrophysical Observation", "SAO 253930"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.07601669),
        dec: Angle.Degrees(-63.82434511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88718"},
        {"Hipparcos Number", "HIP 49941"},
        {"Smithsonian Astrophysical Observation", "SAO 250864"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.95096115),
        dec: Angle.Degrees(-63.82275916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105563"},
        {"Hipparcos Number", "HIP 59265"},
        {"Celescope Catalog", "CEL 4060"},
        {"Smithsonian Astrophysical Observation", "SAO 251765"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.34674755),
        dec: Angle.Degrees(-63.82032179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3495"},
        {"Hipparcos Number", "HIP 2933"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.30556582),
        dec: Angle.Degrees(-63.82022629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128812"},
        {"Hipparcos Number", "HIP 71852"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.46293611),
        dec: Angle.Degrees(-63.81926394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100099"},
        {"Hipparcos Number", "HIP 56134"},
        {"Celescope Catalog", "CEL 3908"},
        {"Geneva Identification System", "GEN# +3.29440138"},
        {"Smithsonian Astrophysical Observation", "SAO 251428"},
        {"Wilson Evans Batten Catalogue", "WEB 10078"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.60131784),
        dec: Angle.Degrees(-63.81722958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116816"},
        {"Hipparcos Number", "HIP 65647"},
        {"Geneva Identification System", "GEN# +1.00116816"},
        {"Smithsonian Astrophysical Observation", "SAO 252313"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.88209496),
        dec: Angle.Degrees(-63.81720714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214018"},
        {"Hipparcos Number", "HIP 111653"},
        {"Smithsonian Astrophysical Observation", "SAO 255264"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.28112708),
        dec: Angle.Degrees(-63.81624495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120784"},
        {"Hipparcos Number", "HIP 67821"},
        {"Smithsonian Astrophysical Observation", "SAO 252502"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.38910970),
        dec: Angle.Degrees(-63.81427565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75541"},
        {"Hipparcos Number", "HIP 43135"},
        {"Celescope Catalog", "CEL 2929"},
        {"Smithsonian Astrophysical Observation", "SAO 250328"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.79296482),
        dec: Angle.Degrees(-63.81263242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124832"},
        {"Hipparcos Number", "HIP 69887"},
        {"Smithsonian Astrophysical Observation", "SAO 252690"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.53870702),
        dec: Angle.Degrees(-63.81175587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55699"},
        {"Hipparcos Number", "HIP 34577"},
        {"Smithsonian Astrophysical Observation", "SAO 249757"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.41877356),
        dec: Angle.Degrees(-63.81061808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130701"},
        {"Henry Draper 2", "HD 130702"},
        {"Hipparcos Number", "HIP 72773"},
        {"Geneva Identification System", "GEN# +1.00130701"},
        {"Smithsonian Astrophysical Observation", "SAO 252928"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.14695946),
        dec: Angle.Degrees(-63.80981741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99437"},
        {"Hipparcos Number", "HIP 55780"},
        {"Geneva Identification System", "GEN# +1.00099437"},
        {"Smithsonian Astrophysical Observation", "SAO 251401"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.43779587),
        dec: Angle.Degrees(-63.80895055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68423"},
        {"Hipparcos Number", "HIP 39843"},
        {"Geneva Identification System", "GEN# +1.00068423"},
        {"Smithsonian Astrophysical Observation", "SAO 250127"},
        {"Wilson Evans Batten Catalogue", "WEB 7768"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.10271092),
        dec: Angle.Degrees(-63.80083385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14090"},
        {"Hipparcos Number", "HIP 10417"},
        {"Geneva Identification System", "GEN# +1.00014090"},
        {"Smithsonian Astrophysical Observation", "SAO 248515"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.55684931),
        dec: Angle.Degrees(-63.79572677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101724"},
        {"Hipparcos Number", "HIP 57067"},
        {"Celescope Catalog", "CEL 3954"},
        {"Geneva Identification System", "GEN# +1.00101724"},
        {"Renson", "Renson 29330"},
        {"Smithsonian Astrophysical Observation", "SAO 251545"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.47942696),
        dec: Angle.Degrees(-63.79537629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188413"},
        {"Hipparcos Number", "HIP 98359"},
        {"Geneva Identification System", "GEN# +1.00188413"},
        {"Smithsonian Astrophysical Observation", "SAO 254699"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.75261193),
        dec: Angle.Degrees(-63.79444499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108355"},
        {"Hipparcos Number", "HIP 60771"},
        {"Geneva Identification System", "GEN# +1.00108355"},
        {"Smithsonian Astrophysical Observation", "SAO 251911"},
        {"Wilson Evans Batten Catalogue", "WEB 10811"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.85352338),
        dec: Angle.Degrees(-63.78895978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102776"},
        {"Hipparcos Number", "HIP 57669"},
        {"Celescope Catalog", "CEL 3988"},
        {"Fundamental Katalog 5th Edition", "FK5 2944"},
        {"Geneva Identification System", "GEN# +1.00102776"},
        {"Smithsonian Astrophysical Observation", "SAO 251602"},
        {"Wilson Evans Batten Catalogue", "WEB 10358"},
    },
    visualMagnitude: 4.30,
    bvColour: -0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.42120019),
        dec: Angle.Degrees(-63.78848906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176340"},
        {"Hipparcos Number", "HIP 93637"},
        {"Smithsonian Astrophysical Observation", "SAO 254453"},
    },
    visualMagnitude: 6.96,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.02542939),
        dec: Angle.Degrees(-63.78466109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24618"},
        {"Hipparcos Number", "HIP 18006"},
        {"Smithsonian Astrophysical Observation", "SAO 248896"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.74359481),
        dec: Angle.Degrees(-63.78341286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
