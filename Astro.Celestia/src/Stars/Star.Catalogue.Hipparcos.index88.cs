using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_88() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27675"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.88121021),
        dec: Angle.Degrees(+30.62768046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52645"},
        {"Smithsonian Astrophysical Observation", "SAO 62237"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.47354200),
        dec: Angle.Degrees(+30.62804731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59947"},
        {"Hipparcos Number", "HIP 36751"},
        {"Smithsonian Astrophysical Observation", "SAO 60183"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.38324210),
        dec: Angle.Degrees(+30.62849917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75780"},
        {"Smithsonian Astrophysical Observation", "SAO 64723"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.21065034),
        dec: Angle.Degrees(+30.63056818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38572"},
        {"Hipparcos Number", "HIP 27398"},
        {"Geneva Identification System", "GEN# +1.00038572"},
        {"Smithsonian Astrophysical Observation", "SAO 58449"},
        {"Wilson Evans Batten Catalogue", "WEB 5382"},
    },
    visualMagnitude: 8.27,
    bvColour: 2.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.03406909),
        dec: Angle.Degrees(+30.63109532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84726"},
        {"Smithsonian Astrophysical Observation", "SAO 65937"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.78502179),
        dec: Angle.Degrees(+30.63245840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6340"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.36608423),
        dec: Angle.Degrees(+30.63406801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130305"},
        {"Hipparcos Number", "HIP 72255"},
        {"Smithsonian Astrophysical Observation", "SAO 64323"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.63695096),
        dec: Angle.Degrees(+30.63768771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5956"},
        {"Hipparcos Number", "HIP 4779"},
        {"Smithsonian Astrophysical Observation", "SAO 54350"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.34756568),
        dec: Angle.Degrees(+30.63829137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104379"},
        {"Hipparcos Number", "HIP 58615"},
        {"Geneva Identification System", "GEN# +1.00104379"},
        {"Smithsonian Astrophysical Observation", "SAO 62799"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.30506861),
        dec: Angle.Degrees(+30.63842960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31565"},
        {"Hipparcos Number", "HIP 23087"},
        {"Geneva Identification System", "GEN# +1.00031565"},
        {"Smithsonian Astrophysical Observation", "SAO 57537"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.53527370),
        dec: Angle.Degrees(+30.63871774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131950"},
        {"Hipparcos Number", "HIP 73037"},
        {"Geneva Identification System", "GEN# +1.00131950"},
        {"Smithsonian Astrophysical Observation", "SAO 64401"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.89571666),
        dec: Angle.Degrees(+30.64240336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26125"},
        {"Hipparcos Number", "HIP 19397"},
        {"Smithsonian Astrophysical Observation", "SAO 57021"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.32384043),
        dec: Angle.Degrees(+30.64288761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41821",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41821"},
        {"Smithsonian Astrophysical Observation", "SAO 60871"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.89669377),
        dec: Angle.Degrees(+30.64317601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45237"},
        {"Hipparcos Number", "HIP 30747"},
        {"Geneva Identification System", "GEN# +1.00045237"},
        {"Smithsonian Astrophysical Observation", "SAO 59100"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.91793642),
        dec: Angle.Degrees(+30.64520870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164755"},
        {"Hipparcos Number", "HIP 88260"},
        {"Fundamental Katalog 5th Edition", "FK5 5586"},
        {"Smithsonian Astrophysical Observation", "SAO 66558"},
        {"Wilson Evans Batten Catalogue", "WEB 14911"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.35268878),
        dec: Angle.Degrees(+30.64525699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53573",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 10.05,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)57, 36.2600),
        dec: Angle.DegreesMinutesSeconds((int)+30, (int)38, 48.700)
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
    primaryId: "HIP 11253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14874"},
        {"Hipparcos Number", "HIP 11253"},
        {"Geneva Identification System", "GEN# +1.00014874"},
        {"Smithsonian Astrophysical Observation", "SAO 55525"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.21323914),
        dec: Angle.Degrees(+30.64718304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281681"},
        {"Hipparcos Number", "HIP 19477"},
        {"Smithsonian Astrophysical Observation", "SAO 57038"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.57603030),
        dec: Angle.Degrees(+30.64838167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198482"},
        {"Hipparcos Number", "HIP 102799"},
        {"Smithsonian Astrophysical Observation", "SAO 70549"},
        {"Wilson Evans Batten Catalogue", "WEB 18646"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.40108371),
        dec: Angle.Degrees(+30.65047522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95422"},
    },
    visualMagnitude: 11.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.15115517),
        dec: Angle.Degrees(+30.65220634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53571",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7988 A"},
        {"Henry Draper", "HD 94883"},
        {"Hipparcos Number", "HIP 53571"},
        {"Smithsonian Astrophysical Observation", "SAO 62329"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.39939232),
        dec: Angle.Degrees(+30.65269284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98674"},
    },
    visualMagnitude: 10.99,
    bvColour: 2.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.63223559),
        dec: Angle.Degrees(+30.65332223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281242"},
        {"Hipparcos Number", "HIP 17796"},
        {"Smithsonian Astrophysical Observation", "SAO 56718"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.14826535),
        dec: Angle.Degrees(+30.65653882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335027"},
        {"Hipparcos Number", "HIP 102468"},
        {"Smithsonian Astrophysical Observation", "SAO 70469"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.45787489),
        dec: Angle.Degrees(+30.65850045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64039"},
        {"Geneva Identification System", "GEN# +0.03102452"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.86758628),
        dec: Angle.Degrees(+30.66080367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4327",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 768 AB"},
        {"Henry Draper", "HD 5315"},
        {"Hipparcos Number", "HIP 4327"},
        {"Smithsonian Astrophysical Observation", "SAO 54265"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.84557185),
        dec: Angle.Degrees(+30.66164464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89595"},
        {"Hipparcos Number", "HIP 50673"},
        {"Smithsonian Astrophysical Observation", "SAO 61991"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.21337703),
        dec: Angle.Degrees(+30.66383029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76445"},
        {"Smithsonian Astrophysical Observation", "SAO 64805"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.19080353),
        dec: Angle.Degrees(+30.66817597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282860"},
        {"Hipparcos Number", "HIP 23703"},
        {"Smithsonian Astrophysical Observation", "SAO 57627"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.42579165),
        dec: Angle.Degrees(+30.66938490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219538"},
        {"Hipparcos Number", "HIP 114886"},
        {"Cincinnati Publication", "Ci 18 3046"},
        {"Geneva Identification System", "GEN# +1.00219538"},
        {"Smithsonian Astrophysical Observation", "SAO 73123"},
        {"Wilson Evans Batten Catalogue", "WEB 20360"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.07464283),
        dec: Angle.Degrees(+30.66998899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 359.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134811"},
        {"Hipparcos Number", "HIP 74284"},
        {"Geneva Identification System", "GEN# +1.00134811"},
        {"Smithsonian Astrophysical Observation", "SAO 64539"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.71920560),
        dec: Angle.Degrees(+30.67215725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14479"},
        {"Hipparcos Number", "HIP 10954"},
        {"Geneva Identification System", "GEN# +1.00014479"},
        {"Smithsonian Astrophysical Observation", "SAO 55476"},
        {"Wilson Evans Batten Catalogue", "WEB 2304"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.26865776),
        dec: Angle.Degrees(+30.67483634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93241"},
        {"Hipparcos Number", "HIP 52687"},
        {"Geneva Identification System", "GEN# +1.00093241"},
        {"Smithsonian Astrophysical Observation", "SAO 62245"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.60339811),
        dec: Angle.Degrees(+30.67488729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222033"},
        {"Hipparcos Number", "HIP 116542"},
        {"Geneva Identification System", "GEN# +1.00222033"},
        {"Smithsonian Astrophysical Observation", "SAO 73377"},
        {"Wilson Evans Batten Catalogue", "WEB 20578"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.27709360),
        dec: Angle.Degrees(+30.67783598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186440"},
        {"Hipparcos Number", "HIP 97028"},
        {"Celescope Catalog", "CEL 4824"},
        {"Geneva Identification System", "GEN# +1.00186440"},
        {"Smithsonian Astrophysical Observation", "SAO 68744"},
        {"Wilson Evans Batten Catalogue", "WEB 17026"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.78998146),
        dec: Angle.Degrees(+30.67788039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127245"},
        {"Hipparcos Number", "HIP 70863"},
        {"Geneva Identification System", "GEN# +1.00127245"},
        {"Smithsonian Astrophysical Observation", "SAO 64172"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.36643312),
        dec: Angle.Degrees(+30.67963830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16042"},
        {"Hipparcos Number", "HIP 12053"},
        {"Geneva Identification System", "GEN# +1.00016042"},
        {"Smithsonian Astrophysical Observation", "SAO 55682"},
        {"Wilson Evans Batten Catalogue", "WEB 2481"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.84279263),
        dec: Angle.Degrees(+30.68088211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93152"},
        {"Hipparcos Number", "HIP 52638"},
        {"Fundamental Katalog 5th Edition", "FK5 407"},
        {"Geneva Identification System", "GEN# +1.00093152J"},
        {"Smithsonian Astrophysical Observation", "SAO 62236"},
        {"Wilson Evans Batten Catalogue", "WEB 9587"},
    },
    visualMagnitude: 5.36,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.46630065),
        dec: Angle.Degrees(+30.68240198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35931"},
        {"Smithsonian Astrophysical Observation", "SAO 60053"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.10498532),
        dec: Angle.Degrees(+30.68280893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32050",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5332 AB"},
        {"Henry Draper", "HD 47812"},
        {"Hipparcos Number", "HIP 32050"},
        {"Smithsonian Astrophysical Observation", "SAO 59375"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.44782004),
        dec: Angle.Degrees(+30.68407104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 641"},
        {"Hipparcos Number", "HIP 886"},
        {"Smithsonian Astrophysical Observation", "SAO 53699"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.70202017),
        dec: Angle.Degrees(+30.68565518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200450"},
        {"Hipparcos Number", "HIP 103848"},
        {"Smithsonian Astrophysical Observation", "SAO 70819"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.64389945),
        dec: Angle.Degrees(+30.68567588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251803"},
        {"Hipparcos Number", "HIP 29050"},
        {"Smithsonian Astrophysical Observation", "SAO 58768"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.92995711),
        dec: Angle.Degrees(+30.68633962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122404"},
        {"Hipparcos Number", "HIP 68465"},
        {"Geneva Identification System", "GEN# +1.00122404"},
        {"Smithsonian Astrophysical Observation", "SAO 63885"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.26075671),
        dec: Angle.Degrees(+30.68711895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188669"},
        {"Hipparcos Number", "HIP 98011"},
        {"Smithsonian Astrophysical Observation", "SAO 69078"},
        {"Wilson Evans Batten Catalogue", "WEB 17261"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.77142110),
        dec: Angle.Degrees(+30.68753335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85708"},
        {"Hipparcos Number", "HIP 48572"},
        {"Geneva Identification System", "GEN# +1.00085708"},
        {"Smithsonian Astrophysical Observation", "SAO 61748"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.60007184),
        dec: Angle.Degrees(+30.68836888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63581"},
        {"Geneva Identification System", "GEN# +0.03102438"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.43618613),
        dec: Angle.Degrees(+30.69142491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65930"},
        {"Smithsonian Astrophysical Observation", "SAO 63578"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.73669214),
        dec: Angle.Degrees(+30.69164942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62962"},
        {"Geneva Identification System", "GEN# +0.03102420"},
        {"Smithsonian Astrophysical Observation", "SAO 63241"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.53405443),
        dec: Angle.Degrees(+30.69200720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50765"},
        {"Hipparcos Number", "HIP 33332"},
        {"Geneva Identification System", "GEN# +1.00050765"},
        {"Smithsonian Astrophysical Observation", "SAO 59617"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.98703759),
        dec: Angle.Degrees(+30.69242656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70093"},
        {"Geneva Identification System", "GEN# +0.03102610"},
        {"Smithsonian Astrophysical Observation", "SAO 64083"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.15086767),
        dec: Angle.Degrees(+30.69247130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80789"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.43894662),
        dec: Angle.Degrees(+30.69449598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136526"},
        {"Hipparcos Number", "HIP 75057"},
        {"Wilson Evans Batten Catalogue", "WEB 12802"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.05531677),
        dec: Angle.Degrees(+30.69563322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60988"},
        {"Hipparcos Number", "HIP 37176"},
        {"Geneva Identification System", "GEN# +1.00060988"},
        {"Smithsonian Astrophysical Observation", "SAO 60240"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.58052808),
        dec: Angle.Degrees(+30.69599790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74485"},
        {"Hipparcos Number", "HIP 42954"},
        {"Fundamental Katalog 5th Edition", "FK5 2690"},
        {"Geneva Identification System", "GEN# +1.00074485"},
        {"Smithsonian Astrophysical Observation", "SAO 61029"},
        {"Wilson Evans Batten Catalogue", "WEB 8305"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.33926878),
        dec: Angle.Degrees(+30.69776209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116879"},
        {"Hipparcos Number", "HIP 65533"},
        {"Geneva Identification System", "GEN# +1.00116879"},
        {"Smithsonian Astrophysical Observation", "SAO 63536"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.52885218),
        dec: Angle.Degrees(+30.70221780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188503"},
        {"Hipparcos Number", "HIP 97948"},
        {"Celescope Catalog", "CEL 4874"},
        {"Geneva Identification System", "GEN# +1.00188503"},
        {"Smithsonian Astrophysical Observation", "SAO 69055"},
        {"Wilson Evans Batten Catalogue", "WEB 17234"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.58498286),
        dec: Angle.Degrees(+30.70421990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35193",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5936 AB"},
        {"Henry Draper", "HD 55971"},
        {"Hipparcos Number", "HIP 35193"},
        {"Smithsonian Astrophysical Observation", "SAO 59930"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.09762674),
        dec: Angle.Degrees(+30.70525808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155316"},
        {"Hipparcos Number", "HIP 83946"},
        {"Renson", "Renson 43870"},
        {"Smithsonian Astrophysical Observation", "SAO 65833"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.38721828),
        dec: Angle.Degrees(+30.70562137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152895"},
        {"Hipparcos Number", "HIP 82771"},
        {"Smithsonian Astrophysical Observation", "SAO 65650"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.74045837),
        dec: Angle.Degrees(+30.70599370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12676"},
        {"Hipparcos Number", "HIP 9698"},
        {"Smithsonian Astrophysical Observation", "SAO 55244"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.18457177),
        dec: Angle.Degrees(+30.70765533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129725"},
        {"Hipparcos Number", "HIP 71984"},
        {"Smithsonian Astrophysical Observation", "SAO 64292"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.83507908),
        dec: Angle.Degrees(+30.71028783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39712"},
        {"Hipparcos Number", "HIP 28022"},
        {"Celescope Catalog", "CEL 1033"},
        {"Geneva Identification System", "GEN# +1.00039712"},
        {"Smithsonian Astrophysical Observation", "SAO 58574"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.90268818),
        dec: Angle.Degrees(+30.71138952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220564"},
        {"Hipparcos Number", "HIP 115563"},
        {"Geneva Identification System", "GEN# +1.00220564"},
        {"Smithsonian Astrophysical Observation", "SAO 73233"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.12869215),
        dec: Angle.Degrees(+30.71217564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73279"},
        {"Hipparcos Number", "HIP 42389"},
        {"Smithsonian Astrophysical Observation", "SAO 60945"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.65883894),
        dec: Angle.Degrees(+30.71223694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78513"},
        {"Hipparcos Number", "HIP 44967"},
        {"Geneva Identification System", "GEN# +1.00078513"},
        {"Smithsonian Astrophysical Observation", "SAO 61296"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.40924021),
        dec: Angle.Degrees(+30.71290138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69751"},
        {"Hipparcos Number", "HIP 40795"},
        {"Smithsonian Astrophysical Observation", "SAO 60730"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.89223063),
        dec: Angle.Degrees(+30.71643388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333635"},
        {"Hipparcos Number", "HIP 99323"},
        {"Geneva Identification System", "GEN# +1.00333635"},
        {"Smithsonian Astrophysical Observation", "SAO 69521"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.40267848),
        dec: Angle.Degrees(+30.71732266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102453",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14259 A"},
        {"Henry Draper", "HD 197912"},
        {"Hipparcos Number", "HIP 102453"},
        {"Geneva Identification System", "GEN# +1.00197912J"},
        {"Smithsonian Astrophysical Observation", "SAO 70467"},
        {"Wilson Evans Batten Catalogue", "WEB 18554"},
    },
    visualMagnitude: 4.22,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.41566302),
        dec: Angle.Degrees(+30.71965680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65255"},
        {"Hipparcos Number", "HIP 39031"},
        {"Smithsonian Astrophysical Observation", "SAO 60498"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.79157001),
        dec: Angle.Degrees(+30.72009856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120531"},
        {"Hipparcos Number", "HIP 67463"},
        {"Smithsonian Astrophysical Observation", "SAO 63768"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.37380198),
        dec: Angle.Degrees(+30.72076234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100796"},
        {"Hipparcos Number", "HIP 56587"},
        {"Fundamental Katalog 5th Edition", "FK5 5024"},
        {"Geneva Identification System", "GEN# +1.00100796"},
        {"Smithsonian Astrophysical Observation", "SAO 62620"},
        {"Wilson Evans Batten Catalogue", "WEB 10173"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.02338326),
        dec: Angle.Degrees(+30.72123814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96858",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12786 AB"},
        {"Henry Draper", "HD 186098"},
        {"Henry Draper 2", "HD 186097"},
        {"Hipparcos Number", "HIP 96858"},
        {"Smithsonian Astrophysical Observation", "SAO 68695"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.31451639),
        dec: Angle.Degrees(+30.72132874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107548",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107548"},
        {"Smithsonian Astrophysical Observation", "SAO 71695"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.73565933),
        dec: Angle.Degrees(+30.72146687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13704"},
        {"Hipparcos Number", "HIP 10425"},
        {"Geneva Identification System", "GEN# +1.00013704"},
        {"Smithsonian Astrophysical Observation", "SAO 55373"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.58410380),
        dec: Angle.Degrees(+30.72504841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94990"},
        {"Hipparcos Number", "HIP 53636"},
        {"Smithsonian Astrophysical Observation", "SAO 62334"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.59324363),
        dec: Angle.Degrees(+30.72668435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164374"},
        {"Hipparcos Number", "HIP 88093"},
        {"Smithsonian Astrophysical Observation", "SAO 66540"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.87388819),
        dec: Angle.Degrees(+30.72777059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106107"},
        {"Smithsonian Astrophysical Observation", "SAO 71389"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.40183253),
        dec: Angle.Degrees(+30.72879503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46135"},
        {"Smithsonian Astrophysical Observation", "SAO 61460"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.12482931),
        dec: Angle.Degrees(+30.73034020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190604"},
        {"Hipparcos Number", "HIP 98869"},
        {"Smithsonian Astrophysical Observation", "SAO 69364"},
        {"Wilson Evans Batten Catalogue", "WEB 17547"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.16384816),
        dec: Angle.Degrees(+30.73136350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177809"},
        {"Hipparcos Number", "HIP 93720"},
        {"Geneva Identification System", "GEN# +1.00177809"},
        {"Smithsonian Astrophysical Observation", "SAO 67781"},
        {"Wilson Evans Batten Catalogue", "WEB 16289"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.24280008),
        dec: Angle.Degrees(+30.73344797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212910"},
        {"Hipparcos Number", "HIP 110822"},
        {"Smithsonian Astrophysical Observation", "SAO 72348"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.77838757),
        dec: Angle.Degrees(+30.73431231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17167 AB"},
        {"Henry Draper", "HD 224882"},
        {"Hipparcos Number", "HIP 114"},
        {"Geneva Identification System", "GEN# +1.00224882J"},
        {"Smithsonian Astrophysical Observation", "SAO 73691"},
        {"Wilson Evans Batten Catalogue", "WEB 15"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.37167609),
        dec: Angle.Degrees(+30.73587929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192805"},
        {"Hipparcos Number", "HIP 99864"},
        {"Celescope Catalog", "CEL 4998"},
        {"Geneva Identification System", "GEN# +1.00192805"},
        {"Smithsonian Astrophysical Observation", "SAO 69708"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.92319323),
        dec: Angle.Degrees(+30.74188544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127616"},
        {"Hipparcos Number", "HIP 71032"},
        {"Smithsonian Astrophysical Observation", "SAO 64199"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.91616517),
        dec: Angle.Degrees(+30.74329225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117893"},
        {"Hipparcos Number", "HIP 66083"},
        {"Geneva Identification System", "GEN# +1.00117893"},
        {"Smithsonian Astrophysical Observation", "SAO 63597"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.19969516),
        dec: Angle.Degrees(+30.74829661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220538"},
        {"Hipparcos Number", "HIP 115545"},
        {"Smithsonian Astrophysical Observation", "SAO 73231"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.07391037),
        dec: Angle.Degrees(+30.75149597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107728",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15353 A"},
        {"Henry Draper", "HD 207593"},
        {"Hipparcos Number", "HIP 107728"},
        {"Smithsonian Astrophysical Observation", "SAO 71734"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.34935014),
        dec: Angle.Degrees(+30.75390530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91332"},
        {"Hipparcos Number", "HIP 51652"},
        {"Geneva Identification System", "GEN# +1.00091332"},
        {"Smithsonian Astrophysical Observation", "SAO 62119"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.29046497),
        dec: Angle.Degrees(+30.75484099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 266611"},
        {"Hipparcos Number", "HIP 33428"},
        {"Geneva Identification System", "GEN# +1.00266568"},
        {"Wilson Evans Batten Catalogue", "WEB 6719"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.26929658),
        dec: Angle.Degrees(+30.75703466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107729",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15353 B"},
        {"Hipparcos Number", "HIP 107729"},
        {"Smithsonian Astrophysical Observation", "SAO 71735"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.35080501),
        dec: Angle.Degrees(+30.75848474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77555"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.51455387),
        dec: Angle.Degrees(+30.76100812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83351"},
        {"Hipparcos Number", "HIP 47324"},
        {"Geneva Identification System", "GEN# +1.00083351"},
        {"Smithsonian Astrophysical Observation", "SAO 61612"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.64887952),
        dec: Angle.Degrees(+30.76150786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113039",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16339 AB"},
        {"Henry Draper", "HD 216562"},
        {"Hipparcos Number", "HIP 113039"},
        {"Geneva Identification System", "GEN# +1.00216562J"},
        {"Smithsonian Astrophysical Observation", "SAO 72815"},
        {"Wilson Evans Batten Catalogue", "WEB 20124"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.39562755),
        dec: Angle.Degrees(+30.76265349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335289"},
        {"Hipparcos Number", "HIP 103199"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.63894806),
        dec: Angle.Degrees(+30.76393207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187750"},
        {"Hipparcos Number", "HIP 97619"},
        {"Celescope Catalog", "CEL 4858"},
        {"Geneva Identification System", "GEN# +1.00187750"},
        {"Smithsonian Astrophysical Observation", "SAO 68934"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.61102262),
        dec: Angle.Degrees(+30.76613679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20725"},
        {"Hipparcos Number", "HIP 15636"},
        {"Smithsonian Astrophysical Observation", "SAO 56372"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.33046277),
        dec: Angle.Degrees(+30.76623496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111347"},
        {"Hipparcos Number", "HIP 62492"},
        {"Geneva Identification System", "GEN# +1.00111347"},
        {"Smithsonian Astrophysical Observation", "SAO 63199"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.09196399),
        dec: Angle.Degrees(+30.76711903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10005"},
        {"Smithsonian Astrophysical Observation", "SAO 55297"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.21096151),
        dec: Angle.Degrees(+30.76721937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91162"},
        {"Hipparcos Number", "HIP 51565"},
        {"Smithsonian Astrophysical Observation", "SAO 62103"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.99509837),
        dec: Angle.Degrees(+30.76956048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223953"},
        {"Hipparcos Number", "HIP 117835"},
        {"Geneva Identification System", "GEN# +1.00223953"},
        {"Smithsonian Astrophysical Observation", "SAO 73591"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.47086813),
        dec: Angle.Degrees(+30.77016937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113025"},
    },
    visualMagnitude: 11.05,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.35228590),
        dec: Angle.Degrees(+30.77018029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209440"},
        {"Hipparcos Number", "HIP 108831"},
        {"Geneva Identification System", "GEN# +1.00209440"},
        {"Smithsonian Astrophysical Observation", "SAO 71973"},
        {"Wilson Evans Batten Catalogue", "WEB 19575"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.70695045),
        dec: Angle.Degrees(+30.77121867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281309"},
        {"Hipparcos Number", "HIP 18204"},
        {"Smithsonian Astrophysical Observation", "SAO 56793"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.39803075),
        dec: Angle.Degrees(+30.77351153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9687"},
        {"Hipparcos Number", "HIP 7403"},
        {"Smithsonian Astrophysical Observation", "SAO 54809"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.85817155),
        dec: Angle.Degrees(+30.77517800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281679"},
        {"Hipparcos Number", "HIP 19395"},
        {"Smithsonian Astrophysical Observation", "SAO 57020"},
        {"New General Catalogue", "NGC 1514"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.32079144),
        dec: Angle.Degrees(+30.77595545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189086"},
        {"Hipparcos Number", "HIP 98182"},
        {"Celescope Catalog", "CEL 4885"},
        {"Geneva Identification System", "GEN# +1.00189086"},
        {"Smithsonian Astrophysical Observation", "SAO 69137"},
        {"Wilson Evans Batten Catalogue", "WEB 17309"},
    },
    visualMagnitude: 6.96,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.28451666),
        dec: Angle.Degrees(+30.77747520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10981"},
        {"Hipparcos Number", "HIP 8409"},
        {"Geneva Identification System", "GEN# +1.00010981"},
        {"Smithsonian Astrophysical Observation", "SAO 54989"},
        {"Wilson Evans Batten Catalogue", "WEB 1791"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.11981483),
        dec: Angle.Degrees(+30.77922919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130354"},
        {"Hipparcos Number", "HIP 72271"},
        {"Smithsonian Astrophysical Observation", "SAO 64327"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.69834856),
        dec: Angle.Degrees(+30.77971317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175676"},
        {"Hipparcos Number", "HIP 92853"},
        {"Geneva Identification System", "GEN# +1.00175676"},
        {"Smithsonian Astrophysical Observation", "SAO 67570"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.81336316),
        dec: Angle.Degrees(+30.78003712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 253615"},
        {"Hipparcos Number", "HIP 29617"},
        {"Smithsonian Astrophysical Observation", "SAO 58885"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.62275715),
        dec: Angle.Degrees(+30.78257649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9788"},
        {"Geneva Identification System", "GEN# +0.03000331"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.45587015),
        dec: Angle.Degrees(+30.78410257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43111"},
        {"Hipparcos Number", "HIP 29742"},
        {"Smithsonian Astrophysical Observation", "SAO 58913"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.95828748),
        dec: Angle.Degrees(+30.78470089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105471",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105471"},
        {"Smithsonian Astrophysical Observation", "SAO 71242"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.44676121),
        dec: Angle.Degrees(+30.78479515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63462",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8731"},
        {"Henry Draper", "HD 112989"},
        {"Hipparcos Number", "HIP 63462"},
        {"Fundamental Katalog 5th Edition", "FK5 3039"},
        {"Geneva Identification System", "GEN# +1.00112989"},
        {"Smithsonian Astrophysical Observation", "SAO 63288"},
        {"Wilson Evans Batten Catalogue", "WEB 11229"},
    },
    visualMagnitude: 4.88,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.06868941),
        dec: Angle.Degrees(+30.78503676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160054"},
        {"Hipparcos Number", "HIP 86178"},
        {"Fundamental Katalog 5th Edition", "FK5 3397"},
        {"Geneva Identification System", "GEN# +1.00160054"},
        {"Smithsonian Astrophysical Observation", "SAO 66175"},
        {"Wilson Evans Batten Catalogue", "WEB 14534"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.15302243),
        dec: Angle.Degrees(+30.78519255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191855"},
        {"Hipparcos Number", "HIP 99431"},
        {"Smithsonian Astrophysical Observation", "SAO 69562"},
        {"Wilson Evans Batten Catalogue", "WEB 17759"},
    },
    visualMagnitude: 6.96,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.72661999),
        dec: Angle.Degrees(+30.78968966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9966"},
        {"Hipparcos Number", "HIP 7612"},
        {"Geneva Identification System", "GEN# +1.00009966"},
        {"Smithsonian Astrophysical Observation", "SAO 54850"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.51946099),
        dec: Angle.Degrees(+30.78982774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 281.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334655"},
        {"Hipparcos Number", "HIP 101682"},
        {"Smithsonian Astrophysical Observation", "SAO 70260"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.15481883),
        dec: Angle.Degrees(+30.78989507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214296"},
        {"Hipparcos Number", "HIP 111619"},
        {"Smithsonian Astrophysical Observation", "SAO 72533"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.18769097),
        dec: Angle.Degrees(+30.79144810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78257"},
    },
    visualMagnitude: 11.64,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.67296908),
        dec: Angle.Degrees(+30.79160273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198330"},
        {"Hipparcos Number", "HIP 102707"},
        {"Smithsonian Astrophysical Observation", "SAO 70526"},
        {"Wilson Evans Batten Catalogue", "WEB 18617"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.15663863),
        dec: Angle.Degrees(+30.79294497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10829"},
        {"Hipparcos Number", "HIP 8277"},
        {"Geneva Identification System", "GEN# +1.00010829"},
        {"Smithsonian Astrophysical Observation", "SAO 54971"},
        {"Wilson Evans Batten Catalogue", "WEB 1765"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.66405118),
        dec: Angle.Degrees(+30.79394894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88280"},
        {"Hipparcos Number", "HIP 49914"},
        {"Smithsonian Astrophysical Observation", "SAO 61919"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.86892150),
        dec: Angle.Degrees(+30.79706699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33299"},
        {"Hipparcos Number", "HIP 24100"},
        {"Geneva Identification System", "GEN# +1.00033299"},
        {"Smithsonian Astrophysical Observation", "SAO 57713"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.64573141),
        dec: Angle.Degrees(+30.79754858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110642"},
        {"Hipparcos Number", "HIP 62077"},
        {"Geneva Identification System", "GEN# +1.00110642"},
        {"Smithsonian Astrophysical Observation", "SAO 63157"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.84146325),
        dec: Angle.Degrees(+30.79846231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60373"},
        {"Geneva Identification System", "GEN# +0.03102357"},
        {"Smithsonian Astrophysical Observation", "SAO 62975"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.69175718),
        dec: Angle.Degrees(+30.80094430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149008"},
        {"Hipparcos Number", "HIP 80867"},
        {"Smithsonian Astrophysical Observation", "SAO 65351"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.68913057),
        dec: Angle.Degrees(+30.80298302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111471",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16085 A"},
        {"Henry Draper", "HD 214023"},
        {"Hipparcos Number", "HIP 111471"},
        {"Geneva Identification System", "GEN# +1.00214023"},
        {"Smithsonian Astrophysical Observation", "SAO 72490"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.75976953),
        dec: Angle.Degrees(+30.80311801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11166"},
        {"Hipparcos Number", "HIP 8557"},
        {"Geneva Identification System", "GEN# +1.00011166"},
        {"Smithsonian Astrophysical Observation", "SAO 55017"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.59960763),
        dec: Angle.Degrees(+30.80363179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158165"},
        {"Hipparcos Number", "HIP 85348"},
        {"Smithsonian Astrophysical Observation", "SAO 66046"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.61271937),
        dec: Angle.Degrees(+30.80431843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33427"},
        {"Hipparcos Number", "HIP 24172"},
        {"Smithsonian Astrophysical Observation", "SAO 57729"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.86482734),
        dec: Angle.Degrees(+30.80533926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17642",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2758 C"},
        {"Hipparcos Number", "HIP 17642"},
    },
    visualMagnitude: 10.23,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.70388084),
        dec: Angle.Degrees(+30.80832481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186178"},
        {"Hipparcos Number", "HIP 96888"},
        {"Smithsonian Astrophysical Observation", "SAO 68704"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.41910160),
        dec: Angle.Degrees(+30.80858609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202108"},
        {"Hipparcos Number", "HIP 104733"},
        {"Geneva Identification System", "GEN# +1.00202108"},
        {"Smithsonian Astrophysical Observation", "SAO 71071"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.24020897),
        dec: Angle.Degrees(+30.80924687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17646",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2758 AB"},
        {"Henry Draper", "HD 281172"},
        {"Hipparcos Number", "HIP 17646"},
    },
    visualMagnitude: 9.91,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.70853032),
        dec: Angle.Degrees(+30.80929986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210552"},
        {"Hipparcos Number", "HIP 109454"},
        {"Geneva Identification System", "GEN# +1.00210552"},
        {"Smithsonian Astrophysical Observation", "SAO 72090"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.62048615),
        dec: Angle.Degrees(+30.81073565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196972"},
        {"Hipparcos Number", "HIP 101953"},
        {"Smithsonian Astrophysical Observation", "SAO 70333"},
        {"Wilson Evans Batten Catalogue", "WEB 18429"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.90139471),
        dec: Angle.Degrees(+30.81411611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61771",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61771"},
        {"Geneva Identification System", "GEN# +0.03102393"},
        {"Smithsonian Astrophysical Observation", "SAO 63123"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.90538538),
        dec: Angle.Degrees(+30.81449584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52234"},
        {"Cincinnati Publication", "Ci 18 1288"},
        {"Cincinnati Publication 2", "Ci 20 586"},
        {"Smithsonian Astrophysical Observation", "SAO 62191"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.06961120),
        dec: Angle.Degrees(+30.81546790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -431.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89291"},
        {"Smithsonian Astrophysical Observation", "SAO 66762"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.30882548),
        dec: Angle.Degrees(+30.81638817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16397"},
        {"Hipparcos Number", "HIP 12306"},
        {"Cincinnati Publication", "Ci 18 340"},
        {"Cincinnati Publication 2", "Ci 20 176"},
        {"Geneva Identification System", "GEN# +1.00016397"},
        {"Smithsonian Astrophysical Observation", "SAO 55739"},
        {"Wilson Evans Batten Catalogue", "WEB 2524"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.61747275),
        dec: Angle.Degrees(+30.81756750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -487.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -387.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142144"},
        {"Hipparcos Number", "HIP 77697"},
        {"Smithsonian Astrophysical Observation", "SAO 64953"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.95138935),
        dec: Angle.Degrees(+30.81770522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106366"},
        {"Hipparcos Number", "HIP 59666"},
        {"Fundamental Katalog 5th Edition", "FK5 5085"},
        {"Geneva Identification System", "GEN# +1.00106366"},
        {"Smithsonian Astrophysical Observation", "SAO 62905"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.53523489),
        dec: Angle.Degrees(+30.81944169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224545"},
        {"Hipparcos Number", "HIP 118217"},
        {"Smithsonian Astrophysical Observation", "SAO 73648"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.69870266),
        dec: Angle.Degrees(+30.82078752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334039"},
        {"Hipparcos Number", "HIP 100099"},
        {"Geneva Identification System", "GEN# +1.00334039"},
        {"Smithsonian Astrophysical Observation", "SAO 69795"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.61001401),
        dec: Angle.Degrees(+30.82125926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202882"},
        {"Hipparcos Number", "HIP 105146"},
        {"Smithsonian Astrophysical Observation", "SAO 71175"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.50026207),
        dec: Angle.Degrees(+30.82205457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53950",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8023 AB"},
        {"Henry Draper", "HD 95574"},
        {"Hipparcos Number", "HIP 53950"},
        {"Smithsonian Astrophysical Observation", "SAO 62368"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.57313391),
        dec: Angle.Degrees(+30.82374913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56483"},
        {"Hipparcos Number", "HIP 35372"},
        {"Smithsonian Astrophysical Observation", "SAO 59969"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.60936630),
        dec: Angle.Degrees(+30.82439463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191258"},
        {"Hipparcos Number", "HIP 99160"},
        {"Smithsonian Astrophysical Observation", "SAO 69463"},
        {"Wilson Evans Batten Catalogue", "WEB 17649"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.97255221),
        dec: Angle.Degrees(+30.82489633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32353",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5403 AB"},
        {"Henry Draper", "HD 48510"},
        {"Hipparcos Number", "HIP 32353"},
        {"Smithsonian Astrophysical Observation", "SAO 59444"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.29175457),
        dec: Angle.Degrees(+30.82597301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116016",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16800 C"},
        {"Hipparcos Number", "HIP 116016"},
        {"Geneva Identification System", "GEN# +1.00221264C"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.60716277),
        dec: Angle.Degrees(+30.82702392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57929",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8331 AB"},
        {"Hipparcos Number", "HIP 57929"},
        {"Smithsonian Astrophysical Observation", "SAO 62741"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.21934695),
        dec: Angle.Degrees(+30.82727435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187427"},
        {"Hipparcos Number", "HIP 97470"},
        {"Geneva Identification System", "GEN# +1.00187427"},
        {"Smithsonian Astrophysical Observation", "SAO 68890"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.16940734),
        dec: Angle.Degrees(+30.82865235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208415"},
        {"Hipparcos Number", "HIP 108218"},
        {"Smithsonian Astrophysical Observation", "SAO 71840"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.85406333),
        dec: Angle.Degrees(+30.82876927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332639"},
        {"Hipparcos Number", "HIP 97452"},
        {"Geneva Identification System", "GEN# +1.00332639"},
        {"Smithsonian Astrophysical Observation", "SAO 68886"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.11898648),
        dec: Angle.Degrees(+30.83017605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58762"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.77402315),
        dec: Angle.Degrees(+30.83179036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116017",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16800 AB"},
        {"Aitken 2", "ADS 16800"},
        {"Henry Draper", "HD 221264"},
        {"Hipparcos Number", "HIP 116017"},
        {"Geneva Identification System", "GEN# +1.00221264J"},
        {"Smithsonian Astrophysical Observation", "SAO 73306"},
        {"Wilson Evans Batten Catalogue", "WEB 20514"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.60953065),
        dec: Angle.Degrees(+30.83183946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104957"},
        {"Hipparcos Number", "HIP 58937"},
        {"Geneva Identification System", "GEN# +1.00104957"},
        {"Renson", "Renson 30390"},
        {"Smithsonian Astrophysical Observation", "SAO 62830"},
        {"Wilson Evans Batten Catalogue", "WEB 10492"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.27619512),
        dec: Angle.Degrees(+30.83266256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136159"},
        {"Hipparcos Number", "HIP 74868"},
        {"Smithsonian Astrophysical Observation", "SAO 64617"},
        {"Wilson Evans Batten Catalogue", "WEB 12768"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.49863289),
        dec: Angle.Degrees(+30.83311739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26747"},
        {"Hipparcos Number", "HIP 19819"},
        {"Smithsonian Astrophysical Observation", "SAO 57103"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.74939344),
        dec: Angle.Degrees(+30.83682351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65573"},
        {"Smithsonian Astrophysical Observation", "SAO 63542"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.66315593),
        dec: Angle.Degrees(+30.83704956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89905"},
        {"Hipparcos Number", "HIP 50852"},
        {"Fundamental Katalog 5th Edition", "FK5 4923"},
        {"Smithsonian Astrophysical Observation", "SAO 62008"},
        {"Wilson Evans Batten Catalogue", "WEB 9303"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.75561263),
        dec: Angle.Degrees(+30.83724624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73809"},
        {"Smithsonian Astrophysical Observation", "SAO 64494"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.28315063),
        dec: Angle.Degrees(+30.83818002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204773"},
        {"Hipparcos Number", "HIP 106153"},
        {"Smithsonian Astrophysical Observation", "SAO 71400"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.52916756),
        dec: Angle.Degrees(+30.83919231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187161"},
        {"Hipparcos Number", "HIP 97357"},
        {"Celescope Catalog", "CEL 4843"},
        {"Geneva Identification System", "GEN# +1.00187161"},
        {"Smithsonian Astrophysical Observation", "SAO 68851"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.82318695),
        dec: Angle.Degrees(+30.84020762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166601"},
        {"Hipparcos Number", "HIP 89014"},
        {"Geneva Identification System", "GEN# +1.00166601"},
        {"Smithsonian Astrophysical Observation", "SAO 66702"},
        {"Wilson Evans Batten Catalogue", "WEB 15106"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.51093743),
        dec: Angle.Degrees(+30.84046166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75337"},
        {"Geneva Identification System", "GEN# +0.03102730"},
        {"Smithsonian Astrophysical Observation", "SAO 64678"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.91560747),
        dec: Angle.Degrees(+30.84163598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243692"},
        {"Hipparcos Number", "HIP 25512"},
        {"Smithsonian Astrophysical Observation", "SAO 58044"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.83922695),
        dec: Angle.Degrees(+30.84325529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123351"},
        {"Hipparcos Number", "HIP 68904"},
        {"Geneva Identification System", "GEN# +1.00123351"},
        {"Smithsonian Astrophysical Observation", "SAO 63932"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.60889456),
        dec: Angle.Degrees(+30.84680912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141219"},
        {"Hipparcos Number", "HIP 77300"},
        {"Smithsonian Astrophysical Observation", "SAO 64897"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.72211130),
        dec: Angle.Degrees(+30.84698442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172631"},
        {"Hipparcos Number", "HIP 91533"},
        {"Smithsonian Astrophysical Observation", "SAO 67226"},
        {"Wilson Evans Batten Catalogue", "WEB 15737"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.00805744),
        dec: Angle.Degrees(+30.84938758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80259"},
        {"Smithsonian Astrophysical Observation", "SAO 65266"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.77131775),
        dec: Angle.Degrees(+30.85015286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189107"},
        {"Hipparcos Number", "HIP 98186"},
        {"Celescope Catalog", "CEL 4886"},
        {"Geneva Identification System", "GEN# +1.00189107"},
        {"Smithsonian Astrophysical Observation", "SAO 69142"},
        {"Wilson Evans Batten Catalogue", "WEB 17312"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.29438071),
        dec: Angle.Degrees(+30.85631937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35948"},
        {"Smithsonian Astrophysical Observation", "SAO 60054"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.15930644),
        dec: Angle.Degrees(+30.85652556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38663"},
        {"Smithsonian Astrophysical Observation", "SAO 60444"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.74186861),
        dec: Angle.Degrees(+30.85839253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36757"},
        {"Smithsonian Astrophysical Observation", "SAO 60184"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.39339027),
        dec: Angle.Degrees(+30.85898582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3092",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 548 A"},
        {"Henry Draper", "HD 3627"},
        {"Hipparcos Number", "HIP 3092"},
        {"Fundamental Katalog 5th Edition", "FK5 20"},
        {"Geneva Identification System", "GEN# +1.00003627A"},
        {"Smithsonian Astrophysical Observation", "SAO 54058"},
        {"Wilson Evans Batten Catalogue", "WEB 551"},
    },
    visualMagnitude: 3.27,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.83165567),
        dec: Angle.Degrees(+30.86122579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98263"},
        {"Hipparcos Number", "HIP 55220"},
        {"Smithsonian Astrophysical Observation", "SAO 62487"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.62541315),
        dec: Angle.Degrees(+30.86189981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193856"},
        {"Hipparcos Number", "HIP 100377"},
        {"Geneva Identification System", "GEN# +1.00193856"},
        {"Smithsonian Astrophysical Observation", "SAO 69881"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.35103757),
        dec: Angle.Degrees(+30.86427735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15377"},
        {"Hipparcos Number", "HIP 11588"},
        {"Smithsonian Astrophysical Observation", "SAO 55600"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.33974917),
        dec: Angle.Degrees(+30.86530279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79162"},
        {"Smithsonian Astrophysical Observation", "SAO 65111"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.35333119),
        dec: Angle.Degrees(+30.86690647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258730"},
        {"Hipparcos Number", "HIP 31129"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.97849148),
        dec: Angle.Degrees(+30.86703344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222277"},
        {"Hipparcos Number", "HIP 116712"},
        {"Smithsonian Astrophysical Observation", "SAO 73409"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.78905550),
        dec: Angle.Degrees(+30.86930130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107819"},
        {"Smithsonian Astrophysical Observation", "SAO 71755"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.64508821),
        dec: Angle.Degrees(+30.87192782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150710"},
        {"Hipparcos Number", "HIP 81726"},
        {"Geneva Identification System", "GEN# +1.00150710"},
        {"Smithsonian Astrophysical Observation", "SAO 65487"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.39488208),
        dec: Angle.Degrees(+30.87574173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108315"},
        {"Smithsonian Astrophysical Observation", "SAO 71861"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.14656562),
        dec: Angle.Degrees(+30.87729531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332931"},
        {"Hipparcos Number", "HIP 98082"},
        {"Smithsonian Astrophysical Observation", "SAO 69100"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.99865431),
        dec: Angle.Degrees(+30.87769381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35667"},
        {"Wilson Evans Batten Catalogue", "WEB 7106"},
    },
    visualMagnitude: 11.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.38971289),
        dec: Angle.Degrees(+30.88317987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27259"},
        {"Hipparcos Number", "HIP 20178"},
        {"Smithsonian Astrophysical Observation", "SAO 57155"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.87730669),
        dec: Angle.Degrees(+30.88325413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25554"},
        {"Hipparcos Number", "HIP 19033"},
        {"Smithsonian Astrophysical Observation", "SAO 56950"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.16026781),
        dec: Angle.Degrees(+30.88419842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27334"},
        {"Hipparcos Number", "HIP 20230"},
        {"Smithsonian Astrophysical Observation", "SAO 57167"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.03925505),
        dec: Angle.Degrees(+30.88606415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67867"},
        {"Smithsonian Astrophysical Observation", "SAO 63815"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.50974730),
        dec: Angle.Degrees(+30.88624029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89145"},
        {"Hipparcos Number", "HIP 50410"},
        {"Smithsonian Astrophysical Observation", "SAO 61969"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.39771458),
        dec: Angle.Degrees(+30.88721349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47050"},
        {"Hipparcos Number", "HIP 31716"},
        {"Smithsonian Astrophysical Observation", "SAO 59309"},
        {"Wilson Evans Batten Catalogue", "WEB 6362"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.52026462),
        dec: Angle.Degrees(+30.88966591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94048",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12094 A"},
        {"Henry Draper", "HD 178822"},
        {"Hipparcos Number", "HIP 94048"},
        {"Smithsonian Astrophysical Observation", "SAO 67866"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.20847726),
        dec: Angle.Degrees(+30.88999593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37366"},
        {"Hipparcos Number", "HIP 26611"},
        {"Celescope Catalog", "CEL 887"},
        {"Geneva Identification System", "GEN# +1.00037366"},
        {"Smithsonian Astrophysical Observation", "SAO 58297"},
        {"Wilson Evans Batten Catalogue", "WEB 5248"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.85334332),
        dec: Angle.Degrees(+30.89077689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147677"},
        {"Hipparcos Number", "HIP 80181"},
        {"Fundamental Katalog 5th Edition", "FK5 3294"},
        {"Geneva Identification System", "GEN# +1.00147677"},
        {"Smithsonian Astrophysical Observation", "SAO 65254"},
        {"Wilson Evans Batten Catalogue", "WEB 13574"},
    },
    visualMagnitude: 4.86,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.52454222),
        dec: Angle.Degrees(+30.89173424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171406"},
        {"Hipparcos Number", "HIP 90970"},
        {"Geneva Identification System", "GEN# +1.00171406"},
        {"Smithsonian Astrophysical Observation", "SAO 67102"},
        {"Wilson Evans Batten Catalogue", "WEB 15605"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.34599951),
        dec: Angle.Degrees(+30.89210594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2343"},
        {"Hipparcos Number", "HIP 2170"},
        {"Fundamental Katalog 5th Edition", "FK5 4045"},
        {"Geneva Identification System", "GEN# +1.00002343"},
        {"Smithsonian Astrophysical Observation", "SAO 53907"},
        {"Wilson Evans Batten Catalogue", "WEB 403"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.84759908),
        dec: Angle.Degrees(+30.89335644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192166"},
        {"Hipparcos Number", "HIP 99569"},
        {"Smithsonian Astrophysical Observation", "SAO 69596"},
    },
    visualMagnitude: 9.03,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.09898038),
        dec: Angle.Degrees(+30.89393370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115338"},
        {"Hipparcos Number", "HIP 64748"},
        {"Geneva Identification System", "GEN# +1.00115338"},
        {"Smithsonian Astrophysical Observation", "SAO 63436"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.05006350),
        dec: Angle.Degrees(+30.89433825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9023"},
        {"Hipparcos Number", "HIP 6948"},
        {"Smithsonian Astrophysical Observation", "SAO 54735"},
        {"Wilson Evans Batten Catalogue", "WEB 1507"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.36514585),
        dec: Angle.Degrees(+30.89477968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111483",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111483"},
        {"Smithsonian Astrophysical Observation", "SAO 72494"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.80259297),
        dec: Angle.Degrees(+30.89628171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9136"},
        {"Smithsonian Astrophysical Observation", "SAO 55143"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.44180179),
        dec: Angle.Degrees(+30.89677817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104688"},
        {"Smithsonian Astrophysical Observation", "SAO 71057"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.09417850),
        dec: Angle.Degrees(+30.89678075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282724"},
        {"Hipparcos Number", "HIP 23302"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.17526738),
        dec: Angle.Degrees(+30.89715945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120005"},
        {"Hipparcos Number", "HIP 67195"},
        {"Geneva Identification System", "GEN# +1.00120005"},
        {"Smithsonian Astrophysical Observation", "SAO 63733"},
        {"Wilson Evans Batten Catalogue", "WEB 11825"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.55795304),
        dec: Angle.Degrees(+30.89724773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -258.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104450"},
        {"Hipparcos Number", "HIP 58667"},
        {"Geneva Identification System", "GEN# +1.00104450"},
        {"Smithsonian Astrophysical Observation", "SAO 62804"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.43890103),
        dec: Angle.Degrees(+30.89920962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94671"},
        {"Smithsonian Astrophysical Observation", "SAO 68046"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.96722155),
        dec: Angle.Degrees(+30.89922769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140298"},
        {"Hipparcos Number", "HIP 76869"},
        {"Smithsonian Astrophysical Observation", "SAO 64850"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.45014912),
        dec: Angle.Degrees(+30.90160715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246560"},
        {"Hipparcos Number", "HIP 26946"},
        {"Geneva Identification System", "GEN# +1.00246560"},
        {"Smithsonian Astrophysical Observation", "SAO 58363"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.76083120),
        dec: Angle.Degrees(+30.90274936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84722"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.76590164),
        dec: Angle.Degrees(+30.90525783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15026"},
        {"Hipparcos Number", "HIP 11351"},
        {"Smithsonian Astrophysical Observation", "SAO 55550"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.52133006),
        dec: Angle.Degrees(+30.90679346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81048",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10113 AB"},
        {"Henry Draper", "HD 149394"},
        {"Hipparcos Number", "HIP 81048"},
        {"Smithsonian Astrophysical Observation", "SAO 65376"},
        {"Wilson Evans Batten Catalogue", "WEB 13707"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.30204205),
        dec: Angle.Degrees(+30.90745159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63185"},
        {"Hipparcos Number", "HIP 38122"},
        {"Geneva Identification System", "GEN# +1.00063185"},
        {"Smithsonian Astrophysical Observation", "SAO 60355"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.18492652),
        dec: Angle.Degrees(+30.91001529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52184"},
        {"Smithsonian Astrophysical Observation", "SAO 62184"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.91367086),
        dec: Angle.Degrees(+30.91232780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102876",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14355 A"},
        {"Henry Draper", "HD 198626"},
        {"Henry Draper 2", "HD 335121"},
        {"Hipparcos Number", "HIP 102876"},
        {"Geneva Identification System", "GEN# +1.00198626"},
        {"Smithsonian Astrophysical Observation", "SAO 70564"},
        {"Smithsonian Astrophysical Observation 2", "SAO 70540"},
        {"Wilson Evans Batten Catalogue", "WEB 18663"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.65003836),
        dec: Angle.Degrees(+30.91259438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98409",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13224 AB"},
        {"Henry Draper", "HD 189597"},
        {"Hipparcos Number", "HIP 98409"},
        {"Smithsonian Astrophysical Observation", "SAO 69223"},
        {"Wilson Evans Batten Catalogue", "WEB 17370"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.92417010),
        dec: Angle.Degrees(+30.91393798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144620"},
        {"Hipparcos Number", "HIP 78844"},
        {"Smithsonian Astrophysical Observation", "SAO 65071"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.41842669),
        dec: Angle.Degrees(+30.91705138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104039"},
        {"Smithsonian Astrophysical Observation", "SAO 70867"},
        {"Wilson Evans Batten Catalogue", "WEB 18955"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.16704500),
        dec: Angle.Degrees(+30.91791317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2870"},
        {"Smithsonian Astrophysical Observation", "SAO 54027"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.10054887),
        dec: Angle.Degrees(+30.91850545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46841"},
        {"Hipparcos Number", "HIP 31608"},
        {"Geneva Identification System", "GEN# +1.00046841"},
        {"Smithsonian Astrophysical Observation", "SAO 59293"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.23257510),
        dec: Angle.Degrees(+30.91892208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335129"},
        {"Hipparcos Number", "HIP 102556"},
        {"Smithsonian Astrophysical Observation", "SAO 70490"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.75344166),
        dec: Angle.Degrees(+30.92177172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195420"},
        {"Hipparcos Number", "HIP 101148"},
        {"Smithsonian Astrophysical Observation", "SAO 70114"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.53910922),
        dec: Angle.Degrees(+30.92532491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153808"},
        {"Hipparcos Number", "HIP 83207"},
        {"Fundamental Katalog 5th Edition", "FK5 634"},
        {"Geneva Identification System", "GEN# +1.00153808"},
        {"Smithsonian Astrophysical Observation", "SAO 65716"},
        {"Wilson Evans Batten Catalogue", "WEB 14064"},
    },
    visualMagnitude: 3.92,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.07252582),
        dec: Angle.Degrees(+30.92633926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135838"},
        {"Hipparcos Number", "HIP 74722"},
        {"Smithsonian Astrophysical Observation", "SAO 64599"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.05193320),
        dec: Angle.Degrees(+30.92754946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26206",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4166 AB"},
        {"Henry Draper", "HD 36723"},
        {"Hipparcos Number", "HIP 26206"},
        {"Geneva Identification System", "GEN# +1.00036723J"},
        {"Smithsonian Astrophysical Observation", "SAO 58204"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.77732645),
        dec: Angle.Degrees(+30.92901936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209963"},
        {"Hipparcos Number", "HIP 109148"},
        {"Smithsonian Astrophysical Observation", "SAO 72034"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.64161682),
        dec: Angle.Degrees(+30.92923949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94903"},
        {"Smithsonian Astrophysical Observation", "SAO 68110"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.68207325),
        dec: Angle.Degrees(+30.93102644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50577"},
        {"Hipparcos Number", "HIP 33272"},
        {"Geneva Identification System", "GEN# +1.00050577"},
        {"Smithsonian Astrophysical Observation", "SAO 59607"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.81523252),
        dec: Angle.Degrees(+30.93160741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96343"},
        {"Hipparcos Number", "HIP 54316"},
        {"Geneva Identification System", "GEN# +1.00096343"},
        {"Smithsonian Astrophysical Observation", "SAO 62409"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.67389830),
        dec: Angle.Degrees(+30.93171978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15984"},
        {"Geneva Identification System", "GEN# +0.03000540"},
        {"Smithsonian Astrophysical Observation", "SAO 56444"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.45873014),
        dec: Angle.Degrees(+30.93173092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34383"},
        {"Hipparcos Number", "HIP 24743"},
        {"Smithsonian Astrophysical Observation", "SAO 57863"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.58223081),
        dec: Angle.Degrees(+30.93337120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27040",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4305 AB"},
        {"Henry Draper", "HD 38017"},
        {"Hipparcos Number", "HIP 27040"},
        {"Celescope Catalog", "CEL 944"},
        {"Geneva Identification System", "GEN# +1.00038017J"},
        {"Smithsonian Astrophysical Observation", "SAO 58377"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.02146877),
        dec: Angle.Degrees(+30.93382640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332470"},
        {"Hipparcos Number", "HIP 97043"},
        {"Smithsonian Astrophysical Observation", "SAO 68749"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.83367225),
        dec: Angle.Degrees(+30.93431425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1606"},
        {"Hipparcos Number", "HIP 1630"},
        {"Geneva Identification System", "GEN# +1.00001606"},
        {"Smithsonian Astrophysical Observation", "SAO 53820"},
        {"Wilson Evans Batten Catalogue", "WEB 296"},
    },
    visualMagnitude: 5.89,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.10163324),
        dec: Angle.Degrees(+30.93561514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16761"},
        {"Hipparcos Number", "HIP 12600"},
        {"Smithsonian Astrophysical Observation", "SAO 55792"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.50281993),
        dec: Angle.Degrees(+30.93589190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203924"},
        {"Hipparcos Number", "HIP 105688"},
        {"Smithsonian Astrophysical Observation", "SAO 71287"},
        {"Wilson Evans Batten Catalogue", "WEB 19184"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.09439966),
        dec: Angle.Degrees(+30.93661702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334527"},
        {"Hipparcos Number", "HIP 101408"},
        {"Smithsonian Astrophysical Observation", "SAO 70180"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.26805082),
        dec: Angle.Degrees(+30.93720829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149044"},
        {"Hipparcos Number", "HIP 80884"},
        {"Geneva Identification System", "GEN# +1.00149044"},
        {"Smithsonian Astrophysical Observation", "SAO 65354"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.73017374),
        dec: Angle.Degrees(+30.94088566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59223"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.19603761),
        dec: Angle.Degrees(+30.94273642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3617",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 639"},
        {"Aitken 2", "ADS 639 A"},
        {"Henry Draper", "HD 4372"},
        {"Hipparcos Number", "HIP 3617"},
        {"Geneva Identification System", "GEN# +1.00004372"},
        {"Smithsonian Astrophysical Observation", "SAO 54138"},
        {"Wilson Evans Batten Catalogue", "WEB 645"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.60149417),
        dec: Angle.Degrees(+30.94279923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149890"},
        {"Hipparcos Number", "HIP 81312"},
        {"Cincinnati Publication", "Ci 18 2214"},
        {"Cincinnati Publication 2", "Ci 20 1003"},
        {"Geneva Identification System", "GEN# +1.00149890"},
        {"Smithsonian Astrophysical Observation", "SAO 65426"},
        {"Wilson Evans Batten Catalogue", "WEB 13743"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.10834330),
        dec: Angle.Degrees(+30.94281387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -465.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44300"},
        {"Hipparcos Number", "HIP 30309"},
        {"Geneva Identification System", "GEN# +1.00044300"},
        {"Smithsonian Astrophysical Observation", "SAO 59021"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.61808746),
        dec: Angle.Degrees(+30.94525111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188993"},
        {"Hipparcos Number", "HIP 98138"},
        {"Geneva Identification System", "GEN# +1.00188993"},
        {"Smithsonian Astrophysical Observation", "SAO 69122"},
        {"Wilson Evans Batten Catalogue", "WEB 17298"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.17372813),
        dec: Angle.Degrees(+30.94714252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199042"},
        {"Hipparcos Number", "HIP 103115"},
        {"Smithsonian Astrophysical Observation", "SAO 70633"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.38627159),
        dec: Angle.Degrees(+30.95134746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3620",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 639 B"},
        {"Henry Draper", "HD 4388"},
        {"Hipparcos Number", "HIP 3620"},
        {"Geneva Identification System", "GEN# +1.00004388"},
        {"Smithsonian Astrophysical Observation", "SAO 54139"},
        {"Wilson Evans Batten Catalogue", "WEB 647"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.61276262),
        dec: Angle.Degrees(+30.95163673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69221"},
        {"Geneva Identification System", "GEN# +0.03102590"},
        {"Smithsonian Astrophysical Observation", "SAO 63964"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.57938890),
        dec: Angle.Degrees(+30.95290060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46399"},
        {"Hipparcos Number", "HIP 31357"},
        {"Smithsonian Astrophysical Observation", "SAO 59245"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.63425390),
        dec: Angle.Degrees(+30.95469408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84341"},
        {"Smithsonian Astrophysical Observation", "SAO 65886"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.64130701),
        dec: Angle.Degrees(+30.95579299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56386"},
        {"Hipparcos Number", "HIP 35345"},
        {"Fundamental Katalog 5th Edition", "FK5 2563"},
        {"Geneva Identification System", "GEN# +1.00056386"},
        {"Smithsonian Astrophysical Observation", "SAO 59964"},
        {"Wilson Evans Batten Catalogue", "WEB 7053"},
    },
    visualMagnitude: 6.19,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.51705909),
        dec: Angle.Degrees(+30.95592678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155579"},
        {"Hipparcos Number", "HIP 84068"},
        {"Geneva Identification System", "GEN# +1.00155579"},
        {"Smithsonian Astrophysical Observation", "SAO 65850"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.80039999),
        dec: Angle.Degrees(+30.95616807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212901"},
        {"Hipparcos Number", "HIP 110809"},
        {"Smithsonian Astrophysical Observation", "SAO 72347"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.75380049),
        dec: Angle.Degrees(+30.95694026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42176"},
        {"Hipparcos Number", "HIP 29301"},
        {"Smithsonian Astrophysical Observation", "SAO 58830"},
        {"Wilson Evans Batten Catalogue", "WEB 5751"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.66389092),
        dec: Angle.Degrees(+30.95714770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83187"},
        {"Hipparcos Number", "HIP 47222"},
        {"Geneva Identification System", "GEN# +1.00083187"},
        {"Smithsonian Astrophysical Observation", "SAO 61603"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.36141568),
        dec: Angle.Degrees(+30.95731550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282422"},
        {"Hipparcos Number", "HIP 22117"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.39665229),
        dec: Angle.Degrees(+30.95805237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131600"},
        {"Hipparcos Number", "HIP 72879"},
        {"Geneva Identification System", "GEN# +1.00131600"},
        {"Smithsonian Astrophysical Observation", "SAO 64382"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.43205397),
        dec: Angle.Degrees(+30.95807451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57274"},
        {"Cincinnati Publication", "Ci 18 1450"},
        {"Geneva Identification System", "GEN# +0.03102290"},
        {"Smithsonian Astrophysical Observation", "SAO 62684"},
        {"Wilson Evans Batten Catalogue", "WEB 10301"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.17076193),
        dec: Angle.Degrees(+30.96021872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -380.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36896",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6185 AB"},
        {"Henry Draper", "HD 60318"},
        {"Hipparcos Number", "HIP 36896"},
        {"Geneva Identification System", "GEN# +1.00060318J"},
        {"Smithsonian Astrophysical Observation", "SAO 60204"},
        {"Wilson Evans Batten Catalogue", "WEB 7327"},
    },
    visualMagnitude: 5.34,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.78673794),
        dec: Angle.Degrees(+30.96091010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334230"},
        {"Hipparcos Number", "HIP 100668"},
        {"Smithsonian Astrophysical Observation", "SAO 69975"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.16172878),
        dec: Angle.Degrees(+30.96138633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202313"},
        {"Hipparcos Number", "HIP 104819"},
        {"Renson", "Renson 56380"},
        {"Smithsonian Astrophysical Observation", "SAO 71101"},
        {"Wilson Evans Batten Catalogue", "WEB 19062"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.54113230),
        dec: Angle.Degrees(+30.96149468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106423"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.33791419),
        dec: Angle.Degrees(+30.96205714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30997"},
    },
    visualMagnitude: 12.85,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.58774316),
        dec: Angle.Degrees(+30.96272300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78712"},
        {"Hipparcos Number", "HIP 45058"},
        {"Geneva Identification System", "GEN# +1.00078712"},
        {"Smithsonian Astrophysical Observation", "SAO 61306"},
        {"Wilson Evans Batten Catalogue", "WEB 8600"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.66168928),
        dec: Angle.Degrees(+30.96321920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106278"},
        {"Hipparcos Number", "HIP 59620"},
        {"Geneva Identification System", "GEN# +1.00106278"},
        {"Smithsonian Astrophysical Observation", "SAO 62901"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.39591324),
        dec: Angle.Degrees(+30.96339143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332344"},
        {"Hipparcos Number", "HIP 96826"},
        {"Smithsonian Astrophysical Observation", "SAO 68682"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.20868434),
        dec: Angle.Degrees(+30.96367190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214979"},
        {"Hipparcos Number", "HIP 112032"},
        {"Smithsonian Astrophysical Observation", "SAO 72625"},
        {"Wilson Evans Batten Catalogue", "WEB 20000"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.38031252),
        dec: Angle.Degrees(+30.96585875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33705"},
        {"Hipparcos Number", "HIP 24338"},
        {"Smithsonian Astrophysical Observation", "SAO 57761"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.35520459),
        dec: Angle.Degrees(+30.96650540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73413"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.04372456),
        dec: Angle.Degrees(+30.96689872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30444"},
        {"Hipparcos Number", "HIP 22375"},
        {"Geneva Identification System", "GEN# +1.00030444"},
        {"Smithsonian Astrophysical Observation", "SAO 57439"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.25081142),
        dec: Angle.Degrees(+30.96733928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40524"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.12110523),
        dec: Angle.Degrees(+30.96817655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -211.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170199"},
        {"Hipparcos Number", "HIP 90410"},
        {"Smithsonian Astrophysical Observation", "SAO 66981"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.71313679),
        dec: Angle.Degrees(+30.96832584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134367"},
        {"Hipparcos Number", "HIP 74089"},
        {"Smithsonian Astrophysical Observation", "SAO 64518"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.12202293),
        dec: Angle.Degrees(+30.97073112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6921"},
        {"Hipparcos Number", "HIP 5470"},
        {"Geneva Identification System", "GEN# +1.00006921"},
        {"Smithsonian Astrophysical Observation", "SAO 54478"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.51085456),
        dec: Angle.Degrees(+30.97191623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100149"},
        {"Hipparcos Number", "HIP 56233"},
        {"Geneva Identification System", "GEN# +1.00100149"},
        {"Smithsonian Astrophysical Observation", "SAO 62586"},
        {"Wilson Evans Batten Catalogue", "WEB 10104"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.91429673),
        dec: Angle.Degrees(+30.97266799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109888"},
        {"Smithsonian Astrophysical Observation", "SAO 72174"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.83808637),
        dec: Angle.Degrees(+30.97310607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11437"},
        {"Geneva Identification System", "GEN# +0.03000397A"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.87166751),
        dec: Angle.Degrees(+30.97367408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145587"},
        {"Hipparcos Number", "HIP 79266"},
        {"Smithsonian Astrophysical Observation", "SAO 65121"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.65998876),
        dec: Angle.Degrees(+30.97415794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54873",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54873"},
        {"Smithsonian Astrophysical Observation", "SAO 62458"},
    },
    visualMagnitude: 11.20,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.52667965),
        dec: Angle.Degrees(+30.97456060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1605"},
        {"Hipparcos Number", "HIP 1640"},
        {"Geneva Identification System", "GEN# +1.00001605"},
        {"Smithsonian Astrophysical Observation", "SAO 53821"},
        {"Wilson Evans Batten Catalogue", "WEB 297"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.13108865),
        dec: Angle.Degrees(+30.97466252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43967"},
        {"Smithsonian Astrophysical Observation", "SAO 61150"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.30736105),
        dec: Angle.Degrees(+30.97710943)
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
    primaryId: "HIP 69001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123533"},
        {"Hipparcos Number", "HIP 69001"},
        {"Geneva Identification System", "GEN# +1.00123533"},
        {"Smithsonian Astrophysical Observation", "SAO 63940"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.89711447),
        dec: Angle.Degrees(+30.97809629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189395"},
        {"Hipparcos Number", "HIP 98325"},
        {"Celescope Catalog", "CEL 4892"},
        {"Fundamental Katalog 5th Edition", "FK5 3594"},
        {"Geneva Identification System", "GEN# +1.00189395"},
        {"Smithsonian Astrophysical Observation", "SAO 69188"},
        {"Wilson Evans Batten Catalogue", "WEB 17343"},
    },
    visualMagnitude: 5.51,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.65816165),
        dec: Angle.Degrees(+30.98367174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20905"},
        {"Hipparcos Number", "HIP 15781"},
        {"Smithsonian Astrophysical Observation", "SAO 56402"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.84960882),
        dec: Angle.Degrees(+30.98404528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242273"},
        {"Hipparcos Number", "HIP 24685"},
        {"Smithsonian Astrophysical Observation", "SAO 57847"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.42496160),
        dec: Angle.Degrees(+30.98430116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145645"},
        {"Hipparcos Number", "HIP 79285"},
        {"Geneva Identification System", "GEN# +1.00145645"},
        {"Smithsonian Astrophysical Observation", "SAO 65123"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.72534115),
        dec: Angle.Degrees(+30.98582016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79916"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.68230858),
        dec: Angle.Degrees(+30.98965887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69514"},
        {"Geneva Identification System", "GEN# +0.03102596J"},
        {"Smithsonian Astrophysical Observation", "SAO 64000"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.45343967),
        dec: Angle.Degrees(+30.99093140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8246"},
        {"Hipparcos Number", "HIP 6406"},
        {"Smithsonian Astrophysical Observation", "SAO 54636"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.57568832),
        dec: Angle.Degrees(+30.99352392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108847"},
        {"Hipparcos Number", "HIP 61016"},
        {"Geneva Identification System", "GEN# +1.00108847"},
        {"Smithsonian Astrophysical Observation", "SAO 63028"},
        {"Wilson Evans Batten Catalogue", "WEB 10863"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.57347592),
        dec: Angle.Degrees(+30.99416027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209516"},
        {"Hipparcos Number", "HIP 108878"},
        {"Geneva Identification System", "GEN# +1.00209516"},
        {"Smithsonian Astrophysical Observation", "SAO 71984"},
        {"Wilson Evans Batten Catalogue", "WEB 19584"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.83561862),
        dec: Angle.Degrees(+30.99487434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281305"},
        {"Hipparcos Number", "HIP 18258"},
        {"Smithsonian Astrophysical Observation", "SAO 56804"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.58620549),
        dec: Angle.Degrees(+30.99859683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63013"},
        {"Geneva Identification System", "GEN# +0.03102421"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.70105523),
        dec: Angle.Degrees(+30.99868293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116744"},
    },
    visualMagnitude: 11.78,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.89982974),
        dec: Angle.Degrees(+30.99876138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166180"},
        {"Hipparcos Number", "HIP 88847"},
        {"Geneva Identification System", "GEN# +1.00166180"},
        {"Smithsonian Astrophysical Observation", "SAO 66668"},
        {"Wilson Evans Batten Catalogue", "WEB 15060"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.05154349),
        dec: Angle.Degrees(+30.99888814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113493"},
        {"Hipparcos Number", "HIP 63741"},
        {"Geneva Identification System", "GEN# +1.00113493"},
        {"Smithsonian Astrophysical Observation", "SAO 63318"},
        {"Wilson Evans Batten Catalogue", "WEB 11273"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.95432850),
        dec: Angle.Degrees(+31.00153268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112693"},
        {"Hipparcos Number", "HIP 63293"},
        {"Geneva Identification System", "GEN# +1.00112693"},
        {"Smithsonian Astrophysical Observation", "SAO 63272"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.55992212),
        dec: Angle.Degrees(+31.00166397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68164"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.32560889),
        dec: Angle.Degrees(+31.00180034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196608"},
        {"Hipparcos Number", "HIP 101764"},
        {"Smithsonian Astrophysical Observation", "SAO 70283"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.37978300),
        dec: Angle.Degrees(+31.00257619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56889"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.94017616),
        dec: Angle.Degrees(+31.00403721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48607"},
        {"Smithsonian Astrophysical Observation", "SAO 61752"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.68605708),
        dec: Angle.Degrees(+31.00443945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9070"},
        {"Hipparcos Number", "HIP 6978"},
        {"Geneva Identification System", "GEN# +1.00009070"},
        {"Smithsonian Astrophysical Observation", "SAO 54737"},
        {"Wilson Evans Batten Catalogue", "WEB 1510"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.46337870),
        dec: Angle.Degrees(+31.00733300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83024"},
        {"Smithsonian Astrophysical Observation", "SAO 65679"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.49348268),
        dec: Angle.Degrees(+31.00851741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33620"},
        {"Hipparcos Number", "HIP 24295"},
        {"Smithsonian Astrophysical Observation", "SAO 57747"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.20501451),
        dec: Angle.Degrees(+31.00912248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55695"},
        {"Smithsonian Astrophysical Observation", "SAO 62540"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.17910089),
        dec: Angle.Degrees(+31.00961031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106622",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15120 A"},
        {"Henry Draper", "HD 205617"},
        {"Hipparcos Number", "HIP 106622"},
        {"Smithsonian Astrophysical Observation", "SAO 71494"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.94057489),
        dec: Angle.Degrees(+31.00968226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127207"},
        {"Hipparcos Number", "HIP 70851"},
        {"Geneva Identification System", "GEN# +1.00127207"},
        {"Smithsonian Astrophysical Observation", "SAO 64170"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.32914488),
        dec: Angle.Degrees(+31.01006903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218300"},
        {"Hipparcos Number", "HIP 114101"},
        {"Smithsonian Astrophysical Observation", "SAO 72997"},
        {"Wilson Evans Batten Catalogue", "WEB 20262"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.64047808),
        dec: Angle.Degrees(+31.01104609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153145"},
        {"Hipparcos Number", "HIP 82893"},
        {"Fundamental Katalog 5th Edition", "FK5 5494"},
        {"Smithsonian Astrophysical Observation", "SAO 65661"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.09436424),
        dec: Angle.Degrees(+31.01127923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96087"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.03514480),
        dec: Angle.Degrees(+31.01169134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119035"},
        {"Hipparcos Number", "HIP 66690"},
        {"Geneva Identification System", "GEN# +1.00119035"},
        {"Smithsonian Astrophysical Observation", "SAO 63676"},
        {"Wilson Evans Batten Catalogue", "WEB 11764"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.06511630),
        dec: Angle.Degrees(+31.01181276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44169"},
        {"Hipparcos Number", "HIP 30250"},
        {"Smithsonian Astrophysical Observation", "SAO 59013"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.45040982),
        dec: Angle.Degrees(+31.01479284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221830"},
        {"Hipparcos Number", "HIP 116421"},
        {"Cincinnati Publication", "Ci 20 1435"},
        {"Geneva Identification System", "GEN# +1.00221830"},
        {"Smithsonian Astrophysical Observation", "SAO 73358"},
        {"Wilson Evans Batten Catalogue", "WEB 20566"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.86886083),
        dec: Angle.Degrees(+31.01655715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 540.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 253.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3054"},
        {"Cincinnati Publication", "Ci 18 79"},
        {"Geneva Identification System", "GEN# +0.03000089"},
        {"Smithsonian Astrophysical Observation", "SAO 54052"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.69844701),
        dec: Angle.Degrees(+31.01929218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -245.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166382"},
        {"Hipparcos Number", "HIP 88923"},
        {"Geneva Identification System", "GEN# +1.00166382"},
        {"Smithsonian Astrophysical Observation", "SAO 66680"},
        {"Wilson Evans Batten Catalogue", "WEB 15082"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.27588386),
        dec: Angle.Degrees(+31.02115052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181119"},
        {"Hipparcos Number", "HIP 94852"},
        {"Celescope Catalog", "CEL 4731"},
        {"Geneva Identification System", "GEN# +1.00181119"},
        {"Smithsonian Astrophysical Observation", "SAO 68095"},
        {"Wilson Evans Batten Catalogue", "WEB 16555"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.50355398),
        dec: Angle.Degrees(+31.02184029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9087",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1548 AB"},
        {"Henry Draper", "HD 11849"},
        {"Hipparcos Number", "HIP 9087"},
        {"Smithsonian Astrophysical Observation", "SAO 55122"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.25555680),
        dec: Angle.Degrees(+31.02289015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334421"},
        {"Hipparcos Number", "HIP 100986"},
        {"Smithsonian Astrophysical Observation", "SAO 70072"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.12529285),
        dec: Angle.Degrees(+31.02311946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154889"},
        {"Hipparcos Number", "HIP 83739"},
        {"Smithsonian Astrophysical Observation", "SAO 65796"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.72146424),
        dec: Angle.Degrees(+31.02394520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282373"},
        {"Hipparcos Number", "HIP 21858"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.50654309),
        dec: Angle.Degrees(+31.02695927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10500"},
        {"Hipparcos Number", "HIP 8017"},
        {"Smithsonian Astrophysical Observation", "SAO 54926"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.73223852),
        dec: Angle.Degrees(+31.02728088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219699"},
        {"Hipparcos Number", "HIP 115018"},
        {"Geneva Identification System", "GEN# +1.00219699"},
        {"Smithsonian Astrophysical Observation", "SAO 73148"},
        {"Wilson Evans Batten Catalogue", "WEB 20375"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.42590996),
        dec: Angle.Degrees(+31.03004214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40254"},
        {"Hipparcos Number", "HIP 28324"},
        {"Geneva Identification System", "GEN# +1.00040254"},
        {"Smithsonian Astrophysical Observation", "SAO 58628"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.76211185),
        dec: Angle.Degrees(+31.03024751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15266"},
        {"Cincinnati Publication", "Ci 18 431"},
        {"Geneva Identification System", "GEN# +0.03000516"},
        {"Smithsonian Astrophysical Observation", "SAO 56314"},
        {"Wilson Evans Batten Catalogue", "WEB 2941"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.23445158),
        dec: Angle.Degrees(+31.03112823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83630"},
        {"Smithsonian Astrophysical Observation", "SAO 65779"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.37631080),
        dec: Angle.Degrees(+31.03120611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 184.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17542"},
        {"Hipparcos Number", "HIP 13186"},
        {"Smithsonian Astrophysical Observation", "SAO 55916"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.42196118),
        dec: Angle.Degrees(+31.03300154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63018"},
        {"Geneva Identification System", "GEN# +0.03102422"},
        {"Smithsonian Astrophysical Observation", "SAO 63248"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.71654780),
        dec: Angle.Degrees(+31.03340982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108078"},
        {"Hipparcos Number", "HIP 60555"},
        {"Geneva Identification System", "GEN# +1.00108078"},
        {"Smithsonian Astrophysical Observation", "SAO 62988"},
        {"Wilson Evans Batten Catalogue", "WEB 10767"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.20462548),
        dec: Angle.Degrees(+31.03385347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40588"},
        {"Hipparcos Number", "HIP 28517"},
        {"Geneva Identification System", "GEN# +1.00040588"},
        {"Smithsonian Astrophysical Observation", "SAO 58657"},
        {"Wilson Evans Batten Catalogue", "WEB 5575"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.29189835),
        dec: Angle.Degrees(+31.03451677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49773"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.40442697),
        dec: Angle.Degrees(+31.03534355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180614"},
        {"Hipparcos Number", "HIP 94677"},
        {"Smithsonian Astrophysical Observation", "SAO 68049"},
        {"Wilson Evans Batten Catalogue", "WEB 16507"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.98381295),
        dec: Angle.Degrees(+31.03572591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20437"},
        {"Hipparcos Number", "HIP 15385"},
        {"Smithsonian Astrophysical Observation", "SAO 56335"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.59707414),
        dec: Angle.Degrees(+31.03621419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162467"},
        {"Hipparcos Number", "HIP 87263"},
        {"Geneva Identification System", "GEN# +1.00162467"},
        {"Smithsonian Astrophysical Observation", "SAO 66359"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.46891789),
        dec: Angle.Degrees(+31.03734949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215793"},
        {"Hipparcos Number", "HIP 112502"},
        {"Smithsonian Astrophysical Observation", "SAO 72720"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.83357001),
        dec: Angle.Degrees(+31.03742156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19060"},
        {"Hipparcos Number", "HIP 14340"},
        {"Smithsonian Astrophysical Observation", "SAO 56137"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.23150820),
        dec: Angle.Degrees(+31.03900775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94701"},
        {"Hipparcos Number", "HIP 53473"},
        {"Geneva Identification System", "GEN# +1.00094701"},
        {"Smithsonian Astrophysical Observation", "SAO 62317"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.07778926),
        dec: Angle.Degrees(+31.03966630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12795"},
        {"Smithsonian Astrophysical Observation", "SAO 55828"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.10893188),
        dec: Angle.Degrees(+31.03974242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334032"},
        {"Hipparcos Number", "HIP 100141"},
        {"Geneva Identification System", "GEN# +8.02300030"},
    },
    visualMagnitude: 11.32,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.70506494),
        dec: Angle.Degrees(+31.04082875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91116"},
        {"Hipparcos Number", "HIP 51543"},
        {"Smithsonian Astrophysical Observation", "SAO 62098"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.91076816),
        dec: Angle.Degrees(+31.04163425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144286"},
        {"Hipparcos Number", "HIP 78700"},
        {"Smithsonian Astrophysical Observation", "SAO 65056"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.97964495),
        dec: Angle.Degrees(+31.04303928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18142"},
        {"Hipparcos Number", "HIP 13645"},
        {"Smithsonian Astrophysical Observation", "SAO 56009"},
        {"Wilson Evans Batten Catalogue", "WEB 2709"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.92197522),
        dec: Angle.Degrees(+31.04312605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13933"},
        {"Hipparcos Number", "HIP 10590"},
        {"Geneva Identification System", "GEN# +1.00013933"},
        {"Smithsonian Astrophysical Observation", "SAO 55406"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.09230837),
        dec: Angle.Degrees(+31.04369603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18350",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2859 A"},
        {"Henry Draper", "HD 24534"},
        {"Hipparcos Number", "HIP 18350"},
        {"Fundamental Katalog 5th Edition", "FK5 4355"},
        {"Geneva Identification System", "GEN# +1.00024534"},
        {"Smithsonian Astrophysical Observation", "SAO 56815"},
        {"Wilson Evans Batten Catalogue", "WEB 3545"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.84616124),
        dec: Angle.Degrees(+31.04584808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49057"},
        {"Hipparcos Number", "HIP 32583"},
        {"Smithsonian Astrophysical Observation", "SAO 59491"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.98478362),
        dec: Angle.Degrees(+31.04682752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182616"},
        {"Hipparcos Number", "HIP 95388"},
        {"Smithsonian Astrophysical Observation", "SAO 68260"},
        {"Wilson Evans Batten Catalogue", "WEB 16671"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.07501270),
        dec: Angle.Degrees(+31.04732164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243861"},
        {"Hipparcos Number", "HIP 25614"},
        {"Smithsonian Astrophysical Observation", "SAO 58074"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.08347346),
        dec: Angle.Degrees(+31.04876287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41292"},
        {"Smithsonian Astrophysical Observation", "SAO 60799"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.36975812),
        dec: Angle.Degrees(+31.04976082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105388"},
        {"Hipparcos Number", "HIP 59174"},
        {"Geneva Identification System", "GEN# +1.00105388"},
        {"Smithsonian Astrophysical Observation", "SAO 62851"},
        {"Wilson Evans Batten Catalogue", "WEB 10526"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.02363408),
        dec: Angle.Degrees(+31.04981568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86825"},
        {"Smithsonian Astrophysical Observation", "SAO 66292"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.12650384),
        dec: Angle.Degrees(+31.04995585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13053",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2128 AB"},
        {"Henry Draper", "HD 17329"},
        {"Hipparcos Number", "HIP 13053"},
        {"Smithsonian Astrophysical Observation", "SAO 55886"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.93806496),
        dec: Angle.Degrees(+31.05294159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115634"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.37368336),
        dec: Angle.Degrees(+31.05337854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216717"},
        {"Hipparcos Number", "HIP 113149"},
        {"Smithsonian Astrophysical Observation", "SAO 72834"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.69088691),
        dec: Angle.Degrees(+31.05467694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45573"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.32784129),
        dec: Angle.Degrees(+31.05595521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31706"},
        {"Hipparcos Number", "HIP 23187"},
        {"Geneva Identification System", "GEN# +1.00031706"},
        {"Smithsonian Astrophysical Observation", "SAO 57553"},
        {"Wilson Evans Batten Catalogue", "WEB 4501"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.84627941),
        dec: Angle.Degrees(+31.05704518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61032"},
        {"Smithsonian Astrophysical Observation", "SAO 63032"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.62927214),
        dec: Angle.Degrees(+31.05744200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85373"},
        {"Cincinnati Publication", "Ci 18 2326"},
        {"Smithsonian Astrophysical Observation", "SAO 66050"},
        {"Wilson Evans Batten Catalogue", "WEB 14418"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.67355805),
        dec: Angle.Degrees(+31.05926495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -358.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257132"},
        {"Henry Draper 2", "HD 257133"},
        {"Hipparcos Number", "HIP 30697"},
        {"Smithsonian Astrophysical Observation", "SAO 59089"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.74902609),
        dec: Angle.Degrees(+31.05933458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61421"},
        {"Geneva Identification System", "GEN# +0.03102385"},
        {"Smithsonian Astrophysical Observation", "SAO 63079"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.78463874),
        dec: Angle.Degrees(+31.06286899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133873"},
        {"Hipparcos Number", "HIP 73868"},
        {"Smithsonian Astrophysical Observation", "SAO 64497"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.45509368),
        dec: Angle.Degrees(+31.06476888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38909"},
        {"Hipparcos Number", "HIP 27582"},
        {"Celescope Catalog", "CEL 997"},
        {"Geneva Identification System", "GEN# +1.00038909"},
        {"Smithsonian Astrophysical Observation", "SAO 58493"},
        {"Wilson Evans Batten Catalogue", "WEB 5414"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.62026821),
        dec: Angle.Degrees(+31.06521240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86073",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86073"},
        {"Smithsonian Astrophysical Observation", "SAO 66157"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.86687853),
        dec: Angle.Degrees(+31.06533859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9707"},
        {"Smithsonian Astrophysical Observation", "SAO 55245"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.21458395),
        dec: Angle.Degrees(+31.06669313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168851"},
        {"Hipparcos Number", "HIP 89895"},
        {"Smithsonian Astrophysical Observation", "SAO 66879"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.14337334),
        dec: Angle.Degrees(+31.06683363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115045"},
        {"Hipparcos Number", "HIP 64581"},
        {"Geneva Identification System", "GEN# +1.00115045"},
        {"Smithsonian Astrophysical Observation", "SAO 63422"},
        {"Wilson Evans Batten Catalogue", "WEB 11424"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.55114049),
        dec: Angle.Degrees(+31.06790210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19925"},
        {"Hipparcos Number", "HIP 14988"},
        {"Smithsonian Astrophysical Observation", "SAO 56259"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.29400542),
        dec: Angle.Degrees(+31.06909700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42150"},
        {"Smithsonian Astrophysical Observation", "SAO 60910"},
    },
    visualMagnitude: 10.35,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.87298552),
        dec: Angle.Degrees(+31.07185122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1281"},
        {"Hipparcos Number", "HIP 1367"},
        {"Smithsonian Astrophysical Observation", "SAO 53778"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.27365648),
        dec: Angle.Degrees(+31.07421533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158226"},
        {"Hipparcos Number", "HIP 85378"},
        {"Cincinnati Publication", "Ci 20 1039"},
        {"Cincinnati Publication 2", "Ci 18 2328"},
        {"Geneva Identification System", "GEN# +1.10158226"},
        {"Geneva Identification System 2", "GEN# +1.00158226A"},
        {"Smithsonian Astrophysical Observation", "SAO 66051"},
        {"Wilson Evans Batten Catalogue", "WEB 14416"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.68101118),
        dec: Angle.Degrees(+31.07701161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -361.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85016"},
        {"Hipparcos Number", "HIP 48212"},
        {"Geneva Identification System", "GEN# +1.00085016"},
        {"Smithsonian Astrophysical Observation", "SAO 61705"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.44431744),
        dec: Angle.Degrees(+31.07711945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224216"},
        {"Hipparcos Number", "HIP 117997"},
        {"Geneva Identification System", "GEN# +1.00224216"},
        {"Smithsonian Astrophysical Observation", "SAO 73618"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.02003127),
        dec: Angle.Degrees(+31.07806242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113338"},
        {"Hipparcos Number", "HIP 63645"},
        {"Smithsonian Astrophysical Observation", "SAO 63316"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.66146584),
        dec: Angle.Degrees(+31.07863551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5997"},
        {"Hipparcos Number", "HIP 4803"},
        {"Smithsonian Astrophysical Observation", "SAO 54358"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.41362399),
        dec: Angle.Degrees(+31.08050316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82864"},
        {"Hipparcos Number", "HIP 47064"},
        {"Geneva Identification System", "GEN# +1.00082864"},
        {"Smithsonian Astrophysical Observation", "SAO 61585"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.86994503),
        dec: Angle.Degrees(+31.08189400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94938"},
        {"Hipparcos Number", "HIP 53606"},
        {"Geneva Identification System", "GEN# +1.00094938"},
        {"Smithsonian Astrophysical Observation", "SAO 62332"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.49640244),
        dec: Angle.Degrees(+31.08254608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45307"},
        {"Smithsonian Astrophysical Observation", "SAO 61340"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.51512329),
        dec: Angle.Degrees(+31.08287003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149672"},
        {"Hipparcos Number", "HIP 81196"},
        {"Geneva Identification System", "GEN# +1.00149672"},
        {"Smithsonian Astrophysical Observation", "SAO 65404"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.77785959),
        dec: Angle.Degrees(+31.08292839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113621",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16443 AB"},
        {"Henry Draper", "HD 217477"},
        {"Hipparcos Number", "HIP 113621"},
        {"Geneva Identification System", "GEN# +1.00217477J"},
        {"Renson", "Renson 59990"},
        {"Smithsonian Astrophysical Observation", "SAO 72924"},
        {"Wilson Evans Batten Catalogue", "WEB 20193"},
    },
    visualMagnitude: 6.60,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.17668593),
        dec: Angle.Degrees(+31.08296433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56485"},
        {"Wilson Evans Batten Catalogue", "WEB 10151"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.70233182),
        dec: Angle.Degrees(+31.08552121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49441",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7632 AB"},
        {"Henry Draper", "HD 87443"},
        {"Hipparcos Number", "HIP 49441"},
        {"Smithsonian Astrophysical Observation", "SAO 61853"},
        {"Wilson Evans Batten Catalogue", "WEB 9130"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.41086202),
        dec: Angle.Degrees(+31.08702023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55481"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.44311936),
        dec: Angle.Degrees(+31.08772897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217888"},
        {"Hipparcos Number", "HIP 113873"},
        {"Smithsonian Astrophysical Observation", "SAO 72964"},
        {"Wilson Evans Batten Catalogue", "WEB 20228"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.91263048),
        dec: Angle.Degrees(+31.08795215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94205"},
        {"Smithsonian Astrophysical Observation", "SAO 67917"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.68401973),
        dec: Angle.Degrees(+31.08811208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282615"},
        {"Hipparcos Number", "HIP 23023"},
        {"Smithsonian Astrophysical Observation", "SAO 57523"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.26409854),
        dec: Angle.Degrees(+31.09265001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154917"},
        {"Hipparcos Number", "HIP 83754"},
        {"Smithsonian Astrophysical Observation", "SAO 65797"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.76841770),
        dec: Angle.Degrees(+31.09317786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149957"},
        {"Hipparcos Number", "HIP 81348"},
        {"Cincinnati Publication", "Ci 20 1004"},
        {"Cincinnati Publication 2", "Ci 18 2217"},
        {"Geneva Identification System", "GEN# +1.00149957"},
        {"Smithsonian Astrophysical Observation", "SAO 65431"},
        {"Wilson Evans Batten Catalogue", "WEB 13749"},
        {"Wilson Evans Batten Catalogue 2", "WEB 13748"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.20349414),
        dec: Angle.Degrees(+31.09789229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 340.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -447.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70488"},
        {"Smithsonian Astrophysical Observation", "SAO 64132"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.26642599),
        dec: Angle.Degrees(+31.09797045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8839"},
        {"Hipparcos Number", "HIP 6814"},
        {"Geneva Identification System", "GEN# +1.00008839"},
        {"Smithsonian Astrophysical Observation", "SAO 54708"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.91414057),
        dec: Angle.Degrees(+31.10046176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112611",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16278 AB"},
        {"Henry Draper", "HD 215955"},
        {"Hipparcos Number", "HIP 112611"},
        {"Smithsonian Astrophysical Observation", "SAO 72737"},
        {"Wilson Evans Batten Catalogue", "WEB 20077"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.11417211),
        dec: Angle.Degrees(+31.10069537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105496"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.50170540),
        dec: Angle.Degrees(+31.10078421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 375.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 177.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61980",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61980"},
    },
    visualMagnitude: 11.85,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.51937417),
        dec: Angle.Degrees(+31.10158249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59667"},
        {"Hipparcos Number", "HIP 36651"},
        {"Smithsonian Astrophysical Observation", "SAO 60158"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.06611717),
        dec: Angle.Degrees(+31.10208548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118872"},
        {"Hipparcos Number", "HIP 66599"},
        {"Geneva Identification System", "GEN# +1.00118872"},
        {"Smithsonian Astrophysical Observation", "SAO 63662"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.77791736),
        dec: Angle.Degrees(+31.10446928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128966"},
        {"Hipparcos Number", "HIP 71649"},
        {"Smithsonian Astrophysical Observation", "SAO 64257"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.82647052),
        dec: Angle.Degrees(+31.10910715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37014"},
        {"Smithsonian Astrophysical Observation", "SAO 60220"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.11188160),
        dec: Angle.Degrees(+31.10919312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37761",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6323 AB"},
        {"Henry Draper", "HD 62319"},
        {"Hipparcos Number", "HIP 37761"},
        {"Smithsonian Astrophysical Observation", "SAO 60312"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.15880045),
        dec: Angle.Degrees(+31.11395052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17433"},
        {"Hipparcos Number", "HIP 13118"},
        {"Cincinnati Publication", "Ci 18 359"},
        {"Geneva Identification System", "GEN# +1.00017433"},
        {"Smithsonian Astrophysical Observation", "SAO 55899"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.18157204),
        dec: Angle.Degrees(+31.11561362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203767"},
        {"Hipparcos Number", "HIP 105613"},
        {"Smithsonian Astrophysical Observation", "SAO 71275"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.86838501),
        dec: Angle.Degrees(+31.11625232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3790"},
        {"Hipparcos Number", "HIP 3214"},
        {"Geneva Identification System", "GEN# +1.00003790"},
        {"Smithsonian Astrophysical Observation", "SAO 54075"},
        {"Wilson Evans Batten Catalogue", "WEB 577"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.21930456),
        dec: Angle.Degrees(+31.11650674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47573"},
        {"Hipparcos Number", "HIP 31954"},
        {"Smithsonian Astrophysical Observation", "SAO 59350"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.16897545),
        dec: Angle.Degrees(+31.11664840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190047"},
        {"Hipparcos Number", "HIP 98630"},
        {"Geneva Identification System", "GEN# +1.00190047"},
        {"Smithsonian Astrophysical Observation", "SAO 69283"},
        {"Wilson Evans Batten Catalogue", "WEB 17442"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.48143263),
        dec: Angle.Degrees(+31.11755860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209935"},
        {"Hipparcos Number", "HIP 109123"},
        {"Smithsonian Astrophysical Observation", "SAO 72028"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.55557824),
        dec: Angle.Degrees(+31.11983139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22418"},
        {"Hipparcos Number", "HIP 16900"},
        {"Geneva Identification System", "GEN# +1.00022418"},
        {"Smithsonian Astrophysical Observation", "SAO 56588"},
        {"Wilson Evans Batten Catalogue", "WEB 3216"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.36676528),
        dec: Angle.Degrees(+31.12017469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162881"},
        {"Hipparcos Number", "HIP 87431"},
        {"Smithsonian Astrophysical Observation", "SAO 66393"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.00123798),
        dec: Angle.Degrees(+31.12044858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50299"},
        {"Hipparcos Number", "HIP 33134"},
        {"Geneva Identification System", "GEN# +1.00050299"},
        {"Smithsonian Astrophysical Observation", "SAO 59591"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.48829070),
        dec: Angle.Degrees(+31.12198764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190469"},
        {"Hipparcos Number", "HIP 98796"},
        {"Geneva Identification System", "GEN# +1.00190469"},
        {"Smithsonian Astrophysical Observation", "SAO 69337"},
        {"Wilson Evans Batten Catalogue", "WEB 17508"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.98449159),
        dec: Angle.Degrees(+31.12378182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18579"},
        {"Hipparcos Number", "HIP 14002"},
        {"Geneva Identification System", "GEN# +1.00018579"},
        {"Smithsonian Astrophysical Observation", "SAO 56076"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.07090515),
        dec: Angle.Degrees(+31.12504035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22360"},
        {"Hipparcos Number", "HIP 16872"},
        {"Geneva Identification System", "GEN# +1.00022360"},
        {"Smithsonian Astrophysical Observation", "SAO 56584"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.27996841),
        dec: Angle.Degrees(+31.12527020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213607"},
        {"Hipparcos Number", "HIP 111235"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.04288100),
        dec: Angle.Degrees(+31.12529347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87818"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.08866798),
        dec: Angle.Degrees(+31.12682104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20367"},
        {"Hipparcos Number", "HIP 15323"},
        {"Geneva Identification System", "GEN# +1.00020367"},
        {"Smithsonian Astrophysical Observation", "SAO 56323"},
        {"Wilson Evans Batten Catalogue", "WEB 2949"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.41715145),
        dec: Angle.Degrees(+31.12718548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195"},
        {"Hipparcos Number", "HIP 563"},
        {"Smithsonian Astrophysical Observation", "SAO 53647"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.71117886),
        dec: Angle.Degrees(+31.13044847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161550"},
        {"Hipparcos Number", "HIP 86861"},
        {"Smithsonian Astrophysical Observation", "SAO 66298"},
        {"Wilson Evans Batten Catalogue", "WEB 14651"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.21176459),
        dec: Angle.Degrees(+31.13182216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58428"},
        {"Geneva Identification System", "GEN# +0.03102316"},
        {"Smithsonian Astrophysical Observation", "SAO 62782"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.70654551),
        dec: Angle.Degrees(+31.13225489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58889"},
        {"Geneva Identification System", "GEN# +0.03102326"},
        {"Smithsonian Astrophysical Observation", "SAO 62825"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.16702631),
        dec: Angle.Degrees(+31.13321444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11961"},
        {"Hipparcos Number", "HIP 9171"},
        {"Fundamental Katalog 5th Edition", "FK5 4178"},
        {"Smithsonian Astrophysical Observation", "SAO 55147"},
        {"Wilson Evans Batten Catalogue", "WEB 1928"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.51584088),
        dec: Angle.Degrees(+31.13449182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66008"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.99308550),
        dec: Angle.Degrees(+31.13456110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60186"},
    },
    visualMagnitude: 11.62,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.13962141),
        dec: Angle.Degrees(+31.13463231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173239"},
        {"Hipparcos Number", "HIP 91790"},
        {"Celescope Catalog", "CEL 4644"},
        {"Geneva Identification System", "GEN# +1.00173239"},
        {"Smithsonian Astrophysical Observation", "SAO 67279"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.75628604),
        dec: Angle.Degrees(+31.13561040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129516"},
        {"Hipparcos Number", "HIP 71888"},
        {"Smithsonian Astrophysical Observation", "SAO 64281"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.54739964),
        dec: Angle.Degrees(+31.13676679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13038 C"},
        {"Hipparcos Number", "HIP 97733"},
        {"Geneva Identification System", "GEN# +1.00187981C"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.92221616),
        dec: Angle.Degrees(+31.13779626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10419"},
        {"Hipparcos Number", "HIP 7960"},
        {"Smithsonian Astrophysical Observation", "SAO 54917"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.55245688),
        dec: Angle.Degrees(+31.13962418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16090"},
        {"Hipparcos Number", "HIP 12099"},
        {"Geneva Identification System", "GEN# +1.00016090"},
        {"Smithsonian Astrophysical Observation", "SAO 55691"},
        {"Wilson Evans Batten Catalogue", "WEB 2489"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.97771484),
        dec: Angle.Degrees(+31.14008895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27323"},
        {"Hipparcos Number", "HIP 20227"},
        {"Smithsonian Astrophysical Observation", "SAO 57165"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.02610834),
        dec: Angle.Degrees(+31.14108605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97734",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13038 A"},
        {"Henry Draper", "HD 187981"},
        {"Hipparcos Number", "HIP 97734"},
        {"Geneva Identification System", "GEN# +1.00187981A"},
        {"Smithsonian Astrophysical Observation", "SAO 68974"},
        {"Wilson Evans Batten Catalogue", "WEB 17192"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.92240246),
        dec: Angle.Degrees(+31.14129745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35239"},
        {"Hipparcos Number", "HIP 25291"},
        {"Celescope Catalog", "CEL 674"},
        {"Geneva Identification System", "GEN# +1.00035239"},
        {"Smithsonian Astrophysical Observation", "SAO 57988"},
        {"Wilson Evans Batten Catalogue", "WEB 4906"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.16052742),
        dec: Angle.Degrees(+31.14316298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132048"},
        {"Hipparcos Number", "HIP 73079"},
        {"Smithsonian Astrophysical Observation", "SAO 64412"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.03547447),
        dec: Angle.Degrees(+31.14321759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168693"},
        {"Hipparcos Number", "HIP 89819"},
        {"Smithsonian Astrophysical Observation", "SAO 66864"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.95429514),
        dec: Angle.Degrees(+31.14482052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59267"},
        {"Hipparcos Number", "HIP 36484"},
        {"Geneva Identification System", "GEN# +1.00059267"},
        {"Smithsonian Astrophysical Observation", "SAO 60139"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.60431189),
        dec: Angle.Degrees(+31.14516255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214740"},
        {"Hipparcos Number", "HIP 111878"},
        {"Smithsonian Astrophysical Observation", "SAO 72586"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.92786467),
        dec: Angle.Degrees(+31.14573846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175589"},
        {"Hipparcos Number", "HIP 92832"},
        {"Smithsonian Astrophysical Observation", "SAO 67563"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.71817443),
        dec: Angle.Degrees(+31.14716732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211922"},
        {"Hipparcos Number", "HIP 110261"},
        {"Renson", "Renson 58830"},
        {"Smithsonian Astrophysical Observation", "SAO 72239"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.01405582),
        dec: Angle.Degrees(+31.14842834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117203"},
        {"Hipparcos Number", "HIP 65709"},
        {"Fundamental Katalog 5th Edition", "FK5 1350"},
        {"Geneva Identification System", "GEN# +1.00117203"},
        {"Smithsonian Astrophysical Observation", "SAO 63556"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.07813396),
        dec: Angle.Degrees(+31.14923050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70077"},
        {"Geneva Identification System", "GEN# +0.03102608"},
        {"Smithsonian Astrophysical Observation", "SAO 64078"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.10628590),
        dec: Angle.Degrees(+31.14965185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51043"},
        {"Smithsonian Astrophysical Observation", "SAO 62036"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.42529982),
        dec: Angle.Degrees(+31.14986213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218852"},
        {"Hipparcos Number", "HIP 114471"},
        {"Smithsonian Astrophysical Observation", "SAO 73062"},
        {"Wilson Evans Batten Catalogue", "WEB 20316"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.74312159),
        dec: Angle.Degrees(+31.15086099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34883"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.27346187),
        dec: Angle.Degrees(+31.15261714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202813"},
        {"Hipparcos Number", "HIP 105114"},
        {"Smithsonian Astrophysical Observation", "SAO 71164"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.39286719),
        dec: Angle.Degrees(+31.15484054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158974"},
        {"Hipparcos Number", "HIP 85715"},
        {"Geneva Identification System", "GEN# +1.00158974"},
        {"Smithsonian Astrophysical Observation", "SAO 66103"},
        {"Wilson Evans Batten Catalogue", "WEB 14465"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.73071285),
        dec: Angle.Degrees(+31.15810073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172396"},
        {"Hipparcos Number", "HIP 91423"},
        {"Smithsonian Astrophysical Observation", "SAO 67203"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.67367739),
        dec: Angle.Degrees(+31.15821953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35033"},
        {"Hipparcos Number", "HIP 25175"},
        {"Celescope Catalog", "CEL 656"},
        {"Geneva Identification System", "GEN# +1.00035033"},
        {"Renson", "Renson 8948"},
        {"Smithsonian Astrophysical Observation", "SAO 57960"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.77379978),
        dec: Angle.Degrees(+31.15853994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54619",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8082 AB"},
        {"Hipparcos Number", "HIP 54619"},
        {"Smithsonian Astrophysical Observation", "SAO 62436"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.67473750),
        dec: Angle.Degrees(+31.15914585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73278"},
        {"Hipparcos Number", "HIP 42391"},
        {"Geneva Identification System", "GEN# +1.00073278"},
        {"Smithsonian Astrophysical Observation", "SAO 60947"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.66447835),
        dec: Angle.Degrees(+31.16074746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63580",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63580"},
        {"Geneva Identification System", "GEN# +0.03102439"},
        {"Smithsonian Astrophysical Observation", "SAO 63307"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.42960478),
        dec: Angle.Degrees(+31.16156565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83069"},
        {"Hipparcos Number", "HIP 47168"},
        {"Fundamental Katalog 5th Edition", "FK5 2765"},
        {"Geneva Identification System", "GEN# +1.00083069"},
        {"Smithsonian Astrophysical Observation", "SAO 61594"},
        {"Wilson Evans Batten Catalogue", "WEB 8870"},
    },
    visualMagnitude: 5.57,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.17854374),
        dec: Angle.Degrees(+31.16184064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221851"},
        {"Hipparcos Number", "HIP 116416"},
        {"Cincinnati Publication", "Ci 18 3094"},
        {"Geneva Identification System", "GEN# +1.00221851"},
        {"Smithsonian Astrophysical Observation", "SAO 73357"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.85726949),
        dec: Angle.Degrees(+31.16198982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242992"},
        {"Hipparcos Number", "HIP 25169"},
        {"Geneva Identification System", "GEN# +1.00242992"},
        {"Smithsonian Astrophysical Observation", "SAO 57959"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.76670134),
        dec: Angle.Degrees(+31.16213005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30825"},
        {"Hipparcos Number", "HIP 22633"},
        {"Geneva Identification System", "GEN# +1.00030825"},
        {"Smithsonian Astrophysical Observation", "SAO 57468"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.04401002),
        dec: Angle.Degrees(+31.16442501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32976"},
        {"Hipparcos Number", "HIP 23914"},
        {"Smithsonian Astrophysical Observation", "SAO 57672"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.07871524),
        dec: Angle.Degrees(+31.16760848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47945"},
        {"Smithsonian Astrophysical Observation", "SAO 61674"},
    },
    visualMagnitude: 9.76,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.55404271),
        dec: Angle.Degrees(+31.16776515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17306"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.57317429),
        dec: Angle.Degrees(+31.16794527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24167"},
        {"Hipparcos Number", "HIP 18094"},
        {"Geneva Identification System", "GEN# +1.00024167"},
        {"Smithsonian Astrophysical Observation", "SAO 56762"},
        {"Wilson Evans Batten Catalogue", "WEB 3492"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.01855904),
        dec: Angle.Degrees(+31.16866588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39259"},
        {"Smithsonian Astrophysical Observation", "SAO 60521"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.42604713),
        dec: Angle.Degrees(+31.17265314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155525"},
        {"Hipparcos Number", "HIP 84045"},
        {"Smithsonian Astrophysical Observation", "SAO 65848"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.73577007),
        dec: Angle.Degrees(+31.17400466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114437"},
        {"Fundamental Katalog 5th Edition", "FK5 6046"},
        {"Smithsonian Astrophysical Observation", "SAO 73060"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.64215667),
        dec: Angle.Degrees(+31.17455176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144237"},
        {"Hipparcos Number", "HIP 78666"},
        {"Smithsonian Astrophysical Observation", "SAO 65051"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.89386497),
        dec: Angle.Degrees(+31.17677676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133964"},
        {"Hipparcos Number", "HIP 73918"},
        {"Geneva Identification System", "GEN# +1.00133964"},
        {"Smithsonian Astrophysical Observation", "SAO 64501"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.58851901),
        dec: Angle.Degrees(+31.17693713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2313"},
        {"Hipparcos Number", "HIP 2144"},
        {"Smithsonian Astrophysical Observation", "SAO 53905"},
        {"Wilson Evans Batten Catalogue", "WEB 398"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.78252472),
        dec: Angle.Degrees(+31.17715128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220118"},
        {"Hipparcos Number", "HIP 115292"},
        {"Smithsonian Astrophysical Observation", "SAO 73191"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.24408637),
        dec: Angle.Degrees(+31.17826076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4975"},
        {"Smithsonian Astrophysical Observation", "SAO 54385"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.93313185),
        dec: Angle.Degrees(+31.17891249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117291"},
        {"Smithsonian Astrophysical Observation", "SAO 73503"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.74000901),
        dec: Angle.Degrees(+31.18026335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50150"},
        {"Smithsonian Astrophysical Observation", "SAO 61944"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.56784255),
        dec: Angle.Degrees(+31.18060254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81461"},
        {"Hipparcos Number", "HIP 46302"},
        {"Geneva Identification System", "GEN# +1.00081461"},
        {"Smithsonian Astrophysical Observation", "SAO 61492"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.64083000),
        dec: Angle.Degrees(+31.18297274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59850"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.09871051),
        dec: Angle.Degrees(+31.18379766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201078"},
        {"Hipparcos Number", "HIP 104185"},
        {"Fundamental Katalog 5th Edition", "FK5 3687"},
        {"Geneva Identification System", "GEN# +1.00201078"},
        {"Smithsonian Astrophysical Observation", "SAO 70917"},
        {"Wilson Evans Batten Catalogue", "WEB 18978"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.62600709),
        dec: Angle.Degrees(+31.18466842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332332"},
        {"Hipparcos Number", "HIP 101018"},
        {"Smithsonian Astrophysical Observation", "SAO 70082"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.19530076),
        dec: Angle.Degrees(+31.18849846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1968"},
        {"Hipparcos Number", "HIP 1903"},
        {"Renson", "Renson 440"},
        {"Smithsonian Astrophysical Observation", "SAO 53861"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.01379035),
        dec: Angle.Degrees(+31.18851521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120420"},
        {"Hipparcos Number", "HIP 67384"},
        {"Fundamental Katalog 5th Edition", "FK5 3096"},
        {"Geneva Identification System", "GEN# +1.00120420"},
        {"Smithsonian Astrophysical Observation", "SAO 63760"},
        {"Wilson Evans Batten Catalogue", "WEB 11851"},
    },
    visualMagnitude: 5.61,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.16141241),
        dec: Angle.Degrees(+31.19011458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160216"},
        {"Hipparcos Number", "HIP 86229"},
        {"Smithsonian Astrophysical Observation", "SAO 66185"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.32996640),
        dec: Angle.Degrees(+31.19066456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68519"},
        {"Smithsonian Astrophysical Observation", "SAO 63893"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.40995779),
        dec: Angle.Degrees(+31.19286317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88530"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.17223704),
        dec: Angle.Degrees(+31.19383769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124586"},
        {"Hipparcos Number", "HIP 69509"},
        {"Geneva Identification System", "GEN# +1.00124586"},
        {"Smithsonian Astrophysical Observation", "SAO 63999"},
        {"Wilson Evans Batten Catalogue", "WEB 12111"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.44268939),
        dec: Angle.Degrees(+31.19531910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75667"},
    },
    visualMagnitude: 11.43,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.89070203),
        dec: Angle.Degrees(+31.19532500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78139"},
        {"Hipparcos Number", "HIP 44781"},
        {"Smithsonian Astrophysical Observation", "SAO 61274"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.90735741),
        dec: Angle.Degrees(+31.20062679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160677"},
        {"Hipparcos Number", "HIP 86462"},
        {"Geneva Identification System", "GEN# +1.00160677"},
        {"Smithsonian Astrophysical Observation", "SAO 66231"},
        {"Wilson Evans Batten Catalogue", "WEB 14585"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.98968601),
        dec: Angle.Degrees(+31.20244310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58190"},
        {"Geneva Identification System", "GEN# +0.03202205"},
        {"Smithsonian Astrophysical Observation", "SAO 62760"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.00467319),
        dec: Angle.Degrees(+31.20252023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28855"},
        {"Hipparcos Number", "HIP 21283"},
        {"Smithsonian Astrophysical Observation", "SAO 57315"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.50208567),
        dec: Angle.Degrees(+31.20255684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41750"},
        {"Hipparcos Number", "HIP 29116"},
        {"Geneva Identification System", "GEN# +1.00041750"},
        {"Smithsonian Astrophysical Observation", "SAO 58783"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.10306574),
        dec: Angle.Degrees(+31.20305571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29119",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 8.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)08, 25.9600),
        dec: Angle.DegreesMinutesSeconds((int)+31, (int)12, 15.600)
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
    primaryId: "HIP 72795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131452"},
        {"Hipparcos Number", "HIP 72795"},
        {"Geneva Identification System", "GEN# +1.00131452"},
        {"Smithsonian Astrophysical Observation", "SAO 64374"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.19459937),
        dec: Angle.Degrees(+31.20550193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83834",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10356 AB"},
        {"Henry Draper", "HD 155061"},
        {"Hipparcos Number", "HIP 83834"},
        {"Smithsonian Astrophysical Observation", "SAO 65810"},
        {"Wilson Evans Batten Catalogue", "WEB 14165"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.00290075),
        dec: Angle.Degrees(+31.20623662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102602"},
        {"Hipparcos Number", "HIP 57612"},
        {"Smithsonian Astrophysical Observation", "SAO 62713"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.18215451),
        dec: Angle.Degrees(+31.20825405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43344",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 9.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)49, 47.1200),
        dec: Angle.DegreesMinutesSeconds((int)+31, (int)12, 33.400)
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
    primaryId: "HIP 58959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104998"},
        {"Hipparcos Number", "HIP 58959"},
        {"Geneva Identification System", "GEN# +1.00104998"},
        {"Smithsonian Astrophysical Observation", "SAO 62833"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.34488277),
        dec: Angle.Degrees(+31.21031611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43348"},
        {"Smithsonian Astrophysical Observation", "SAO 61066"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.44931116),
        dec: Angle.Degrees(+31.21078583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62406"},
        {"Geneva Identification System", "GEN# +0.03202274"},
        {"Wilson Evans Batten Catalogue", "WEB 11081"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.83374120),
        dec: Angle.Degrees(+31.21420625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184149"},
        {"Hipparcos Number", "HIP 96058"},
        {"Smithsonian Astrophysical Observation", "SAO 68448"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.97363867),
        dec: Angle.Degrees(+31.21489249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213340"},
        {"Hipparcos Number", "HIP 111075"},
        {"Smithsonian Astrophysical Observation", "SAO 72407"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.53498047),
        dec: Angle.Degrees(+31.21582140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81811"},
        {"Smithsonian Astrophysical Observation", "SAO 65498"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.64665059),
        dec: Angle.Degrees(+31.21611219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81378"},
        {"Smithsonian Astrophysical Observation", "SAO 65434"},
        {"Wilson Evans Batten Catalogue", "WEB 13755"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.29183402),
        dec: Angle.Degrees(+31.21652723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55998"},
    },
    visualMagnitude: 11.47,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.13694652),
        dec: Angle.Degrees(+31.21684441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185603"},
        {"Hipparcos Number", "HIP 96618"},
        {"Geneva Identification System", "GEN# +1.00185603"},
        {"Smithsonian Astrophysical Observation", "SAO 68614"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.66138689),
        dec: Angle.Degrees(+31.21924071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158225"},
        {"Hipparcos Number", "HIP 85381"},
        {"Geneva Identification System", "GEN# +1.00158225"},
        {"Smithsonian Astrophysical Observation", "SAO 66052"},
        {"Wilson Evans Batten Catalogue", "WEB 14420"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.69148990),
        dec: Angle.Degrees(+31.21955443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55997"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.13411808),
        dec: Angle.Degrees(+31.22024110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192662"},
        {"Hipparcos Number", "HIP 99804"},
        {"Renson", "Renson 53710"},
        {"Smithsonian Astrophysical Observation", "SAO 69686"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.73458222),
        dec: Angle.Degrees(+31.22177172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142942"},
        {"Hipparcos Number", "HIP 78061"},
        {"Smithsonian Astrophysical Observation", "SAO 64977"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.06405295),
        dec: Angle.Degrees(+31.22207933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95829"},
        {"Hipparcos Number", "HIP 54068"},
        {"Smithsonian Astrophysical Observation", "SAO 62381"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.94738322),
        dec: Angle.Degrees(+31.22209969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35238"},
        {"Hipparcos Number", "HIP 25290"},
        {"Geneva Identification System", "GEN# +1.00035238"},
        {"Smithsonian Astrophysical Observation", "SAO 57987"},
        {"Wilson Evans Batten Catalogue", "WEB 4905"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.16018419),
        dec: Angle.Degrees(+31.22393349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37423"},
        {"Hipparcos Number", "HIP 26650"},
        {"Geneva Identification System", "GEN# +1.00037423"},
        {"Smithsonian Astrophysical Observation", "SAO 58304"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.96055136),
        dec: Angle.Degrees(+31.22407444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58005"},
        {"Geneva Identification System", "GEN# +0.03202199"},
        {"Smithsonian Astrophysical Observation", "SAO 62745"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.46227403),
        dec: Angle.Degrees(+31.22589338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112208",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16219 A"},
        {"Henry Draper", "HD 215273"},
        {"Hipparcos Number", "HIP 112208"},
        {"Smithsonian Astrophysical Observation", "SAO 72665"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.88423243),
        dec: Angle.Degrees(+31.22732003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36383",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36383"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.32430726),
        dec: Angle.Degrees(+31.22867139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52714"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.66633344),
        dec: Angle.Degrees(+31.22870336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -211.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79498"},
        {"Smithsonian Astrophysical Observation", "SAO 65152"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.34671390),
        dec: Angle.Degrees(+31.22931958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282138"},
        {"Hipparcos Number", "HIP 20621"},
    },
    visualMagnitude: 9.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.27802699),
        dec: Angle.Degrees(+31.22956687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189847"},
        {"Hipparcos Number", "HIP 98525"},
        {"Geneva Identification System", "GEN# +1.00189847"},
        {"Smithsonian Astrophysical Observation", "SAO 69254"},
        {"Wilson Evans Batten Catalogue", "WEB 17404"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.24475171),
        dec: Angle.Degrees(+31.23046514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87512"},
        {"Hipparcos Number", "HIP 49487"},
        {"Geneva Identification System", "GEN# +1.00087512"},
        {"Smithsonian Astrophysical Observation", "SAO 61859"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.54941809),
        dec: Angle.Degrees(+31.23119836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67525"},
        {"Geneva Identification System", "GEN# +0.03102553"},
        {"Smithsonian Astrophysical Observation", "SAO 63776"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.52929810),
        dec: Angle.Degrees(+31.23230730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185174"},
        {"Hipparcos Number", "HIP 96452"},
        {"Geneva Identification System", "GEN# +1.00185174"},
        {"Smithsonian Astrophysical Observation", "SAO 68575"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.14367949),
        dec: Angle.Degrees(+31.23600511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184381"},
        {"Hipparcos Number", "HIP 96143"},
        {"Geneva Identification System", "GEN# +1.00184381"},
        {"Smithsonian Astrophysical Observation", "SAO 68472"},
        {"Wilson Evans Batten Catalogue", "WEB 16844"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.22870909),
        dec: Angle.Degrees(+31.23606240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72451",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72451"},
        {"Smithsonian Astrophysical Observation", "SAO 64340"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.23603381),
        dec: Angle.Degrees(+31.23695422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142395"},
        {"Hipparcos Number", "HIP 77805"},
        {"Smithsonian Astrophysical Observation", "SAO 64966"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.31286152),
        dec: Angle.Degrees(+31.23754616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37559"},
        {"Smithsonian Astrophysical Observation", "SAO 60288"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.63119066),
        dec: Angle.Degrees(+31.23788385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52368"},
        {"Hipparcos Number", "HIP 33916"},
        {"Geneva Identification System", "GEN# +1.00052368"},
        {"Smithsonian Astrophysical Observation", "SAO 59711"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.57641721),
        dec: Angle.Degrees(+31.23926756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180613"},
        {"Hipparcos Number", "HIP 94680"},
        {"Celescope Catalog", "CEL 4727"},
        {"Geneva Identification System", "GEN# +1.00180613"},
        {"Smithsonian Astrophysical Observation", "SAO 68051"},
        {"Wilson Evans Batten Catalogue", "WEB 16512"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.99018641),
        dec: Angle.Degrees(+31.24085924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192804"},
        {"Hipparcos Number", "HIP 99868"},
        {"Geneva Identification System", "GEN# +1.00192804"},
        {"Smithsonian Astrophysical Observation", "SAO 69709"},
        {"Wilson Evans Batten Catalogue", "WEB 17958"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.92700903),
        dec: Angle.Degrees(+31.24226653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190537"},
        {"Hipparcos Number", "HIP 98831"},
        {"Geneva Identification System", "GEN# +1.00190537"},
        {"Renson", "Renson 52970"},
        {"Smithsonian Astrophysical Observation", "SAO 69343"},
        {"Wilson Evans Batten Catalogue", "WEB 17527"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.05396004),
        dec: Angle.Degrees(+31.24316659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27419"},
        {"Hipparcos Number", "HIP 20286"},
        {"Smithsonian Astrophysical Observation", "SAO 57178"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.22015373),
        dec: Angle.Degrees(+31.24549543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90746",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11422 AB"},
        {"Hipparcos Number", "HIP 90746"},
        {"Smithsonian Astrophysical Observation", "SAO 67050"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.74063617),
        dec: Angle.Degrees(+31.24556025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95450"},
        {"Hipparcos Number", "HIP 53884"},
        {"Geneva Identification System", "GEN# +1.00095450"},
        {"Smithsonian Astrophysical Observation", "SAO 62358"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.36409448),
        dec: Angle.Degrees(+31.24638880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107741"},
        {"Hipparcos Number", "HIP 60367"},
        {"Geneva Identification System", "GEN# +1.00107741"},
        {"Smithsonian Astrophysical Observation", "SAO 62974"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.67334099),
        dec: Angle.Degrees(+31.24890452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104504"},
        {"Hipparcos Number", "HIP 58685"},
        {"Geneva Identification System", "GEN# +1.00104504"},
        {"Smithsonian Astrophysical Observation", "SAO 62806"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.53311983),
        dec: Angle.Degrees(+31.24953833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197206"},
        {"Hipparcos Number", "HIP 102083"},
        {"Smithsonian Astrophysical Observation", "SAO 70370"},
        {"Wilson Evans Batten Catalogue", "WEB 18460"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.32617845),
        dec: Angle.Degrees(+31.25026219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166799"},
        {"Hipparcos Number", "HIP 89090"},
        {"Smithsonian Astrophysical Observation", "SAO 66720"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.74199701),
        dec: Angle.Degrees(+31.25144983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100443",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13760 AB"},
        {"Henry Draper", "HD 193986"},
        {"Hipparcos Number", "HIP 100443"},
        {"Smithsonian Astrophysical Observation", "SAO 69906"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.54245126),
        dec: Angle.Degrees(+31.25321375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123929"},
        {"Hipparcos Number", "HIP 69185"},
        {"Geneva Identification System", "GEN# +1.00123929"},
        {"Smithsonian Astrophysical Observation", "SAO 63961"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.43747334),
        dec: Angle.Degrees(+31.25630242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14840"},
        {"Geneva Identification System", "GEN# +0.03000500"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.91762487),
        dec: Angle.Degrees(+31.25649169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157329"},
        {"Hipparcos Number", "HIP 84920"},
        {"Geneva Identification System", "GEN# +1.00157329"},
        {"Smithsonian Astrophysical Observation", "SAO 65971"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.31136548),
        dec: Angle.Degrees(+31.25687684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66999"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.96234319),
        dec: Angle.Degrees(+31.25980986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212470"},
        {"Hipparcos Number", "HIP 110569"},
        {"Smithsonian Astrophysical Observation", "SAO 72295"},
        {"Wilson Evans Batten Catalogue", "WEB 19815"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.98494862),
        dec: Angle.Degrees(+31.26175185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282719"},
        {"Hipparcos Number", "HIP 23433"},
        {"Fundamental Katalog 5th Edition", "FK5 4463"},
        {"Smithsonian Astrophysical Observation", "SAO 57590"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.56139913),
        dec: Angle.Degrees(+31.26370674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208491"},
        {"Hipparcos Number", "HIP 108251"},
        {"Smithsonian Astrophysical Observation", "SAO 71850"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.96272276),
        dec: Angle.Degrees(+31.26467569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194097"},
        {"Hipparcos Number", "HIP 100486"},
        {"Geneva Identification System", "GEN# +1.00194097"},
        {"Smithsonian Astrophysical Observation", "SAO 69917"},
        {"Wilson Evans Batten Catalogue", "WEB 18146"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.65547104),
        dec: Angle.Degrees(+31.26502064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49200"},
        {"Hipparcos Number", "HIP 32651"},
        {"Smithsonian Astrophysical Observation", "SAO 59505"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.16536867),
        dec: Angle.Degrees(+31.26691596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3256"},
        {"Geneva Identification System", "GEN# +9.80069012"},
    },
    visualMagnitude: 11.64,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.37018709),
        dec: Angle.Degrees(+31.26905890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117974"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.92811385),
        dec: Angle.Degrees(+31.26915072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242193"},
        {"Hipparcos Number", "HIP 24641"},
        {"Smithsonian Astrophysical Observation", "SAO 57838"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.31317671),
        dec: Angle.Degrees(+31.27059106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103617"},
        {"Smithsonian Astrophysical Observation", "SAO 70767"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.90745929),
        dec: Angle.Degrees(+31.27107268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184927"},
        {"Hipparcos Number", "HIP 96362"},
        {"Celescope Catalog", "CEL 4793"},
        {"Geneva Identification System", "GEN# +1.00184927"},
        {"Renson", "Renson 51020"},
        {"Smithsonian Astrophysical Observation", "SAO 68542"},
        {"Wilson Evans Batten Catalogue", "WEB 16898"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.88336100),
        dec: Angle.Degrees(+31.27664012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83787"},
        {"Hipparcos Number", "HIP 47544"},
        {"Geneva Identification System", "GEN# +1.00083787"},
        {"Smithsonian Astrophysical Observation", "SAO 61633"},
        {"Wilson Evans Batten Catalogue", "WEB 8917"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.39627242),
        dec: Angle.Degrees(+31.27784047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40665"},
        {"Smithsonian Astrophysical Observation", "SAO 60709"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.51483511),
        dec: Angle.Degrees(+31.27803173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282230"},
        {"Hipparcos Number", "HIP 21105"},
        {"Smithsonian Astrophysical Observation", "SAO 57281"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.84642152),
        dec: Angle.Degrees(+31.27828078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141158"},
        {"Hipparcos Number", "HIP 77265"},
        {"Smithsonian Astrophysical Observation", "SAO 64891"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.62482690),
        dec: Angle.Degrees(+31.27828801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160848"},
        {"Hipparcos Number", "HIP 86514"},
        {"Smithsonian Astrophysical Observation", "SAO 66247"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.20816901),
        dec: Angle.Degrees(+31.27888745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108021"},
        {"Hipparcos Number", "HIP 60529"},
        {"Cincinnati Publication", "Ci 18 1561"},
        {"Geneva Identification System", "GEN# +1.00108021"},
        {"Smithsonian Astrophysical Observation", "SAO 62985"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.12536254),
        dec: Angle.Degrees(+31.28029847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118217"},
        {"Hipparcos Number", "HIP 66260"},
        {"Geneva Identification System", "GEN# +1.00118217"},
        {"Smithsonian Astrophysical Observation", "SAO 63622"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.70817199),
        dec: Angle.Degrees(+31.28175511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36071"},
        {"Hipparcos Number", "HIP 25794"},
        {"Geneva Identification System", "GEN# +1.00036071"},
        {"Smithsonian Astrophysical Observation", "SAO 58128"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.61914916),
        dec: Angle.Degrees(+31.28223540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179527"},
        {"Hipparcos Number", "HIP 94311"},
        {"Celescope Catalog", "CEL 4717"},
        {"Fundamental Katalog 5th Edition", "FK5 3532"},
        {"Geneva Identification System", "GEN# +1.00179527"},
        {"Renson", "Renson 49860"},
        {"Smithsonian Astrophysical Observation", "SAO 67946"},
        {"Wilson Evans Batten Catalogue", "WEB 16428"},
    },
    visualMagnitude: 5.93,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.94171276),
        dec: Angle.Degrees(+31.28346360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213802"},
        {"Hipparcos Number", "HIP 111352"},
        {"Geneva Identification System", "GEN# +1.00213802"},
        {"Smithsonian Astrophysical Observation", "SAO 72463"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.39257844),
        dec: Angle.Degrees(+31.28394946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138341"},
        {"Hipparcos Number", "HIP 75919"},
        {"Geneva Identification System", "GEN# +1.00138341"},
        {"Renson", "Renson 39390"},
        {"Smithsonian Astrophysical Observation", "SAO 64736"},
        {"Wilson Evans Batten Catalogue", "WEB 12912"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.59491496),
        dec: Angle.Degrees(+31.28597597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160822"},
        {"Hipparcos Number", "HIP 86506"},
        {"Geneva Identification System", "GEN# +1.00160822"},
        {"Smithsonian Astrophysical Observation", "SAO 66243"},
        {"Wilson Evans Batten Catalogue", "WEB 14591"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.17178162),
        dec: Angle.Degrees(+31.28766077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11408",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1851 AB"},
        {"Henry Draper", "HD 15128"},
        {"Hipparcos Number", "HIP 11408"},
        {"Smithsonian Astrophysical Observation", "SAO 55566"},
        {"Wilson Evans Batten Catalogue", "WEB 2381"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.75387482),
        dec: Angle.Degrees(+31.28818659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71764",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9340 AB"},
        {"Henry Draper", "HD 129260"},
        {"Hipparcos Number", "HIP 71764"},
        {"Smithsonian Astrophysical Observation", "SAO 64268"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.18436003),
        dec: Angle.Degrees(+31.29002296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1363"},
        {"Hipparcos Number", "HIP 1448"},
        {"Geneva Identification System", "GEN# +1.00001363"},
        {"Smithsonian Astrophysical Observation", "SAO 53793"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.50368585),
        dec: Angle.Degrees(+31.29184629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89900"},
        {"Smithsonian Astrophysical Observation", "SAO 66880"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.16943921),
        dec: Angle.Degrees(+31.56289416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263375"},
        {"Hipparcos Number", "HIP 32482"},
        {"Smithsonian Astrophysical Observation", "SAO 59474"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.68632349),
        dec: Angle.Degrees(+31.29367692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40398"},
        {"Smithsonian Astrophysical Observation", "SAO 60672"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.71641379),
        dec: Angle.Degrees(+31.29411533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70627"},
        {"Hipparcos Number", "HIP 41172"},
        {"Smithsonian Astrophysical Observation", "SAO 60787"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.02454070),
        dec: Angle.Degrees(+31.30103989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79851"},
        {"Hipparcos Number", "HIP 45584"},
        {"Smithsonian Astrophysical Observation", "SAO 61382"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.36326252),
        dec: Angle.Degrees(+31.30105546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107487"},
        {"Hipparcos Number", "HIP 60242"},
        {"Geneva Identification System", "GEN# +1.00107487"},
        {"Smithsonian Astrophysical Observation", "SAO 62962"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.29281469),
        dec: Angle.Degrees(+31.30223464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67936"},
        {"Hipparcos Number", "HIP 40103"},
        {"Smithsonian Astrophysical Observation", "SAO 60629"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.87939209),
        dec: Angle.Degrees(+31.30459542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27092",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4317 AB"},
        {"Henry Draper", "HD 38105"},
        {"Hipparcos Number", "HIP 27092"},
        {"Geneva Identification System", "GEN# +1.00038105J"},
        {"Smithsonian Astrophysical Observation", "SAO 58387"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.17367342),
        dec: Angle.Degrees(+31.30576876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218043"},
        {"Hipparcos Number", "HIP 113952"},
        {"Geneva Identification System", "GEN# +1.00218043"},
        {"Smithsonian Astrophysical Observation", "SAO 72981"},
        {"Wilson Evans Batten Catalogue", "WEB 20236"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.15150606),
        dec: Angle.Degrees(+31.30754596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65088"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.11194944),
        dec: Angle.Degrees(+31.30868594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1024"},
        {"Smithsonian Astrophysical Observation", "SAO 53724"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.19089969),
        dec: Angle.Degrees(+31.30971644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110353",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15858 AB"},
        {"Henry Draper", "HD 212046"},
        {"Hipparcos Number", "HIP 110353"},
        {"Smithsonian Astrophysical Observation", "SAO 72253"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.25752038),
        dec: Angle.Degrees(+31.30986841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19017"},
        {"Hipparcos Number", "HIP 14312"},
        {"Smithsonian Astrophysical Observation", "SAO 56133"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.15222030),
        dec: Angle.Degrees(+31.30995957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112723",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16292 AB"},
        {"Henry Draper", "HD 216109"},
        {"Hipparcos Number", "HIP 112723"},
        {"Smithsonian Astrophysical Observation", "SAO 72759"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.42070910),
        dec: Angle.Degrees(+31.31144614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197329"},
        {"Hipparcos Number", "HIP 102161"},
        {"Smithsonian Astrophysical Observation", "SAO 70395"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.50969782),
        dec: Angle.Degrees(+31.31184671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211340"},
        {"Hipparcos Number", "HIP 109921"},
        {"Smithsonian Astrophysical Observation", "SAO 72185"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.95654830),
        dec: Angle.Degrees(+31.31463446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66611"},
        {"Hipparcos Number", "HIP 39605"},
        {"Smithsonian Astrophysical Observation", "SAO 60551"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.40065520),
        dec: Angle.Degrees(+31.31574773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172269"},
        {"Hipparcos Number", "HIP 91356"},
        {"Geneva Identification System", "GEN# +1.00172269"},
        {"Smithsonian Astrophysical Observation", "SAO 67184"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.48806818),
        dec: Angle.Degrees(+31.31671422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245318"},
        {"Hipparcos Number", "HIP 26374"},
        {"Geneva Identification System", "GEN# +1.00245318"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.24055507),
        dec: Angle.Degrees(+31.31685322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74185"},
        {"Hipparcos Number", "HIP 42826"},
        {"Smithsonian Astrophysical Observation", "SAO 61013"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.89525787),
        dec: Angle.Degrees(+31.31718879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335007"},
        {"Henry Draper 2", "HD 335007A"},
        {"Hipparcos Number", "HIP 102320"},
        {"Geneva Identification System", "GEN# +1.00335007"},
        {"Wilson Evans Batten Catalogue", "WEB 18524"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.97230863),
        dec: Angle.Degrees(+31.31956500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332322"},
        {"Hipparcos Number", "HIP 100867"},
        {"Smithsonian Astrophysical Observation", "SAO 70043"},
    },
    visualMagnitude: 9.03,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.78312706),
        dec: Angle.Degrees(+31.32074833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127664"},
        {"Hipparcos Number", "HIP 71049"},
        {"Smithsonian Astrophysical Observation", "SAO 64201"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.95287175),
        dec: Angle.Degrees(+31.32105743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179281"},
        {"Hipparcos Number", "HIP 94212"},
        {"Celescope Catalog", "CEL 4712"},
        {"Geneva Identification System", "GEN# +1.00179281"},
        {"Smithsonian Astrophysical Observation", "SAO 67921"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.69528047),
        dec: Angle.Degrees(+31.32161016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38200"},
        {"Hipparcos Number", "HIP 27164"},
        {"Geneva Identification System", "GEN# +1.00038200"},
        {"Smithsonian Astrophysical Observation", "SAO 58404"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.37330119),
        dec: Angle.Degrees(+31.32486889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116310",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16836 AB"},
        {"Henry Draper", "HD 221673"},
        {"Hipparcos Number", "HIP 116310"},
        {"Geneva Identification System", "GEN# +1.00221673"},
        {"Smithsonian Astrophysical Observation", "SAO 73341"},
        {"Wilson Evans Batten Catalogue", "WEB 20554"},
    },
    visualMagnitude: 4.97,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.48813881),
        dec: Angle.Degrees(+31.32532196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40676"},
        {"Hipparcos Number", "HIP 28575"},
        {"Geneva Identification System", "GEN# +1.00040676"},
        {"Smithsonian Astrophysical Observation", "SAO 58670"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.46055150),
        dec: Angle.Degrees(+31.32688539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82010"},
        {"Hipparcos Number", "HIP 46604"},
        {"Geneva Identification System", "GEN# +1.00082010"},
        {"Smithsonian Astrophysical Observation", "SAO 61525"},
        {"Wilson Evans Batten Catalogue", "WEB 8793"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.54909402),
        dec: Angle.Degrees(+31.32714466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72147",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72147"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.35349882),
        dec: Angle.Degrees(+31.32796698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250810"},
        {"Hipparcos Number", "HIP 28715"},
        {"Geneva Identification System", "GEN# +1.00250810"},
        {"Smithsonian Astrophysical Observation", "SAO 58699"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.97354366),
        dec: Angle.Degrees(+31.32812066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25295"},
        {"Hipparcos Number", "HIP 18841"},
        {"Geneva Identification System", "GEN# +1.00025295"},
        {"Smithsonian Astrophysical Observation", "SAO 56917"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.60124143),
        dec: Angle.Degrees(+31.33113125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37097"},
        {"Hipparcos Number", "HIP 26419"},
        {"Fundamental Katalog 5th Edition", "FK5 4510"},
        {"Geneva Identification System", "GEN# +1.00037097"},
        {"Smithsonian Astrophysical Observation", "SAO 58257"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.34054948),
        dec: Angle.Degrees(+31.33137820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183081"},
        {"Hipparcos Number", "HIP 95590"},
        {"Smithsonian Astrophysical Observation", "SAO 68312"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.64171709),
        dec: Angle.Degrees(+31.33150598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331457"},
        {"Hipparcos Number", "HIP 97798"},
        {"Smithsonian Astrophysical Observation", "SAO 69003"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.09679699),
        dec: Angle.Degrees(+31.33233612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103986"},
        {"Hipparcos Number", "HIP 58405"},
        {"Smithsonian Astrophysical Observation", "SAO 62780"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.62962369),
        dec: Angle.Degrees(+31.33738519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14348"},
        {"Hipparcos Number", "HIP 10868"},
        {"Geneva Identification System", "GEN# +1.00014348"},
        {"Smithsonian Astrophysical Observation", "SAO 55460"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.97017293),
        dec: Angle.Degrees(+31.33770658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56969"},
        {"Geneva Identification System", "GEN# +0.03202176"},
        {"Smithsonian Astrophysical Observation", "SAO 62652"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.17457542),
        dec: Angle.Degrees(+31.33811175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143550"},
        {"Hipparcos Number", "HIP 78348"},
        {"Smithsonian Astrophysical Observation", "SAO 65009"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.96316606),
        dec: Angle.Degrees(+31.33971947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52451"},
        {"Hipparcos Number", "HIP 33945"},
        {"Smithsonian Astrophysical Observation", "SAO 59713"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.66304290),
        dec: Angle.Degrees(+31.34000820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74450"},
        {"Smithsonian Astrophysical Observation", "SAO 64562"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.21075258),
        dec: Angle.Degrees(+31.34004527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71454"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.18693338),
        dec: Angle.Degrees(+31.34061251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6339"},
        {"Cincinnati Publication", "Ci 18 174"},
        {"Cincinnati Publication 2", "Ci 20 97"},
        {"Geneva Identification System", "GEN# +0.03000206"},
        {"Smithsonian Astrophysical Observation", "SAO 54624"},
        {"Wilson Evans Batten Catalogue", "WEB 1410"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.36614642),
        dec: Angle.Degrees(+31.34165105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 529.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96117"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.14319817),
        dec: Angle.Degrees(+31.34289465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207352"},
        {"Hipparcos Number", "HIP 107592"},
        {"Smithsonian Astrophysical Observation", "SAO 71709"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.88835435),
        dec: Angle.Degrees(+31.34323433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47650"},
        {"Hipparcos Number", "HIP 31988"},
        {"Geneva Identification System", "GEN# +1.00047650"},
        {"Smithsonian Astrophysical Observation", "SAO 59359"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.26576902),
        dec: Angle.Degrees(+31.35161305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254015"},
        {"Hipparcos Number", "HIP 29776"},
        {"Smithsonian Astrophysical Observation", "SAO 58924"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.04117912),
        dec: Angle.Degrees(+31.35311940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198597"},
        {"Hipparcos Number", "HIP 102863"},
        {"Smithsonian Astrophysical Observation", "SAO 70559"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.59831676),
        dec: Angle.Degrees(+31.35313596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61708"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.72611006),
        dec: Angle.Degrees(+31.35341062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169550"},
        {"Hipparcos Number", "HIP 90160"},
        {"Geneva Identification System", "GEN# +1.00169550"},
        {"Smithsonian Astrophysical Observation", "SAO 66932"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.98328187),
        dec: Angle.Degrees(+31.35674260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202643"},
        {"Hipparcos Number", "HIP 105020"},
        {"Smithsonian Astrophysical Observation", "SAO 71145"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.07978926),
        dec: Angle.Degrees(+31.35758988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197119"},
        {"Hipparcos Number", "HIP 102034"},
        {"Celescope Catalog", "CEL 5139"},
        {"Geneva Identification System", "GEN# +1.00197119"},
        {"Smithsonian Astrophysical Observation", "SAO 70352"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.15174322),
        dec: Angle.Degrees(+31.35799708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37519"},
        {"Hipparcos Number", "HIP 26712"},
        {"Celescope Catalog", "CEL 906"},
        {"Fundamental Katalog 5th Edition", "FK5 2425"},
        {"Geneva Identification System", "GEN# +1.00037519"},
        {"Renson", "Renson 10100"},
        {"Smithsonian Astrophysical Observation", "SAO 58319"},
        {"Wilson Evans Batten Catalogue", "WEB 5265"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.14962767),
        dec: Angle.Degrees(+31.35821889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138749"},
        {"Hipparcos Number", "HIP 76127"},
        {"Fundamental Katalog 5th Edition", "FK5 576"},
        {"Geneva Identification System", "GEN# +1.00138749"},
        {"Smithsonian Astrophysical Observation", "SAO 64769"},
        {"Wilson Evans Batten Catalogue", "WEB 12933"},
    },
    visualMagnitude: 4.14,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.23248309),
        dec: Angle.Degrees(+31.35915517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254778"},
        {"Hipparcos Number", "HIP 30020"},
        {"Smithsonian Astrophysical Observation", "SAO 58978"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.76153766),
        dec: Angle.Degrees(+31.36406971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77311"},
        {"Hipparcos Number", "HIP 44401"},
        {"Smithsonian Astrophysical Observation", "SAO 61217"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.67524490),
        dec: Angle.Degrees(+31.36480902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114377"},
        {"Hipparcos Number", "HIP 64232"},
        {"Geneva Identification System", "GEN# +1.00114377J"},
        {"Smithsonian Astrophysical Observation", "SAO 63375"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.46680947),
        dec: Angle.Degrees(+31.36685964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136753"},
        {"Hipparcos Number", "HIP 75143"},
        {"Geneva Identification System", "GEN# +1.00136753"},
        {"Smithsonian Astrophysical Observation", "SAO 64652"},
        {"Wilson Evans Batten Catalogue", "WEB 12820"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.34983864),
        dec: Angle.Degrees(+31.36741279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38456",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38456"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.16148082),
        dec: Angle.Degrees(+31.36782011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94069"},
        {"Hipparcos Number", "HIP 53112"},
        {"Geneva Identification System", "GEN# +1.00094069"},
        {"Smithsonian Astrophysical Observation", "SAO 62286"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.99457087),
        dec: Angle.Degrees(+31.36832759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331549"},
        {"Hipparcos Number", "HIP 98115"},
        {"Geneva Identification System", "GEN# +1.00331549"},
        {"Smithsonian Astrophysical Observation", "SAO 69115"},
        {"Wilson Evans Batten Catalogue", "WEB 17292"},
    },
    visualMagnitude: 9.18,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.09799871),
        dec: Angle.Degrees(+31.36923908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41682",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6834 B"},
        {"Hipparcos Number", "HIP 41682"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.45935185),
        dec: Angle.Degrees(+31.36965542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73471",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9478 B"},
        {"Hipparcos Number", "HIP 73471"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.23971218),
        dec: Angle.Degrees(+31.37180449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108007"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.23207762),
        dec: Angle.Degrees(+31.37251183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34905"},
        {"Hipparcos Number", "HIP 25078"},
        {"Geneva Identification System", "GEN# +1.00034905"},
        {"Smithsonian Astrophysical Observation", "SAO 57948"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.53850874),
        dec: Angle.Degrees(+31.37267583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2019"},
        {"Hipparcos Number", "HIP 1952"},
        {"Geneva Identification System", "GEN# +1.00002019"},
        {"Renson", "Renson 460"},
        {"Smithsonian Astrophysical Observation", "SAO 53870"},
        {"Wilson Evans Batten Catalogue", "WEB 367"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.16530026),
        dec: Angle.Degrees(+31.37308234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48195"},
        {"Hipparcos Number", "HIP 32215"},
        {"Smithsonian Astrophysical Observation", "SAO 59414"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.88535433),
        dec: Angle.Degrees(+31.37389445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183680"},
        {"Hipparcos Number", "HIP 95839"},
        {"Smithsonian Astrophysical Observation", "SAO 68391"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.38302460),
        dec: Angle.Degrees(+31.37428969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41685",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6834 A"},
        {"Henry Draper", "HD 71679"},
        {"Hipparcos Number", "HIP 41685"},
        {"Smithsonian Astrophysical Observation", "SAO 60856"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.46356231),
        dec: Angle.Degrees(+31.37559504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73472",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9478 A"},
        {"Henry Draper", "HD 132971"},
        {"Hipparcos Number", "HIP 73472"},
        {"Smithsonian Astrophysical Observation", "SAO 64464"},
        {"Wilson Evans Batten Catalogue", "WEB 12576"},
    },
    visualMagnitude: 8.50,
    bvColour: 2.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.24056954),
        dec: Angle.Degrees(+31.37740788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54800"},
        {"Hipparcos Number", "HIP 34745"},
        {"Geneva Identification System", "GEN# +1.00054800"},
        {"Smithsonian Astrophysical Observation", "SAO 59874"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.90721164),
        dec: Angle.Degrees(+31.37752943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88531"},
        {"Hipparcos Number", "HIP 50059"},
        {"Geneva Identification System", "GEN# +1.00088531"},
        {"Smithsonian Astrophysical Observation", "SAO 61934"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.31308699),
        dec: Angle.Degrees(+31.37795332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221247"},
        {"Hipparcos Number", "HIP 116001"},
        {"Geneva Identification System", "GEN# +1.00221247"},
        {"Smithsonian Astrophysical Observation", "SAO 73303"},
        {"Wilson Evans Batten Catalogue", "WEB 20513"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.55197500),
        dec: Angle.Degrees(+31.37823557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245727"},
        {"Hipparcos Number", "HIP 26570"},
        {"Smithsonian Astrophysical Observation", "SAO 58288"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.73864207),
        dec: Angle.Degrees(+31.37847217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341"},
        {"Hipparcos Number", "HIP 659"},
        {"Geneva Identification System", "GEN# +1.00000341"},
        {"Renson", "Renson 40"},
        {"Smithsonian Astrophysical Observation", "SAO 53670"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.03986590),
        dec: Angle.Degrees(+31.37900363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210955"},
        {"Hipparcos Number", "HIP 109710"},
        {"Smithsonian Astrophysical Observation", "SAO 72143"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.34220976),
        dec: Angle.Degrees(+31.38227854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140571"},
        {"Hipparcos Number", "HIP 76993"},
        {"Geneva Identification System", "GEN# +1.00140571"},
        {"Smithsonian Astrophysical Observation", "SAO 64865"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.80966149),
        dec: Angle.Degrees(+31.38490128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50950"},
        {"Hipparcos Number", "HIP 33393"},
        {"Geneva Identification System", "GEN# +1.00050950"},
        {"Smithsonian Astrophysical Observation", "SAO 59629"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.18521134),
        dec: Angle.Degrees(+31.38532765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81742"},
        {"Hipparcos Number", "HIP 46446"},
        {"Smithsonian Astrophysical Observation", "SAO 61507"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.09158810),
        dec: Angle.Degrees(+31.38751424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191512"},
        {"Hipparcos Number", "HIP 99278"},
        {"Smithsonian Astrophysical Observation", "SAO 69506"},
        {"Wilson Evans Batten Catalogue", "WEB 17699"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.28793609),
        dec: Angle.Degrees(+31.38951182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40930"},
        {"Hipparcos Number", "HIP 28683"},
        {"Geneva Identification System", "GEN# +1.00040930"},
        {"Smithsonian Astrophysical Observation", "SAO 58695"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.84058900),
        dec: Angle.Degrees(+31.39014934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9982",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9982"},
        {"Geneva Identification System", "GEN# +0.03000338"},
        {"Smithsonian Astrophysical Observation", "SAO 55292"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.13877405),
        dec: Angle.Degrees(+31.39047246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 228.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60920",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8569 AB"},
        {"Aitken 2", "ADS 8569"},
        {"Henry Draper", "HD 108693"},
        {"Hipparcos Number", "HIP 60920"},
        {"Geneva Identification System", "GEN# +1.00108693"},
        {"Smithsonian Astrophysical Observation", "SAO 63020"},
        {"Wilson Evans Batten Catalogue", "WEB 10839"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.28176540),
        dec: Angle.Degrees(+31.39049503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332"},
        {"Hipparcos Number", "HIP 652"},
        {"Geneva Identification System", "GEN# +1.00000332"},
        {"Smithsonian Astrophysical Observation", "SAO 53668"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.00721943),
        dec: Angle.Degrees(+31.39121911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85162"},
        {"Hipparcos Number", "HIP 48292"},
        {"Smithsonian Astrophysical Observation", "SAO 61710"},
        {"Wilson Evans Batten Catalogue", "WEB 9006"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.68755095),
        dec: Angle.Degrees(+31.39273942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53287"},
        {"Hipparcos Number", "HIP 34229"},
        {"Smithsonian Astrophysical Observation", "SAO 59766"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.44689428),
        dec: Angle.Degrees(+31.39328075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174961"},
        {"Hipparcos Number", "HIP 92579"},
        {"Fundamental Katalog 5th Edition", "FK5 5663"},
        {"Smithsonian Astrophysical Observation", "SAO 67487"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.97544756),
        dec: Angle.Degrees(+31.39410022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5050"},
        {"Hipparcos Number", "HIP 4108"},
        {"Geneva Identification System", "GEN# +1.00005050"},
        {"Smithsonian Astrophysical Observation", "SAO 54222"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.17368773),
        dec: Angle.Degrees(+31.39458165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17259"},
        {"Hipparcos Number", "HIP 12991"},
        {"Smithsonian Astrophysical Observation", "SAO 55875"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.76523147),
        dec: Angle.Degrees(+31.39512209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26815"},
        {"Hipparcos Number", "HIP 19876"},
        {"Geneva Identification System", "GEN# +1.00026815"},
        {"Smithsonian Astrophysical Observation", "SAO 57106"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.94011257),
        dec: Angle.Degrees(+31.39736408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73192"},
        {"Cincinnati Publication", "Ci 20 901"},
        {"Geneva Identification System", "GEN# +9.80166057"},
        {"Wilson Evans Batten Catalogue", "WEB 12547"},
    },
    visualMagnitude: 11.08,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.38655978),
        dec: Angle.Degrees(+31.39853389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -694.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1159.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93514",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11977 A"},
        {"Henry Draper", "HD 177279"},
        {"Hipparcos Number", "HIP 93514"},
        {"Renson", "Renson 49440"},
        {"Smithsonian Astrophysical Observation", "SAO 67730"},
        {"Wilson Evans Batten Catalogue", "WEB 16237"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.67192537),
        dec: Angle.Degrees(+31.39958507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120349"},
        {"Hipparcos Number", "HIP 67357"},
        {"Geneva Identification System", "GEN# +1.00120349"},
        {"Smithsonian Astrophysical Observation", "SAO 63756"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.08387639),
        dec: Angle.Degrees(+31.40105888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33862"},
        {"Hipparcos Number", "HIP 24447"},
        {"Smithsonian Astrophysical Observation", "SAO 57789"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.66435054),
        dec: Angle.Degrees(+31.40202928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28696"},
        {"Hipparcos Number", "HIP 21196"},
        {"Smithsonian Astrophysical Observation", "SAO 57294"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.17014482),
        dec: Angle.Degrees(+31.40503241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167006"},
        {"Hipparcos Number", "HIP 89172"},
        {"Fundamental Katalog 5th Edition", "FK5 3448"},
        {"Geneva Identification System", "GEN# +1.00167006"},
        {"Smithsonian Astrophysical Observation", "SAO 66737"},
        {"Wilson Evans Batten Catalogue", "WEB 15148"},
    },
    visualMagnitude: 4.96,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.97569523),
        dec: Angle.Degrees(+31.40528840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92178",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11685 AB"},
        {"Henry Draper", "HD 174022"},
        {"Hipparcos Number", "HIP 92178"},
        {"Geneva Identification System", "GEN# +1.00174022J"},
        {"Smithsonian Astrophysical Observation", "SAO 67378"},
        {"Wilson Evans Batten Catalogue", "WEB 15896"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.80451994),
        dec: Angle.Degrees(+31.40556769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112909"},
        {"Wilson Evans Batten Catalogue", "WEB 20107"},
    },
    visualMagnitude: 11.66,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.97156518),
        dec: Angle.Degrees(+31.75433773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 527.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15883"},
        {"Hipparcos Number", "HIP 11933"},
        {"Smithsonian Astrophysical Observation", "SAO 55661"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.49770358),
        dec: Angle.Degrees(+31.40638265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185999"},
        {"Hipparcos Number", "HIP 96804"},
        {"Smithsonian Astrophysical Observation", "SAO 68679"},
        {"Wilson Evans Batten Catalogue", "WEB 16988"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.17097856),
        dec: Angle.Degrees(+31.40649722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21030"},
        {"Hipparcos Number", "HIP 15889"},
        {"Smithsonian Astrophysical Observation", "SAO 56420"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.16347339),
        dec: Angle.Degrees(+31.40761605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24885"},
        {"Hipparcos Number", "HIP 18578"},
        {"Smithsonian Astrophysical Observation", "SAO 56853"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.64770386),
        dec: Angle.Degrees(+31.40844920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11901",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1947 A"},
        {"Henry Draper", "HD 15832"},
        {"Hipparcos Number", "HIP 11901"},
        {"Smithsonian Astrophysical Observation", "SAO 55658"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.39023836),
        dec: Angle.Degrees(+31.40851731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154509"},
        {"Hipparcos Number", "HIP 83551"},
        {"Geneva Identification System", "GEN# +1.00154509"},
        {"Smithsonian Astrophysical Observation", "SAO 65775"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.13416641),
        dec: Angle.Degrees(+31.41136067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41415"},
        {"Hipparcos Number", "HIP 28929"},
        {"Geneva Identification System", "GEN# +1.00041415"},
        {"Smithsonian Astrophysical Observation", "SAO 58748"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.59130923),
        dec: Angle.Degrees(+31.41340558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20812"},
        {"Hipparcos Number", "HIP 15704"},
        {"Smithsonian Astrophysical Observation", "SAO 56387"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.57643749),
        dec: Angle.Degrees(+31.41423907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16243",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16243"},
        {"Geneva Identification System", "GEN# +0.03000549"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.33238266),
        dec: Angle.Degrees(+31.41586757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16637"},
        {"Hipparcos Number", "HIP 12500"},
        {"Smithsonian Astrophysical Observation", "SAO 55780"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.21301843),
        dec: Angle.Degrees(+31.41920245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104336"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.03120617),
        dec: Angle.Degrees(+31.42142813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91230"},
        {"Hipparcos Number", "HIP 51606"},
        {"Smithsonian Astrophysical Observation", "SAO 62110"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.12474847),
        dec: Angle.Degrees(+31.42205688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252521"},
        {"Hipparcos Number", "HIP 29283"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.60748943),
        dec: Angle.Degrees(+31.42292034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108944"},
        {"Hipparcos Number", "HIP 61072"},
        {"Geneva Identification System", "GEN# +1.00108944"},
        {"Smithsonian Astrophysical Observation", "SAO 63037"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.75304414),
        dec: Angle.Degrees(+31.42376982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186777"},
        {"Hipparcos Number", "HIP 97201"},
        {"Celescope Catalog", "CEL 4833"},
        {"Geneva Identification System", "GEN# +1.00186777"},
        {"Smithsonian Astrophysical Observation", "SAO 68793"},
        {"Wilson Evans Batten Catalogue", "WEB 17065"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.32150332),
        dec: Angle.Degrees(+31.42409214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7034"},
        {"Hipparcos Number", "HIP 5544"},
        {"Geneva Identification System", "GEN# +1.00007034"},
        {"Smithsonian Astrophysical Observation", "SAO 54493"},
        {"Wilson Evans Batten Catalogue", "WEB 1236"},
    },
    visualMagnitude: 5.15,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.77822190),
        dec: Angle.Degrees(+31.42476555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88677"},
        {"Hipparcos Number", "HIP 50143"},
        {"Geneva Identification System", "GEN# +1.00088677"},
        {"Smithsonian Astrophysical Observation", "SAO 61943"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.54570195),
        dec: Angle.Degrees(+31.42487661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87584"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.37892529),
        dec: Angle.Degrees(+31.42504913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25711",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4067 AB"},
        {"Henry Draper", "HD 244022"},
        {"Hipparcos Number", "HIP 25711"},
        {"Smithsonian Astrophysical Observation", "SAO 58096"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.35267600),
        dec: Angle.Degrees(+31.42633760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50654"},
        {"Smithsonian Astrophysical Observation", "SAO 61989"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.17015215),
        dec: Angle.Degrees(+31.42836071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250047"},
        {"Hipparcos Number", "HIP 28445"},
        {"Geneva Identification System", "GEN# +1.00250047"},
        {"Smithsonian Astrophysical Observation", "SAO 58648"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.08907987),
        dec: Angle.Degrees(+31.43079299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -299.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187180"},
        {"Hipparcos Number", "HIP 97363"},
        {"Geneva Identification System", "GEN# +1.00187180"},
        {"Smithsonian Astrophysical Observation", "SAO 68853"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.84394750),
        dec: Angle.Degrees(+31.43117645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4469"},
        {"Smithsonian Astrophysical Observation", "SAO 54287"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.32156118),
        dec: Angle.Degrees(+31.43261727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46464"},
        {"Hipparcos Number", "HIP 31414"},
        {"Smithsonian Astrophysical Observation", "SAO 59257"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.75830374),
        dec: Angle.Degrees(+31.43467623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85317"},
        {"Hipparcos Number", "HIP 48373"},
        {"Geneva Identification System", "GEN# +1.00085317"},
        {"Smithsonian Astrophysical Observation", "SAO 61719"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.91719483),
        dec: Angle.Degrees(+31.43655319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95977"},
        {"Hipparcos Number", "HIP 54150"},
        {"Geneva Identification System", "GEN# +1.00095977"},
        {"Smithsonian Astrophysical Observation", "SAO 62390"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.16276207),
        dec: Angle.Degrees(+31.43667069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30454"},
        {"Hipparcos Number", "HIP 22393"},
        {"Fundamental Katalog 5th Edition", "FK5 2359"},
        {"Geneva Identification System", "GEN# +1.00030454"},
        {"Smithsonian Astrophysical Observation", "SAO 57441"},
        {"Wilson Evans Batten Catalogue", "WEB 4316"},
    },
    visualMagnitude: 5.57,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.30347923),
        dec: Angle.Degrees(+31.43762493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10516"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.87373535),
        dec: Angle.Degrees(+31.43825643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27971"},
        {"Hipparcos Number", "HIP 20704"},
        {"Fundamental Katalog 5th Edition", "FK5 2325"},
        {"Geneva Identification System", "GEN# +1.00027971"},
        {"Smithsonian Astrophysical Observation", "SAO 57229"},
        {"Wilson Evans Batten Catalogue", "WEB 3968"},
    },
    visualMagnitude: 5.29,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.52607257),
        dec: Angle.Degrees(+31.43920664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177878"},
        {"Hipparcos Number", "HIP 93738"},
        {"Geneva Identification System", "GEN# +1.00177878"},
        {"Smithsonian Astrophysical Observation", "SAO 67792"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.30113650),
        dec: Angle.Degrees(+31.43920760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120279"},
        {"Hipparcos Number", "HIP 67327"},
        {"Geneva Identification System", "GEN# +1.00120279"},
        {"Smithsonian Astrophysical Observation", "SAO 63753"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.99352858),
        dec: Angle.Degrees(+31.44057106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84603"},
        {"Smithsonian Astrophysical Observation", "SAO 65918"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.40818443),
        dec: Angle.Degrees(+31.44819768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209193"},
        {"Hipparcos Number", "HIP 108660"},
        {"Geneva Identification System", "GEN# +1.00209193"},
        {"Smithsonian Astrophysical Observation", "SAO 71937"},
        {"Wilson Evans Batten Catalogue", "WEB 19553"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.18951213),
        dec: Angle.Degrees(+31.45007070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47883"},
        {"Hipparcos Number", "HIP 32083"},
        {"Geneva Identification System", "GEN# +1.00047883"},
        {"Smithsonian Astrophysical Observation", "SAO 59383"},
        {"Wilson Evans Batten Catalogue", "WEB 6474"},
    },
    visualMagnitude: 8.23,
    bvColour: 2.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.53577472),
        dec: Angle.Degrees(+31.45489044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33049",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33049"},
    },
    visualMagnitude: 11.33,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.27357999),
        dec: Angle.Degrees(+31.45496503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114224",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16528 A"},
        {"Henry Draper", "HD 218472"},
        {"Hipparcos Number", "HIP 114224"},
        {"Smithsonian Astrophysical Observation", "SAO 73021"},
        {"Wilson Evans Batten Catalogue", "WEB 20285"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.98002519),
        dec: Angle.Degrees(+31.45888857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5035"},
        {"Hipparcos Number", "HIP 4103"},
        {"Geneva Identification System", "GEN# +1.00005035"},
        {"Smithsonian Astrophysical Observation", "SAO 54221"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.16671383),
        dec: Angle.Degrees(+31.45946741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 213.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331860"},
        {"Hipparcos Number", "HIP 99161"},
        {"Smithsonian Astrophysical Observation", "SAO 69464"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.97772715),
        dec: Angle.Degrees(+31.46217045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265345"},
        {"Hipparcos Number", "HIP 33047"},
        {"Smithsonian Astrophysical Observation", "SAO 59578"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.26943210),
        dec: Angle.Degrees(+31.46236195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200479"},
        {"Hipparcos Number", "HIP 103864"},
        {"Smithsonian Astrophysical Observation", "SAO 70822"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.68321083),
        dec: Angle.Degrees(+31.46397222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34456",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34456"},
        {"Smithsonian Astrophysical Observation", "SAO 59813"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.13964426),
        dec: Angle.Degrees(+31.46616182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222557"},
        {"Hipparcos Number", "HIP 116881"},
        {"Smithsonian Astrophysical Observation", "SAO 73437"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.36991524),
        dec: Angle.Degrees(+31.46737972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88786"},
        {"Hipparcos Number", "HIP 50218"},
        {"Geneva Identification System", "GEN# +1.00088786"},
        {"Smithsonian Astrophysical Observation", "SAO 61953"},
        {"Wilson Evans Batten Catalogue", "WEB 9224"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.77651322),
        dec: Angle.Degrees(+31.46807457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135079"},
        {"Hipparcos Number", "HIP 74403"},
        {"Smithsonian Astrophysical Observation", "SAO 64553"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.09421552),
        dec: Angle.Degrees(+31.46959614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153559"},
        {"Hipparcos Number", "HIP 83109"},
        {"Geneva Identification System", "GEN# +1.00153559"},
        {"Smithsonian Astrophysical Observation", "SAO 65696"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.74325084),
        dec: Angle.Degrees(+31.46994621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86512"},
        {"Hipparcos Number", "HIP 48997"},
        {"Smithsonian Astrophysical Observation", "SAO 61802"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.94397259),
        dec: Angle.Degrees(+31.47128724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258183"},
        {"Hipparcos Number", "HIP 30991"},
        {"Smithsonian Astrophysical Observation", "SAO 59156"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.57231470),
        dec: Angle.Degrees(+31.47199984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140065"},
        {"Hipparcos Number", "HIP 76777"},
        {"Smithsonian Astrophysical Observation", "SAO 64839"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.13825992),
        dec: Angle.Degrees(+31.47217085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42980"},
        {"Hipparcos Number", "HIP 29688"},
        {"Geneva Identification System", "GEN# +1.00042980"},
        {"Smithsonian Astrophysical Observation", "SAO 58898"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.81479174),
        dec: Angle.Degrees(+31.47259347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145932"},
        {"Hipparcos Number", "HIP 79408"},
        {"Smithsonian Astrophysical Observation", "SAO 65142"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.08684623),
        dec: Angle.Degrees(+31.47622283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111717"},
        {"Hipparcos Number", "HIP 62706"},
        {"Geneva Identification System", "GEN# +1.00111717"},
        {"Smithsonian Astrophysical Observation", "SAO 63221"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.74838051),
        dec: Angle.Degrees(+31.47622442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216716"},
        {"Hipparcos Number", "HIP 113147"},
        {"Smithsonian Astrophysical Observation", "SAO 72831"},
        {"Wilson Evans Batten Catalogue", "WEB 20138"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.68664888),
        dec: Angle.Degrees(+31.47877630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46657"},
        {"Hipparcos Number", "HIP 31520"},
        {"Smithsonian Astrophysical Observation", "SAO 59272"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.99739955),
        dec: Angle.Degrees(+31.47929814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136654"},
        {"Hipparcos Number", "HIP 75104"},
        {"Geneva Identification System", "GEN# +1.00136654"},
        {"Smithsonian Astrophysical Observation", "SAO 64647"},
        {"Wilson Evans Batten Catalogue", "WEB 12809"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.20916798),
        dec: Angle.Degrees(+31.47977003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 138.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71748"},
        {"Cincinnati Publication", "Ci 20 877"},
    },
    visualMagnitude: 11.74,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.13994823),
        dec: Angle.Degrees(+31.48176238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -852.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55602"},
        {"Hipparcos Number", "HIP 35048"},
        {"Smithsonian Astrophysical Observation", "SAO 59915"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.72108425),
        dec: Angle.Degrees(+31.48476663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3397"},
        {"Hipparcos Number", "HIP 2923"},
        {"Geneva Identification System", "GEN# +1.00003397"},
        {"Smithsonian Astrophysical Observation", "SAO 54036"},
        {"Wilson Evans Batten Catalogue", "WEB 530"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.26483330),
        dec: Angle.Degrees(+31.48648077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8243",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8243"},
        {"Smithsonian Astrophysical Observation", "SAO 54962"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.53688746),
        dec: Angle.Degrees(+31.48694633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110080",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110080"},
        {"Smithsonian Astrophysical Observation", "SAO 72211"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.46316337),
        dec: Angle.Degrees(+31.48989147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25310"},
        {"Hipparcos Number", "HIP 18848"},
        {"Smithsonian Astrophysical Observation", "SAO 56918"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.61892314),
        dec: Angle.Degrees(+31.49112881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119875"},
        {"Hipparcos Number", "HIP 67110"},
        {"Geneva Identification System", "GEN# +1.00119875"},
        {"Smithsonian Astrophysical Observation", "SAO 63721"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.33139673),
        dec: Angle.Degrees(+31.49155088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107165"},
        {"Smithsonian Astrophysical Observation", "SAO 71620"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.60122171),
        dec: Angle.Degrees(+31.49473016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186258"},
        {"Hipparcos Number", "HIP 96914"},
        {"Smithsonian Astrophysical Observation", "SAO 68710"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.50512106),
        dec: Angle.Degrees(+31.49545252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25658"},
        {"Hipparcos Number", "HIP 19087"},
        {"Smithsonian Astrophysical Observation", "SAO 56961"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.38934626),
        dec: Angle.Degrees(+31.49722869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212376"},
        {"Hipparcos Number", "HIP 110517"},
        {"Smithsonian Astrophysical Observation", "SAO 72290"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.83330061),
        dec: Angle.Degrees(+31.50108905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6273"},
        {"Hipparcos Number", "HIP 5005"},
        {"Smithsonian Astrophysical Observation", "SAO 54394"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.02575314),
        dec: Angle.Degrees(+31.50233764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108833"},
        {"Hipparcos Number", "HIP 61009"},
        {"Geneva Identification System", "GEN# +1.00108833"},
        {"Wilson Evans Batten Catalogue", "WEB 10861"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.55167799),
        dec: Angle.Degrees(+31.50333863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161695"},
        {"Hipparcos Number", "HIP 86925"},
        {"Fundamental Katalog 5th Edition", "FK5 3410"},
        {"Geneva Identification System", "GEN# +1.00161695"},
        {"Smithsonian Astrophysical Observation", "SAO 66311"},
        {"Wilson Evans Batten Catalogue", "WEB 14664"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.41763106),
        dec: Angle.Degrees(+31.50468387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99967",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13630 A"},
        {"Henry Draper", "HD 193010"},
        {"Hipparcos Number", "HIP 99967"},
        {"Celescope Catalog", "CEL 5009"},
        {"Geneva Identification System", "GEN# +1.00193010"},
        {"Smithsonian Astrophysical Observation", "SAO 69743"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.22912783),
        dec: Angle.Degrees(+31.50524135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187279"},
        {"Hipparcos Number", "HIP 97416"},
        {"Celescope Catalog", "CEL 4847"},
        {"Geneva Identification System", "GEN# +1.00187279"},
        {"Smithsonian Astrophysical Observation", "SAO 68870"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.99849504),
        dec: Angle.Degrees(+31.50624610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72305"},
        {"Hipparcos Number", "HIP 41962"},
        {"Smithsonian Astrophysical Observation", "SAO 60894"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.29648588),
        dec: Angle.Degrees(+31.50894831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104588"},
        {"Hipparcos Number", "HIP 58725"},
        {"Smithsonian Astrophysical Observation", "SAO 62812"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.68775107),
        dec: Angle.Degrees(+31.51041570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36085"},
        {"Hipparcos Number", "HIP 25801"},
        {"Geneva Identification System", "GEN# +1.00036085"},
        {"Smithsonian Astrophysical Observation", "SAO 58130"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.64967504),
        dec: Angle.Degrees(+31.51105520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15630"},
        {"Hipparcos Number", "HIP 11749"},
        {"Smithsonian Astrophysical Observation", "SAO 55628"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.89814499),
        dec: Angle.Degrees(+31.51334386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56498"},
        {"Smithsonian Astrophysical Observation", "SAO 62610"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.74110116),
        dec: Angle.Degrees(+31.51550140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1439"},
        {"Hipparcos Number", "HIP 1493"},
        {"Fundamental Katalog 5th Edition", "FK5 1006"},
        {"Geneva Identification System", "GEN# +1.00001439"},
        {"Smithsonian Astrophysical Observation", "SAO 53803"},
        {"Wilson Evans Batten Catalogue", "WEB 276"},
    },
    visualMagnitude: 5.88,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.65924059),
        dec: Angle.Degrees(+31.51723388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156651"},
        {"Hipparcos Number", "HIP 84587"},
        {"Smithsonian Astrophysical Observation", "SAO 65915"},
        {"Wilson Evans Batten Catalogue", "WEB 14283"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.36038819),
        dec: Angle.Degrees(+31.51839209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76540"},
        {"Hipparcos Number", "HIP 44013"},
        {"Smithsonian Astrophysical Observation", "SAO 61156"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.43681879),
        dec: Angle.Degrees(+31.51922913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196629"},
        {"Hipparcos Number", "HIP 101768"},
        {"Geneva Identification System", "GEN# +1.00196629"},
        {"Smithsonian Astrophysical Observation", "SAO 70289"},
        {"Wilson Evans Batten Catalogue", "WEB 18384"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.38638877),
        dec: Angle.Degrees(+31.52198719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7500"},
        {"Hipparcos Number", "HIP 5883"},
        {"Smithsonian Astrophysical Observation", "SAO 54558"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.88529031),
        dec: Angle.Degrees(+31.52408988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13372"},
        {"Hipparcos Number", "HIP 10220"},
        {"Fundamental Katalog 5th Edition", "FK5 2148"},
        {"Geneva Identification System", "GEN# +1.00013372"},
        {"Renson", "Renson 3460"},
        {"Smithsonian Astrophysical Observation", "SAO 55338"},
        {"Wilson Evans Batten Catalogue", "WEB 2131"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.85416096),
        dec: Angle.Degrees(+31.52642246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207370"},
        {"Hipparcos Number", "HIP 107600"},
        {"Smithsonian Astrophysical Observation", "SAO 71710"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.92024867),
        dec: Angle.Degrees(+31.52842804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55203",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alula Australis"},
        {"Aitken", "ADS 8119 AB"},
        {"Hipparcos Number", "HIP 55203"},
        {"Cincinnati Publication", "Ci 20 627"},
        {"Geneva Identification System", "GEN# +1.00098231"},
        {"Smithsonian Astrophysical Observation", "SAO 62484"},
    },
    visualMagnitude: 3.79,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)18, 11.2400),
        dec: Angle.DegreesMinutesSeconds((int)+31, (int)31, 50.800)
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
    primaryId: "HIP 49173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86873"},
        {"Hipparcos Number", "HIP 49173"},
        {"Geneva Identification System", "GEN# +1.00086873"},
        {"Smithsonian Astrophysical Observation", "SAO 61820"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.52526572),
        dec: Angle.Degrees(+31.53132326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26022"},
        {"Hipparcos Number", "HIP 19317"},
        {"Smithsonian Astrophysical Observation", "SAO 57008"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.11447774),
        dec: Angle.Degrees(+31.53264119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93166"},
        {"Smithsonian Astrophysical Observation", "SAO 67657"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.66029150),
        dec: Angle.Degrees(+31.53278997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206137"},
        {"Hipparcos Number", "HIP 106934"},
        {"Geneva Identification System", "GEN# +1.00206137"},
        {"Smithsonian Astrophysical Observation", "SAO 71565"},
        {"Wilson Evans Batten Catalogue", "WEB 19323"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.85423187),
        dec: Angle.Degrees(+31.53320860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115380"},
        {"Hipparcos Number", "HIP 64780"},
        {"Smithsonian Astrophysical Observation", "SAO 63438"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.13519678),
        dec: Angle.Degrees(+31.53323808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209205"},
        {"Hipparcos Number", "HIP 108672"},
        {"Fundamental Katalog 5th Edition", "FK5 5945"},
        {"Smithsonian Astrophysical Observation", "SAO 71939"},
        {"Wilson Evans Batten Catalogue", "WEB 19554"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.22880853),
        dec: Angle.Degrees(+31.53428712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91605",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11576 A"},
        {"Hipparcos Number", "HIP 91605"},
        {"Cincinnati Publication", "Ci 18 2450"},
        {"Cincinnati Publication 2", "Ci 20 1103"},
        {"Geneva Identification System", "GEN# +0.03103330A"},
        {"Wilson Evans Batten Catalogue", "WEB 15753"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.22843563),
        dec: Angle.Degrees(+31.53511253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -837.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1075"},
        {"Hipparcos Number", "HIP 1208"},
        {"Smithsonian Astrophysical Observation", "SAO 53755"},
        {"Wilson Evans Batten Catalogue", "WEB 217"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.77886512),
        dec: Angle.Degrees(+31.53573771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167491"},
        {"Hipparcos Number", "HIP 89360"},
        {"Geneva Identification System", "GEN# +1.00167491"},
        {"Smithsonian Astrophysical Observation", "SAO 66778"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.52024767),
        dec: Angle.Degrees(+31.53985391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331096"},
        {"Hipparcos Number", "HIP 96925"},
        {"Smithsonian Astrophysical Observation", "SAO 68716"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.53578888),
        dec: Angle.Degrees(+31.54077516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85427"},
        {"Hipparcos Number", "HIP 48435"},
        {"Geneva Identification System", "GEN# +1.00085427"},
        {"Smithsonian Astrophysical Observation", "SAO 61730"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.12083159),
        dec: Angle.Degrees(+31.54257489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191425"},
        {"Hipparcos Number", "HIP 99235"},
        {"Smithsonian Astrophysical Observation", "SAO 69489"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.16285594),
        dec: Angle.Degrees(+31.54354824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89792"},
        {"Hipparcos Number", "HIP 50800"},
        {"Smithsonian Astrophysical Observation", "SAO 62001"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.58201347),
        dec: Angle.Degrees(+31.54446013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6675",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1134 C"},
        {"Henry Draper", "HD 8624"},
        {"Hipparcos Number", "HIP 6675"},
        {"Geneva Identification System", "GEN# +1.00008624"},
        {"Smithsonian Astrophysical Observation", "SAO 54689"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.41018166),
        dec: Angle.Degrees(+31.54628825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51999"},
    },
    visualMagnitude: 10.24,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.35185896),
        dec: Angle.Degrees(+31.54833512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194110"},
        {"Hipparcos Number", "HIP 100503"},
        {"Smithsonian Astrophysical Observation", "SAO 69922"},
        {"Wilson Evans Batten Catalogue", "WEB 18150"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.69595791),
        dec: Angle.Degrees(+31.54954947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86729"},
        {"Hipparcos Number", "HIP 49088"},
        {"Smithsonian Astrophysical Observation", "SAO 61809"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.28917115),
        dec: Angle.Degrees(+31.54990379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8610"},
        {"Hipparcos Number", "HIP 6668"},
        {"Smithsonian Astrophysical Observation", "SAO 54687"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.39238174),
        dec: Angle.Degrees(+31.55053143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26385"},
        {"Hipparcos Number", "HIP 19576"},
        {"Renson", "Renson 6680"},
        {"Smithsonian Astrophysical Observation", "SAO 57056"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.92171304),
        dec: Angle.Degrees(+31.55073448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67087"},
        {"Hipparcos Number", "HIP 39767"},
        {"Geneva Identification System", "GEN# +1.00067087"},
        {"Smithsonian Astrophysical Observation", "SAO 60580"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.91569601),
        dec: Angle.Degrees(+31.55140720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118052"},
        {"Hipparcos Number", "HIP 66186"},
        {"Geneva Identification System", "GEN# +1.00118052"},
        {"Smithsonian Astrophysical Observation", "SAO 63610"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.47829629),
        dec: Angle.Degrees(+31.55147599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139724"},
        {"Hipparcos Number", "HIP 76610"},
        {"Smithsonian Astrophysical Observation", "SAO 64824"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.67712208),
        dec: Angle.Degrees(+31.55185691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78164"},
        {"Smithsonian Astrophysical Observation", "SAO 64987"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.41354963),
        dec: Angle.Degrees(+31.55245450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23974"},
        {"Hipparcos Number", "HIP 17966"},
        {"Geneva Identification System", "GEN# +1.00023974"},
        {"Smithsonian Astrophysical Observation", "SAO 56738"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.61461297),
        dec: Angle.Degrees(+31.55362778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137050"},
        {"Hipparcos Number", "HIP 75283"},
        {"Geneva Identification System", "GEN# +1.00137050"},
        {"Smithsonian Astrophysical Observation", "SAO 64671"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.72027615),
        dec: Angle.Degrees(+31.55396957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113207"},
        {"Smithsonian Astrophysical Observation", "SAO 72845"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.87884648),
        dec: Angle.Degrees(+31.55431757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109819",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15770 AB"},
        {"Henry Draper", "HD 211151"},
        {"Hipparcos Number", "HIP 109819"},
        {"Smithsonian Astrophysical Observation", "SAO 72164"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.65086668),
        dec: Angle.Degrees(+31.55742474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174434"},
        {"Hipparcos Number", "HIP 92338"},
        {"Smithsonian Astrophysical Observation", "SAO 67421"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.28863925),
        dec: Angle.Degrees(+31.55915586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109601"},
        {"Cincinnati Publication", "Ci 20 1344"},
        {"Geneva Identification System", "GEN# +0.03004633"},
        {"Wilson Evans Batten Catalogue", "WEB 19694"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.02771721),
        dec: Angle.Degrees(+31.56242247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -345.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -418.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50136"},
        {"Smithsonian Astrophysical Observation", "SAO 61942"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.52709868),
        dec: Angle.Degrees(+31.56295385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122456"},
        {"Hipparcos Number", "HIP 68501"},
        {"Fundamental Katalog 5th Edition", "FK5 5245"},
        {"Geneva Identification System", "GEN# +1.00122456"},
        {"Smithsonian Astrophysical Observation", "SAO 63889"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.34302988),
        dec: Angle.Degrees(+31.56369191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104126"},
        {"Smithsonian Astrophysical Observation", "SAO 70892"},
    },
    visualMagnitude: 8.99,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.42886385),
        dec: Angle.Degrees(+31.56584645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30651"},
        {"Hipparcos Number", "HIP 22523"},
        {"Smithsonian Astrophysical Observation", "SAO 57454"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.70038672),
        dec: Angle.Degrees(+31.56590486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268079"},
        {"Hipparcos Number", "HIP 33940"},
        {"Geneva Identification System", "GEN# +1.00268079"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.65203918),
        dec: Angle.Degrees(+31.56610186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -360.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143687"},
        {"Hipparcos Number", "HIP 78429"},
        {"Fundamental Katalog 5th Edition", "FK5 5412"},
        {"Geneva Identification System", "GEN# +1.00143687"},
        {"Smithsonian Astrophysical Observation", "SAO 65019"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.17697004),
        dec: Angle.Degrees(+31.56837303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33773"},
        {"Hipparcos Number", "HIP 24388"},
        {"Smithsonian Astrophysical Observation", "SAO 57771"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.48564077),
        dec: Angle.Degrees(+31.57163393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129355"},
        {"Hipparcos Number", "HIP 71802"},
        {"Geneva Identification System", "GEN# +1.00129355"},
        {"Smithsonian Astrophysical Observation", "SAO 64273"},
        {"Wilson Evans Batten Catalogue", "WEB 12369"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.30577137),
        dec: Angle.Degrees(+31.57212862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196606"},
        {"Hipparcos Number", "HIP 101765"},
        {"Celescope Catalog", "CEL 5129"},
        {"Geneva Identification System", "GEN# +1.00196606"},
        {"Renson", "Renson 54840"},
        {"Smithsonian Astrophysical Observation", "SAO 70287"},
        {"Wilson Evans Batten Catalogue", "WEB 18383"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.38238346),
        dec: Angle.Degrees(+31.57254134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91351"},
        {"Smithsonian Astrophysical Observation", "SAO 67183"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.48438867),
        dec: Angle.Degrees(+31.57372482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88307"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.50615142),
        dec: Angle.Degrees(+31.57761006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124441"},
        {"Hipparcos Number", "HIP 69437"},
        {"Smithsonian Astrophysical Observation", "SAO 63989"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.24712568),
        dec: Angle.Degrees(+31.57770548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97384"},
        {"Hipparcos Number", "HIP 54762"},
        {"Smithsonian Astrophysical Observation", "SAO 62455"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.18328037),
        dec: Angle.Degrees(+31.57775973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89233"},
        {"Smithsonian Astrophysical Observation", "SAO 66747"},
        {"Wilson Evans Batten Catalogue", "WEB 15169"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.14210080),
        dec: Angle.Degrees(+31.57981136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15866"},
        {"Hipparcos Number", "HIP 11924"},
        {"Geneva Identification System", "GEN# +1.00015866"},
        {"Smithsonian Astrophysical Observation", "SAO 55660"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.47612572),
        dec: Angle.Degrees(+31.58071974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144600"},
        {"Hipparcos Number", "HIP 78829"},
        {"Smithsonian Astrophysical Observation", "SAO 65069"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.37647357),
        dec: Angle.Degrees(+31.58340077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69833"},
        {"Geneva Identification System", "GEN# +0.03202453"},
        {"Smithsonian Astrophysical Observation", "SAO 64049"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.38041559),
        dec: Angle.Degrees(+31.58503966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23205",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3581 AB"},
        {"Henry Draper", "HD 31734"},
        {"Hipparcos Number", "HIP 23205"},
        {"Smithsonian Astrophysical Observation", "SAO 57556"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.90275920),
        dec: Angle.Degrees(+31.58523136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70401"},
        {"Hipparcos Number", "HIP 41086"},
        {"Geneva Identification System", "GEN# +1.00070401"},
        {"Smithsonian Astrophysical Observation", "SAO 60768"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.74026375),
        dec: Angle.Degrees(+31.58551036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88019"},
        {"Hipparcos Number", "HIP 49770"},
        {"Smithsonian Astrophysical Observation", "SAO 61903"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.38419745),
        dec: Angle.Degrees(+31.58717575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9134",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9134"},
        {"Smithsonian Astrophysical Observation", "SAO 55142"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.43661661),
        dec: Angle.Degrees(+31.58760651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 218.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282466"},
        {"Hipparcos Number", "HIP 22241"},
        {"Smithsonian Astrophysical Observation", "SAO 57429"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.78117796),
        dec: Angle.Degrees(+31.58845381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151714"},
        {"Hipparcos Number", "HIP 82226"},
        {"Smithsonian Astrophysical Observation", "SAO 65561"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.96852841),
        dec: Angle.Degrees(+31.58972477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331092"},
        {"Hipparcos Number", "HIP 96850"},
        {"Geneva Identification System", "GEN# +1.00331092"},
        {"Smithsonian Astrophysical Observation", "SAO 68692"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.29720469),
        dec: Angle.Degrees(+31.59060422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199515"},
        {"Hipparcos Number", "HIP 103382"},
        {"Smithsonian Astrophysical Observation", "SAO 70698"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.18258513),
        dec: Angle.Degrees(+31.59106940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65470"},
        {"Hipparcos Number", "HIP 39109"},
        {"Smithsonian Astrophysical Observation", "SAO 60510"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.01875429),
        dec: Angle.Degrees(+31.59178302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90942"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.26319712),
        dec: Angle.Degrees(+31.59360954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83631"},
        {"Hipparcos Number", "HIP 47477"},
        {"Smithsonian Astrophysical Observation", "SAO 61623"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.17151584),
        dec: Angle.Degrees(+31.59471270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90937"},
        {"Smithsonian Astrophysical Observation", "SAO 67094"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.25540319),
        dec: Angle.Degrees(+31.59527127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170877"},
        {"Hipparcos Number", "HIP 90702"},
        {"Smithsonian Astrophysical Observation", "SAO 67037"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.58324059),
        dec: Angle.Degrees(+31.59766369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97776"},
        {"Hipparcos Number", "HIP 54962"},
        {"Smithsonian Astrophysical Observation", "SAO 62463"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.82811460),
        dec: Angle.Degrees(+31.59826674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81693",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10157 AB"},
        {"Henry Draper", "HD 150680"},
        {"Hipparcos Number", "HIP 81693"},
        {"Cincinnati Publication", "Ci 20 1007"},
        {"Geneva Identification System", "GEN# +1.00150680"},
        {"Smithsonian Astrophysical Observation", "SAO 65485"},
        {"Wilson Evans Batten Catalogue", "WEB 13799"},
    },
    visualMagnitude: 2.81,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.32282132),
        dec: Angle.Degrees(+31.60188695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -462.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 345.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93725"},
        {"Smithsonian Astrophysical Observation", "SAO 67786"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.25741425),
        dec: Angle.Degrees(+31.60188770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188036"},
        {"Hipparcos Number", "HIP 97755"},
        {"Celescope Catalog", "CEL 4861"},
        {"Geneva Identification System", "GEN# +1.00188036"},
        {"Smithsonian Astrophysical Observation", "SAO 68985"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.99353815),
        dec: Angle.Degrees(+31.60294423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49658",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7651 AB"},
        {"Henry Draper", "HD 87822"},
        {"Hipparcos Number", "HIP 49658"},
        {"Geneva Identification System", "GEN# +1.00087822"},
        {"Smithsonian Astrophysical Observation", "SAO 61882"},
        {"Wilson Evans Batten Catalogue", "WEB 9159"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.06642598),
        dec: Angle.Degrees(+31.60427591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55055",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8109 AB"},
        {"Henry Draper", "HD 97936"},
        {"Hipparcos Number", "HIP 55055"},
        {"Smithsonian Astrophysical Observation", "SAO 62471"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.06241144),
        dec: Angle.Degrees(+31.60501618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16187"},
        {"Hipparcos Number", "HIP 12160"},
        {"Geneva Identification System", "GEN# +1.00016187"},
        {"Smithsonian Astrophysical Observation", "SAO 55703"},
        {"Wilson Evans Batten Catalogue", "WEB 2498"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.17937710),
        dec: Angle.Degrees(+31.60766603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15710"},
        {"Smithsonian Astrophysical Observation", "SAO 56388"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.59429884),
        dec: Angle.Degrees(+31.60914017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183650"},
        {"Hipparcos Number", "HIP 95821"},
        {"Cincinnati Publication", "Ci 20 1154"},
        {"Cincinnati Publication 2", "Ci 18 2539"},
        {"Geneva Identification System", "GEN# +1.00183650"},
        {"Smithsonian Astrophysical Observation", "SAO 68384"},
        {"Wilson Evans Batten Catalogue", "WEB 16777"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.33942055),
        dec: Angle.Degrees(+31.60965599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -411.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208288"},
        {"Hipparcos Number", "HIP 108141"},
        {"Geneva Identification System", "GEN# +1.00208288"},
        {"Smithsonian Astrophysical Observation", "SAO 71818"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.64060046),
        dec: Angle.Degrees(+31.61023376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6890"},
        {"Geneva Identification System", "GEN# +0.03000228"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.18472201),
        dec: Angle.Degrees(+31.61107515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 371.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63610"},
        {"Hipparcos Number", "HIP 38317"},
        {"Geneva Identification System", "GEN# +1.00063610"},
        {"Smithsonian Astrophysical Observation", "SAO 60380"},
        {"Wilson Evans Batten Catalogue", "WEB 7538"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.75085419),
        dec: Angle.Degrees(+31.61363455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60800"},
        {"Hipparcos Number", "HIP 37108"},
        {"Smithsonian Astrophysical Observation", "SAO 60231"},
        {"Wilson Evans Batten Catalogue", "WEB 7358"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.37962724),
        dec: Angle.Degrees(+31.61373552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57130"},
        {"Hipparcos Number", "HIP 35637"},
        {"Smithsonian Astrophysical Observation", "SAO 59995"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.31138386),
        dec: Angle.Degrees(+31.61414433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132864"},
        {"Hipparcos Number", "HIP 73438"},
        {"Geneva Identification System", "GEN# +1.00132864"},
        {"Smithsonian Astrophysical Observation", "SAO 64460"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.10924488),
        dec: Angle.Degrees(+31.61495310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -201.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128703"},
        {"Hipparcos Number", "HIP 71518"},
        {"Geneva Identification System", "GEN# +1.00128703"},
        {"Smithsonian Astrophysical Observation", "SAO 64243"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.39615037),
        dec: Angle.Degrees(+31.61522514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118537"},
        {"Hipparcos Number", "HIP 66420"},
        {"Geneva Identification System", "GEN# +1.00118537"},
        {"Smithsonian Astrophysical Observation", "SAO 63645"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.25164748),
        dec: Angle.Degrees(+31.61580151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63631"},
        {"Hipparcos Number", "HIP 38329"},
        {"Geneva Identification System", "GEN# +1.00063631"},
        {"Smithsonian Astrophysical Observation", "SAO 60383"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.77575420),
        dec: Angle.Degrees(+31.61605131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139494"},
        {"Hipparcos Number", "HIP 76493"},
        {"Smithsonian Astrophysical Observation", "SAO 64812"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.34957302),
        dec: Angle.Degrees(+31.61714191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223609"},
        {"Hipparcos Number", "HIP 117592"},
        {"Geneva Identification System", "GEN# +1.00223609"},
        {"Smithsonian Astrophysical Observation", "SAO 73548"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.72247757),
        dec: Angle.Degrees(+31.61733802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172958"},
        {"Hipparcos Number", "HIP 91675"},
        {"Celescope Catalog", "CEL 4639"},
        {"Fundamental Katalog 5th Edition", "FK5 3487"},
        {"Geneva Identification System", "GEN# +1.00172958"},
        {"Smithsonian Astrophysical Observation", "SAO 67256"},
        {"Wilson Evans Batten Catalogue", "WEB 15766"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.42210755),
        dec: Angle.Degrees(+31.61759677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82194"},
        {"Smithsonian Astrophysical Observation", "SAO 65557"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.87863825),
        dec: Angle.Degrees(+31.61807426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38997"},
        {"Hipparcos Number", "HIP 27635"},
        {"Smithsonian Astrophysical Observation", "SAO 58501"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.75571084),
        dec: Angle.Degrees(+31.61920060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36139",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6072 AB"},
        {"Henry Draper", "HD 58382"},
        {"Hipparcos Number", "HIP 36139"},
        {"Smithsonian Astrophysical Observation", "SAO 60080"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.66506500),
        dec: Angle.Degrees(+31.62006061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101805"},
        {"Smithsonian Astrophysical Observation", "SAO 70304"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.46497306),
        dec: Angle.Degrees(+31.62033907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84036"},
        {"Hipparcos Number", "HIP 47661"},
        {"Geneva Identification System", "GEN# +1.00084036"},
        {"Smithsonian Astrophysical Observation", "SAO 61653"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.77058327),
        dec: Angle.Degrees(+31.62065756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180612"},
        {"Hipparcos Number", "HIP 94684"},
        {"Celescope Catalog", "CEL 4728"},
        {"Geneva Identification System", "GEN# +1.00180612"},
        {"Smithsonian Astrophysical Observation", "SAO 68052"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.99544886),
        dec: Angle.Degrees(+31.62228877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199055"},
        {"Hipparcos Number", "HIP 103116"},
        {"Geneva Identification System", "GEN# +1.00199055"},
        {"Smithsonian Astrophysical Observation", "SAO 70636"},
        {"Wilson Evans Batten Catalogue", "WEB 18726"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.38883365),
        dec: Angle.Degrees(+31.62614291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174567"},
        {"Hipparcos Number", "HIP 92396"},
        {"Geneva Identification System", "GEN# +1.00174567"},
        {"Smithsonian Astrophysical Observation", "SAO 67438"},
        {"Wilson Evans Batten Catalogue", "WEB 15958"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.43366641),
        dec: Angle.Degrees(+31.62946227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115655"},
        {"Hipparcos Number", "HIP 64904"},
        {"Geneva Identification System", "GEN# +1.00115655"},
        {"Smithsonian Astrophysical Observation", "SAO 63458"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.54974862),
        dec: Angle.Degrees(+31.63035621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282707"},
        {"Hipparcos Number", "HIP 23409"},
        {"Smithsonian Astrophysical Observation", "SAO 57583"},
        {"Wilson Evans Batten Catalogue", "WEB 4546"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.46377086),
        dec: Angle.Degrees(+31.63266846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179280"},
        {"Hipparcos Number", "HIP 94210"},
        {"Geneva Identification System", "GEN# +1.00179280"},
        {"Smithsonian Astrophysical Observation", "SAO 67920"},
        {"Wilson Evans Batten Catalogue", "WEB 16411"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.68989464),
        dec: Angle.Degrees(+31.63499948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71097",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9302 B"},
        {"Hipparcos Number", "HIP 71097"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.08997464),
        dec: Angle.Degrees(+31.63515406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71100",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9302 AC"},
        {"Henry Draper", "HD 127737"},
        {"Hipparcos Number", "HIP 71100"},
        {"Smithsonian Astrophysical Observation", "SAO 64206"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.09469228),
        dec: Angle.Degrees(+31.63681231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44016"},
        {"Hipparcos Number", "HIP 30168"},
        {"Geneva Identification System", "GEN# +1.00044016"},
        {"Smithsonian Astrophysical Observation", "SAO 58997"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.21393892),
        dec: Angle.Degrees(+31.63958145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91015"},
    },
    visualMagnitude: 12.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.48922255),
        dec: Angle.Degrees(+31.64006381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52002",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52002"},
        {"Smithsonian Astrophysical Observation", "SAO 62161"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.36287402),
        dec: Angle.Degrees(+31.64060738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91579",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11566 AB"},
        {"Henry Draper", "HD 172729"},
        {"Hipparcos Number", "HIP 91579"},
        {"Smithsonian Astrophysical Observation", "SAO 67238"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.12377219),
        dec: Angle.Degrees(+31.64345440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17905"},
        {"Hipparcos Number", "HIP 13464"},
        {"Geneva Identification System", "GEN# +1.00017905"},
        {"Smithsonian Astrophysical Observation", "SAO 55972"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.35161007),
        dec: Angle.Degrees(+31.64473032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3081"},
        {"Hipparcos Number", "HIP 2694"},
        {"Geneva Identification System", "GEN# +1.00003081"},
        {"Smithsonian Astrophysical Observation", "SAO 53993"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.54409774),
        dec: Angle.Degrees(+31.64554855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136175"},
        {"Hipparcos Number", "HIP 74881"},
        {"Geneva Identification System", "GEN# +1.00136175"},
        {"Smithsonian Astrophysical Observation", "SAO 64619"},
        {"Wilson Evans Batten Catalogue", "WEB 12770"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.54732448),
        dec: Angle.Degrees(+31.64709091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199837"},
        {"Hipparcos Number", "HIP 103548"},
        {"Fundamental Katalog 5th Edition", "FK5 5848"},
        {"Smithsonian Astrophysical Observation", "SAO 70743"},
        {"Wilson Evans Batten Catalogue", "WEB 18839"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.68202600),
        dec: Angle.Degrees(+31.64748804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150917"},
        {"Hipparcos Number", "HIP 81826"},
        {"Smithsonian Astrophysical Observation", "SAO 65501"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.71010983),
        dec: Angle.Degrees(+31.64767574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21864"},
        {"Hipparcos Number", "HIP 16507"},
        {"Smithsonian Astrophysical Observation", "SAO 56529"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.13366538),
        dec: Angle.Degrees(+31.64802549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84697"},
        {"Smithsonian Astrophysical Observation", "SAO 65933"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.71150015),
        dec: Angle.Degrees(+31.64881383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10056"},
        {"Hipparcos Number", "HIP 7680"},
        {"Smithsonian Astrophysical Observation", "SAO 54866"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.71585843),
        dec: Angle.Degrees(+31.64949691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242658"},
        {"Hipparcos Number", "HIP 24934"},
        {"Smithsonian Astrophysical Observation", "SAO 57918"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.13597056),
        dec: Angle.Degrees(+31.65015890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19428",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3029 A"},
        {"Henry Draper", "HD 26161"},
        {"Hipparcos Number", "HIP 19428"},
        {"Geneva Identification System", "GEN# +1.00026161"},
        {"Smithsonian Astrophysical Observation", "SAO 57026"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.41171272),
        dec: Angle.Degrees(+31.65195602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195907"},
        {"Hipparcos Number", "HIP 101411"},
        {"Celescope Catalog", "CEL 5106"},
        {"Geneva Identification System", "GEN# +1.00195907"},
        {"Smithsonian Astrophysical Observation", "SAO 70181"},
        {"Wilson Evans Batten Catalogue", "WEB 18322"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.27131931),
        dec: Angle.Degrees(+31.65706400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121603"},
        {"Hipparcos Number", "HIP 68042"},
        {"Smithsonian Astrophysical Observation", "SAO 63834"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.97581451),
        dec: Angle.Degrees(+31.65881014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182355"},
        {"Hipparcos Number", "HIP 95284"},
        {"Smithsonian Astrophysical Observation", "SAO 68230"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.77451066),
        dec: Angle.Degrees(+31.66072637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122652"},
        {"Hipparcos Number", "HIP 68593"},
        {"Geneva Identification System", "GEN# +1.00122652"},
        {"Smithsonian Astrophysical Observation", "SAO 63905"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.63209478),
        dec: Angle.Degrees(+31.66083402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161478"},
        {"Hipparcos Number", "HIP 86824"},
        {"Geneva Identification System", "GEN# +1.00161478"},
        {"Smithsonian Astrophysical Observation", "SAO 66291"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.11642273),
        dec: Angle.Degrees(+31.66131004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121256"},
        {"Hipparcos Number", "HIP 67840"},
        {"Geneva Identification System", "GEN# +1.00121256"},
        {"Smithsonian Astrophysical Observation", "SAO 63812"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.43865723),
        dec: Angle.Degrees(+31.66553743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110959",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110959"},
        {"Smithsonian Astrophysical Observation", "SAO 72384"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.20458036),
        dec: Angle.Degrees(+31.66596857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6252"},
        {"Smithsonian Astrophysical Observation", "SAO 54611"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.05201776),
        dec: Angle.Degrees(+31.66644212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9680"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.12757089),
        dec: Angle.Degrees(+31.66703348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4279"},
        {"Hipparcos Number", "HIP 3555"},
        {"Smithsonian Astrophysical Observation", "SAO 54126"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.36343094),
        dec: Angle.Degrees(+31.66901710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 619",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 83 AB"},
        {"Henry Draper", "HD 281"},
        {"Hipparcos Number", "HIP 619"},
        {"Smithsonian Astrophysical Observation", "SAO 53659"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.89656955),
        dec: Angle.Degrees(+31.66904954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200742"},
        {"Hipparcos Number", "HIP 104014"},
        {"Geneva Identification System", "GEN# +1.00200742"},
        {"Smithsonian Astrophysical Observation", "SAO 70859"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.09247398),
        dec: Angle.Degrees(+31.67064183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198213"},
        {"Hipparcos Number", "HIP 102632"},
        {"Smithsonian Astrophysical Observation", "SAO 70512"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.95013383),
        dec: Angle.Degrees(+31.67181832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114930"},
        {"Hipparcos Number", "HIP 64525"},
        {"Geneva Identification System", "GEN# +1.00114930"},
        {"Smithsonian Astrophysical Observation", "SAO 63411"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.36975781),
        dec: Angle.Degrees(+31.67188892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219476"},
        {"Hipparcos Number", "HIP 114838"},
        {"Geneva Identification System", "GEN# +1.00219476"},
        {"Smithsonian Astrophysical Observation", "SAO 73118"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.92319332),
        dec: Angle.Degrees(+31.67550859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194282"},
        {"Hipparcos Number", "HIP 100573"},
        {"Celescope Catalog", "CEL 5045"},
        {"Geneva Identification System", "GEN# +1.00194282"},
        {"Smithsonian Astrophysical Observation", "SAO 69944"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.92075146),
        dec: Angle.Degrees(+31.67729683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65299"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.74947816),
        dec: Angle.Degrees(+31.67951176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16757",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2628 AB"},
        {"Henry Draper", "HD 22195"},
        {"Hipparcos Number", "HIP 16757"},
        {"Smithsonian Astrophysical Observation", "SAO 56569"},
        {"Wilson Evans Batten Catalogue", "WEB 3189"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.90763521),
        dec: Angle.Degrees(+31.68044276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91512"},
        {"Hipparcos Number", "HIP 51758"},
        {"Smithsonian Astrophysical Observation", "SAO 62130"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.62779801),
        dec: Angle.Degrees(+31.68052651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176503"},
        {"Hipparcos Number", "HIP 93214"},
        {"Geneva Identification System", "GEN# +1.00176503"},
        {"Smithsonian Astrophysical Observation", "SAO 67671"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.81168124),
        dec: Angle.Degrees(+31.68146697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267337"},
        {"Hipparcos Number", "HIP 33678"},
        {"Smithsonian Astrophysical Observation", "SAO 59674"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.94886976),
        dec: Angle.Degrees(+31.68158129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91868",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11623 AB"},
        {"Hipparcos Number", "HIP 91868"},
        {"Smithsonian Astrophysical Observation", "SAO 67291"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.93153393),
        dec: Angle.Degrees(+31.68182705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133254"},
        {"Hipparcos Number", "HIP 73589"},
        {"Smithsonian Astrophysical Observation", "SAO 64471"},
        {"Wilson Evans Batten Catalogue", "WEB 12585"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.62784983),
        dec: Angle.Degrees(+31.68380415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139814"},
        {"Hipparcos Number", "HIP 76656"},
        {"Smithsonian Astrophysical Observation", "SAO 64828"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.80667453),
        dec: Angle.Degrees(+31.68787546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117161"},
        {"Smithsonian Astrophysical Observation", "SAO 73478"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.29643594),
        dec: Angle.Degrees(+31.68938496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217852"},
        {"Hipparcos Number", "HIP 113844"},
        {"Geneva Identification System", "GEN# +1.00217852"},
        {"Smithsonian Astrophysical Observation", "SAO 72961"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.82391921),
        dec: Angle.Degrees(+31.68939323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154226"},
        {"Hipparcos Number", "HIP 83408"},
        {"Renson", "Renson 43590"},
        {"Smithsonian Astrophysical Observation", "SAO 65750"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.72191994),
        dec: Angle.Degrees(+31.69018800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19883",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3082 AB"},
        {"Henry Draper", "HD 26842"},
        {"Hipparcos Number", "HIP 19883"},
        {"Geneva Identification System", "GEN# +1.00026842"},
        {"Smithsonian Astrophysical Observation", "SAO 57110"},
        {"Wilson Evans Batten Catalogue", "WEB 3799"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.98218732),
        dec: Angle.Degrees(+31.69319370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206113"},
        {"Hipparcos Number", "HIP 106915"},
        {"Geneva Identification System", "GEN# +1.00206113"},
        {"Smithsonian Astrophysical Observation", "SAO 71561"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.79311598),
        dec: Angle.Degrees(+31.69334451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64729"},
        {"Hipparcos Number", "HIP 38797"},
        {"Geneva Identification System", "GEN# +1.00064729"},
        {"Smithsonian Astrophysical Observation", "SAO 60464"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.10236770),
        dec: Angle.Degrees(+31.69560653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197702"},
        {"Hipparcos Number", "HIP 102363"},
        {"Celescope Catalog", "CEL 5158"},
        {"Geneva Identification System", "GEN# +1.00197702"},
        {"Smithsonian Astrophysical Observation", "SAO 70442"},
        {"Wilson Evans Batten Catalogue", "WEB 18528"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.11081401),
        dec: Angle.Degrees(+31.69577163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331701"},
        {"Hipparcos Number", "HIP 98700"},
        {"Geneva Identification System", "GEN# +1.00331701"},
        {"Smithsonian Astrophysical Observation", "SAO 69305"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.69889995),
        dec: Angle.Degrees(+31.69607557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17940"},
        {"Hipparcos Number", "HIP 13504"},
        {"Geneva Identification System", "GEN# +1.00017940"},
        {"Smithsonian Astrophysical Observation", "SAO 55982"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.48490081),
        dec: Angle.Degrees(+31.69652688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92620"},
        {"Hipparcos Number", "HIP 52366"},
        {"Geneva Identification System", "GEN# +1.00092620"},
        {"Smithsonian Astrophysical Observation", "SAO 62206"},
        {"Wilson Evans Batten Catalogue", "WEB 9530"},
    },
    visualMagnitude: 6.02,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.54695661),
        dec: Angle.Degrees(+31.69704343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56222"},
        {"Hipparcos Number", "HIP 35298"},
        {"Smithsonian Astrophysical Observation", "SAO 59954"},
        {"Wilson Evans Batten Catalogue", "WEB 7045"},
    },
    visualMagnitude: 6.75,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.37726248),
        dec: Angle.Degrees(+31.69810596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215068"},
        {"Hipparcos Number", "HIP 112084"},
        {"Smithsonian Astrophysical Observation", "SAO 72636"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.53549063),
        dec: Angle.Degrees(+31.69977299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152598"},
        {"Hipparcos Number", "HIP 82587"},
        {"Fundamental Katalog 5th Edition", "FK5 1441"},
        {"Geneva Identification System", "GEN# +1.00152598"},
        {"Smithsonian Astrophysical Observation", "SAO 65627"},
        {"Wilson Evans Batten Catalogue", "WEB 13946"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.24216797),
        dec: Angle.Degrees(+31.70171538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39586"},
        {"Hipparcos Number", "HIP 27973"},
        {"Geneva Identification System", "GEN# +1.00039586"},
        {"Smithsonian Astrophysical Observation", "SAO 58569"},
        {"Wilson Evans Batten Catalogue", "WEB 5481"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.74591834),
        dec: Angle.Degrees(+31.70193276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75690"},
        {"Smithsonian Astrophysical Observation", "SAO 64712"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.94262602),
        dec: Angle.Degrees(+31.70196435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49011"},
        {"Hipparcos Number", "HIP 32568"},
        {"Geneva Identification System", "GEN# +1.00049011"},
        {"Smithsonian Astrophysical Observation", "SAO 59489"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.94135923),
        dec: Angle.Degrees(+31.70282669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221125"},
        {"Hipparcos Number", "HIP 115921"},
        {"Smithsonian Astrophysical Observation", "SAO 73287"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.29505167),
        dec: Angle.Degrees(+31.70485803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8230"},
        {"Hipparcos Number", "HIP 6400"},
        {"Smithsonian Astrophysical Observation", "SAO 54634"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.54774392),
        dec: Angle.Degrees(+31.70602439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221239"},
        {"Hipparcos Number", "HIP 116005"},
        {"Geneva Identification System", "GEN# +1.00221239"},
        {"Smithsonian Astrophysical Observation", "SAO 73305"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.55669803),
        dec: Angle.Degrees(+31.70614272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97760",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13042 A"},
        {"Henry Draper", "HD 188035"},
        {"Hipparcos Number", "HIP 97760"},
        {"Celescope Catalog", "CEL 4862"},
        {"Geneva Identification System", "GEN# +1.00188035"},
        {"Smithsonian Astrophysical Observation", "SAO 68987"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.00087624),
        dec: Angle.Degrees(+31.70726501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140472"},
        {"Hipparcos Number", "HIP 76944"},
        {"Smithsonian Astrophysical Observation", "SAO 64862"},
        {"Wilson Evans Batten Catalogue", "WEB 13051"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.66919079),
        dec: Angle.Degrees(+31.70878120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70490"},
        {"Smithsonian Astrophysical Observation", "SAO 64133"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.26750688),
        dec: Angle.Degrees(+31.70975580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70061"},
        {"Geneva Identification System", "GEN# +0.03202458"},
        {"Smithsonian Astrophysical Observation", "SAO 64076"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.06402445),
        dec: Angle.Degrees(+31.71063141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46924"},
        {"Hipparcos Number", "HIP 31643"},
        {"Smithsonian Astrophysical Observation", "SAO 59300"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.33820316),
        dec: Angle.Degrees(+31.71078729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116599"},
        {"Smithsonian Astrophysical Observation", "SAO 73386"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.45320619),
        dec: Angle.Degrees(+31.71599703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74075"},
        {"Hipparcos Number", "HIP 42763"},
        {"Smithsonian Astrophysical Observation", "SAO 61005"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.71666692),
        dec: Angle.Degrees(+31.72238391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51167",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7776 AB"},
        {"Hipparcos Number", "HIP 51167"},
        {"Smithsonian Astrophysical Observation", "SAO 62047"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.77178193),
        dec: Angle.Degrees(+31.72292715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219653"},
        {"Hipparcos Number", "HIP 114975"},
        {"Smithsonian Astrophysical Observation", "SAO 73141"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.30371395),
        dec: Angle.Degrees(+31.72371249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63834"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.24498633),
        dec: Angle.Degrees(+31.72398030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92944"},
        {"Smithsonian Astrophysical Observation", "SAO 67598"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.04947447),
        dec: Angle.Degrees(+31.72508229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198932"},
        {"Hipparcos Number", "HIP 103057"},
        {"Smithsonian Astrophysical Observation", "SAO 70618"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.19954429),
        dec: Angle.Degrees(+31.72667644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105582"},
        {"Smithsonian Astrophysical Observation", "SAO 71269"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.77943599),
        dec: Angle.Degrees(+31.72684950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331524"},
        {"Hipparcos Number", "HIP 98067"},
        {"Geneva Identification System", "GEN# +1.00331524"},
        {"Smithsonian Astrophysical Observation", "SAO 69096"},
        {"Wilson Evans Batten Catalogue", "WEB 17279"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.95989718),
        dec: Angle.Degrees(+31.72725211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223362"},
        {"Hipparcos Number", "HIP 117448"},
        {"Smithsonian Astrophysical Observation", "SAO 73525"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.21181979),
        dec: Angle.Degrees(+31.72794527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112914"},
        {"Cincinnati Publication", "Ci 18 2986"},
        {"Cincinnati Publication 2", "Ci 20 1385"},
        {"Smithsonian Astrophysical Observation", "SAO 72796"},
        {"Wilson Evans Batten Catalogue", "WEB 20109"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.99866624),
        dec: Angle.Degrees(+31.72923682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -317.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -374.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171621"},
        {"Hipparcos Number", "HIP 91064"},
        {"Geneva Identification System", "GEN# +1.00171621"},
        {"Smithsonian Astrophysical Observation", "SAO 67123"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.63393540),
        dec: Angle.Degrees(+31.72943518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94437"},
        {"Hipparcos Number", "HIP 53333"},
        {"Geneva Identification System", "GEN# +1.00094437"},
        {"Smithsonian Astrophysical Observation", "SAO 62307"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.62288801),
        dec: Angle.Degrees(+31.73060184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21110"},
        {"Hipparcos Number", "HIP 15953"},
        {"Geneva Identification System", "GEN# +1.00021110"},
        {"Smithsonian Astrophysical Observation", "SAO 56436"},
        {"Wilson Evans Batten Catalogue", "WEB 3046"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.34963800),
        dec: Angle.Degrees(+31.73111892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109625"},
        {"Hipparcos Number", "HIP 61494"},
        {"Geneva Identification System", "GEN# +1.00109625"},
        {"Smithsonian Astrophysical Observation", "SAO 63093"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.99113019),
        dec: Angle.Degrees(+31.73266106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41906"},
        {"Hipparcos Number", "HIP 29173"},
        {"Smithsonian Astrophysical Observation", "SAO 58797"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.30815012),
        dec: Angle.Degrees(+31.73400270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98573"},
        {"Hipparcos Number", "HIP 55405"},
        {"Smithsonian Astrophysical Observation", "SAO 62500"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.18416331),
        dec: Angle.Degrees(+31.73460513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101404",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13995 A"},
        {"Hipparcos Number", "HIP 101404"},
        {"Smithsonian Astrophysical Observation", "SAO 70179"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.26082507),
        dec: Angle.Degrees(+31.73562804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141456"},
        {"Hipparcos Number", "HIP 77397"},
        {"Smithsonian Astrophysical Observation", "SAO 64915"},
        {"Wilson Evans Batten Catalogue", "WEB 13107"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.00746880),
        dec: Angle.Degrees(+31.73572158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182273"},
        {"Hipparcos Number", "HIP 95246"},
        {"Geneva Identification System", "GEN# +1.00182273"},
        {"Renson", "Renson 50390"},
        {"Smithsonian Astrophysical Observation", "SAO 68218"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.67249762),
        dec: Angle.Degrees(+31.73611469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44651"},
        {"Smithsonian Astrophysical Observation", "SAO 61249"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.47030156),
        dec: Angle.Degrees(+31.73719174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48740"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.12541161),
        dec: Angle.Degrees(+31.73874514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331093"},
        {"Hipparcos Number", "HIP 96946"},
        {"Cincinnati Publication", "Ci 18 2573"},
        {"Smithsonian Astrophysical Observation", "SAO 68727"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.62013232),
        dec: Angle.Degrees(+31.74087957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -199.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80434",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80434"},
        {"Smithsonian Astrophysical Observation", "SAO 65287"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.27692000),
        dec: Angle.Degrees(+31.74123080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29418"},
        {"Hipparcos Number", "HIP 21679"},
        {"Geneva Identification System", "GEN# +1.00029418"},
        {"Smithsonian Astrophysical Observation", "SAO 57361"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.81013387),
        dec: Angle.Degrees(+31.74151927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82190"},
        {"Hipparcos Number", "HIP 46707"},
        {"Smithsonian Astrophysical Observation", "SAO 61538"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.82864235),
        dec: Angle.Degrees(+31.74185896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177808"},
        {"Hipparcos Number", "HIP 93718"},
        {"Geneva Identification System", "GEN# +1.00177808"},
        {"Smithsonian Astrophysical Observation", "SAO 67782"},
        {"Wilson Evans Batten Catalogue", "WEB 16288"},
    },
    visualMagnitude: 5.63,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.24093053),
        dec: Angle.Degrees(+31.74425746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58030"},
        {"Geneva Identification System", "GEN# +0.03202201"},
        {"Smithsonian Astrophysical Observation", "SAO 62748"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.52471816),
        dec: Angle.Degrees(+31.74451918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7724"},
        {"Hipparcos Number", "HIP 6025"},
        {"Smithsonian Astrophysical Observation", "SAO 54580"},
        {"Wilson Evans Batten Catalogue", "WEB 1363"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.35059759),
        dec: Angle.Degrees(+31.74460911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101606"},
        {"Hipparcos Number", "HIP 57029"},
        {"Fundamental Katalog 5th Edition", "FK5 2938"},
        {"Geneva Identification System", "GEN# +1.00101606J"},
        {"Smithsonian Astrophysical Observation", "SAO 62658"},
        {"Wilson Evans Batten Catalogue", "WEB 10265"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.39375241),
        dec: Angle.Degrees(+31.74598350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -351.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220793"},
        {"Hipparcos Number", "HIP 115701"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.62898034),
        dec: Angle.Degrees(+31.74707460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9713"},
        {"Hipparcos Number", "HIP 7428"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.92260971),
        dec: Angle.Degrees(+31.74796123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58428"},
        {"Hipparcos Number", "HIP 36157"},
        {"Geneva Identification System", "GEN# +1.00058428"},
        {"Smithsonian Astrophysical Observation", "SAO 60082"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.73784143),
        dec: Angle.Degrees(+31.75085596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7670"},
        {"Hipparcos Number", "HIP 5989"},
        {"Geneva Identification System", "GEN# +1.00007670"},
        {"Smithsonian Astrophysical Observation", "SAO 54577"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.25585930),
        dec: Angle.Degrees(+31.75260702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71186"},
        {"Geneva Identification System", "GEN# +0.03202489"},
        {"Wilson Evans Batten Catalogue", "WEB 12306"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.38837441),
        dec: Angle.Degrees(+31.75461631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47395"},
    },
    visualMagnitude: 11.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.85175347),
        dec: Angle.Degrees(+31.75522522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174179"},
        {"Hipparcos Number", "HIP 92243"},
        {"Celescope Catalog", "CEL 4653"},
        {"Geneva Identification System", "GEN# +1.00174179"},
        {"Smithsonian Astrophysical Observation", "SAO 67396"},
        {"Wilson Evans Batten Catalogue", "WEB 15917"},
    },
    visualMagnitude: 6.06,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.98905393),
        dec: Angle.Degrees(+31.75684463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74567"},
        {"Smithsonian Astrophysical Observation", "SAO 64575"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.54025464),
        dec: Angle.Degrees(+31.75728538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131725"},
        {"Hipparcos Number", "HIP 72937"},
        {"Geneva Identification System", "GEN# +1.00131725"},
        {"Smithsonian Astrophysical Observation", "SAO 64390"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.59799244),
        dec: Angle.Degrees(+31.75799935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101905"},
        {"Hipparcos Number", "HIP 57206"},
        {"Geneva Identification System", "GEN# +1.00101905"},
        {"Smithsonian Astrophysical Observation", "SAO 62673"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.95374792),
        dec: Angle.Degrees(+31.75803422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75489"},
        {"Hipparcos Number", "HIP 43475"},
        {"Smithsonian Astrophysical Observation", "SAO 61088"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.83739761),
        dec: Angle.Degrees(+31.75843588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185527"},
        {"Hipparcos Number", "HIP 96602"},
        {"Smithsonian Astrophysical Observation", "SAO 68606"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.57516086),
        dec: Angle.Degrees(+31.75901333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101855"},
        {"Hipparcos Number", "HIP 57176"},
        {"Geneva Identification System", "GEN# +1.00101855"},
        {"Smithsonian Astrophysical Observation", "SAO 62671"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.88008042),
        dec: Angle.Degrees(+31.76211927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72222"},
        {"Smithsonian Astrophysical Observation", "SAO 64319"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.56575220),
        dec: Angle.Degrees(+31.76249260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143419"},
        {"Hipparcos Number", "HIP 78277"},
        {"Smithsonian Astrophysical Observation", "SAO 65000"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.74163699),
        dec: Angle.Degrees(+31.76353132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243662"},
        {"Hipparcos Number", "HIP 25494"},
        {"Smithsonian Astrophysical Observation", "SAO 58039"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.78881292),
        dec: Angle.Degrees(+31.76590489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47255"},
        {"Hipparcos Number", "HIP 31816"},
        {"Geneva Identification System", "GEN# +1.00047255"},
        {"Smithsonian Astrophysical Observation", "SAO 59330"},
        {"Wilson Evans Batten Catalogue", "WEB 6388"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.77447580),
        dec: Angle.Degrees(+31.76614217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68761"},
        {"Geneva Identification System", "GEN# +0.03202425"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.11085081),
        dec: Angle.Degrees(+31.76715500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43180"},
        {"Smithsonian Astrophysical Observation", "SAO 61053"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.94152853),
        dec: Angle.Degrees(+31.76851570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197839"},
        {"Hipparcos Number", "HIP 102415"},
        {"Smithsonian Astrophysical Observation", "SAO 70458"},
        {"Wilson Evans Batten Catalogue", "WEB 18543"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.30520328),
        dec: Angle.Degrees(+31.77407050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118914"},
        {"Hipparcos Number", "HIP 66621"},
        {"Geneva Identification System", "GEN# +1.00118914"},
        {"Smithsonian Astrophysical Observation", "SAO 63667"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.83840689),
        dec: Angle.Degrees(+31.77414741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111860"},
        {"Hipparcos Number", "HIP 62791"},
        {"Geneva Identification System", "GEN# +1.00111860"},
        {"Smithsonian Astrophysical Observation", "SAO 63227"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.00564089),
        dec: Angle.Degrees(+31.77445821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165885"},
        {"Hipparcos Number", "HIP 88731"},
        {"Smithsonian Astrophysical Observation", "SAO 66641"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.71919305),
        dec: Angle.Degrees(+31.77708032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32036"},
        {"Hipparcos Number", "HIP 23400"},
        {"Celescope Catalog", "CEL 509"},
        {"Geneva Identification System", "GEN# +1.00032036"},
        {"Smithsonian Astrophysical Observation", "SAO 57582"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.44134743),
        dec: Angle.Degrees(+31.77814079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91655"},
        {"Hipparcos Number", "HIP 51840"},
        {"Geneva Identification System", "GEN# +1.00091655"},
        {"Smithsonian Astrophysical Observation", "SAO 62138"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.86987399),
        dec: Angle.Degrees(+31.77847530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113021"},
        {"Hipparcos Number", "HIP 63479"},
        {"Fundamental Katalog 5th Edition", "FK5 5147"},
        {"Geneva Identification System", "GEN# +1.00113021"},
        {"Smithsonian Astrophysical Observation", "SAO 63290"},
        {"Wilson Evans Batten Catalogue", "WEB 11232"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.10684058),
        dec: Angle.Degrees(+31.77923941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66003"},
        {"Geneva Identification System", "GEN# +0.03202359"},
        {"Smithsonian Astrophysical Observation", "SAO 63585"},
    },
    visualMagnitude: 10.45,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.97917768),
        dec: Angle.Degrees(+31.78006284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217754"},
        {"Hipparcos Number", "HIP 113783"},
        {"Geneva Identification System", "GEN# +1.00217754"},
        {"Renson", "Renson 60040"},
        {"Smithsonian Astrophysical Observation", "SAO 72949"},
        {"Wilson Evans Batten Catalogue", "WEB 20214"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.63894845),
        dec: Angle.Degrees(+31.78154358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260608"},
        {"Hipparcos Number", "HIP 31702"},
        {"Smithsonian Astrophysical Observation", "SAO 59307"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.47583507),
        dec: Angle.Degrees(+31.78316091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205514"},
        {"Hipparcos Number", "HIP 106572"},
        {"Smithsonian Astrophysical Observation", "SAO 71483"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.75810905),
        dec: Angle.Degrees(+31.78387339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36366",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6109 A"},
        {"Henry Draper", "HD 58946"},
        {"Hipparcos Number", "HIP 36366"},
        {"Fundamental Katalog 5th Edition", "FK5 286"},
        {"Geneva Identification System", "GEN# +1.00058946"},
        {"Renson", "Renson 16110"},
        {"Smithsonian Astrophysical Observation", "SAO 60118"},
        {"Wilson Evans Batten Catalogue", "WEB 7234"},
    },
    visualMagnitude: 4.16,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.27754045),
        dec: Angle.Degrees(+31.78407932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 193.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27538",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4421 AB"},
        {"Henry Draper", "HD 38819"},
        {"Hipparcos Number", "HIP 27538"},
        {"Smithsonian Astrophysical Observation", "SAO 58484"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.48138314),
        dec: Angle.Degrees(+31.78574500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214823"},
        {"Hipparcos Number", "HIP 111928"},
        {"Geneva Identification System", "GEN# +1.00214823"},
        {"Smithsonian Astrophysical Observation", "SAO 72604"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.08255934),
        dec: Angle.Degrees(+31.78763831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135438"},
        {"Hipparcos Number", "HIP 74561"},
        {"Geneva Identification System", "GEN# +1.00135438"},
        {"Smithsonian Astrophysical Observation", "SAO 64574"},
        {"Wilson Evans Batten Catalogue", "WEB 12726"},
    },
    visualMagnitude: 5.98,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.52506116),
        dec: Angle.Degrees(+31.78791816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70746"},
        {"Smithsonian Astrophysical Observation", "SAO 64155"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.01492172),
        dec: Angle.Degrees(+31.78818249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83051",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10284 AB"},
        {"Hipparcos Number", "HIP 83051"},
        {"Smithsonian Astrophysical Observation", "SAO 65682"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.56144944),
        dec: Angle.Degrees(+31.79095187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70892",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9288 A"},
        {"Henry Draper", "HD 127304"},
        {"Hipparcos Number", "HIP 70892"},
        {"Geneva Identification System", "GEN# +1.00127304A"},
        {"Renson", "Renson 36230"},
        {"Smithsonian Astrophysical Observation", "SAO 64178"},
        {"Wilson Evans Batten Catalogue", "WEB 12273"},
    },
    visualMagnitude: 6.06,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.45701807),
        dec: Angle.Degrees(+31.79117120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26499"},
        {"Hipparcos Number", "HIP 19659"},
        {"Smithsonian Astrophysical Observation", "SAO 57070"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.18820009),
        dec: Angle.Degrees(+31.79475168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204441"},
        {"Hipparcos Number", "HIP 105971"},
        {"Smithsonian Astrophysical Observation", "SAO 71363"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.93768979),
        dec: Angle.Degrees(+31.79528794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73343"},
        {"Hipparcos Number", "HIP 42432"},
        {"Geneva Identification System", "GEN# +1.00073343"},
        {"Smithsonian Astrophysical Observation", "SAO 60954"},
        {"Wilson Evans Batten Catalogue", "WEB 8156"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.78559499),
        dec: Angle.Degrees(+31.79572215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331413"},
        {"Hipparcos Number", "HIP 97778"},
        {"Renson", "Renson 51920"},
        {"Smithsonian Astrophysical Observation", "SAO 68995"},
    },
    visualMagnitude: 8.83,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.03459965),
        dec: Angle.Degrees(+31.79611736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221090"},
        {"Hipparcos Number", "HIP 115896"},
        {"Geneva Identification System", "GEN# +1.00221090"},
        {"Smithsonian Astrophysical Observation", "SAO 73284"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.20727767),
        dec: Angle.Degrees(+31.79620720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106152"},
        {"Hipparcos Number", "HIP 59558"},
        {"Geneva Identification System", "GEN# +1.00106152"},
        {"Smithsonian Astrophysical Observation", "SAO 62897"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.21636997),
        dec: Angle.Degrees(+31.79623652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331299"},
        {"Hipparcos Number", "HIP 97387"},
        {"Smithsonian Astrophysical Observation", "SAO 68860"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.90875379),
        dec: Angle.Degrees(+31.80084884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15176"},
        {"Hipparcos Number", "HIP 11432"},
        {"Geneva Identification System", "GEN# +1.00015176"},
        {"Smithsonian Astrophysical Observation", "SAO 55570"},
        {"Wilson Evans Batten Catalogue", "WEB 2387"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.86578353),
        dec: Angle.Degrees(+31.80134872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182758"},
        {"Hipparcos Number", "HIP 95446"},
        {"Geneva Identification System", "GEN# +1.00182758"},
        {"Smithsonian Astrophysical Observation", "SAO 68278"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.23370199),
        dec: Angle.Degrees(+31.80142413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146946"},
        {"Hipparcos Number", "HIP 79837"},
        {"Cincinnati Publication", "Ci 18 2180"},
        {"Fundamental Katalog 5th Edition", "FK5 5435"},
        {"Geneva Identification System", "GEN# +1.00146946"},
        {"Smithsonian Astrophysical Observation", "SAO 65206"},
        {"Wilson Evans Batten Catalogue", "WEB 13517"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.44107631),
        dec: Angle.Degrees(+31.80362467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 312.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6118"},
        {"Hipparcos Number", "HIP 4889"},
        {"Geneva Identification System", "GEN# +1.00006118"},
        {"Smithsonian Astrophysical Observation", "SAO 54374"},
        {"Wilson Evans Batten Catalogue", "WEB 953"},
    },
    visualMagnitude: 5.50,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.70452742),
        dec: Angle.Degrees(+31.80433674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92703"},
        {"Smithsonian Astrophysical Observation", "SAO 67525"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.34129491),
        dec: Angle.Degrees(+31.80599799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69521"},
        {"Hipparcos Number", "HIP 40715"},
        {"Geneva Identification System", "GEN# +1.00069521"},
        {"Renson", "Renson 19215"},
        {"Smithsonian Astrophysical Observation", "SAO 60719"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.66429989),
        dec: Angle.Degrees(+31.80955867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137147"},
        {"Hipparcos Number", "HIP 75322"},
        {"Geneva Identification System", "GEN# +1.00137147"},
        {"Smithsonian Astrophysical Observation", "SAO 64675"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.83854430),
        dec: Angle.Degrees(+31.81179078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115355",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16702 AB"},
        {"Henry Draper", "HD 220222"},
        {"Hipparcos Number", "HIP 115355"},
        {"Geneva Identification System", "GEN# +1.00220222"},
        {"Smithsonian Astrophysical Observation", "SAO 73205"},
        {"Wilson Evans Batten Catalogue", "WEB 20429"},
    },
    visualMagnitude: 5.35,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.47885850),
        dec: Angle.Degrees(+31.81248117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72793"},
        {"Hipparcos Number", "HIP 42179"},
        {"Smithsonian Astrophysical Observation", "SAO 60913"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.98129501),
        dec: Angle.Degrees(+31.81588545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21229"},
        {"Hipparcos Number", "HIP 16034"},
        {"Smithsonian Astrophysical Observation", "SAO 56450"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.62794875),
        dec: Angle.Degrees(+31.82157905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53603"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.49175961),
        dec: Angle.Degrees(+31.82305618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108077"},
        {"Hipparcos Number", "HIP 60560"},
        {"Geneva Identification System", "GEN# +1.00108077"},
        {"Smithsonian Astrophysical Observation", "SAO 62990"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.21644261),
        dec: Angle.Degrees(+31.82326474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151145"},
        {"Hipparcos Number", "HIP 81938"},
        {"Smithsonian Astrophysical Observation", "SAO 65514"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.07039782),
        dec: Angle.Degrees(+31.82381154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34258"},
        {"Hipparcos Number", "HIP 24662"},
        {"Smithsonian Astrophysical Observation", "SAO 57843"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.37924963),
        dec: Angle.Degrees(+31.82400360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99164"},
        {"Hipparcos Number", "HIP 55708"},
        {"Geneva Identification System", "GEN# +1.00099164"},
        {"Smithsonian Astrophysical Observation", "SAO 62541"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.23104813),
        dec: Angle.Degrees(+31.82502354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98402",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13223 AB"},
        {"Henry Draper", "HD 189613"},
        {"Hipparcos Number", "HIP 98402"},
        {"Smithsonian Astrophysical Observation", "SAO 69222"},
        {"Wilson Evans Batten Catalogue", "WEB 17371"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.91303066),
        dec: Angle.Degrees(+31.82648793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22781"},
        {"Hipparcos Number", "HIP 17187"},
        {"Smithsonian Astrophysical Observation", "SAO 56626"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.20624087),
        dec: Angle.Degrees(+31.82651813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98851"},
        {"Hipparcos Number", "HIP 55563"},
        {"Geneva Identification System", "GEN# +1.00098851"},
        {"Renson", "Renson 28480"},
        {"Smithsonian Astrophysical Observation", "SAO 62524"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.71334749),
        dec: Angle.Degrees(+31.82812103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91699"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.49684034),
        dec: Angle.Degrees(+31.83046912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -303.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83759"},
    },
    visualMagnitude: 11.20,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.77410984),
        dec: Angle.Degrees(+31.83303655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221785"},
        {"Hipparcos Number", "HIP 116381"},
        {"Smithsonian Astrophysical Observation", "SAO 73352"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.74606822),
        dec: Angle.Degrees(+31.83548746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64510"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.33448107),
        dec: Angle.Degrees(+31.83568281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57486",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57486"},
        {"Geneva Identification System", "GEN# +0.03202188"},
        {"Wilson Evans Batten Catalogue", "WEB 10323"},
    },
    visualMagnitude: 10.75,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.75211125),
        dec: Angle.Degrees(+31.83576957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212988"},
        {"Hipparcos Number", "HIP 110873"},
        {"Geneva Identification System", "GEN# +1.00212988"},
        {"Smithsonian Astrophysical Observation", "SAO 72366"},
        {"Wilson Evans Batten Catalogue", "WEB 19853"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.94258454),
        dec: Angle.Degrees(+31.83997497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8320"},
        {"Hipparcos Number", "HIP 6453"},
        {"Smithsonian Astrophysical Observation", "SAO 54641"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.73514375),
        dec: Angle.Degrees(+31.84121472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75011"},
        {"Smithsonian Astrophysical Observation", "SAO 64632"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.91777296),
        dec: Angle.Degrees(+31.84216823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11215"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.08695583),
        dec: Angle.Degrees(+31.84591714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189656"},
        {"Hipparcos Number", "HIP 98422"},
        {"Geneva Identification System", "GEN# +1.00189656"},
        {"Smithsonian Astrophysical Observation", "SAO 69225"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.96871688),
        dec: Angle.Degrees(+31.84700410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107781",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15364 A"},
        {"Henry Draper", "HD 207703"},
        {"Hipparcos Number", "HIP 107781"},
        {"Smithsonian Astrophysical Observation", "SAO 71749"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.52230094),
        dec: Angle.Degrees(+31.84789198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102732"},
    },
    visualMagnitude: 12.94,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.25351560),
        dec: Angle.Degrees(+31.84883766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170755"},
        {"Hipparcos Number", "HIP 90649"},
        {"Geneva Identification System", "GEN# +1.00170755"},
        {"Smithsonian Astrophysical Observation", "SAO 67025"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.43914965),
        dec: Angle.Degrees(+31.85136884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1853"},
        {"Smithsonian Astrophysical Observation", "SAO 53853"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.85353325),
        dec: Angle.Degrees(+31.85143239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5801"},
        {"Hipparcos Number", "HIP 4670"},
        {"Geneva Identification System", "GEN# +1.00005801"},
        {"Smithsonian Astrophysical Observation", "SAO 54330"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.99183807),
        dec: Angle.Degrees(+31.85385619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281999"},
        {"Hipparcos Number", "HIP 20539"},
        {"Smithsonian Astrophysical Observation", "SAO 57209"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.01791215),
        dec: Angle.Degrees(+31.85507289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180314"},
        {"Hipparcos Number", "HIP 94576"},
        {"Smithsonian Astrophysical Observation", "SAO 68027"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.70906864),
        dec: Angle.Degrees(+31.86030131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213521"},
        {"Hipparcos Number", "HIP 111186"},
        {"Smithsonian Astrophysical Observation", "SAO 72430"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.86736869),
        dec: Angle.Degrees(+31.86042441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
