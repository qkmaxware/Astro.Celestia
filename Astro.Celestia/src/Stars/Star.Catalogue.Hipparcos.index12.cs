using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_12() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40129"},
        {"Hipparcos Number", "HIP 27855"},
        {"Smithsonian Astrophysical Observation", "SAO 234189"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.39934714),
        dec: Angle.Degrees(-56.67042323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151423"},
        {"Hipparcos Number", "HIP 82403"},
        {"Geneva Identification System", "GEN# +1.00151423"},
        {"Smithsonian Astrophysical Observation", "SAO 244176"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.58763891),
        dec: Angle.Degrees(-56.67015725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87123"},
        {"Hipparcos Number", "HIP 49094"},
        {"Geneva Identification System", "GEN# +1.00087123"},
        {"Smithsonian Astrophysical Observation", "SAO 237606"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.30811984),
        dec: Angle.Degrees(-56.66895861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187500"},
        {"Hipparcos Number", "HIP 97857"},
        {"Smithsonian Astrophysical Observation", "SAO 246314"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.29475307),
        dec: Angle.Degrees(-56.66808996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130227"},
        {"Hipparcos Number", "HIP 72471"},
        {"Geneva Identification System", "GEN# +1.00130227"},
        {"Smithsonian Astrophysical Observation", "SAO 242026"},
        {"Wilson Evans Batten Catalogue", "WEB 12453"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.27987082),
        dec: Angle.Degrees(-56.66753864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31009"},
        {"Hipparcos Number", "HIP 22381"},
        {"Geneva Identification System", "GEN# +1.00031009"},
        {"Smithsonian Astrophysical Observation", "SAO 233694"},
        {"Wilson Evans Batten Catalogue", "WEB 4315"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.26985215),
        dec: Angle.Degrees(-56.66663150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155779"},
        {"Hipparcos Number", "HIP 84534"},
        {"Smithsonian Astrophysical Observation", "SAO 244577"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.22653672),
        dec: Angle.Degrees(-56.66600511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3657"},
        {"Hipparcos Number", "HIP 3050"},
        {"Geneva Identification System", "GEN# +1.00003657"},
        {"Smithsonian Astrophysical Observation", "SAO 232129"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.68870626),
        dec: Angle.Degrees(-56.66570786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55023"},
        {"Hipparcos Number", "HIP 34399"},
        {"Smithsonian Astrophysical Observation", "SAO 234949"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.98289900),
        dec: Angle.Degrees(-56.66427993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162932"},
        {"Hipparcos Number", "HIP 87869"},
        {"Geneva Identification System", "GEN# +1.00162932"},
        {"Smithsonian Astrophysical Observation", "SAO 245130"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.24081607),
        dec: Angle.Degrees(-56.66313388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217216"},
        {"Hipparcos Number", "HIP 113563"},
        {"Smithsonian Astrophysical Observation", "SAO 247672"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.02672549),
        dec: Angle.Degrees(-56.66302453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96728"},
        {"Hipparcos Number", "HIP 54390"},
        {"Celescope Catalog", "CEL 3820"},
        {"Geneva Identification System", "GEN# +1.00096728"},
        {"Smithsonian Astrophysical Observation", "SAO 238799"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.91988657),
        dec: Angle.Degrees(-56.66059857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212726"},
        {"Hipparcos Number", "HIP 110886"},
        {"Geneva Identification System", "GEN# +1.00212726"},
        {"Smithsonian Astrophysical Observation", "SAO 247456"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.97221045),
        dec: Angle.Degrees(-56.66033925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23773"},
        {"Hipparcos Number", "HIP 17501"},
        {"Smithsonian Astrophysical Observation", "SAO 233258"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.21942808),
        dec: Angle.Degrees(-56.65832222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112970"},
        {"Hipparcos Number", "HIP 63540"},
        {"Smithsonian Astrophysical Observation", "SAO 240479"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.30818565),
        dec: Angle.Degrees(-56.65802950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212607"},
        {"Hipparcos Number", "HIP 110798"},
        {"Smithsonian Astrophysical Observation", "SAO 247448"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.71273088),
        dec: Angle.Degrees(-56.63586560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166912"},
        {"Hipparcos Number", "HIP 89530"},
        {"Smithsonian Astrophysical Observation", "SAO 245354"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.02947713),
        dec: Angle.Degrees(-56.65082881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2039"},
        {"Hipparcos Number", "HIP 1931"},
        {"Geneva Identification System", "GEN# +1.00002039"},
        {"Smithsonian Astrophysical Observation", "SAO 232025"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.08414358),
        dec: Angle.Degrees(-56.65008448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76346"},
        {"Hipparcos Number", "HIP 43620"},
        {"Celescope Catalog", "CEL 3041"},
        {"Geneva Identification System", "GEN# +1.00076346"},
        {"Smithsonian Astrophysical Observation", "SAO 236368"},
    },
    visualMagnitude: 6.02,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.26584378),
        dec: Angle.Degrees(-56.64957371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67930"},
        {"Hipparcos Number", "HIP 39736"},
        {"Smithsonian Astrophysical Observation", "SAO 235755"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.82623778),
        dec: Angle.Degrees(-56.64776576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121704"},
        {"Hipparcos Number", "HIP 68277"},
        {"Geneva Identification System", "GEN# +1.00121704"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.66510884),
        dec: Angle.Degrees(-56.64595893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170486"},
        {"Hipparcos Number", "HIP 90938"},
        {"Smithsonian Astrophysical Observation", "SAO 245542"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.25708554),
        dec: Angle.Degrees(-56.64594578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113297"},
        {"Hipparcos Number", "HIP 63731"},
        {"Smithsonian Astrophysical Observation", "SAO 240511"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.90389744),
        dec: Angle.Degrees(-56.64518897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36138"},
        {"Hipparcos Number", "HIP 25423"},
        {"Renson", "Renson 9340"},
        {"Smithsonian Astrophysical Observation", "SAO 233978"},
        {"Wilson Evans Batten Catalogue", "WEB 4927"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.56176865),
        dec: Angle.Degrees(-56.64504040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57622"},
        {"Hipparcos Number", "HIP 35424"},
        {"Smithsonian Astrophysical Observation", "SAO 235092"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.70469753),
        dec: Angle.Degrees(-56.64472811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 150.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164426"},
        {"Hipparcos Number", "HIP 88507"},
        {"Smithsonian Astrophysical Observation", "SAO 245215"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.09728643),
        dec: Angle.Degrees(-56.64461308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99890"},
        {"Hipparcos Number", "HIP 56036"},
        {"Geneva Identification System", "GEN# +1.00099890"},
        {"Smithsonian Astrophysical Observation", "SAO 239106"},
        {"Wilson Evans Batten Catalogue", "WEB 10061"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.27400615),
        dec: Angle.Degrees(-56.64426195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11678"},
        {"Hipparcos Number", "HIP 8780"},
        {"Smithsonian Astrophysical Observation", "SAO 232558"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.23512823),
        dec: Angle.Degrees(-56.64391024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223753"},
        {"Hipparcos Number", "HIP 117715"},
        {"Smithsonian Astrophysical Observation", "SAO 248047"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.11555717),
        dec: Angle.Degrees(-56.64282840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17111"},
        {"Hipparcos Number", "HIP 12651"},
        {"Smithsonian Astrophysical Observation", "SAO 232865"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.62980578),
        dec: Angle.Degrees(-56.64020965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113793"},
        {"Hipparcos Number", "HIP 64013"},
        {"Smithsonian Astrophysical Observation", "SAO 240560"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.74985406),
        dec: Angle.Degrees(-56.63672211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200787"},
        {"Hipparcos Number", "HIP 104312"},
        {"Geneva Identification System", "GEN# +1.00200787"},
        {"Smithsonian Astrophysical Observation", "SAO 246879"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.97289905),
        dec: Angle.Degrees(-56.63594719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125481"},
        {"Henry Draper 2", "HD 125482"},
        {"Hipparcos Number", "HIP 70179"},
        {"Geneva Identification System", "GEN# +1.00125481"},
        {"Smithsonian Astrophysical Observation", "SAO 241659"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.38029408),
        dec: Angle.Degrees(-56.63465599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72802"},
        {"Hipparcos Number", "HIP 41864"},
        {"Fundamental Katalog 5th Edition", "FK5 4769"},
        {"Geneva Identification System", "GEN# +1.00072802"},
        {"Smithsonian Astrophysical Observation", "SAO 236066"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.04735088),
        dec: Angle.Degrees(-56.63395068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110291"},
        {"Hipparcos Number", "HIP 61940"},
        {"Smithsonian Astrophysical Observation", "SAO 240157"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.40681436),
        dec: Angle.Degrees(-56.63311321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207738"},
        {"Hipparcos Number", "HIP 108004"},
        {"Smithsonian Astrophysical Observation", "SAO 247214"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.21860469),
        dec: Angle.Degrees(-56.63287127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97744"},
        {"Hipparcos Number", "HIP 54864"},
        {"Smithsonian Astrophysical Observation", "SAO 238885"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.50976843),
        dec: Angle.Degrees(-56.63273843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142136"},
        {"Hipparcos Number", "HIP 77996"},
        {"Smithsonian Astrophysical Observation", "SAO 243124"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.91695299),
        dec: Angle.Degrees(-56.63010210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168476"},
        {"Hipparcos Number", "HIP 90099"},
        {"Geneva Identification System", "GEN# +1.00168476"},
        {"Renson", "Renson 47210"},
        {"Smithsonian Astrophysical Observation", "SAO 245434"},
        {"Wilson Evans Batten Catalogue", "WEB 15402"},
    },
    visualMagnitude: 9.30,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.81109786),
        dec: Angle.Degrees(-56.62890837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140742"},
        {"Hipparcos Number", "HIP 77398"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.01004800),
        dec: Angle.Degrees(-56.62693160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112554"},
        {"Hipparcos Number", "HIP 63298"},
        {"Geneva Identification System", "GEN# +1.00112554"},
        {"Smithsonian Astrophysical Observation", "SAO 240427"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.57976137),
        dec: Angle.Degrees(-56.62688622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60434"},
        {"Hipparcos Number", "HIP 36554"},
        {"Smithsonian Astrophysical Observation", "SAO 235266"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.79593546),
        dec: Angle.Degrees(-56.62446422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132594"},
        {"Hipparcos Number", "HIP 73580"},
        {"Geneva Identification System", "GEN# +1.00132594"},
        {"Smithsonian Astrophysical Observation", "SAO 242184"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.59647096),
        dec: Angle.Degrees(-56.62397261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95338"},
        {"Hipparcos Number", "HIP 53719"},
        {"Cincinnati Publication", "Ci 20 603"},
        {"Geneva Identification System", "GEN# +1.00095338"},
        {"Smithsonian Astrophysical Observation", "SAO 238662"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.86144351),
        dec: Angle.Degrees(-56.62274970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -416.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23671"},
        {"Hipparcos Number", "HIP 17433"},
        {"Smithsonian Astrophysical Observation", "SAO 233249"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.01559011),
        dec: Angle.Degrees(-56.62202441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53466"},
        {"Hipparcos Number", "HIP 33863"},
        {"Geneva Identification System", "GEN# +1.00053466"},
        {"Smithsonian Astrophysical Observation", "SAO 234869"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.44534958),
        dec: Angle.Degrees(-56.62143574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127866"},
        {"Hipparcos Number", "HIP 71378"},
        {"Geneva Identification System", "GEN# +2.56620136"},
        {"Smithsonian Astrophysical Observation", "SAO 241825"},
        {"New General Catalogue", "NGC 5662 136"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.94857878),
        dec: Angle.Degrees(-56.61843697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8148"},
        {"Hipparcos Number", "HIP 6213"},
        {"Smithsonian Astrophysical Observation", "SAO 232379"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.91654445),
        dec: Angle.Degrees(-56.61635047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89768"},
        {"Hipparcos Number", "HIP 50596"},
        {"Smithsonian Astrophysical Observation", "SAO 237932"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.03745455),
        dec: Angle.Degrees(-56.61539734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139636"},
        {"Hipparcos Number", "HIP 76881"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.48835459),
        dec: Angle.Degrees(-56.61230278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99616"},
        {"Hipparcos Number", "HIP 55871"},
        {"Smithsonian Astrophysical Observation", "SAO 239080"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.78251253),
        dec: Angle.Degrees(-56.61077292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195208"},
        {"Hipparcos Number", "HIP 101362"},
        {"Smithsonian Astrophysical Observation", "SAO 246624"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.15588151),
        dec: Angle.Degrees(-56.60937191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153028"},
        {"Hipparcos Number", "HIP 83205"},
        {"Geneva Identification System", "GEN# +1.00153028"},
        {"Smithsonian Astrophysical Observation", "SAO 244340"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.07058983),
        dec: Angle.Degrees(-56.60685709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98896"},
        {"Hipparcos Number", "HIP 55517"},
        {"Smithsonian Astrophysical Observation", "SAO 239002"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.56167388),
        dec: Angle.Degrees(-56.60281195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113137"},
        {"Hipparcos Number", "HIP 63616"},
        {"Smithsonian Astrophysical Observation", "SAO 240495"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.57935013),
        dec: Angle.Degrees(-56.60179399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36096"},
        {"Hipparcos Number", "HIP 25391"},
        {"Smithsonian Astrophysical Observation", "SAO 233976"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.47448052),
        dec: Angle.Degrees(-56.60163903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15934"},
        {"Hipparcos Number", "HIP 11745"},
        {"Smithsonian Astrophysical Observation", "SAO 232802"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.89161234),
        dec: Angle.Degrees(-56.60117970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215497"},
        {"Hipparcos Number", "HIP 112441"},
        {"Smithsonian Astrophysical Observation", "SAO 247578"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.65338247),
        dec: Angle.Degrees(-56.59938600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49075"},
        {"Hipparcos Number", "HIP 32198"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.81818311),
        dec: Angle.Degrees(-56.59517800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2768"},
        {"Hipparcos Number", "HIP 2416"},
        {"Smithsonian Astrophysical Observation", "SAO 232071"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.70028979),
        dec: Angle.Degrees(-56.59512448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6996"},
        {"Hipparcos Number", "HIP 5428"},
        {"Geneva Identification System", "GEN# +1.00006996J"},
        {"Smithsonian Astrophysical Observation", "SAO 232315"},
        {"Wilson Evans Batten Catalogue", "WEB 1185"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.34204925),
        dec: Angle.Degrees(-56.59511763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132083"},
        {"Hipparcos Number", "HIP 73371"},
        {"Renson", "Renson 37510"},
        {"Smithsonian Astrophysical Observation", "SAO 242147"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.91242537),
        dec: Angle.Degrees(-56.59089160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88862"},
        {"Hipparcos Number", "HIP 50069"},
        {"Smithsonian Astrophysical Observation", "SAO 237808"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.34298496),
        dec: Angle.Degrees(-56.58669891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5080"},
        {"Hipparcos Number", "HIP 4046"},
        {"Fundamental Katalog 5th Edition", "FK5 4075"},
        {"Geneva Identification System", "GEN# +1.00005080"},
        {"Smithsonian Astrophysical Observation", "SAO 232211"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.96210601),
        dec: Angle.Degrees(-56.57816546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93822"},
        {"Hipparcos Number", "HIP 52870"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.18039092),
        dec: Angle.Degrees(-56.57703866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224583"},
        {"Hipparcos Number", "HIP 118249"},
        {"Smithsonian Astrophysical Observation", "SAO 248090"},
        {"Wilson Evans Batten Catalogue", "WEB 20785"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.76901380),
        dec: Angle.Degrees(-56.57560999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111777"},
        {"Hipparcos Number", "HIP 62809"},
        {"Cincinnati Publication", "Ci 20 746"},
        {"Geneva Identification System", "GEN# +1.00111777"},
        {"Smithsonian Astrophysical Observation", "SAO 240333"},
        {"Wilson Evans Batten Catalogue", "WEB 11136"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.05154956),
        dec: Angle.Degrees(-56.57390804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -687.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37193"},
        {"Hipparcos Number", "HIP 26053"},
        {"Smithsonian Astrophysical Observation", "SAO 234024"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.36352042),
        dec: Angle.Degrees(-56.57333542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108375"},
        {"Hipparcos Number", "HIP 60762"},
        {"Smithsonian Astrophysical Observation", "SAO 239955"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.82504650),
        dec: Angle.Degrees(-56.56423158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127753"},
        {"Hipparcos Number", "HIP 71326"},
        {"Geneva Identification System", "GEN# +2.56620008"},
        {"Geneva Identification System 2", "GEN# +2.56620049"},
        {"Smithsonian Astrophysical Observation", "SAO 241812"},
        {"New General Catalogue", "NGC 5662 49"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.78672004),
        dec: Angle.Degrees(-56.56262521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104564"},
        {"Hipparcos Number", "HIP 58711"},
        {"Smithsonian Astrophysical Observation", "SAO 239607"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.62922005),
        dec: Angle.Degrees(-56.56046903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89540"},
        {"Hipparcos Number", "HIP 50481"},
        {"Fundamental Katalog 5th Edition", "FK5 4916"},
        {"Geneva Identification System", "GEN# +1.00089540"},
        {"Smithsonian Astrophysical Observation", "SAO 237899"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.62013061),
        dec: Angle.Degrees(-56.55987109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201974"},
        {"Hipparcos Number", "HIP 104933"},
        {"Smithsonian Astrophysical Observation", "SAO 246926"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.83019196),
        dec: Angle.Degrees(-56.55933117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167059"},
        {"Hipparcos Number", "HIP 89591"},
        {"Smithsonian Astrophysical Observation", "SAO 245363"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.23676725),
        dec: Angle.Degrees(-56.55867673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149317"},
        {"Hipparcos Number", "HIP 81371"},
        {"Geneva Identification System", "GEN# +1.00149317"},
        {"Smithsonian Astrophysical Observation", "SAO 243989"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.27274860),
        dec: Angle.Degrees(-56.55584469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40508"},
        {"Hipparcos Number", "HIP 28051"},
        {"Smithsonian Astrophysical Observation", "SAO 234212"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.97783947),
        dec: Angle.Degrees(-56.55512306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153201"},
        {"Hipparcos Number", "HIP 83269"},
        {"Renson", "Renson 43350"},
        {"Smithsonian Astrophysical Observation", "SAO 244356"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.27927895),
        dec: Angle.Degrees(-56.55501465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23203"},
        {"Hipparcos Number", "HIP 17152"},
        {"Smithsonian Astrophysical Observation", "SAO 233220"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.10675535),
        dec: Angle.Degrees(-56.55485813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26530"},
        {"Hipparcos Number", "HIP 19352"},
        {"Smithsonian Astrophysical Observation", "SAO 233414"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.18815681),
        dec: Angle.Degrees(-56.55413992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94287"},
        {"Hipparcos Number", "HIP 53108"},
        {"Smithsonian Astrophysical Observation", "SAO 238542"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.97750206),
        dec: Angle.Degrees(-56.55362633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90871"},
        {"Hipparcos Number", "HIP 51252"},
        {"Geneva Identification System", "GEN# +1.00090871"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.02688765),
        dec: Angle.Degrees(-56.55347767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203314"},
        {"Hipparcos Number", "HIP 105627"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.90954410),
        dec: Angle.Degrees(-56.55239466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95494"},
        {"Hipparcos Number", "HIP 53797"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.09642452),
        dec: Angle.Degrees(-56.55186949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157007"},
        {"Hipparcos Number", "HIP 85145"},
        {"Smithsonian Astrophysical Observation", "SAO 244698"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.00012472),
        dec: Angle.Degrees(-56.54607426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15007"},
        {"Hipparcos Number", "HIP 11123"},
        {"Fundamental Katalog 5th Edition", "FK5 4222"},
        {"Smithsonian Astrophysical Observation", "SAO 232742"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.78776437),
        dec: Angle.Degrees(-56.54462065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82388"},
        {"Hipparcos Number", "HIP 46537"},
        {"Smithsonian Astrophysical Observation", "SAO 237036"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.36987261),
        dec: Angle.Degrees(-56.53729679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40507"},
        {"Hipparcos Number", "HIP 28042"},
        {"Geneva Identification System", "GEN# +1.00040507"},
        {"Smithsonian Astrophysical Observation", "SAO 234211"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.95702306),
        dec: Angle.Degrees(-56.52783924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28443"},
        {"Hipparcos Number", "HIP 20696"},
        {"Geneva Identification System", "GEN# +1.00028443"},
        {"Smithsonian Astrophysical Observation", "SAO 233518"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.50282100),
        dec: Angle.Degrees(-56.52617601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156854"},
        {"Hipparcos Number", "HIP 85068"},
        {"Geneva Identification System", "GEN# +1.00156854"},
        {"Smithsonian Astrophysical Observation", "SAO 244685"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.77963562),
        dec: Angle.Degrees(-56.52555632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108732"},
        {"Hipparcos Number", "HIP 60969"},
        {"Geneva Identification System", "GEN# +1.00108732"},
        {"Smithsonian Astrophysical Observation", "SAO 239999"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.47580895),
        dec: Angle.Degrees(-56.52496942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174894"},
        {"Hipparcos Number", "HIP 92938"},
        {"Smithsonian Astrophysical Observation", "SAO 245813"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.03377610),
        dec: Angle.Degrees(-56.52479487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27320"},
        {"Hipparcos Number", "HIP 19869"},
        {"Smithsonian Astrophysical Observation", "SAO 233455"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.92224963),
        dec: Angle.Degrees(-56.52234364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105244"},
        {"Hipparcos Number", "HIP 59090"},
        {"Smithsonian Astrophysical Observation", "SAO 239675"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.76527647),
        dec: Angle.Degrees(-56.51958587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138400"},
        {"Hipparcos Number", "HIP 76248"},
        {"Smithsonian Astrophysical Observation", "SAO 242704"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.62702586),
        dec: Angle.Degrees(-56.51935771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35418"},
        {"Hipparcos Number", "HIP 24999"},
        {"Smithsonian Astrophysical Observation", "SAO 233942"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.30057965),
        dec: Angle.Degrees(-56.51890037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137326"},
        {"Hipparcos Number", "HIP 75702"},
        {"Smithsonian Astrophysical Observation", "SAO 242550"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.97965359),
        dec: Angle.Degrees(-56.51804650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127900"},
        {"Hipparcos Number", "HIP 71397"},
        {"Geneva Identification System", "GEN# +2.56620184"},
        {"Smithsonian Astrophysical Observation", "SAO 241831"},
        {"New General Catalogue", "NGC 5662 184"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.00518126),
        dec: Angle.Degrees(-56.51784975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201411"},
        {"Hipparcos Number", "HIP 104620"},
        {"Fundamental Katalog 5th Edition", "FK5 3695"},
        {"Smithsonian Astrophysical Observation", "SAO 246897"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.89284813),
        dec: Angle.Degrees(-56.51716158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32978"},
        {"Smithsonian Astrophysical Observation", "SAO 234758"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.04517062),
        dec: Angle.Degrees(-56.51594191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20879"},
        {"Hipparcos Number", "HIP 15464"},
        {"Smithsonian Astrophysical Observation", "SAO 233074"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.85260858),
        dec: Angle.Degrees(-56.51549562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224965"},
        {"Hipparcos Number", "HIP 166"},
        {"Smithsonian Astrophysical Observation", "SAO 248104"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.52152674),
        dec: Angle.Degrees(-56.51490157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212804"},
        {"Hipparcos Number", "HIP 110917"},
        {"Geneva Identification System", "GEN# +1.00212804"},
        {"Smithsonian Astrophysical Observation", "SAO 247457"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.07455678),
        dec: Angle.Degrees(-56.51190646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50994"},
        {"Hipparcos Number", "HIP 32980"},
        {"Smithsonian Astrophysical Observation", "SAO 234759"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.05400291),
        dec: Angle.Degrees(-56.50855721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12307"},
    },
    visualMagnitude: 11.39,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.62236466),
        dec: Angle.Degrees(-56.50850057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 172.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18017"},
        {"Smithsonian Astrophysical Observation", "SAO 233298"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.76032618),
        dec: Angle.Degrees(-56.50688137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192115"},
        {"Hipparcos Number", "HIP 99895"},
        {"Smithsonian Astrophysical Observation", "SAO 246504"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.02688338),
        dec: Angle.Degrees(-56.50659154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123040"},
        {"Hipparcos Number", "HIP 68959"},
        {"Smithsonian Astrophysical Observation", "SAO 241451"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.74344308),
        dec: Angle.Degrees(-56.50605935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3980"},
        {"Hipparcos Number", "HIP 3277"},
        {"Geneva Identification System", "GEN# +1.00003980J"},
        {"Renson", "Renson 1090"},
        {"Smithsonian Astrophysical Observation", "SAO 232152"},
        {"Wilson Evans Batten Catalogue", "WEB 584"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.44292464),
        dec: Angle.Degrees(-56.50145475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5937"},
        {"Hipparcos Number", "HIP 4671"},
        {"Smithsonian Astrophysical Observation", "SAO 232253"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.99644411),
        dec: Angle.Degrees(-56.50143695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193310"},
        {"Hipparcos Number", "HIP 100462"},
        {"Smithsonian Astrophysical Observation", "SAO 246549"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.58760886),
        dec: Angle.Degrees(-56.50095046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182305"},
        {"Hipparcos Number", "HIP 95635"},
        {"Smithsonian Astrophysical Observation", "SAO 246103"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.79917698),
        dec: Angle.Degrees(-56.49894406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217727"},
        {"Hipparcos Number", "HIP 113863"},
        {"Geneva Identification System", "GEN# +1.00217727"},
        {"Smithsonian Astrophysical Observation", "SAO 247701"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.88191784),
        dec: Angle.Degrees(-56.49876885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89872"},
        {"Hipparcos Number", "HIP 50662"},
        {"Smithsonian Astrophysical Observation", "SAO 237953"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.19758362),
        dec: Angle.Degrees(-56.49666745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148422"},
        {"Hipparcos Number", "HIP 80887"},
        {"Geneva Identification System", "GEN# +1.00148422"},
        {"Smithsonian Astrophysical Observation", "SAO 243899"},
        {"Wilson Evans Batten Catalogue", "WEB 13679"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.74956134),
        dec: Angle.Degrees(-56.49532797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103937"},
        {"Hipparcos Number", "HIP 58346"},
        {"Smithsonian Astrophysical Observation", "SAO 239528"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.49117263),
        dec: Angle.Degrees(-56.49410278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173469"},
        {"Hipparcos Number", "HIP 92298"},
        {"Smithsonian Astrophysical Observation", "SAO 245717"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.17364183),
        dec: Angle.Degrees(-56.49289649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112892"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.92522167),
        dec: Angle.Degrees(-56.49093093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 225.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108484"},
        {"Hipparcos Number", "HIP 60824"},
        {"Geneva Identification System", "GEN# +1.00108484"},
        {"Smithsonian Astrophysical Observation", "SAO 239968"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.01049409),
        dec: Angle.Degrees(-56.48943929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110956"},
        {"Hipparcos Number", "HIP 62327"},
        {"Celescope Catalog", "CEL 4153"},
        {"Fundamental Katalog 5th Edition", "FK5 3018"},
        {"Geneva Identification System", "GEN# +1.00110956A"},
        {"Smithsonian Astrophysical Observation", "SAO 240235"},
        {"Wilson Evans Batten Catalogue", "WEB 11068"},
    },
    visualMagnitude: 4.62,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.59478955),
        dec: Angle.Degrees(-56.48877967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121177"},
        {"Hipparcos Number", "HIP 67981"},
        {"Smithsonian Astrophysical Observation", "SAO 241291"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.81998655),
        dec: Angle.Degrees(-56.48580346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80948"},
        {"Hipparcos Number", "HIP 45821"},
        {"Smithsonian Astrophysical Observation", "SAO 236866"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.14402205),
        dec: Angle.Degrees(-56.48455577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89065"},
        {"Hipparcos Number", "HIP 50199"},
        {"Smithsonian Astrophysical Observation", "SAO 237830"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.72216718),
        dec: Angle.Degrees(-56.48384099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65690"},
        {"Hipparcos Number", "HIP 38836"},
        {"Geneva Identification System", "GEN# +1.00065690"},
        {"Smithsonian Astrophysical Observation", "SAO 235637"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.21774033),
        dec: Angle.Degrees(-56.48318179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153162"},
        {"Hipparcos Number", "HIP 83250"},
        {"Smithsonian Astrophysical Observation", "SAO 244351"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.23212282),
        dec: Angle.Degrees(-56.47995300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216114"},
        {"Hipparcos Number", "HIP 112839"},
        {"Smithsonian Astrophysical Observation", "SAO 247617"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.77712779),
        dec: Angle.Degrees(-56.47895432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167270"},
        {"Hipparcos Number", "HIP 89658"},
        {"Geneva Identification System", "GEN# +1.00167270"},
        {"Smithsonian Astrophysical Observation", "SAO 245377"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.46191147),
        dec: Angle.Degrees(-56.47797446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118322"},
        {"Hipparcos Number", "HIP 66466"},
        {"Geneva Identification System", "GEN# +1.00118322"},
    },
    visualMagnitude: 7.76,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.40028321),
        dec: Angle.Degrees(-56.47639563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25449"},
        {"Hipparcos Number", "HIP 18656"},
        {"Renson", "Renson 6490"},
        {"Smithsonian Astrophysical Observation", "SAO 233350"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.90594590),
        dec: Angle.Degrees(-56.47292844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209567"},
        {"Hipparcos Number", "HIP 109097"},
        {"Geneva Identification System", "GEN# +1.00209567J"},
        {"Smithsonian Astrophysical Observation", "SAO 247305"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.49444761),
        dec: Angle.Degrees(-56.47203244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208877"},
        {"Hipparcos Number", "HIP 108670"},
        {"Smithsonian Astrophysical Observation", "SAO 247267"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.22433942),
        dec: Angle.Degrees(-56.47118905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38087"},
        {"Geneva Identification System", "GEN# +1.00063926J"},
        {"Smithsonian Astrophysical Observation", "SAO 235532"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.08127238),
        dec: Angle.Degrees(-56.47109287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173507"},
        {"Hipparcos Number", "HIP 92318"},
        {"Smithsonian Astrophysical Observation", "SAO 245722"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.23091683),
        dec: Angle.Degrees(-56.47030843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104401"},
        {"Hipparcos Number", "HIP 58618"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.31012903),
        dec: Angle.Degrees(-56.46995867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109078"},
        {"Hipparcos Number", "HIP 61188"},
        {"Geneva Identification System", "GEN# +1.00109078"},
        {"Smithsonian Astrophysical Observation", "SAO 240038"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.06945301),
        dec: Angle.Degrees(-56.46777472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82314"},
        {"Smithsonian Astrophysical Observation", "SAO 244159"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.27258742),
        dec: Angle.Degrees(-56.46669428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39919"},
        {"Hipparcos Number", "HIP 27732"},
        {"Smithsonian Astrophysical Observation", "SAO 234180"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.07386578),
        dec: Angle.Degrees(-56.46291749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1517"},
        {"Hipparcos Number", "HIP 1533"},
        {"Smithsonian Astrophysical Observation", "SAO 231997"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.77517192),
        dec: Angle.Degrees(-56.46084659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77704"},
        {"Hipparcos Number", "HIP 44338"},
        {"Smithsonian Astrophysical Observation", "SAO 236522"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.43616794),
        dec: Angle.Degrees(-56.46028777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127924"},
        {"Hipparcos Number", "HIP 71398"},
        {"Geneva Identification System", "GEN# +2.56620187"},
        {"Renson", "Renson 36350"},
        {"Smithsonian Astrophysical Observation", "SAO 241832"},
        {"New General Catalogue", "NGC 5662 187"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.00641083),
        dec: Angle.Degrees(-56.46013222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108554"},
        {"Hipparcos Number", "HIP 60869"},
        {"Smithsonian Astrophysical Observation", "SAO 239975"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.14027338),
        dec: Angle.Degrees(-56.45768692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117160"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.28879176),
        dec: Angle.Degrees(-56.45624554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206872"},
        {"Hipparcos Number", "HIP 107534"},
        {"Smithsonian Astrophysical Observation", "SAO 247173"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.69978371),
        dec: Angle.Degrees(-56.45527253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222120"},
        {"Hipparcos Number", "HIP 116640"},
        {"Smithsonian Astrophysical Observation", "SAO 247959"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.55221102),
        dec: Angle.Degrees(-56.45114126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154672"},
        {"Hipparcos Number", "HIP 83983"},
        {"Geneva Identification System", "GEN# +1.00154672"},
        {"Smithsonian Astrophysical Observation", "SAO 244476"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.52032832),
        dec: Angle.Degrees(-56.44896760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189650"},
        {"Hipparcos Number", "HIP 98795"},
        {"Geneva Identification System", "GEN# +1.00189650"},
        {"Smithsonian Astrophysical Observation", "SAO 246413"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.98293742),
        dec: Angle.Degrees(-56.44783545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144628"},
        {"Hipparcos Number", "HIP 79190"},
        {"Geneva Identification System", "GEN# +1.00144628"},
        {"Smithsonian Astrophysical Observation", "SAO 243380"},
        {"Wilson Evans Batten Catalogue", "WEB 13388"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.42890460),
        dec: Angle.Degrees(-56.44596179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 334.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32127"},
        {"Smithsonian Astrophysical Observation", "SAO 234666"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.64430251),
        dec: Angle.Degrees(-56.44529779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99414"},
        {"Hipparcos Number", "HIP 55785"},
        {"Smithsonian Astrophysical Observation", "SAO 239058"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.45062492),
        dec: Angle.Degrees(-56.44445416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44364"},
        {"Hipparcos Number", "HIP 29932"},
        {"Geneva Identification System", "GEN# +1.00044364"},
        {"Smithsonian Astrophysical Observation", "SAO 234437"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.52573927),
        dec: Angle.Degrees(-56.44413327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110358"},
        {"Hipparcos Number", "HIP 61983"},
        {"Smithsonian Astrophysical Observation", "SAO 240166"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.53212563),
        dec: Angle.Degrees(-56.44354474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105785"},
        {"Hipparcos Number", "HIP 59360"},
        {"Smithsonian Astrophysical Observation", "SAO 239716"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.67546108),
        dec: Angle.Degrees(-56.44228464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85082"},
        {"Hipparcos Number", "HIP 48050"},
        {"Celescope Catalog", "CEL 3384"},
        {"Geneva Identification System", "GEN# +1.00085082"},
        {"Smithsonian Astrophysical Observation", "SAO 237346"},
    },
    visualMagnitude: 8.97,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.92710579),
        dec: Angle.Degrees(-56.44173583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128713"},
        {"Hipparcos Number", "HIP 71746"},
        {"Fundamental Katalog 5th Edition", "FK5 3162"},
        {"Geneva Identification System", "GEN# +1.00128713"},
        {"Smithsonian Astrophysical Observation", "SAO 241898"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.13655470),
        dec: Angle.Degrees(-56.44074033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173699"},
        {"Hipparcos Number", "HIP 92413"},
        {"Smithsonian Astrophysical Observation", "SAO 245736"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.49278779),
        dec: Angle.Degrees(-56.43944250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38328"},
        {"Hipparcos Number", "HIP 26817"},
        {"Fundamental Katalog 5th Edition", "FK5 4518"},
        {"Smithsonian Astrophysical Observation", "SAO 234098"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.41213434),
        dec: Angle.Degrees(-56.43810531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88174"},
        {"Hipparcos Number", "HIP 49675"},
        {"Smithsonian Astrophysical Observation", "SAO 237726"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.11133996),
        dec: Angle.Degrees(-56.43688514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220918"},
        {"Hipparcos Number", "HIP 115848"},
        {"Smithsonian Astrophysical Observation", "SAO 247889"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.05519735),
        dec: Angle.Degrees(-56.43643904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15628"},
        {"Hipparcos Number", "HIP 11531"},
        {"Geneva Identification System", "GEN# +1.00015628"},
        {"Smithsonian Astrophysical Observation", "SAO 232787"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.17166425),
        dec: Angle.Degrees(-56.43635976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130102"},
        {"Hipparcos Number", "HIP 72415"},
        {"Geneva Identification System", "GEN# +1.00130102"},
        {"Smithsonian Astrophysical Observation", "SAO 242011"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.10498293),
        dec: Angle.Degrees(-56.43613335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96985"},
        {"Hipparcos Number", "HIP 54506"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.27241139),
        dec: Angle.Degrees(-56.43390754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8978"},
        {"Hipparcos Number", "HIP 6780"},
        {"Geneva Identification System", "GEN# +1.00008978"},
        {"Smithsonian Astrophysical Observation", "SAO 232428"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.79287437),
        dec: Angle.Degrees(-56.43039686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10269"},
        {"Hipparcos Number", "HIP 7699"},
        {"Geneva Identification System", "GEN# +1.00010269"},
        {"Smithsonian Astrophysical Observation", "SAO 232488"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.78136774),
        dec: Angle.Degrees(-56.42929868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166026"},
        {"Hipparcos Number", "HIP 89183"},
        {"Smithsonian Astrophysical Observation", "SAO 245304"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.01215243),
        dec: Angle.Degrees(-56.42832955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82682"},
        {"Hipparcos Number", "HIP 46711"},
        {"Smithsonian Astrophysical Observation", "SAO 237069"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.83104472),
        dec: Angle.Degrees(-56.42799716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57198"},
        {"Hipparcos Number", "HIP 35238"},
        {"Smithsonian Astrophysical Observation", "SAO 235071"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.22945835),
        dec: Angle.Degrees(-56.42769350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21660"},
        {"Hipparcos Number", "HIP 16082"},
        {"Smithsonian Astrophysical Observation", "SAO 233123"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.77825618),
        dec: Angle.Degrees(-56.42753351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130298"},
        {"Hipparcos Number", "HIP 72510"},
        {"Geneva Identification System", "GEN# +1.00130298"},
        {"Smithsonian Astrophysical Observation", "SAO 242038"},
        {"Wilson Evans Batten Catalogue", "WEB 12466"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.39071643),
        dec: Angle.Degrees(-56.42735110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31906"},
        {"Hipparcos Number", "HIP 22950"},
        {"Smithsonian Astrophysical Observation", "SAO 233742"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.06979274),
        dec: Angle.Degrees(-56.42669837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143410"},
        {"Hipparcos Number", "HIP 78611"},
        {"Smithsonian Astrophysical Observation", "SAO 243272"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.73947678),
        dec: Angle.Degrees(-56.42536229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174851"},
        {"Hipparcos Number", "HIP 92902"},
        {"Fundamental Katalog 5th Edition", "FK5 3504"},
        {"Smithsonian Astrophysical Observation", "SAO 245809"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.94038204),
        dec: Angle.Degrees(-56.42337342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147040"},
        {"Hipparcos Number", "HIP 80204"},
        {"Smithsonian Astrophysical Observation", "SAO 243702"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.60518116),
        dec: Angle.Degrees(-56.42336310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88226"},
        {"Hipparcos Number", "HIP 49697"},
        {"Smithsonian Astrophysical Observation", "SAO 237733"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.17722873),
        dec: Angle.Degrees(-56.42071547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222437"},
        {"Hipparcos Number", "HIP 116835"},
        {"Smithsonian Astrophysical Observation", "SAO 247975"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.21188016),
        dec: Angle.Degrees(-56.42054531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94508"},
        {"Hipparcos Number", "HIP 53260"},
        {"Smithsonian Astrophysical Observation", "SAO 238575"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.38926255),
        dec: Angle.Degrees(-56.42051347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210573"},
        {"Hipparcos Number", "HIP 109655"},
        {"Geneva Identification System", "GEN# +1.00210573"},
        {"Smithsonian Astrophysical Observation", "SAO 247357"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.20069587),
        dec: Angle.Degrees(-56.41912988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -274.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183809"},
        {"Hipparcos Number", "HIP 96253"},
        {"Geneva Identification System", "GEN# +1.00183809"},
        {"Smithsonian Astrophysical Observation", "SAO 246164"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.57585272),
        dec: Angle.Degrees(-56.41785911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210340"},
        {"Hipparcos Number", "HIP 109538"},
        {"Smithsonian Astrophysical Observation", "SAO 247344"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.82747373),
        dec: Angle.Degrees(-56.41724060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156793"},
        {"Hipparcos Number", "HIP 85030"},
        {"Smithsonian Astrophysical Observation", "SAO 244676"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.68753490),
        dec: Angle.Degrees(-56.41506844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145342"},
        {"Hipparcos Number", "HIP 79499"},
        {"Smithsonian Astrophysical Observation", "SAO 243447"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.35162346),
        dec: Angle.Degrees(-56.41450243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 839"},
        {"Hipparcos Number", "HIP 997"},
        {"Smithsonian Astrophysical Observation", "SAO 231970"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.12424830),
        dec: Angle.Degrees(-56.41332506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24799"},
        {"Hipparcos Number", "HIP 18202"},
        {"Smithsonian Astrophysical Observation", "SAO 233315"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.39455619),
        dec: Angle.Degrees(-56.41299271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85250"},
        {"Hipparcos Number", "HIP 48119"},
        {"Geneva Identification System", "GEN# +2.30330001"},
        {"Smithsonian Astrophysical Observation", "SAO 237370"},
        {"New General Catalogue", "NGC 3033 1"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.16691281),
        dec: Angle.Degrees(-56.41192613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64067"},
        {"Henry Draper 2", "HD 64067D"},
        {"Hipparcos Number", "HIP 38152"},
        {"Geneva Identification System", "GEN# +1.00064067J"},
        {"Smithsonian Astrophysical Observation", "SAO 235539"},
        {"Wilson Evans Batten Catalogue", "WEB 7519"},
    },
    visualMagnitude: 5.57,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.27800960),
        dec: Angle.Degrees(-56.41038485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97595"},
        {"Hipparcos Number", "HIP 54800"},
        {"Smithsonian Astrophysical Observation", "SAO 238870"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.27777984),
        dec: Angle.Degrees(-56.41006578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108570"},
        {"Hipparcos Number", "HIP 60870"},
        {"Geneva Identification System", "GEN# +1.00108570"},
        {"Smithsonian Astrophysical Observation", "SAO 239977"},
        {"Wilson Evans Batten Catalogue", "WEB 10834"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.14099776),
        dec: Angle.Degrees(-56.40726625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -232.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95764"},
        {"Hipparcos Number", "HIP 53935"},
        {"Smithsonian Astrophysical Observation", "SAO 238705"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.54345934),
        dec: Angle.Degrees(-56.40594745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96258"},
        {"Hipparcos Number", "HIP 54187"},
        {"Smithsonian Astrophysical Observation", "SAO 238748"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.27007372),
        dec: Angle.Degrees(-56.40296121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207634"},
        {"Hipparcos Number", "HIP 107943"},
        {"Smithsonian Astrophysical Observation", "SAO 247211"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.02780136),
        dec: Angle.Degrees(-56.40271274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155086"},
        {"Hipparcos Number", "HIP 84197"},
        {"Smithsonian Astrophysical Observation", "SAO 244515"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.16374344),
        dec: Angle.Degrees(-56.40255541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20177"},
        {"Hipparcos Number", "HIP 14874"},
        {"Geneva Identification System", "GEN# +1.00020177"},
        {"Smithsonian Astrophysical Observation", "SAO 233033"},
        {"Wilson Evans Batten Catalogue", "WEB 2872"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.00677815),
        dec: Angle.Degrees(-56.40165247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105857"},
        {"Hipparcos Number", "HIP 59397"},
        {"Geneva Identification System", "GEN# +1.00105857"},
        {"Smithsonian Astrophysical Observation", "SAO 239727"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.77462124),
        dec: Angle.Degrees(-56.40133123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165987"},
        {"Hipparcos Number", "HIP 89171"},
        {"Smithsonian Astrophysical Observation", "SAO 245300"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.96348640),
        dec: Angle.Degrees(-56.40091961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32545"},
        {"Hipparcos Number", "HIP 23297"},
        {"Smithsonian Astrophysical Observation", "SAO 233783"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.16695129),
        dec: Angle.Degrees(-56.39926986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72976"},
        {"Hipparcos Number", "HIP 41954"},
        {"Celescope Catalog", "CEL 2648"},
        {"Geneva Identification System", "GEN# +1.00072976"},
        {"Renson", "Renson 20250"},
        {"Smithsonian Astrophysical Observation", "SAO 236081"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.27312973),
        dec: Angle.Degrees(-56.39662157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117238"},
        {"Hipparcos Number", "HIP 65881"},
        {"Smithsonian Astrophysical Observation", "SAO 240895"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.56720190),
        dec: Angle.Degrees(-56.39575235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52622"},
        {"Hipparcos Number", "HIP 33577"},
        {"Geneva Identification System", "GEN# +1.00052622"},
        {"Smithsonian Astrophysical Observation", "SAO 234825"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.65163880),
        dec: Angle.Degrees(-56.39476607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223443"},
        {"Hipparcos Number", "HIP 117508"},
        {"Geneva Identification System", "GEN# +1.00223443"},
        {"Smithsonian Astrophysical Observation", "SAO 248032"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.44012863),
        dec: Angle.Degrees(-56.39125502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11146"},
        {"Hipparcos Number", "HIP 8386"},
        {"Smithsonian Astrophysical Observation", "SAO 232526"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.03099740),
        dec: Angle.Degrees(-56.39084532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31998"},
        {"Hipparcos Number", "HIP 23002"},
        {"Geneva Identification System", "GEN# +1.00031998"},
        {"Smithsonian Astrophysical Observation", "SAO 233753"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.21722506),
        dec: Angle.Degrees(-56.39043210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86720"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.78623894),
        dec: Angle.Degrees(-56.39037207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181247"},
        {"Hipparcos Number", "HIP 95258"},
        {"Smithsonian Astrophysical Observation", "SAO 246051"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.71112203),
        dec: Angle.Degrees(-56.38844439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198251"},
        {"Henry Draper 2", "HD 198251A"},
        {"Hipparcos Number", "HIP 102957"},
        {"Smithsonian Astrophysical Observation", "SAO 246760"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.89117112),
        dec: Angle.Degrees(-56.38810598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125288"},
        {"Hipparcos Number", "HIP 70069"},
        {"Fundamental Katalog 5th Edition", "FK5 529"},
        {"Geneva Identification System", "GEN# +1.00125288"},
        {"Smithsonian Astrophysical Observation", "SAO 241641"},
        {"Wilson Evans Batten Catalogue", "WEB 12182"},
    },
    visualMagnitude: 4.30,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.08146975),
        dec: Angle.Degrees(-56.38647906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113953"},
        {"Hipparcos Number", "HIP 64087"},
        {"Celescope Catalog", "CEL 4204"},
        {"Geneva Identification System", "GEN# +1.00113953"},
        {"Smithsonian Astrophysical Observation", "SAO 240584"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.00433472),
        dec: Angle.Degrees(-56.38477063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129123"},
        {"Hipparcos Number", "HIP 71953"},
        {"Geneva Identification System", "GEN# +1.00129123"},
        {"Smithsonian Astrophysical Observation", "SAO 241930"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.74482648),
        dec: Angle.Degrees(-56.38434492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135377"},
        {"Hipparcos Number", "HIP 74795"},
        {"Smithsonian Astrophysical Observation", "SAO 242381"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.28279148),
        dec: Angle.Degrees(-56.38398845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123775"},
        {"Hipparcos Number", "HIP 69331"},
        {"Smithsonian Astrophysical Observation", "SAO 241515"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.84662400),
        dec: Angle.Degrees(-56.38270132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222596"},
        {"Hipparcos Number", "HIP 116935"},
        {"Smithsonian Astrophysical Observation", "SAO 247987"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.54119868),
        dec: Angle.Degrees(-56.37994004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205309"},
        {"Hipparcos Number", "HIP 106681"},
        {"Geneva Identification System", "GEN# +1.00205309"},
        {"Smithsonian Astrophysical Observation", "SAO 247103"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.11880536),
        dec: Angle.Degrees(-56.37888070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102323"},
        {"Hipparcos Number", "HIP 57426"},
        {"Smithsonian Astrophysical Observation", "SAO 239364"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.59566062),
        dec: Angle.Degrees(-56.37847649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157246"},
        {"Hipparcos Number", "HIP 85267"},
        {"Geneva Identification System", "GEN# +1.00157246A"},
        {"Smithsonian Astrophysical Observation", "SAO 244726"},
        {"Wilson Evans Batten Catalogue", "WEB 14396"},
    },
    visualMagnitude: 3.31,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.34858274),
        dec: Angle.Degrees(-56.37768824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172519"},
        {"Hipparcos Number", "HIP 91888"},
        {"Geneva Identification System", "GEN# +1.00172519"},
        {"Smithsonian Astrophysical Observation", "SAO 245660"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.98035132),
        dec: Angle.Degrees(-56.37647216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104296"},
        {"Hipparcos Number", "HIP 58566"},
        {"Smithsonian Astrophysical Observation", "SAO 239575"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.13872654),
        dec: Angle.Degrees(-56.37574418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137682"},
        {"Hipparcos Number", "HIP 75876"},
        {"Renson", "Renson 39150"},
        {"Smithsonian Astrophysical Observation", "SAO 242612"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.47566779),
        dec: Angle.Degrees(-56.37492849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107543"},
        {"Hipparcos Number", "HIP 60308"},
        {"Geneva Identification System", "GEN# +1.00107543"},
        {"Smithsonian Astrophysical Observation", "SAO 239880"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.48932747),
        dec: Angle.Degrees(-56.37438360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145666"},
        {"Hipparcos Number", "HIP 79636"},
        {"Geneva Identification System", "GEN# +1.00145666"},
        {"Smithsonian Astrophysical Observation", "SAO 243495"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.76825779),
        dec: Angle.Degrees(-56.37399568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -212.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30352"},
        {"Hipparcos Number", "HIP 21990"},
        {"Smithsonian Astrophysical Observation", "SAO 233648"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.90025812),
        dec: Angle.Degrees(-56.37330384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73465"},
        {"Hipparcos Number", "HIP 42178"},
        {"Geneva Identification System", "GEN# +1.00073465"},
        {"Smithsonian Astrophysical Observation", "SAO 236112"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.96866019),
        dec: Angle.Degrees(-56.37301050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55477"},
        {"Hipparcos Number", "HIP 34586"},
        {"Smithsonian Astrophysical Observation", "SAO 234979"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.45463265),
        dec: Angle.Degrees(-56.37151968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11668"},
        {"Hipparcos Number", "HIP 8767"},
        {"Smithsonian Astrophysical Observation", "SAO 232556"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.20191561),
        dec: Angle.Degrees(-56.37140265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45229"},
        {"Hipparcos Number", "HIP 30342"},
        {"Geneva Identification System", "GEN# +1.00045229"},
        {"Renson", "Renson 11990"},
        {"Smithsonian Astrophysical Observation", "SAO 234473"},
        {"Wilson Evans Batten Catalogue", "WEB 6037"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.73278618),
        dec: Angle.Degrees(-56.36992070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80726"},
        {"Hipparcos Number", "HIP 45714"},
        {"Geneva Identification System", "GEN# +1.00080726"},
        {"Smithsonian Astrophysical Observation", "SAO 236847"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.78917120),
        dec: Angle.Degrees(-56.36559700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45002"},
        {"Hipparcos Number", "HIP 30237"},
        {"Smithsonian Astrophysical Observation", "SAO 234465"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.41977059),
        dec: Angle.Degrees(-56.36229082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186543"},
        {"Hipparcos Number", "HIP 97421"},
        {"Fundamental Katalog 5th Edition", "FK5 739"},
        {"Geneva Identification System", "GEN# +1.00186543"},
        {"Renson", "Renson 51400"},
        {"Smithsonian Astrophysical Observation", "SAO 246271"},
        {"Wilson Evans Batten Catalogue", "WEB 17119"},
    },
    visualMagnitude: 5.33,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.00459018),
        dec: Angle.Degrees(-56.36227755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118966"},
        {"Hipparcos Number", "HIP 66820"},
        {"Smithsonian Astrophysical Observation", "SAO 241073"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.43445657),
        dec: Angle.Degrees(-56.36055331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68899"},
        {"Hipparcos Number", "HIP 40112"},
        {"Smithsonian Astrophysical Observation", "SAO 235799"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.89545353),
        dec: Angle.Degrees(-56.35980780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129328"},
        {"Hipparcos Number", "HIP 72032"},
        {"Smithsonian Astrophysical Observation", "SAO 241953"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.01720003),
        dec: Angle.Degrees(-56.35900203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7041"},
        {"Hipparcos Number", "HIP 5455"},
        {"Geneva Identification System", "GEN# +1.00007041"},
        {"Smithsonian Astrophysical Observation", "SAO 232320"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.45552793),
        dec: Angle.Degrees(-56.35605647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43473"},
        {"Hipparcos Number", "HIP 29514"},
        {"Smithsonian Astrophysical Observation", "SAO 234380"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.26252757),
        dec: Angle.Degrees(-56.35605547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160567"},
        {"Hipparcos Number", "HIP 86780"},
        {"Smithsonian Astrophysical Observation", "SAO 244972"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.98995560),
        dec: Angle.Degrees(-56.35555317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115097"},
        {"Hipparcos Number", "HIP 64724"},
        {"Smithsonian Astrophysical Observation", "SAO 240689"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.99338416),
        dec: Angle.Degrees(-56.35536014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163656"},
        {"Hipparcos Number", "HIP 88186"},
        {"Smithsonian Astrophysical Observation", "SAO 245164"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.14666018),
        dec: Angle.Degrees(-56.35182044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3680"},
        {"Hipparcos Number", "HIP 3066"},
        {"Smithsonian Astrophysical Observation", "SAO 232131"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.72449994),
        dec: Angle.Degrees(-56.35128592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156139"},
        {"Hipparcos Number", "HIP 84724"},
        {"Smithsonian Astrophysical Observation", "SAO 244614"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.76638276),
        dec: Angle.Degrees(-56.35035659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159019"},
        {"Hipparcos Number", "HIP 86093"},
        {"Geneva Identification System", "GEN# +1.00159019"},
        {"Smithsonian Astrophysical Observation", "SAO 244872"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.91752154),
        dec: Angle.Degrees(-56.34871023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123146"},
        {"Henry Draper 2", "HD 123147"},
        {"Hipparcos Number", "HIP 69007"},
        {"Geneva Identification System", "GEN# +1.00123146"},
        {"Geneva Identification System 2", "GEN# +1.00123147"},
        {"Smithsonian Astrophysical Observation", "SAO 241461"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.90903354),
        dec: Angle.Degrees(-56.34793608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92808"},
        {"Hipparcos Number", "HIP 52337"},
        {"Geneva Identification System", "GEN# +1.00092808"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.43202905),
        dec: Angle.Degrees(-56.34400179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44542"},
        {"Smithsonian Astrophysical Observation", "SAO 236565"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.13212106),
        dec: Angle.Degrees(-56.34345263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94063"},
        {"Hipparcos Number", "HIP 52993"},
        {"Geneva Identification System", "GEN# +1.00094063"},
        {"Smithsonian Astrophysical Observation", "SAO 238521"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.61051263),
        dec: Angle.Degrees(-56.34185806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78190"},
        {"Hipparcos Number", "HIP 44545"},
        {"Celescope Catalog", "CEL 3173"},
        {"Geneva Identification System", "GEN# +1.00078190J"},
        {"Smithsonian Astrophysical Observation", "SAO 236568"},
        {"Wilson Evans Batten Catalogue", "WEB 8529"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.13687408),
        dec: Angle.Degrees(-56.34106089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143796"},
        {"Hipparcos Number", "HIP 78803"},
        {"Fundamental Katalog 5th Edition", "FK5 5420"},
        {"Geneva Identification System", "GEN# +1.00143796"},
        {"Smithsonian Astrophysical Observation", "SAO 243305"},
        {"Wilson Evans Batten Catalogue", "WEB 13321"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.31462770),
        dec: Angle.Degrees(-56.33989551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102277"},
        {"Hipparcos Number", "HIP 57398"},
        {"Smithsonian Astrophysical Observation", "SAO 239358"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.51288242),
        dec: Angle.Degrees(-56.33768731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192726"},
        {"Hipparcos Number", "HIP 100178"},
        {"Smithsonian Astrophysical Observation", "SAO 246526"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.79452745),
        dec: Angle.Degrees(-56.33757245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86468"},
        {"Hipparcos Number", "HIP 48793"},
        {"Smithsonian Astrophysical Observation", "SAO 237527"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.27132891),
        dec: Angle.Degrees(-56.33514680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23759"},
        {"Hipparcos Number", "HIP 17494"},
        {"Smithsonian Astrophysical Observation", "SAO 233257"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.21059763),
        dec: Angle.Degrees(-56.33446832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205792"},
        {"Hipparcos Number", "HIP 106946"},
        {"Smithsonian Astrophysical Observation", "SAO 247122"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.89713082),
        dec: Angle.Degrees(-56.33305180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117740"},
        {"Hipparcos Number", "HIP 66136"},
        {"Geneva Identification System", "GEN# +1.00117740"},
        {"Smithsonian Astrophysical Observation", "SAO 240939"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.36180120),
        dec: Angle.Degrees(-56.33179617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147200"},
        {"Hipparcos Number", "HIP 80296"},
        {"Smithsonian Astrophysical Observation", "SAO 243724"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.86552036),
        dec: Angle.Degrees(-56.32972386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116777"},
        {"Hipparcos Number", "HIP 65594"},
        {"Smithsonian Astrophysical Observation", "SAO 240849"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.73592861),
        dec: Angle.Degrees(-56.32952395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110798"},
        {"Hipparcos Number", "HIP 62224"},
        {"Celescope Catalog", "CEL 4150"},
        {"Geneva Identification System", "GEN# +1.00110798"},
        {"Smithsonian Astrophysical Observation", "SAO 240211"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.29258558),
        dec: Angle.Degrees(-56.32914217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206575"},
        {"Hipparcos Number", "HIP 107369"},
        {"Smithsonian Astrophysical Observation", "SAO 247159"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.20838751),
        dec: Angle.Degrees(-56.32790287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14881",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14881"},
        {"Smithsonian Astrophysical Observation", "SAO 233034"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.02188680),
        dec: Angle.Degrees(-56.32644791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115087"},
        {"Hipparcos Number", "HIP 64719"},
        {"Smithsonian Astrophysical Observation", "SAO 240688"},
    },
    visualMagnitude: 9.64,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.97869800),
        dec: Angle.Degrees(-56.32539186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25131"},
        {"Hipparcos Number", "HIP 18445"},
        {"Geneva Identification System", "GEN# +1.00025131"},
        {"Smithsonian Astrophysical Observation", "SAO 233334"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.14383330),
        dec: Angle.Degrees(-56.32516481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125765"},
        {"Hipparcos Number", "HIP 70340"},
        {"Smithsonian Astrophysical Observation", "SAO 241683"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.86683845),
        dec: Angle.Degrees(-56.32435771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185283"},
        {"Hipparcos Number", "HIP 96861"},
        {"Geneva Identification System", "GEN# +1.00185283"},
        {"Smithsonian Astrophysical Observation", "SAO 246213"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.32535279),
        dec: Angle.Degrees(-56.32174782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -162.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83657"},
        {"Hipparcos Number", "HIP 47277"},
        {"Smithsonian Astrophysical Observation", "SAO 237167"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.52554147),
        dec: Angle.Degrees(-56.32173227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60173"},
        {"Hipparcos Number", "HIP 36461"},
        {"Smithsonian Astrophysical Observation", "SAO 235246"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.53139498),
        dec: Angle.Degrees(-56.31880362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50100"},
        {"Hipparcos Number", "HIP 32618"},
        {"Smithsonian Astrophysical Observation", "SAO 234725"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.08142625),
        dec: Angle.Degrees(-56.31809737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103961"},
        {"Hipparcos Number", "HIP 58379"},
        {"Fundamental Katalog 5th Edition", "FK5 2956"},
        {"Geneva Identification System", "GEN# +1.00103961"},
        {"Smithsonian Astrophysical Observation", "SAO 239533"},
        {"Wilson Evans Batten Catalogue", "WEB 10436"},
    },
    visualMagnitude: 5.44,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.56352995),
        dec: Angle.Degrees(-56.31731449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16123"},
        {"Hipparcos Number", "HIP 11880"},
        {"Smithsonian Astrophysical Observation", "SAO 232814"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.31414034),
        dec: Angle.Degrees(-56.31677528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122358"},
        {"Hipparcos Number", "HIP 68640"},
        {"Smithsonian Astrophysical Observation", "SAO 241395"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.75697158),
        dec: Angle.Degrees(-56.31537681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176500"},
        {"Hipparcos Number", "HIP 93602"},
        {"Smithsonian Astrophysical Observation", "SAO 245891"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.92640480),
        dec: Angle.Degrees(-56.31519709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62612"},
        {"Hipparcos Number", "HIP 37502"},
        {"Smithsonian Astrophysical Observation", "SAO 235421"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.44992158),
        dec: Angle.Degrees(-56.31515903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184844"},
        {"Hipparcos Number", "HIP 96677"},
        {"Geneva Identification System", "GEN# +1.00184844"},
        {"Smithsonian Astrophysical Observation", "SAO 246199"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.82760268),
        dec: Angle.Degrees(-56.31379549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108553"},
        {"Hipparcos Number", "HIP 60872"},
        {"Smithsonian Astrophysical Observation", "SAO 239978"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.14519208),
        dec: Angle.Degrees(-56.31308345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109123"},
        {"Hipparcos Number", "HIP 61221"},
        {"Smithsonian Astrophysical Observation", "SAO 240043"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.18354925),
        dec: Angle.Degrees(-56.30844966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202298"},
        {"Hipparcos Number", "HIP 105061"},
        {"Smithsonian Astrophysical Observation", "SAO 246943"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.24665233),
        dec: Angle.Degrees(-56.30715736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112440"},
        {"Hipparcos Number", "HIP 63230"},
        {"Smithsonian Astrophysical Observation", "SAO 240411"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.34190357),
        dec: Angle.Degrees(-56.30710652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178349"},
        {"Hipparcos Number", "HIP 94278"},
        {"Fundamental Katalog 5th Edition", "FK5 5689"},
        {"Smithsonian Astrophysical Observation", "SAO 245959"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.84138247),
        dec: Angle.Degrees(-56.30671738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110273"},
        {"Hipparcos Number", "HIP 61928"},
        {"Geneva Identification System", "GEN# +1.00110273"},
        {"Smithsonian Astrophysical Observation", "SAO 240152"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.37120418),
        dec: Angle.Degrees(-56.30460889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66867"},
        {"Hipparcos Number", "HIP 39339"},
        {"Smithsonian Astrophysical Observation", "SAO 235705"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.62733363),
        dec: Angle.Degrees(-56.30356468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33000"},
        {"Hipparcos Number", "HIP 23546"},
        {"Geneva Identification System", "GEN# +1.00033000"},
        {"Smithsonian Astrophysical Observation", "SAO 233810"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.94988183),
        dec: Angle.Degrees(-56.30287174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220027"},
        {"Hipparcos Number", "HIP 115295"},
        {"Smithsonian Astrophysical Observation", "SAO 247839"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.26378438),
        dec: Angle.Degrees(-56.30283956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209373"},
        {"Hipparcos Number", "HIP 108971"},
        {"Geneva Identification System", "GEN# +1.00209373"},
        {"Smithsonian Astrophysical Observation", "SAO 247297"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.14532047),
        dec: Angle.Degrees(-56.29963967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130936"},
        {"Hipparcos Number", "HIP 72820"},
        {"Geneva Identification System", "GEN# +1.00130936"},
        {"Smithsonian Astrophysical Observation", "SAO 242085"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.26940545),
        dec: Angle.Degrees(-56.29912618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162661"},
        {"Hipparcos Number", "HIP 87753"},
        {"Smithsonian Astrophysical Observation", "SAO 245115"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.87466481),
        dec: Angle.Degrees(-56.29846605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17014"},
        {"Hipparcos Number", "HIP 12566"},
        {"Smithsonian Astrophysical Observation", "SAO 232863"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.40219842),
        dec: Angle.Degrees(-56.29712775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57969"},
        {"Hipparcos Number", "HIP 35567"},
        {"Geneva Identification System", "GEN# +1.00057969"},
        {"Smithsonian Astrophysical Observation", "SAO 235114"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.09575798),
        dec: Angle.Degrees(-56.29479639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30490"},
        {"Hipparcos Number", "HIP 22082"},
        {"Smithsonian Astrophysical Observation", "SAO 233666"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.24509962),
        dec: Angle.Degrees(-56.29461897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24566"},
        {"Hipparcos Number", "HIP 18055"},
        {"Geneva Identification System", "GEN# +1.00024566"},
        {"Smithsonian Astrophysical Observation", "SAO 233301"},
        {"Wilson Evans Batten Catalogue", "WEB 3481"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.88539211),
        dec: Angle.Degrees(-56.29401963)
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
    primaryId: "HIP 75108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136037"},
        {"Hipparcos Number", "HIP 75108"},
        {"Geneva Identification System", "GEN# +1.00136037"},
        {"Smithsonian Astrophysical Observation", "SAO 242430"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.22106443),
        dec: Angle.Degrees(-56.29377652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104200"},
        {"Hipparcos Number", "HIP 58509"},
        {"Geneva Identification System", "GEN# +1.00104200"},
        {"Smithsonian Astrophysical Observation", "SAO 239561"},
        {"Wilson Evans Batten Catalogue", "WEB 10447"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.98575597),
        dec: Angle.Degrees(-56.29313907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93247"},
        {"Hipparcos Number", "HIP 52570"},
        {"Geneva Identification System", "GEN# +1.00093247"},
        {"Wilson Evans Batten Catalogue", "WEB 9576"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.23481016),
        dec: Angle.Degrees(-56.28956114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120100"},
        {"Hipparcos Number", "HIP 67400"},
        {"Geneva Identification System", "GEN# +1.00120100"},
        {"Smithsonian Astrophysical Observation", "SAO 241192"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.20037346),
        dec: Angle.Degrees(-56.28900942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109024"},
        {"Hipparcos Number", "HIP 61166"},
        {"Celescope Catalog", "CEL 4118"},
        {"Geneva Identification System", "GEN# +1.00109024"},
        {"Smithsonian Astrophysical Observation", "SAO 240034"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.00757081),
        dec: Angle.Degrees(-56.28836102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59844",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Welch's Red Variable"},
        {"Hipparcos Number", "HIP 59844"},
    },
    visualMagnitude: 7.74,
    bvColour: 2.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.06998017),
        dec: Angle.Degrees(-56.28599782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135135"},
        {"Hipparcos Number", "HIP 74698"},
        {"Smithsonian Astrophysical Observation", "SAO 242361"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.98395744),
        dec: Angle.Degrees(-56.28455596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158550"},
        {"Hipparcos Number", "HIP 85897"},
        {"Smithsonian Astrophysical Observation", "SAO 244832"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.29795006),
        dec: Angle.Degrees(-56.28440180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95120"},
        {"Hipparcos Number", "HIP 53609"},
        {"Smithsonian Astrophysical Observation", "SAO 238638"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.51183063),
        dec: Angle.Degrees(-56.28230203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141983"},
        {"Hipparcos Number", "HIP 77914"},
        {"Smithsonian Astrophysical Observation", "SAO 243103"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.67849310),
        dec: Angle.Degrees(-56.28038110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99586"},
        {"Hipparcos Number", "HIP 55865"},
        {"Smithsonian Astrophysical Observation", "SAO 239078"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.75351376),
        dec: Angle.Degrees(-56.28021631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115598"},
        {"Hipparcos Number", "HIP 64987"},
        {"Celescope Catalog", "CEL 4232"},
        {"Geneva Identification System", "GEN# +1.00115598"},
        {"Smithsonian Astrophysical Observation", "SAO 240735"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.79891773),
        dec: Angle.Degrees(-56.27906864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218813"},
        {"Hipparcos Number", "HIP 114518"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.92546774),
        dec: Angle.Degrees(-56.27849677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92552"},
        {"Hipparcos Number", "HIP 52202"},
        {"Celescope Catalog", "CEL 3626"},
        {"Geneva Identification System", "GEN# +1.00092552"},
        {"Smithsonian Astrophysical Observation", "SAO 238323"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.98278345),
        dec: Angle.Degrees(-56.27784702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204352"},
        {"Hipparcos Number", "HIP 106148"},
        {"Geneva Identification System", "GEN# +1.00204352"},
        {"Smithsonian Astrophysical Observation", "SAO 247051"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.51736334),
        dec: Angle.Degrees(-56.27781946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223482"},
        {"Hipparcos Number", "HIP 117521"},
        {"Smithsonian Astrophysical Observation", "SAO 248033"},
    },
    visualMagnitude: 9.72,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.50331992),
        dec: Angle.Degrees(-56.27779598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188869"},
        {"Hipparcos Number", "HIP 98453"},
        {"Smithsonian Astrophysical Observation", "SAO 246377"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.05344991),
        dec: Angle.Degrees(-56.27685487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136267"},
        {"Hipparcos Number", "HIP 75219"},
        {"Geneva Identification System", "GEN# +1.00136267"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.55890218),
        dec: Angle.Degrees(-56.27659425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141840"},
        {"Hipparcos Number", "HIP 77856"},
        {"Geneva Identification System", "GEN# +1.00141840"},
        {"Smithsonian Astrophysical Observation", "SAO 243092"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.47209481),
        dec: Angle.Degrees(-56.27589147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207158"},
        {"Hipparcos Number", "HIP 107690"},
        {"Geneva Identification System", "GEN# +1.00207158"},
        {"Smithsonian Astrophysical Observation", "SAO 247190"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.22671593),
        dec: Angle.Degrees(-56.27400548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123926"},
        {"Hipparcos Number", "HIP 69382"},
        {"Smithsonian Astrophysical Observation", "SAO 241523"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.04276820),
        dec: Angle.Degrees(-56.27384743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67764"},
        {"Hipparcos Number", "HIP 39680"},
        {"Geneva Identification System", "GEN# +1.00067764"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.64059200),
        dec: Angle.Degrees(-56.27232943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102804"},
        {"Hipparcos Number", "HIP 57698"},
        {"Geneva Identification System", "GEN# +1.00102804"},
        {"Smithsonian Astrophysical Observation", "SAO 239409"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.49260389),
        dec: Angle.Degrees(-56.27199936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185911"},
        {"Hipparcos Number", "HIP 97128"},
        {"Smithsonian Astrophysical Observation", "SAO 246239"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.10751291),
        dec: Angle.Degrees(-56.27129327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10079"},
        {"Hipparcos Number", "HIP 7542"},
        {"Fundamental Katalog 5th Edition", "FK5 4147"},
        {"Smithsonian Astrophysical Observation", "SAO 232479"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.29195230),
        dec: Angle.Degrees(-56.27065817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85625"},
        {"Hipparcos Number", "HIP 48344"},
        {"Smithsonian Astrophysical Observation", "SAO 237416"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.82630228),
        dec: Angle.Degrees(-56.26713982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17450"},
        {"Hipparcos Number", "HIP 12896"},
        {"Smithsonian Astrophysical Observation", "SAO 232885"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.43919660),
        dec: Angle.Degrees(-56.26647203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152064"},
        {"Hipparcos Number", "HIP 82695"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.55545878),
        dec: Angle.Degrees(-56.26501383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73794"},
        {"Hipparcos Number", "HIP 42310"},
        {"Smithsonian Astrophysical Observation", "SAO 236132"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.39748734),
        dec: Angle.Degrees(-56.26212248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80093"},
        {"Hipparcos Number", "HIP 45429"},
        {"Smithsonian Astrophysical Observation", "SAO 236776"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.88097416),
        dec: Angle.Degrees(-56.26105116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132481"},
        {"Hipparcos Number", "HIP 73522"},
        {"Geneva Identification System", "GEN# +1.00132481"},
        {"Smithsonian Astrophysical Observation", "SAO 242174"},
        {"Wilson Evans Batten Catalogue", "WEB 12580"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.40989760),
        dec: Angle.Degrees(-56.26017194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185682"},
        {"Hipparcos Number", "HIP 97032"},
        {"Smithsonian Astrophysical Observation", "SAO 246228"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.80692405),
        dec: Angle.Degrees(-56.26014564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149498"},
        {"Hipparcos Number", "HIP 81469"},
        {"Geneva Identification System", "GEN# +1.00149498"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.59702760),
        dec: Angle.Degrees(-56.25859445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47792"},
        {"Hipparcos Number", "HIP 31612"},
        {"Smithsonian Astrophysical Observation", "SAO 234617"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.24680302),
        dec: Angle.Degrees(-56.25810097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87323"},
        {"Hipparcos Number", "HIP 49205"},
        {"Fundamental Katalog 5th Edition", "FK5 4889"},
        {"Geneva Identification System", "GEN# +1.00087323"},
        {"Smithsonian Astrophysical Observation", "SAO 237629"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.64580936),
        dec: Angle.Degrees(-56.25669503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2264"},
        {"Hipparcos Number", "HIP 2056"},
        {"Smithsonian Astrophysical Observation", "SAO 232039"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.51099878),
        dec: Angle.Degrees(-56.25571381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163486"},
        {"Hipparcos Number", "HIP 88104"},
        {"Smithsonian Astrophysical Observation", "SAO 245156"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.90813728),
        dec: Angle.Degrees(-56.25551689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190220"},
        {"Hipparcos Number", "HIP 99076"},
        {"Smithsonian Astrophysical Observation", "SAO 246436"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.70893098),
        dec: Angle.Degrees(-56.25484185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6220"},
        {"Hipparcos Number", "HIP 4847"},
        {"Smithsonian Astrophysical Observation", "SAO 232269"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.58943973),
        dec: Angle.Degrees(-56.25207660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201815"},
        {"Hipparcos Number", "HIP 104832"},
        {"Smithsonian Astrophysical Observation", "SAO 246919"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.56421810),
        dec: Angle.Degrees(-56.25144585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14398"},
        {"Hipparcos Number", "HIP 10694"},
        {"Geneva Identification System", "GEN# +1.00014398"},
        {"Smithsonian Astrophysical Observation", "SAO 232701"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.41821490),
        dec: Angle.Degrees(-56.25114847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25262"},
        {"Hipparcos Number", "HIP 18529"},
        {"Geneva Identification System", "GEN# +1.00025262"},
        {"Smithsonian Astrophysical Observation", "SAO 233341"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.43912860),
        dec: Angle.Degrees(-56.25038277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70561"},
        {"Hipparcos Number", "HIP 40821"},
        {"Geneva Identification System", "GEN# +1.00070561"},
        {"Smithsonian Astrophysical Observation", "SAO 235892"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.97452720),
        dec: Angle.Degrees(-56.24996039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116150"},
        {"Geneva Identification System", "GEN# -0.05610090"},
        {"Smithsonian Astrophysical Observation", "SAO 247917"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.99951821),
        dec: Angle.Degrees(-56.24971650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 322"},
        {"Hipparcos Number", "HIP 632"},
        {"Smithsonian Astrophysical Observation", "SAO 231934"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.92073631),
        dec: Angle.Degrees(-56.24955098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153161"},
        {"Hipparcos Number", "HIP 83249"},
        {"Smithsonian Astrophysical Observation", "SAO 244352"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.23038079),
        dec: Angle.Degrees(-56.24631462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12672"},
        {"Hipparcos Number", "HIP 9509"},
        {"Smithsonian Astrophysical Observation", "SAO 232609"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.58414223),
        dec: Angle.Degrees(-56.24591081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35433"},
        {"Hipparcos Number", "HIP 25009"},
        {"Geneva Identification System", "GEN# +1.00035433"},
        {"Smithsonian Astrophysical Observation", "SAO 233943"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.32244326),
        dec: Angle.Degrees(-56.24544176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151319"},
        {"Hipparcos Number", "HIP 82361"},
        {"Smithsonian Astrophysical Observation", "SAO 244170"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.44218366),
        dec: Angle.Degrees(-56.24492631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59487"},
        {"Hipparcos Number", "HIP 36170"},
        {"Smithsonian Astrophysical Observation", "SAO 235203"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.75122795),
        dec: Angle.Degrees(-56.24437841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76233"},
        {"Hipparcos Number", "HIP 43566"},
        {"Celescope Catalog", "CEL 3026"},
        {"Geneva Identification System", "GEN# +1.00076233"},
        {"Smithsonian Astrophysical Observation", "SAO 236357"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.09074153),
        dec: Angle.Degrees(-56.24211651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2848"},
        {"Hipparcos Number", "HIP 2468"},
        {"Smithsonian Astrophysical Observation", "SAO 232076"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.83506425),
        dec: Angle.Degrees(-56.24149203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198119"},
        {"Hipparcos Number", "HIP 102895"},
        {"Geneva Identification System", "GEN# +1.00198119"},
        {"Smithsonian Astrophysical Observation", "SAO 246752"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.67831638),
        dec: Angle.Degrees(-56.24122993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50715"},
        {"Hipparcos Number", "HIP 32871"},
        {"Smithsonian Astrophysical Observation", "SAO 234749"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.74748405),
        dec: Angle.Degrees(-56.24003593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91420"},
    },
    visualMagnitude: 11.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.66976494),
        dec: Angle.Degrees(-56.23984904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98309"},
        {"Hipparcos Number", "HIP 55178"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.45979830),
        dec: Angle.Degrees(-56.23862866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32865"},
        {"Smithsonian Astrophysical Observation", "SAO 234748"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.74121767),
        dec: Angle.Degrees(-56.23700323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23100"},
        {"Hipparcos Number", "HIP 17089"},
        {"Smithsonian Astrophysical Observation", "SAO 233209"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.91346634),
        dec: Angle.Degrees(-56.23462699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10731"},
        {"Hipparcos Number", "HIP 8056"},
        {"Smithsonian Astrophysical Observation", "SAO 232508"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.86772593),
        dec: Angle.Degrees(-56.23447075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42026"},
        {"Hipparcos Number", "HIP 28827"},
        {"Smithsonian Astrophysical Observation", "SAO 234298"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.27800361),
        dec: Angle.Degrees(-56.23316697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33362"},
        {"Hipparcos Number", "HIP 23761"},
        {"Smithsonian Astrophysical Observation", "SAO 233825"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.60224476),
        dec: Angle.Degrees(-56.23146021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61949"},
        {"Hipparcos Number", "HIP 37209"},
        {"Smithsonian Astrophysical Observation", "SAO 235385"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.65570114),
        dec: Angle.Degrees(-56.22936472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142606"},
        {"Hipparcos Number", "HIP 78210"},
        {"Smithsonian Astrophysical Observation", "SAO 243174"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.55580918),
        dec: Angle.Degrees(-56.22830481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47566"},
        {"Hipparcos Number", "HIP 31504"},
        {"Smithsonian Astrophysical Observation", "SAO 234600"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.96589452),
        dec: Angle.Degrees(-56.22799068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65997"},
        {"Geneva Identification System", "GEN# +9.86196036"},
    },
    visualMagnitude: 12.28,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.96482417),
        dec: Angle.Degrees(-56.22761146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -292.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171212"},
        {"Hipparcos Number", "HIP 91245"},
        {"Smithsonian Astrophysical Observation", "SAO 245584"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.17266081),
        dec: Angle.Degrees(-56.22679170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29178"},
        {"Hipparcos Number", "HIP 21187"},
        {"Geneva Identification System", "GEN# +1.00029178"},
        {"Smithsonian Astrophysical Observation", "SAO 233557"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.12798049),
        dec: Angle.Degrees(-56.22630149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1251"},
        {"Hipparcos Number", "HIP 1313"},
        {"Smithsonian Astrophysical Observation", "SAO 231985"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.13059775),
        dec: Angle.Degrees(-56.22459111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122116"},
        {"Hipparcos Number", "HIP 68496"},
        {"Geneva Identification System", "GEN# +1.00122116"},
        {"Smithsonian Astrophysical Observation", "SAO 241372"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.33269281),
        dec: Angle.Degrees(-56.22420604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36636"},
        {"Hipparcos Number", "HIP 25743"},
        {"Smithsonian Astrophysical Observation", "SAO 233999"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.44943411),
        dec: Angle.Degrees(-56.22262402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118423"},
        {"Hipparcos Number", "HIP 66523"},
        {"Geneva Identification System", "GEN# +1.00118423"},
        {"Smithsonian Astrophysical Observation", "SAO 241015"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.53698865),
        dec: Angle.Degrees(-56.22233856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198474"},
        {"Hipparcos Number", "HIP 103075"},
        {"Smithsonian Astrophysical Observation", "SAO 246767"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.27004398),
        dec: Angle.Degrees(-56.22011043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127427"},
        {"Hipparcos Number", "HIP 71163"},
        {"Smithsonian Astrophysical Observation", "SAO 241788"},
        {"New General Catalogue", "NGC 5662 510"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.32825856),
        dec: Angle.Degrees(-56.21601205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167852"},
        {"Hipparcos Number", "HIP 89872"},
        {"Smithsonian Astrophysical Observation", "SAO 245403"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.08907047),
        dec: Angle.Degrees(-56.21565377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45683"},
        {"Hipparcos Number", "HIP 30556"},
        {"Smithsonian Astrophysical Observation", "SAO 234498"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.35562310),
        dec: Angle.Degrees(-56.21421843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122438"},
        {"Hipparcos Number", "HIP 68670"},
        {"Geneva Identification System", "GEN# +1.00122438"},
        {"Smithsonian Astrophysical Observation", "SAO 241403"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.86072926),
        dec: Angle.Degrees(-56.21338128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117275"},
        {"Hipparcos Number", "HIP 65893"},
        {"Smithsonian Astrophysical Observation", "SAO 240900"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.60813677),
        dec: Angle.Degrees(-56.20965248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83708"},
        {"Hipparcos Number", "HIP 47308"},
        {"Geneva Identification System", "GEN# +1.00083708"},
        {"Smithsonian Astrophysical Observation", "SAO 237176"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.60866707),
        dec: Angle.Degrees(-56.20778657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90816"},
        {"Hipparcos Number", "HIP 51234"},
        {"Geneva Identification System", "GEN# +1.00090816"},
        {"Smithsonian Astrophysical Observation", "SAO 238084"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.97107572),
        dec: Angle.Degrees(-56.20670980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111191"},
        {"Hipparcos Number", "HIP 62470"},
        {"Smithsonian Astrophysical Observation", "SAO 240268"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.03329025),
        dec: Angle.Degrees(-56.20176131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3238"},
        {"Hipparcos Number", "HIP 2746"},
        {"Geneva Identification System", "GEN# +1.00003238"},
        {"Smithsonian Astrophysical Observation", "SAO 232097"},
        {"Wilson Evans Batten Catalogue", "WEB 495"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.75855064),
        dec: Angle.Degrees(-56.20082273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39936"},
        {"Hipparcos Number", "HIP 27757"},
        {"Smithsonian Astrophysical Observation", "SAO 234182"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.11880677),
        dec: Angle.Degrees(-56.20073928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7751"},
        {"Smithsonian Astrophysical Observation", "SAO 232490"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.94684603),
        dec: Angle.Degrees(-56.19644067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 286.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78331",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78331"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.90951035),
        dec: Angle.Degrees(-56.19513207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111902"},
        {"Hipparcos Number", "HIP 62883"},
        {"Smithsonian Astrophysical Observation", "SAO 240350"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.31723831),
        dec: Angle.Degrees(-56.19371076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18599"},
        {"Hipparcos Number", "HIP 13754"},
        {"Smithsonian Astrophysical Observation", "SAO 232947"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.26245332),
        dec: Angle.Degrees(-56.19221021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12936"},
        {"Hipparcos Number", "HIP 9708"},
        {"Smithsonian Astrophysical Observation", "SAO 232623"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.21836185),
        dec: Angle.Degrees(-56.16998381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 537"},
        {"Hipparcos Number", "HIP 782"},
        {"Smithsonian Astrophysical Observation", "SAO 231950"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.41376549),
        dec: Angle.Degrees(-56.19178561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144183"},
        {"Hipparcos Number", "HIP 78989"},
        {"Geneva Identification System", "GEN# +1.00144183"},
        {"Smithsonian Astrophysical Observation", "SAO 243339"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.85035422),
        dec: Angle.Degrees(-56.19095697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37679"},
        {"Hipparcos Number", "HIP 26367"},
        {"Smithsonian Astrophysical Observation", "SAO 234051"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.22834272),
        dec: Angle.Degrees(-56.18782597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183698"},
        {"Hipparcos Number", "HIP 96211"},
        {"Geneva Identification System", "GEN# +1.00183698"},
        {"Smithsonian Astrophysical Observation", "SAO 246159"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.45755163),
        dec: Angle.Degrees(-56.18777659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27555"},
        {"Hipparcos Number", "HIP 20051"},
        {"Smithsonian Astrophysical Observation", "SAO 233471"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.49643847),
        dec: Angle.Degrees(-56.18645712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150263"},
        {"Hipparcos Number", "HIP 81841"},
        {"Smithsonian Astrophysical Observation", "SAO 244085"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.75225679),
        dec: Angle.Degrees(-56.18505205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129771"},
        {"Hipparcos Number", "HIP 72254"},
        {"Smithsonian Astrophysical Observation", "SAO 241981"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.63312813),
        dec: Angle.Degrees(-56.18483979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181847"},
        {"Hipparcos Number", "HIP 95465"},
        {"Smithsonian Astrophysical Observation", "SAO 246080"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.28977690),
        dec: Angle.Degrees(-56.18110553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61764"},
        {"Hipparcos Number", "HIP 37137"},
        {"Smithsonian Astrophysical Observation", "SAO 235373"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.46445821),
        dec: Angle.Degrees(-56.17980243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224289"},
        {"Hipparcos Number", "HIP 118041"},
        {"Geneva Identification System", "GEN# +1.00224289"},
        {"Smithsonian Astrophysical Observation", "SAO 248070"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.14981252),
        dec: Angle.Degrees(-56.17731616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27142"},
        {"Hipparcos Number", "HIP 19759"},
        {"Geneva Identification System", "GEN# +1.00027142"},
        {"Smithsonian Astrophysical Observation", "SAO 233444"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.54676512),
        dec: Angle.Degrees(-56.17690385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90983"},
    },
    visualMagnitude: 12.62,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.37912101),
        dec: Angle.Degrees(-56.17622571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110506"},
        {"Hipparcos Number", "HIP 62058"},
        {"Celescope Catalog", "CEL 4147"},
        {"Geneva Identification System", "GEN# +1.00110506"},
        {"Smithsonian Astrophysical Observation", "SAO 240179"},
        {"Wilson Evans Batten Catalogue", "WEB 11033"},
    },
    visualMagnitude: 5.99,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.78838403),
        dec: Angle.Degrees(-56.17619646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168929"},
        {"Hipparcos Number", "HIP 90308"},
        {"Smithsonian Astrophysical Observation", "SAO 245458"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.39075014),
        dec: Angle.Degrees(-56.17278008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86633"},
        {"Hipparcos Number", "HIP 48865"},
        {"Celescope Catalog", "CEL 3418"},
        {"Geneva Identification System", "GEN# +1.00086633J"},
        {"Smithsonian Astrophysical Observation", "SAO 237544"},
    },
    visualMagnitude: 8.93,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.50054952),
        dec: Angle.Degrees(-56.17162420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13517"},
        {"Hipparcos Number", "HIP 10121"},
        {"Smithsonian Astrophysical Observation", "SAO 232659"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.53902704),
        dec: Angle.Degrees(-56.17093559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203149"},
        {"Hipparcos Number", "HIP 105554"},
        {"Smithsonian Astrophysical Observation", "SAO 247001"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.66906400),
        dec: Angle.Degrees(-56.16876828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34611"},
        {"Hipparcos Number", "HIP 24509"},
        {"Smithsonian Astrophysical Observation", "SAO 233896"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.85992244),
        dec: Angle.Degrees(-56.16845915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74322"},
        {"Hipparcos Number", "HIP 42588"},
        {"Smithsonian Astrophysical Observation", "SAO 236180"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.19943455),
        dec: Angle.Degrees(-56.16754364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67622"},
        {"Hipparcos Number", "HIP 39629"},
        {"Smithsonian Astrophysical Observation", "SAO 235743"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.48031475),
        dec: Angle.Degrees(-56.16661763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53131"},
    },
    visualMagnitude: 10.36,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.03034197),
        dec: Angle.Degrees(-56.16655360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39523"},
        {"Hipparcos Number", "HIP 27530"},
        {"Fundamental Katalog 5th Edition", "FK5 1156"},
        {"Geneva Identification System", "GEN# +1.00039523"},
        {"Smithsonian Astrophysical Observation", "SAO 234154"},
        {"Wilson Evans Batten Catalogue", "WEB 5406"},
    },
    visualMagnitude: 4.50,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.45656999),
        dec: Angle.Degrees(-56.16648860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29855"},
        {"Hipparcos Number", "HIP 21660"},
        {"Smithsonian Astrophysical Observation", "SAO 233608"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.76059520),
        dec: Angle.Degrees(-56.16614224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161218"},
        {"Hipparcos Number", "HIP 87070"},
        {"Geneva Identification System", "GEN# +1.00161218"},
        {"Smithsonian Astrophysical Observation", "SAO 245025"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.88682621),
        dec: Angle.Degrees(-56.16595970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75876"},
        {"Hipparcos Number", "HIP 43374"},
        {"Smithsonian Astrophysical Observation", "SAO 236324"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.52928992),
        dec: Angle.Degrees(-56.16595702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140042"},
        {"Hipparcos Number", "HIP 77072"},
        {"Fundamental Katalog 5th Edition", "FK5 3245"},
        {"Geneva Identification System", "GEN# +1.00140042"},
        {"Smithsonian Astrophysical Observation", "SAO 242889"},
    },
    visualMagnitude: 7.06,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.06760300),
        dec: Angle.Degrees(-56.16536898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79278"},
    },
    visualMagnitude: 9.56,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.70168300),
        dec: Angle.Degrees(-56.16475061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215205"},
        {"Hipparcos Number", "HIP 112285"},
        {"Smithsonian Astrophysical Observation", "SAO 247561"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.15364043),
        dec: Angle.Degrees(-56.16299851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80596"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.82968126),
        dec: Angle.Degrees(-56.16273218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41248"},
        {"Hipparcos Number", "HIP 28460"},
        {"Geneva Identification System", "GEN# +1.00041248"},
        {"Smithsonian Astrophysical Observation", "SAO 234250"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.13603897),
        dec: Angle.Degrees(-56.16197623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94314"},
        {"Hipparcos Number", "HIP 53132"},
        {"Smithsonian Astrophysical Observation", "SAO 238547"},
    },
    visualMagnitude: 8.73,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.03205705),
        dec: Angle.Degrees(-56.15977744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105137"},
        {"Hipparcos Number", "HIP 59032"},
        {"Smithsonian Astrophysical Observation", "SAO 239664"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.55019228),
        dec: Angle.Degrees(-56.15788290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118258"},
        {"Hipparcos Number", "HIP 66410"},
        {"Geneva Identification System", "GEN# +1.00118258"},
        {"Smithsonian Astrophysical Observation", "SAO 240999"},
        {"Wilson Evans Batten Catalogue", "WEB 11725"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.22893120),
        dec: Angle.Degrees(-56.15673050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55964"},
        {"Hipparcos Number", "HIP 34776"},
        {"Smithsonian Astrophysical Observation", "SAO 235005"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.98113942),
        dec: Angle.Degrees(-56.15561762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162154"},
        {"Hipparcos Number", "HIP 87522"},
        {"Smithsonian Astrophysical Observation", "SAO 245086"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.21626104),
        dec: Angle.Degrees(-56.15475803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212018"},
        {"Hipparcos Number", "HIP 110470"},
        {"Smithsonian Astrophysical Observation", "SAO 247426"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.65174991),
        dec: Angle.Degrees(-56.15241835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88773"},
        {"Hipparcos Number", "HIP 50026"},
        {"Celescope Catalog", "CEL 3465"},
        {"Geneva Identification System", "GEN# +1.00088773"},
        {"Smithsonian Astrophysical Observation", "SAO 237793"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.20113458),
        dec: Angle.Degrees(-56.15078574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26046"},
        {"Hipparcos Number", "HIP 19025"},
        {"Smithsonian Astrophysical Observation", "SAO 233391"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.12828553),
        dec: Angle.Degrees(-56.14950360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112533"},
        {"Hipparcos Number", "HIP 63291"},
        {"Smithsonian Astrophysical Observation", "SAO 240425"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.55060896),
        dec: Angle.Degrees(-56.14835539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23099"},
        {"Hipparcos Number", "HIP 17092"},
        {"Smithsonian Astrophysical Observation", "SAO 233210"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.92182338),
        dec: Angle.Degrees(-56.14816519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62714"},
        {"Hipparcos Number", "HIP 37549"},
        {"Renson", "Renson 17270"},
        {"Smithsonian Astrophysical Observation", "SAO 235432"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.59913412),
        dec: Angle.Degrees(-56.14603538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122232"},
        {"Hipparcos Number", "HIP 68565"},
        {"Geneva Identification System", "GEN# +1.00122232"},
        {"Smithsonian Astrophysical Observation", "SAO 241379"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.54536589),
        dec: Angle.Degrees(-56.14596092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213543"},
        {"Hipparcos Number", "HIP 111338"},
        {"Smithsonian Astrophysical Observation", "SAO 247485"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.34886881),
        dec: Angle.Degrees(-56.14468494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180183"},
        {"Hipparcos Number", "HIP 94899"},
        {"Geneva Identification System", "GEN# +1.00180183A"},
        {"Smithsonian Astrophysical Observation", "SAO 246019"},
        {"Wilson Evans Batten Catalogue", "WEB 16565"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.67322640),
        dec: Angle.Degrees(-56.14465353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218322"},
        {"Hipparcos Number", "HIP 114217"},
        {"Smithsonian Astrophysical Observation", "SAO 247749"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.95948684),
        dec: Angle.Degrees(-56.14326038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22973"},
        {"Hipparcos Number", "HIP 16990"},
        {"Geneva Identification System", "GEN# +1.00022973"},
        {"Smithsonian Astrophysical Observation", "SAO 233199"},
        {"Wilson Evans Batten Catalogue", "WEB 3231"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.63197954),
        dec: Angle.Degrees(-56.14306290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221315"},
        {"Hipparcos Number", "HIP 116099"},
        {"Smithsonian Astrophysical Observation", "SAO 247914"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.86930204),
        dec: Angle.Degrees(-56.14251549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122707"},
        {"Hipparcos Number", "HIP 68800"},
        {"Smithsonian Astrophysical Observation", "SAO 241423"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.26557480),
        dec: Angle.Degrees(-56.13900745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126692"},
        {"Hipparcos Number", "HIP 70824"},
        {"Geneva Identification System", "GEN# +1.00126692"},
        {"Smithsonian Astrophysical Observation", "SAO 241742"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.25229844),
        dec: Angle.Degrees(-56.13685046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200085"},
        {"Hipparcos Number", "HIP 103936"},
        {"Smithsonian Astrophysical Observation", "SAO 246837"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.89601600),
        dec: Angle.Degrees(-56.13582496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8342"},
        {"Hipparcos Number", "HIP 6345"},
        {"Smithsonian Astrophysical Observation", "SAO 232391"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.37702455),
        dec: Angle.Degrees(-56.13518726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14488"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.75510596),
        dec: Angle.Degrees(-56.13455943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35580"},
        {"Hipparcos Number", "HIP 25098"},
        {"Fundamental Katalog 5th Edition", "FK5 2403"},
        {"Geneva Identification System", "GEN# +1.00035580"},
        {"Smithsonian Astrophysical Observation", "SAO 233952"},
        {"Wilson Evans Batten Catalogue", "WEB 4868"},
    },
    visualMagnitude: 6.10,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.59229956),
        dec: Angle.Degrees(-56.13445367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136003"},
        {"Hipparcos Number", "HIP 75095"},
        {"Geneva Identification System", "GEN# +1.00136003"},
        {"Smithsonian Astrophysical Observation", "SAO 242427"},
        {"Wilson Evans Batten Catalogue", "WEB 12805"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.17842365),
        dec: Angle.Degrees(-56.13260045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126859"},
        {"Hipparcos Number", "HIP 70904"},
        {"Geneva Identification System", "GEN# +1.00126859"},
        {"Smithsonian Astrophysical Observation", "SAO 241751"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.49325702),
        dec: Angle.Degrees(-56.13119242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208561"},
        {"Hipparcos Number", "HIP 108501"},
        {"Smithsonian Astrophysical Observation", "SAO 247252"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.71154706),
        dec: Angle.Degrees(-56.12980371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109045"},
        {"Hipparcos Number", "HIP 61179"},
        {"Geneva Identification System", "GEN# +1.00109045"},
        {"Smithsonian Astrophysical Observation", "SAO 240037"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.03679380),
        dec: Angle.Degrees(-56.12955839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109298"},
        {"Hipparcos Number", "HIP 61330"},
        {"Smithsonian Astrophysical Observation", "SAO 240063"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.50143465),
        dec: Angle.Degrees(-56.12803400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149139"},
        {"Hipparcos Number", "HIP 81264"},
        {"Geneva Identification System", "GEN# +1.00149139"},
        {"Smithsonian Astrophysical Observation", "SAO 243972"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.96593142),
        dec: Angle.Degrees(-56.12724047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175265"},
        {"Hipparcos Number", "HIP 93090"},
        {"Geneva Identification System", "GEN# +1.00175265"},
        {"Smithsonian Astrophysical Observation", "SAO 245826"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.44968013),
        dec: Angle.Degrees(-56.12670137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203850"},
        {"Hipparcos Number", "HIP 105905"},
        {"Cincinnati Publication", "Ci 20 1281"},
        {"Geneva Identification System", "GEN# +1.00203850"},
        {"Smithsonian Astrophysical Observation", "SAO 247033"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.74067096),
        dec: Angle.Degrees(-56.12560249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 662.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 138.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164161"},
        {"Hipparcos Number", "HIP 88418"},
        {"Smithsonian Astrophysical Observation", "SAO 245198"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.79367990),
        dec: Angle.Degrees(-56.12503781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100735"},
        {"Hipparcos Number", "HIP 56507"},
        {"Geneva Identification System", "GEN# +1.00100735"},
        {"Smithsonian Astrophysical Observation", "SAO 239198"},
        {"Wilson Evans Batten Catalogue", "WEB 10156"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.76439290),
        dec: Angle.Degrees(-56.12232662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200322"},
        {"Hipparcos Number", "HIP 104072"},
        {"Smithsonian Astrophysical Observation", "SAO 246853"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.27427409),
        dec: Angle.Degrees(-56.12084580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108998"},
        {"Hipparcos Number", "HIP 61146"},
        {"Smithsonian Astrophysical Observation", "SAO 240030"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.95637437),
        dec: Angle.Degrees(-56.12049902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40644"},
        {"Hipparcos Number", "HIP 28127"},
        {"Smithsonian Astrophysical Observation", "SAO 234221"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.18316462),
        dec: Angle.Degrees(-56.12037796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30187"},
        {"Hipparcos Number", "HIP 21874"},
        {"Geneva Identification System", "GEN# +1.00030187"},
        {"Smithsonian Astrophysical Observation", "SAO 233634"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.54312385),
        dec: Angle.Degrees(-56.11898881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14616"},
        {"Hipparcos Number", "HIP 10859"},
        {"Smithsonian Astrophysical Observation", "SAO 232716"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.94029423),
        dec: Angle.Degrees(-56.11537284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75186"},
        {"Hipparcos Number", "HIP 43009"},
        {"Smithsonian Astrophysical Observation", "SAO 236253"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.47399112),
        dec: Angle.Degrees(-56.11207395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91463"},
        {"Hipparcos Number", "HIP 51589"},
        {"Smithsonian Astrophysical Observation", "SAO 238156"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.06841501),
        dec: Angle.Degrees(-56.11149403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94488"},
        {"Hipparcos Number", "HIP 53249"},
        {"Geneva Identification System", "GEN# +1.00094488"},
        {"Smithsonian Astrophysical Observation", "SAO 238571"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.36209881),
        dec: Angle.Degrees(-56.11103437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89569"},
        {"Hipparcos Number", "HIP 50493"},
        {"Geneva Identification System", "GEN# +1.00089569"},
        {"Smithsonian Astrophysical Observation", "SAO 237902"},
        {"Wilson Evans Batten Catalogue", "WEB 9263"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.65899399),
        dec: Angle.Degrees(-56.11067508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -239.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113237"},
        {"Hipparcos Number", "HIP 63695"},
        {"Celescope Catalog", "CEL 4195"},
        {"Geneva Identification System", "GEN# +1.00113237J"},
        {"Smithsonian Astrophysical Observation", "SAO 240503"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.79618303),
        dec: Angle.Degrees(-56.11060801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10887"},
        {"Hipparcos Number", "HIP 8193"},
        {"Geneva Identification System", "GEN# +1.00010887"},
        {"Smithsonian Astrophysical Observation", "SAO 232517"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.33334266),
        dec: Angle.Degrees(-56.10791053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88557"},
        {"Hipparcos Number", "HIP 49885"},
        {"Smithsonian Astrophysical Observation", "SAO 237767"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.79435341),
        dec: Angle.Degrees(-56.10552521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106475"},
        {"Hipparcos Number", "HIP 59734"},
        {"Smithsonian Astrophysical Observation", "SAO 239790"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.75094234),
        dec: Angle.Degrees(-56.10361872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6753"},
        {"Hipparcos Number", "HIP 5264"},
        {"Geneva Identification System", "GEN# +1.00006753"},
        {"Smithsonian Astrophysical Observation", "SAO 232300"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.81003820),
        dec: Angle.Degrees(-56.10341500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6684"},
        {"Hipparcos Number", "HIP 5202"},
        {"Smithsonian Astrophysical Observation", "SAO 232295"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.63681703),
        dec: Angle.Degrees(-56.10208953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52301"},
        {"Hipparcos Number", "HIP 33464"},
        {"Geneva Identification System", "GEN# +1.00052301"},
        {"Smithsonian Astrophysical Observation", "SAO 234812"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.35017158),
        dec: Angle.Degrees(-56.10140495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42328"},
        {"Hipparcos Number", "HIP 28950"},
        {"Smithsonian Astrophysical Observation", "SAO 234318"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.66176627),
        dec: Angle.Degrees(-56.10060467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139600"},
        {"Hipparcos Number", "HIP 76860"},
        {"Geneva Identification System", "GEN# +1.00139600"},
        {"Smithsonian Astrophysical Observation", "SAO 242837"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.42781186),
        dec: Angle.Degrees(-56.10008349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183771"},
        {"Hipparcos Number", "HIP 96231"},
        {"Geneva Identification System", "GEN# +1.00183771"},
        {"Smithsonian Astrophysical Observation", "SAO 246162"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.52466968),
        dec: Angle.Degrees(-56.10004827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197288"},
        {"Hipparcos Number", "HIP 102426"},
        {"Smithsonian Astrophysical Observation", "SAO 246716"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.33272091),
        dec: Angle.Degrees(-56.09763912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14682"},
        {"Hipparcos Number", "HIP 10897"},
        {"Smithsonian Astrophysical Observation", "SAO 232720"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.06510077),
        dec: Angle.Degrees(-56.09759899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3812"},
        {"Geneva Identification System", "GEN# -0.05600154"},
        {"Smithsonian Astrophysical Observation", "SAO 232194"},
    },
    visualMagnitude: 10.33,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.25544052),
        dec: Angle.Degrees(-56.09703704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222005"},
        {"Hipparcos Number", "HIP 116553"},
        {"Smithsonian Astrophysical Observation", "SAO 247950"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.31113655),
        dec: Angle.Degrees(-56.09698687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87122"},
        {"Hipparcos Number", "HIP 49092"},
        {"Celescope Catalog", "CEL 3422"},
        {"Geneva Identification System", "GEN# +1.00087122"},
        {"Smithsonian Astrophysical Observation", "SAO 237603"},
        {"Wilson Evans Batten Catalogue", "WEB 9102"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.30006153),
        dec: Angle.Degrees(-56.09656162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92781"},
        {"Hipparcos Number", "HIP 52326"},
        {"Smithsonian Astrophysical Observation", "SAO 238358"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.38860372),
        dec: Angle.Degrees(-56.09600330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103493"},
        {"Hipparcos Number", "HIP 58106"},
        {"Geneva Identification System", "GEN# +1.00103493J"},
        {"Smithsonian Astrophysical Observation", "SAO 239487"},
        {"Wilson Evans Batten Catalogue", "WEB 10403"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.75467546),
        dec: Angle.Degrees(-56.09550622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 209.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107562"},
        {"Hipparcos Number", "HIP 60312"},
        {"Geneva Identification System", "GEN# +1.00107562"},
        {"Smithsonian Astrophysical Observation", "SAO 239882"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.50821937),
        dec: Angle.Degrees(-56.09383402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220357"},
        {"Hipparcos Number", "HIP 115486"},
        {"Smithsonian Astrophysical Observation", "SAO 247852"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.91094554),
        dec: Angle.Degrees(-56.09374570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79835"},
        {"Hipparcos Number", "HIP 45310"},
        {"Smithsonian Astrophysical Observation", "SAO 236747"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.52897355),
        dec: Angle.Degrees(-56.09273323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52028"},
        {"Hipparcos Number", "HIP 33367"},
        {"Smithsonian Astrophysical Observation", "SAO 234796"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.08919682),
        dec: Angle.Degrees(-56.09042445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171988"},
        {"Hipparcos Number", "HIP 91600"},
        {"Smithsonian Astrophysical Observation", "SAO 245630"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.21237016),
        dec: Angle.Degrees(-56.08970888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22256"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.87508085),
        dec: Angle.Degrees(-55.68491581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81850"},
        {"Hipparcos Number", "HIP 46265"},
        {"Celescope Catalog", "CEL 3293"},
        {"Geneva Identification System", "GEN# +1.00081850J"},
        {"Smithsonian Astrophysical Observation", "SAO 236965"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.49602924),
        dec: Angle.Degrees(-56.08946456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68434"},
        {"Hipparcos Number", "HIP 39957"},
        {"Fundamental Katalog 5th Edition", "FK5 2638"},
        {"Geneva Identification System", "GEN# +1.00068434"},
        {"Renson", "Renson 18930"},
        {"Smithsonian Astrophysical Observation", "SAO 235784"},
        {"Wilson Evans Batten Catalogue", "WEB 7792"},
    },
    visualMagnitude: 5.66,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.39013231),
        dec: Angle.Degrees(-56.08547484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194754"},
        {"Hipparcos Number", "HIP 101132"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.49871489),
        dec: Angle.Degrees(-56.08501065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32778"},
        {"Hipparcos Number", "HIP 23437"},
        {"Cincinnati Publication", "Ci 20 314"},
        {"Geneva Identification System", "GEN# +1.00032778A"},
        {"Smithsonian Astrophysical Observation", "SAO 233796"},
        {"Wilson Evans Batten Catalogue", "WEB 4557"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.57128038),
        dec: Angle.Degrees(-56.08231511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 731.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219060"},
        {"Hipparcos Number", "HIP 114658"},
        {"Smithsonian Astrophysical Observation", "SAO 247783"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.40577937),
        dec: Angle.Degrees(-56.08028685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19238"},
        {"Hipparcos Number", "HIP 14219"},
        {"Smithsonian Astrophysical Observation", "SAO 232975"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.83959530),
        dec: Angle.Degrees(-56.07813730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43550"},
        {"Hipparcos Number", "HIP 29542"},
        {"Smithsonian Astrophysical Observation", "SAO 234385"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.37903152),
        dec: Angle.Degrees(-56.07429386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121600"},
        {"Hipparcos Number", "HIP 68211"},
        {"Geneva Identification System", "GEN# +1.00121600"},
        {"Smithsonian Astrophysical Observation", "SAO 241329"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.47843283),
        dec: Angle.Degrees(-56.06883172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92757"},
        {"Hipparcos Number", "HIP 52320"},
        {"Celescope Catalog", "CEL 3645"},
        {"Geneva Identification System", "GEN# +1.00092757"},
        {"Smithsonian Astrophysical Observation", "SAO 238355"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.35892764),
        dec: Angle.Degrees(-56.06873315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20334"},
        {"Hipparcos Number", "HIP 15033"},
        {"Smithsonian Astrophysical Observation", "SAO 233044"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.42323035),
        dec: Angle.Degrees(-56.06479643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106202"},
        {"Hipparcos Number", "HIP 59593"},
        {"Geneva Identification System", "GEN# +1.00106202"},
        {"Smithsonian Astrophysical Observation", "SAO 239763"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.30996338),
        dec: Angle.Degrees(-56.06459844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190671"},
        {"Hipparcos Number", "HIP 99256"},
        {"Smithsonian Astrophysical Observation", "SAO 246458"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.22572435),
        dec: Angle.Degrees(-56.06107580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144534"},
        {"Henry Draper 2", "HD 144535"},
        {"Hipparcos Number", "HIP 79133"},
        {"Smithsonian Astrophysical Observation", "SAO 243365"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.28770017),
        dec: Angle.Degrees(-56.05793688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24157"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.81878287),
        dec: Angle.Degrees(-56.05726064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 142.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147335"},
        {"Hipparcos Number", "HIP 80363"},
        {"Geneva Identification System", "GEN# +1.00147335"},
        {"Smithsonian Astrophysical Observation", "SAO 243746"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.06843597),
        dec: Angle.Degrees(-56.05470281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6282"},
        {"Hipparcos Number", "HIP 4898"},
        {"Smithsonian Astrophysical Observation", "SAO 232274"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.71783523),
        dec: Angle.Degrees(-56.05466531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 300084"},
        {"Hipparcos Number", "HIP 46308"},
        {"Smithsonian Astrophysical Observation", "SAO 236982"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.65337641),
        dec: Angle.Degrees(-56.05408472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187745"},
        {"Hipparcos Number", "HIP 97953"},
        {"Smithsonian Astrophysical Observation", "SAO 246327"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.61223527),
        dec: Angle.Degrees(-56.05057844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107375"},
        {"Hipparcos Number", "HIP 60216"},
        {"Smithsonian Astrophysical Observation", "SAO 239862"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.22098457),
        dec: Angle.Degrees(-56.04861475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152204"},
        {"Hipparcos Number", "HIP 82778"},
        {"Fundamental Katalog 5th Edition", "FK5 5493"},
        {"Smithsonian Astrophysical Observation", "SAO 244268"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.75446922),
        dec: Angle.Degrees(-56.04816274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51894"},
        {"Wilson Evans Batten Catalogue", "WEB 9471"},
    },
    visualMagnitude: 10.66,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.03587609),
        dec: Angle.Degrees(-56.04324972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89890"},
        {"Hipparcos Number", "HIP 50676"},
        {"Celescope Catalog", "CEL 3515"},
        {"Geneva Identification System", "GEN# +1.00089890"},
        {"Smithsonian Astrophysical Observation", "SAO 237959"},
        {"Wilson Evans Batten Catalogue", "WEB 9288"},
    },
    visualMagnitude: 4.50,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.22839581),
        dec: Angle.Degrees(-56.04322401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24049"},
        {"Hipparcos Number", "HIP 17671"},
        {"Geneva Identification System", "GEN# +1.00024049"},
        {"Smithsonian Astrophysical Observation", "SAO 233269"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.77519744),
        dec: Angle.Degrees(-56.04151813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 363.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72111"},
        {"Hipparcos Number", "HIP 41557"},
        {"Smithsonian Astrophysical Observation", "SAO 236013"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.09942765),
        dec: Angle.Degrees(-56.04115056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146729"},
        {"Hipparcos Number", "HIP 80081"},
        {"Geneva Identification System", "GEN# +1.00146729"},
        {"Smithsonian Astrophysical Observation", "SAO 243659"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.16188489),
        dec: Angle.Degrees(-56.04082625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121504"},
        {"Hipparcos Number", "HIP 68162"},
        {"Geneva Identification System", "GEN# +1.00121504"},
        {"Smithsonian Astrophysical Observation", "SAO 241321"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.32291295),
        dec: Angle.Degrees(-56.03983839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154173"},
        {"Hipparcos Number", "HIP 83749"},
        {"Smithsonian Astrophysical Observation", "SAO 244442"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.75025577),
        dec: Angle.Degrees(-56.03832087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68168"},
        {"Smithsonian Astrophysical Observation", "SAO 241323"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.33658253),
        dec: Angle.Degrees(-56.03418202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 301709"},
        {"Hipparcos Number", "HIP 56511"},
        {"Smithsonian Astrophysical Observation", "SAO 239199"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.77890145),
        dec: Angle.Degrees(-56.03297087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30030"},
        {"Hipparcos Number", "HIP 21787"},
        {"Smithsonian Astrophysical Observation", "SAO 233624"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.20309796),
        dec: Angle.Degrees(-56.03094239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114565"},
        {"Hipparcos Number", "HIP 64421"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.06084501),
        dec: Angle.Degrees(-56.02742913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98859"},
        {"Hipparcos Number", "HIP 55502"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.50530839),
        dec: Angle.Degrees(-56.02388531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167128"},
        {"Hipparcos Number", "HIP 89605"},
        {"Fundamental Katalog 5th Edition", "FK5 1474"},
        {"Geneva Identification System", "GEN# +1.00167128"},
        {"Smithsonian Astrophysical Observation", "SAO 245369"},
        {"Wilson Evans Batten Catalogue", "WEB 15261"},
    },
    visualMagnitude: 5.36,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.28140609),
        dec: Angle.Degrees(-56.02331993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89613"},
        {"Hipparcos Number", "HIP 50518"},
        {"Smithsonian Astrophysical Observation", "SAO 237907"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.75950817),
        dec: Angle.Degrees(-56.02077876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84656"},
        {"Hipparcos Number", "HIP 47830"},
        {"Celescope Catalog", "CEL 3376"},
        {"Geneva Identification System", "GEN# +1.00084656"},
        {"Renson", "Renson 24160"},
        {"Smithsonian Astrophysical Observation", "SAO 237298"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.23730426),
        dec: Angle.Degrees(-56.01743174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48971"},
        {"Hipparcos Number", "HIP 32149"},
        {"Smithsonian Astrophysical Observation", "SAO 234669"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.71140786),
        dec: Angle.Degrees(-56.01609727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66041"},
        {"Hipparcos Number", "HIP 38996"},
        {"Geneva Identification System", "GEN# +1.00066041"},
        {"Renson", "Renson 18180"},
        {"Smithsonian Astrophysical Observation", "SAO 235653"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.71477456),
        dec: Angle.Degrees(-56.01376383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179862"},
        {"Hipparcos Number", "HIP 94796"},
        {"Smithsonian Astrophysical Observation", "SAO 246011"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.31966041),
        dec: Angle.Degrees(-56.01261993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98038"},
        {"Hipparcos Number", "HIP 55018"},
        {"Smithsonian Astrophysical Observation", "SAO 238918"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.97044341),
        dec: Angle.Degrees(-56.01234240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131105"},
        {"Hipparcos Number", "HIP 72890"},
        {"Geneva Identification System", "GEN# +1.00131105"},
        {"Smithsonian Astrophysical Observation", "SAO 242099"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.46242929),
        dec: Angle.Degrees(-56.01169058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285"},
        {"Hipparcos Number", "HIP 612"},
        {"Geneva Identification System", "GEN# +1.00000285"},
        {"Smithsonian Astrophysical Observation", "SAO 231932"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.86689616),
        dec: Angle.Degrees(-56.01154749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130060"},
        {"Hipparcos Number", "HIP 72402"},
        {"Smithsonian Astrophysical Observation", "SAO 242006"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.05322368),
        dec: Angle.Degrees(-56.00868701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221752"},
        {"Hipparcos Number", "HIP 116390"},
        {"Smithsonian Astrophysical Observation", "SAO 247935"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.77006381),
        dec: Angle.Degrees(-56.00846301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64032"},
        {"Hipparcos Number", "HIP 38131"},
        {"Smithsonian Astrophysical Observation", "SAO 235537"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.20785965),
        dec: Angle.Degrees(-56.00808310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155409"},
        {"Hipparcos Number", "HIP 84338"},
        {"Geneva Identification System", "GEN# +1.00155409"},
        {"Smithsonian Astrophysical Observation", "SAO 244544"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.63233847),
        dec: Angle.Degrees(-56.00757448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140290"},
        {"Hipparcos Number", "HIP 77181"},
        {"Geneva Identification System", "GEN# +1.00140290"},
        {"Smithsonian Astrophysical Observation", "SAO 242924"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.39291895),
        dec: Angle.Degrees(-56.00672714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82789"},
        {"Hipparcos Number", "HIP 46803"},
        {"Smithsonian Astrophysical Observation", "SAO 237078"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.05469810),
        dec: Angle.Degrees(-56.00502626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171181"},
        {"Hipparcos Number", "HIP 91219"},
        {"Smithsonian Astrophysical Observation", "SAO 245577"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.11778252),
        dec: Angle.Degrees(-56.00468159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122324"},
        {"Hipparcos Number", "HIP 68620"},
        {"Geneva Identification System", "GEN# +1.00122324"},
        {"Smithsonian Astrophysical Observation", "SAO 241389"},
        {"Wilson Evans Batten Catalogue", "WEB 12015"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.70379076),
        dec: Angle.Degrees(-56.00412039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142364"},
        {"Hipparcos Number", "HIP 78109"},
        {"Geneva Identification System", "GEN# +1.00142364"},
        {"Smithsonian Astrophysical Observation", "SAO 243144"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.23463395),
        dec: Angle.Degrees(-56.00300034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37401"},
        {"Hipparcos Number", "HIP 26189"},
        {"Smithsonian Astrophysical Observation", "SAO 234035"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.73585960),
        dec: Angle.Degrees(-56.00078304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48764"},
        {"Hipparcos Number", "HIP 32041"},
        {"Smithsonian Astrophysical Observation", "SAO 234658"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.40749787),
        dec: Angle.Degrees(-55.99908667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88646"},
        {"Hipparcos Number", "HIP 49937"},
        {"Celescope Catalog", "CEL 3459"},
        {"Geneva Identification System", "GEN# +1.00088646"},
        {"Smithsonian Astrophysical Observation", "SAO 237775"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.94579839),
        dec: Angle.Degrees(-55.99593832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1622"},
        {"Hipparcos Number", "HIP 1613"},
        {"Geneva Identification System", "GEN# +1.00001622"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.04614172),
        dec: Angle.Degrees(-55.99399669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209593"},
        {"Hipparcos Number", "HIP 109118"},
        {"Geneva Identification System", "GEN# +1.00209593"},
        {"Smithsonian Astrophysical Observation", "SAO 247307"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.54614651),
        dec: Angle.Degrees(-55.99332098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157245"},
        {"Hipparcos Number", "HIP 85260"},
        {"Smithsonian Astrophysical Observation", "SAO 244724"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.32858483),
        dec: Angle.Degrees(-55.99307172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76308"},
        {"Hipparcos Number", "HIP 43600"},
        {"Smithsonian Astrophysical Observation", "SAO 236365"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.19712698),
        dec: Angle.Degrees(-55.99202230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175224"},
        {"Hipparcos Number", "HIP 93069"},
        {"Cincinnati Publication", "Ci 20 1117"},
        {"Geneva Identification System", "GEN# +1.00175224"},
        {"Smithsonian Astrophysical Observation", "SAO 245823"},
        {"Wilson Evans Batten Catalogue", "WEB 16119"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.37749732),
        dec: Angle.Degrees(-55.99081610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -441.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109115"},
    },
    visualMagnitude: 12.75,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.54257499),
        dec: Angle.Degrees(-55.99016928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152786"},
        {"Hipparcos Number", "HIP 83081"},
        {"Fundamental Katalog 5th Edition", "FK5 631"},
        {"Geneva Identification System", "GEN# +1.00152786"},
        {"Smithsonian Astrophysical Observation", "SAO 244315"},
        {"Wilson Evans Batten Catalogue", "WEB 14045"},
    },
    visualMagnitude: 3.12,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.65512817),
        dec: Angle.Degrees(-55.99005508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92464"},
        {"Hipparcos Number", "HIP 52161"},
        {"Celescope Catalog", "CEL 3619"},
        {"Geneva Identification System", "GEN# +1.00092464"},
        {"Smithsonian Astrophysical Observation", "SAO 238312"},
        {"Wilson Evans Batten Catalogue", "WEB 9506"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.84549354),
        dec: Angle.Degrees(-55.98980838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121792"},
        {"Hipparcos Number", "HIP 68322"},
        {"Smithsonian Astrophysical Observation", "SAO 241347"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.78944213),
        dec: Angle.Degrees(-55.98722966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213459"},
        {"Hipparcos Number", "HIP 111291"},
        {"Geneva Identification System", "GEN# +1.00213459"},
        {"Smithsonian Astrophysical Observation", "SAO 247480"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.17812585),
        dec: Angle.Degrees(-55.98722006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101844"},
        {"Geneva Identification System", "GEN# +6.20145059"},
    },
    visualMagnitude: 11.36,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.58091391),
        dec: Angle.Degrees(-55.60529117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118369"},
        {"Hipparcos Number", "HIP 66483"},
        {"Celescope Catalog", "CEL 4270"},
        {"Smithsonian Astrophysical Observation", "SAO 241006"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.44796879),
        dec: Angle.Degrees(-55.98545490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196563"},
        {"Hipparcos Number", "HIP 102044"},
        {"Smithsonian Astrophysical Observation", "SAO 246686"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.20419561),
        dec: Angle.Degrees(-55.98258293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93680"},
        {"Hipparcos Number", "HIP 52818"},
        {"Smithsonian Astrophysical Observation", "SAO 238486"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.98268694),
        dec: Angle.Degrees(-55.97729591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209268"},
        {"Hipparcos Number", "HIP 108903"},
        {"Geneva Identification System", "GEN# +1.00209268"},
        {"Smithsonian Astrophysical Observation", "SAO 247291"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.89790105),
        dec: Angle.Degrees(-55.97673111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -241.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16991"},
        {"Hipparcos Number", "HIP 12541"},
        {"Smithsonian Astrophysical Observation", "SAO 232861"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.34469681),
        dec: Angle.Degrees(-55.97602023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18898"},
        {"Hipparcos Number", "HIP 13971"},
        {"Smithsonian Astrophysical Observation", "SAO 232962"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.98754728),
        dec: Angle.Degrees(-55.97558024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106906"},
        {"Hipparcos Number", "HIP 59960"},
        {"Geneva Identification System", "GEN# +1.00106906"},
        {"Smithsonian Astrophysical Observation", "SAO 239819"},
        {"Wilson Evans Batten Catalogue", "WEB 10656"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.47180301),
        dec: Angle.Degrees(-55.97549495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140311"},
        {"Hipparcos Number", "HIP 77187"},
        {"Geneva Identification System", "GEN# +1.00140311J"},
        {"Smithsonian Astrophysical Observation", "SAO 242927"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.41658932),
        dec: Angle.Degrees(-55.97514246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163822"},
        {"Hipparcos Number", "HIP 88262"},
        {"Smithsonian Astrophysical Observation", "SAO 245174"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.35850969),
        dec: Angle.Degrees(-55.97416516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29166"},
        {"Hipparcos Number", "HIP 21183"},
        {"Smithsonian Astrophysical Observation", "SAO 233556"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.12153146),
        dec: Angle.Degrees(-55.97218674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57719"},
        {"Hipparcos Number", "HIP 35474"},
        {"Smithsonian Astrophysical Observation", "SAO 235100"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.84097268),
        dec: Angle.Degrees(-55.97091222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180887"},
        {"Hipparcos Number", "HIP 95134"},
        {"Smithsonian Astrophysical Observation", "SAO 246041"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.32853712),
        dec: Angle.Degrees(-55.96986546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6819"},
        {"Hipparcos Number", "HIP 5302"},
        {"Geneva Identification System", "GEN# +1.00006819"},
        {"Smithsonian Astrophysical Observation", "SAO 232301"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.95274959),
        dec: Angle.Degrees(-55.96977045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108208"},
        {"Hipparcos Number", "HIP 60679"},
        {"Geneva Identification System", "GEN# +1.00108208"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.53307615),
        dec: Angle.Degrees(-55.96976871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 143.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42211"},
        {"Hipparcos Number", "HIP 28895"},
        {"Smithsonian Astrophysical Observation", "SAO 234308"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.50776133),
        dec: Angle.Degrees(-55.96944532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9439"},
        {"Hipparcos Number", "HIP 7094"},
        {"Smithsonian Astrophysical Observation", "SAO 232448"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.85775345),
        dec: Angle.Degrees(-55.96807154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72143"},
        {"Hipparcos Number", "HIP 41579"},
        {"Smithsonian Astrophysical Observation", "SAO 236018"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.16479948),
        dec: Angle.Degrees(-55.96699979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218138"},
        {"Hipparcos Number", "HIP 114086"},
        {"Smithsonian Astrophysical Observation", "SAO 247728"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.59266927),
        dec: Angle.Degrees(-55.96571155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64203"},
        {"Hipparcos Number", "HIP 38212"},
        {"Smithsonian Astrophysical Observation", "SAO 235548"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.42295051),
        dec: Angle.Degrees(-55.96439886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125687"},
        {"Hipparcos Number", "HIP 70290"},
        {"Smithsonian Astrophysical Observation", "SAO 241679"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.71768134),
        dec: Angle.Degrees(-55.96230443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36816"},
    },
    visualMagnitude: 12.44,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.57716496),
        dec: Angle.Degrees(-55.96226529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127502"},
        {"Hipparcos Number", "HIP 71202"},
        {"Smithsonian Astrophysical Observation", "SAO 241796"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.42530266),
        dec: Angle.Degrees(-55.96108427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119974"},
        {"Hipparcos Number", "HIP 67326"},
        {"Geneva Identification System", "GEN# +1.00119974"},
        {"Smithsonian Astrophysical Observation", "SAO 241181"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.99090974),
        dec: Angle.Degrees(-55.96060503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81222"},
        {"Hipparcos Number", "HIP 45949"},
        {"Geneva Identification System", "GEN# +1.00081222"},
        {"Smithsonian Astrophysical Observation", "SAO 236893"},
        {"Wilson Evans Batten Catalogue", "WEB 8714"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.56740998),
        dec: Angle.Degrees(-55.96035501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81951"},
        {"Hipparcos Number", "HIP 46322"},
        {"Smithsonian Astrophysical Observation", "SAO 236985"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.67535142),
        dec: Angle.Degrees(-55.95938761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124339"},
        {"Hipparcos Number", "HIP 69611"},
        {"Geneva Identification System", "GEN# +1.00124339"},
        {"Smithsonian Astrophysical Observation", "SAO 241562"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.70244510),
        dec: Angle.Degrees(-55.95936886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116402"},
        {"Hipparcos Number", "HIP 65423"},
        {"Geneva Identification System", "GEN# +1.00116402"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.14646384),
        dec: Angle.Degrees(-55.95667499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85106"},
        {"Hipparcos Number", "HIP 48065"},
        {"Geneva Identification System", "GEN# +1.00085106"},
        {"Smithsonian Astrophysical Observation", "SAO 237348"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.96985909),
        dec: Angle.Degrees(-55.95624180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76841"},
        {"Hipparcos Number", "HIP 43869"},
        {"Smithsonian Astrophysical Observation", "SAO 236418"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.05539118),
        dec: Angle.Degrees(-55.95531034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169303"},
        {"Hipparcos Number", "HIP 90446"},
        {"Geneva Identification System", "GEN# +1.00169303"},
        {"Smithsonian Astrophysical Observation", "SAO 245475"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.82321856),
        dec: Angle.Degrees(-55.95420466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121280"},
        {"Hipparcos Number", "HIP 68054"},
        {"Smithsonian Astrophysical Observation", "SAO 241306"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.01925981),
        dec: Angle.Degrees(-55.95300836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218218"},
        {"Hipparcos Number", "HIP 114150"},
        {"Smithsonian Astrophysical Observation", "SAO 247736"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.76773148),
        dec: Angle.Degrees(-55.95228358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199200"},
        {"Hipparcos Number", "HIP 103486"},
        {"Geneva Identification System", "GEN# +1.00199200"},
        {"Smithsonian Astrophysical Observation", "SAO 246806"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.50537694),
        dec: Angle.Degrees(-55.95046427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53868"},
        {"Hipparcos Number", "HIP 34015"},
        {"Smithsonian Astrophysical Observation", "SAO 234891"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.87349579),
        dec: Angle.Degrees(-55.94831148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21266"},
        {"Hipparcos Number", "HIP 15773"},
        {"Smithsonian Astrophysical Observation", "SAO 233101"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.81662729),
        dec: Angle.Degrees(-55.94813706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218271"},
        {"Hipparcos Number", "HIP 114188"},
        {"Smithsonian Astrophysical Observation", "SAO 247742"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.86468600),
        dec: Angle.Degrees(-55.94802088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110461"},
        {"Hipparcos Number", "HIP 62026"},
        {"Celescope Catalog", "CEL 4146"},
        {"Geneva Identification System", "GEN# +1.00110461"},
        {"Smithsonian Astrophysical Observation", "SAO 240176"},
        {"Wilson Evans Batten Catalogue", "WEB 11029"},
    },
    visualMagnitude: 6.06,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.70748233),
        dec: Angle.Degrees(-55.94696105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210602"},
        {"Hipparcos Number", "HIP 109666"},
        {"Smithsonian Astrophysical Observation", "SAO 247359"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.23395099),
        dec: Angle.Degrees(-55.94496235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14641"},
        {"Hipparcos Number", "HIP 10871"},
        {"Fundamental Katalog 5th Edition", "FK5 2158"},
        {"Geneva Identification System", "GEN# +1.00014641J"},
        {"Smithsonian Astrophysical Observation", "SAO 232717"},
        {"Wilson Evans Batten Catalogue", "WEB 2293"},
    },
    visualMagnitude: 5.81,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.97602796),
        dec: Angle.Degrees(-55.94484169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137924"},
        {"Hipparcos Number", "HIP 76009"},
        {"Smithsonian Astrophysical Observation", "SAO 242648"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.85790252),
        dec: Angle.Degrees(-55.94325158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74045"},
        {"Hipparcos Number", "HIP 42424"},
        {"Smithsonian Astrophysical Observation", "SAO 236148"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.76697013),
        dec: Angle.Degrees(-55.94244705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148473"},
        {"Hipparcos Number", "HIP 80913"},
        {"Geneva Identification System", "GEN# +1.00148473"},
        {"Smithsonian Astrophysical Observation", "SAO 243905"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.84667488),
        dec: Angle.Degrees(-55.93980744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193808"},
        {"Hipparcos Number", "HIP 100699"},
        {"Smithsonian Astrophysical Observation", "SAO 246568"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.23498979),
        dec: Angle.Degrees(-55.93963501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160266"},
        {"Hipparcos Number", "HIP 86640"},
        {"Smithsonian Astrophysical Observation", "SAO 244952"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.55250281),
        dec: Angle.Degrees(-55.93797996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39013"},
        {"Hipparcos Number", "HIP 27238"},
        {"Geneva Identification System", "GEN# +1.00039013"},
        {"Smithsonian Astrophysical Observation", "SAO 234129"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.59600550),
        dec: Angle.Degrees(-55.93680526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66847"},
        {"Hipparcos Number", "HIP 39324"},
        {"Smithsonian Astrophysical Observation", "SAO 235701"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.60680396),
        dec: Angle.Degrees(-55.93664718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 300083"},
        {"Hipparcos Number", "HIP 46327"},
        {"Smithsonian Astrophysical Observation", "SAO 236986"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.68030227),
        dec: Angle.Degrees(-55.93579011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213400"},
        {"Hipparcos Number", "HIP 111246"},
        {"Smithsonian Astrophysical Observation", "SAO 247476"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.07759697),
        dec: Angle.Degrees(-55.93541972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181459"},
        {"Hipparcos Number", "HIP 95329"},
        {"Geneva Identification System", "GEN# +1.00181459"},
        {"Smithsonian Astrophysical Observation", "SAO 246064"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.91483460),
        dec: Angle.Degrees(-55.93532381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199248"},
        {"Hipparcos Number", "HIP 103514"},
        {"Smithsonian Astrophysical Observation", "SAO 246809"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.57545260),
        dec: Angle.Degrees(-55.93476897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149299"},
        {"Hipparcos Number", "HIP 81352"},
        {"Smithsonian Astrophysical Observation", "SAO 243986"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.21548086),
        dec: Angle.Degrees(-55.93293556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109808"},
        {"Hipparcos Number", "HIP 61639"},
        {"Celescope Catalog", "CEL 4135"},
        {"Geneva Identification System", "GEN# +1.00109808J"},
        {"Smithsonian Astrophysical Observation", "SAO 240104"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.53037716),
        dec: Angle.Degrees(-55.93118630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114526"},
        {"Hipparcos Number", "HIP 64414"},
        {"Smithsonian Astrophysical Observation", "SAO 240643"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.02962163),
        dec: Angle.Degrees(-55.92845498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199995"},
        {"Hipparcos Number", "HIP 103886"},
        {"Smithsonian Astrophysical Observation", "SAO 246834"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.74374879),
        dec: Angle.Degrees(-55.92724054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116357"},
        {"Hipparcos Number", "HIP 65402"},
        {"Smithsonian Astrophysical Observation", "SAO 240803"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.06903296),
        dec: Angle.Degrees(-55.92623979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103806"},
        {"Hipparcos Number", "HIP 58271"},
        {"Smithsonian Astrophysical Observation", "SAO 239519"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.26269646),
        dec: Angle.Degrees(-55.91777249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46212"},
        {"Hipparcos Number", "HIP 30861"},
        {"Smithsonian Astrophysical Observation", "SAO 234529"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.19050411),
        dec: Angle.Degrees(-55.91719102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52251"},
        {"Hipparcos Number", "HIP 33440"},
        {"Fundamental Katalog 5th Edition", "FK5 4630"},
        {"Smithsonian Astrophysical Observation", "SAO 234810"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.29837320),
        dec: Angle.Degrees(-55.91509034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112781"},
        {"Hipparcos Number", "HIP 63424"},
        {"Smithsonian Astrophysical Observation", "SAO 240457"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.95806761),
        dec: Angle.Degrees(-55.91501430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216011"},
        {"Hipparcos Number", "HIP 112764"},
        {"Smithsonian Astrophysical Observation", "SAO 247608"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.55483324),
        dec: Angle.Degrees(-55.91499664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131643"},
        {"Hipparcos Number", "HIP 73159"},
        {"Geneva Identification System", "GEN# +1.00131643"},
        {"Smithsonian Astrophysical Observation", "SAO 242127"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.27555169),
        dec: Angle.Degrees(-55.91260118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112764"},
        {"Hipparcos Number", "HIP 63422"},
        {"Celescope Catalog", "CEL 4188"},
        {"Geneva Identification System", "GEN# +1.00112764"},
        {"Smithsonian Astrophysical Observation", "SAO 240455"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.95132924),
        dec: Angle.Degrees(-55.91229524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110324"},
        {"Hipparcos Number", "HIP 61948"},
        {"Geneva Identification System", "GEN# +1.00110324"},
        {"Smithsonian Astrophysical Observation", "SAO 240159"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.44761773),
        dec: Angle.Degrees(-55.91094671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89185"},
        {"Hipparcos Number", "HIP 50265"},
        {"Smithsonian Astrophysical Observation", "SAO 237848"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.95504141),
        dec: Angle.Degrees(-55.90909699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87541"},
        {"Hipparcos Number", "HIP 49318"},
        {"Celescope Catalog", "CEL 3437"},
        {"Geneva Identification System", "GEN# +1.00087541"},
        {"Smithsonian Astrophysical Observation", "SAO 237657"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.00502302),
        dec: Angle.Degrees(-55.90822218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67366"},
        {"Hipparcos Number", "HIP 39532"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.18265903),
        dec: Angle.Degrees(-55.90755003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28601"},
        {"Henry Draper 2", "HD 28601A"},
        {"Hipparcos Number", "HIP 20805"},
        {"Smithsonian Astrophysical Observation", "SAO 233530"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.87695237),
        dec: Angle.Degrees(-55.90514705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99682"},
        {"Hipparcos Number", "HIP 55909"},
        {"Geneva Identification System", "GEN# +1.00099682"},
        {"Smithsonian Astrophysical Observation", "SAO 239085"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.89800793),
        dec: Angle.Degrees(-55.90416524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50450"},
        {"Hipparcos Number", "HIP 32778"},
        {"Geneva Identification System", "GEN# +1.00050450"},
        {"Smithsonian Astrophysical Observation", "SAO 234739"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.51018200),
        dec: Angle.Degrees(-55.90356180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187542"},
        {"Hipparcos Number", "HIP 97881"},
        {"Geneva Identification System", "GEN# +1.00187542"},
        {"Smithsonian Astrophysical Observation", "SAO 246319"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.35642302),
        dec: Angle.Degrees(-55.90152772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21982"},
        {"Hipparcos Number", "HIP 16284"},
        {"Geneva Identification System", "GEN# +1.00021982"},
        {"Smithsonian Astrophysical Observation", "SAO 233136"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.47960309),
        dec: Angle.Degrees(-55.90025404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162520"},
        {"Hipparcos Number", "HIP 87695"},
        {"Smithsonian Astrophysical Observation", "SAO 245108"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.68464370),
        dec: Angle.Degrees(-55.89840420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99978"},
        {"Hipparcos Number", "HIP 56074"},
        {"Geneva Identification System", "GEN# +1.00099978"},
        {"Smithsonian Astrophysical Observation", "SAO 239114"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.40531338),
        dec: Angle.Degrees(-55.89568476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78309"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.84464801),
        dec: Angle.Degrees(-55.89543829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212090"},
        {"Hipparcos Number", "HIP 110503"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.77838839),
        dec: Angle.Degrees(-55.89409643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190058"},
        {"Hipparcos Number", "HIP 99007"},
        {"Geneva Identification System", "GEN# +1.00190058"},
        {"Smithsonian Astrophysical Observation", "SAO 246431"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.49885751),
        dec: Angle.Degrees(-55.89297721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109458"},
        {"Hipparcos Number", "HIP 61426"},
        {"Geneva Identification System", "GEN# +1.00109458"},
        {"Smithsonian Astrophysical Observation", "SAO 240077"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.81063686),
        dec: Angle.Degrees(-55.89297578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70164"},
        {"Hipparcos Number", "HIP 40636"},
        {"Smithsonian Astrophysical Observation", "SAO 235870"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.43473630),
        dec: Angle.Degrees(-55.89195114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 302073"},
        {"Hipparcos Number", "HIP 44600"},
        {"Smithsonian Astrophysical Observation", "SAO 236586"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.30191237),
        dec: Angle.Degrees(-55.89185732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119526"},
        {"Hipparcos Number", "HIP 67096"},
        {"Smithsonian Astrophysical Observation", "SAO 241132"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.28537238),
        dec: Angle.Degrees(-55.89107396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209356"},
        {"Hipparcos Number", "HIP 108954"},
        {"Smithsonian Astrophysical Observation", "SAO 247294"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.10675275),
        dec: Angle.Degrees(-55.89081280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13528"},
        {"Hipparcos Number", "HIP 10135"},
        {"Smithsonian Astrophysical Observation", "SAO 232661"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.58858671),
        dec: Angle.Degrees(-55.89080602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172306"},
        {"Hipparcos Number", "HIP 91754"},
        {"Smithsonian Astrophysical Observation", "SAO 245643"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.65606742),
        dec: Angle.Degrees(-55.88971190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181703"},
        {"Hipparcos Number", "HIP 95404"},
        {"Smithsonian Astrophysical Observation", "SAO 246070"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.10955100),
        dec: Angle.Degrees(-55.88829453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203692"},
        {"Hipparcos Number", "HIP 105822"},
        {"Smithsonian Astrophysical Observation", "SAO 247023"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.49052012),
        dec: Angle.Degrees(-55.88815459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61394"},
        {"Hipparcos Number", "HIP 36977"},
        {"Geneva Identification System", "GEN# +1.00061394"},
        {"Smithsonian Astrophysical Observation", "SAO 235343"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.00674600),
        dec: Angle.Degrees(-55.88773325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102937"},
        {"Hipparcos Number", "HIP 57776"},
        {"Smithsonian Astrophysical Observation", "SAO 239425"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.71620030),
        dec: Angle.Degrees(-55.88760947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99822"},
        {"Hipparcos Number", "HIP 55989"},
        {"Geneva Identification System", "GEN# +1.00099822"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.11887341),
        dec: Angle.Degrees(-55.88740201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208796"},
        {"Hipparcos Number", "HIP 108626"},
        {"Geneva Identification System", "GEN# +1.00208796"},
        {"Smithsonian Astrophysical Observation", "SAO 247262"},
        {"Wilson Evans Batten Catalogue", "WEB 19546"},
    },
    visualMagnitude: 6.02,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.10093018),
        dec: Angle.Degrees(-55.88345150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125104"},
        {"Hipparcos Number", "HIP 69978"},
        {"Celescope Catalog", "CEL 4310"},
        {"Geneva Identification System", "GEN# +1.00125104"},
        {"Smithsonian Astrophysical Observation", "SAO 241629"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.78772848),
        dec: Angle.Degrees(-55.88223866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140679"},
        {"Hipparcos Number", "HIP 77375"},
        {"Smithsonian Astrophysical Observation", "SAO 242973"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.92424299),
        dec: Angle.Degrees(-55.88191030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18325"},
        {"Hipparcos Number", "HIP 13536"},
        {"Geneva Identification System", "GEN# +1.00018325"},
        {"Smithsonian Astrophysical Observation", "SAO 232937"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.58274885),
        dec: Angle.Degrees(-55.87936029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223500"},
        {"Hipparcos Number", "HIP 117545"},
        {"Smithsonian Astrophysical Observation", "SAO 248035"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.56591792),
        dec: Angle.Degrees(-55.87599959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94368"},
        {"Cincinnati Publication", "Ci 20 1134"},
        {"Geneva Identification System", "GEN# +6.00107598"},
        {"Geneva Identification System 2", "GEN# -0.05607638"},
    },
    visualMagnitude: 11.31,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.10644051),
        dec: Angle.Degrees(-55.86837187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -278.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10614"},
        {"Hipparcos Number", "HIP 7950"},
        {"Smithsonian Astrophysical Observation", "SAO 232500"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.52670459),
        dec: Angle.Degrees(-55.86549036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112136"},
        {"Hipparcos Number", "HIP 63032"},
        {"Geneva Identification System", "GEN# +1.00112136"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.74336391),
        dec: Angle.Degrees(-55.86392022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22738"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.37945078),
        dec: Angle.Degrees(-55.86048727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201887"},
        {"Hipparcos Number", "HIP 104865"},
        {"Geneva Identification System", "GEN# +1.00201887"},
        {"Smithsonian Astrophysical Observation", "SAO 246921"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.64127068),
        dec: Angle.Degrees(-55.85973995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7489"},
        {"Hipparcos Number", "HIP 5762"},
    },
    visualMagnitude: 10.36,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.48525339),
        dec: Angle.Degrees(-55.85818558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174957"},
        {"Hipparcos Number", "HIP 92958"},
        {"Geneva Identification System", "GEN# +1.00174957"},
        {"Smithsonian Astrophysical Observation", "SAO 245815"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.07818736),
        dec: Angle.Degrees(-55.85764504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75152"},
        {"Hipparcos Number", "HIP 42989"},
        {"Geneva Identification System", "GEN# +1.00075152"},
        {"Renson", "Renson 21030"},
        {"Smithsonian Astrophysical Observation", "SAO 236251"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.43312870),
        dec: Angle.Degrees(-55.85500254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206521"},
        {"Hipparcos Number", "HIP 107327"},
        {"Smithsonian Astrophysical Observation", "SAO 247156"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.08509176),
        dec: Angle.Degrees(-55.85364372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143907"},
        {"Hipparcos Number", "HIP 78863"},
        {"Smithsonian Astrophysical Observation", "SAO 243318"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.47265140),
        dec: Angle.Degrees(-55.85350637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187136"},
        {"Hipparcos Number", "HIP 97694"},
        {"Smithsonian Astrophysical Observation", "SAO 246299"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.81355815),
        dec: Angle.Degrees(-55.85261558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152640"},
        {"Hipparcos Number", "HIP 82991"},
        {"Geneva Identification System", "GEN# +1.00152640"},
        {"Smithsonian Astrophysical Observation", "SAO 244297"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.39250529),
        dec: Angle.Degrees(-55.85177222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220985"},
        {"Hipparcos Number", "HIP 115890"},
        {"Smithsonian Astrophysical Observation", "SAO 247891"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.19242444),
        dec: Angle.Degrees(-55.85024199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133903"},
        {"Hipparcos Number", "HIP 74171"},
        {"Smithsonian Astrophysical Observation", "SAO 242261"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.32876751),
        dec: Angle.Degrees(-55.84712222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40293"},
        {"Hipparcos Number", "HIP 27923"},
        {"Geneva Identification System", "GEN# +1.00040293"},
        {"Smithsonian Astrophysical Observation", "SAO 234197"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.62948821),
        dec: Angle.Degrees(-55.84435638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 210.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150200"},
        {"Hipparcos Number", "HIP 81807"},
        {"Smithsonian Astrophysical Observation", "SAO 244080"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.63097953),
        dec: Angle.Degrees(-55.84400759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4084"},
        {"Hipparcos Number", "HIP 3353"},
        {"Geneva Identification System", "GEN# +1.00004084"},
        {"Smithsonian Astrophysical Observation", "SAO 232159"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.67717196),
        dec: Angle.Degrees(-55.84391205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104311"},
        {"Hipparcos Number", "HIP 58571"},
        {"Smithsonian Astrophysical Observation", "SAO 239578"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.16839211),
        dec: Angle.Degrees(-55.84319721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190507"},
        {"Hipparcos Number", "HIP 99173"},
        {"Geneva Identification System", "GEN# +1.00190507"},
        {"Smithsonian Astrophysical Observation", "SAO 246451"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.00969973),
        dec: Angle.Degrees(-55.84157986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61216"},
        {"Hipparcos Number", "HIP 36895"},
        {"Smithsonian Astrophysical Observation", "SAO 235326"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.78573964),
        dec: Angle.Degrees(-55.83504614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28247"},
        {"Hipparcos Number", "HIP 20566"},
        {"Fundamental Katalog 5th Edition", "FK5 4402"},
        {"Smithsonian Astrophysical Observation", "SAO 233507"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.08309149),
        dec: Angle.Degrees(-55.83397391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175166"},
        {"Hipparcos Number", "HIP 93055"},
        {"Geneva Identification System", "GEN# +1.00175166"},
        {"Smithsonian Astrophysical Observation", "SAO 245821"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.32433421),
        dec: Angle.Degrees(-55.83309810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145112"},
        {"Hipparcos Number", "HIP 79382"},
        {"Geneva Identification System", "GEN# +1.00145112"},
        {"Smithsonian Astrophysical Observation", "SAO 243424"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.01372605),
        dec: Angle.Degrees(-55.83303343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84330"},
        {"Hipparcos Number", "HIP 47625"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.67081012),
        dec: Angle.Degrees(-55.83216506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80353"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.04954274),
        dec: Angle.Degrees(-55.82919148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117620"},
        {"Hipparcos Number", "HIP 66075"},
        {"Geneva Identification System", "GEN# +1.00117620"},
        {"Smithsonian Astrophysical Observation", "SAO 240933"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.17720576),
        dec: Angle.Degrees(-55.82749273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139039"},
        {"Hipparcos Number", "HIP 76585"},
        {"Smithsonian Astrophysical Observation", "SAO 242783"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.61626599),
        dec: Angle.Degrees(-55.82635262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 300611"},
        {"Hipparcos Number", "HIP 50360"},
        {"Smithsonian Astrophysical Observation", "SAO 237866"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.24501952),
        dec: Angle.Degrees(-55.82344865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133367"},
        {"Hipparcos Number", "HIP 73920"},
        {"Smithsonian Astrophysical Observation", "SAO 242223"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.59376304),
        dec: Angle.Degrees(-55.82326091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108406"},
        {"Hipparcos Number", "HIP 60786"},
        {"Celescope Catalog", "CEL 4110"},
        {"Geneva Identification System", "GEN# +1.00108406"},
        {"Smithsonian Astrophysical Observation", "SAO 239963"},
    },
    visualMagnitude: 8.77,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.88040600),
        dec: Angle.Degrees(-55.82289426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20784"},
        {"Hipparcos Number", "HIP 15389"},
        {"Smithsonian Astrophysical Observation", "SAO 233070"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.60297643),
        dec: Angle.Degrees(-55.82252338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216034"},
        {"Hipparcos Number", "HIP 112787"},
        {"Smithsonian Astrophysical Observation", "SAO 247611"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.60629283),
        dec: Angle.Degrees(-55.82030516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102100"},
        {"Hipparcos Number", "HIP 57282"},
        {"Smithsonian Astrophysical Observation", "SAO 239342"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.18891371),
        dec: Angle.Degrees(-55.81940584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161031"},
        {"Hipparcos Number", "HIP 86978"},
        {"Smithsonian Astrophysical Observation", "SAO 245011"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.62036005),
        dec: Angle.Degrees(-55.81604401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125499"},
        {"Hipparcos Number", "HIP 70182"},
        {"Geneva Identification System", "GEN# +1.00125499"},
        {"Smithsonian Astrophysical Observation", "SAO 241661"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.38503328),
        dec: Angle.Degrees(-55.81591548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138095"},
        {"Hipparcos Number", "HIP 76089"},
        {"Smithsonian Astrophysical Observation", "SAO 242661"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.09881511),
        dec: Angle.Degrees(-55.81589065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80999"},
        {"Hipparcos Number", "HIP 45853"},
        {"Geneva Identification System", "GEN# +1.00080999"},
        {"Smithsonian Astrophysical Observation", "SAO 236871"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.22518175),
        dec: Angle.Degrees(-55.81209979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143817"},
        {"Hipparcos Number", "HIP 78807"},
        {"Geneva Identification System", "GEN# +1.00143817"},
        {"Smithsonian Astrophysical Observation", "SAO 243308"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.32629259),
        dec: Angle.Degrees(-55.81118258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217048"},
        {"Hipparcos Number", "HIP 113460"},
        {"Smithsonian Astrophysical Observation", "SAO 247663"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.66424412),
        dec: Angle.Degrees(-55.81082163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223100"},
        {"Hipparcos Number", "HIP 117276"},
        {"Smithsonian Astrophysical Observation", "SAO 248015"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.71332275),
        dec: Angle.Degrees(-55.80948917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76131"},
        {"Hipparcos Number", "HIP 43513"},
        {"Celescope Catalog", "CEL 3019"},
        {"Geneva Identification System", "GEN# +1.00076131"},
        {"Smithsonian Astrophysical Observation", "SAO 236340"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.93986813),
        dec: Angle.Degrees(-55.80886875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129367"},
        {"Hipparcos Number", "HIP 72042"},
        {"Smithsonian Astrophysical Observation", "SAO 241956"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.04397035),
        dec: Angle.Degrees(-55.80566224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37305"},
        {"Smithsonian Astrophysical Observation", "SAO 235400"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.87598044),
        dec: Angle.Degrees(-55.80483247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 302013"},
        {"Hipparcos Number", "HIP 57812"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.81371450),
        dec: Angle.Degrees(-55.80429049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104695"},
        {"Hipparcos Number", "HIP 58779"},
        {"Smithsonian Astrophysical Observation", "SAO 239615"},
    },
    visualMagnitude: 8.82,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.83242274),
        dec: Angle.Degrees(-55.80260731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78548"},
        {"Hipparcos Number", "HIP 44708"},
        {"Celescope Catalog", "CEL 3188"},
        {"Geneva Identification System", "GEN# +1.00078548"},
        {"Smithsonian Astrophysical Observation", "SAO 236611"},
        {"Wilson Evans Batten Catalogue", "WEB 8551"},
    },
    visualMagnitude: 6.10,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.64183582),
        dec: Angle.Degrees(-55.80242862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43222"},
        {"Hipparcos Number", "HIP 29400"},
        {"Smithsonian Astrophysical Observation", "SAO 234370"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.92989493),
        dec: Angle.Degrees(-55.80186566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115842"},
        {"Hipparcos Number", "HIP 65129"},
        {"Celescope Catalog", "CEL 4238"},
        {"Fundamental Katalog 5th Edition", "FK5 3065"},
        {"Geneva Identification System", "GEN# +1.00115842"},
        {"Smithsonian Astrophysical Observation", "SAO 240765"},
        {"Wilson Evans Batten Catalogue", "WEB 11501"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.20142983),
        dec: Angle.Degrees(-55.80069803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72696"},
        {"Hipparcos Number", "HIP 41831"},
        {"Smithsonian Astrophysical Observation", "SAO 236058"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.91918733),
        dec: Angle.Degrees(-55.80060380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199274"},
        {"Hipparcos Number", "HIP 103538"},
        {"Smithsonian Astrophysical Observation", "SAO 246811"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.63689661),
        dec: Angle.Degrees(-55.79779753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26045"},
        {"Hipparcos Number", "HIP 19020"},
        {"Smithsonian Astrophysical Observation", "SAO 233390"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.11875608),
        dec: Angle.Degrees(-55.79721058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133786"},
        {"Hipparcos Number", "HIP 74101"},
        {"Smithsonian Astrophysical Observation", "SAO 242250"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.16606955),
        dec: Angle.Degrees(-55.79485631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84837"},
        {"Hipparcos Number", "HIP 47936"},
        {"Smithsonian Astrophysical Observation", "SAO 237322"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.52539625),
        dec: Angle.Degrees(-55.79368799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184167"},
        {"Hipparcos Number", "HIP 96413"},
        {"Geneva Identification System", "GEN# +1.00184167"},
        {"Smithsonian Astrophysical Observation", "SAO 246177"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.02510606),
        dec: Angle.Degrees(-55.79300364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93339"},
        {"Hipparcos Number", "HIP 52611"},
        {"Geneva Identification System", "GEN# +1.00093339"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.37330713),
        dec: Angle.Degrees(-55.79143174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125287"},
        {"Hipparcos Number", "HIP 70058"},
        {"Geneva Identification System", "GEN# +1.00125287"},
        {"Smithsonian Astrophysical Observation", "SAO 241640"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.05929449),
        dec: Angle.Degrees(-55.79139186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112583"},
        {"Smithsonian Astrophysical Observation", "SAO 247588"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.03072476),
        dec: Angle.Degrees(-55.79113677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202776"},
        {"Hipparcos Number", "HIP 105347"},
        {"Smithsonian Astrophysical Observation", "SAO 246968"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.06922503),
        dec: Angle.Degrees(-55.79100140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161365"},
        {"Hipparcos Number", "HIP 87159"},
        {"Smithsonian Astrophysical Observation", "SAO 245037"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.10384200),
        dec: Angle.Degrees(-55.79088780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161255"},
        {"Hipparcos Number", "HIP 87083"},
        {"Smithsonian Astrophysical Observation", "SAO 245027"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.91535469),
        dec: Angle.Degrees(-55.79019643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106444"},
        {"Hipparcos Number", "HIP 59716"},
        {"Smithsonian Astrophysical Observation", "SAO 239787"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.71150016),
        dec: Angle.Degrees(-55.78984158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71368"},
        {"Hipparcos Number", "HIP 41196"},
        {"Smithsonian Astrophysical Observation", "SAO 235947"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.09376564),
        dec: Angle.Degrees(-55.78968366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 301011"},
        {"Henry Draper 2", "HD 93340"},
        {"Hipparcos Number", "HIP 52607"},
        {"Geneva Identification System", "GEN# +1.00093340"},
        {"Smithsonian Astrophysical Observation", "SAO 238438"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.36327861),
        dec: Angle.Degrees(-55.78732456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88890"},
        {"Hipparcos Number", "HIP 50090"},
        {"Smithsonian Astrophysical Observation", "SAO 237816"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.40969190),
        dec: Angle.Degrees(-55.78531270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59721"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.71810420),
        dec: Angle.Degrees(-55.78431496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95119"},
        {"Hipparcos Number", "HIP 53610"},
        {"Smithsonian Astrophysical Observation", "SAO 238639"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.52015706),
        dec: Angle.Degrees(-55.78371073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28545"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.38563132),
        dec: Angle.Degrees(-55.78366995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203148"},
        {"Hipparcos Number", "HIP 105547"},
        {"Smithsonian Astrophysical Observation", "SAO 247000"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.64915875),
        dec: Angle.Degrees(-55.78361066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4001"},
        {"Hipparcos Number", "HIP 3290"},
        {"Smithsonian Astrophysical Observation", "SAO 232154"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.49932390),
        dec: Angle.Degrees(-55.78205146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33438"},
        {"Hipparcos Number", "HIP 23812"},
        {"Smithsonian Astrophysical Observation", "SAO 233833"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.76614190),
        dec: Angle.Degrees(-55.78099891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116982"},
        {"Hipparcos Number", "HIP 65718"},
        {"Geneva Identification System", "GEN# +1.00116982"},
        {"Smithsonian Astrophysical Observation", "SAO 240868"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.09867101),
        dec: Angle.Degrees(-55.77986613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30734"},
        {"Hipparcos Number", "HIP 22232"},
        {"Smithsonian Astrophysical Observation", "SAO 233680"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.74029334),
        dec: Angle.Degrees(-55.77970563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207618"},
        {"Hipparcos Number", "HIP 107928"},
        {"Smithsonian Astrophysical Observation", "SAO 247209"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.99432804),
        dec: Angle.Degrees(-55.77907846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211398"},
        {"Hipparcos Number", "HIP 110095"},
        {"Smithsonian Astrophysical Observation", "SAO 247398"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.52715352),
        dec: Angle.Degrees(-55.77789380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143983"},
        {"Hipparcos Number", "HIP 78884"},
        {"Geneva Identification System", "GEN# +1.00143983"},
        {"Smithsonian Astrophysical Observation", "SAO 243322"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.55569805),
        dec: Angle.Degrees(-55.77726988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96136"},
        {"Hipparcos Number", "HIP 54118"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.10120347),
        dec: Angle.Degrees(-55.77653369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70163"},
        {"Hipparcos Number", "HIP 40637"},
        {"Smithsonian Astrophysical Observation", "SAO 235871"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.43727334),
        dec: Angle.Degrees(-55.77536487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74622"},
        {"Hipparcos Number", "HIP 42717"},
        {"Geneva Identification System", "GEN# +1.00074622"},
        {"Smithsonian Astrophysical Observation", "SAO 236206"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.58708068),
        dec: Angle.Degrees(-55.77465771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61142"},
        {"Hipparcos Number", "HIP 36872"},
        {"Geneva Identification System", "GEN# +1.00061142"},
        {"Smithsonian Astrophysical Observation", "SAO 235319"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.70544540),
        dec: Angle.Degrees(-55.77366095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107048"},
        {"Hipparcos Number", "HIP 60042"},
        {"Geneva Identification System", "GEN# +1.00107048"},
        {"Smithsonian Astrophysical Observation", "SAO 239834"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.70039942),
        dec: Angle.Degrees(-55.77197267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54794"},
        {"Hipparcos Number", "HIP 34334"},
        {"Geneva Identification System", "GEN# +1.00054794"},
        {"Smithsonian Astrophysical Observation", "SAO 234941"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.76055964),
        dec: Angle.Degrees(-55.77132352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58292"},
        {"Hipparcos Number", "HIP 35692"},
        {"Geneva Identification System", "GEN# +1.00058292"},
        {"Renson", "Renson 15910"},
        {"Smithsonian Astrophysical Observation", "SAO 235143"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.46434417),
        dec: Angle.Degrees(-55.77108529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81534"},
        {"Hipparcos Number", "HIP 46096"},
        {"Smithsonian Astrophysical Observation", "SAO 236933"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.00445972),
        dec: Angle.Degrees(-55.76882657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193134"},
        {"Hipparcos Number", "HIP 100368"},
        {"Smithsonian Astrophysical Observation", "SAO 246543"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.32368331),
        dec: Angle.Degrees(-55.76765220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87699"},
        {"Hipparcos Number", "HIP 49397"},
        {"Geneva Identification System", "GEN# +1.00087699"},
        {"Smithsonian Astrophysical Observation", "SAO 237678"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.26921898),
        dec: Angle.Degrees(-55.76746335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172447"},
        {"Hipparcos Number", "HIP 91837"},
        {"Smithsonian Astrophysical Observation", "SAO 245656"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.85606102),
        dec: Angle.Degrees(-55.76689215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189330"},
        {"Hipparcos Number", "HIP 98653"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.56489211),
        dec: Angle.Degrees(-55.76642554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176477"},
        {"Hipparcos Number", "HIP 93587"},
        {"Geneva Identification System", "GEN# +1.00176477"},
        {"Smithsonian Astrophysical Observation", "SAO 245888"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.89349224),
        dec: Angle.Degrees(-55.76538371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124812"},
        {"Hipparcos Number", "HIP 69825"},
        {"Geneva Identification System", "GEN# +1.00124812"},
        {"Smithsonian Astrophysical Observation", "SAO 241595"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.35633300),
        dec: Angle.Degrees(-55.76514737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211849"},
        {"Hipparcos Number", "HIP 110376"},
        {"Fundamental Katalog 5th Edition", "FK5 5973"},
        {"Geneva Identification System", "GEN# +1.00211849"},
        {"Smithsonian Astrophysical Observation", "SAO 247417"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.34460760),
        dec: Angle.Degrees(-55.76468042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3852"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.37265385),
        dec: Angle.Degrees(-55.76455397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98767"},
        {"Hipparcos Number", "HIP 55448"},
        {"Geneva Identification System", "GEN# +1.00098767"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.34136895),
        dec: Angle.Degrees(-55.76317479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158992"},
        {"Hipparcos Number", "HIP 86076"},
        {"Smithsonian Astrophysical Observation", "SAO 244871"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.87134907),
        dec: Angle.Degrees(-55.76306913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188320"},
        {"Hipparcos Number", "HIP 98211"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.36441532),
        dec: Angle.Degrees(-55.76094145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11574"},
        {"Hipparcos Number", "HIP 8711"},
        {"Geneva Identification System", "GEN# +1.00011574"},
        {"Smithsonian Astrophysical Observation", "SAO 232553"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.02585322),
        dec: Angle.Degrees(-55.75991466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174926"},
        {"Hipparcos Number", "HIP 92948"},
        {"Smithsonian Astrophysical Observation", "SAO 245814"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.05848713),
        dec: Angle.Degrees(-55.75932300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133383"},
        {"Hipparcos Number", "HIP 73933"},
        {"Smithsonian Astrophysical Observation", "SAO 242224"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.62710073),
        dec: Angle.Degrees(-55.75370247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 740"},
        {"Hipparcos Number", "HIP 927"},
        {"Geneva Identification System", "GEN# +1.00000740"},
        {"Smithsonian Astrophysical Observation", "SAO 231961"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.88096041),
        dec: Angle.Degrees(-55.74966102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119238"},
        {"Hipparcos Number", "HIP 66956"},
        {"Renson", "Renson 34420"},
        {"Smithsonian Astrophysical Observation", "SAO 241105"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.84713628),
        dec: Angle.Degrees(-55.74947388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11100"},
        {"Smithsonian Astrophysical Observation", "SAO 232738"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.72610864),
        dec: Angle.Degrees(-55.74887859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71549"},
        {"Hipparcos Number", "HIP 41285"},
        {"Renson", "Renson 19760"},
        {"Smithsonian Astrophysical Observation", "SAO 235963"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.34266285),
        dec: Angle.Degrees(-55.74866400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177368"},
        {"Hipparcos Number", "HIP 93922"},
        {"Smithsonian Astrophysical Observation", "SAO 245928"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.86760275),
        dec: Angle.Degrees(-55.74677578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145474"},
        {"Hipparcos Number", "HIP 79559"},
        {"Smithsonian Astrophysical Observation", "SAO 243469"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.51189753),
        dec: Angle.Degrees(-55.74629530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50548"},
        {"Hipparcos Number", "HIP 32820"},
        {"Smithsonian Astrophysical Observation", "SAO 234743"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.62754170),
        dec: Angle.Degrees(-55.74275855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121874"},
        {"Hipparcos Number", "HIP 68363"},
        {"Smithsonian Astrophysical Observation", "SAO 241358"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.90468237),
        dec: Angle.Degrees(-55.74011424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2531"},
        {"Hipparcos Number", "HIP 2251"},
        {"Smithsonian Astrophysical Observation", "SAO 232056"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.16979687),
        dec: Angle.Degrees(-55.73940953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100914"},
        {"Hipparcos Number", "HIP 56607"},
        {"Smithsonian Astrophysical Observation", "SAO 239214"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.09393773),
        dec: Angle.Degrees(-55.73912170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121040"},
        {"Hipparcos Number", "HIP 67919"},
        {"Geneva Identification System", "GEN# +1.00121040"},
        {"Smithsonian Astrophysical Observation", "SAO 241277"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.65975832),
        dec: Angle.Degrees(-55.73827545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205935"},
        {"Hipparcos Number", "HIP 107030"},
        {"Geneva Identification System", "GEN# +1.00205935"},
        {"Smithsonian Astrophysical Observation", "SAO 247132"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.14038307),
        dec: Angle.Degrees(-55.73800029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97828"},
        {"Hipparcos Number", "HIP 54905"},
        {"Smithsonian Astrophysical Observation", "SAO 238892"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.63685071),
        dec: Angle.Degrees(-55.73795135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108374"},
        {"Hipparcos Number", "HIP 60761"},
        {"Celescope Catalog", "CEL 4108"},
        {"Geneva Identification System", "GEN# +1.00108374J"},
        {"Smithsonian Astrophysical Observation", "SAO 239954"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.81886106),
        dec: Angle.Degrees(-55.73494763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56935"},
        {"Hipparcos Number", "HIP 35154"},
        {"Smithsonian Astrophysical Observation", "SAO 235058"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.98912477),
        dec: Angle.Degrees(-55.73329191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92368"},
        {"Hipparcos Number", "HIP 52090"},
        {"Geneva Identification System", "GEN# +1.00092368"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.65902870),
        dec: Angle.Degrees(-55.73297247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134672"},
        {"Hipparcos Number", "HIP 74501"},
        {"Geneva Identification System", "GEN# +1.00134672"},
        {"Smithsonian Astrophysical Observation", "SAO 242323"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.37183030),
        dec: Angle.Degrees(-55.73176277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131325"},
        {"Hipparcos Number", "HIP 73000"},
        {"Geneva Identification System", "GEN# +1.00131325"},
        {"Smithsonian Astrophysical Observation", "SAO 242110"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.78722168),
        dec: Angle.Degrees(-55.73167185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52603"},
        {"Hipparcos Number", "HIP 33588"},
        {"Geneva Identification System", "GEN# +1.00052603"},
        {"Smithsonian Astrophysical Observation", "SAO 234826"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.66587384),
        dec: Angle.Degrees(-55.72892565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105513"},
        {"Hipparcos Number", "HIP 59231"},
        {"Geneva Identification System", "GEN# +1.00105513"},
        {"Smithsonian Astrophysical Observation", "SAO 239697"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.22619623),
        dec: Angle.Degrees(-55.72823410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55432"},
        {"Hipparcos Number", "HIP 34584"},
        {"Smithsonian Astrophysical Observation", "SAO 234978"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.43749923),
        dec: Angle.Degrees(-55.72584926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45614"},
        {"Hipparcos Number", "HIP 30533"},
        {"Geneva Identification System", "GEN# +1.00045614"},
        {"Smithsonian Astrophysical Observation", "SAO 234493"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.27434648),
        dec: Angle.Degrees(-55.72543808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42719"},
        {"Smithsonian Astrophysical Observation", "SAO 236207"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.59225763),
        dec: Angle.Degrees(-55.72492241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38829"},
        {"Hipparcos Number", "HIP 27139"},
        {"Smithsonian Astrophysical Observation", "SAO 234121"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.31293422),
        dec: Angle.Degrees(-55.72469958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101411"},
        {"Hipparcos Number", "HIP 56896"},
        {"Geneva Identification System", "GEN# +1.00101411"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.95729112),
        dec: Angle.Degrees(-55.72082955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177693"},
        {"Hipparcos Number", "HIP 94054"},
        {"Geneva Identification System", "GEN# +1.00177693"},
        {"Smithsonian Astrophysical Observation", "SAO 245937"},
        {"Wilson Evans Batten Catalogue", "WEB 16373"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.21777649),
        dec: Angle.Degrees(-55.72014436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150577"},
        {"Hipparcos Number", "HIP 81997"},
        {"Smithsonian Astrophysical Observation", "SAO 244108"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.26029912),
        dec: Angle.Degrees(-55.71902088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154251"},
        {"Hipparcos Number", "HIP 83785"},
        {"Smithsonian Astrophysical Observation", "SAO 244445"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.85875207),
        dec: Angle.Degrees(-55.71741374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162730"},
        {"Hipparcos Number", "HIP 87765"},
        {"Smithsonian Astrophysical Observation", "SAO 245118"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.92564208),
        dec: Angle.Degrees(-55.71672814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77423"},
        {"Hipparcos Number", "HIP 44186"},
        {"Geneva Identification System", "GEN# +1.00077423"},
        {"Smithsonian Astrophysical Observation", "SAO 236485"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.01753319),
        dec: Angle.Degrees(-55.71040822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106615"},
        {"Hipparcos Number", "HIP 59813"},
        {"Smithsonian Astrophysical Observation", "SAO 239797"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.98628048),
        dec: Angle.Degrees(-55.70872061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34971"},
        {"Hipparcos Number", "HIP 24717"},
        {"Smithsonian Astrophysical Observation", "SAO 233919"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.51868294),
        dec: Angle.Degrees(-55.70724349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91268"},
        {"Hipparcos Number", "HIP 51484"},
        {"Geneva Identification System", "GEN# +1.00091268"},
        {"Smithsonian Astrophysical Observation", "SAO 238141"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.72970632),
        dec: Angle.Degrees(-55.70636759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42490"},
        {"Hipparcos Number", "HIP 29039"},
        {"Geneva Identification System", "GEN# +1.00042490"},
        {"Smithsonian Astrophysical Observation", "SAO 234327"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.89549224),
        dec: Angle.Degrees(-55.70549125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14574"},
    },
    visualMagnitude: 11.72,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.03707395),
        dec: Angle.Degrees(-55.70529495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 352.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128505"},
        {"Hipparcos Number", "HIP 71638"},
        {"Smithsonian Astrophysical Observation", "SAO 241878"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.79638256),
        dec: Angle.Degrees(-55.70297948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71636",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71636"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.79037004),
        dec: Angle.Degrees(-55.70261067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64624"},
        {"Hipparcos Number", "HIP 38387"},
        {"Smithsonian Astrophysical Observation", "SAO 235572"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.95227196),
        dec: Angle.Degrees(-55.70254660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217795"},
        {"Hipparcos Number", "HIP 113900"},
        {"Geneva Identification System", "GEN# +1.00217795"},
        {"Smithsonian Astrophysical Observation", "SAO 247707"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.99678707),
        dec: Angle.Degrees(-55.69773080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31407"},
        {"Hipparcos Number", "HIP 22663"},
        {"Smithsonian Astrophysical Observation", "SAO 233719"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.11767788),
        dec: Angle.Degrees(-55.69706825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1043"},
        {"Hipparcos Number", "HIP 1159"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.61544188),
        dec: Angle.Degrees(-55.69674944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224271"},
        {"Hipparcos Number", "HIP 118038"},
        {"Smithsonian Astrophysical Observation", "SAO 248068"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.14391849),
        dec: Angle.Degrees(-55.69582884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38683"},
        {"Hipparcos Number", "HIP 27054"},
        {"Geneva Identification System", "GEN# +1.00038683"},
        {"Smithsonian Astrophysical Observation", "SAO 234112"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.05678739),
        dec: Angle.Degrees(-55.69560188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57342"},
    },
    visualMagnitude: 10.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.35845539),
        dec: Angle.Degrees(-55.69191178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -318.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165256"},
        {"Hipparcos Number", "HIP 88849"},
        {"Smithsonian Astrophysical Observation", "SAO 245258"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.06741605),
        dec: Angle.Degrees(-55.69122197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208198"},
        {"Hipparcos Number", "HIP 108297"},
        {"Smithsonian Astrophysical Observation", "SAO 247233"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.10241195),
        dec: Angle.Degrees(-55.69119099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89105"},
        {"Hipparcos Number", "HIP 50233"},
        {"Celescope Catalog", "CEL 3482"},
        {"Geneva Identification System", "GEN# +1.00089105"},
        {"Smithsonian Astrophysical Observation", "SAO 237835"},
    },
    visualMagnitude: 7.92,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.82408378),
        dec: Angle.Degrees(-55.68946578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8964"},
        {"Hipparcos Number", "HIP 6770"},
        {"Smithsonian Astrophysical Observation", "SAO 232427"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.76876681),
        dec: Angle.Degrees(-55.68610223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160737"},
        {"Hipparcos Number", "HIP 86854"},
        {"Smithsonian Astrophysical Observation", "SAO 244988"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.18875793),
        dec: Angle.Degrees(-55.68460953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112291"},
        {"Hipparcos Number", "HIP 63150"},
        {"Smithsonian Astrophysical Observation", "SAO 240389"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.09390898),
        dec: Angle.Degrees(-55.68300970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89924"},
        {"Hipparcos Number", "HIP 50707"},
        {"Smithsonian Astrophysical Observation", "SAO 237970"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.31299375),
        dec: Angle.Degrees(-55.68251390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63652"},
    },
    visualMagnitude: 10.43,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.68553768),
        dec: Angle.Degrees(-55.67981073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216594"},
        {"Hipparcos Number", "HIP 113178"},
        {"Smithsonian Astrophysical Observation", "SAO 247645"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.77495000),
        dec: Angle.Degrees(-55.67890966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73860"},
        {"Geneva Identification System", "GEN# +2.58230002"},
        {"New General Catalogue", "NGC 5823 2"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.42322982),
        dec: Angle.Degrees(-55.67741460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113197"},
        {"Hipparcos Number", "HIP 63655"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.69103138),
        dec: Angle.Degrees(-55.67528836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30163"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.20152611),
        dec: Angle.Degrees(-55.67517578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23332"},
        {"Hipparcos Number", "HIP 17246"},
        {"Geneva Identification System", "GEN# +1.00023332"},
        {"Smithsonian Astrophysical Observation", "SAO 233228"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.40240181),
        dec: Angle.Degrees(-55.67491423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166117"},
        {"Hipparcos Number", "HIP 89214"},
        {"Smithsonian Astrophysical Observation", "SAO 245310"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.09046544),
        dec: Angle.Degrees(-55.67283780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112646"},
        {"Hipparcos Number", "HIP 63353"},
        {"Geneva Identification System", "GEN# +1.00112646"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.72916307),
        dec: Angle.Degrees(-55.67261528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120644"},
        {"Hipparcos Number", "HIP 67710"},
        {"Smithsonian Astrophysical Observation", "SAO 241240"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.06660552),
        dec: Angle.Degrees(-55.67239102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32823"},
        {"Hipparcos Number", "HIP 23465"},
        {"Smithsonian Astrophysical Observation", "SAO 233799"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.67421102),
        dec: Angle.Degrees(-55.67124445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65076"},
        {"Hipparcos Number", "HIP 38583"},
        {"Smithsonian Astrophysical Observation", "SAO 235602"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.50788634),
        dec: Angle.Degrees(-55.66813168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52300"},
        {"Hipparcos Number", "HIP 33473"},
        {"Smithsonian Astrophysical Observation", "SAO 234813"},
    },
    visualMagnitude: 7.37,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.36836948),
        dec: Angle.Degrees(-55.66777239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95447"},
        {"Hipparcos Number", "HIP 53769"},
        {"Geneva Identification System", "GEN# +1.00095447"},
        {"Smithsonian Astrophysical Observation", "SAO 238676"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.03258301),
        dec: Angle.Degrees(-55.66677147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12816"},
        {"Hipparcos Number", "HIP 9638"},
        {"Geneva Identification System", "GEN# +1.00012816"},
        {"Smithsonian Astrophysical Observation", "SAO 232616"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.97314189),
        dec: Angle.Degrees(-55.66142215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102322"},
        {"Hipparcos Number", "HIP 57427"},
        {"Geneva Identification System", "GEN# +1.00102322"},
        {"Smithsonian Astrophysical Observation", "SAO 239365"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.59662489),
        dec: Angle.Degrees(-55.66078408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3517"},
        {"Hipparcos Number", "HIP 2960"},
        {"Geneva Identification System", "GEN# +1.00003517"},
        {"Smithsonian Astrophysical Observation", "SAO 232118"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.40395096),
        dec: Angle.Degrees(-55.66016383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104345"},
        {"Hipparcos Number", "HIP 58592"},
        {"Smithsonian Astrophysical Observation", "SAO 239582"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.22234560),
        dec: Angle.Degrees(-55.65741981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206998"},
        {"Hipparcos Number", "HIP 107607"},
        {"Geneva Identification System", "GEN# +1.00206998"},
        {"Smithsonian Astrophysical Observation", "SAO 247181"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.93323768),
        dec: Angle.Degrees(-55.65415992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109965"},
        {"Hipparcos Number", "HIP 61753"},
        {"Smithsonian Astrophysical Observation", "SAO 240120"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.83863057),
        dec: Angle.Degrees(-55.65402282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62377"},
        {"Hipparcos Number", "HIP 37396"},
        {"Smithsonian Astrophysical Observation", "SAO 235411"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.17037099),
        dec: Angle.Degrees(-55.65155405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66220",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66220"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.58448972),
        dec: Angle.Degrees(-55.65023723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77655"},
        {"Hipparcos Number", "HIP 44314"},
        {"Celescope Catalog", "CEL 3151"},
        {"Geneva Identification System", "GEN# +1.00077655J"},
        {"Smithsonian Astrophysical Observation", "SAO 236516"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.37769571),
        dec: Angle.Degrees(-55.64937324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3510"},
        {"Hipparcos Number", "HIP 2949"},
        {"Smithsonian Astrophysical Observation", "SAO 232116"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.36884474),
        dec: Angle.Degrees(-55.64882531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46894"},
        {"Hipparcos Number", "HIP 31179"},
        {"Geneva Identification System", "GEN# +1.00046894"},
        {"Smithsonian Astrophysical Observation", "SAO 234566"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.14246961),
        dec: Angle.Degrees(-55.64838466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80229"},
        {"Hipparcos Number", "HIP 45508"},
        {"Geneva Identification System", "GEN# +1.00080229"},
        {"Smithsonian Astrophysical Observation", "SAO 236790"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.10917540),
        dec: Angle.Degrees(-55.64681677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27319"},
        {"Hipparcos Number", "HIP 19880"},
        {"Smithsonian Astrophysical Observation", "SAO 233458"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.96236050),
        dec: Angle.Degrees(-55.64628483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64346"},
        {"Hipparcos Number", "HIP 38275"},
        {"Smithsonian Astrophysical Observation", "SAO 235557"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.63056586),
        dec: Angle.Degrees(-55.64161266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79946"},
        {"Hipparcos Number", "HIP 45372"},
        {"Celescope Catalog", "CEL 3240"},
        {"Geneva Identification System", "GEN# +1.00079946"},
        {"Smithsonian Astrophysical Observation", "SAO 236758"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.69778933),
        dec: Angle.Degrees(-55.64093606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2598"},
        {"Hipparcos Number", "HIP 2279"},
        {"Smithsonian Astrophysical Observation", "SAO 232063"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.28363154),
        dec: Angle.Degrees(-55.63924741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112363"},
        {"Hipparcos Number", "HIP 63194"},
        {"Smithsonian Astrophysical Observation", "SAO 240401"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.19752344),
        dec: Angle.Degrees(-55.63771240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82597"},
        {"Hipparcos Number", "HIP 46674"},
        {"Smithsonian Astrophysical Observation", "SAO 237064"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.73625250),
        dec: Angle.Degrees(-55.63620987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7608"},
        {"Hipparcos Number", "HIP 5843"},
        {"Smithsonian Astrophysical Observation", "SAO 232356"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.75189809),
        dec: Angle.Degrees(-55.63260893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143086"},
        {"Hipparcos Number", "HIP 78463"},
        {"Smithsonian Astrophysical Observation", "SAO 243244"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.26570540),
        dec: Angle.Degrees(-55.63155557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84572"},
        {"Hipparcos Number", "HIP 47770"},
        {"Smithsonian Astrophysical Observation", "SAO 237286"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.09037748),
        dec: Angle.Degrees(-55.63133944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160519"},
        {"Hipparcos Number", "HIP 86746"},
        {"Geneva Identification System", "GEN# +1.00160519"},
        {"Smithsonian Astrophysical Observation", "SAO 244969"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.88469780),
        dec: Angle.Degrees(-55.62846789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137522"},
        {"Hipparcos Number", "HIP 75791"},
        {"Geneva Identification System", "GEN# +1.00137522"},
        {"Smithsonian Astrophysical Observation", "SAO 242583"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.24797508),
        dec: Angle.Degrees(-55.62733037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73732"},
        {"New General Catalogue", "NGC 5823 159"},
    },
    visualMagnitude: 11.28,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.07729846),
        dec: Angle.Degrees(-55.62399148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98192"},
        {"Hipparcos Number", "HIP 55113"},
        {"Smithsonian Astrophysical Observation", "SAO 238932"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.26177039),
        dec: Angle.Degrees(-55.62258382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4546"},
        {"Hipparcos Number", "HIP 3654"},
        {"Smithsonian Astrophysical Observation", "SAO 232182"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.69623357),
        dec: Angle.Degrees(-55.62086470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94645"},
        {"Hipparcos Number", "HIP 53347"},
        {"Smithsonian Astrophysical Observation", "SAO 238589"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.65469316),
        dec: Angle.Degrees(-55.61898042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184957"},
        {"Hipparcos Number", "HIP 96731"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.95938902),
        dec: Angle.Degrees(-55.61868521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135472"},
        {"Hipparcos Number", "HIP 74829"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.39255986),
        dec: Angle.Degrees(-55.61832291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77261"},
        {"Hipparcos Number", "HIP 44122"},
        {"Smithsonian Astrophysical Observation", "SAO 236467"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.79020346),
        dec: Angle.Degrees(-55.61800977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31334"},
        {"Hipparcos Number", "HIP 22599"},
        {"Smithsonian Astrophysical Observation", "SAO 233717"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.93287958),
        dec: Angle.Degrees(-55.61731206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15060"},
        {"Hipparcos Number", "HIP 11160"},
        {"Geneva Identification System", "GEN# +1.00015060"},
        {"Smithsonian Astrophysical Observation", "SAO 232746"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.89791377),
        dec: Angle.Degrees(-55.61696852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158428"},
        {"Hipparcos Number", "HIP 85835"},
        {"Smithsonian Astrophysical Observation", "SAO 244820"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.09342247),
        dec: Angle.Degrees(-55.61650270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79419"},
        {"Hipparcos Number", "HIP 45136"},
        {"Smithsonian Astrophysical Observation", "SAO 236708"},
    },
    visualMagnitude: 9.08,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.95050078),
        dec: Angle.Degrees(-55.61517573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120056"},
        {"Hipparcos Number", "HIP 67371"},
        {"Geneva Identification System", "GEN# +1.00120056"},
        {"Smithsonian Astrophysical Observation", "SAO 241184"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.13244869),
        dec: Angle.Degrees(-55.61469306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39566"},
        {"Hipparcos Number", "HIP 27556"},
        {"Smithsonian Astrophysical Observation", "SAO 234157"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.54054869),
        dec: Angle.Degrees(-55.61435500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101374"},
        {"Hipparcos Number", "HIP 56877"},
        {"Smithsonian Astrophysical Observation", "SAO 239268"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.90368546),
        dec: Angle.Degrees(-55.61309941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32012"},
        {"Hipparcos Number", "HIP 23025"},
        {"Smithsonian Astrophysical Observation", "SAO 233756"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.27480508),
        dec: Angle.Degrees(-55.61241452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173343"},
        {"Hipparcos Number", "HIP 92239"},
        {"Smithsonian Astrophysical Observation", "SAO 245711"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.98061840),
        dec: Angle.Degrees(-55.61190573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113686"},
        {"Hipparcos Number", "HIP 63943"},
        {"Smithsonian Astrophysical Observation", "SAO 240544"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.56487627),
        dec: Angle.Degrees(-55.61166664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11528"},
        {"Smithsonian Astrophysical Observation", "SAO 232786"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.16537777),
        dec: Angle.Degrees(-55.61120946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135257"},
        {"Hipparcos Number", "HIP 74742"},
        {"Smithsonian Astrophysical Observation", "SAO 242370"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.13032006),
        dec: Angle.Degrees(-55.61081079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31862"},
        {"Geneva Identification System", "GEN# -0.05501035"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.90853351),
        dec: Angle.Degrees(-55.60970381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -394.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77869"},
        {"Hipparcos Number", "HIP 44411"},
        {"Smithsonian Astrophysical Observation", "SAO 236535"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.69803998),
        dec: Angle.Degrees(-55.60917055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68875",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68875"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.54989481),
        dec: Angle.Degrees(-55.60756836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129578"},
        {"Hipparcos Number", "HIP 72133"},
        {"Geneva Identification System", "GEN# +1.00129578"},
        {"Smithsonian Astrophysical Observation", "SAO 241972"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.32843877),
        dec: Angle.Degrees(-55.60670032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112676",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112676"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.26387812),
        dec: Angle.Degrees(-55.60631321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196623"},
        {"Hipparcos Number", "HIP 102069"},
        {"Smithsonian Astrophysical Observation", "SAO 246689"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.27498443),
        dec: Angle.Degrees(-55.60529710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128135"},
        {"Hipparcos Number", "HIP 71493"},
        {"Smithsonian Astrophysical Observation", "SAO 241845"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.30074343),
        dec: Angle.Degrees(-55.60361090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92449"},
        {"Hipparcos Number", "HIP 52154"},
        {"Fundamental Katalog 5th Edition", "FK5 402"},
        {"Geneva Identification System", "GEN# +1.00092449A"},
        {"Smithsonian Astrophysical Observation", "SAO 238309"},
        {"Wilson Evans Batten Catalogue", "WEB 9505"},
    },
    visualMagnitude: 4.29,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.82671887),
        dec: Angle.Degrees(-55.60327905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129557"},
        {"Hipparcos Number", "HIP 72121"},
        {"Geneva Identification System", "GEN# +1.00129557"},
        {"Smithsonian Astrophysical Observation", "SAO 241971"},
        {"Wilson Evans Batten Catalogue", "WEB 12407"},
    },
    visualMagnitude: 6.10,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.29569214),
        dec: Angle.Degrees(-55.60162158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25861"},
        {"Hipparcos Number", "HIP 18889"},
        {"Smithsonian Astrophysical Observation", "SAO 233377"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.74419210),
        dec: Angle.Degrees(-55.60157083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29187"},
        {"Hipparcos Number", "HIP 21200"},
        {"Geneva Identification System", "GEN# +1.00029187"},
        {"Smithsonian Astrophysical Observation", "SAO 233559"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.18019138),
        dec: Angle.Degrees(-55.59708505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5394"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.25852764),
        dec: Angle.Degrees(-55.59117282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35740"},
        {"Hipparcos Number", "HIP 25219"},
        {"Smithsonian Astrophysical Observation", "SAO 233959"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.90911097),
        dec: Angle.Degrees(-55.59086867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55598"},
        {"Hipparcos Number", "HIP 34631"},
        {"Smithsonian Astrophysical Observation", "SAO 234991"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.60195006),
        dec: Angle.Degrees(-55.58769155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198608"},
        {"Hipparcos Number", "HIP 103140"},
        {"Smithsonian Astrophysical Observation", "SAO 246776"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.46588477),
        dec: Angle.Degrees(-55.58735934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9209"},
        {"Hipparcos Number", "HIP 6940"},
        {"Smithsonian Astrophysical Observation", "SAO 232434"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.35076390),
        dec: Angle.Degrees(-55.58725295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211639"},
        {"Hipparcos Number", "HIP 110234"},
        {"Smithsonian Astrophysical Observation", "SAO 247405"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.94623000),
        dec: Angle.Degrees(-55.58553998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141016"},
        {"Hipparcos Number", "HIP 77495"},
        {"Smithsonian Astrophysical Observation", "SAO 243009"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.35121413),
        dec: Angle.Degrees(-55.58528256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77465"},
        {"Hipparcos Number", "HIP 44207"},
        {"Geneva Identification System", "GEN# +1.00077465"},
        {"Smithsonian Astrophysical Observation", "SAO 236491"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.07409784),
        dec: Angle.Degrees(-55.58411746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188923"},
        {"Hipparcos Number", "HIP 98484"},
        {"Smithsonian Astrophysical Observation", "SAO 246381"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.10883282),
        dec: Angle.Degrees(-55.58310103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170928"},
        {"Hipparcos Number", "HIP 91116"},
        {"Fundamental Katalog 5th Edition", "FK5 5633"},
        {"Smithsonian Astrophysical Observation", "SAO 245564"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.78892199),
        dec: Angle.Degrees(-55.58256470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38873"},
        {"Hipparcos Number", "HIP 27170"},
        {"Geneva Identification System", "GEN# +1.00038873"},
        {"Smithsonian Astrophysical Observation", "SAO 234123"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.37753847),
        dec: Angle.Degrees(-55.57799738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58540"},
        {"Hipparcos Number", "HIP 35790"},
        {"Smithsonian Astrophysical Observation", "SAO 235155"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.73763974),
        dec: Angle.Degrees(-55.57743788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122896"},
        {"Hipparcos Number", "HIP 68866"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.53297381),
        dec: Angle.Degrees(-55.57672300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101584"},
        {"Hipparcos Number", "HIP 56992"},
        {"Geneva Identification System", "GEN# +1.00101584"},
        {"Smithsonian Astrophysical Observation", "SAO 239288"},
        {"Wilson Evans Batten Catalogue", "WEB 10259"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.24505583),
        dec: Angle.Degrees(-55.57383666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111064"},
        {"Hipparcos Number", "HIP 62396"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.81056198),
        dec: Angle.Degrees(-55.57327792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90028",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90028"},
        {"Smithsonian Astrophysical Observation", "SAO 245427"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.54176066),
        dec: Angle.Degrees(-55.57285047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157022"},
        {"Hipparcos Number", "HIP 85142"},
        {"Smithsonian Astrophysical Observation", "SAO 244699"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.99227410),
        dec: Angle.Degrees(-55.56974228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79846"},
        {"Hipparcos Number", "HIP 45328"},
        {"Fundamental Katalog 5th Edition", "FK5 2736"},
        {"Geneva Identification System", "GEN# +1.00079846"},
        {"Smithsonian Astrophysical Observation", "SAO 236749"},
        {"Wilson Evans Batten Catalogue", "WEB 8634"},
    },
    visualMagnitude: 5.26,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.57510250),
        dec: Angle.Degrees(-55.56970109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58476"},
        {"Hipparcos Number", "HIP 35768"},
        {"Smithsonian Astrophysical Observation", "SAO 235153"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.66968563),
        dec: Angle.Degrees(-55.56908512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34327"},
        {"Hipparcos Number", "HIP 24344"},
        {"Geneva Identification System", "GEN# +1.00034327"},
        {"Smithsonian Astrophysical Observation", "SAO 233880"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.36604504),
        dec: Angle.Degrees(-55.56865331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82645"},
        {"Hipparcos Number", "HIP 46699"},
        {"Geneva Identification System", "GEN# +1.00082645"},
        {"Smithsonian Astrophysical Observation", "SAO 237066"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.80460152),
        dec: Angle.Degrees(-55.56677273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18795"},
        {"Hipparcos Number", "HIP 13909"},
        {"Smithsonian Astrophysical Observation", "SAO 232958"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.78444733),
        dec: Angle.Degrees(-55.56526173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168292"},
        {"Hipparcos Number", "HIP 90026"},
        {"Smithsonian Astrophysical Observation", "SAO 245426"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.54095054),
        dec: Angle.Degrees(-55.56420505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94844"},
        {"Hipparcos Number", "HIP 53447"},
        {"Geneva Identification System", "GEN# +1.00094844"},
        {"Smithsonian Astrophysical Observation", "SAO 238606"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.00329115),
        dec: Angle.Degrees(-55.56346185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142959"},
        {"Hipparcos Number", "HIP 78393"},
        {"Geneva Identification System", "GEN# +1.00142959"},
        {"Smithsonian Astrophysical Observation", "SAO 243226"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.06578069),
        dec: Angle.Degrees(-55.56323026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112268"},
        {"Hipparcos Number", "HIP 63145"},
        {"Smithsonian Astrophysical Observation", "SAO 240388"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.07764606),
        dec: Angle.Degrees(-55.56105353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80157"},
        {"Hipparcos Number", "HIP 45478"},
        {"Geneva Identification System", "GEN# +1.00080157"},
        {"Smithsonian Astrophysical Observation", "SAO 236783"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.00545747),
        dec: Angle.Degrees(-55.55834270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150156"},
        {"Hipparcos Number", "HIP 81780"},
        {"Smithsonian Astrophysical Observation", "SAO 244074"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.55821139),
        dec: Angle.Degrees(-55.55783781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219535"},
        {"Hipparcos Number", "HIP 114961"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.26916723),
        dec: Angle.Degrees(-55.55783612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93791"},
    },
    visualMagnitude: 11.69,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.51397881),
        dec: Angle.Degrees(-55.55701989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141581"},
        {"Hipparcos Number", "HIP 77753"},
        {"Smithsonian Astrophysical Observation", "SAO 243063"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.14679072),
        dec: Angle.Degrees(-55.55571527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98132"},
        {"Hipparcos Number", "HIP 55080"},
        {"Smithsonian Astrophysical Observation", "SAO 238924"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.14721965),
        dec: Angle.Degrees(-55.55533473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120909"},
        {"Hipparcos Number", "HIP 67847"},
        {"Geneva Identification System", "GEN# +1.00120909"},
        {"Smithsonian Astrophysical Observation", "SAO 241264"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.45982633),
        dec: Angle.Degrees(-55.55504709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220330"},
        {"Hipparcos Number", "HIP 115462"},
        {"Smithsonian Astrophysical Observation", "SAO 247851"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.84202613),
        dec: Angle.Degrees(-55.55337380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146964"},
        {"Hipparcos Number", "HIP 80167"},
        {"Smithsonian Astrophysical Observation", "SAO 243688"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.47742904),
        dec: Angle.Degrees(-55.55152665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214603"},
        {"Hipparcos Number", "HIP 111936"},
        {"Smithsonian Astrophysical Observation", "SAO 247541"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.11240865),
        dec: Angle.Degrees(-55.55122540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63010"},
        {"Hipparcos Number", "HIP 37672"},
        {"Smithsonian Astrophysical Observation", "SAO 235456"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.94193548),
        dec: Angle.Degrees(-55.54933617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89077"},
        {"Hipparcos Number", "HIP 50221"},
        {"Smithsonian Astrophysical Observation", "SAO 237832"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.78132334),
        dec: Angle.Degrees(-55.54929114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218228"},
        {"Hipparcos Number", "HIP 114151"},
        {"Smithsonian Astrophysical Observation", "SAO 247737"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.76965784),
        dec: Angle.Degrees(-55.54870812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170132"},
        {"Hipparcos Number", "HIP 90753"},
        {"Smithsonian Astrophysical Observation", "SAO 245518"},
    },
    visualMagnitude: 9.35,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.74811901),
        dec: Angle.Degrees(-55.54858827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23137"},
        {"Hipparcos Number", "HIP 17122"},
        {"Renson", "Renson 5870"},
        {"Smithsonian Astrophysical Observation", "SAO 233215"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.00571637),
        dec: Angle.Degrees(-55.54772301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195541"},
        {"Hipparcos Number", "HIP 101531"},
        {"Smithsonian Astrophysical Observation", "SAO 246638"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.64083583),
        dec: Angle.Degrees(-55.54433110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203335"},
        {"Hipparcos Number", "HIP 105629"},
        {"Geneva Identification System", "GEN# +1.00203335"},
        {"Smithsonian Astrophysical Observation", "SAO 247006"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.91597874),
        dec: Angle.Degrees(-55.54267705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120738"},
        {"Hipparcos Number", "HIP 67746"},
        {"Geneva Identification System", "GEN# +1.00120738"},
        {"Smithsonian Astrophysical Observation", "SAO 241248"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.17891557),
        dec: Angle.Degrees(-55.54104260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145361"},
        {"Hipparcos Number", "HIP 79497"},
        {"Geneva Identification System", "GEN# +1.00145361"},
        {"Smithsonian Astrophysical Observation", "SAO 243449"},
        {"Wilson Evans Batten Catalogue", "WEB 13454"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.34499914),
        dec: Angle.Degrees(-55.54084556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66768"},
        {"Hipparcos Number", "HIP 39310"},
        {"Celescope Catalog", "CEL 2151"},
        {"Geneva Identification System", "GEN# +1.00066768"},
        {"Smithsonian Astrophysical Observation", "SAO 235698"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.56471815),
        dec: Angle.Degrees(-55.54060541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166557"},
        {"Hipparcos Number", "HIP 89379"},
        {"Smithsonian Astrophysical Observation", "SAO 245330"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.59637281),
        dec: Angle.Degrees(-55.54012218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111454"},
        {"Hipparcos Number", "HIP 62629"},
        {"Smithsonian Astrophysical Observation", "SAO 240296"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.49663738),
        dec: Angle.Degrees(-55.54011764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49877"},
        {"Hipparcos Number", "HIP 32531"},
        {"Fundamental Katalog 5th Edition", "FK5 2524"},
        {"Geneva Identification System", "GEN# +1.00049877"},
        {"Smithsonian Astrophysical Observation", "SAO 234710"},
    },
    visualMagnitude: 5.60,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.82795802),
        dec: Angle.Degrees(-55.54004918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79360"},
    },
    visualMagnitude: 11.15,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.95727027),
        dec: Angle.Degrees(-55.53665617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181624"},
        {"Hipparcos Number", "HIP 95378"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.04148897),
        dec: Angle.Degrees(-55.53415487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104581"},
        {"Hipparcos Number", "HIP 58714"},
        {"Geneva Identification System", "GEN# +1.00104581"},
        {"Smithsonian Astrophysical Observation", "SAO 239608"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.64144037),
        dec: Angle.Degrees(-55.53392695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103936"},
        {"Hipparcos Number", "HIP 58370"},
        {"Smithsonian Astrophysical Observation", "SAO 239532"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.53206142),
        dec: Angle.Degrees(-55.53170412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157244"},
        {"Hipparcos Number", "HIP 85258"},
        {"Fundamental Katalog 5th Edition", "FK5 645"},
        {"Geneva Identification System", "GEN# +1.00157244"},
        {"Smithsonian Astrophysical Observation", "SAO 244725"},
        {"Wilson Evans Batten Catalogue", "WEB 14394"},
    },
    visualMagnitude: 2.84,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.32498828),
        dec: Angle.Degrees(-55.52982397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125422"},
        {"Hipparcos Number", "HIP 70137"},
        {"Smithsonian Astrophysical Observation", "SAO 241653"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.27182551),
        dec: Angle.Degrees(-55.52981162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137161"},
        {"Hipparcos Number", "HIP 75609"},
        {"Smithsonian Astrophysical Observation", "SAO 242532"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.72762778),
        dec: Angle.Degrees(-55.52849761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135784"},
        {"Hipparcos Number", "HIP 74974"},
        {"Smithsonian Astrophysical Observation", "SAO 242407"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.81757131),
        dec: Angle.Degrees(-55.52846631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76824"},
        {"Hipparcos Number", "HIP 43867"},
        {"Fundamental Katalog 5th Edition", "FK5 4797"},
        {"Smithsonian Astrophysical Observation", "SAO 236416"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.04692354),
        dec: Angle.Degrees(-55.52835727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219458"},
        {"Hipparcos Number", "HIP 114899"},
        {"Geneva Identification System", "GEN# +1.00219458"},
        {"Smithsonian Astrophysical Observation", "SAO 247809"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.10590246),
        dec: Angle.Degrees(-55.52696147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13307"},
        {"Hipparcos Number", "HIP 9961"},
        {"Smithsonian Astrophysical Observation", "SAO 232645"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.05832933),
        dec: Angle.Degrees(-55.52601012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30126"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.09136017),
        dec: Angle.Degrees(-55.52593801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 259.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210528"},
        {"Hipparcos Number", "HIP 109622"},
        {"Smithsonian Astrophysical Observation", "SAO 247353"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.10232929),
        dec: Angle.Degrees(-55.52410410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9734"},
        {"Hipparcos Number", "HIP 7290"},
        {"Geneva Identification System", "GEN# +1.00009734J"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.48011335),
        dec: Angle.Degrees(-55.52314222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89192"},
        {"Hipparcos Number", "HIP 50279"},
        {"Celescope Catalog", "CEL 3485"},
        {"Geneva Identification System", "GEN# +1.00089192"},
        {"Renson", "Renson 25580"},
        {"Smithsonian Astrophysical Observation", "SAO 237851"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.98672668),
        dec: Angle.Degrees(-55.51968804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48122"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.17289808),
        dec: Angle.Degrees(-55.51955057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16447"},
        {"Hipparcos Number", "HIP 12130"},
        {"Geneva Identification System", "GEN# +1.00016447"},
        {"Smithsonian Astrophysical Observation", "SAO 232829"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.05790416),
        dec: Angle.Degrees(-55.51735381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69574"},
        {"Hipparcos Number", "HIP 40405"},
        {"Smithsonian Astrophysical Observation", "SAO 235835"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.73186738),
        dec: Angle.Degrees(-55.51638298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81157"},
        {"Hipparcos Number", "HIP 45920"},
        {"Celescope Catalog", "CEL 3275"},
        {"Geneva Identification System", "GEN# +1.00081157"},
        {"Renson", "Renson 23040"},
        {"Smithsonian Astrophysical Observation", "SAO 236887"},
        {"Wilson Evans Batten Catalogue", "WEB 8712"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.45878607),
        dec: Angle.Degrees(-55.51487092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210920"},
        {"Hipparcos Number", "HIP 109865"},
        {"Smithsonian Astrophysical Observation", "SAO 247374"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.76937303),
        dec: Angle.Degrees(-55.51440176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113917"},
        {"Hipparcos Number", "HIP 64067"},
        {"Smithsonian Astrophysical Observation", "SAO 240578"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.95619637),
        dec: Angle.Degrees(-55.51306647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114412"},
        {"Hipparcos Number", "HIP 64333"},
        {"Smithsonian Astrophysical Observation", "SAO 240633"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.80737505),
        dec: Angle.Degrees(-55.51206177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3853"},
        {"Hipparcos Number", "HIP 3178"},
        {"Smithsonian Astrophysical Observation", "SAO 232145"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.12599930),
        dec: Angle.Degrees(-55.51153487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46312"},
        {"Hipparcos Number", "HIP 30924"},
        {"Smithsonian Astrophysical Observation", "SAO 234534"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.35039450),
        dec: Angle.Degrees(-55.51142193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132206"},
        {"Hipparcos Number", "HIP 73409"},
        {"Smithsonian Astrophysical Observation", "SAO 242159"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.02617653),
        dec: Angle.Degrees(-55.50814543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146464"},
        {"Hipparcos Number", "HIP 79958"},
        {"Geneva Identification System", "GEN# +1.00146464"},
        {"Smithsonian Astrophysical Observation", "SAO 243609"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.81603165),
        dec: Angle.Degrees(-55.50477921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33086"},
        {"Hipparcos Number", "HIP 23619"},
        {"Smithsonian Astrophysical Observation", "SAO 233812"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.17004494),
        dec: Angle.Degrees(-55.50128694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152"},
        {"Hipparcos Number", "HIP 517"},
        {"Smithsonian Astrophysical Observation", "SAO 231925"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.56378577),
        dec: Angle.Degrees(-55.49869634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163398"},
        {"Hipparcos Number", "HIP 88066"},
        {"Smithsonian Astrophysical Observation", "SAO 245152"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.79724649),
        dec: Angle.Degrees(-55.49790712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83626"},
        {"Hipparcos Number", "HIP 47248"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.46195902),
        dec: Angle.Degrees(-55.49725505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101538"},
        {"Smithsonian Astrophysical Observation", "SAO 246639"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.67482799),
        dec: Angle.Degrees(-55.49637675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85230"},
        {"Hipparcos Number", "HIP 48120"},
        {"Smithsonian Astrophysical Observation", "SAO 237369"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.16769783),
        dec: Angle.Degrees(-55.49520537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 300068"},
        {"Hipparcos Number", "HIP 46645"},
        {"Smithsonian Astrophysical Observation", "SAO 237060"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.66470025),
        dec: Angle.Degrees(-55.49484568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14229"},
        {"Hipparcos Number", "HIP 10583"},
        {"Geneva Identification System", "GEN# +1.00014229"},
        {"Smithsonian Astrophysical Observation", "SAO 232695"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.05362402),
        dec: Angle.Degrees(-55.49356438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166116"},
        {"Hipparcos Number", "HIP 89209"},
        {"Smithsonian Astrophysical Observation", "SAO 245311"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.08773889),
        dec: Angle.Degrees(-55.49248102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154487"},
        {"Hipparcos Number", "HIP 83894"},
        {"Geneva Identification System", "GEN# +1.00154487"},
        {"Smithsonian Astrophysical Observation", "SAO 244460"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.19460991),
        dec: Angle.Degrees(-55.49117464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218905"},
        {"Hipparcos Number", "HIP 114560"},
        {"Smithsonian Astrophysical Observation", "SAO 247769"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.08852812),
        dec: Angle.Degrees(-55.48951233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19938"},
        {"Hipparcos Number", "HIP 14690"},
        {"Smithsonian Astrophysical Observation", "SAO 233014"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.44564449),
        dec: Angle.Degrees(-55.48747190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111477"},
        {"Hipparcos Number", "HIP 62643"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.54560856),
        dec: Angle.Degrees(-55.48732655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135039"},
        {"Hipparcos Number", "HIP 74658"},
        {"Smithsonian Astrophysical Observation", "SAO 242351"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.83476417),
        dec: Angle.Degrees(-55.48592872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87190"},
        {"Hipparcos Number", "HIP 49131"},
        {"Geneva Identification System", "GEN# +1.00087190"},
        {"Smithsonian Astrophysical Observation", "SAO 237613"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.41260412),
        dec: Angle.Degrees(-55.48511771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224288"},
        {"Hipparcos Number", "HIP 118039"},
        {"Smithsonian Astrophysical Observation", "SAO 248069"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.14717638),
        dec: Angle.Degrees(-55.48351273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24510"},
        {"Hipparcos Number", "HIP 18027"},
        {"Smithsonian Astrophysical Observation", "SAO 233299"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.78777330),
        dec: Angle.Degrees(-55.48265919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20708"},
        {"Hipparcos Number", "HIP 15315"},
        {"Smithsonian Astrophysical Observation", "SAO 233064"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.40496267),
        dec: Angle.Degrees(-55.48253853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175282"},
        {"Hipparcos Number", "HIP 93086"},
        {"Geneva Identification System", "GEN# +1.00175282"},
        {"Smithsonian Astrophysical Observation", "SAO 245825"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.43238186),
        dec: Angle.Degrees(-55.48176140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78359"},
        {"Hipparcos Number", "HIP 44617"},
        {"Smithsonian Astrophysical Observation", "SAO 236590"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.37367794),
        dec: Angle.Degrees(-55.48126962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94545"},
        {"Hipparcos Number", "HIP 53285"},
        {"Smithsonian Astrophysical Observation", "SAO 238582"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.46762968),
        dec: Angle.Degrees(-55.47876280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68056"},
        {"Hipparcos Number", "HIP 39796"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.98832991),
        dec: Angle.Degrees(-55.47864864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55826"},
    },
    visualMagnitude: 9.11,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)26, 30.3800),
        dec: Angle.DegreesMinutesSeconds((int)-55, (int)28, 39.000)
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
    primaryId: "HIP 51095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51095"},
        {"Smithsonian Astrophysical Observation", "SAO 238061"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.58918472),
        dec: Angle.Degrees(-55.47737406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90613"},
        {"Hipparcos Number", "HIP 51092"},
        {"Smithsonian Astrophysical Observation", "SAO 238060"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.57993202),
        dec: Angle.Degrees(-55.47683411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99510"},
        {"Hipparcos Number", "HIP 55829"},
        {"Smithsonian Astrophysical Observation", "SAO 239068"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.63255613),
        dec: Angle.Degrees(-55.47657889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206502"},
        {"Hipparcos Number", "HIP 107323"},
        {"Smithsonian Astrophysical Observation", "SAO 247155"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.07504284),
        dec: Angle.Degrees(-55.47301924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71491"},
        {"Hipparcos Number", "HIP 41266"},
        {"Renson", "Renson 19730"},
        {"Smithsonian Astrophysical Observation", "SAO 235957"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.28877313),
        dec: Angle.Degrees(-55.47283502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214235"},
        {"Hipparcos Number", "HIP 111736"},
        {"Smithsonian Astrophysical Observation", "SAO 247523"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.51122771),
        dec: Angle.Degrees(-55.47159207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203166"},
        {"Hipparcos Number", "HIP 105556"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.67442705),
        dec: Angle.Degrees(-55.47094415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32244"},
        {"Hipparcos Number", "HIP 23119"},
        {"Smithsonian Astrophysical Observation", "SAO 233769"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.63032114),
        dec: Angle.Degrees(-55.47067086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72878"},
        {"Hipparcos Number", "HIP 41906"},
        {"Smithsonian Astrophysical Observation", "SAO 236075"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.17137354),
        dec: Angle.Degrees(-55.46989615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1250"},
        {"Hipparcos Number", "HIP 1314"},
        {"Smithsonian Astrophysical Observation", "SAO 231986"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.13473932),
        dec: Angle.Degrees(-55.46952747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21609"},
        {"Hipparcos Number", "HIP 16055"},
        {"Smithsonian Astrophysical Observation", "SAO 233119"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.68835066),
        dec: Angle.Degrees(-55.46750905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131984"},
        {"Hipparcos Number", "HIP 73323"},
        {"Smithsonian Astrophysical Observation", "SAO 242141"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.75082553),
        dec: Angle.Degrees(-55.46494109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127296"},
        {"Hipparcos Number", "HIP 71112"},
        {"Geneva Identification System", "GEN# +1.00127296"},
        {"Smithsonian Astrophysical Observation", "SAO 241778"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.12918117),
        dec: Angle.Degrees(-55.46376581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164805"},
        {"Hipparcos Number", "HIP 88659"},
        {"Smithsonian Astrophysical Observation", "SAO 245236"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.51109990),
        dec: Angle.Degrees(-55.46363939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102113"},
        {"Hipparcos Number", "HIP 57293"},
        {"Smithsonian Astrophysical Observation", "SAO 239346"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.21392400),
        dec: Angle.Degrees(-55.46182164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210272"},
        {"Hipparcos Number", "HIP 109488"},
        {"Geneva Identification System", "GEN# +1.00210272"},
        {"Smithsonian Astrophysical Observation", "SAO 247339"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.70611705),
        dec: Angle.Degrees(-55.45680068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 194.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23422"},
        {"Hipparcos Number", "HIP 17315"},
        {"Smithsonian Astrophysical Observation", "SAO 233233"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.59609337),
        dec: Angle.Degrees(-55.45632537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108568"},
        {"Hipparcos Number", "HIP 60885"},
        {"Smithsonian Astrophysical Observation", "SAO 239980"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.16700525),
        dec: Angle.Degrees(-55.45532148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66607"},
        {"Hipparcos Number", "HIP 39238"},
        {"Celescope Catalog", "CEL 2146"},
        {"Geneva Identification System", "GEN# +1.00066607"},
        {"Smithsonian Astrophysical Observation", "SAO 235690"},
    },
    visualMagnitude: 6.28,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.38160067),
        dec: Angle.Degrees(-55.45467367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6467"},
        {"Hipparcos Number", "HIP 5058"},
        {"Smithsonian Astrophysical Observation", "SAO 232286"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.17867954),
        dec: Angle.Degrees(-55.45419408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85810"},
        {"Hipparcos Number", "HIP 48449"},
        {"Smithsonian Astrophysical Observation", "SAO 237442"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.16573093),
        dec: Angle.Degrees(-55.45389906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220594"},
        {"Hipparcos Number", "HIP 115636"},
        {"Geneva Identification System", "GEN# +1.00220594"},
        {"Smithsonian Astrophysical Observation", "SAO 247868"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.37859025),
        dec: Angle.Degrees(-55.45221172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116401"},
        {"Hipparcos Number", "HIP 65422"},
        {"Smithsonian Astrophysical Observation", "SAO 240809"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.14081168),
        dec: Angle.Degrees(-55.45097922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75611"},
        {"Hipparcos Number", "HIP 43238"},
        {"Celescope Catalog", "CEL 2946"},
        {"Geneva Identification System", "GEN# +1.00075611"},
        {"Smithsonian Astrophysical Observation", "SAO 236295"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.11873770),
        dec: Angle.Degrees(-55.44918550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123720"},
        {"Hipparcos Number", "HIP 69300"},
        {"Smithsonian Astrophysical Observation", "SAO 241509"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.76165189),
        dec: Angle.Degrees(-55.44767131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136970"},
        {"Hipparcos Number", "HIP 75546"},
        {"Smithsonian Astrophysical Observation", "SAO 242508"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.50415869),
        dec: Angle.Degrees(-55.44559669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180119"},
        {"Hipparcos Number", "HIP 94866"},
        {"Smithsonian Astrophysical Observation", "SAO 246018"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.57781037),
        dec: Angle.Degrees(-55.44430290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182893"},
        {"Hipparcos Number", "HIP 95866"},
        {"Geneva Identification System", "GEN# +1.00182893"},
        {"Smithsonian Astrophysical Observation", "SAO 246125"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.46910889),
        dec: Angle.Degrees(-55.44159258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53525"},
        {"Hipparcos Number", "HIP 33902"},
        {"Smithsonian Astrophysical Observation", "SAO 234875"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.54799599),
        dec: Angle.Degrees(-55.44028099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68278"},
        {"Hipparcos Number", "HIP 39890"},
        {"Smithsonian Astrophysical Observation", "SAO 235775"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.21878541),
        dec: Angle.Degrees(-55.43497414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91227"},
        {"Hipparcos Number", "HIP 51456"},
        {"Smithsonian Astrophysical Observation", "SAO 238133"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.64760051),
        dec: Angle.Degrees(-55.43427480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151163"},
        {"Hipparcos Number", "HIP 82277"},
        {"Geneva Identification System", "GEN# +1.00151163"},
        {"Smithsonian Astrophysical Observation", "SAO 244155"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.17837726),
        dec: Angle.Degrees(-55.43376401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89996"},
        {"Smithsonian Astrophysical Observation", "SAO 245421"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.44224013),
        dec: Angle.Degrees(-55.43335495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12228"},
        {"Hipparcos Number", "HIP 9201"},
        {"Smithsonian Astrophysical Observation", "SAO 232589"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.60371570),
        dec: Angle.Degrees(-55.43208784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203587"},
        {"Hipparcos Number", "HIP 105755"},
        {"Smithsonian Astrophysical Observation", "SAO 247020"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.29391179),
        dec: Angle.Degrees(-55.43185873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131375"},
        {"Hipparcos Number", "HIP 73021"},
        {"Smithsonian Astrophysical Observation", "SAO 242112"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.85281389),
        dec: Angle.Degrees(-55.43142877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125669"},
        {"Hipparcos Number", "HIP 70277"},
        {"Geneva Identification System", "GEN# +1.00125669"},
        {"Smithsonian Astrophysical Observation", "SAO 241677"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.68002270),
        dec: Angle.Degrees(-55.43113571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104872"},
        {"Hipparcos Number", "HIP 58883"},
        {"Geneva Identification System", "GEN# +1.00104872"},
        {"Smithsonian Astrophysical Observation", "SAO 239635"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.15798224),
        dec: Angle.Degrees(-55.43077532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139236"},
        {"Hipparcos Number", "HIP 76687"},
        {"Smithsonian Astrophysical Observation", "SAO 242799"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.89540475),
        dec: Angle.Degrees(-55.42705894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1453"},
        {"Hipparcos Number", "HIP 1483"},
        {"Smithsonian Astrophysical Observation", "SAO 231994"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.61497964),
        dec: Angle.Degrees(-55.42602538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186836"},
        {"Hipparcos Number", "HIP 97548"},
        {"Smithsonian Astrophysical Observation", "SAO 246282"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.40550940),
        dec: Angle.Degrees(-55.42426007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130494"},
        {"Hipparcos Number", "HIP 72602"},
        {"Smithsonian Astrophysical Observation", "SAO 242055"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.67118336),
        dec: Angle.Degrees(-55.42092400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187231"},
        {"Hipparcos Number", "HIP 97746"},
        {"Smithsonian Astrophysical Observation", "SAO 246303"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.95320606),
        dec: Angle.Degrees(-55.42084345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92925"},
        {"Hipparcos Number", "HIP 52398"},
        {"Smithsonian Astrophysical Observation", "SAO 238377"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.65126199),
        dec: Angle.Degrees(-55.41816893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115990"},
        {"Hipparcos Number", "HIP 65207"},
        {"Celescope Catalog", "CEL 4241"},
        {"Geneva Identification System", "GEN# +1.00115990"},
        {"Smithsonian Astrophysical Observation", "SAO 240774"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.45289318),
        dec: Angle.Degrees(-55.41703077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24486",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24486"},
        {"Smithsonian Astrophysical Observation", "SAO 233894"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.81106941),
        dec: Angle.Degrees(-55.41647790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149234"},
        {"Hipparcos Number", "HIP 81309"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.10279581),
        dec: Angle.Degrees(-55.41475000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44164"},
        {"Hipparcos Number", "HIP 29845"},
        {"Smithsonian Astrophysical Observation", "SAO 234420"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.26959639),
        dec: Angle.Degrees(-55.41470591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163361"},
        {"Hipparcos Number", "HIP 88034"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.72112675),
        dec: Angle.Degrees(-55.41372857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37583"},
        {"Hipparcos Number", "HIP 26317"},
        {"Geneva Identification System", "GEN# +1.00037583"},
        {"Smithsonian Astrophysical Observation", "SAO 234045"},
        {"Wilson Evans Batten Catalogue", "WEB 5178"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.07153937),
        dec: Angle.Degrees(-55.41073503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91848"},
        {"Hipparcos Number", "HIP 51807"},
        {"Geneva Identification System", "GEN# +1.00091848"},
        {"Smithsonian Astrophysical Observation", "SAO 238214"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.76930514),
        dec: Angle.Degrees(-55.40974051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72820"},
        {"Hipparcos Number", "HIP 41887"},
        {"Smithsonian Astrophysical Observation", "SAO 236069"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.11897461),
        dec: Angle.Degrees(-55.40929681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111599"},
        {"Hipparcos Number", "HIP 62711"},
        {"Geneva Identification System", "GEN# +1.00111599"},
        {"Smithsonian Astrophysical Observation", "SAO 240315"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.77298299),
        dec: Angle.Degrees(-55.40885320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223125"},
        {"Hipparcos Number", "HIP 117297"},
        {"Geneva Identification System", "GEN# +1.00223125"},
        {"Smithsonian Astrophysical Observation", "SAO 248016"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.75299831),
        dec: Angle.Degrees(-55.40826702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225091"},
        {"Hipparcos Number", "HIP 260"},
        {"Geneva Identification System", "GEN# +1.00225091"},
        {"Smithsonian Astrophysical Observation", "SAO 231908"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.81709566),
        dec: Angle.Degrees(-55.40508846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161420"},
        {"Hipparcos Number", "HIP 87174"},
        {"Fundamental Katalog 5th Edition", "FK5 3412"},
        {"Geneva Identification System", "GEN# +1.00161420"},
        {"Smithsonian Astrophysical Observation", "SAO 245044"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.15868334),
        dec: Angle.Degrees(-55.40182660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211205"},
        {"Hipparcos Number", "HIP 110013"},
        {"Smithsonian Astrophysical Observation", "SAO 247388"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.23147082),
        dec: Angle.Degrees(-55.40000335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25968"},
        {"Hipparcos Number", "HIP 18969"},
        {"Smithsonian Astrophysical Observation", "SAO 233386"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.97065483),
        dec: Angle.Degrees(-55.39988373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27518"},
        {"Smithsonian Astrophysical Observation", "SAO 234151"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.40627822),
        dec: Angle.Degrees(-55.39569687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155205"},
        {"Hipparcos Number", "HIP 84241"},
        {"Smithsonian Astrophysical Observation", "SAO 244524"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.29656817),
        dec: Angle.Degrees(-55.39186382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49965"},
        {"Hipparcos Number", "HIP 32565"},
        {"Smithsonian Astrophysical Observation", "SAO 234716"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.93138501),
        dec: Angle.Degrees(-55.39070685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155054"},
        {"Hipparcos Number", "HIP 84157"},
        {"Smithsonian Astrophysical Observation", "SAO 244510"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.08309032),
        dec: Angle.Degrees(-55.38929736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116297"},
        {"Hipparcos Number", "HIP 65367"},
        {"Geneva Identification System", "GEN# +1.00116297"},
        {"Smithsonian Astrophysical Observation", "SAO 240793"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.95321145),
        dec: Angle.Degrees(-55.38828996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 300791"},
        {"Hipparcos Number", "HIP 51661"},
        {"Geneva Identification System", "GEN# +1.00300791"},
        {"Smithsonian Astrophysical Observation", "SAO 238176"},
        {"Smithsonian Astrophysical Observation 2", "SAO 238177"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.31312973),
        dec: Angle.Degrees(-55.38688483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115058"},
        {"Hipparcos Number", "HIP 64700"},
        {"Geneva Identification System", "GEN# +1.00115058"},
        {"Smithsonian Astrophysical Observation", "SAO 240685"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.90693653),
        dec: Angle.Degrees(-55.38584802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99388"},
        {"Hipparcos Number", "HIP 55773"},
        {"Smithsonian Astrophysical Observation", "SAO 239056"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.42238973),
        dec: Angle.Degrees(-55.38565119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87510"},
    },
    visualMagnitude: 11.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.19233287),
        dec: Angle.Degrees(-55.38225898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163028"},
        {"Hipparcos Number", "HIP 87892"},
        {"Smithsonian Astrophysical Observation", "SAO 245131"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.30507465),
        dec: Angle.Degrees(-55.38118845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
