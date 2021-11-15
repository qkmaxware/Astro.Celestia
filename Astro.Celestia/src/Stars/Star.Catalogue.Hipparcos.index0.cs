using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_0() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99685"},
        {"Hipparcos Number", "HIP 48752"},
        {"Geneva Identification System", "GEN# +1.00099685"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.16726051),
        dec: Angle.Degrees(-89.78245385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110994"},
        {"Hipparcos Number", "HIP 71348"},
        {"Fundamental Katalog 5th Edition", "FK5 3985"},
        {"Geneva Identification System", "GEN# +1.00110994"},
        {"Smithsonian Astrophysical Observation", "SAO 258660"},
        {"Wilson Evans Batten Catalogue", "WEB 12319"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.87831588),
        dec: Angle.Degrees(-89.77169600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90105"},
        {"Hipparcos Number", "HIP 42708"},
        {"Smithsonian Astrophysical Observation", "SAO 258546"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.51854607),
        dec: Angle.Degrees(-89.46050180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125371"},
        {"Hipparcos Number", "HIP 78866"},
        {"Fundamental Katalog 5th Edition", "FK5 5422"},
        {"Geneva Identification System", "GEN# +1.00125371"},
        {"Smithsonian Astrophysical Observation", "SAO 258715"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.48101072),
        dec: Angle.Degrees(-89.30844881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63013"},
        {"Hipparcos Number", "HIP 22645"},
        {"Geneva Identification System", "GEN# +1.00063013"},
        {"Renson", "Renson 17350"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.08412819),
        dec: Angle.Degrees(-89.27396066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99828"},
        {"Hipparcos Number", "HIP 54065"},
        {"Geneva Identification System", "GEN# +1.00099828"},
        {"Smithsonian Astrophysical Observation", "SAO 258607"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.95273774),
        dec: Angle.Degrees(-89.23917414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12697"},
        {"Hipparcos Number", "HIP 3560"},
        {"Geneva Identification System", "GEN# +1.00012697"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.37459799),
        dec: Angle.Degrees(-89.16899196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145953"},
        {"Hipparcos Number", "HIP 90987"},
        {"Smithsonian Astrophysical Observation", "SAO 258767"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.38554942),
        dec: Angle.Degrees(-89.13745594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82390"},
        {"Hipparcos Number", "HIP 40104"},
        {"Geneva Identification System", "GEN# +1.00082390"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.88527773),
        dec: Angle.Degrees(-89.00436594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104382",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Polaris Australis"},
        {"Henry Draper", "HD 177482"},
        {"Hipparcos Number", "HIP 104382"},
        {"Fundamental Katalog 5th Edition", "FK5 923"},
        {"Geneva Identification System", "GEN# +1.00177482"},
        {"Smithsonian Astrophysical Observation", "SAO 258857"},
        {"Wilson Evans Batten Catalogue", "WEB 19004"},
    },
    visualMagnitude: 5.45,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.19172547),
        dec: Angle.Degrees(-88.95651120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52522"},
        {"Hipparcos Number", "HIP 23845"},
        {"Renson", "Renson 14380"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.90313924),
        dec: Angle.Degrees(-88.87031204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75261"},
        {"Hipparcos Number", "HIP 35861"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.89900337),
        dec: Angle.Degrees(-88.85198288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206553"},
        {"Hipparcos Number", "HIP 112355"},
        {"Fundamental Katalog 5th Edition", "FK5 1669"},
        {"Geneva Identification System", "GEN# +1.00206553"},
        {"Smithsonian Astrophysical Observation", "SAO 258931"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.37331127),
        dec: Angle.Degrees(-88.81820740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154113"},
        {"Hipparcos Number", "HIP 92231"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.94714007),
        dec: Angle.Degrees(-88.77559063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65322"},
        {"Hipparcos Number", "HIP 30678"},
        {"Fundamental Katalog 5th Edition", "FK5 1662"},
        {"Geneva Identification System", "GEN# +1.00065322"},
        {"Smithsonian Astrophysical Observation", "SAO 258465"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.69688072),
        dec: Angle.Degrees(-88.74373403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110082"},
        {"Hipparcos Number", "HIP 62662"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.59313824),
        dec: Angle.Degrees(-88.12099013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92277"},
        {"Hipparcos Number", "HIP 49368"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.17048401),
        dec: Angle.Degrees(-88.67380190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128884"},
        {"Hipparcos Number", "HIP 76725"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.02212866),
        dec: Angle.Degrees(-88.65457177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155919"},
        {"Hipparcos Number", "HIP 92300"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.18883445),
        dec: Angle.Degrees(-88.64039304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77872"},
        {"Hipparcos Number", "HIP 39106"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.00244573),
        dec: Angle.Degrees(-88.60601643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67400"},
        {"Hipparcos Number", "HIP 32897"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.81526124),
        dec: Angle.Degrees(-88.53533293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 187.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115118"},
        {"Hipparcos Number", "HIP 66780"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.30113384),
        dec: Angle.Degrees(-88.48366695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75574"},
        {"Hipparcos Number", "HIP 38078"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.05068957),
        dec: Angle.Degrees(-88.45555971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188964"},
        {"Hipparcos Number", "HIP 104602"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.84743261),
        dec: Angle.Degrees(-88.45293992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106461"},
        {"Hipparcos Number", "HIP 60041"},
        {"Smithsonian Astrophysical Observation", "SAO 258640"},
    },
    visualMagnitude: 6.63,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.69478395),
        dec: Angle.Degrees(-88.41494466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57877"},
        {"Hipparcos Number", "HIP 29078"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.01281530),
        dec: Angle.Degrees(-88.37471461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1348"},
        {"Hipparcos Number", "HIP 1007"},
        {"Fundamental Katalog 5th Edition", "FK5 1655"},
        {"Geneva Identification System", "GEN# +1.00001348"},
        {"Smithsonian Astrophysical Observation", "SAO 258218"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.14031225),
        dec: Angle.Degrees(-88.36287521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16477"},
        {"Hipparcos Number", "HIP 8469"},
        {"Geneva Identification System", "GEN# +1.00016477J"},
        {"Smithsonian Astrophysical Observation", "SAO 258291"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.29750272),
        dec: Angle.Degrees(-88.35744689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98795"},
        {"Hipparcos Number", "HIP 54441"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.08632113),
        dec: Angle.Degrees(-88.35027692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41301"},
        {"Hipparcos Number", "HIP 22379"},
        {"Fundamental Katalog 5th Edition", "FK5 4442"},
        {"Geneva Identification System", "GEN# +1.00041301"},
        {"Smithsonian Astrophysical Observation", "SAO 258410"},
        {"Wilson Evans Batten Catalogue", "WEB 4312"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.26009098),
        dec: Angle.Degrees(-88.27117985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19589"},
        {"Hipparcos Number", "HIP 10768"},
        {"Fundamental Katalog 5th Edition", "FK5 1657"},
        {"Geneva Identification System", "GEN# +1.00019589"},
        {"Smithsonian Astrophysical Observation", "SAO 258307"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.64451014),
        dec: Angle.Degrees(-88.14567966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129723"},
        {"Hipparcos Number", "HIP 75736"},
        {"Fundamental Katalog 5th Edition", "FK5 920"},
        {"Geneva Identification System", "GEN# +1.00129723"},
        {"Renson", "Renson 36980"},
        {"Smithsonian Astrophysical Observation", "SAO 258720"},
        {"Wilson Evans Batten Catalogue", "WEB 12896"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.08618345),
        dec: Angle.Degrees(-88.13281448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57037"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)41, 44.8300),
        dec: Angle.DegreesMinutesSeconds((int)-88, (int)03, 43.800)
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
    primaryId: "HIP 32914",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 11.43,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)51, 27.7500),
        dec: Angle.DegreesMinutesSeconds((int)-87, (int)58, 59.700)
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
    primaryId: "HIP 46043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86142"},
        {"Hipparcos Number", "HIP 46043"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.84701457),
        dec: Angle.Degrees(-87.97397795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217208"},
        {"Hipparcos Number", "HIP 114889"},
        {"Fundamental Katalog 5th Edition", "FK5 6056"},
        {"Smithsonian Astrophysical Observation", "SAO 258960"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.07099452),
        dec: Angle.Degrees(-87.96052053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22336"},
        {"Hipparcos Number", "HIP 12931"},
        {"Renson", "Renson 5640"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.58674786),
        dec: Angle.Degrees(-87.91213367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71552"},
        {"Hipparcos Number", "HIP 37199"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.63246458),
        dec: Angle.Degrees(-87.90611061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9898"},
        {"Hipparcos Number", "HIP 5654"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.16169040),
        dec: Angle.Degrees(-87.86462696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174827"},
        {"Hipparcos Number", "HIP 97658"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.71916657),
        dec: Angle.Degrees(-87.84523235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180710"},
        {"Hipparcos Number", "HIP 99687"},
        {"Fundamental Katalog 5th Edition", "FK5 5779"},
        {"Geneva Identification System", "GEN# +1.00180710"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.43283338),
        dec: Angle.Degrees(-87.82269434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34652"},
        {"Hipparcos Number", "HIP 20325"},
        {"Fundamental Katalog 5th Edition", "FK5 4399"},
        {"Geneva Identification System", "GEN# +1.00034652"},
        {"Smithsonian Astrophysical Observation", "SAO 258386"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.31522720),
        dec: Angle.Degrees(-87.81311163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207497"},
        {"Hipparcos Number", "HIP 110397"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.43036319),
        dec: Angle.Degrees(-87.80495774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133348"},
        {"Hipparcos Number", "HIP 77114"},
        {"Geneva Identification System", "GEN# +1.00133348"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.18726193),
        dec: Angle.Degrees(-87.77643564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92092"},
        {"Hipparcos Number", "HIP 50402"},
        {"Smithsonian Astrophysical Observation", "SAO 258576"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.37537963),
        dec: Angle.Degrees(-87.72845521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77149"},
        {"Hipparcos Number", "HIP 40861"},
        {"Geneva Identification System", "GEN# +1.00077149"},
        {"Smithsonian Astrophysical Observation", "SAO 258501"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.07335296),
        dec: Angle.Degrees(-87.72808059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130339"},
        {"Hipparcos Number", "HIP 75386"},
        {"Smithsonian Astrophysical Observation", "SAO 258721"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.06888900),
        dec: Angle.Degrees(-87.71192473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2205"},
        {"Hipparcos Number", "HIP 1649"},
        {"Geneva Identification System", "GEN# +1.00002205"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.17280122),
        dec: Angle.Degrees(-87.66706225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118935"},
        {"Hipparcos Number", "HIP 68569"},
        {"Fundamental Katalog 5th Edition", "FK5 5246"},
        {"Smithsonian Astrophysical Observation", "SAO 258681"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.57031074),
        dec: Angle.Degrees(-87.61535847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164461"},
        {"Hipparcos Number", "HIP 92824"},
        {"Fundamental Katalog 5th Edition", "FK5 922"},
        {"Geneva Identification System", "GEN# +1.00164461"},
        {"Smithsonian Astrophysical Observation", "SAO 258799"},
        {"Wilson Evans Batten Catalogue", "WEB 16063"},
    },
    visualMagnitude: 5.29,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.69853501),
        dec: Angle.Degrees(-87.60551487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148451"},
        {"Hipparcos Number", "HIP 84461"},
        {"Geneva Identification System", "GEN# +1.00148451"},
        {"Smithsonian Astrophysical Observation", "SAO 258754"},
        {"Wilson Evans Batten Catalogue", "WEB 14255"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.00349797),
        dec: Angle.Degrees(-87.56589580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113283"},
        {"Hipparcos Number", "HIP 64690"},
        {"Geneva Identification System", "GEN# +1.00113283"},
        {"Smithsonian Astrophysical Observation", "SAO 258659"},
        {"Wilson Evans Batten Catalogue", "WEB 11440"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.87285290),
        dec: Angle.Degrees(-87.56030424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218362"},
        {"Hipparcos Number", "HIP 115193"},
        {"Smithsonian Astrophysical Observation", "SAO 258965"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.98143176),
        dec: Angle.Degrees(-87.55629096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219765"},
        {"Hipparcos Number", "HIP 115836"},
        {"Fundamental Katalog 5th Edition", "FK5 925"},
        {"Geneva Identification System", "GEN# +1.00219765"},
        {"Smithsonian Astrophysical Observation", "SAO 258970"},
    },
    visualMagnitude: 5.50,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.01486122),
        dec: Angle.Degrees(-87.48224182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185975"},
        {"Hipparcos Number", "HIP 100968"},
        {"Geneva Identification System", "GEN# +1.00185975"},
        {"Smithsonian Astrophysical Observation", "SAO 258853"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.06872886),
        dec: Angle.Degrees(-87.47206607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 911"},
        {"Hipparcos Number", "HIP 903"},
        {"Geneva Identification System", "GEN# +1.00000911"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.78668359),
        dec: Angle.Degrees(-87.41423771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103793"},
        {"Hipparcos Number", "HIP 58185"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.99996635),
        dec: Angle.Degrees(-87.40319896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155392"},
        {"Hipparcos Number", "HIP 88018"},
        {"Smithsonian Astrophysical Observation", "SAO 258773"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.67191493),
        dec: Angle.Degrees(-87.36446589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9787"},
        {"Hipparcos Number", "HIP 5953"},
        {"Fundamental Katalog 5th Edition", "FK5 4113"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.15204140),
        dec: Angle.Degrees(-87.34044714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17784"},
        {"Hipparcos Number", "HIP 10809"},
        {"Renson", "Renson 4450"},
        {"Smithsonian Astrophysical Observation", "SAO 258304"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.78696980),
        dec: Angle.Degrees(-87.32151345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22450"},
        {"Hipparcos Number", "HIP 13844"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.55309936),
        dec: Angle.Degrees(-87.32054873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211207"},
        {"Hipparcos Number", "HIP 111644"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.24781920),
        dec: Angle.Degrees(-87.32039130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62040"},
        {"Hipparcos Number", "HIP 33601"},
        {"Smithsonian Astrophysical Observation", "SAO 258466"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.71716332),
        dec: Angle.Degrees(-87.30475791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147832"},
        {"Hipparcos Number", "HIP 83769"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.80656771),
        dec: Angle.Degrees(-87.29708170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101532"},
        {"Hipparcos Number", "HIP 56557"},
        {"Geneva Identification System", "GEN# +1.00101532"},
        {"Smithsonian Astrophysical Observation", "SAO 258617"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.93385708),
        dec: Angle.Degrees(-87.26940521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -290.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135293"},
        {"Hipparcos Number", "HIP 77470"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.27048337),
        dec: Angle.Degrees(-87.26643504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155285"},
        {"Hipparcos Number", "HIP 87780"},
        {"Fundamental Katalog 5th Edition", "FK5 5575"},
        {"Smithsonian Astrophysical Observation", "SAO 258772"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.97181036),
        dec: Angle.Degrees(-87.24026537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85742"},
        {"Hipparcos Number", "HIP 46512"},
        {"Smithsonian Astrophysical Observation", "SAO 258541"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.30527985),
        dec: Angle.Degrees(-87.23692070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13952"},
        {"Hipparcos Number", "HIP 8550"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.57020475),
        dec: Angle.Degrees(-87.22843276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112540"},
        {"Hipparcos Number", "HIP 64109"},
        {"Geneva Identification System", "GEN# +1.00112540"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.08586661),
        dec: Angle.Degrees(-87.21951279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24826"},
        {"Hipparcos Number", "HIP 15307"},
        {"Renson", "Renson 6350"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.37385772),
        dec: Angle.Degrees(-87.21601247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147092"},
        {"Hipparcos Number", "HIP 83217"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.11210519),
        dec: Angle.Degrees(-87.20273044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200117"},
        {"Hipparcos Number", "HIP 106463"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.44377949),
        dec: Angle.Degrees(-87.18708091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169665"},
        {"Hipparcos Number", "HIP 94254"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.78986912),
        dec: Angle.Degrees(-87.18668990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128576"},
        {"Hipparcos Number", "HIP 73883"},
        {"Smithsonian Astrophysical Observation", "SAO 258709"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.51299390),
        dec: Angle.Degrees(-87.17411509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84538"},
        {"Hipparcos Number", "HIP 45816"},
        {"Smithsonian Astrophysical Observation", "SAO 258535"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.12623123),
        dec: Angle.Degrees(-87.16666721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145548"},
        {"Hipparcos Number", "HIP 82459"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.77350829),
        dec: Angle.Degrees(-87.13678223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113652"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.27574170),
        dec: Angle.Degrees(-87.05303079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198477"},
        {"Hipparcos Number", "HIP 105585"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.78570241),
        dec: Angle.Degrees(-87.05208763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105569"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.72075456),
        dec: Angle.Degrees(-87.04833848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58805"},
        {"Hipparcos Number", "HIP 32500"},
        {"Fundamental Katalog 5th Edition", "FK5 1661"},
        {"Geneva Identification System", "GEN# +1.00058805"},
        {"Smithsonian Astrophysical Observation", "SAO 258460"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.74383218),
        dec: Angle.Degrees(-87.02497454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59145"},
        {"Hipparcos Number", "HIP 32760"},
        {"Smithsonian Astrophysical Observation", "SAO 258462"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.46101193),
        dec: Angle.Degrees(-86.93250381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31976"},
        {"Hipparcos Number", "HIP 20198"},
        {"Smithsonian Astrophysical Observation", "SAO 258381"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.93792379),
        dec: Angle.Degrees(-86.92661327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88705"},
        {"Hipparcos Number", "HIP 48620"},
        {"Fundamental Katalog 5th Edition", "FK5 4882"},
        {"Smithsonian Astrophysical Observation", "SAO 258556"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.72165843),
        dec: Angle.Degrees(-86.91028242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45104"},
        {"Hipparcos Number", "HIP 27050"},
        {"Geneva Identification System", "GEN# +1.00045104"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.04293325),
        dec: Angle.Degrees(-86.90219893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94009"},
        {"Hipparcos Number", "HIP 52065"},
        {"Fundamental Katalog 5th Edition", "FK5 4945"},
        {"Geneva Identification System", "GEN# +1.00094009"},
        {"Smithsonian Astrophysical Observation", "SAO 258591"},
        {"Wilson Evans Batten Catalogue", "WEB 9493"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.58511513),
        dec: Angle.Degrees(-86.89721065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153493"},
        {"Hipparcos Number", "HIP 86410"},
        {"Geneva Identification System", "GEN# +1.00153493"},
        {"Smithsonian Astrophysical Observation", "SAO 258766"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.84561595),
        dec: Angle.Degrees(-86.88513550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48295"},
        {"Hipparcos Number", "HIP 28682"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.83193848),
        dec: Angle.Degrees(-86.78612066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194314"},
        {"Hipparcos Number", "HIP 103426"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.31113357),
        dec: Angle.Degrees(-86.78079801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67480"},
        {"Hipparcos Number", "HIP 36813"},
        {"Smithsonian Astrophysical Observation", "SAO 258482"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.56630353),
        dec: Angle.Degrees(-86.77242457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105162"},
        {"Hipparcos Number", "HIP 59086"},
        {"Smithsonian Astrophysical Observation", "SAO 258635"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.75233658),
        dec: Angle.Degrees(-86.76015425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116877"},
        {"Hipparcos Number", "HIP 66710"},
        {"Smithsonian Astrophysical Observation", "SAO 258672"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.11107857),
        dec: Angle.Degrees(-86.72515803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3932"},
        {"Hipparcos Number", "HIP 2764"},
        {"Smithsonian Astrophysical Observation", "SAO 258232"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.81747147),
        dec: Angle.Degrees(-86.70523233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21464"},
        {"Hipparcos Number", "HIP 13778"},
        {"Smithsonian Astrophysical Observation", "SAO 258328"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.33217294),
        dec: Angle.Degrees(-86.70191862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163487"},
        {"Hipparcos Number", "HIP 91074"},
        {"Smithsonian Astrophysical Observation", "SAO 258794"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.65808078),
        dec: Angle.Degrees(-86.66255283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80100"},
        {"Hipparcos Number", "HIP 43636"},
        {"Smithsonian Astrophysical Observation", "SAO 258513"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.30567207),
        dec: Angle.Degrees(-86.56230265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74566"},
        {"Hipparcos Number", "HIP 40514"},
        {"Smithsonian Astrophysical Observation", "SAO 258497"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.07271791),
        dec: Angle.Degrees(-86.55740379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91542"},
        {"Hipparcos Number", "HIP 50605"},
        {"Geneva Identification System", "GEN# +1.00091542"},
        {"Smithsonian Astrophysical Observation", "SAO 258572"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.05767619),
        dec: Angle.Degrees(-86.55689316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86836"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.15250714),
        dec: Angle.Degrees(-86.48624487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208094"},
        {"Hipparcos Number", "HIP 109686"},
        {"Fundamental Katalog 5th Edition", "FK5 5961"},
        {"Smithsonian Astrophysical Observation", "SAO 258922"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.28231115),
        dec: Angle.Degrees(-86.47928188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129289"},
        {"Hipparcos Number", "HIP 73791"},
        {"Fundamental Katalog 5th Edition", "FK5 5338"},
        {"Smithsonian Astrophysical Observation", "SAO 258710"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.23202302),
        dec: Angle.Degrees(-86.47156727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115499"},
        {"Hipparcos Number", "HIP 65758"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.20864631),
        dec: Angle.Degrees(-86.44950865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20451"},
        {"Hipparcos Number", "HIP 13281"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.73046328),
        dec: Angle.Degrees(-86.41991139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 194.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 205.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221763"},
        {"Hipparcos Number", "HIP 116717"},
        {"Geneva Identification System", "GEN# +1.00221763"},
        {"Smithsonian Astrophysical Observation", "SAO 258978"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.80363544),
        dec: Angle.Degrees(-86.39895146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127163"},
        {"Hipparcos Number", "HIP 72636"},
        {"Smithsonian Astrophysical Observation", "SAO 258706"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.76087078),
        dec: Angle.Degrees(-86.39474542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45483"},
        {"Hipparcos Number", "HIP 27734"},
        {"Smithsonian Astrophysical Observation", "SAO 258431"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.07529352),
        dec: Angle.Degrees(-86.39350894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40857"},
        {"Hipparcos Number", "HIP 25412"},
        {"Geneva Identification System", "GEN# +1.00040857"},
        {"Wilson Evans Batten Catalogue", "WEB 4925"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.52576156),
        dec: Angle.Degrees(-86.38834110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75315"},
        {"Hipparcos Number", "HIP 40951"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.36438203),
        dec: Angle.Degrees(-86.37689869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113840"},
        {"Smithsonian Astrophysical Observation", "SAO 258954"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.81687936),
        dec: Angle.Degrees(-86.37442810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93211"},
        {"Hipparcos Number", "HIP 51737"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.56688435),
        dec: Angle.Degrees(-86.37090936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148542"},
        {"Hipparcos Number", "HIP 83255"},
        {"Fundamental Katalog 5th Edition", "FK5 921"},
        {"Geneva Identification System", "GEN# +1.00148542"},
        {"Renson", "Renson 41975"},
        {"Smithsonian Astrophysical Observation", "SAO 258751"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.24350817),
        dec: Angle.Degrees(-86.36429709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155522"},
        {"Hipparcos Number", "HIP 86937"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.46576880),
        dec: Angle.Degrees(-86.29841047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62691"},
        {"Hipparcos Number", "HIP 34967"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.52729662),
        dec: Angle.Degrees(-86.25133245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29034"},
        {"Hipparcos Number", "HIP 18872"},
        {"Fundamental Katalog 5th Edition", "FK5 4363"},
        {"Smithsonian Astrophysical Observation", "SAO 258368"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.68396133),
        dec: Angle.Degrees(-86.24539628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97903"},
        {"Hipparcos Number", "HIP 54474"},
        {"Smithsonian Astrophysical Observation", "SAO 258605"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.17223125),
        dec: Angle.Degrees(-86.23094263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150074"},
        {"Hipparcos Number", "HIP 83987"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.53717943),
        dec: Angle.Degrees(-86.20422460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167490"},
        {"Hipparcos Number", "HIP 92332"},
        {"Fundamental Katalog 5th Edition", "FK5 5654"},
        {"Smithsonian Astrophysical Observation", "SAO 258803"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.27736555),
        dec: Angle.Degrees(-86.19525737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29881"},
        {"Hipparcos Number", "HIP 19514"},
        {"Geneva Identification System", "GEN# +1.00029881"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.71031203),
        dec: Angle.Degrees(-86.19444870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 703"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.19229374),
        dec: Angle.Degrees(-86.18850470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14160"},
        {"Hipparcos Number", "HIP 9250"},
        {"Smithsonian Astrophysical Observation", "SAO 258288"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.72803549),
        dec: Angle.Degrees(-86.18441423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190767"},
        {"Hipparcos Number", "HIP 101562"},
        {"Smithsonian Astrophysical Observation", "SAO 258859"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.75728771),
        dec: Angle.Degrees(-86.16361121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139760"},
        {"Hipparcos Number", "HIP 78948"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.75341950),
        dec: Angle.Degrees(-86.16055736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210681"},
        {"Hipparcos Number", "HIP 110867"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.92608349),
        dec: Angle.Degrees(-86.15565341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107739"},
        {"Hipparcos Number", "HIP 60638"},
        {"Geneva Identification System", "GEN# +1.00107739"},
        {"Smithsonian Astrophysical Observation", "SAO 258644"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.40949088),
        dec: Angle.Degrees(-86.15059684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23859"},
        {"Hipparcos Number", "HIP 15574"},
        {"Geneva Identification System", "GEN# +1.00023859"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.15817334),
        dec: Angle.Degrees(-86.13826854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188909"},
        {"Hipparcos Number", "HIP 100793"},
        {"Smithsonian Astrophysical Observation", "SAO 258855"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.55169182),
        dec: Angle.Degrees(-86.10480106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92683"},
        {"Hipparcos Number", "HIP 51472"},
        {"Fundamental Katalog 5th Edition", "FK5 1663"},
        {"Geneva Identification System", "GEN# +1.00092683"},
        {"Smithsonian Astrophysical Observation", "SAO 258586"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.70531633),
        dec: Angle.Degrees(-86.09067844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137334"},
        {"Hipparcos Number", "HIP 77613"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.67036179),
        dec: Angle.Degrees(-86.08511777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44959"},
        {"Hipparcos Number", "HIP 27710"},
        {"Geneva Identification System", "GEN# +1.00044959"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.01791555),
        dec: Angle.Degrees(-86.07520366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 385"},
        {"Hipparcos Number", "HIP 620"},
        {"Fundamental Katalog 5th Edition", "FK5 4015"},
        {"Smithsonian Astrophysical Observation", "SAO 258214"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.90322981),
        dec: Angle.Degrees(-86.03877612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171760"},
        {"Hipparcos Number", "HIP 94002"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.08348164),
        dec: Angle.Degrees(-86.01414784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85300"},
        {"Hipparcos Number", "HIP 46892"},
        {"Fundamental Katalog 5th Edition", "FK5 4848"},
        {"Smithsonian Astrophysical Observation", "SAO 258542"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.32536808),
        dec: Angle.Degrees(-86.01002222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85300B"},
        {"Hipparcos Number", "HIP 46870"},
        {"Smithsonian Astrophysical Observation", "SAO 258540"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.26397746),
        dec: Angle.Degrees(-86.00959870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211539"},
        {"Hipparcos Number", "HIP 111196"},
        {"Fundamental Katalog 5th Edition", "FK5 1670"},
        {"Geneva Identification System", "GEN# +1.00211539"},
        {"Smithsonian Astrophysical Observation", "SAO 258932"},
    },
    visualMagnitude: 5.76,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.90761619),
        dec: Angle.Degrees(-85.96740206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119110"},
        {"Hipparcos Number", "HIP 67891"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.57060868),
        dec: Angle.Degrees(-85.95903167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88722"},
        {"Hipparcos Number", "HIP 48976"},
        {"Smithsonian Astrophysical Observation", "SAO 258559"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.86145383),
        dec: Angle.Degrees(-85.95425466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24318"},
        {"Hipparcos Number", "HIP 15974"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.41715619),
        dec: Angle.Degrees(-85.94625596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10992"},
        {"Hipparcos Number", "HIP 7302"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.50564042),
        dec: Angle.Degrees(-85.93587337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97709"},
        {"Hipparcos Number", "HIP 54409"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.00106139),
        dec: Angle.Degrees(-85.91765760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67479"},
        {"Hipparcos Number", "HIP 37470"},
        {"Fundamental Katalog 5th Edition", "FK5 4693"},
        {"Smithsonian Astrophysical Observation", "SAO 258486"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.36228294),
        dec: Angle.Degrees(-85.91630233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42556"},
        {"Hipparcos Number", "HIP 26661"},
        {"Fundamental Katalog 5th Edition", "FK5 1660"},
        {"Smithsonian Astrophysical Observation", "SAO 258427"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.99718963),
        dec: Angle.Degrees(-85.91434283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207047"},
        {"Hipparcos Number", "HIP 108907"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.91231076),
        dec: Angle.Degrees(-85.90261825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223648"},
        {"Hipparcos Number", "HIP 117751"},
        {"Renson", "Renson 61300"},
        {"Smithsonian Astrophysical Observation", "SAO 258990"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.20372197),
        dec: Angle.Degrees(-85.89554481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4863"},
        {"Hipparcos Number", "HIP 3470"},
        {"Geneva Identification System", "GEN# +1.00004863"},
        {"Smithsonian Astrophysical Observation", "SAO 258240"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.08845455),
        dec: Angle.Degrees(-85.89152517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19069"},
        {"Hipparcos Number", "HIP 12610"},
        {"Smithsonian Astrophysical Observation", "SAO 258314"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.53246874),
        dec: Angle.Degrees(-85.85811150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205195"},
        {"Henry Draper 2", "HD 205195A"},
        {"Hipparcos Number", "HIP 107949"},
        {"Smithsonian Astrophysical Observation", "SAO 258908"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.04645652),
        dec: Angle.Degrees(-85.83656586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157756"},
        {"Hipparcos Number", "HIP 87742"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.84613895),
        dec: Angle.Degrees(-85.82989560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116632"},
        {"Hipparcos Number", "HIP 66323"},
        {"Smithsonian Astrophysical Observation", "SAO 258671"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.88107548),
        dec: Angle.Degrees(-85.82426705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11856"},
        {"Hipparcos Number", "HIP 7931"},
        {"Smithsonian Astrophysical Observation", "SAO 258278"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.48924531),
        dec: Angle.Degrees(-85.79551123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117374"},
        {"Hipparcos Number", "HIP 66753"},
        {"Fundamental Katalog 5th Edition", "FK5 1665"},
        {"Geneva Identification System", "GEN# +1.00117374"},
        {"Renson", "Renson 33860"},
        {"Smithsonian Astrophysical Observation", "SAO 258674"},
        {"Wilson Evans Batten Catalogue", "WEB 11774"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.23406365),
        dec: Angle.Degrees(-85.78599228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105155"},
        {"Hipparcos Number", "HIP 59059"},
        {"Smithsonian Astrophysical Observation", "SAO 258634"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.67689241),
        dec: Angle.Degrees(-85.78040428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80099"},
        {"Hipparcos Number", "HIP 44020"},
        {"Smithsonian Astrophysical Observation", "SAO 258517"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.47254454),
        dec: Angle.Degrees(-85.74890246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97437"},
        {"Hipparcos Number", "HIP 54279"},
        {"Smithsonian Astrophysical Observation", "SAO 258602"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.55585103),
        dec: Angle.Degrees(-85.74886404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55914"},
        {"Hipparcos Number", "HIP 32458"},
        {"Smithsonian Astrophysical Observation", "SAO 258457"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.61375826),
        dec: Angle.Degrees(-85.74609745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200752"},
        {"Hipparcos Number", "HIP 105871"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.62701563),
        dec: Angle.Degrees(-85.72263129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16701"},
        {"Hipparcos Number", "HIP 10993"},
        {"Fundamental Katalog 5th Edition", "FK5 1656"},
        {"Geneva Identification System", "GEN# +1.00016701"},
        {"Smithsonian Astrophysical Observation", "SAO 258302"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.41931688),
        dec: Angle.Degrees(-85.71789991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220522"},
        {"Hipparcos Number", "HIP 115928"},
        {"Smithsonian Astrophysical Observation", "SAO 258973"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.31801170),
        dec: Angle.Degrees(-85.70940010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166066"},
        {"Hipparcos Number", "HIP 91434"},
        {"Geneva Identification System", "GEN# +1.00166066"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.70799692),
        dec: Angle.Degrees(-85.70884796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4229"},
        {"Hipparcos Number", "HIP 3114"},
        {"Geneva Identification System", "GEN# +1.00004229"},
        {"Smithsonian Astrophysical Observation", "SAO 258238"},
        {"Wilson Evans Batten Catalogue", "WEB 555"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.90895997),
        dec: Angle.Degrees(-85.70084431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71274"},
        {"Hipparcos Number", "HIP 39319"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.58650309),
        dec: Angle.Degrees(-85.69091786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132463"},
        {"Hipparcos Number", "HIP 75015"},
        {"Smithsonian Astrophysical Observation", "SAO 258722"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.93314426),
        dec: Angle.Degrees(-85.67958187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79837"},
        {"Hipparcos Number", "HIP 43908"},
        {"Fundamental Katalog 5th Edition", "FK5 918"},
        {"Geneva Identification System", "GEN# +1.00079837"},
        {"Smithsonian Astrophysical Observation", "SAO 258515"},
        {"Wilson Evans Batten Catalogue", "WEB 8445"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.17451360),
        dec: Angle.Degrees(-85.66323432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21275"},
        {"Hipparcos Number", "HIP 14210"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.80471396),
        dec: Angle.Degrees(-85.63937030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200267"},
        {"Hipparcos Number", "HIP 105581"},
        {"Fundamental Katalog 5th Edition", "FK5 5886"},
        {"Smithsonian Astrophysical Observation", "SAO 258887"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.77831971),
        dec: Angle.Degrees(-85.63876238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58713"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.63741400),
        dec: Angle.Degrees(-85.63747469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104555"},
        {"Hipparcos Number", "HIP 58697"},
        {"Fundamental Katalog 5th Edition", "FK5 3983"},
        {"Geneva Identification System", "GEN# +1.00104555"},
        {"Smithsonian Astrophysical Observation", "SAO 258632"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.58615049),
        dec: Angle.Degrees(-85.63176087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108259"},
        {"Hipparcos Number", "HIP 60926"},
        {"Geneva Identification System", "GEN# +1.00108259"},
        {"Smithsonian Astrophysical Observation", "SAO 258645"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.30282883),
        dec: Angle.Degrees(-85.57924918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170391"},
        {"Hipparcos Number", "HIP 93082"},
        {"Fundamental Katalog 5th Edition", "FK5 5671"},
        {"Smithsonian Astrophysical Observation", "SAO 258812"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.42308182),
        dec: Angle.Degrees(-85.56527347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114035"},
        {"Hipparcos Number", "HIP 64709"},
        {"Renson", "Renson 33020"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.93602337),
        dec: Angle.Degrees(-85.56118423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200221"},
        {"Hipparcos Number", "HIP 105532"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.60966575),
        dec: Angle.Degrees(-85.54067864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144444"},
        {"Hipparcos Number", "HIP 80852"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.66829876),
        dec: Angle.Degrees(-85.51065183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213529"},
        {"Hipparcos Number", "HIP 112146"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.73561405),
        dec: Angle.Degrees(-85.50996088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101438"},
        {"Hipparcos Number", "HIP 56706"},
        {"Geneva Identification System", "GEN# +1.00101438"},
        {"Smithsonian Astrophysical Observation", "SAO 258619"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.39630992),
        dec: Angle.Degrees(-85.48649606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36129"},
        {"Hipparcos Number", "HIP 23372"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.37430734),
        dec: Angle.Degrees(-85.48621573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65870"},
        {"Hipparcos Number", "HIP 37010"},
        {"Smithsonian Astrophysical Observation", "SAO 258479"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.10189877),
        dec: Angle.Degrees(-85.43570208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4152"},
        {"Hipparcos Number", "HIP 3053"},
        {"Geneva Identification System", "GEN# +1.00004152"},
        {"Smithsonian Astrophysical Observation", "SAO 258237"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.69033976),
        dec: Angle.Degrees(-85.41237038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34449"},
        {"Hipparcos Number", "HIP 22504"},
        {"Geneva Identification System", "GEN# +1.00034449"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.63706679),
        dec: Angle.Degrees(-85.37507484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112692"},
        {"Hipparcos Number", "HIP 63852"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.29366439),
        dec: Angle.Degrees(-85.36962151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125957"},
        {"Hipparcos Number", "HIP 71564"},
        {"Smithsonian Astrophysical Observation", "SAO 258703"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.54197435),
        dec: Angle.Degrees(-85.29364143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200526"},
        {"Hipparcos Number", "HIP 105628"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.91633142),
        dec: Angle.Degrees(-85.28828505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150065"},
        {"Hipparcos Number", "HIP 83487"},
        {"Smithsonian Astrophysical Observation", "SAO 258753"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.94927694),
        dec: Angle.Degrees(-85.28699684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92865"},
        {"Hipparcos Number", "HIP 51723"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.52429031),
        dec: Angle.Degrees(-85.28156938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25887"},
        {"Hipparcos Number", "HIP 17328"},
        {"Geneva Identification System", "GEN# +1.00025887J"},
        {"Smithsonian Astrophysical Observation", "SAO 258356"},
        {"Wilson Evans Batten Catalogue", "WEB 3275"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.63620779),
        dec: Angle.Degrees(-85.26202284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3913"},
        {"Hipparcos Number", "HIP 2928"},
        {"Fundamental Katalog 5th Edition", "FK5 4056"},
        {"Smithsonian Astrophysical Observation", "SAO 258234"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.28648678),
        dec: Angle.Degrees(-85.25251475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159517"},
        {"Hipparcos Number", "HIP 88274"},
        {"Fundamental Katalog 5th Edition", "FK5 3989"},
        {"Geneva Identification System", "GEN# +1.00159517"},
        {"Smithsonian Astrophysical Observation", "SAO 258779"},
        {"Wilson Evans Batten Catalogue", "WEB 14917"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.39253838),
        dec: Angle.Degrees(-85.21447624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199692"},
        {"Hipparcos Number", "HIP 105145"},
        {"Smithsonian Astrophysical Observation", "SAO 258883"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.50038449),
        dec: Angle.Degrees(-85.20114168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93310"},
        {"Hipparcos Number", "HIP 52020"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.42081224),
        dec: Angle.Degrees(-85.19455547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25451"},
        {"Hipparcos Number", "HIP 17079"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.89258674),
        dec: Angle.Degrees(-85.19451614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29830"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.22089682),
        dec: Angle.Degrees(-85.18512220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 162.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81063"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.35765065),
        dec: Angle.Degrees(-85.18153504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -274.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94930"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.75975242),
        dec: Angle.Degrees(-85.18121575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19014"},
        {"Hipparcos Number", "HIP 12823"},
        {"Geneva Identification System", "GEN# +1.00019014"},
        {"Smithsonian Astrophysical Observation", "SAO 258316"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.21596259),
        dec: Angle.Degrees(-85.15900357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111482"},
        {"Hipparcos Number", "HIP 63031"},
        {"Fundamental Katalog 5th Edition", "FK5 919"},
        {"Geneva Identification System", "GEN# +1.00111482"},
        {"Smithsonian Astrophysical Observation", "SAO 258654"},
        {"Wilson Evans Batten Catalogue", "WEB 11174"},
    },
    visualMagnitude: 5.45,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.74311570),
        dec: Angle.Degrees(-85.12342237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120071"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.90874574),
        dec: Angle.Degrees(-85.11982654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102586"},
        {"Hipparcos Number", "HIP 57484"},
        {"Smithsonian Astrophysical Observation", "SAO 258623"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.74864431),
        dec: Angle.Degrees(-85.10764555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160999"},
        {"Hipparcos Number", "HIP 88896"},
        {"Smithsonian Astrophysical Observation", "SAO 258785"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.22050367),
        dec: Angle.Degrees(-85.08438618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194594"},
        {"Hipparcos Number", "HIP 102575"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.80740748),
        dec: Angle.Degrees(-85.08230504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89499"},
        {"Hipparcos Number", "HIP 49616"},
        {"Cincinnati Publication", "Ci 20 572"},
        {"Geneva Identification System", "GEN# +1.00089499"},
        {"Wilson Evans Batten Catalogue", "WEB 9154"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.88902078),
        dec: Angle.Degrees(-85.07679025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -563.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 393.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73506"},
        {"Hipparcos Number", "HIP 40701"},
        {"Smithsonian Astrophysical Observation", "SAO 258495"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.62467964),
        dec: Angle.Degrees(-85.07642753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47018"},
        {"Hipparcos Number", "HIP 29313"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.71579878),
        dec: Angle.Degrees(-85.06296748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106310"},
        {"Hipparcos Number", "HIP 59731"},
        {"Smithsonian Astrophysical Observation", "SAO 258638"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.74835580),
        dec: Angle.Degrees(-85.05760764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12880"},
        {"Hipparcos Number", "HIP 8783"},
        {"Smithsonian Astrophysical Observation", "SAO 258283"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.24270726),
        dec: Angle.Degrees(-85.03486171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206053"},
        {"Hipparcos Number", "HIP 108129"},
        {"Smithsonian Astrophysical Observation", "SAO 258916"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.59368104),
        dec: Angle.Degrees(-85.03358338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59746"},
        {"Hipparcos Number", "HIP 34374"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.89425028),
        dec: Angle.Degrees(-85.02650540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17946"},
        {"Hipparcos Number", "HIP 12078"},
        {"Fundamental Katalog 5th Edition", "FK5 4239"},
        {"Smithsonian Astrophysical Observation", "SAO 258311"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.92660772),
        dec: Angle.Degrees(-85.01699106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107272"},
        {"Hipparcos Number", "HIP 60297"},
        {"Smithsonian Astrophysical Observation", "SAO 258642"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.45786494),
        dec: Angle.Degrees(-85.01015480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148940"},
        {"Hipparcos Number", "HIP 82768"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.73082351),
        dec: Angle.Degrees(-85.00985738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114668"},
        {"Smithsonian Astrophysical Observation", "SAO 258962"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.44561411),
        dec: Angle.Degrees(-85.00943575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166493"},
        {"Hipparcos Number", "HIP 91202"},
        {"Renson", "Renson 46880"},
        {"Smithsonian Astrophysical Observation", "SAO 258797"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.07614507),
        dec: Angle.Degrees(-85.00756678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179889"},
        {"Hipparcos Number", "HIP 96614"},
        {"Geneva Identification System", "GEN# +1.00179889"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.63920042),
        dec: Angle.Degrees(-85.00459438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1032"},
        {"Hipparcos Number", "HIP 1074"},
        {"Fundamental Katalog 5th Edition", "FK5 3972"},
        {"Geneva Identification System", "GEN# +1.00001032"},
        {"Smithsonian Astrophysical Observation", "SAO 258217"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.33145220),
        dec: Angle.Degrees(-84.99402068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99827"},
        {"Hipparcos Number", "HIP 55746"},
        {"Smithsonian Astrophysical Observation", "SAO 258611"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.32525747),
        dec: Angle.Degrees(-84.95456894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146110"},
        {"Hipparcos Number", "HIP 81367"},
        {"Smithsonian Astrophysical Observation", "SAO 258744"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.25447721),
        dec: Angle.Degrees(-84.94681420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5406"},
        {"Hipparcos Number", "HIP 3899"},
        {"Smithsonian Astrophysical Observation", "SAO 258245"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.50325276),
        dec: Angle.Degrees(-84.93524164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185656"},
        {"Hipparcos Number", "HIP 98708"},
        {"Smithsonian Astrophysical Observation", "SAO 258846"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.73047139),
        dec: Angle.Degrees(-84.91970177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42125"},
        {"Hipparcos Number", "HIP 26932"},
        {"Fundamental Katalog 5th Edition", "FK5 4523"},
        {"Geneva Identification System", "GEN# +1.00042125"},
        {"Smithsonian Astrophysical Observation", "SAO 258426"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.74467347),
        dec: Angle.Degrees(-84.90101081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217690"},
        {"Hipparcos Number", "HIP 114306"},
        {"Smithsonian Astrophysical Observation", "SAO 258957"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.24298148),
        dec: Angle.Degrees(-84.87983544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21989"},
        {"Geneva Identification System", "GEN# -0.08500055"},
        {"Smithsonian Astrophysical Observation", "SAO 258392"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.90002049),
        dec: Angle.Degrees(-84.81108962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202418"},
        {"Hipparcos Number", "HIP 106320"},
        {"Geneva Identification System", "GEN# +1.00202418"},
        {"Smithsonian Astrophysical Observation", "SAO 258899"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.01192811),
        dec: Angle.Degrees(-84.80999675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31053"},
        {"Hipparcos Number", "HIP 20930"},
        {"Geneva Identification System", "GEN# +1.00031053"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.31937818),
        dec: Angle.Degrees(-84.80510807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120949"},
        {"Hipparcos Number", "HIP 68695"},
        {"Smithsonian Astrophysical Observation", "SAO 258685"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.92328182),
        dec: Angle.Degrees(-84.79153781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131596"},
        {"Hipparcos Number", "HIP 74296"},
        {"Geneva Identification System", "GEN# +1.00131596"},
        {"Smithsonian Astrophysical Observation", "SAO 258717"},
    },
    visualMagnitude: 5.88,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.78664063),
        dec: Angle.Degrees(-84.78782184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39780"},
        {"Hipparcos Number", "HIP 25776"},
        {"Fundamental Katalog 5th Edition", "FK5 1659"},
        {"Geneva Identification System", "GEN# +1.00039780"},
        {"Smithsonian Astrophysical Observation", "SAO 258418"},
        {"Wilson Evans Batten Catalogue", "WEB 5007"},
    },
    visualMagnitude: 6.18,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.55804936),
        dec: Angle.Degrees(-84.78521152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11025"},
        {"Hipparcos Number", "HIP 7568"},
        {"Fundamental Katalog 5th Edition", "FK5 916"},
        {"Geneva Identification System", "GEN# +1.00011025"},
        {"Smithsonian Astrophysical Observation", "SAO 258273"},
        {"Wilson Evans Batten Catalogue", "WEB 1619"},
    },
    visualMagnitude: 5.66,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.36574940),
        dec: Angle.Degrees(-84.76965017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136725"},
        {"Hipparcos Number", "HIP 76800"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.21525240),
        dec: Angle.Degrees(-84.75737247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200204"},
        {"Hipparcos Number", "HIP 105274"},
        {"Geneva Identification System", "GEN# +1.00200204"},
        {"Smithsonian Astrophysical Observation", "SAO 258885"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.85350136),
        dec: Angle.Degrees(-84.75622445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13121"},
        {"Hipparcos Number", "HIP 8976"},
        {"Fundamental Katalog 5th Edition", "FK5 4173"},
        {"Smithsonian Astrophysical Observation", "SAO 258285"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.92446139),
        dec: Angle.Degrees(-84.75116435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169082"},
        {"Hipparcos Number", "HIP 92145"},
        {"Smithsonian Astrophysical Observation", "SAO 258805"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.70840136),
        dec: Angle.Degrees(-84.72673733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177671"},
        {"Hipparcos Number", "HIP 95781"},
        {"Fundamental Katalog 5th Edition", "FK5 5715"},
        {"Geneva Identification System", "GEN# +1.00177671"},
        {"Smithsonian Astrophysical Observation", "SAO 258829"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.22442333),
        dec: Angle.Degrees(-84.71995362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23776"},
        {"Hipparcos Number", "HIP 16131"},
        {"Geneva Identification System", "GEN# +1.00023776"},
        {"Smithsonian Astrophysical Observation", "SAO 258341"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.94545855),
        dec: Angle.Degrees(-84.71573862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155498"},
        {"Hipparcos Number", "HIP 86072"},
        {"Geneva Identification System", "GEN# +1.00155498"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.86520504),
        dec: Angle.Degrees(-84.69673394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75314"},
        {"Hipparcos Number", "HIP 41796"},
        {"Smithsonian Astrophysical Observation", "SAO 258499"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.83305273),
        dec: Angle.Degrees(-84.68503387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210548"},
        {"Hipparcos Number", "HIP 110428"},
        {"Smithsonian Astrophysical Observation", "SAO 258927"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.51053141),
        dec: Angle.Degrees(-84.66619545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150996"},
        {"Hipparcos Number", "HIP 83751"},
        {"Smithsonian Astrophysical Observation", "SAO 258757"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.76074535),
        dec: Angle.Degrees(-84.66532909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82370"},
        {"Hipparcos Number", "HIP 45532"},
        {"Smithsonian Astrophysical Observation", "SAO 258527"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.19406862),
        dec: Angle.Degrees(-84.66033929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45469"},
        {"Smithsonian Astrophysical Observation", "SAO 258526"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.98120463),
        dec: Angle.Degrees(-84.64797540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15372"},
        {"Hipparcos Number", "HIP 10436"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.61749095),
        dec: Angle.Degrees(-84.62370378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82025"},
        {"Hipparcos Number", "HIP 45357"},
        {"Smithsonian Astrophysical Observation", "SAO 258525"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.64542788),
        dec: Angle.Degrees(-84.62337867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135611"},
        {"Hipparcos Number", "HIP 76178"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.39521625),
        dec: Angle.Degrees(-84.60870657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96124"},
        {"Hipparcos Number", "HIP 53702"},
        {"Fundamental Katalog 5th Edition", "FK5 1664"},
        {"Geneva Identification System", "GEN# +1.00096124"},
        {"Smithsonian Astrophysical Observation", "SAO 258600"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.80901947),
        dec: Angle.Degrees(-84.59387348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126643"},
        {"Hipparcos Number", "HIP 71747"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.13969388),
        dec: Angle.Degrees(-84.57137460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122470"},
        {"Hipparcos Number", "HIP 69487"},
        {"Smithsonian Astrophysical Observation", "SAO 258691"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.39226822),
        dec: Angle.Degrees(-84.54462906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14759"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.65328768),
        dec: Angle.Degrees(-84.54367107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 592.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 209.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153647"},
        {"Hipparcos Number", "HIP 85054"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.73660279),
        dec: Angle.Degrees(-84.51258905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29138"},
        {"Hipparcos Number", "HIP 19732"},
        {"Geneva Identification System", "GEN# +1.00029138"},
        {"Smithsonian Astrophysical Observation", "SAO 258373"},
        {"Wilson Evans Batten Catalogue", "WEB 3765"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.44475023),
        dec: Angle.Degrees(-84.48581399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120538"},
        {"Hipparcos Number", "HIP 68429"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.13426256),
        dec: Angle.Degrees(-84.48248547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95688"},
        {"Hipparcos Number", "HIP 53498"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.15946425),
        dec: Angle.Degrees(-84.47856310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60102"},
        {"Hipparcos Number", "HIP 34753"},
        {"Smithsonian Astrophysical Observation", "SAO 258468"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.91029536),
        dec: Angle.Degrees(-84.46940884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137333"},
        {"Hipparcos Number", "HIP 76996"},
        {"Fundamental Katalog 5th Edition", "FK5 1666"},
        {"Geneva Identification System", "GEN# +1.00137333"},
        {"Smithsonian Astrophysical Observation", "SAO 258731"},
        {"Wilson Evans Batten Catalogue", "WEB 13057"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.81708657),
        dec: Angle.Degrees(-84.46550807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114298"},
        {"Hipparcos Number", "HIP 64743"},
        {"Smithsonian Astrophysical Observation", "SAO 258661"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.03840172),
        dec: Angle.Degrees(-84.46283128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144167"},
        {"Hipparcos Number", "HIP 80382"},
        {"Geneva Identification System", "GEN# +1.00144167"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.11715033),
        dec: Angle.Degrees(-84.45547209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71676"},
        {"Hipparcos Number", "HIP 39998"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.52773659),
        dec: Angle.Degrees(-84.44493650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97436"},
        {"Hipparcos Number", "HIP 54391"},
        {"Fundamental Katalog 5th Edition", "FK5 4984"},
        {"Smithsonian Astrophysical Observation", "SAO 258603"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.94008561),
        dec: Angle.Degrees(-84.43692048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206961"},
        {"Hipparcos Number", "HIP 108469"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.60330413),
        dec: Angle.Degrees(-84.43543240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194149"},
        {"Hipparcos Number", "HIP 102205"},
        {"Fundamental Katalog 5th Edition", "FK5 1668"},
        {"Geneva Identification System", "GEN# +1.00194149"},
        {"Renson", "Renson 54190"},
        {"Smithsonian Astrophysical Observation", "SAO 258866"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.63978636),
        dec: Angle.Degrees(-84.40704999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160115"},
        {"Hipparcos Number", "HIP 88209"},
        {"Smithsonian Astrophysical Observation", "SAO 258781"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.19602646),
        dec: Angle.Degrees(-84.40573935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67227"},
    },
    visualMagnitude: 11.08,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.63312646),
        dec: Angle.Degrees(-84.40181044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171991"},
        {"Hipparcos Number", "HIP 93276"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.99965571),
        dec: Angle.Degrees(-84.40151255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165338"},
        {"Hipparcos Number", "HIP 90509"},
        {"Fundamental Katalog 5th Edition", "FK5 3991"},
        {"Geneva Identification System", "GEN# +1.00165338"},
        {"Smithsonian Astrophysical Observation", "SAO 258795"},
    },
    visualMagnitude: 6.49,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.02644303),
        dec: Angle.Degrees(-84.38723353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178506"},
        {"Hipparcos Number", "HIP 95930"},
        {"Smithsonian Astrophysical Observation", "SAO 258830"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.63953207),
        dec: Angle.Degrees(-84.38386088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185684"},
        {"Hipparcos Number", "HIP 98509"},
        {"Smithsonian Astrophysical Observation", "SAO 258845"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.18674864),
        dec: Angle.Degrees(-84.38384035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31132"},
        {"Hipparcos Number", "HIP 21235"},
        {"Smithsonian Astrophysical Observation", "SAO 258382"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.32444194),
        dec: Angle.Degrees(-84.37637244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91620"},
        {"Hipparcos Number", "HIP 51084"},
        {"Smithsonian Astrophysical Observation", "SAO 258577"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.55972836),
        dec: Angle.Degrees(-84.34834769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62785"},
        {"Hipparcos Number", "HIP 36020"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.34301268),
        dec: Angle.Degrees(-84.34008514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224354"},
        {"Hipparcos Number", "HIP 118119"},
        {"Smithsonian Astrophysical Observation", "SAO 258995"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.39393659),
        dec: Angle.Degrees(-84.33217540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200816"},
        {"Hipparcos Number", "HIP 105428"},
        {"Smithsonian Astrophysical Observation", "SAO 258888"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.33758078),
        dec: Angle.Degrees(-84.30981655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150508"},
        {"Hipparcos Number", "HIP 83366"},
        {"Fundamental Katalog 5th Edition", "FK5 5500"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.57686403),
        dec: Angle.Degrees(-84.30368812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106732"},
        {"Hipparcos Number", "HIP 59928"},
        {"Smithsonian Astrophysical Observation", "SAO 258641"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.39082643),
        dec: Angle.Degrees(-84.29058037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18854"},
        {"Hipparcos Number", "HIP 12921"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.55212817),
        dec: Angle.Degrees(-84.28301179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109244"},
        {"Hipparcos Number", "HIP 61501"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.02074144),
        dec: Angle.Degrees(-84.27478179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112859"},
        {"Smithsonian Astrophysical Observation", "SAO 258945"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.83172658),
        dec: Angle.Degrees(-84.26374148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142022"},
        {"Henry Draper 2", "HD 142022A"},
        {"Hipparcos Number", "HIP 79242"},
        {"Geneva Identification System", "GEN# +1.00142022"},
        {"Smithsonian Astrophysical Observation", "SAO 258738"},
        {"Wilson Evans Batten Catalogue", "WEB 13398"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.57076306),
        dec: Angle.Degrees(-84.23153598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -337.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92238"},
        {"Hipparcos Number", "HIP 51499"},
        {"Smithsonian Astrophysical Observation", "SAO 258582"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.76420201),
        dec: Angle.Degrees(-84.22019882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29245"},
        {"Hipparcos Number", "HIP 19890"},
        {"Smithsonian Astrophysical Observation", "SAO 258377"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.99564053),
        dec: Angle.Degrees(-84.18134794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24568"},
        {"Hipparcos Number", "HIP 16781"},
        {"Smithsonian Astrophysical Observation", "SAO 258348"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.99149338),
        dec: Angle.Degrees(-84.16307795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126124"},
        {"Hipparcos Number", "HIP 71404"},
        {"Smithsonian Astrophysical Observation", "SAO 258701"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.02590478),
        dec: Angle.Degrees(-84.14843301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204653"},
        {"Hipparcos Number", "HIP 107239"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.81276084),
        dec: Angle.Degrees(-84.14330128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91852"},
        {"Hipparcos Number", "HIP 51272"},
        {"Smithsonian Astrophysical Observation", "SAO 258579"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.09925336),
        dec: Angle.Degrees(-84.13875316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213579"},
        {"Hipparcos Number", "HIP 111982"},
        {"Smithsonian Astrophysical Observation", "SAO 258938"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.24554266),
        dec: Angle.Degrees(-84.13668181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142879"},
        {"Hipparcos Number", "HIP 79682"},
        {"Geneva Identification System", "GEN# +1.00142879"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.93430507),
        dec: Angle.Degrees(-84.12459765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 191.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158651"},
        {"Hipparcos Number", "HIP 87414"},
        {"Geneva Identification System", "GEN# +1.00158651"},
        {"Smithsonian Astrophysical Observation", "SAO 258778"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.96572109),
        dec: Angle.Degrees(-84.11113449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161"},
        {"Hipparcos Number", "HIP 507"},
        {"Smithsonian Astrophysical Observation", "SAO 258210"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.51738261),
        dec: Angle.Degrees(-84.09820798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100370"},
        {"Hipparcos Number", "HIP 56114"},
        {"Smithsonian Astrophysical Observation", "SAO 258613"},
    },
    visualMagnitude: 8.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.54557701),
        dec: Angle.Degrees(-84.09562809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188925"},
        {"Hipparcos Number", "HIP 99902"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.04784750),
        dec: Angle.Degrees(-84.09058688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74544"},
        {"Hipparcos Number", "HIP 41528"},
        {"Geneva Identification System", "GEN# +1.00074544"},
        {"Smithsonian Astrophysical Observation", "SAO 258498"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.04944295),
        dec: Angle.Degrees(-84.08976395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88948"},
        {"Hipparcos Number", "HIP 49442"},
        {"Smithsonian Astrophysical Observation", "SAO 258564"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.41363560),
        dec: Angle.Degrees(-84.08892660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3982"},
        {"Hipparcos Number", "HIP 3036"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.65283516),
        dec: Angle.Degrees(-84.08731582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25254"},
        {"Hipparcos Number", "HIP 17287"},
        {"Fundamental Katalog 5th Edition", "FK5 4336"},
        {"Geneva Identification System", "GEN# +1.00025254"},
        {"Smithsonian Astrophysical Observation", "SAO 258353"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.51464023),
        dec: Angle.Degrees(-84.08356237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179954"},
        {"Hipparcos Number", "HIP 96311"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.74344591),
        dec: Angle.Degrees(-84.07583507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6383",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6383"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.50895263),
        dec: Angle.Degrees(-84.06402020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -446.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68057"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.02258166),
        dec: Angle.Degrees(-84.06022922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34823"},
        {"Hipparcos Number", "HIP 23180"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.81601779),
        dec: Angle.Degrees(-84.02255356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4894"},
        {"Hipparcos Number", "HIP 3627"},
        {"Geneva Identification System", "GEN# +1.00004894"},
        {"Smithsonian Astrophysical Observation", "SAO 258241"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.62690894),
        dec: Angle.Degrees(-84.01173303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -302.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53842"},
        {"Hipparcos Number", "HIP 32435"},
        {"Geneva Identification System", "GEN# +1.00053842"},
        {"Smithsonian Astrophysical Observation", "SAO 258455"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.55596616),
        dec: Angle.Degrees(-83.99168435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205879"},
        {"Hipparcos Number", "HIP 107823"},
        {"Smithsonian Astrophysical Observation", "SAO 258910"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.66083673),
        dec: Angle.Degrees(-83.96097102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207635"},
        {"Hipparcos Number", "HIP 108744"},
        {"Smithsonian Astrophysical Observation", "SAO 258919"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.43087927),
        dec: Angle.Degrees(-83.95304586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172690"},
        {"Hipparcos Number", "HIP 93481"},
        {"Geneva Identification System", "GEN# +1.00172690"},
        {"Renson", "Renson 48380"},
        {"Smithsonian Astrophysical Observation", "SAO 258816"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.56013978),
        dec: Angle.Degrees(-83.93975931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198661"},
        {"Hipparcos Number", "HIP 104244"},
        {"Smithsonian Astrophysical Observation", "SAO 258876"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.80768448),
        dec: Angle.Degrees(-83.92426736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60040"},
        {"Hipparcos Number", "HIP 34905"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.32953471),
        dec: Angle.Degrees(-83.92379344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131744"},
        {"Hipparcos Number", "HIP 74187"},
        {"Smithsonian Astrophysical Observation", "SAO 258716"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.39365501),
        dec: Angle.Degrees(-83.90950178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117695"},
        {"Hipparcos Number", "HIP 66660"},
        {"Fundamental Katalog 5th Edition", "FK5 5208"},
        {"Geneva Identification System", "GEN# +1.00117695"},
        {"Smithsonian Astrophysical Observation", "SAO 258676"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.98431073),
        dec: Angle.Degrees(-83.90835876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146008"},
        {"Hipparcos Number", "HIP 80990"},
        {"Wilson Evans Batten Catalogue", "WEB 13698"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.10771295),
        dec: Angle.Degrees(-83.90262449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39179"},
        {"Hipparcos Number", "HIP 25758"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.51121925),
        dec: Angle.Degrees(-83.86860867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34017"},
        {"Hipparcos Number", "HIP 22763"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.45802473),
        dec: Angle.Degrees(-83.86582564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223042"},
        {"Hipparcos Number", "HIP 117347"},
        {"Smithsonian Astrophysical Observation", "SAO 258984"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.90597924),
        dec: Angle.Degrees(-83.86188317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35877"},
        {"Hipparcos Number", "HIP 23824"},
        {"Geneva Identification System", "GEN# +1.00035877"},
        {"Smithsonian Astrophysical Observation", "SAO 258401"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.82630615),
        dec: Angle.Degrees(-83.86025826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 147.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196686"},
        {"Hipparcos Number", "HIP 103235"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.71461195),
        dec: Angle.Degrees(-83.85402830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114240"},
        {"Hipparcos Number", "HIP 64652"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.79150949),
        dec: Angle.Degrees(-83.84345332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48822"},
        {"Hipparcos Number", "HIP 30523"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.23243215),
        dec: Angle.Degrees(-83.83064393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108344"},
        {"Hipparcos Number", "HIP 60912"},
        {"Fundamental Katalog 5th Edition", "FK5 3984"},
        {"Geneva Identification System", "GEN# +1.00108344"},
        {"Smithsonian Astrophysical Observation", "SAO 258646"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.25253753),
        dec: Angle.Degrees(-83.80268753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185545"},
        {"Hipparcos Number", "HIP 98279"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.53832865),
        dec: Angle.Degrees(-83.78206566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99017"},
        {"Hipparcos Number", "HIP 55372"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.07238722),
        dec: Angle.Degrees(-83.78082896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113514"},
        {"Hipparcos Number", "HIP 64213"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.41583177),
        dec: Angle.Degrees(-83.77979885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105770"},
        {"Hipparcos Number", "HIP 59404"},
        {"Geneva Identification System", "GEN# +1.00105770"},
        {"Renson", "Renson 30610"},
        {"Smithsonian Astrophysical Observation", "SAO 258636"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.78934018),
        dec: Angle.Degrees(-83.77819593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141240"},
        {"Hipparcos Number", "HIP 78783"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.25796688),
        dec: Angle.Degrees(-83.77710894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56938"},
        {"Hipparcos Number", "HIP 33675"},
        {"Smithsonian Astrophysical Observation", "SAO 258461"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.93902589),
        dec: Angle.Degrees(-83.75270337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5278"},
        {"Hipparcos Number", "HIP 3911"},
        {"Geneva Identification System", "GEN# +1.00005278"},
        {"Smithsonian Astrophysical Observation", "SAO 258243"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.53815505),
        dec: Angle.Degrees(-83.74397170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214469"},
        {"Hipparcos Number", "HIP 112372"},
        {"Geneva Identification System", "GEN# +1.00214469"},
        {"Smithsonian Astrophysical Observation", "SAO 258940"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.40629085),
        dec: Angle.Degrees(-83.74188010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81103"},
        {"Hipparcos Number", "HIP 45061"},
        {"Smithsonian Astrophysical Observation", "SAO 258521"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.67149639),
        dec: Angle.Degrees(-83.74151272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149158"},
        {"Hipparcos Number", "HIP 82501"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.92363000),
        dec: Angle.Degrees(-83.72662623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206912"},
        {"Hipparcos Number", "HIP 108322"},
        {"Geneva Identification System", "GEN# +1.00206912"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.17686022),
        dec: Angle.Degrees(-83.72652430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68060"},
        {"Hipparcos Number", "HIP 38537"},
        {"Geneva Identification System", "GEN# +1.00068060"},
        {"Smithsonian Astrophysical Observation", "SAO 258489"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.37252975),
        dec: Angle.Degrees(-83.72184864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135720"},
        {"Hipparcos Number", "HIP 76032"},
        {"Smithsonian Astrophysical Observation", "SAO 258729"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.92875727),
        dec: Angle.Degrees(-83.71250508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195227"},
        {"Hipparcos Number", "HIP 102484"},
        {"Renson", "Renson 54420"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.52314636),
        dec: Angle.Degrees(-83.68759640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153621"},
        {"Hipparcos Number", "HIP 84800"},
        {"Geneva Identification System", "GEN# +1.00153621"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.99823111),
        dec: Angle.Degrees(-83.68231315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124882"},
        {"Hipparcos Number", "HIP 70638"},
        {"Geneva Identification System", "GEN# +1.00124882"},
        {"Smithsonian Astrophysical Observation", "SAO 258698"},
        {"Wilson Evans Batten Catalogue", "WEB 12243"},
    },
    visualMagnitude: 4.31,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.73225313),
        dec: Angle.Degrees(-83.66785308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87617"},
        {"Hipparcos Number", "HIP 48724"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.06970698),
        dec: Angle.Degrees(-83.66024936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110451"},
        {"Hipparcos Number", "HIP 62239"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.34970361),
        dec: Angle.Degrees(-83.65765698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182165"},
        {"Hipparcos Number", "HIP 96923"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.53431963),
        dec: Angle.Degrees(-83.65422472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131062"},
        {"Hipparcos Number", "HIP 73796"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.24276326),
        dec: Angle.Degrees(-83.64753237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177855"},
        {"Hipparcos Number", "HIP 95507"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.38354872),
        dec: Angle.Degrees(-83.63917531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37226"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.69058972),
        dec: Angle.Degrees(-83.63670713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 186.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28576"},
        {"Hipparcos Number", "HIP 19589"},
        {"Geneva Identification System", "GEN# +1.00028576"},
        {"Smithsonian Astrophysical Observation", "SAO 258370"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.97997303),
        dec: Angle.Degrees(-83.60195345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146164"},
        {"Hipparcos Number", "HIP 80996"},
        {"Fundamental Katalog 5th Edition", "FK5 5463"},
        {"Geneva Identification System", "GEN# +1.00146164"},
        {"Renson", "Renson 41330"},
        {"Smithsonian Astrophysical Observation", "SAO 258743"},
        {"Wilson Evans Batten Catalogue", "WEB 13699"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.12685685),
        dec: Angle.Degrees(-83.59222291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7070"},
        {"Hipparcos Number", "HIP 5084"},
        {"Fundamental Katalog 5th Edition", "FK5 3973"},
        {"Smithsonian Astrophysical Observation", "SAO 258255"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.28605474),
        dec: Angle.Degrees(-83.59037137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19053"},
        {"Hipparcos Number", "HIP 13195"},
        {"Smithsonian Astrophysical Observation", "SAO 258319"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.44398379),
        dec: Angle.Degrees(-83.56956064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170848"},
        {"Hipparcos Number", "HIP 92509"},
        {"Fundamental Katalog 5th Edition", "FK5 5659"},
        {"Smithsonian Astrophysical Observation", "SAO 258807"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.79035328),
        dec: Angle.Degrees(-83.56303543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220236"},
        {"Hipparcos Number", "HIP 115641"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.39451041),
        dec: Angle.Degrees(-83.55086963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123396"},
        {"Hipparcos Number", "HIP 69834"},
        {"Geneva Identification System", "GEN# +1.00123396"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.38259075),
        dec: Angle.Degrees(-83.54779853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147043"},
        {"Hipparcos Number", "HIP 81390"},
        {"Geneva Identification System", "GEN# +1.00147043"},
        {"Smithsonian Astrophysical Observation", "SAO 258746"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.32305097),
        dec: Angle.Degrees(-83.54723286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21190"},
        {"Hipparcos Number", "HIP 14700"},
        {"Fundamental Katalog 5th Edition", "FK5 3975"},
        {"Geneva Identification System", "GEN# +1.00021190"},
        {"Renson", "Renson 5286"},
        {"Smithsonian Astrophysical Observation", "SAO 258330"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.47417906),
        dec: Angle.Degrees(-83.53160839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45766"},
        {"Hipparcos Number", "HIP 29228"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.43853671),
        dec: Angle.Degrees(-83.52272373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83524"},
        {"Hipparcos Number", "HIP 46373"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.84372201),
        dec: Angle.Degrees(-83.52006456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211487"},
        {"Hipparcos Number", "HIP 110729"},
        {"Geneva Identification System", "GEN# +1.00211487"},
        {"Smithsonian Astrophysical Observation", "SAO 258930"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.51160599),
        dec: Angle.Degrees(-83.51587679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31396"},
        {"Hipparcos Number", "HIP 21480"},
        {"Fundamental Katalog 5th Edition", "FK5 4414"},
        {"Geneva Identification System", "GEN# +1.00031396"},
        {"Smithsonian Astrophysical Observation", "SAO 258384"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.19489768),
        dec: Angle.Degrees(-83.49673273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100695"},
        {"Hipparcos Number", "HIP 56323"},
        {"Geneva Identification System", "GEN# +1.00100695"},
        {"Smithsonian Astrophysical Observation", "SAO 258615"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.20869604),
        dec: Angle.Degrees(-83.48427376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174930"},
        {"Hipparcos Number", "HIP 94347"},
        {"Geneva Identification System", "GEN# +1.00174930"},
        {"Smithsonian Astrophysical Observation", "SAO 258820"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.04644334),
        dec: Angle.Degrees(-83.48338675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145344"},
        {"Hipparcos Number", "HIP 80611"},
        {"Geneva Identification System", "GEN# +1.00145344"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.88763456),
        dec: Angle.Degrees(-83.47556255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213852"},
        {"Hipparcos Number", "HIP 112049"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.43225625),
        dec: Angle.Degrees(-83.46379693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24429"},
        {"Hipparcos Number", "HIP 16840"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.18447438),
        dec: Angle.Degrees(-83.44915551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187032"},
        {"Hipparcos Number", "HIP 98905"},
        {"Smithsonian Astrophysical Observation", "SAO 258849"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.26584067),
        dec: Angle.Degrees(-83.44002949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192695"},
        {"Hipparcos Number", "HIP 101333"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.07279152),
        dec: Angle.Degrees(-83.43082922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172226"},
        {"Hipparcos Number", "HIP 93117"},
        {"Smithsonian Astrophysical Observation", "SAO 258814"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.54178857),
        dec: Angle.Degrees(-83.42216671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163174"},
        {"Hipparcos Number", "HIP 89358"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.51579546),
        dec: Angle.Degrees(-83.41403207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98588"},
        {"Hipparcos Number", "HIP 55116"},
        {"Smithsonian Astrophysical Observation", "SAO 258606"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.26558267),
        dec: Angle.Degrees(-83.39345010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23370"},
        {"Hipparcos Number", "HIP 16208"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.20621419),
        dec: Angle.Degrees(-83.38485985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118033"},
        {"Hipparcos Number", "HIP 66822"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.43622268),
        dec: Angle.Degrees(-83.37964330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11359"},
        {"Hipparcos Number", "HIP 8018"},
        {"Geneva Identification System", "GEN# +1.00011359"},
        {"Smithsonian Astrophysical Observation", "SAO 258276"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.73332534),
        dec: Angle.Degrees(-83.36709095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92407"},
        {"Hipparcos Number", "HIP 51672"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.34901187),
        dec: Angle.Degrees(-83.36252230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209036"},
        {"Hipparcos Number", "HIP 109415"},
        {"Fundamental Katalog 5th Edition", "FK5 5958"},
        {"Smithsonian Astrophysical Observation", "SAO 258923"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.51442012),
        dec: Angle.Degrees(-83.35820838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216130"},
        {"Hipparcos Number", "HIP 113257"},
        {"Geneva Identification System", "GEN# +1.00216130"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.02180646),
        dec: Angle.Degrees(-83.35157348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20225"},
        {"Hipparcos Number", "HIP 14052"},
        {"Smithsonian Astrophysical Observation", "SAO 258325"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.23483372),
        dec: Angle.Degrees(-83.33742850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118125"},
        {"Hipparcos Number", "HIP 66869"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.57223283),
        dec: Angle.Degrees(-83.32143917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107378"},
        {"Hipparcos Number", "HIP 60330"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.55317609),
        dec: Angle.Degrees(-83.31991228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171161"},
        {"Hipparcos Number", "HIP 92586"},
        {"Fundamental Katalog 5th Edition", "FK5 3992"},
        {"Geneva Identification System", "GEN# +1.00171161"},
        {"Smithsonian Astrophysical Observation", "SAO 258810"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.99182485),
        dec: Angle.Degrees(-83.31630912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191220"},
        {"Hipparcos Number", "HIP 100697"},
        {"Geneva Identification System", "GEN# +1.00191220"},
        {"Renson", "Renson 53220"},
        {"Smithsonian Astrophysical Observation", "SAO 258856"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.22834017),
        dec: Angle.Degrees(-83.31063455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39981"},
        {"Hipparcos Number", "HIP 26383"},
        {"Geneva Identification System", "GEN# +1.00039981"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.26672975),
        dec: Angle.Degrees(-83.29113130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124062"},
        {"Hipparcos Number", "HIP 70154"},
        {"Smithsonian Astrophysical Observation", "SAO 258695"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.31716617),
        dec: Angle.Degrees(-83.27921867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103497"},
        {"Hipparcos Number", "HIP 58055"},
        {"Smithsonian Astrophysical Observation", "SAO 258626"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.60745747),
        dec: Angle.Degrees(-83.27324782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200307"},
        {"Hipparcos Number", "HIP 104997"},
        {"Fundamental Katalog 5th Edition", "FK5 5876"},
        {"Smithsonian Astrophysical Observation", "SAO 258884"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.98172847),
        dec: Angle.Degrees(-83.26586310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6794"},
        {"Hipparcos Number", "HIP 4926"},
        {"Smithsonian Astrophysical Observation", "SAO 258250"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.80161616),
        dec: Angle.Degrees(-83.25451373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213615"},
        {"Hipparcos Number", "HIP 111898"},
        {"Geneva Identification System", "GEN# +1.00213615"},
        {"Smithsonian Astrophysical Observation", "SAO 258937"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.99740091),
        dec: Angle.Degrees(-83.25167274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10870"},
        {"Hipparcos Number", "HIP 7637"},
        {"Smithsonian Astrophysical Observation", "SAO 258272"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.60283351),
        dec: Angle.Degrees(-83.24769755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148527"},
        {"Hipparcos Number", "HIP 82076"},
        {"Geneva Identification System", "GEN# +1.00148527"},
        {"Smithsonian Astrophysical Observation", "SAO 258748"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.47357184),
        dec: Angle.Degrees(-83.23982394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160288"},
        {"Hipparcos Number", "HIP 87931"},
        {"Geneva Identification System", "GEN# +1.00160288"},
        {"Smithsonian Astrophysical Observation", "SAO 258780"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.43641948),
        dec: Angle.Degrees(-83.23540536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137179"},
        {"Hipparcos Number", "HIP 76642"},
        {"Geneva Identification System", "GEN# +1.00137179"},
        {"Smithsonian Astrophysical Observation", "SAO 258730"},
    },
    visualMagnitude: 8.75,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.76680654),
        dec: Angle.Degrees(-83.23267466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130650"},
        {"Hipparcos Number", "HIP 73540"},
        {"Fundamental Katalog 5th Edition", "FK5 3987"},
        {"Geneva Identification System", "GEN# +1.00130650"},
        {"Smithsonian Astrophysical Observation", "SAO 258713"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.46126796),
        dec: Angle.Degrees(-83.22777573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150027"},
        {"Hipparcos Number", "HIP 82853"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.98867898),
        dec: Angle.Degrees(-83.21820845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201414"},
        {"Hipparcos Number", "HIP 105511"},
        {"Geneva Identification System", "GEN# +1.00201414"},
        {"Smithsonian Astrophysical Observation", "SAO 258891"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.55227600),
        dec: Angle.Degrees(-83.20955561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111643"},
        {"Hipparcos Number", "HIP 63002"},
        {"Smithsonian Astrophysical Observation", "SAO 258655"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.64769893),
        dec: Angle.Degrees(-83.17303323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36226"},
        {"Hipparcos Number", "HIP 24202"},
        {"Smithsonian Astrophysical Observation", "SAO 258406"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.93359122),
        dec: Angle.Degrees(-83.17138982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197909"},
        {"Hipparcos Number", "HIP 103679"},
        {"Smithsonian Astrophysical Observation", "SAO 258875"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.13509616),
        dec: Angle.Degrees(-83.14660137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2519"},
        {"Hipparcos Number", "HIP 2115"},
        {"Smithsonian Astrophysical Observation", "SAO 258225"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.71210029),
        dec: Angle.Degrees(-83.13913309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162402"},
        {"Hipparcos Number", "HIP 88950"},
        {"Smithsonian Astrophysical Observation", "SAO 258788"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.35262054),
        dec: Angle.Degrees(-83.13313707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108900"},
    },
    visualMagnitude: 12.05,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.89260728),
        dec: Angle.Degrees(-80.15972377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222513"},
        {"Hipparcos Number", "HIP 116982"},
        {"Smithsonian Astrophysical Observation", "SAO 258982"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.72644604),
        dec: Angle.Degrees(-83.13202265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126377"},
        {"Hipparcos Number", "HIP 71370"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.93960165),
        dec: Angle.Degrees(-83.12087706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27896"},
        {"Hipparcos Number", "HIP 19250"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.87594585),
        dec: Angle.Degrees(-83.11573691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93118"},
        {"Hipparcos Number", "HIP 52104"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.68942056),
        dec: Angle.Degrees(-83.10873654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -265.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 193.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101782"},
        {"Hipparcos Number", "HIP 56996"},
        {"Fundamental Katalog 5th Edition", "FK5 3982"},
        {"Geneva Identification System", "GEN# +1.00101782"},
        {"Smithsonian Astrophysical Observation", "SAO 258621"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.25665440),
        dec: Angle.Degrees(-83.09996178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205037"},
        {"Hipparcos Number", "HIP 107267"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.90099469),
        dec: Angle.Degrees(-83.07283070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25886"},
        {"Hipparcos Number", "HIP 17931"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.51773134),
        dec: Angle.Degrees(-83.07039462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20474"},
        {"Hipparcos Number", "HIP 14272"},
        {"Smithsonian Astrophysical Observation", "SAO 258327"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.99951872),
        dec: Angle.Degrees(-83.06900250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1525"},
        {"Hipparcos Number", "HIP 1452"},
        {"Renson", "Renson 310"},
        {"Smithsonian Astrophysical Observation", "SAO 258221"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.52345796),
        dec: Angle.Degrees(-83.06136375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18601"},
        {"Hipparcos Number", "HIP 12971"},
        {"Smithsonian Astrophysical Observation", "SAO 258315"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.71423750),
        dec: Angle.Degrees(-83.04250951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131246"},
        {"Hipparcos Number", "HIP 73771"},
        {"Geneva Identification System", "GEN# +1.00131246"},
        {"Smithsonian Astrophysical Observation", "SAO 258714"},
        {"Wilson Evans Batten Catalogue", "WEB 12608"},
    },
    visualMagnitude: 5.65,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.19567959),
        dec: Angle.Degrees(-83.03826851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203153"},
        {"Hipparcos Number", "HIP 106259"},
        {"Smithsonian Astrophysical Observation", "SAO 258901"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.84096412),
        dec: Angle.Degrees(-83.03368736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3988"},
        {"Hipparcos Number", "HIP 3087"},
        {"Renson", "Renson 1100"},
        {"Smithsonian Astrophysical Observation", "SAO 258235"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.81381032),
        dec: Angle.Degrees(-83.03290796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26208"},
        {"Hipparcos Number", "HIP 18157"},
        {"Smithsonian Astrophysical Observation", "SAO 258359"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.22730057),
        dec: Angle.Degrees(-83.02807694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223833"},
        {"Hipparcos Number", "HIP 117825"},
        {"Smithsonian Astrophysical Observation", "SAO 258992"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.45241190),
        dec: Angle.Degrees(-83.00696549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28940"},
        {"Hipparcos Number", "HIP 19955"},
        {"Smithsonian Astrophysical Observation", "SAO 258374"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.18991301),
        dec: Angle.Degrees(-82.99702037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138437"},
        {"Hipparcos Number", "HIP 77248"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.59962002),
        dec: Angle.Degrees(-82.99605661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224248"},
        {"Hipparcos Number", "HIP 118051"},
        {"Smithsonian Astrophysical Observation", "SAO 258994"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.18445513),
        dec: Angle.Degrees(-82.98410383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109153"},
        {"Hipparcos Number", "HIP 61395"},
        {"Geneva Identification System", "GEN# +1.00109153"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.71000612),
        dec: Angle.Degrees(-82.98026096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10800"},
        {"Hipparcos Number", "HIP 7601"},
        {"Geneva Identification System", "GEN# +1.00010800"},
        {"Smithsonian Astrophysical Observation", "SAO 258271"},
        {"Wilson Evans Batten Catalogue", "WEB 1626"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.47908355),
        dec: Angle.Degrees(-82.97528876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46978"},
        {"Hipparcos Number", "HIP 29960"},
        {"Geneva Identification System", "GEN# +1.00046978"},
        {"Smithsonian Astrophysical Observation", "SAO 258442"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.60642612),
        dec: Angle.Degrees(-82.97111685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15532"},
        {"Hipparcos Number", "HIP 10806"},
        {"Fundamental Katalog 5th Edition", "FK5 4215"},
        {"Smithsonian Astrophysical Observation", "SAO 258297"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.77630709),
        dec: Angle.Degrees(-82.95401718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113192"},
        {"Hipparcos Number", "HIP 63967"},
        {"Renson", "Renson 32860"},
        {"Smithsonian Astrophysical Observation", "SAO 258657"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.63398988),
        dec: Angle.Degrees(-82.95069773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184005"},
        {"Hipparcos Number", "HIP 97475"},
        {"Smithsonian Astrophysical Observation", "SAO 258837"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.17921168),
        dec: Angle.Degrees(-82.92672100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92745"},
        {"Hipparcos Number", "HIP 51925"},
        {"Smithsonian Astrophysical Observation", "SAO 258589"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.10394771),
        dec: Angle.Degrees(-82.92283279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121317"},
        {"Hipparcos Number", "HIP 68647"},
        {"Smithsonian Astrophysical Observation", "SAO 258686"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.77910218),
        dec: Angle.Degrees(-82.92055412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129652"},
        {"Hipparcos Number", "HIP 73013"},
        {"Geneva Identification System", "GEN# +1.00129652"},
        {"Smithsonian Astrophysical Observation", "SAO 258708"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.82084648),
        dec: Angle.Degrees(-82.91895432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90317"},
        {"Hipparcos Number", "HIP 50461"},
        {"Smithsonian Astrophysical Observation", "SAO 258569"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.54541803),
        dec: Angle.Degrees(-82.91073436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86660"},
        {"Hipparcos Number", "HIP 48294"},
        {"Geneva Identification System", "GEN# +1.00086660"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.70137008),
        dec: Angle.Degrees(-82.91026322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29598"},
        {"Hipparcos Number", "HIP 20446"},
        {"Fundamental Katalog 5th Edition", "FK5 1658"},
        {"Geneva Identification System", "GEN# +1.00029598"},
        {"Smithsonian Astrophysical Observation", "SAO 258379"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.71284366),
        dec: Angle.Degrees(-82.89908900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169166"},
        {"Hipparcos Number", "HIP 91619"},
        {"Smithsonian Astrophysical Observation", "SAO 258802"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.27583815),
        dec: Angle.Degrees(-82.89787983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52792"},
        {"Hipparcos Number", "HIP 32351"},
        {"Fundamental Katalog 5th Edition", "FK5 4614"},
        {"Geneva Identification System", "GEN# +1.00052792"},
        {"Smithsonian Astrophysical Observation", "SAO 258452"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.29137391),
        dec: Angle.Degrees(-82.89586643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80754"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.32377664),
        dec: Angle.Degrees(-82.88443126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49889"},
        {"Geneva Identification System", "GEN# +9.86017047"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.79718604),
        dec: Angle.Degrees(-82.86682216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -450.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 329.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80578"},
        {"Hipparcos Number", "HIP 44909"},
        {"Smithsonian Astrophysical Observation", "SAO 258519"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.22997820),
        dec: Angle.Degrees(-82.85470089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124639"},
        {"Hipparcos Number", "HIP 70418"},
        {"Geneva Identification System", "GEN# +1.00124639"},
        {"Smithsonian Astrophysical Observation", "SAO 258697"},
        {"Wilson Evans Batten Catalogue", "WEB 12221"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.09240580),
        dec: Angle.Degrees(-82.84822332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14223"},
    },
    visualMagnitude: 10.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.85281050),
        dec: Angle.Degrees(-82.84480525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 376.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 245.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213555"},
        {"Hipparcos Number", "HIP 111825"},
        {"Fundamental Katalog 5th Edition", "FK5 5998"},
        {"Geneva Identification System", "GEN# +1.00213555"},
        {"Smithsonian Astrophysical Observation", "SAO 258936"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.75033293),
        dec: Angle.Degrees(-82.81383857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43642"},
        {"Hipparcos Number", "HIP 28363"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.88387248),
        dec: Angle.Degrees(-82.81189565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188206"},
        {"Hipparcos Number", "HIP 99318"},
        {"Geneva Identification System", "GEN# +1.00188206"},
        {"Smithsonian Astrophysical Observation", "SAO 258851"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.39492411),
        dec: Angle.Degrees(-82.80500136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85500"},
        {"Hipparcos Number", "HIP 47622"},
        {"Smithsonian Astrophysical Observation", "SAO 258545"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.66254854),
        dec: Angle.Degrees(-82.78851936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155454"},
        {"Hipparcos Number", "HIP 85530"},
        {"Smithsonian Astrophysical Observation", "SAO 258768"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.18327881),
        dec: Angle.Degrees(-82.77959567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108057"},
    },
    visualMagnitude: 12.02,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.39733237),
        dec: Angle.Degrees(-82.77874132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158787"},
        {"Hipparcos Number", "HIP 87165"},
        {"Geneva Identification System", "GEN# +1.00158787"},
        {"Smithsonian Astrophysical Observation", "SAO 258776"},
        {"Wilson Evans Batten Catalogue", "WEB 14704"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.13162339),
        dec: Angle.Degrees(-82.77435906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151325"},
        {"Hipparcos Number", "HIP 83439"},
        {"Smithsonian Astrophysical Observation", "SAO 258756"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.80586397),
        dec: Angle.Degrees(-82.76387023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207483"},
        {"Hipparcos Number", "HIP 108497"},
        {"Smithsonian Astrophysical Observation", "SAO 258918"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.69264187),
        dec: Angle.Degrees(-82.75317036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117924"},
        {"Hipparcos Number", "HIP 66707"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.10872203),
        dec: Angle.Degrees(-82.74639717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106149"},
        {"Hipparcos Number", "HIP 59624"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.40590859),
        dec: Angle.Degrees(-82.73710226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9429"},
    },
    visualMagnitude: 11.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)01, 07.4400),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)21, 01.900)
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
    primaryId: "HIP 88343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161352"},
        {"Hipparcos Number", "HIP 88343"},
        {"Smithsonian Astrophysical Observation", "SAO 258783"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.62116537),
        dec: Angle.Degrees(-82.73540283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110295"},
        {"Hipparcos Number", "HIP 62132"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.00369034),
        dec: Angle.Degrees(-82.73433350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113478"},
        {"Hipparcos Number", "HIP 64119"},
        {"Fundamental Katalog 5th Edition", "FK5 5162"},
        {"Geneva Identification System", "GEN# +1.00113478"},
        {"Smithsonian Astrophysical Observation", "SAO 258658"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.12304601),
        dec: Angle.Degrees(-82.72100157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206240"},
        {"Henry Draper 2", "HD 206241"},
        {"Hipparcos Number", "HIP 107843"},
        {"Geneva Identification System", "GEN# +1.00206240J"},
        {"Smithsonian Astrophysical Observation", "SAO 258914"},
        {"Wilson Evans Batten Catalogue", "WEB 19445"},
    },
    visualMagnitude: 5.27,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.72603561),
        dec: Angle.Degrees(-82.71882392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217010"},
        {"Hipparcos Number", "HIP 113807"},
        {"Geneva Identification System", "GEN# +1.00217010"},
        {"Smithsonian Astrophysical Observation", "SAO 258955"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.69506455),
        dec: Angle.Degrees(-82.70781063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 354.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215587"},
        {"Hipparcos Number", "HIP 112911"},
        {"Smithsonian Astrophysical Observation", "SAO 258948"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.99036434),
        dec: Angle.Degrees(-82.70205494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2031"},
        {"Hipparcos Number", "HIP 1806"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.73090555),
        dec: Angle.Degrees(-82.68350013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203532"},
        {"Hipparcos Number", "HIP 106474"},
        {"Fundamental Katalog 5th Edition", "FK5 3995"},
        {"Geneva Identification System", "GEN# +1.00203532"},
        {"Smithsonian Astrophysical Observation", "SAO 258902"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.47696549),
        dec: Angle.Degrees(-82.68307834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129332"},
        {"Hipparcos Number", "HIP 72825"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.28501677),
        dec: Angle.Degrees(-82.68243330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11715"},
        {"Hipparcos Number", "HIP 8291"},
        {"Geneva Identification System", "GEN# +1.00011715"},
        {"Smithsonian Astrophysical Observation", "SAO 258281"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.70584295),
        dec: Angle.Degrees(-82.67298535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4266"},
        {"Smithsonian Astrophysical Observation", "SAO 258246"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.63993371),
        dec: Angle.Degrees(-82.66931994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120213"},
        {"Hipparcos Number", "HIP 68009"},
        {"Fundamental Katalog 5th Edition", "FK5 3986"},
        {"Geneva Identification System", "GEN# +1.00120213"},
        {"Smithsonian Astrophysical Observation", "SAO 258683"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.91245413),
        dec: Angle.Degrees(-82.66613365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138019"},
        {"Hipparcos Number", "HIP 76966"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.73927225),
        dec: Angle.Degrees(-82.66274611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208929"},
        {"Hipparcos Number", "HIP 109280"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.07614995),
        dec: Angle.Degrees(-82.63394759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210659"},
        {"Hipparcos Number", "HIP 110231"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.93686200),
        dec: Angle.Degrees(-82.63185875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185079"},
        {"Hipparcos Number", "HIP 97855"},
        {"Smithsonian Astrophysical Observation", "SAO 258842"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.29396837),
        dec: Angle.Degrees(-82.63128550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74763"},
        {"Hipparcos Number", "HIP 41910"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.17907256),
        dec: Angle.Degrees(-82.61448070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28017"},
        {"Hipparcos Number", "HIP 19437"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.43260776),
        dec: Angle.Degrees(-82.59106897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44554"},
        {"Hipparcos Number", "HIP 28837"},
        {"Smithsonian Astrophysical Observation", "SAO 258433"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.30434688),
        dec: Angle.Degrees(-82.58956157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31037"},
        {"Hipparcos Number", "HIP 21455"},
        {"Geneva Identification System", "GEN# +1.00031037"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.10736380),
        dec: Angle.Degrees(-82.58251749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 147.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64723"},
        {"Hipparcos Number", "HIP 37356"},
        {"Smithsonian Astrophysical Observation", "SAO 258478"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.01612087),
        dec: Angle.Degrees(-82.58162778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95709"},
        {"Hipparcos Number", "HIP 53629"},
        {"Smithsonian Astrophysical Observation", "SAO 258598"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.57189342),
        dec: Angle.Degrees(-82.58055475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75001"},
        {"Hipparcos Number", "HIP 42059"},
        {"Geneva Identification System", "GEN# +1.00075001"},
        {"Renson", "Renson 20970"},
        {"Smithsonian Astrophysical Observation", "SAO 258500"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.59713760),
        dec: Angle.Degrees(-82.56688032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145621"},
        {"Hipparcos Number", "HIP 80567"},
        {"Fundamental Katalog 5th Edition", "FK5 3988"},
        {"Smithsonian Astrophysical Observation", "SAO 258741"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.75340036),
        dec: Angle.Degrees(-82.55986239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104433"},
        {"Hipparcos Number", "HIP 58623"},
        {"Smithsonian Astrophysical Observation", "SAO 258631"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.33286958),
        dec: Angle.Degrees(-82.55643418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15161"},
        {"Hipparcos Number", "HIP 10594"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.09920759),
        dec: Angle.Degrees(-82.55417351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173661"},
        {"Hipparcos Number", "HIP 93544"},
        {"Geneva Identification System", "GEN# +1.00173661"},
        {"Smithsonian Astrophysical Observation", "SAO 258817"},
        {"Wilson Evans Batten Catalogue", "WEB 16242"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.78472850),
        dec: Angle.Degrees(-82.55344695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7654"},
        {"Hipparcos Number", "HIP 5549"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.79328601),
        dec: Angle.Degrees(-82.54833799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103963"},
        {"Hipparcos Number", "HIP 58361"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.50763394),
        dec: Angle.Degrees(-82.52338424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31932"},
        {"Hipparcos Number", "HIP 21967"},
        {"Smithsonian Astrophysical Observation", "SAO 258388"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.82699667),
        dec: Angle.Degrees(-82.51988037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99927"},
        {"Hipparcos Number", "HIP 55876"},
        {"Smithsonian Astrophysical Observation", "SAO 258612"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.80001068),
        dec: Angle.Degrees(-82.51724548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149905"},
        {"Hipparcos Number", "HIP 82619"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.35032532),
        dec: Angle.Degrees(-82.51186456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13255"},
        {"Hipparcos Number", "HIP 9386"},
        {"Fundamental Katalog 5th Edition", "FK5 3974"},
        {"Geneva Identification System", "GEN# +1.00013255"},
        {"Smithsonian Astrophysical Observation", "SAO 258287"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.15564490),
        dec: Angle.Degrees(-82.50856293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88369"},
        {"Hipparcos Number", "HIP 49261"},
        {"Fundamental Katalog 5th Edition", "FK5 4891"},
        {"Smithsonian Astrophysical Observation", "SAO 258560"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.84122804),
        dec: Angle.Degrees(-82.50830999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222669"},
        {"Hipparcos Number", "HIP 117066"},
        {"Fundamental Katalog 5th Edition", "FK5 6102"},
        {"Geneva Identification System", "GEN# +1.00222669"},
        {"Smithsonian Astrophysical Observation", "SAO 258983"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.99140547),
        dec: Angle.Degrees(-82.50827822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4946"},
        {"Hipparcos Number", "HIP 3716"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.92492045),
        dec: Angle.Degrees(-82.50749500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164920"},
        {"Hipparcos Number", "HIP 89876"},
        {"Smithsonian Astrophysical Observation", "SAO 258790"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.10231953),
        dec: Angle.Degrees(-82.50541930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174341"},
        {"Hipparcos Number", "HIP 93834"},
        {"Geneva Identification System", "GEN# +1.00174341"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.64132390),
        dec: Angle.Degrees(-82.49245992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22237"},
        {"Hipparcos Number", "HIP 15645"},
        {"Geneva Identification System", "GEN# +1.00022237"},
        {"Smithsonian Astrophysical Observation", "SAO 258336"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.35323489),
        dec: Angle.Degrees(-82.47808468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33214"},
        {"Hipparcos Number", "HIP 22646"},
        {"Geneva Identification System", "GEN# +1.00033214"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.08382327),
        dec: Angle.Degrees(-82.47637139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 150.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15859"},
        {"Hipparcos Number", "HIP 11084"},
        {"Smithsonian Astrophysical Observation", "SAO 258300"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.68773119),
        dec: Angle.Degrees(-82.47609129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34172"},
        {"Hipparcos Number", "HIP 23148"},
        {"Fundamental Katalog 5th Edition", "FK5 917"},
        {"Geneva Identification System", "GEN# +1.00034172"},
        {"Smithsonian Astrophysical Observation", "SAO 258395"},
        {"Wilson Evans Batten Catalogue", "WEB 4490"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.71244667),
        dec: Angle.Degrees(-82.47052255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206096"},
        {"Hipparcos Number", "HIP 107747"},
        {"Fundamental Katalog 5th Edition", "FK5 3996"},
        {"Geneva Identification System", "GEN# +1.00206096"},
        {"Smithsonian Astrophysical Observation", "SAO 258912"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.40107072),
        dec: Angle.Degrees(-82.43387561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156983"},
        {"Hipparcos Number", "HIP 86210"},
        {"Smithsonian Astrophysical Observation", "SAO 258771"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.25857963),
        dec: Angle.Degrees(-82.43042777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41217"},
        {"Hipparcos Number", "HIP 27279"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.71554314),
        dec: Angle.Degrees(-82.42828951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92817"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.68832434),
        dec: Angle.Degrees(-82.41805155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -351.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83885"},
        {"Hipparcos Number", "HIP 46742"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.90798979),
        dec: Angle.Degrees(-82.41212203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223127"},
        {"Hipparcos Number", "HIP 117381"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.00135300),
        dec: Angle.Degrees(-82.41169610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11799"},
        {"Hipparcos Number", "HIP 8374"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.96742977),
        dec: Angle.Degrees(-82.40607989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153014"},
        {"Hipparcos Number", "HIP 84219"},
        {"Geneva Identification System", "GEN# +1.00153014"},
        {"Smithsonian Astrophysical Observation", "SAO 258763"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.22735530),
        dec: Angle.Degrees(-82.38812855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31931"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.09518606),
        dec: Angle.Degrees(-82.38073112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 281.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36064"},
        {"Hipparcos Number", "HIP 24276"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.15062561),
        dec: Angle.Degrees(-82.36827960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65001"},
        {"Hipparcos Number", "HIP 37512"},
        {"Fundamental Katalog 5th Edition", "FK5 4694"},
        {"Smithsonian Astrophysical Observation", "SAO 258480"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.48437477),
        dec: Angle.Degrees(-82.34175858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26017"},
        {"Hipparcos Number", "HIP 18136"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.16098936),
        dec: Angle.Degrees(-82.33098471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80258"},
        {"Hipparcos Number", "HIP 44800"},
        {"Fundamental Katalog 5th Edition", "FK5 3979"},
        {"Geneva Identification System", "GEN# +1.00080258"},
        {"Smithsonian Astrophysical Observation", "SAO 258518"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.94593413),
        dec: Angle.Degrees(-82.32486753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152565"},
        {"Hipparcos Number", "HIP 83972"},
        {"Smithsonian Astrophysical Observation", "SAO 258760"},
    },
    visualMagnitude: 7.17,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.46519292),
        dec: Angle.Degrees(-82.31860114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24009"},
        {"Hipparcos Number", "HIP 16768"},
        {"Smithsonian Astrophysical Observation", "SAO 258345"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.94206643),
        dec: Angle.Degrees(-82.31400011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13713"},
        {"Hipparcos Number", "HIP 9697"},
        {"Smithsonian Astrophysical Observation", "SAO 258290"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.18284953),
        dec: Angle.Degrees(-82.29944426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12970"},
        {"Hipparcos Number", "HIP 9191"},
        {"Smithsonian Astrophysical Observation", "SAO 258286"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.58657437),
        dec: Angle.Degrees(-82.29408096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96177"},
        {"Hipparcos Number", "HIP 53871"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.32096709),
        dec: Angle.Degrees(-82.29280206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193887"},
        {"Hipparcos Number", "HIP 101628"},
        {"Smithsonian Astrophysical Observation", "SAO 258862"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.97627085),
        dec: Angle.Degrees(-82.29059070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10693"},
        {"Hipparcos Number", "HIP 7560"},
        {"Smithsonian Astrophysical Observation", "SAO 258270"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.34757533),
        dec: Angle.Degrees(-82.28174482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53873",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53873"},
    },
    visualMagnitude: 11.67,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.33069444),
        dec: Angle.Degrees(-23.86766127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -383.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 203.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196176"},
        {"Hipparcos Number", "HIP 102695"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.12502965),
        dec: Angle.Degrees(-82.26866498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22056"},
        {"Hipparcos Number", "HIP 15540"},
        {"Geneva Identification System", "GEN# +1.00022056"},
        {"Smithsonian Astrophysical Observation", "SAO 258335"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.05007406),
        dec: Angle.Degrees(-82.26499489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83563"},
        {"Hipparcos Number", "HIP 46557"},
        {"Smithsonian Astrophysical Observation", "SAO 258536"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.41757063),
        dec: Angle.Degrees(-82.26331034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196487"},
        {"Hipparcos Number", "HIP 102868"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.61417853),
        dec: Angle.Degrees(-82.26307851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104903"},
        {"Hipparcos Number", "HIP 58911"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.20663281),
        dec: Angle.Degrees(-82.25516180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62806"},
        {"Hipparcos Number", "HIP 36543"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.75035394),
        dec: Angle.Degrees(-82.25159882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17216"},
        {"Hipparcos Number", "HIP 12018"},
        {"Geneva Identification System", "GEN# +1.00017216"},
        {"Smithsonian Astrophysical Observation", "SAO 258306"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.75706006),
        dec: Angle.Degrees(-82.23573643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 636"},
        {"Hipparcos Number", "HIP 814"},
        {"Fundamental Katalog 5th Edition", "FK5 3971"},
        {"Geneva Identification System", "GEN# +1.00000636"},
        {"Smithsonian Astrophysical Observation", "SAO 258215"},
        {"Wilson Evans Batten Catalogue", "WEB 139"},
    },
    visualMagnitude: 5.29,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.50945435),
        dec: Angle.Degrees(-82.22399743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124862"},
        {"Hipparcos Number", "HIP 70479"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.23966489),
        dec: Angle.Degrees(-82.22061073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158866"},
        {"Hipparcos Number", "HIP 87091"},
        {"Geneva Identification System", "GEN# +1.00158866"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.92856000),
        dec: Angle.Degrees(-82.21593780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87971"},
        {"Hipparcos Number", "HIP 49065"},
        {"Fundamental Katalog 5th Edition", "FK5 3980"},
        {"Geneva Identification System", "GEN# +1.00087971"},
        {"Smithsonian Astrophysical Observation", "SAO 258554"},
        {"Wilson Evans Batten Catalogue", "WEB 9099"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.18293561),
        dec: Angle.Degrees(-82.21474569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56531"},
    },
    visualMagnitude: 11.17,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.87043933),
        dec: Angle.Degrees(-82.20860337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201292"},
        {"Hipparcos Number", "HIP 105307"},
        {"Smithsonian Astrophysical Observation", "SAO 258889"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.93361493),
        dec: Angle.Degrees(-82.20539728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52677"},
        {"Hipparcos Number", "HIP 32460"},
        {"Geneva Identification System", "GEN# +1.00052677"},
        {"Smithsonian Astrophysical Observation", "SAO 258453"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.62382938),
        dec: Angle.Degrees(-82.18542358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209958"},
        {"Hipparcos Number", "HIP 109845"},
        {"Smithsonian Astrophysical Observation", "SAO 258925"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.70509197),
        dec: Angle.Degrees(-82.18256794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224362"},
        {"Hipparcos Number", "HIP 118114"},
        {"Geneva Identification System", "GEN# +1.00224362"},
        {"Smithsonian Astrophysical Observation", "SAO 258996"},
        {"Wilson Evans Batten Catalogue", "WEB 20766"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.38745413),
        dec: Angle.Degrees(-82.16974335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185191"},
        {"Hipparcos Number", "HIP 97813"},
        {"Smithsonian Astrophysical Observation", "SAO 258841"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.14814532),
        dec: Angle.Degrees(-82.16163163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45040"},
        {"Hipparcos Number", "HIP 29155"},
        {"Smithsonian Astrophysical Observation", "SAO 258438"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.25437014),
        dec: Angle.Degrees(-82.15758903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206065"},
        {"Hipparcos Number", "HIP 107689"},
        {"Smithsonian Astrophysical Observation", "SAO 258909"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.22422425),
        dec: Angle.Degrees(-82.12391854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79124"},
        {"Hipparcos Number", "HIP 44288"},
        {"Smithsonian Astrophysical Observation", "SAO 258514"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.29585076),
        dec: Angle.Degrees(-82.11505829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57002"},
        {"Hipparcos Number", "HIP 34084"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.01594661),
        dec: Angle.Degrees(-82.11234702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160581"},
        {"Hipparcos Number", "HIP 87843"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.18407931),
        dec: Angle.Degrees(-82.06901010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128077"},
        {"Hipparcos Number", "HIP 72081"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.18331403),
        dec: Angle.Degrees(-82.05769688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44828"},
        {"Hipparcos Number", "HIP 29076"},
        {"Fundamental Katalog 5th Edition", "FK5 3977"},
        {"Geneva Identification System", "GEN# +1.00044828"},
        {"Smithsonian Astrophysical Observation", "SAO 258437"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.00464305),
        dec: Angle.Degrees(-82.04374992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116939"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.56110247),
        dec: Angle.Degrees(-82.04353985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 260.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110218"},
        {"Hipparcos Number", "HIP 62065"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.80663156),
        dec: Angle.Degrees(-82.04243167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9745"},
        {"Hipparcos Number", "HIP 6916"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.26497906),
        dec: Angle.Degrees(-82.03916799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93486"},
        {"Hipparcos Number", "HIP 52381"},
        {"Geneva Identification System", "GEN# +1.00093486"},
        {"Smithsonian Astrophysical Observation", "SAO 258590"},
        {"Wilson Evans Batten Catalogue", "WEB 9533"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.60070257),
        dec: Angle.Degrees(-82.03716124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32860"},
        {"Hipparcos Number", "HIP 22518"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.68325295),
        dec: Angle.Degrees(-82.03251367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189310"},
        {"Hipparcos Number", "HIP 99634"},
        {"Geneva Identification System", "GEN# +1.00189310"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.31695679),
        dec: Angle.Degrees(-82.02809545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199509"},
        {"Hipparcos Number", "HIP 104436"},
        {"Geneva Identification System", "GEN# +1.00199509"},
        {"Smithsonian Astrophysical Observation", "SAO 258880"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.33177202),
        dec: Angle.Degrees(-82.02714188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 264.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223647"},
        {"Hipparcos Number", "HIP 117689"},
        {"Fundamental Katalog 5th Edition", "FK5 3997"},
        {"Geneva Identification System", "GEN# +1.00223647"},
        {"Smithsonian Astrophysical Observation", "SAO 258989"},
        {"Wilson Evans Batten Catalogue", "WEB 20711"},
    },
    visualMagnitude: 5.10,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.02789102),
        dec: Angle.Degrees(-82.01876765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69681"},
        {"Hipparcos Number", "HIP 39529"},
        {"Smithsonian Astrophysical Observation", "SAO 258492"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.17865929),
        dec: Angle.Degrees(-81.99394158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44313"},
        {"Hipparcos Number", "HIP 28849"},
        {"Fundamental Katalog 5th Edition", "FK5 4554"},
        {"Smithsonian Astrophysical Observation", "SAO 258432"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.34943389),
        dec: Angle.Degrees(-81.99073440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65517"},
        {"Hipparcos Number", "HIP 37817"},
        {"Smithsonian Astrophysical Observation", "SAO 258483"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.31024834),
        dec: Angle.Degrees(-81.96749301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202680"},
        {"Hipparcos Number", "HIP 105973"},
        {"Geneva Identification System", "GEN# +1.00202680"},
        {"Smithsonian Astrophysical Observation", "SAO 258898"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.94360016),
        dec: Angle.Degrees(-81.96552270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145990"},
        {"Hipparcos Number", "HIP 80624"},
        {"Smithsonian Astrophysical Observation", "SAO 258742"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.94348010),
        dec: Angle.Degrees(-81.96127313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203853"},
        {"Hipparcos Number", "HIP 106553"},
        {"Smithsonian Astrophysical Observation", "SAO 258905"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.69475196),
        dec: Angle.Degrees(-81.92684235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220866"},
        {"Hipparcos Number", "HIP 115970"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.44711758),
        dec: Angle.Degrees(-81.92549356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143740"},
        {"Hipparcos Number", "HIP 79680"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.93382725),
        dec: Angle.Degrees(-81.92165180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92029"},
        {"Hipparcos Number", "HIP 51557"},
        {"Geneva Identification System", "GEN# +1.00092029A"},
        {"Smithsonian Astrophysical Observation", "SAO 258581"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.96562563),
        dec: Angle.Degrees(-81.92110161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117857"},
        {"Hipparcos Number", "HIP 66597"},
        {"Smithsonian Astrophysical Observation", "SAO 258677"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.76426147),
        dec: Angle.Degrees(-81.90860194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19918"},
        {"Hipparcos Number", "HIP 14026"},
        {"Renson", "Renson 4930"},
        {"Smithsonian Astrophysical Observation", "SAO 258324"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.15498622),
        dec: Angle.Degrees(-81.90198824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87160"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.09881707),
        dec: Angle.Degrees(-81.89550929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134867"},
        {"Hipparcos Number", "HIP 75341"},
        {"Smithsonian Astrophysical Observation", "SAO 258725"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.92847944),
        dec: Angle.Degrees(-81.88493511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19424"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)09, 35.7000),
        dec: Angle.DegreesMinutesSeconds((int)-81, (int)51, 18.200)
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
    primaryId: "HIP 72837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129598"},
        {"Hipparcos Number", "HIP 72837"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.32455173),
        dec: Angle.Degrees(-81.85060715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121456"},
        {"Hipparcos Number", "HIP 68616"},
        {"Geneva Identification System", "GEN# +1.00121456"},
        {"Smithsonian Astrophysical Observation", "SAO 258687"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.69480419),
        dec: Angle.Degrees(-81.85025610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164134"},
        {"Hipparcos Number", "HIP 89434"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.79342469),
        dec: Angle.Degrees(-81.84212228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83237"},
        {"Hipparcos Number", "HIP 46399"},
        {"Smithsonian Astrophysical Observation", "SAO 258533"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.92467039),
        dec: Angle.Degrees(-81.84037088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87369"},
        {"Hipparcos Number", "HIP 48775"},
        {"Smithsonian Astrophysical Observation", "SAO 258553"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.22447868),
        dec: Angle.Degrees(-81.83656951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169904"},
        {"Hipparcos Number", "HIP 91723"},
        {"Geneva Identification System", "GEN# +1.00169904"},
        {"Smithsonian Astrophysical Observation", "SAO 258804"},
        {"Wilson Evans Batten Catalogue", "WEB 15774"},
    },
    visualMagnitude: 6.27,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.55983879),
        dec: Angle.Degrees(-81.80807287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178026"},
        {"Hipparcos Number", "HIP 95189"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.46264214),
        dec: Angle.Degrees(-81.79493043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123062"},
        {"Hipparcos Number", "HIP 69473"},
        {"Smithsonian Astrophysical Observation", "SAO 258692"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.34321099),
        dec: Angle.Degrees(-81.79102243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24492"},
        {"Hipparcos Number", "HIP 17184"},
        {"Geneva Identification System", "GEN# +1.00024492"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.20112570),
        dec: Angle.Degrees(-81.78962263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 201.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29244"},
        {"Hipparcos Number", "HIP 20382"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.47073249),
        dec: Angle.Degrees(-81.77925106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118863"},
        {"Hipparcos Number", "HIP 67146"},
        {"Smithsonian Astrophysical Observation", "SAO 258679"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.40847892),
        dec: Angle.Degrees(-81.77902420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25612"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.07682229),
        dec: Angle.Degrees(-81.77430687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -441.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80913"},
        {"Hipparcos Number", "HIP 45183"},
        {"Geneva Identification System", "GEN# +1.00080913"},
        {"Smithsonian Astrophysical Observation", "SAO 258522"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.10591262),
        dec: Angle.Degrees(-81.76861094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19596"},
        {"Hipparcos Number", "HIP 13839"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.53611492),
        dec: Angle.Degrees(-81.76123667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181466"},
        {"Hipparcos Number", "HIP 96314"},
        {"Fundamental Katalog 5th Edition", "FK5 3993"},
        {"Smithsonian Astrophysical Observation", "SAO 258833"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.74889654),
        dec: Angle.Degrees(-81.75296725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21884"},
        {"Hipparcos Number", "HIP 15470"},
        {"Smithsonian Astrophysical Observation", "SAO 258334"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.86750710),
        dec: Angle.Degrees(-81.75127312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84525"},
        {"Hipparcos Number", "HIP 47203"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.30000639),
        dec: Angle.Degrees(-81.74725242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137144"},
        {"Hipparcos Number", "HIP 76391"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.03376615),
        dec: Angle.Degrees(-81.72614150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84698"},
        {"Hipparcos Number", "HIP 47299"},
        {"Smithsonian Astrophysical Observation", "SAO 258543"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.58867278),
        dec: Angle.Degrees(-81.70938825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50129"},
        {"Hipparcos Number", "HIP 31601"},
        {"Smithsonian Astrophysical Observation", "SAO 258449"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.20930466),
        dec: Angle.Degrees(-81.67896777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83726"},
        {"Hipparcos Number", "HIP 46731"},
        {"Smithsonian Astrophysical Observation", "SAO 258537"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.87926764),
        dec: Angle.Degrees(-81.67472352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7101"},
        {"Hipparcos Number", "HIP 5228"},
        {"Smithsonian Astrophysical Observation", "SAO 258257"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.71174805),
        dec: Angle.Degrees(-81.64877169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90438"},
        {"Hipparcos Number", "HIP 50607"},
        {"Fundamental Katalog 5th Edition", "FK5 3981"},
        {"Geneva Identification System", "GEN# +1.00090438"},
        {"Smithsonian Astrophysical Observation", "SAO 258570"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.06216776),
        dec: Angle.Degrees(-81.64851754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60573"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.24627699),
        dec: Angle.Degrees(-81.64457123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46100"},
        {"Hipparcos Number", "HIP 29792"},
        {"Geneva Identification System", "GEN# +1.00046100"},
        {"Smithsonian Astrophysical Observation", "SAO 258441"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.08865887),
        dec: Angle.Degrees(-81.63404125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96417"},
        {"Hipparcos Number", "HIP 54017"},
        {"Geneva Identification System", "GEN# +1.00096417"},
        {"Smithsonian Astrophysical Observation", "SAO 258601"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.76056235),
        dec: Angle.Degrees(-81.62184094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92091"},
        {"Hipparcos Number", "HIP 51605"},
        {"Smithsonian Astrophysical Observation", "SAO 258583"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.12366692),
        dec: Angle.Degrees(-81.61581544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191122"},
        {"Hipparcos Number", "HIP 100359"},
        {"Fundamental Katalog 5th Edition", "FK5 5792"},
        {"Geneva Identification System", "GEN# +1.00191122"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.30337899),
        dec: Angle.Degrees(-81.61550381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1783"},
        {"Hipparcos Number", "HIP 1665"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.21452045),
        dec: Angle.Degrees(-81.61207550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39197"},
        {"Hipparcos Number", "HIP 26269"},
        {"Fundamental Katalog 5th Edition", "FK5 4506"},
        {"Geneva Identification System", "GEN# +1.00039197"},
        {"Smithsonian Astrophysical Observation", "SAO 258420"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.91474297),
        dec: Angle.Degrees(-81.61194305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156191"},
        {"Hipparcos Number", "HIP 85714"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.72864175),
        dec: Angle.Degrees(-81.61155145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70104"},
        {"Hipparcos Number", "HIP 39772"},
        {"Fundamental Katalog 5th Edition", "FK5 4729"},
        {"Smithsonian Astrophysical Observation", "SAO 258493"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.92424730),
        dec: Angle.Degrees(-81.60943106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65836"},
        {"Hipparcos Number", "HIP 38017"},
        {"Fundamental Katalog 5th Edition", "FK5 3978"},
        {"Renson", "Renson 18040"},
        {"Smithsonian Astrophysical Observation", "SAO 258485"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.87726362),
        dec: Angle.Degrees(-81.59653504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150140"},
        {"Hipparcos Number", "HIP 82592"},
        {"Smithsonian Astrophysical Observation", "SAO 258752"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.26332214),
        dec: Angle.Degrees(-81.59455615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37909"},
        {"Hipparcos Number", "HIP 25472"},
        {"Geneva Identification System", "GEN# +1.00037909"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.70744051),
        dec: Angle.Degrees(-81.58555110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29116"},
        {"Hipparcos Number", "HIP 20297"},
        {"Geneva Identification System", "GEN# +1.00029116"},
        {"Renson", "Renson 7440"},
        {"Smithsonian Astrophysical Observation", "SAO 258378"},
        {"Wilson Evans Batten Catalogue", "WEB 3881"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.24179812),
        dec: Angle.Degrees(-81.58022679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98364"},
        {"Hipparcos Number", "HIP 55035"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.99392164),
        dec: Angle.Degrees(-81.57024457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186992"},
        {"Hipparcos Number", "HIP 98531"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.25075305),
        dec: Angle.Degrees(-81.56826463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88351"},
        {"Hipparcos Number", "HIP 49326"},
        {"Geneva Identification System", "GEN# +1.00088351"},
        {"Smithsonian Astrophysical Observation", "SAO 258561"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.03070622),
        dec: Angle.Degrees(-81.56562097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95788"},
        {"Hipparcos Number", "HIP 53700"},
        {"Geneva Identification System", "GEN# +1.00095788J"},
        {"Smithsonian Astrophysical Observation", "SAO 258599"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.80788715),
        dec: Angle.Degrees(-81.55632816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15681"},
        {"Hipparcos Number", "HIP 11039"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.53129812),
        dec: Angle.Degrees(-81.55085323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218077"},
        {"Hipparcos Number", "HIP 114281"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.20161372),
        dec: Angle.Degrees(-81.54341466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35798"},
        {"Hipparcos Number", "HIP 24256"},
        {"Fundamental Katalog 5th Edition", "FK5 3976"},
        {"Geneva Identification System", "GEN# +1.00035798"},
        {"Smithsonian Astrophysical Observation", "SAO 258405"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.10705724),
        dec: Angle.Degrees(-81.54185362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123029"},
        {"Hipparcos Number", "HIP 69422"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.21672231),
        dec: Angle.Degrees(-81.54180018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8259"},
        {"Hipparcos Number", "HIP 5964"},
        {"Smithsonian Astrophysical Observation", "SAO 258262"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.17819849),
        dec: Angle.Degrees(-81.54089529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178737"},
        {"Hipparcos Number", "HIP 95344"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.95552027),
        dec: Angle.Degrees(-81.54026123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141824"},
        {"Hipparcos Number", "HIP 78677"},
        {"Smithsonian Astrophysical Observation", "SAO 258735"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.92469549),
        dec: Angle.Degrees(-81.53826217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180965"},
        {"Hipparcos Number", "HIP 96128"},
        {"Geneva Identification System", "GEN# +1.00180965"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.17878716),
        dec: Angle.Degrees(-81.53039616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194277"},
        {"Hipparcos Number", "HIP 101697"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.19738665),
        dec: Angle.Degrees(-81.53013629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140790"},
        {"Hipparcos Number", "HIP 78179"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.44512642),
        dec: Angle.Degrees(-81.52505218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31628"},
        {"Hipparcos Number", "HIP 21945"},
        {"Smithsonian Astrophysical Observation", "SAO 258387"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.75298977),
        dec: Angle.Degrees(-81.50433824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56861"},
        {"Hipparcos Number", "HIP 34132"},
        {"Smithsonian Astrophysical Observation", "SAO 258464"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.15876929),
        dec: Angle.Degrees(-81.49971261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12681"},
        {"Hipparcos Number", "HIP 9052"},
        {"Geneva Identification System", "GEN# +1.00012681"},
        {"Smithsonian Astrophysical Observation", "SAO 258284"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.15634973),
        dec: Angle.Degrees(-81.49928857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110247"},
        {"Hipparcos Number", "HIP 62060"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.79934259),
        dec: Angle.Degrees(-81.49793840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17020"},
        {"Hipparcos Number", "HIP 11957"},
        {"Geneva Identification System", "GEN# +1.00017020"},
        {"Smithsonian Astrophysical Observation", "SAO 258305"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.56520088),
        dec: Angle.Degrees(-81.49664680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162337"},
        {"Hipparcos Number", "HIP 88599"},
        {"Fundamental Katalog 5th Edition", "FK5 3990"},
        {"Geneva Identification System", "GEN# +1.00162337"},
        {"Smithsonian Astrophysical Observation", "SAO 258787"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.36143072),
        dec: Angle.Degrees(-81.48644851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17440"},
        {"Hipparcos Number", "HIP 12271"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.49905116),
        dec: Angle.Degrees(-81.46744393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127736"},
        {"Hipparcos Number", "HIP 71883"},
        {"Smithsonian Astrophysical Observation", "SAO 258705"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.54058972),
        dec: Angle.Degrees(-81.46213259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50418"},
        {"Hipparcos Number", "HIP 31772"},
        {"Smithsonian Astrophysical Observation", "SAO 258450"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.66572247),
        dec: Angle.Degrees(-81.45903051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161071"},
        {"Hipparcos Number", "HIP 87968"},
        {"Geneva Identification System", "GEN# +1.00161071"},
        {"Smithsonian Astrophysical Observation", "SAO 258782"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.53902570),
        dec: Angle.Degrees(-81.45312267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125271"},
        {"Hipparcos Number", "HIP 70610"},
        {"Geneva Identification System", "GEN# +1.00125271"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.64925795),
        dec: Angle.Degrees(-81.45276725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55110"},
    },
    visualMagnitude: 11.25,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.26068349),
        dec: Angle.Degrees(-81.45250141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151553"},
        {"Hipparcos Number", "HIP 83344"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.50431243),
        dec: Angle.Degrees(-81.43466924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100484"},
        {"Hipparcos Number", "HIP 56256"},
        {"Renson", "Renson 28880"},
        {"Smithsonian Astrophysical Observation", "SAO 258614"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.96922088),
        dec: Angle.Degrees(-81.42918048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163283"},
        {"Hipparcos Number", "HIP 89009"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.49671050),
        dec: Angle.Degrees(-81.41741466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175862"},
        {"Hipparcos Number", "HIP 94304"},
        {"Geneva Identification System", "GEN# +1.00175862"},
        {"Smithsonian Astrophysical Observation", "SAO 258821"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.92480749),
        dec: Angle.Degrees(-81.41292339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199066"},
        {"Hipparcos Number", "HIP 104098"},
        {"Smithsonian Astrophysical Observation", "SAO 258877"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.34798243),
        dec: Angle.Degrees(-81.39682310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28125"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.17691068),
        dec: Angle.Degrees(-81.38724543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 342.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178712"},
        {"Hipparcos Number", "HIP 95335"},
        {"Smithsonian Astrophysical Observation", "SAO 258828"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.93237700),
        dec: Angle.Degrees(-81.38216610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214846"},
        {"Hipparcos Number", "HIP 112405"},
        {"Fundamental Katalog 5th Edition", "FK5 924"},
        {"Geneva Identification System", "GEN# +1.00214846"},
        {"Smithsonian Astrophysical Observation", "SAO 258941"},
        {"Wilson Evans Batten Catalogue", "WEB 20051"},
    },
    visualMagnitude: 4.13,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.51551393),
        dec: Angle.Degrees(-81.38161731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114859"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.98088423),
        dec: Angle.Degrees(-81.37284402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 504.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11864"},
        {"Hipparcos Number", "HIP 8499"},
        {"Smithsonian Astrophysical Observation", "SAO 258282"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.39938100),
        dec: Angle.Degrees(-81.35902083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186154"},
        {"Hipparcos Number", "HIP 98086"},
        {"Fundamental Katalog 5th Edition", "FK5 1667"},
        {"Geneva Identification System", "GEN# +1.00186154"},
        {"Smithsonian Astrophysical Observation", "SAO 258844"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.00675249),
        dec: Angle.Degrees(-81.34983861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103560"},
        {"Hipparcos Number", "HIP 58104"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.75195674),
        dec: Angle.Degrees(-81.34882878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225254"},
        {"Hipparcos Number", "HIP 367"},
        {"Smithsonian Astrophysical Observation", "SAO 258209"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.15561443),
        dec: Angle.Degrees(-81.34531911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204581"},
        {"Hipparcos Number", "HIP 106846"},
        {"Smithsonian Astrophysical Observation", "SAO 258907"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.61444989),
        dec: Angle.Degrees(-81.34107083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -328.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200463"},
        {"Hipparcos Number", "HIP 104796"},
        {"Smithsonian Astrophysical Observation", "SAO 258882"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.45639684),
        dec: Angle.Degrees(-81.33835817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112494"},
        {"Hipparcos Number", "HIP 63483"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.11362833),
        dec: Angle.Degrees(-81.33412050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152760"},
        {"Hipparcos Number", "HIP 83924"},
        {"Smithsonian Astrophysical Observation", "SAO 258762"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.29292785),
        dec: Angle.Degrees(-81.32311330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115674"},
        {"Hipparcos Number", "HIP 65302"},
        {"Geneva Identification System", "GEN# +1.00115674"},
        {"Smithsonian Astrophysical Observation", "SAO 258663"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.75610475),
        dec: Angle.Degrees(-81.30975325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -360.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136437"},
        {"Hipparcos Number", "HIP 76030"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.92790863),
        dec: Angle.Degrees(-81.30307418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96675"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.81424112),
        dec: Angle.Degrees(-81.30258412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194612"},
        {"Hipparcos Number", "HIP 101843"},
        {"Geneva Identification System", "GEN# +1.00194612"},
        {"Smithsonian Astrophysical Observation", "SAO 258864"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.57752070),
        dec: Angle.Degrees(-81.28897011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171480"},
        {"Hipparcos Number", "HIP 92358"},
        {"Smithsonian Astrophysical Observation", "SAO 258809"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.34730084),
        dec: Angle.Degrees(-81.27076402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30133"},
        {"Hipparcos Number", "HIP 21101"},
        {"Smithsonian Astrophysical Observation", "SAO 258380"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.81763222),
        dec: Angle.Degrees(-81.26585925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15803"},
    },
    visualMagnitude: 11.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.90253585),
        dec: Angle.Degrees(-81.25951257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 174.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181983"},
        {"Hipparcos Number", "HIP 96425"},
        {"Geneva Identification System", "GEN# +1.00181983"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.06247837),
        dec: Angle.Degrees(-81.24739364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206211"},
        {"Hipparcos Number", "HIP 107693"},
        {"Geneva Identification System", "GEN# +1.00206211"},
        {"Smithsonian Astrophysical Observation", "SAO 258911"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.22870789),
        dec: Angle.Degrees(-81.23517438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59104"},
        {"Hipparcos Number", "HIP 35056"},
        {"Renson", "Renson 16160"},
        {"Smithsonian Astrophysical Observation", "SAO 258467"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.74080581),
        dec: Angle.Degrees(-81.22306821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66169"},
        {"Hipparcos Number", "HIP 38220"},
        {"Smithsonian Astrophysical Observation", "SAO 258488"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.44780226),
        dec: Angle.Degrees(-81.20480684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130480"},
        {"Hipparcos Number", "HIP 73226"},
        {"Smithsonian Astrophysical Observation", "SAO 258711"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.48688334),
        dec: Angle.Degrees(-81.20418748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106363"},
        {"Hipparcos Number", "HIP 59722"},
        {"Geneva Identification System", "GEN# +1.00106363"},
        {"Smithsonian Astrophysical Observation", "SAO 258639"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.71827349),
        dec: Angle.Degrees(-81.19413050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103445"},
        {"Hipparcos Number", "HIP 58032"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.53097972),
        dec: Angle.Degrees(-81.19070937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89337"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.42341838),
        dec: Angle.Degrees(-81.17971986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -259.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3763"},
        {"Hipparcos Number", "HIP 2986"},
        {"Smithsonian Astrophysical Observation", "SAO 258233"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.49072736),
        dec: Angle.Degrees(-81.17743480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154179"},
        {"Hipparcos Number", "HIP 84601"},
        {"Smithsonian Astrophysical Observation", "SAO 258764"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.40415377),
        dec: Angle.Degrees(-81.17663024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196521"},
        {"Hipparcos Number", "HIP 102742"},
        {"Geneva Identification System", "GEN# +1.00196521"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.27837580),
        dec: Angle.Degrees(-81.17014611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44949"},
        {"Geneva Identification System", "GEN# -0.08000328J"},
    },
    visualMagnitude: 11.87,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.32142520),
        dec: Angle.Degrees(-81.16336976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92106"},
        {"Hipparcos Number", "HIP 51632"},
        {"Renson", "Renson 26470"},
        {"Smithsonian Astrophysical Observation", "SAO 258584"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.21994186),
        dec: Angle.Degrees(-81.16289326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145885"},
        {"Hipparcos Number", "HIP 80507"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.51910033),
        dec: Angle.Degrees(-81.16066338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17314"},
        {"Hipparcos Number", "HIP 12221"},
        {"Smithsonian Astrophysical Observation", "SAO 258310"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.34251561),
        dec: Angle.Degrees(-81.15212776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113048"},
        {"Hipparcos Number", "HIP 63794"},
        {"Geneva Identification System", "GEN# +1.00113048"},
        {"Smithsonian Astrophysical Observation", "SAO 258656"},
        {"Wilson Evans Batten Catalogue", "WEB 11283"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.12172469),
        dec: Angle.Degrees(-81.15010262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165278"},
        {"Hipparcos Number", "HIP 89788"},
        {"Smithsonian Astrophysical Observation", "SAO 258791"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.85662876),
        dec: Angle.Degrees(-81.14580674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76570"},
        {"Hipparcos Number", "HIP 43092"},
        {"Smithsonian Astrophysical Observation", "SAO 258505"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.65037969),
        dec: Angle.Degrees(-81.12327120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82634"},
        {"Hipparcos Number", "HIP 46133"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.11749013),
        dec: Angle.Degrees(-81.11563433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216464"},
        {"Hipparcos Number", "HIP 113346"},
        {"Smithsonian Astrophysical Observation", "SAO 258953"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.32280000),
        dec: Angle.Degrees(-81.10945333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19733"},
        {"Hipparcos Number", "HIP 13999"},
        {"Geneva Identification System", "GEN# +1.00019733"},
        {"Smithsonian Astrophysical Observation", "SAO 258323"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.05606244),
        dec: Angle.Degrees(-81.08863262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152103"},
        {"Hipparcos Number", "HIP 83576"},
        {"Geneva Identification System", "GEN# +1.00152103"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.21106525),
        dec: Angle.Degrees(-81.08624062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36179"},
        {"Hipparcos Number", "HIP 24542"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.98097235),
        dec: Angle.Degrees(-81.07225775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157008"},
        {"Hipparcos Number", "HIP 86012"},
        {"Smithsonian Astrophysical Observation", "SAO 258770"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.67887296),
        dec: Angle.Degrees(-81.06835526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52494"},
        {"Hipparcos Number", "HIP 32564"},
        {"Smithsonian Astrophysical Observation", "SAO 258454"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.91660208),
        dec: Angle.Degrees(-81.06583630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44327"},
        {"Hipparcos Number", "HIP 28993"},
        {"Geneva Identification System", "GEN# +1.00044327"},
        {"Smithsonian Astrophysical Observation", "SAO 258434"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.77168069),
        dec: Angle.Degrees(-81.06325241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85901"},
        {"Hipparcos Number", "HIP 48027"},
        {"Smithsonian Astrophysical Observation", "SAO 258547"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.85101297),
        dec: Angle.Degrees(-81.06143872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91509"},
        {"Hipparcos Number", "HIP 51284"},
        {"Smithsonian Astrophysical Observation", "SAO 258578"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.13077681),
        dec: Angle.Degrees(-81.05594511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37134"},
        {"Hipparcos Number", "HIP 25079"},
        {"Renson", "Renson 9900"},
        {"Smithsonian Astrophysical Observation", "SAO 258412"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.53923796),
        dec: Angle.Degrees(-81.03897303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12110"},
        {"Hipparcos Number", "HIP 8701"},
        {"Geneva Identification System", "GEN# +1.00012110"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.99004932),
        dec: Angle.Degrees(-81.01945276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8688"},
        {"Hipparcos Number", "HIP 6281"},
        {"Smithsonian Astrophysical Observation", "SAO 258263"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.14186903),
        dec: Angle.Degrees(-81.01682003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123998"},
        {"Hipparcos Number", "HIP 69896"},
        {"Fundamental Katalog 5th Edition", "FK5 3129"},
        {"Geneva Identification System", "GEN# +1.00123998"},
        {"Renson", "Renson 35480"},
        {"Smithsonian Astrophysical Observation", "SAO 258693"},
        {"Wilson Evans Batten Catalogue", "WEB 12158"},
    },
    visualMagnitude: 4.89,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.55821047),
        dec: Angle.Degrees(-81.00760147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103536"},
        {"Hipparcos Number", "HIP 58095"},
        {"Smithsonian Astrophysical Observation", "SAO 258627"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.72118553),
        dec: Angle.Degrees(-81.00697400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20587"},
        {"Hipparcos Number", "HIP 14565"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.00728911),
        dec: Angle.Degrees(-80.99836632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27895"},
        {"Hipparcos Number", "HIP 19561"},
        {"Smithsonian Astrophysical Observation", "SAO 258366"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.84787670),
        dec: Angle.Degrees(-80.99577156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210728"},
        {"Hipparcos Number", "HIP 110158"},
        {"Geneva Identification System", "GEN# +1.00210728"},
        {"Renson", "Renson 58570"},
        {"Smithsonian Astrophysical Observation", "SAO 258926"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.69587740),
        dec: Angle.Degrees(-80.97962732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207348"},
        {"Hipparcos Number", "HIP 108260"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.98391340),
        dec: Angle.Degrees(-80.97238787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193721"},
        {"Hipparcos Number", "HIP 101427"},
        {"Fundamental Katalog 5th Edition", "FK5 3994"},
        {"Geneva Identification System", "GEN# +1.00193721"},
        {"Smithsonian Astrophysical Observation", "SAO 258861"},
    },
    visualMagnitude: 5.76,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.32338660),
        dec: Angle.Degrees(-80.96482633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36481"},
        {"Hipparcos Number", "HIP 24718"},
        {"Smithsonian Astrophysical Observation", "SAO 258409"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.52304258),
        dec: Angle.Degrees(-80.96469080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16035"},
        {"Hipparcos Number", "HIP 11342"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.48130981),
        dec: Angle.Degrees(-80.94597576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83979"},
        {"Hipparcos Number", "HIP 46928"},
        {"Geneva Identification System", "GEN# +1.00083979"},
        {"Smithsonian Astrophysical Observation", "SAO 258538"},
        {"Wilson Evans Batten Catalogue", "WEB 8848"},
    },
    visualMagnitude: 5.07,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.47293825),
        dec: Angle.Degrees(-80.94129374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214309"},
        {"Hipparcos Number", "HIP 112092"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.56407618),
        dec: Angle.Degrees(-80.93868310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94455"},
        {"Hipparcos Number", "HIP 52969"},
        {"Geneva Identification System", "GEN# +1.00094455"},
        {"Renson", "Renson 27260"},
        {"Smithsonian Astrophysical Observation", "SAO 258594"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.50241553),
        dec: Angle.Degrees(-80.93353484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147351"},
        {"Hipparcos Number", "HIP 81120"},
        {"Smithsonian Astrophysical Observation", "SAO 258745"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.51914791),
        dec: Angle.Degrees(-80.92919695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187707"},
        {"Hipparcos Number", "HIP 98771"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.91078408),
        dec: Angle.Degrees(-80.92638708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89992"},
        {"Hipparcos Number", "HIP 50379"},
        {"Geneva Identification System", "GEN# +1.00089992"},
        {"Smithsonian Astrophysical Observation", "SAO 258568"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.30265805),
        dec: Angle.Degrees(-80.92320099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74970"},
        {"Hipparcos Number", "HIP 42221"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.12315252),
        dec: Angle.Degrees(-80.91841807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72922"},
        {"Hipparcos Number", "HIP 41191"},
        {"Fundamental Katalog 5th Edition", "FK5 2664"},
        {"Geneva Identification System", "GEN# +1.00072922"},
        {"Smithsonian Astrophysical Observation", "SAO 258496"},
    },
    visualMagnitude: 5.67,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.08492509),
        dec: Angle.Degrees(-80.91471955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 213.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218559"},
        {"Hipparcos Number", "HIP 114550"},
        {"Geneva Identification System", "GEN# +1.00218559"},
        {"Smithsonian Astrophysical Observation", "SAO 258961"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.05179488),
        dec: Angle.Degrees(-80.91267194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138882"},
        {"Hipparcos Number", "HIP 77219"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.49316924),
        dec: Angle.Degrees(-80.89242935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27021"},
        {"Hipparcos Number", "HIP 18970"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.97183771),
        dec: Angle.Degrees(-80.89023181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195291"},
        {"Hipparcos Number", "HIP 102087"},
        {"Smithsonian Astrophysical Observation", "SAO 258868"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.34034102),
        dec: Angle.Degrees(-80.88304864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202401"},
        {"Hipparcos Number", "HIP 105720"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.19450103),
        dec: Angle.Degrees(-80.87143212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9198"},
        {"Hipparcos Number", "HIP 6657"},
        {"Smithsonian Astrophysical Observation", "SAO 258266"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.35297792),
        dec: Angle.Degrees(-80.87039449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23972"},
        {"Hipparcos Number", "HIP 16910"},
        {"Geneva Identification System", "GEN# +1.00023972"},
        {"Smithsonian Astrophysical Observation", "SAO 258347"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.39996501),
        dec: Angle.Degrees(-80.86047243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156513"},
        {"Hipparcos Number", "HIP 85760"},
        {"Fundamental Katalog 5th Edition", "FK5 1455"},
        {"Geneva Identification System", "GEN# +1.00156513"},
        {"Smithsonian Astrophysical Observation", "SAO 258769"},
    },
    visualMagnitude: 5.83,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.86447140),
        dec: Angle.Degrees(-80.85902834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23932"},
        {"Hipparcos Number", "HIP 16899"},
        {"Geneva Identification System", "GEN# +1.00023932"},
        {"Smithsonian Astrophysical Observation", "SAO 258346"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.35037779),
        dec: Angle.Degrees(-80.85426531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189488"},
        {"Hipparcos Number", "HIP 99559"},
        {"Smithsonian Astrophysical Observation", "SAO 258852"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.06869117),
        dec: Angle.Degrees(-80.85331642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38875"},
        {"Hipparcos Number", "HIP 26194"},
        {"Smithsonian Astrophysical Observation", "SAO 258417"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.74885204),
        dec: Angle.Degrees(-80.85240259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54481"},
        {"Hipparcos Number", "HIP 33308"},
        {"Fundamental Katalog 5th Edition", "FK5 4628"},
        {"Smithsonian Astrophysical Observation", "SAO 258458"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.92651297),
        dec: Angle.Degrees(-80.83805082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95602"},
        {"Hipparcos Number", "HIP 53643"},
        {"Smithsonian Astrophysical Observation", "SAO 258597"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.60913515),
        dec: Angle.Degrees(-80.83418910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221214"},
        {"Hipparcos Number", "HIP 116145"},
        {"Smithsonian Astrophysical Observation", "SAO 258975"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.99012003),
        dec: Angle.Degrees(-80.82789516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61545"},
        {"Hipparcos Number", "HIP 36187"},
        {"Smithsonian Astrophysical Observation", "SAO 258472"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.78657449),
        dec: Angle.Degrees(-80.82392682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50506"},
        {"Hipparcos Number", "HIP 31897"},
        {"Fundamental Katalog 5th Edition", "FK5 264"},
        {"Geneva Identification System", "GEN# +1.00050506"},
        {"Smithsonian Astrophysical Observation", "SAO 258451"},
        {"Wilson Evans Batten Catalogue", "WEB 6411"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.01211946),
        dec: Angle.Degrees(-80.81372235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34232"},
        {"Hipparcos Number", "HIP 23435"},
        {"Smithsonian Astrophysical Observation", "SAO 258397"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.56595346),
        dec: Angle.Degrees(-80.81141153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144266"},
        {"Hipparcos Number", "HIP 79786"},
        {"Smithsonian Astrophysical Observation", "SAO 258740"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.24528906),
        dec: Angle.Degrees(-80.80021315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149080"},
        {"Hipparcos Number", "HIP 82005"},
        {"Smithsonian Astrophysical Observation", "SAO 258749"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.28285710),
        dec: Angle.Degrees(-80.79974583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95647"},
        {"Hipparcos Number", "HIP 53651"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.65186516),
        dec: Angle.Degrees(-80.78966573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82554"},
        {"Hipparcos Number", "HIP 46107"},
        {"Fundamental Katalog 5th Edition", "FK5 2753"},
        {"Geneva Identification System", "GEN# +1.00082554"},
        {"Smithsonian Astrophysical Observation", "SAO 258530"},
        {"Wilson Evans Batten Catalogue", "WEB 8731"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.04053926),
        dec: Angle.Degrees(-80.78720514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 135.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129886"},
        {"Hipparcos Number", "HIP 72915"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.52990846),
        dec: Angle.Degrees(-80.78670717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106508"},
        {"Hipparcos Number", "HIP 59798"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.93642760),
        dec: Angle.Degrees(-80.78468220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32195"},
        {"Hipparcos Number", "HIP 22295"},
        {"Geneva Identification System", "GEN# +1.00032195"},
        {"Smithsonian Astrophysical Observation", "SAO 258391"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.02084167),
        dec: Angle.Degrees(-80.77933778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122342"},
        {"Hipparcos Number", "HIP 69055"},
        {"Fundamental Katalog 5th Edition", "FK5 5254"},
        {"Geneva Identification System", "GEN# +1.00122342"},
        {"Smithsonian Astrophysical Observation", "SAO 258690"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.01850305),
        dec: Angle.Degrees(-80.76402290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141101"},
        {"Hipparcos Number", "HIP 78250"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.64857852),
        dec: Angle.Degrees(-80.75558461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145327"},
        {"Hipparcos Number", "HIP 80200"},
        {"Geneva Identification System", "GEN# +1.00145327"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.59257241),
        dec: Angle.Degrees(-80.74580319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127284"},
        {"Hipparcos Number", "HIP 71598"},
        {"Smithsonian Astrophysical Observation", "SAO 258704"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.64569990),
        dec: Angle.Degrees(-80.73622534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27358"},
        {"Hipparcos Number", "HIP 19188"},
        {"Smithsonian Astrophysical Observation", "SAO 258364"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.68554271),
        dec: Angle.Degrees(-80.73554137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -236.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172882"},
        {"Hipparcos Number", "HIP 92928"},
        {"Fundamental Katalog 5th Edition", "FK5 3496"},
        {"Geneva Identification System", "GEN# +1.00172882"},
        {"Smithsonian Astrophysical Observation", "SAO 258815"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.99994877),
        dec: Angle.Degrees(-80.72786473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192950"},
        {"Hipparcos Number", "HIP 101037"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.24759499),
        dec: Angle.Degrees(-80.71729816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22773"},
        {"Hipparcos Number", "HIP 16190"},
        {"Smithsonian Astrophysical Observation", "SAO 258340"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.14129214),
        dec: Angle.Degrees(-80.70905563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5757"},
        {"Hipparcos Number", "HIP 4357"},
        {"Smithsonian Astrophysical Observation", "SAO 258247"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.95921275),
        dec: Angle.Degrees(-80.70889391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72354"},
        {"Hipparcos Number", "HIP 40949"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.35918309),
        dec: Angle.Degrees(-80.70752426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111111"},
        {"Hipparcos Number", "HIP 62590"},
        {"Geneva Identification System", "GEN# +1.00111111"},
        {"Smithsonian Astrophysical Observation", "SAO 258650"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.38356711),
        dec: Angle.Degrees(-80.70234413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199391"},
        {"Hipparcos Number", "HIP 104206"},
        {"Smithsonian Astrophysical Observation", "SAO 258879"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.68248470),
        dec: Angle.Degrees(-80.69775189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212619"},
        {"Hipparcos Number", "HIP 111153"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.78808786),
        dec: Angle.Degrees(-80.69594918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202707"},
        {"Hipparcos Number", "HIP 105876"},
        {"Geneva Identification System", "GEN# +1.00202707"},
        {"Smithsonian Astrophysical Observation", "SAO 258896"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.64716107),
        dec: Angle.Degrees(-80.68251550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19682"},
        {"Hipparcos Number", "HIP 13985"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.02942545),
        dec: Angle.Degrees(-80.68119630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85301"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.46746355),
        dec: Angle.Degrees(-80.66287993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158347"},
        {"Hipparcos Number", "HIP 86626"},
        {"Smithsonian Astrophysical Observation", "SAO 258775"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.50129855),
        dec: Angle.Degrees(-80.66210192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3948"},
        {"Hipparcos Number", "HIP 3131"},
        {"Geneva Identification System", "GEN# +1.00003948"},
        {"Smithsonian Astrophysical Observation", "SAO 258236"},
        {"Wilson Evans Batten Catalogue", "WEB 558"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.94852780),
        dec: Angle.Degrees(-80.65618639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89144"},
        {"Hipparcos Number", "HIP 49859"},
        {"Smithsonian Astrophysical Observation", "SAO 258566"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.72230278),
        dec: Angle.Degrees(-80.65552720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184310"},
        {"Hipparcos Number", "HIP 97291"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.59278092),
        dec: Angle.Degrees(-80.64275969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31755"},
        {"Hipparcos Number", "HIP 22101"},
        {"Smithsonian Astrophysical Observation", "SAO 258389"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.35932317),
        dec: Angle.Degrees(-80.64137133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162482"},
        {"Hipparcos Number", "HIP 88538"},
        {"Fundamental Katalog 5th Edition", "FK5 5593"},
        {"Smithsonian Astrophysical Observation", "SAO 258786"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.18962541),
        dec: Angle.Degrees(-80.62895331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198133"},
        {"Hipparcos Number", "HIP 103520"},
        {"Smithsonian Astrophysical Observation", "SAO 258874"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.58482946),
        dec: Angle.Degrees(-80.61994769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188396"},
        {"Hipparcos Number", "HIP 99075"},
        {"Geneva Identification System", "GEN# +1.00188396"},
        {"Smithsonian Astrophysical Observation", "SAO 258850"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.70922618),
        dec: Angle.Degrees(-80.60007059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43013"},
        {"Hipparcos Number", "HIP 28440"},
        {"Smithsonian Astrophysical Observation", "SAO 258430"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.08073895),
        dec: Angle.Degrees(-80.59808765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48324"},
        {"Hipparcos Number", "HIP 30936"},
        {"Smithsonian Astrophysical Observation", "SAO 258445"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.39536778),
        dec: Angle.Degrees(-80.59266432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70417"},
        {"Hipparcos Number", "HIP 40034"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.66494176),
        dec: Angle.Degrees(-80.58603828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14603"},
        {"Hipparcos Number", "HIP 10389"},
        {"Smithsonian Astrophysical Observation", "SAO 258293"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.45789956),
        dec: Angle.Degrees(-80.58284171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142326"},
        {"Hipparcos Number", "HIP 78806"},
        {"Smithsonian Astrophysical Observation", "SAO 258737"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.32602933),
        dec: Angle.Degrees(-80.57940916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118345"},
        {"Hipparcos Number", "HIP 66817"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.43954893),
        dec: Angle.Degrees(-80.57616136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8119"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.08997995),
        dec: Angle.Degrees(-80.57421453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175169"},
        {"Hipparcos Number", "HIP 93889"},
        {"Geneva Identification System", "GEN# +1.00175169"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.78601386),
        dec: Angle.Degrees(-80.55248053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222374"},
        {"Hipparcos Number", "HIP 116861"},
        {"Renson", "Renson 60960"},
        {"Smithsonian Astrophysical Observation", "SAO 258981"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.30877390),
        dec: Angle.Degrees(-80.54952880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193441"},
        {"Hipparcos Number", "HIP 101241"},
        {"Geneva Identification System", "GEN# +1.00193441"},
        {"Smithsonian Astrophysical Observation", "SAO 258860"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.82104141),
        dec: Angle.Degrees(-80.54400947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157065"},
        {"Hipparcos Number", "HIP 85970"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.55415195),
        dec: Angle.Degrees(-80.54040926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15824"},
        {"Smithsonian Astrophysical Observation", "SAO 255989"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.97353902),
        dec: Angle.Degrees(-79.35563071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 123.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93845"},
        {"Hipparcos Number", "HIP 52633"},
        {"Fundamental Katalog 5th Edition", "FK5 411"},
        {"Geneva Identification System", "GEN# +1.00093845"},
        {"Smithsonian Astrophysical Observation", "SAO 258593"},
        {"Wilson Evans Batten Catalogue", "WEB 9586"},
    },
    visualMagnitude: 4.45,
    bvColour: -0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.44639899),
        dec: Angle.Degrees(-80.54020283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48190"},
        {"Hipparcos Number", "HIP 30887"},
        {"Fundamental Katalog 5th Edition", "FK5 4589"},
        {"Smithsonian Astrophysical Observation", "SAO 258444"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.25305819),
        dec: Angle.Degrees(-80.53878899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14806"},
        {"Hipparcos Number", "HIP 10504"},
        {"Renson", "Renson 3690"},
        {"Smithsonian Astrophysical Observation", "SAO 258295"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.85025834),
        dec: Angle.Degrees(-80.53486060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13060"},
        {"Hipparcos Number", "HIP 9400"},
        {"Geneva Identification System", "GEN# +1.00013060"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.19770613),
        dec: Angle.Degrees(-80.53236809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46120"},
        {"Cincinnati Publication", "Ci 20 530"},
        {"Geneva Identification System", "GEN# -0.08000349"},
        {"Wilson Evans Batten Catalogue", "WEB 8733"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.08440714),
        dec: Angle.Degrees(-80.52558901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1237.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92210"},
        {"Hipparcos Number", "HIP 51713"},
        {"Geneva Identification System", "GEN# +1.00092210"},
        {"Smithsonian Astrophysical Observation", "SAO 258585"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.48564965),
        dec: Angle.Degrees(-80.51690626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47815"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.20844793),
        dec: Angle.Degrees(-80.51296218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219125"},
        {"Hipparcos Number", "HIP 114884"},
        {"Geneva Identification System", "GEN# +1.00219125"},
        {"Smithsonian Astrophysical Observation", "SAO 258966"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.06974063),
        dec: Angle.Degrees(-80.51275445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91602"},
        {"Hipparcos Number", "HIP 51365"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.37125499),
        dec: Angle.Degrees(-80.51185461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85499"},
        {"Hipparcos Number", "HIP 47829"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.23592500),
        dec: Angle.Degrees(-80.50900453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103875"},
        {"Hipparcos Number", "HIP 58291"},
        {"Fundamental Katalog 5th Edition", "FK5 5050"},
        {"Smithsonian Astrophysical Observation", "SAO 258628"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.31708555),
        dec: Angle.Degrees(-80.49468646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204698"},
        {"Hipparcos Number", "HIP 106861"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.64274114),
        dec: Angle.Degrees(-80.49262698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21361"},
        {"Hipparcos Number", "HIP 15229"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.09033947),
        dec: Angle.Degrees(-80.48607289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102065"},
        {"Hipparcos Number", "HIP 57192"},
        {"Smithsonian Astrophysical Observation", "SAO 258622"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.90440603),
        dec: Angle.Degrees(-80.48346380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39091"},
        {"Hipparcos Number", "HIP 26394"},
        {"Cincinnati Publication", "Ci 20 352"},
        {"Geneva Identification System", "GEN# +1.00039091"},
        {"Smithsonian Astrophysical Observation", "SAO 258421"},
        {"Wilson Evans Batten Catalogue", "WEB 5206"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.28663598),
        dec: Angle.Degrees(-80.47167450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 311.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1050.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93779"},
        {"Hipparcos Number", "HIP 52595"},
        {"Geneva Identification System", "GEN# +1.00093779"},
        {"Smithsonian Astrophysical Observation", "SAO 258592"},
        {"Wilson Evans Batten Catalogue", "WEB 9583"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.31822960),
        dec: Angle.Degrees(-80.46952330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211092"},
        {"Henry Draper 2", "HD 211092A"},
        {"Hipparcos Number", "HIP 110329"},
        {"Smithsonian Astrophysical Observation", "SAO 258929"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.20447801),
        dec: Angle.Degrees(-80.45398095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135383"},
        {"Hipparcos Number", "HIP 75420"},
        {"Smithsonian Astrophysical Observation", "SAO 258727"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.13552265),
        dec: Angle.Degrees(-80.44056599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210967"},
        {"Hipparcos Number", "HIP 110256"},
        {"Fundamental Katalog 5th Edition", "FK5 839"},
        {"Geneva Identification System", "GEN# +1.00210967"},
        {"Smithsonian Astrophysical Observation", "SAO 258928"},
        {"Wilson Evans Batten Catalogue", "WEB 19783"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.00616756),
        dec: Angle.Degrees(-80.43964301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213743"},
        {"Hipparcos Number", "HIP 111793"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.65226505),
        dec: Angle.Degrees(-80.42820976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219358"},
        {"Hipparcos Number", "HIP 115028"},
        {"Smithsonian Astrophysical Observation", "SAO 258968"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.47075975),
        dec: Angle.Degrees(-80.42479119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1802"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.71154791),
        dec: Angle.Degrees(-80.40974460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35267"},
        {"Hipparcos Number", "HIP 24084"},
        {"Geneva Identification System", "GEN# +1.00035267"},
        {"Smithsonian Astrophysical Observation", "SAO 258400"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.60519751),
        dec: Angle.Degrees(-80.40805901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225169"},
        {"Hipparcos Number", "HIP 317"},
        {"Geneva Identification System", "GEN# +1.00225169"},
        {"Smithsonian Astrophysical Observation", "SAO 258208"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.00253201),
        dec: Angle.Degrees(-80.39507010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219304"},
        {"Hipparcos Number", "HIP 114993"},
        {"Fundamental Katalog 5th Edition", "FK5 6059"},
        {"Smithsonian Astrophysical Observation", "SAO 258967"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.35321427),
        dec: Angle.Degrees(-80.39308311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175861"},
        {"Hipparcos Number", "HIP 94158"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.49948935),
        dec: Angle.Degrees(-80.39103021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81961"},
        {"Hipparcos Number", "HIP 45829"},
        {"Smithsonian Astrophysical Observation", "SAO 258529"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.16544243),
        dec: Angle.Degrees(-80.39026629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 164.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84735"},
        {"Hipparcos Number", "HIP 47421"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.93739079),
        dec: Angle.Degrees(-80.38982348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206309"},
        {"Hipparcos Number", "HIP 107681"},
        {"Smithsonian Astrophysical Observation", "SAO 258913"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.18888762),
        dec: Angle.Degrees(-80.38475445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197908"},
        {"Hipparcos Number", "HIP 103372"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.15008527),
        dec: Angle.Degrees(-80.36998895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149574"},
        {"Hipparcos Number", "HIP 82222"},
        {"Smithsonian Astrophysical Observation", "SAO 258750"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.95807997),
        dec: Angle.Degrees(-80.36289578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84451"},
        {"Hipparcos Number", "HIP 47253"},
        {"Geneva Identification System", "GEN# +1.00084451"},
        {"Renson", "Renson 24090"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.47863865),
        dec: Angle.Degrees(-80.35050708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125838"},
        {"Hipparcos Number", "HIP 70860"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.35295409),
        dec: Angle.Degrees(-80.34548708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201230"},
        {"Hipparcos Number", "HIP 105073"},
        {"Smithsonian Astrophysical Observation", "SAO 258886"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.28422930),
        dec: Angle.Degrees(-80.34488619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196419"},
        {"Hipparcos Number", "HIP 102594"},
        {"Geneva Identification System", "GEN# +1.00196419"},
        {"Smithsonian Astrophysical Observation", "SAO 258869"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.87179319),
        dec: Angle.Degrees(-80.32426112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146967"},
        {"Hipparcos Number", "HIP 80865"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.68581540),
        dec: Angle.Degrees(-80.32068607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108768",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108768"},
    },
    visualMagnitude: 11.77,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.50531135),
        dec: Angle.Degrees(-80.31509362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132501"},
        {"Hipparcos Number", "HIP 74091"},
        {"Smithsonian Astrophysical Observation", "SAO 258719"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.12574003),
        dec: Angle.Degrees(-80.31388714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45189"},
        {"Hipparcos Number", "HIP 29515"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.26495265),
        dec: Angle.Degrees(-80.30965340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43490"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.87370722),
        dec: Angle.Degrees(-80.30069614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -257.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 230.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8224"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.47184770),
        dec: Angle.Degrees(-80.30067621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 212.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30054"},
        {"Hipparcos Number", "HIP 21136"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.96106139),
        dec: Angle.Degrees(-80.29010077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131408"},
        {"Hipparcos Number", "HIP 73576"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.57369345),
        dec: Angle.Degrees(-80.27760266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120160"},
        {"Hipparcos Number", "HIP 67813"},
        {"Geneva Identification System", "GEN# +1.00120160"},
        {"Smithsonian Astrophysical Observation", "SAO 258682"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.37858341),
        dec: Angle.Degrees(-80.27284177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116591"},
        {"Hipparcos Number", "HIP 65771"},
        {"Geneva Identification System", "GEN# +1.00116591"},
        {"Smithsonian Astrophysical Observation", "SAO 257050"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.25919827),
        dec: Angle.Degrees(-80.25736677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100715"},
        {"Hipparcos Number", "HIP 56395"},
        {"Geneva Identification System", "GEN# +1.00100715"},
        {"Smithsonian Astrophysical Observation", "SAO 256852"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.42427013),
        dec: Angle.Degrees(-80.25077246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165737"},
        {"Hipparcos Number", "HIP 89873"},
        {"Smithsonian Astrophysical Observation", "SAO 258793"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.09223516),
        dec: Angle.Degrees(-80.23924720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61440"},
    },
    visualMagnitude: 12.71,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.85862666),
        dec: Angle.Degrees(-74.07300812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179778"},
        {"Hipparcos Number", "HIP 95544"},
        {"Fundamental Katalog 5th Edition", "FK5 5709"},
        {"Smithsonian Astrophysical Observation", "SAO 258831"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.51439312),
        dec: Angle.Degrees(-80.23703056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167714"},
        {"Hipparcos Number", "HIP 90606"},
        {"Geneva Identification System", "GEN# +1.00167714"},
        {"Smithsonian Astrophysical Observation", "SAO 258796"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.33342045),
        dec: Angle.Degrees(-80.23255408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210713"},
        {"Hipparcos Number", "HIP 110100"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.54501955),
        dec: Angle.Degrees(-80.22904765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113063"},
        {"Hipparcos Number", "HIP 63768"},
        {"Renson", "Renson 32830"},
        {"Smithsonian Astrophysical Observation", "SAO 257005"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.06532855),
        dec: Angle.Degrees(-80.21900966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164694"},
        {"Hipparcos Number", "HIP 89445"},
        {"Smithsonian Astrophysical Observation", "SAO 258789"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.81570143),
        dec: Angle.Degrees(-80.21743353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28525"},
        {"Hipparcos Number", "HIP 20049"},
        {"Fundamental Katalog 5th Edition", "FK5 166"},
        {"Geneva Identification System", "GEN# +1.00028525"},
        {"Smithsonian Astrophysical Observation", "SAO 258372"},
        {"Wilson Evans Batten Catalogue", "WEB 3828"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.49656949),
        dec: Angle.Degrees(-80.21418106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76351",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Karaka"},
        {"Henry Draper", "HD 137388"},
        {"Hipparcos Number", "HIP 76351"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.91704974),
        dec: Angle.Degrees(-80.20469392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76362"},
    },
    visualMagnitude: 11.65,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.94850307),
        dec: Angle.Degrees(-80.20230323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35391"},
        {"Hipparcos Number", "HIP 24187"},
        {"Smithsonian Astrophysical Observation", "SAO 258402"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.89713006),
        dec: Angle.Degrees(-80.19226875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35937"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.12703510),
        dec: Angle.Degrees(-80.18552054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172942"},
        {"Hipparcos Number", "HIP 92877"},
        {"Geneva Identification System", "GEN# +1.00172942"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.87084123),
        dec: Angle.Degrees(-80.17803300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141432"},
        {"Hipparcos Number", "HIP 78347"},
        {"Geneva Identification System", "GEN# +1.00141432"},
        {"Renson", "Renson 40140"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.96087228),
        dec: Angle.Degrees(-80.17802865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11604"},
        {"Hipparcos Number", "HIP 8366"},
        {"Geneva Identification System", "GEN# +1.00011604"},
        {"Smithsonian Astrophysical Observation", "SAO 258280"},
        {"Wilson Evans Batten Catalogue", "WEB 1780"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.94453905),
        dec: Angle.Degrees(-80.17616913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 783"},
        {"Hipparcos Number", "HIP 938"},
        {"Fundamental Katalog 5th Edition", "FK5 4022"},
        {"Geneva Identification System", "GEN# +1.00000783"},
        {"Smithsonian Astrophysical Observation", "SAO 258216"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.90304188),
        dec: Angle.Degrees(-80.17376516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65911"},
        {"Hipparcos Number", "HIP 38259"},
        {"Geneva Identification System", "GEN# +1.00065911"},
        {"Smithsonian Astrophysical Observation", "SAO 258487"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.56811364),
        dec: Angle.Degrees(-80.16942423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94246"},
        {"Hipparcos Number", "HIP 52874"},
        {"Smithsonian Astrophysical Observation", "SAO 256760"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.19895110),
        dec: Angle.Degrees(-80.16156501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74343"},
        {"Hipparcos Number", "HIP 41995"},
        {"Smithsonian Astrophysical Observation", "SAO 256526"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.40101212),
        dec: Angle.Degrees(-80.15864439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136476"},
        {"Hipparcos Number", "HIP 75937"},
    },
    visualMagnitude: 9.92,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.64875049),
        dec: Angle.Degrees(-80.15695487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77982"},
        {"Hipparcos Number", "HIP 43911"},
        {"Geneva Identification System", "GEN# +1.00077982"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.18238847),
        dec: Angle.Degrees(-80.13842673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52880"},
        {"Hipparcos Number", "HIP 32821"},
        {"Smithsonian Astrophysical Observation", "SAO 258456"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.62786905),
        dec: Angle.Degrees(-80.13571120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196818"},
        {"Hipparcos Number", "HIP 102803"},
        {"Geneva Identification System", "GEN# +1.00196818"},
        {"Smithsonian Astrophysical Observation", "SAO 258871"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.40523893),
        dec: Angle.Degrees(-80.13364871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88147"},
        {"Hipparcos Number", "HIP 49299"},
        {"Geneva Identification System", "GEN# +1.00088147J"},
        {"Smithsonian Astrophysical Observation", "SAO 256679"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.94136094),
        dec: Angle.Degrees(-80.13101467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215573"},
        {"Hipparcos Number", "HIP 112781"},
        {"Geneva Identification System", "GEN# +1.00215573"},
        {"Smithsonian Astrophysical Observation", "SAO 258946"},
        {"Wilson Evans Batten Catalogue", "WEB 20092"},
    },
    visualMagnitude: 5.32,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.59477516),
        dec: Angle.Degrees(-80.12381446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28712"},
        {"Hipparcos Number", "HIP 20195"},
        {"Smithsonian Astrophysical Observation", "SAO 258376"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.92829315),
        dec: Angle.Degrees(-80.12013436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202046"},
        {"Hipparcos Number", "HIP 105514"},
        {"Geneva Identification System", "GEN# +1.00202046"},
        {"Smithsonian Astrophysical Observation", "SAO 258892"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.55868354),
        dec: Angle.Degrees(-80.11370623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 240.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113729"},
        {"Hipparcos Number", "HIP 64173"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.27975349),
        dec: Angle.Degrees(-80.11349212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7555"},
        {"Hipparcos Number", "HIP 5598"},
        {"Smithsonian Astrophysical Observation", "SAO 258260"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.94269560),
        dec: Angle.Degrees(-80.11225569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42103"},
        {"Hipparcos Number", "HIP 28068"},
        {"Smithsonian Astrophysical Observation", "SAO 258428"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.00981574),
        dec: Angle.Degrees(-80.11060901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124771"},
        {"Hipparcos Number", "HIP 70248"},
        {"Geneva Identification System", "GEN# +1.00124771"},
        {"Smithsonian Astrophysical Observation", "SAO 257142"},
        {"Wilson Evans Batten Catalogue", "WEB 12197"},
    },
    visualMagnitude: 5.06,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.59665420),
        dec: Angle.Degrees(-80.10891100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125856"},
        {"Hipparcos Number", "HIP 70861"},
        {"Smithsonian Astrophysical Observation", "SAO 257158"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.35919943),
        dec: Angle.Degrees(-80.10336146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153582"},
        {"Hipparcos Number", "HIP 84180"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.12583781),
        dec: Angle.Degrees(-80.09860891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221510"},
        {"Hipparcos Number", "HIP 116337"},
        {"Smithsonian Astrophysical Observation", "SAO 258976"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.59589572),
        dec: Angle.Degrees(-80.09844465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146734"},
        {"Hipparcos Number", "HIP 80741"},
        {"Geneva Identification System", "GEN# +1.00146734"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.27165561),
        dec: Angle.Degrees(-80.09706422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184194"},
        {"Hipparcos Number", "HIP 97159"},
        {"Smithsonian Astrophysical Observation", "SAO 258835"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.22708463),
        dec: Angle.Degrees(-80.08853244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83175"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.99025232),
        dec: Angle.Degrees(-80.08617684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120159"},
    },
    visualMagnitude: 13.57,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)22, 59.0300),
        dec: Angle.DegreesMinutesSeconds((int)-80, (int)04, 52.800)
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
    primaryId: "HIP 68827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122050"},
        {"Hipparcos Number", "HIP 68827"},
        {"Geneva Identification System", "GEN# +1.00122050"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.38404629),
        dec: Angle.Degrees(-80.07964945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99511"},
    },
    visualMagnitude: 12.06,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.94298876),
        dec: Angle.Degrees(-80.07657037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -276.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151233"},
        {"Hipparcos Number", "HIP 83046"},
        {"Smithsonian Astrophysical Observation", "SAO 257443"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.54669402),
        dec: Angle.Degrees(-80.07246711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107340"},
        {"Hipparcos Number", "HIP 60261"},
        {"Geneva Identification System", "GEN# +1.00107340"},
        {"Renson", "Renson 31100"},
        {"Smithsonian Astrophysical Observation", "SAO 256930"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.34141002),
        dec: Angle.Degrees(-80.06154016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86320"},
        {"Hipparcos Number", "HIP 48320"},
        {"Fundamental Katalog 5th Edition", "FK5 2791"},
        {"Geneva Identification System", "GEN# +1.00086320"},
        {"Smithsonian Astrophysical Observation", "SAO 256666"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.75333462),
        dec: Angle.Degrees(-80.06109591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11183",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11183"},
        {"Smithsonian Astrophysical Observation", "SAO 258301"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.01008597),
        dec: Angle.Degrees(-80.04548690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203955"},
        {"Hipparcos Number", "HIP 106424"},
        {"Geneva Identification System", "GEN# +1.00203955"},
        {"Smithsonian Astrophysical Observation", "SAO 258904"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.33778586),
        dec: Angle.Degrees(-80.03930788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24428"},
        {"Hipparcos Number", "HIP 17321"},
        {"Geneva Identification System", "GEN# +1.00024428"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.61886909),
        dec: Angle.Degrees(-80.02530175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184975"},
        {"Hipparcos Number", "HIP 97459"},
        {"Smithsonian Astrophysical Observation", "SAO 258839"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.13749014),
        dec: Angle.Degrees(-80.02394413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24427"},
        {"Hipparcos Number", "HIP 17319"},
        {"Geneva Identification System", "GEN# +1.00024427"},
        {"Smithsonian Astrophysical Observation", "SAO 258350"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.61073957),
        dec: Angle.Degrees(-80.02016443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17783"},
        {"Hipparcos Number", "HIP 12667"},
        {"Smithsonian Astrophysical Observation", "SAO 258312"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.68591222),
        dec: Angle.Degrees(-80.01206970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127283"},
        {"Hipparcos Number", "HIP 71550"},
        {"Smithsonian Astrophysical Observation", "SAO 257175"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.51115170),
        dec: Angle.Degrees(-79.99592869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94421"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.27327737),
        dec: Angle.Degrees(-79.99447437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181065"},
        {"Hipparcos Number", "HIP 95958"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.70834593),
        dec: Angle.Degrees(-79.98587565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57971"},
        {"Hipparcos Number", "HIP 34744"},
        {"Smithsonian Astrophysical Observation", "SAO 256386"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.90299552),
        dec: Angle.Degrees(-79.98570506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42427",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42427"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.77850898),
        dec: Angle.Degrees(-79.98330198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115088"},
        {"Hipparcos Number", "HIP 64951"},
        {"Geneva Identification System", "GEN# +1.00115088"},
        {"Smithsonian Astrophysical Observation", "SAO 257026"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.70140385),
        dec: Angle.Degrees(-79.97596131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94630"},
        {"Hipparcos Number", "HIP 53096"},
        {"Smithsonian Astrophysical Observation", "SAO 256767"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.93466023),
        dec: Angle.Degrees(-79.96417958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60152"},
        {"Hipparcos Number", "HIP 35661"},
        {"Geneva Identification System", "GEN# +1.00060152"},
        {"Smithsonian Astrophysical Observation", "SAO 256407"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.37159772),
        dec: Angle.Degrees(-79.96055126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 125.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126596"},
        {"Hipparcos Number", "HIP 71209"},
        {"Smithsonian Astrophysical Observation", "SAO 257170"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.44352117),
        dec: Angle.Degrees(-79.95522099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112462"},
        {"Hipparcos Number", "HIP 63417"},
        {"Smithsonian Astrophysical Observation", "SAO 256995"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.92931933),
        dec: Angle.Degrees(-79.94666258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167100"},
        {"Hipparcos Number", "HIP 90359"},
        {"Smithsonian Astrophysical Observation", "SAO 257587"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.57108667),
        dec: Angle.Degrees(-79.92735874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10062"},
        {"Hipparcos Number", "HIP 7231"},
        {"Fundamental Katalog 5th Edition", "FK5 2103"},
        {"Geneva Identification System", "GEN# +1.00010062"},
        {"Smithsonian Astrophysical Observation", "SAO 258268"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.30383713),
        dec: Angle.Degrees(-79.92661098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203203"},
        {"Hipparcos Number", "HIP 106051"},
        {"Smithsonian Astrophysical Observation", "SAO 258900"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.21043347),
        dec: Angle.Degrees(-79.92568574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51785"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.71897474),
        dec: Angle.Degrees(-79.91678317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38874"},
        {"Hipparcos Number", "HIP 26321"},
        {"Smithsonian Astrophysical Observation", "SAO 256220"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.08647630),
        dec: Angle.Degrees(-79.91430909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10970"},
        {"Hipparcos Number", "HIP 7958"},
        {"Geneva Identification System", "GEN# +1.00010970"},
        {"Smithsonian Astrophysical Observation", "SAO 258275"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.54768997),
        dec: Angle.Degrees(-79.91284388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223537"},
        {"Hipparcos Number", "HIP 117596"},
        {"Geneva Identification System", "GEN# +1.00223537"},
        {"Smithsonian Astrophysical Observation", "SAO 258986"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.73104716),
        dec: Angle.Degrees(-79.89858366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9123"},
        {"Hipparcos Number", "HIP 6641"},
        {"Fundamental Katalog 5th Edition", "FK5 4131"},
        {"Smithsonian Astrophysical Observation", "SAO 258265"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.29923965),
        dec: Angle.Degrees(-79.89606497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6618"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.24452645),
        dec: Angle.Degrees(-79.89366943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42950"},
        {"Hipparcos Number", "HIP 28525"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.31930573),
        dec: Angle.Degrees(-79.87178229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21124"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.90739044),
        dec: Angle.Degrees(-79.87109682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196520"},
        {"Hipparcos Number", "HIP 102608"},
        {"Geneva Identification System", "GEN# +1.00196520"},
        {"Smithsonian Astrophysical Observation", "SAO 258870"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.90165716),
        dec: Angle.Degrees(-79.85364231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1237A"},
        {"Henry Draper 2", "HD 1237"},
        {"Hipparcos Number", "HIP 1292"},
        {"Cincinnati Publication", "Ci 20 15"},
        {"Geneva Identification System", "GEN# +1.00001237"},
        {"Smithsonian Astrophysical Observation", "SAO 258219"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.04683817),
        dec: Angle.Degrees(-79.85104079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 433.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156312"},
        {"Hipparcos Number", "HIP 85558"},
        {"Geneva Identification System", "GEN# +1.00156312"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.26814930),
        dec: Angle.Degrees(-79.84278499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84263"},
        {"Hipparcos Number", "HIP 47186"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.24112521),
        dec: Angle.Degrees(-79.83978560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163173"},
        {"Hipparcos Number", "HIP 88757"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.78980860),
        dec: Angle.Degrees(-79.83784885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118231"},
        {"Hipparcos Number", "HIP 66697"},
        {"Geneva Identification System", "GEN# +1.00118231"},
        {"Renson", "Renson 34090"},
        {"Smithsonian Astrophysical Observation", "SAO 257071"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.07941991),
        dec: Angle.Degrees(-79.83356081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145401"},
        {"Hipparcos Number", "HIP 80158"},
        {"Smithsonian Astrophysical Observation", "SAO 257383"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.42999759),
        dec: Angle.Degrees(-79.83188620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35058"},
        {"Hipparcos Number", "HIP 24014"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.43061758),
        dec: Angle.Degrees(-79.82115588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17137"},
        {"Hipparcos Number", "HIP 12173"},
        {"Fundamental Katalog 5th Edition", "FK5 4241"},
        {"Geneva Identification System", "GEN# +1.00017137"},
        {"Smithsonian Astrophysical Observation", "SAO 258308"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.21492683),
        dec: Angle.Degrees(-79.81398097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25637"},
        {"Hipparcos Number", "HIP 18179"},
        {"Smithsonian Astrophysical Observation", "SAO 256047"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.33326059),
        dec: Angle.Degrees(-79.80978558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52674"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.56275589),
        dec: Angle.Degrees(-79.80887941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31908"},
        {"Hipparcos Number", "HIP 22260"},
        {"Renson", "Renson 8090"},
        {"Smithsonian Astrophysical Observation", "SAO 256135"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.89437577),
        dec: Angle.Degrees(-79.80724298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130338"},
        {"Hipparcos Number", "HIP 73041"},
        {"Geneva Identification System", "GEN# +1.00130338"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.91060349),
        dec: Angle.Degrees(-79.80572520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47746"},
        {"Hipparcos Number", "HIP 30767"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.98143049),
        dec: Angle.Degrees(-79.79960184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17742"},
        {"Hipparcos Number", "HIP 12654"},
        {"Geneva Identification System", "GEN# +1.00017742"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.64703164),
        dec: Angle.Degrees(-79.78437921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108913"},
        {"Hipparcos Number", "HIP 61192"},
        {"Fundamental Katalog 5th Edition", "FK5 5104"},
        {"Geneva Identification System", "GEN# +1.00108913"},
        {"Smithsonian Astrophysical Observation", "SAO 256952"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.07787665),
        dec: Angle.Degrees(-79.78385898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93237"},
        {"Hipparcos Number", "HIP 52340"},
        {"Geneva Identification System", "GEN# +1.00093237"},
        {"Smithsonian Astrophysical Observation", "SAO 256745"},
        {"Wilson Evans Batten Catalogue", "WEB 9527"},
    },
    visualMagnitude: 5.97,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.46490038),
        dec: Angle.Degrees(-79.78330226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118934"},
        {"Hipparcos Number", "HIP 67107"},
        {"Smithsonian Astrophysical Observation", "SAO 257084"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.31389500),
        dec: Angle.Degrees(-79.76810148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37380"},
        {"Hipparcos Number", "HIP 25381"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.45441346),
        dec: Angle.Degrees(-79.76270615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53961"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.60052061),
        dec: Angle.Degrees(-79.76086379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97049"},
        {"Hipparcos Number", "HIP 54374"},
        {"Smithsonian Astrophysical Observation", "SAO 256801"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.87007066),
        dec: Angle.Degrees(-79.75704467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109093"},
        {"Hipparcos Number", "HIP 61288"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.38348201),
        dec: Angle.Degrees(-79.75448055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70858",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70858"},
    },
    visualMagnitude: 11.29,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.34622321),
        dec: Angle.Degrees(-79.74942478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125873"},
        {"Hipparcos Number", "HIP 70847"},
        {"Geneva Identification System", "GEN# +1.00125873"},
        {"Wilson Evans Batten Catalogue", "WEB 12269"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.32231024),
        dec: Angle.Degrees(-79.74729756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44187"},
        {"Hipparcos Number", "HIP 29092"},
        {"Smithsonian Astrophysical Observation", "SAO 256275"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.05365000),
        dec: Angle.Degrees(-79.72585505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59075"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.72549552),
        dec: Angle.Degrees(-79.72114478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207670"},
        {"Hipparcos Number", "HIP 108377"},
        {"Smithsonian Astrophysical Observation", "SAO 257981"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.34659665),
        dec: Angle.Degrees(-79.72055358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216239"},
        {"Hipparcos Number", "HIP 113169"},
        {"Fundamental Katalog 5th Edition", "FK5 6024"},
        {"Smithsonian Astrophysical Observation", "SAO 258081"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.74908344),
        dec: Angle.Degrees(-79.71947560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133386"},
        {"Hipparcos Number", "HIP 74456"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.23312763),
        dec: Angle.Degrees(-79.71850884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47045"},
        {"Hipparcos Number", "HIP 30477"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.10267685),
        dec: Angle.Degrees(-79.71592283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124845"},
        {"Hipparcos Number", "HIP 70266"},
        {"Smithsonian Astrophysical Observation", "SAO 257143"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.65741727),
        dec: Angle.Degrees(-79.71580353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55279"},
        {"Hipparcos Number", "HIP 33737"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.12701251),
        dec: Angle.Degrees(-79.69625443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11656"},
        {"Hipparcos Number", "HIP 8419"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.15280650),
        dec: Angle.Degrees(-79.68952870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68374"},
        {"Hipparcos Number", "HIP 39255"},
        {"Smithsonian Astrophysical Observation", "SAO 256472"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.41835048),
        dec: Angle.Degrees(-79.68192440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36568"},
        {"Hipparcos Number", "HIP 24939"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.13857661),
        dec: Angle.Degrees(-79.68085214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72721"},
    },
    visualMagnitude: 12.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.02285088),
        dec: Angle.Degrees(-79.67963471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75328"},
        {"Hipparcos Number", "HIP 42539"},
        {"Geneva Identification System", "GEN# +1.00075328"},
        {"Smithsonian Astrophysical Observation", "SAO 256541"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.07770704),
        dec: Angle.Degrees(-79.67389066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83236"},
        {"Hipparcos Number", "HIP 46556"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.40758001),
        dec: Angle.Degrees(-79.67212511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64982"},
        {"Hipparcos Number", "HIP 37855"},
        {"Smithsonian Astrophysical Observation", "SAO 256450"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.39835843),
        dec: Angle.Degrees(-79.66904231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98617"},
        {"Hipparcos Number", "HIP 55225"},
        {"Fundamental Katalog 5th Edition", "FK5 2904"},
        {"Geneva Identification System", "GEN# +1.00098617"},
        {"Renson", "Renson 28420"},
        {"Smithsonian Astrophysical Observation", "SAO 256823"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.64252563),
        dec: Angle.Degrees(-79.66860236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149746"},
        {"Hipparcos Number", "HIP 82242"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.04129873),
        dec: Angle.Degrees(-79.66531005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4547"},
        {"Hipparcos Number", "HIP 3536"},
        {"Smithsonian Astrophysical Observation", "SAO 255702"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.27280357),
        dec: Angle.Degrees(-79.66394792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88326"},
        {"Hipparcos Number", "HIP 49423"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.32453010),
        dec: Angle.Degrees(-79.66285643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117076"},
        {"Hipparcos Number", "HIP 66023"},
        {"Smithsonian Astrophysical Observation", "SAO 257055"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.04532199),
        dec: Angle.Degrees(-79.66075679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212264"},
        {"Hipparcos Number", "HIP 110895"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.01338086),
        dec: Angle.Degrees(-79.65933599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67516"},
        {"Hipparcos Number", "HIP 38916"},
        {"Smithsonian Astrophysical Observation", "SAO 256464"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.46307887),
        dec: Angle.Degrees(-79.63267674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169506"},
        {"Hipparcos Number", "HIP 91271"},
        {"Geneva Identification System", "GEN# +1.00169506"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.26121430),
        dec: Angle.Degrees(-79.62913162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139668"},
        {"Henry Draper 2", "HD 139668A"},
        {"Hipparcos Number", "HIP 77492"},
        {"Geneva Identification System", "GEN# +1.00139668"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.34272974),
        dec: Angle.Degrees(-79.62341925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132930"},
        {"Hipparcos Number", "HIP 74240"},
        {"Geneva Identification System", "GEN# +1.00132930"},
        {"Smithsonian Astrophysical Observation", "SAO 257240"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.57884384),
        dec: Angle.Degrees(-79.61279570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50573"},
        {"Hipparcos Number", "HIP 32068"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.49903733),
        dec: Angle.Degrees(-79.60900098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137804"},
        {"Hipparcos Number", "HIP 76498"},
        {"Geneva Identification System", "GEN# +1.00137804"},
        {"Smithsonian Astrophysical Observation", "SAO 257294"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.35849436),
        dec: Angle.Degrees(-79.60806015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191735"},
        {"Hipparcos Number", "HIP 100416"},
        {"Geneva Identification System", "GEN# +5.22270010"},
        {"Smithsonian Astrophysical Observation", "SAO 257793"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.42985597),
        dec: Angle.Degrees(-79.59763196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19151"},
        {"Hipparcos Number", "HIP 13673"},
        {"Smithsonian Astrophysical Observation", "SAO 255939"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.02348624),
        dec: Angle.Degrees(-79.59206503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85128"},
        {"Hipparcos Number", "HIP 47658"},
        {"Fundamental Katalog 5th Edition", "FK5 4862"},
        {"Smithsonian Astrophysical Observation", "SAO 256651"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.75723227),
        dec: Angle.Degrees(-79.59171675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94717"},
        {"Hipparcos Number", "HIP 53151"},
        {"Geneva Identification System", "GEN# +1.00094717"},
        {"Smithsonian Astrophysical Observation", "SAO 256768"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.11945010),
        dec: Angle.Degrees(-79.55944198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206717"},
        {"Hipparcos Number", "HIP 107833"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.68521859),
        dec: Angle.Degrees(-79.54641214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144870"},
        {"Hipparcos Number", "HIP 79904"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.64501903),
        dec: Angle.Degrees(-79.54210825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9711"},
    },
    visualMagnitude: 12.85,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.23284511),
        dec: Angle.Degrees(-79.53800785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28566"},
        {"Hipparcos Number", "HIP 20144"},
        {"Smithsonian Astrophysical Observation", "SAO 256083"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.77648938),
        dec: Angle.Degrees(-79.52097701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92762"},
        {"Hipparcos Number", "HIP 52069"},
        {"Geneva Identification System", "GEN# +1.00092762"},
        {"Smithsonian Astrophysical Observation", "SAO 256740"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.60685526),
        dec: Angle.Degrees(-79.51006911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23547"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.95509223),
        dec: Angle.Degrees(-79.50714737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 174.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76236"},
        {"Hipparcos Number", "HIP 43012"},
        {"Geneva Identification System", "GEN# +1.00076236"},
        {"Smithsonian Astrophysical Observation", "SAO 256552"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.48014451),
        dec: Angle.Degrees(-79.50457035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55984"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.10936546),
        dec: Angle.Degrees(-79.50359066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8242"},
        {"Hipparcos Number", "HIP 6056"},
        {"Smithsonian Astrophysical Observation", "SAO 255760"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.43876702),
        dec: Angle.Degrees(-79.49561240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176298"},
        {"Hipparcos Number", "HIP 94255"},
        {"Smithsonian Astrophysical Observation", "SAO 257659"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.79115387),
        dec: Angle.Degrees(-79.49012639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218108"},
        {"Hipparcos Number", "HIP 114258"},
        {"Fundamental Katalog 5th Edition", "FK5 3847"},
        {"Geneva Identification System", "GEN# +1.00218108"},
        {"Smithsonian Astrophysical Observation", "SAO 258105"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.09809853),
        dec: Angle.Degrees(-79.48059990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126509"},
        {"Hipparcos Number", "HIP 71139"},
        {"Smithsonian Astrophysical Observation", "SAO 257169"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.23473109),
        dec: Angle.Degrees(-79.48021344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124318"},
        {"Hipparcos Number", "HIP 69992"},
        {"Smithsonian Astrophysical Observation", "SAO 257134"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.82427834),
        dec: Angle.Degrees(-79.47808690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158769"},
        {"Hipparcos Number", "HIP 86703"},
        {"Smithsonian Astrophysical Observation", "SAO 257519"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.73949330),
        dec: Angle.Degrees(-79.47786982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219572"},
        {"Hipparcos Number", "HIP 115129"},
        {"Geneva Identification System", "GEN# +1.00219572"},
        {"Smithsonian Astrophysical Observation", "SAO 258127"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.78561400),
        dec: Angle.Degrees(-79.47243616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152253"},
        {"Hipparcos Number", "HIP 83466"},
        {"Renson", "Renson 43090"},
        {"Smithsonian Astrophysical Observation", "SAO 257451"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.88985718),
        dec: Angle.Degrees(-79.46994023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13819"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.47217489),
        dec: Angle.Degrees(-79.46833428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107413"},
        {"Hipparcos Number", "HIP 60287"},
        {"Geneva Identification System", "GEN# +1.00107413"},
        {"Smithsonian Astrophysical Observation", "SAO 256932"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.43673634),
        dec: Angle.Degrees(-79.46657665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110677"},
        {"Hipparcos Number", "HIP 62287"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.46964773),
        dec: Angle.Degrees(-79.46224760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30554"},
        {"Hipparcos Number", "HIP 21519"},
        {"Geneva Identification System", "GEN# +1.00030554"},
        {"Smithsonian Astrophysical Observation", "SAO 256114"},
        {"Wilson Evans Batten Catalogue", "WEB 4131"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.31385916),
        dec: Angle.Degrees(-79.45933952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78694"},
        {"Hipparcos Number", "HIP 44296"},
        {"Smithsonian Astrophysical Observation", "SAO 256578"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.32577742),
        dec: Angle.Degrees(-79.45617867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204904"},
        {"Hipparcos Number", "HIP 106881"},
        {"Fundamental Katalog 5th Edition", "FK5 3723"},
        {"Geneva Identification System", "GEN# +1.00204904"},
        {"Smithsonian Astrophysical Observation", "SAO 257942"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.73396995),
        dec: Angle.Degrees(-79.44251799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219332"},
        {"Hipparcos Number", "HIP 114991"},
        {"Geneva Identification System", "GEN# +1.00219332"},
        {"Smithsonian Astrophysical Observation", "SAO 258125"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.35028989),
        dec: Angle.Degrees(-79.43358373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57336"},
        {"Hipparcos Number", "HIP 34554"},
        {"Fundamental Katalog 5th Edition", "FK5 4646"},
        {"Geneva Identification System", "GEN# +1.00057336"},
        {"Smithsonian Astrophysical Observation", "SAO 256381"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.37722557),
        dec: Angle.Degrees(-79.43201830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188520"},
        {"Hipparcos Number", "HIP 99013"},
        {"Fundamental Katalog 5th Edition", "FK5 5770"},
        {"Geneva Identification System", "GEN# +5.22270014"},
        {"Smithsonian Astrophysical Observation", "SAO 257764"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.51982210),
        dec: Angle.Degrees(-79.42319769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63568"},
        {"Hipparcos Number", "HIP 37231"},
        {"Smithsonian Astrophysical Observation", "SAO 256437"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.71101126),
        dec: Angle.Degrees(-79.42141964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54239"},
        {"Hipparcos Number", "HIP 33384"},
        {"Fundamental Katalog 5th Edition", "FK5 2545"},
        {"Geneva Identification System", "GEN# +1.00054239"},
        {"Smithsonian Astrophysical Observation", "SAO 256355"},
        {"Wilson Evans Batten Catalogue", "WEB 6713"},
    },
    visualMagnitude: 5.45,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.14366809),
        dec: Angle.Degrees(-79.42018913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140316"},
        {"Hipparcos Number", "HIP 77761"},
        {"Fundamental Katalog 5th Edition", "FK5 5404"},
        {"Smithsonian Astrophysical Observation", "SAO 257326"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.16865895),
        dec: Angle.Degrees(-79.40381546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192966"},
        {"Hipparcos Number", "HIP 100913"},
        {"Geneva Identification System", "GEN# +5.22270007"},
        {"Smithsonian Astrophysical Observation", "SAO 257806"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.90410381),
        dec: Angle.Degrees(-79.39334508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20856"},
        {"Hipparcos Number", "HIP 14900"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.06747256),
        dec: Angle.Degrees(-79.38909565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112857"},
        {"Hipparcos Number", "HIP 63639"},
        {"Geneva Identification System", "GEN# +1.00112857"},
        {"Smithsonian Astrophysical Observation", "SAO 256999"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.64844357),
        dec: Angle.Degrees(-79.36516158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40953"},
        {"Hipparcos Number", "HIP 27566"},
        {"Fundamental Katalog 5th Edition", "FK5 2451"},
        {"Geneva Identification System", "GEN# +1.00040953"},
        {"Smithsonian Astrophysical Observation", "SAO 256248"},
        {"Wilson Evans Batten Catalogue", "WEB 5413"},
    },
    visualMagnitude: 5.46,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.56999717),
        dec: Angle.Degrees(-79.36152292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98498"},
        {"Hipparcos Number", "HIP 55156"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.38788138),
        dec: Angle.Degrees(-79.35997497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58285"},
    },
    visualMagnitude: 11.86,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.30689866),
        dec: Angle.Degrees(-79.35873732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80257"},
        {"Hipparcos Number", "HIP 45071"},
        {"Smithsonian Astrophysical Observation", "SAO 256593"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.70196417),
        dec: Angle.Degrees(-79.35863568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32110"},
        {"Hipparcos Number", "HIP 22404"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.31997104),
        dec: Angle.Degrees(-79.35614739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121905"},
        {"Hipparcos Number", "HIP 68712"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.00188939),
        dec: Angle.Degrees(-79.35529879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210332"},
        {"Hipparcos Number", "HIP 109878"},
        {"Smithsonian Astrophysical Observation", "SAO 258014"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.81913948),
        dec: Angle.Degrees(-79.35288097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19433"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.42963670),
        dec: Angle.Degrees(-79.34374835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80981"},
        {"Hipparcos Number", "HIP 45419"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.82409878),
        dec: Angle.Degrees(-79.33240847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70953"},
        {"Hipparcos Number", "HIP 40415"},
        {"Geneva Identification System", "GEN# +1.00070953"},
        {"Smithsonian Astrophysical Observation", "SAO 256491"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.75740291),
        dec: Angle.Degrees(-79.31875496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1964"},
        {"Hipparcos Number", "HIP 1790"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.69099076),
        dec: Angle.Degrees(-79.31283728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106911"},
        {"Hipparcos Number", "HIP 60000"},
        {"Fundamental Katalog 5th Edition", "FK5 459"},
        {"Geneva Identification System", "GEN# +1.00106911"},
        {"Smithsonian Astrophysical Observation", "SAO 256924"},
        {"Wilson Evans Batten Catalogue", "WEB 10663"},
    },
    visualMagnitude: 4.24,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.58726633),
        dec: Angle.Degrees(-79.31226899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10672"},
        {"Hipparcos Number", "HIP 7696"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.76854480),
        dec: Angle.Degrees(-79.30960207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27086"},
        {"Smithsonian Astrophysical Observation", "SAO 256236"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.14852655),
        dec: Angle.Degrees(-79.30762178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101917"},
        {"Hipparcos Number", "HIP 57137"},
        {"Geneva Identification System", "GEN# +1.00101917"},
        {"Smithsonian Astrophysical Observation", "SAO 256865"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.72721843),
        dec: Angle.Degrees(-79.30636263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136135"},
        {"Hipparcos Number", "HIP 75692"},
        {"Smithsonian Astrophysical Observation", "SAO 257274"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.94622912),
        dec: Angle.Degrees(-79.30621173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211134"},
        {"Hipparcos Number", "HIP 110282"},
        {"Smithsonian Astrophysical Observation", "SAO 258022"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.07796536),
        dec: Angle.Degrees(-79.29479781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208103"},
        {"Hipparcos Number", "HIP 108615"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.04737102),
        dec: Angle.Degrees(-79.29193684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114555"},
        {"Hipparcos Number", "HIP 64621"},
        {"Geneva Identification System", "GEN# +1.00114555"},
        {"Smithsonian Astrophysical Observation", "SAO 257020"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.66901595),
        dec: Angle.Degrees(-79.29127736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160268"},
        {"Hipparcos Number", "HIP 87327"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.65684608),
        dec: Angle.Degrees(-79.29061572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200088"},
        {"Hipparcos Number", "HIP 104453"},
        {"Fundamental Katalog 5th Edition", "FK5 5864"},
        {"Geneva Identification System", "GEN# +1.00200088"},
        {"Smithsonian Astrophysical Observation", "SAO 257886"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.38904449),
        dec: Angle.Degrees(-79.27385567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167448"},
        {"Hipparcos Number", "HIP 90421"},
        {"Smithsonian Astrophysical Observation", "SAO 257590"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.73990408),
        dec: Angle.Degrees(-79.26936306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55085"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.17262951),
        dec: Angle.Degrees(-79.26465467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142793"},
        {"Hipparcos Number", "HIP 78900"},
        {"Smithsonian Astrophysical Observation", "SAO 257355"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.59608466),
        dec: Angle.Degrees(-79.25821964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69"},
        {"Hipparcos Number", "HIP 446"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.34229760),
        dec: Angle.Degrees(-79.25391278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122455"},
        {"Hipparcos Number", "HIP 69020"},
        {"Smithsonian Astrophysical Observation", "SAO 257114"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.94565434),
        dec: Angle.Degrees(-79.25148841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101251"},
        {"Hipparcos Number", "HIP 56728"},
        {"Smithsonian Astrophysical Observation", "SAO 256858"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.45548842),
        dec: Angle.Degrees(-79.24213369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6916"},
        {"Hipparcos Number", "HIP 5162"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.51843812),
        dec: Angle.Degrees(-79.23608522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1455"},
        {"Hipparcos Number", "HIP 1425"},
        {"Geneva Identification System", "GEN# +1.00001455"},
        {"Smithsonian Astrophysical Observation", "SAO 255655"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.45528702),
        dec: Angle.Degrees(-79.23233724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171405"},
        {"Hipparcos Number", "HIP 92097"},
        {"Smithsonian Astrophysical Observation", "SAO 257622"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.55312983),
        dec: Angle.Degrees(-79.22587235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42733"},
        {"Hipparcos Number", "HIP 28461"},
        {"Smithsonian Astrophysical Observation", "SAO 256264"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.14169154),
        dec: Angle.Degrees(-79.22074947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174565"},
        {"Hipparcos Number", "HIP 93496"},
        {"Geneva Identification System", "GEN# +1.00174565"},
        {"Smithsonian Astrophysical Observation", "SAO 257647"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.61148556),
        dec: Angle.Degrees(-79.21525875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74306"},
        {"Hipparcos Number", "HIP 42054"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.57975105),
        dec: Angle.Degrees(-79.21321367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8937"},
        {"Hipparcos Number", "HIP 6518"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.92486898),
        dec: Angle.Degrees(-79.21187983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181747"},
        {"Hipparcos Number", "HIP 96118"},
        {"Geneva Identification System", "GEN# +1.00181747"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.14913128),
        dec: Angle.Degrees(-79.19441144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114534"},
        {"Hipparcos Number", "HIP 64612"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.65017101),
        dec: Angle.Degrees(-79.19350564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124546"},
        {"Hipparcos Number", "HIP 70094"},
        {"Geneva Identification System", "GEN# +1.00124546"},
        {"Smithsonian Astrophysical Observation", "SAO 257138"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.15169804),
        dec: Angle.Degrees(-79.18876257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5467"},
        {"Hipparcos Number", "HIP 4210"},
        {"Smithsonian Astrophysical Observation", "SAO 255719"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.42767922),
        dec: Angle.Degrees(-79.17178746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59973"},
        {"Hipparcos Number", "HIP 35671"},
        {"Smithsonian Astrophysical Observation", "SAO 256406"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.40104696),
        dec: Angle.Degrees(-79.16470248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223646"},
        {"Hipparcos Number", "HIP 117675"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.97433028),
        dec: Angle.Degrees(-79.16198918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68039"},
        {"Hipparcos Number", "HIP 39173"},
        {"Smithsonian Astrophysical Observation", "SAO 256469"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.18352459),
        dec: Angle.Degrees(-79.15763025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10859"},
        {"Hipparcos Number", "HIP 7879"},
        {"Geneva Identification System", "GEN# +1.00010859J"},
        {"Smithsonian Astrophysical Observation", "SAO 255806"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.33868782),
        dec: Angle.Degrees(-79.14825374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133921"},
        {"Hipparcos Number", "HIP 74663"},
        {"Smithsonian Astrophysical Observation", "SAO 257252"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.86579043),
        dec: Angle.Degrees(-79.13642926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173778"},
        {"Hipparcos Number", "HIP 93139"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.60053557),
        dec: Angle.Degrees(-79.13262641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90887"},
        {"Hipparcos Number", "HIP 50984"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.22235310),
        dec: Angle.Degrees(-79.12865527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128813"},
        {"Hipparcos Number", "HIP 72233"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.58258750),
        dec: Angle.Degrees(-79.11993302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189487"},
        {"Hipparcos Number", "HIP 99379"},
        {"Geneva Identification System", "GEN# +5.22270013"},
        {"Smithsonian Astrophysical Observation", "SAO 257775"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.56456075),
        dec: Angle.Degrees(-79.11062492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16522"},
        {"Hipparcos Number", "HIP 11757"},
        {"Fundamental Katalog 5th Edition", "FK5 90"},
        {"Geneva Identification System", "GEN# +1.00016522"},
        {"Smithsonian Astrophysical Observation", "SAO 255898"},
        {"Wilson Evans Batten Catalogue", "WEB 2439"},
    },
    visualMagnitude: 5.27,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.91716991),
        dec: Angle.Degrees(-79.10924959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23549"},
        {"Hipparcos Number", "HIP 16815"},
        {"Fundamental Katalog 5th Edition", "FK5 4320"},
        {"Smithsonian Astrophysical Observation", "SAO 256007"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.10429036),
        dec: Angle.Degrees(-79.09864272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62155"},
        {"Hipparcos Number", "HIP 36638"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.01818738),
        dec: Angle.Degrees(-79.09620906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60816"},
        {"Hipparcos Number", "HIP 36039"},
        {"Fundamental Katalog 5th Edition", "FK5 2583"},
        {"Geneva Identification System", "GEN# +1.00060816"},
        {"Smithsonian Astrophysical Observation", "SAO 256415"},
        {"Wilson Evans Batten Catalogue", "WEB 7180"},
    },
    visualMagnitude: 5.54,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.40911866),
        dec: Angle.Degrees(-79.09420265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196293"},
        {"Hipparcos Number", "HIP 102428"},
        {"Smithsonian Astrophysical Observation", "SAO 257844"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.33627384),
        dec: Angle.Degrees(-79.09008180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137607"},
        {"Hipparcos Number", "HIP 76378"},
        {"Renson", "Renson 39130"},
        {"Smithsonian Astrophysical Observation", "SAO 257293"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.98909294),
        dec: Angle.Degrees(-79.08602275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52627"},
        {"Hipparcos Number", "HIP 32840"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.68511343),
        dec: Angle.Degrees(-79.08380033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3614"},
        {"Hipparcos Number", "HIP 2925"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.27537311),
        dec: Angle.Degrees(-79.08226868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117155"},
        {"Hipparcos Number", "HIP 66069"},
        {"Smithsonian Astrophysical Observation", "SAO 257057"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.17320559),
        dec: Angle.Degrees(-79.07490314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82423"},
        {"Hipparcos Number", "HIP 46148"},
        {"Smithsonian Astrophysical Observation", "SAO 256620"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.16944596),
        dec: Angle.Degrees(-79.07467836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191631"},
        {"Hipparcos Number", "HIP 100303"},
        {"Geneva Identification System", "GEN# +5.22270021"},
        {"Smithsonian Astrophysical Observation", "SAO 257791"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.14931623),
        dec: Angle.Degrees(-79.07111486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75747"},
        {"Hipparcos Number", "HIP 42794"},
        {"Geneva Identification System", "GEN# +1.00075747"},
        {"Smithsonian Astrophysical Observation", "SAO 256549"},
        {"Wilson Evans Batten Catalogue", "WEB 8266"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.80128686),
        dec: Angle.Degrees(-79.07015010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46262"},
        {"Hipparcos Number", "HIP 30170"},
        {"Smithsonian Astrophysical Observation", "SAO 256300"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.22447875),
        dec: Angle.Degrees(-79.06680087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84369"},
    },
    visualMagnitude: 12.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.72919674),
        dec: Angle.Degrees(-79.06657432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
