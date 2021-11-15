using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_118() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166818"},
        {"Hipparcos Number", "HIP 87057"},
        {"Geneva Identification System", "GEN# +1.00166818"},
        {"Smithsonian Astrophysical Observation", "SAO 2965"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.85200537),
        dec: Angle.Degrees(+84.70267893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99884"},
        {"Hipparcos Number", "HIP 56340"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.24184864),
        dec: Angle.Degrees(+84.70624046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64861"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.42454329),
        dec: Angle.Degrees(+84.71566131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 274.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189805"},
        {"Hipparcos Number", "HIP 96839"},
        {"Smithsonian Astrophysical Observation", "SAO 3287"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.27102230),
        dec: Angle.Degrees(+84.72973456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11281"},
        {"Hipparcos Number", "HIP 9467"},
        {"Geneva Identification System", "GEN# +1.00011281"},
        {"Smithsonian Astrophysical Observation", "SAO 321"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.45870038),
        dec: Angle.Degrees(+84.74078902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91828"},
        {"Hipparcos Number", "HIP 52586"},
        {"Smithsonian Astrophysical Observation", "SAO 1757"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.29351827),
        dec: Angle.Degrees(+84.74446252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116459"},
        {"Hipparcos Number", "HIP 64655"},
        {"Fundamental Katalog 5th Edition", "FK5 5168"},
        {"Geneva Identification System", "GEN# +1.00116459"},
        {"Smithsonian Astrophysical Observation", "SAO 2186"},
        {"Wilson Evans Batten Catalogue", "WEB 11437"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.80131614),
        dec: Angle.Degrees(+84.75210233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156401"},
        {"Hipparcos Number", "HIP 82630"},
        {"Smithsonian Astrophysical Observation", "SAO 2799"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.37081399),
        dec: Angle.Degrees(+84.76426414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189205"},
        {"Hipparcos Number", "HIP 96542"},
        {"Geneva Identification System", "GEN# +1.00189205"},
        {"Smithsonian Astrophysical Observation", "SAO 3273"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.40430946),
        dec: Angle.Degrees(+84.77143840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216720"},
        {"Hipparcos Number", "HIP 112592"},
        {"Smithsonian Astrophysical Observation", "SAO 3799"},
        {"Wilson Evans Batten Catalogue", "WEB 20074"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.05405459),
        dec: Angle.Degrees(+84.77600579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183677"},
        {"Hipparcos Number", "HIP 93976"},
        {"Smithsonian Astrophysical Observation", "SAO 3190"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.01779157),
        dec: Angle.Degrees(+84.77834337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116818"},
        {"Smithsonian Astrophysical Observation", "SAO 3950"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.15393069),
        dec: Angle.Degrees(+84.81439118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22499"},
        {"Hipparcos Number", "HIP 18468"},
        {"Fundamental Katalog 5th Edition", "FK5 4359"},
        {"Smithsonian Astrophysical Observation", "SAO 600"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.21086814),
        dec: Angle.Degrees(+84.81931023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107982",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107982"},
        {"Smithsonian Astrophysical Observation", "SAO 3660"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.13380245),
        dec: Angle.Degrees(+84.82369643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141155"},
        {"Hipparcos Number", "HIP 75634"},
        {"Fundamental Katalog 5th Edition", "FK5 3959"},
        {"Geneva Identification System", "GEN# +1.00141155"},
        {"Smithsonian Astrophysical Observation", "SAO 2566"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.79335596),
        dec: Angle.Degrees(+84.82536298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29475"},
        {"Hipparcos Number", "HIP 23392"},
        {"Fundamental Katalog 5th Edition", "FK5 4461"},
        {"Smithsonian Astrophysical Observation", "SAO 772"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.42673472),
        dec: Angle.Degrees(+84.87256122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20084"},
        {"Hipparcos Number", "HIP 16489"},
        {"Fundamental Katalog 5th Edition", "FK5 1636"},
        {"Geneva Identification System", "GEN# +1.00020084"},
        {"Smithsonian Astrophysical Observation", "SAO 550"},
        {"Wilson Evans Batten Catalogue", "WEB 3149"},
    },
    visualMagnitude: 5.62,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.08214603),
        dec: Angle.Degrees(+84.91136314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1119"},
        {"Hipparcos Number", "HIP 1359"},
        {"Smithsonian Astrophysical Observation", "SAO 43"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.26178754),
        dec: Angle.Degrees(+84.95506750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55024"},
        {"Smithsonian Astrophysical Observation", "SAO 1840"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.97644548),
        dec: Angle.Degrees(+84.95846438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38847"},
        {"Hipparcos Number", "HIP 29600"},
        {"Geneva Identification System", "GEN# +1.00038847"},
        {"Smithsonian Astrophysical Observation", "SAO 947"},
        {"Wilson Evans Batten Catalogue", "WEB 5821"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.56266963),
        dec: Angle.Degrees(+84.98631828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 147.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217158"},
        {"Hipparcos Number", "HIP 112882"},
        {"Fundamental Katalog 5th Edition", "FK5 6018"},
        {"Smithsonian Astrophysical Observation", "SAO 3809"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.89032849),
        dec: Angle.Degrees(+85.04636467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71986"},
        {"Hipparcos Number", "HIP 43446"},
        {"Geneva Identification System", "GEN# +1.00071986"},
        {"Smithsonian Astrophysical Observation", "SAO 1381"},
        {"Wilson Evans Batten Catalogue", "WEB 8374"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.73030475),
        dec: Angle.Degrees(+85.05120044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14955"},
        {"Hipparcos Number", "HIP 12410"},
        {"Geneva Identification System", "GEN# +1.00014955"},
        {"Smithsonian Astrophysical Observation", "SAO 405"},
        {"Wilson Evans Batten Catalogue", "WEB 2541"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.94815368),
        dec: Angle.Degrees(+85.05951114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213593"},
        {"Hipparcos Number", "HIP 110485"},
        {"Smithsonian Astrophysical Observation", "SAO 3742"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.70000360),
        dec: Angle.Degrees(+85.06168619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79100"},
        {"Smithsonian Astrophysical Observation", "SAO 2684"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.18760327),
        dec: Angle.Degrees(+85.07031110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223383"},
        {"Hipparcos Number", "HIP 117350"},
        {"Geneva Identification System", "GEN# +1.00223383"},
        {"Smithsonian Astrophysical Observation", "SAO 3972"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.90815841),
        dec: Angle.Degrees(+85.07839605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105942"},
        {"Hipparcos Number", "HIP 59355"},
        {"Smithsonian Astrophysical Observation", "SAO 1989"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.65558983),
        dec: Angle.Degrees(+85.07880505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194836"},
        {"Hipparcos Number", "HIP 99091"},
        {"Smithsonian Astrophysical Observation", "SAO 3357"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.75450677),
        dec: Angle.Degrees(+85.09073006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81263"},
        {"Hipparcos Number", "HIP 47506"},
        {"Fundamental Katalog 5th Edition", "FK5 4859"},
        {"Smithsonian Astrophysical Observation", "SAO 1553"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.28091543),
        dec: Angle.Degrees(+85.09246725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3065"},
        {"Hipparcos Number", "HIP 2953"},
        {"Smithsonian Astrophysical Observation", "SAO 99"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.37696415),
        dec: Angle.Degrees(+85.09269876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135280"},
        {"Hipparcos Number", "HIP 72973"},
        {"Smithsonian Astrophysical Observation", "SAO 2477"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.69673051),
        dec: Angle.Degrees(+85.12091193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195146"},
        {"Hipparcos Number", "HIP 99232"},
        {"Geneva Identification System", "GEN# +1.00195146"},
        {"Smithsonian Astrophysical Observation", "SAO 3362"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.15168577),
        dec: Angle.Degrees(+85.12426960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62908"},
        {"Smithsonian Astrophysical Observation", "SAO 2114"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.39502031),
        dec: Angle.Degrees(+85.12945972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6325"},
        {"Geneva Identification System", "GEN# +0.08400019"},
        {"Smithsonian Astrophysical Observation", "SAO 220"},
        {"Wilson Evans Batten Catalogue", "WEB 1409"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.29919637),
        dec: Angle.Degrees(+85.13211173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36905"},
        {"Hipparcos Number", "HIP 28532"},
        {"Fundamental Katalog 5th Edition", "FK5 1638"},
        {"Geneva Identification System", "GEN# +1.00036905"},
        {"Smithsonian Astrophysical Observation", "SAO 914"},
        {"Wilson Evans Batten Catalogue", "WEB 5577"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.33404742),
        dec: Angle.Degrees(+85.18211809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31095"},
        {"Hipparcos Number", "HIP 24745"},
        {"Smithsonian Astrophysical Observation", "SAO 813"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.59179418),
        dec: Angle.Degrees(+85.18882929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72407"},
        {"Hipparcos Number", "HIP 43662"},
        {"Geneva Identification System", "GEN# +1.00072407"},
        {"Smithsonian Astrophysical Observation", "SAO 1389"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.42876005),
        dec: Angle.Degrees(+85.18903310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4349",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4349"},
        {"Geneva Identification System", "GEN# +2.01880010"},
    },
    visualMagnitude: 10.93,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.93913878),
        dec: Angle.Degrees(+85.20580763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8520",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1366 A"},
        {"Henry Draper", "HD 10124"},
        {"Hipparcos Number", "HIP 8520"},
        {"Smithsonian Astrophysical Observation", "SAO 282"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.47304957),
        dec: Angle.Degrees(+85.21555596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38831"},
        {"Smithsonian Astrophysical Observation", "SAO 1236"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.19707558),
        dec: Angle.Degrees(+85.22033040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90235"},
        {"Hipparcos Number", "HIP 51886"},
        {"Smithsonian Astrophysical Observation", "SAO 1723"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.02067219),
        dec: Angle.Degrees(+85.23147709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3354"},
        {"Geneva Identification System", "GEN# +2.01882029"},
        {"Smithsonian Astrophysical Observation", "SAO 111"},
        {"New General Catalogue", "NGC 188 2029"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.67959748),
        dec: Angle.Degrees(+85.23725951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47833"},
        {"Smithsonian Astrophysical Observation", "SAO 1562"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.25028411),
        dec: Angle.Degrees(+85.24449444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18436"},
        {"Smithsonian Astrophysical Observation", "SAO 595"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.12504417),
        dec: Angle.Degrees(+85.25326875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23577"},
        {"Smithsonian Astrophysical Observation", "SAO 776"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.04204990),
        dec: Angle.Degrees(+85.25932172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118523"},
        {"Hipparcos Number", "HIP 65572"},
        {"Geneva Identification System", "GEN# +1.00118523"},
        {"Smithsonian Astrophysical Observation", "SAO 2222"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.66099428),
        dec: Angle.Degrees(+85.27062760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129560"},
        {"Hipparcos Number", "HIP 70534"},
        {"Smithsonian Astrophysical Observation", "SAO 2393"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.44021883),
        dec: Angle.Degrees(+85.27297763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37599"},
        {"Hipparcos Number", "HIP 28956"},
        {"Geneva Identification System", "GEN# +1.00037599"},
        {"Smithsonian Astrophysical Observation", "SAO 925"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.67003117),
        dec: Angle.Degrees(+85.28459962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143802"},
        {"Hipparcos Number", "HIP 76632"},
        {"Fundamental Katalog 5th Edition", "FK5 5383"},
        {"Geneva Identification System", "GEN# +1.00143802"},
        {"Smithsonian Astrophysical Observation", "SAO 2603"},
        {"Wilson Evans Batten Catalogue", "WEB 13012"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.74938454),
        dec: Angle.Degrees(+85.28585695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71866",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71866"},
        {"Smithsonian Astrophysical Observation", "SAO 2452"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.49008514),
        dec: Angle.Degrees(+85.29498650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3297"},
        {"Geneva Identification System", "GEN# +2.01883138"},
        {"Smithsonian Astrophysical Observation", "SAO 109"},
        {"New General Catalogue", "NGC 188 3138"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.51355766),
        dec: Angle.Degrees(+85.34706474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93212"},
        {"Hipparcos Number", "HIP 53352"},
        {"Geneva Identification System", "GEN# +1.00093212"},
        {"Smithsonian Astrophysical Observation", "SAO 1776"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.67387743),
        dec: Angle.Degrees(+85.36213412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187216"},
        {"Hipparcos Number", "HIP 95392"},
        {"Geneva Identification System", "GEN# +1.00187216"},
        {"Smithsonian Astrophysical Observation", "SAO 3243"},
        {"Wilson Evans Batten Catalogue", "WEB 16672"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.07656402),
        dec: Angle.Degrees(+85.36587644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217157"},
        {"Hipparcos Number", "HIP 112833"},
        {"Geneva Identification System", "GEN# +1.00217157"},
        {"Smithsonian Astrophysical Observation", "SAO 3808"},
        {"Wilson Evans Batten Catalogue", "WEB 20098"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.76223899),
        dec: Angle.Degrees(+85.37346100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174"},
        {"Hipparcos Number", "HIP 583"},
        {"Smithsonian Astrophysical Observation", "SAO 17"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.77548337),
        dec: Angle.Degrees(+85.40485204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211681"},
        {"Hipparcos Number", "HIP 109169"},
        {"Geneva Identification System", "GEN# +1.00211681"},
        {"Smithsonian Astrophysical Observation", "SAO 3704"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.70177461),
        dec: Angle.Degrees(+85.40918479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87787"},
        {"Hipparcos Number", "HIP 50675"},
        {"Geneva Identification System", "GEN# +1.00087787"},
        {"Smithsonian Astrophysical Observation", "SAO 1666"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.22206304),
        dec: Angle.Degrees(+85.43384538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222874"},
        {"Hipparcos Number", "HIP 116945"},
        {"Fundamental Katalog 5th Edition", "FK5 6097"},
        {"Smithsonian Astrophysical Observation", "SAO 3956"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.57732941),
        dec: Angle.Degrees(+85.46857574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88554"},
        {"Smithsonian Astrophysical Observation", "SAO 3006"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.23079314),
        dec: Angle.Degrees(+85.47110452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26367"},
        {"Hipparcos Number", "HIP 21386"},
        {"Fundamental Katalog 5th Edition", "FK5 908"},
        {"Geneva Identification System", "GEN# +1.00026367"},
        {"Smithsonian Astrophysical Observation", "SAO 695"},
        {"Wilson Evans Batten Catalogue", "WEB 4104"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.85037936),
        dec: Angle.Degrees(+85.52700667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102120"},
        {"Hipparcos Number", "HIP 57523"},
        {"Smithsonian Astrophysical Observation", "SAO 1932"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.85193058),
        dec: Angle.Degrees(+85.53250815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95603"},
        {"Hipparcos Number", "HIP 54534"},
        {"Geneva Identification System", "GEN# +1.00095603"},
        {"Smithsonian Astrophysical Observation", "SAO 1819"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.39442172),
        dec: Angle.Degrees(+85.54421382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75797"},
        {"Hipparcos Number", "HIP 45241"},
        {"Smithsonian Astrophysical Observation", "SAO 1443"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.32662223),
        dec: Angle.Degrees(+85.55772149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47976"},
        {"Hipparcos Number", "HIP 34575"},
        {"Fundamental Katalog 5th Edition", "FK5 4647"},
        {"Smithsonian Astrophysical Observation", "SAO 1101"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.41458494),
        dec: Angle.Degrees(+85.57000265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30744"},
    },
    visualMagnitude: 12.43,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.91037527),
        dec: Angle.Degrees(+85.58647840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104904"},
        {"Hipparcos Number", "HIP 58874"},
        {"Fundamental Katalog 5th Edition", "FK5 1642"},
        {"Geneva Identification System", "GEN# +1.00104904"},
        {"Smithsonian Astrophysical Observation", "SAO 1975"},
        {"Wilson Evans Batten Catalogue", "WEB 10487"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.11887598),
        dec: Angle.Degrees(+85.58691106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91333"},
        {"Smithsonian Astrophysical Observation", "SAO 3113"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.43034599),
        dec: Angle.Degrees(+85.60863992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152643"},
        {"Hipparcos Number", "HIP 80561"},
        {"Fundamental Katalog 5th Edition", "FK5 5454"},
        {"Smithsonian Astrophysical Observation", "SAO 2738"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.71258505),
        dec: Angle.Degrees(+85.61698070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100432"},
        {"Hipparcos Number", "HIP 56666"},
        {"Geneva Identification System", "GEN# +1.00100432"},
        {"Smithsonian Astrophysical Observation", "SAO 1902"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.28691929),
        dec: Angle.Degrees(+85.61720871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19253"},
        {"Smithsonian Astrophysical Observation", "SAO 626"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.88006118),
        dec: Angle.Degrees(+85.62141235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96571"},
        {"Hipparcos Number", "HIP 54901"},
        {"Fundamental Katalog 5th Edition", "FK5 1641"},
        {"Geneva Identification System", "GEN# +1.00096571"},
        {"Renson", "Renson 27855"},
        {"Smithsonian Astrophysical Observation", "SAO 1834"},
        {"Wilson Evans Batten Catalogue", "WEB 9907"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.62763851),
        dec: Angle.Degrees(+85.64011167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34109"},
        {"Hipparcos Number", "HIP 27015"},
        {"Fundamental Katalog 5th Edition", "FK5 4527"},
        {"Geneva Identification System", "GEN# +1.00034109"},
        {"Smithsonian Astrophysical Observation", "SAO 873"},
        {"Wilson Evans Batten Catalogue", "WEB 5321"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.95400975),
        dec: Angle.Degrees(+85.66832839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104503"},
        {"Smithsonian Astrophysical Observation", "SAO 3540"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.53432858),
        dec: Angle.Degrees(+85.66951995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166798"},
        {"Hipparcos Number", "HIP 86695"},
        {"Fundamental Katalog 5th Edition", "FK5 5557"},
        {"Geneva Identification System", "GEN# +1.00166798"},
        {"Smithsonian Astrophysical Observation", "SAO 2958"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.70829365),
        dec: Angle.Degrees(+85.67013439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42716"},
        {"Smithsonian Astrophysical Observation", "SAO 1355"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.58535138),
        dec: Angle.Degrees(+85.68064374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65172"},
        {"Hipparcos Number", "HIP 41128"},
        {"Geneva Identification System", "GEN# +1.00065172"},
        {"Smithsonian Astrophysical Observation", "SAO 1312"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.87431851),
        dec: Angle.Degrees(+85.69222271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4710"},
        {"Hipparcos Number", "HIP 4320"},
        {"Fundamental Katalog 5th Edition", "FK5 4079"},
        {"Geneva Identification System", "GEN# +1.00004710"},
        {"Smithsonian Astrophysical Observation", "SAO 137"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.81781143),
        dec: Angle.Degrees(+85.70263603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110093"},
        {"Hipparcos Number", "HIP 61396"},
        {"Geneva Identification System", "GEN# +1.00110093"},
        {"Smithsonian Astrophysical Observation", "SAO 2057"},
        {"Wilson Evans Batten Catalogue", "WEB 10929"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.71503454),
        dec: Angle.Degrees(+85.73216141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12648"},
        {"Hipparcos Number", "HIP 10800"},
        {"Geneva Identification System", "GEN# +1.00012648"},
        {"Smithsonian Astrophysical Observation", "SAO 356"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.74897171),
        dec: Angle.Degrees(+85.73594814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36022",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5868 AB"},
        {"Henry Draper", "HD 51141"},
        {"Hipparcos Number", "HIP 36022"},
        {"Smithsonian Astrophysical Observation", "SAO 1148"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.35486544),
        dec: Angle.Degrees(+85.73899265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9504"},
        {"Smithsonian Astrophysical Observation", "SAO 318"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.57439137),
        dec: Angle.Degrees(+85.74182117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122882"},
        {"Hipparcos Number", "HIP 67437"},
        {"Geneva Identification System", "GEN# +1.00122882"},
        {"Smithsonian Astrophysical Observation", "SAO 2298"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.31618486),
        dec: Angle.Degrees(+85.74774453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74034"},
    },
    visualMagnitude: 11.14,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.94636020),
        dec: Angle.Degrees(+85.74990256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193135"},
        {"Hipparcos Number", "HIP 97910"},
        {"Smithsonian Astrophysical Observation", "SAO 3325"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.45309942),
        dec: Angle.Degrees(+85.75883247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78160"},
        {"Smithsonian Astrophysical Observation", "SAO 2665"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.40022559),
        dec: Angle.Degrees(+85.79571288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15374"},
        {"Hipparcos Number", "HIP 12952"},
        {"Smithsonian Astrophysical Observation", "SAO 418"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.64195262),
        dec: Angle.Degrees(+85.79933286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87171"},
        {"Hipparcos Number", "HIP 50482"},
        {"Smithsonian Astrophysical Observation", "SAO 1656"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.62756096),
        dec: Angle.Degrees(+85.82882021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17243"},
        {"Hipparcos Number", "HIP 14428"},
        {"Fundamental Katalog 5th Edition", "FK5 4283"},
        {"Geneva Identification System", "GEN# +1.00017243"},
        {"Smithsonian Astrophysical Observation", "SAO 472"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.56330826),
        dec: Angle.Degrees(+85.86357081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21500"},
        {"Smithsonian Astrophysical Observation", "SAO 699"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.26560018),
        dec: Angle.Degrees(+85.86721222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201748"},
        {"Hipparcos Number", "HIP 102893"},
        {"Geneva Identification System", "GEN# +1.00201748"},
        {"Smithsonian Astrophysical Observation", "SAO 3488"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.67743177),
        dec: Angle.Degrees(+85.86791553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102915"},
    },
    visualMagnitude: 11.30,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.74633707),
        dec: Angle.Degrees(+85.86796293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113591"},
        {"Hipparcos Number", "HIP 63163"},
        {"Geneva Identification System", "GEN# +1.00113591"},
        {"Smithsonian Astrophysical Observation", "SAO 2122"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.13037963),
        dec: Angle.Degrees(+85.88449157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81053"},
        {"Geneva Identification System", "GEN# +0.08600250"},
        {"Smithsonian Astrophysical Observation", "SAO 2756"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.30743342),
        dec: Angle.Degrees(+85.88825910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71161",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9358 AB"},
        {"Henry Draper", "HD 131616"},
        {"Hipparcos Number", "HIP 71161"},
        {"Smithsonian Astrophysical Observation", "SAO 2433"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.32413713),
        dec: Angle.Degrees(+85.93840516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32196"},
        {"Hipparcos Number", "HIP 25911"},
        {"Fundamental Katalog 5th Edition", "FK5 1637"},
        {"Geneva Identification System", "GEN# +1.00032196"},
        {"Renson", "Renson 8210"},
        {"Smithsonian Astrophysical Observation", "SAO 843"},
        {"Wilson Evans Batten Catalogue", "WEB 5032"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.94999407),
        dec: Angle.Degrees(+85.93871532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221344"},
        {"Hipparcos Number", "HIP 115753"},
        {"Geneva Identification System", "GEN# +1.00221344"},
        {"Smithsonian Astrophysical Observation", "SAO 3912"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.77049352),
        dec: Angle.Degrees(+86.00814429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 820"},
        {"Smithsonian Astrophysical Observation", "SAO 24"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.51916096),
        dec: Angle.Degrees(+86.02305546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220497"},
        {"Hipparcos Number", "HIP 115109"},
        {"Smithsonian Astrophysical Observation", "SAO 3892"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.72298355),
        dec: Angle.Degrees(+86.05659728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156374"},
        {"Hipparcos Number", "HIP 82019"},
        {"Smithsonian Astrophysical Observation", "SAO 2786"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.31850023),
        dec: Angle.Degrees(+86.06975776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185778"},
        {"Hipparcos Number", "HIP 94267"},
        {"Fundamental Katalog 5th Edition", "FK5 5688"},
        {"Smithsonian Astrophysical Observation", "SAO 3216"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.81411558),
        dec: Angle.Degrees(+86.07920945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28053"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.98233359),
        dec: Angle.Degrees(+86.08128320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212710"},
        {"Hipparcos Number", "HIP 109693"},
        {"Fundamental Katalog 5th Edition", "FK5 1648"},
        {"Geneva Identification System", "GEN# +1.00212710"},
        {"Smithsonian Astrophysical Observation", "SAO 3721"},
        {"Wilson Evans Batten Catalogue", "WEB 19704"},
    },
    visualMagnitude: 5.27,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.29239384),
        dec: Angle.Degrees(+86.10785672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70920"},
        {"Smithsonian Astrophysical Observation", "SAO 2421"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.54263144),
        dec: Angle.Degrees(+86.15351220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221829"},
        {"Hipparcos Number", "HIP 116109"},
        {"Geneva Identification System", "GEN# +1.00221829"},
        {"Smithsonian Astrophysical Observation", "SAO 3926"},
        {"Wilson Evans Batten Catalogue", "WEB 20526"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.89136702),
        dec: Angle.Degrees(+86.17808401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150265"},
        {"Hipparcos Number", "HIP 79069"},
        {"Smithsonian Astrophysical Observation", "SAO 2692"},
        {"Wilson Evans Batten Catalogue", "WEB 13367"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.11405869),
        dec: Angle.Degrees(+86.19983633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212774"},
        {"Hipparcos Number", "HIP 109694"},
        {"Smithsonian Astrophysical Observation", "SAO 3722"},
        {"Wilson Evans Batten Catalogue", "WEB 19708"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.29455184),
        dec: Angle.Degrees(+86.22134932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103126"},
        {"Hipparcos Number", "HIP 57992"},
        {"Smithsonian Astrophysical Observation", "SAO 1948"},
        {"Wilson Evans Batten Catalogue", "WEB 10389"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.42412743),
        dec: Angle.Degrees(+86.22977450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -222.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 241.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5848"},
        {"Hipparcos Number", "HIP 5372"},
        {"Fundamental Katalog 5th Edition", "FK5 906"},
        {"Geneva Identification System", "GEN# +1.00005848"},
        {"Smithsonian Astrophysical Observation", "SAO 181"},
        {"Wilson Evans Batten Catalogue", "WEB 1166"},
    },
    visualMagnitude: 4.24,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.18399735),
        dec: Angle.Degrees(+86.25711803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195587"},
        {"Hipparcos Number", "HIP 98913"},
        {"Smithsonian Astrophysical Observation", "SAO 3361"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.27635510),
        dec: Angle.Degrees(+86.26592012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30881"},
        {"Hipparcos Number", "HIP 25267"},
        {"Geneva Identification System", "GEN# +1.00030881"},
        {"Smithsonian Astrophysical Observation", "SAO 818"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.05773817),
        dec: Angle.Degrees(+86.28978155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116693"},
        {"Hipparcos Number", "HIP 64486"},
        {"Smithsonian Astrophysical Observation", "SAO 2184"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.27293066),
        dec: Angle.Degrees(+86.31627735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65864"},
        {"Smithsonian Astrophysical Observation", "SAO 2239"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.50142477),
        dec: Angle.Degrees(+86.32532112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56049"},
        {"Hipparcos Number", "HIP 38115"},
        {"Geneva Identification System", "GEN# +1.00056049"},
        {"Smithsonian Astrophysical Observation", "SAO 1201"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.16405761),
        dec: Angle.Degrees(+86.33381857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56322"},
        {"Hipparcos Number", "HIP 38225"},
        {"Geneva Identification System", "GEN# +1.00056322"},
        {"Smithsonian Astrophysical Observation", "SAO 1204"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.47528014),
        dec: Angle.Degrees(+86.36560204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64048"},
        {"Hipparcos Number", "HIP 41118"},
        {"Smithsonian Astrophysical Observation", "SAO 1303"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.84780501),
        dec: Angle.Degrees(+86.37867042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16754"},
        {"Smithsonian Astrophysical Observation", "SAO 546"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.88797052),
        dec: Angle.Degrees(+86.39978559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89787"},
        {"Smithsonian Astrophysical Observation", "SAO 3065"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.85036332),
        dec: Angle.Degrees(+86.40859007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115550",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16759 AB"},
        {"Henry Draper", "HD 221142"},
        {"Hipparcos Number", "HIP 115550"},
        {"Smithsonian Astrophysical Observation", "SAO 3904"},
        {"Wilson Evans Batten Catalogue", "WEB 20455"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.08713678),
        dec: Angle.Degrees(+86.41774505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107113"},
        {"Hipparcos Number", "HIP 59879"},
        {"Geneva Identification System", "GEN# +1.00107113"},
        {"Smithsonian Astrophysical Observation", "SAO 2012"},
        {"Wilson Evans Batten Catalogue", "WEB 10640"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.20562629),
        dec: Angle.Degrees(+86.43584319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208390"},
        {"Hipparcos Number", "HIP 106732"},
        {"Geneva Identification System", "GEN# +1.00208390"},
        {"Smithsonian Astrophysical Observation", "SAO 3626"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.30654644),
        dec: Angle.Degrees(+86.44139429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82753"},
        {"Hipparcos Number", "HIP 48677"},
        {"Smithsonian Astrophysical Observation", "SAO 1584"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.92385151),
        dec: Angle.Degrees(+86.44180756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74040"},
        {"Smithsonian Astrophysical Observation", "SAO 2524"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.97113101),
        dec: Angle.Degrees(+86.49149825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111103"},
        {"Smithsonian Astrophysical Observation", "SAO 3760"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.62037216),
        dec: Angle.Degrees(+86.52955831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170791"},
        {"Hipparcos Number", "HIP 87663"},
        {"Smithsonian Astrophysical Observation", "SAO 2994"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.59910176),
        dec: Angle.Degrees(+86.55860466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221488"},
        {"Hipparcos Number", "HIP 115813"},
        {"Geneva Identification System", "GEN# +1.00221488"},
        {"Smithsonian Astrophysical Observation", "SAO 3917"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.93345742),
        dec: Angle.Degrees(+86.55876618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85013"},
        {"Hipparcos Number", "HIP 49768"},
        {"Geneva Identification System", "GEN# +1.00085013"},
        {"Smithsonian Astrophysical Observation", "SAO 1628"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.38593872),
        dec: Angle.Degrees(+86.57655371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85822",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Yildun"},
        {"Henry Draper", "HD 166205"},
        {"Hipparcos Number", "HIP 85822"},
        {"Fundamental Katalog 5th Edition", "FK5 913"},
        {"Geneva Identification System", "GEN# +1.00166205"},
        {"Smithsonian Astrophysical Observation", "SAO 2937"},
        {"Wilson Evans Batten Catalogue", "WEB 14484"},
    },
    visualMagnitude: 4.35,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.05373826),
        dec: Angle.Degrees(+86.58632924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52842"},
    },
    visualMagnitude: 11.32,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.06470010),
        dec: Angle.Degrees(+86.58770604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22701"},
        {"Hipparcos Number", "HIP 19454"},
        {"Fundamental Katalog 5th Edition", "FK5 3947"},
        {"Geneva Identification System", "GEN# +1.00022701"},
        {"Smithsonian Astrophysical Observation", "SAO 623"},
        {"Wilson Evans Batten Catalogue", "WEB 3732"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.50093270),
        dec: Angle.Degrees(+86.62635165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95788"},
        {"Smithsonian Astrophysical Observation", "SAO 3266"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.24353869),
        dec: Angle.Degrees(+86.63121591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174878"},
        {"Hipparcos Number", "HIP 89465"},
        {"Fundamental Katalog 5th Edition", "FK5 3960"},
        {"Geneva Identification System", "GEN# +1.00174878"},
        {"Smithsonian Astrophysical Observation", "SAO 3059"},
        {"Wilson Evans Batten Catalogue", "WEB 15227"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.86952400),
        dec: Angle.Degrees(+86.65768383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42855"},
        {"Hipparcos Number", "HIP 32948"},
        {"Fundamental Katalog 5th Edition", "FK5 3949"},
        {"Geneva Identification System", "GEN# +1.00042855"},
        {"Smithsonian Astrophysical Observation", "SAO 1037"},
        {"Wilson Evans Batten Catalogue", "WEB 6632"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.94698942),
        dec: Angle.Degrees(+86.68459703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224687"},
        {"Hipparcos Number", "HIP 118285"},
        {"Smithsonian Astrophysical Observation", "SAO 4006"},
        {"Wilson Evans Batten Catalogue", "WEB 20792"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.87655685),
        dec: Angle.Degrees(+86.70640708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33143"},
        {"Smithsonian Astrophysical Observation", "SAO 1040"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.51484201),
        dec: Angle.Degrees(+86.72292246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245"},
        {"Hipparcos Number", "HIP 705"},
        {"Geneva Identification System", "GEN# +1.00000245"},
        {"Smithsonian Astrophysical Observation", "SAO 22"},
        {"Wilson Evans Batten Catalogue", "WEB 116"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.19740240),
        dec: Angle.Degrees(+86.78789828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 331.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82931",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10437 B"},
        {"Hipparcos Number", "HIP 82931"},
        {"Smithsonian Astrophysical Observation", "SAO 2825"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.22100298),
        dec: Angle.Degrees(+86.83789492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82968",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10437 A"},
        {"Henry Draper", "HD 160010"},
        {"Hipparcos Number", "HIP 82968"},
        {"Geneva Identification System", "GEN# +1.00160010"},
        {"Smithsonian Astrophysical Observation", "SAO 2828"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.32523355),
        dec: Angle.Degrees(+86.84446974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81003"},
        {"Hipparcos Number", "HIP 48163"},
        {"Geneva Identification System", "GEN# +1.00081003"},
        {"Smithsonian Astrophysical Observation", "SAO 1564"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.26016572),
        dec: Angle.Degrees(+86.85201160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29944"},
        {"Hipparcos Number", "HIP 25029"},
        {"Geneva Identification System", "GEN# +1.00029944"},
        {"Smithsonian Astrophysical Observation", "SAO 806"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.38846974),
        dec: Angle.Degrees(+86.86637898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72144"},
        {"Hipparcos Number", "HIP 44490"},
        {"Smithsonian Astrophysical Observation", "SAO 1403"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.97147688),
        dec: Angle.Degrees(+86.87710251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102243",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102243"},
        {"Smithsonian Astrophysical Observation", "SAO 3479"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.76383557),
        dec: Angle.Degrees(+86.88949974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10772"},
        {"Hipparcos Number", "HIP 9614"},
        {"Smithsonian Astrophysical Observation", "SAO 314"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.89305674),
        dec: Angle.Degrees(+86.93182634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106207"},
        {"Hipparcos Number", "HIP 59415"},
        {"Fundamental Katalog 5th Edition", "FK5 5079"},
        {"Smithsonian Astrophysical Observation", "SAO 1997"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.81815815),
        dec: Angle.Degrees(+86.93206181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7585"},
        {"Hipparcos Number", "HIP 6913"},
        {"Smithsonian Astrophysical Observation", "SAO 233"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.25518267),
        dec: Angle.Degrees(+86.93306587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94010"},
        {"Smithsonian Astrophysical Observation", "SAO 3220"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.10705380),
        dec: Angle.Degrees(+86.93653974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166926"},
        {"Hipparcos Number", "HIP 85699"},
        {"Geneva Identification System", "GEN# +1.00166926"},
        {"Renson", "Renson 46970"},
        {"Smithsonian Astrophysical Observation", "SAO 2940"},
        {"Wilson Evans Batten Catalogue", "WEB 14462"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.69570753),
        dec: Angle.Degrees(+86.96802383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58531",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8382 A"},
        {"Henry Draper", "HD 104147"},
        {"Hipparcos Number", "HIP 58531"},
        {"Smithsonian Astrophysical Observation", "SAO 1966"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.04512436),
        dec: Angle.Degrees(+86.99444426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58508",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8382 B"},
        {"Hipparcos Number", "HIP 58508"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.98731072),
        dec: Angle.Degrees(+86.99519709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207779"},
        {"Hipparcos Number", "HIP 106030"},
        {"Smithsonian Astrophysical Observation", "SAO 3601"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.13558318),
        dec: Angle.Degrees(+87.00173513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138465"},
        {"Hipparcos Number", "HIP 73264"},
        {"Geneva Identification System", "GEN# +1.00138465"},
        {"Smithsonian Astrophysical Observation", "SAO 2506"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.59368634),
        dec: Angle.Degrees(+87.00628486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37391",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "51 H. Cep"},
        {"Henry Draper", "HD 51802"},
        {"Hipparcos Number", "HIP 37391"},
        {"Fundamental Katalog 5th Edition", "FK5 909"},
        {"Geneva Identification System", "GEN# +1.00051802"},
        {"Smithsonian Astrophysical Observation", "SAO 1168"},
        {"Wilson Evans Batten Catalogue", "WEB 7399"},
    },
    visualMagnitude: 5.05,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.12954787),
        dec: Angle.Degrees(+87.02015634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16335"},
        {"Hipparcos Number", "HIP 14285"},
        {"Smithsonian Astrophysical Observation", "SAO 449"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.03454378),
        dec: Angle.Degrees(+87.02605568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203836"},
        {"Hipparcos Number", "HIP 103435"},
        {"Fundamental Katalog 5th Edition", "FK5 5843"},
        {"Geneva Identification System", "GEN# +1.00203836"},
        {"Smithsonian Astrophysical Observation", "SAO 3515"},
        {"Wilson Evans Batten Catalogue", "WEB 18814"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.34239447),
        dec: Angle.Degrees(+87.03262539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115675"},
        {"Hipparcos Number", "HIP 63762"},
        {"Smithsonian Astrophysical Observation", "SAO 2150"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.03421827),
        dec: Angle.Degrees(+87.11499041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 181.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6319"},
        {"Hipparcos Number", "HIP 5928"},
        {"Geneva Identification System", "GEN# +1.00006319"},
        {"Smithsonian Astrophysical Observation", "SAO 193"},
        {"Wilson Evans Batten Catalogue", "WEB 1345"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.05251889),
        dec: Angle.Degrees(+87.14554531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135294"},
        {"Hipparcos Number", "HIP 71725"},
        {"Fundamental Katalog 5th Edition", "FK5 5303"},
        {"Geneva Identification System", "GEN# +1.00135294"},
        {"Smithsonian Astrophysical Observation", "SAO 2460"},
        {"Wilson Evans Batten Catalogue", "WEB 12356"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.07685446),
        dec: Angle.Degrees(+87.21471827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27724"},
        {"Smithsonian Astrophysical Observation", "SAO 875"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.06496504),
        dec: Angle.Degrees(+87.22079120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88044"},
        {"Hipparcos Number", "HIP 51515"},
        {"Fundamental Katalog 5th Edition", "FK5 4932"},
        {"Geneva Identification System", "GEN# +1.00088044"},
        {"Smithsonian Astrophysical Observation", "SAO 1682"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.82895611),
        dec: Angle.Degrees(+87.27095673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215743"},
        {"Hipparcos Number", "HIP 111244"},
        {"Geneva Identification System", "GEN# +1.00215743"},
        {"Smithsonian Astrophysical Observation", "SAO 3767"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.07407917),
        dec: Angle.Degrees(+87.28455761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181203"},
        {"Hipparcos Number", "HIP 91099"},
        {"Geneva Identification System", "GEN# +1.00181203"},
        {"Smithsonian Astrophysical Observation", "SAO 3131"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.73706000),
        dec: Angle.Degrees(+87.29199369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39164"},
        {"Hipparcos Number", "HIP 31721"},
        {"Smithsonian Astrophysical Observation", "SAO 987"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.53719080),
        dec: Angle.Degrees(+87.29669721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19372",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19372"},
        {"Smithsonian Astrophysical Observation", "SAO 608"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.24420873),
        dec: Angle.Degrees(+87.29764416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221525"},
        {"Hipparcos Number", "HIP 115746"},
        {"Fundamental Katalog 5th Edition", "FK5 3967"},
        {"Geneva Identification System", "GEN# +1.00221525"},
        {"Smithsonian Astrophysical Observation", "SAO 3916"},
        {"Wilson Evans Batten Catalogue", "WEB 20480"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.74966274),
        dec: Angle.Degrees(+87.30745696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5256"},
        {"Hipparcos Number", "HIP 5122"},
        {"Smithsonian Astrophysical Observation", "SAO 163"},
        {"Wilson Evans Batten Catalogue", "WEB 1051"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.40698549),
        dec: Angle.Degrees(+87.31879485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 310.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117053"},
        {"Smithsonian Astrophysical Observation", "SAO 3961"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.94873098),
        dec: Angle.Degrees(+87.35496206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166179"},
        {"Hipparcos Number", "HIP 84858"},
        {"Geneva Identification System", "GEN# +1.00166179"},
        {"Smithsonian Astrophysical Observation", "SAO 2914"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.15142399),
        dec: Angle.Degrees(+87.37537892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16191"},
        {"Smithsonian Astrophysical Observation", "SAO 510"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.14807322),
        dec: Angle.Degrees(+87.39470345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67951",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9114 AB"},
        {"Henry Draper", "HD 126047"},
        {"Hipparcos Number", "HIP 67951"},
        {"Smithsonian Astrophysical Observation", "SAO 2326"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.73941928),
        dec: Angle.Degrees(+87.39557828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12003"},
        {"Smithsonian Astrophysical Observation", "SAO 380"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.68060293),
        dec: Angle.Degrees(+87.42654405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145367"},
        {"Hipparcos Number", "HIP 75576"},
        {"Smithsonian Astrophysical Observation", "SAO 2595"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.58717677),
        dec: Angle.Degrees(+87.43540072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203317"},
        {"Hipparcos Number", "HIP 102646"},
        {"Smithsonian Astrophysical Observation", "SAO 3500"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.99726413),
        dec: Angle.Degrees(+87.53739706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43391"},
        {"Smithsonian Astrophysical Observation", "SAO 1348"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.58523726),
        dec: Angle.Degrees(+87.55564578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96870"},
        {"Hipparcos Number", "HIP 55483"},
        {"Smithsonian Astrophysical Observation", "SAO 1848"},
        {"Wilson Evans Batten Catalogue", "WEB 9978"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.44912439),
        dec: Angle.Degrees(+87.63845987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114282"},
        {"Hipparcos Number", "HIP 62945"},
        {"Fundamental Katalog 5th Edition", "FK5 5140"},
        {"Geneva Identification System", "GEN# +1.00114282"},
        {"Smithsonian Astrophysical Observation", "SAO 2125"},
        {"Wilson Evans Batten Catalogue", "WEB 11164"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.48427190),
        dec: Angle.Degrees(+87.64828980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57535"},
        {"Hipparcos Number", "HIP 40335"},
        {"Smithsonian Astrophysical Observation", "SAO 1252"},
        {"Wilson Evans Batten Catalogue", "WEB 7867"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.53647579),
        dec: Angle.Degrees(+87.69242518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107192"},
        {"Hipparcos Number", "HIP 59767"},
        {"Fundamental Katalog 5th Edition", "FK5 3958"},
        {"Geneva Identification System", "GEN# +1.00107192"},
        {"Smithsonian Astrophysical Observation", "SAO 2010"},
        {"Wilson Evans Batten Catalogue", "WEB 10622"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.83612872),
        dec: Angle.Degrees(+87.69998919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82763"},
        {"Fundamental Katalog 5th Edition", "FK5 5492"},
        {"Smithsonian Astrophysical Observation", "SAO 2845"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.72326732),
        dec: Angle.Degrees(+87.73427826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209556"},
        {"Hipparcos Number", "HIP 106641"},
        {"Smithsonian Astrophysical Observation", "SAO 3641"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.00722240),
        dec: Angle.Degrees(+87.78378287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3133"},
        {"Smithsonian Astrophysical Observation", "SAO 97"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.95592105),
        dec: Angle.Degrees(+87.79673412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181518"},
        {"Hipparcos Number", "HIP 90298"},
        {"Geneva Identification System", "GEN# +1.00181518"},
        {"Smithsonian Astrophysical Observation", "SAO 3120"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.37324771),
        dec: Angle.Degrees(+87.80912962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90162"},
        {"Hipparcos Number", "HIP 52908"},
        {"Smithsonian Astrophysical Observation", "SAO 1747"},
        {"Wilson Evans Batten Catalogue", "WEB 9630"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.30817376),
        dec: Angle.Degrees(+87.85894296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 513"},
        {"Fundamental Katalog 5th Edition", "FK5 4012"},
        {"Smithsonian Astrophysical Observation", "SAO 14"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.54746485),
        dec: Angle.Degrees(+87.88938595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8397"},
        {"Smithsonian Astrophysical Observation", "SAO 259"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.07999316),
        dec: Angle.Degrees(+87.89125408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17673"},
        {"Fundamental Katalog 5th Edition", "FK5 4345"},
        {"Smithsonian Astrophysical Observation", "SAO 553"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.78434422),
        dec: Angle.Degrees(+87.89684377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195252"},
        {"Hipparcos Number", "HIP 96821"},
        {"Fundamental Katalog 5th Edition", "FK5 5733"},
        {"Geneva Identification System", "GEN# +1.00195252"},
        {"Smithsonian Astrophysical Observation", "SAO 3327"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.19859127),
        dec: Angle.Degrees(+87.92233744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134437"},
        {"Hipparcos Number", "HIP 70360"},
        {"Smithsonian Astrophysical Observation", "SAO 2440"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.93666173),
        dec: Angle.Degrees(+87.97457522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51516"},
        {"Smithsonian Astrophysical Observation", "SAO 1673"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.82843929),
        dec: Angle.Degrees(+88.02335162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101444"},
        {"Smithsonian Astrophysical Observation", "SAO 3476"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.38523834),
        dec: Angle.Degrees(+88.06718250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213126"},
        {"Hipparcos Number", "HIP 108862"},
        {"Smithsonian Astrophysical Observation", "SAO 3714"},
        {"Wilson Evans Batten Catalogue", "WEB 19580"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.80485050),
        dec: Angle.Degrees(+88.07302911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64009"},
        {"Smithsonian Astrophysical Observation", "SAO 2176"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.74220849),
        dec: Angle.Degrees(+88.09090287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29457"},
        {"Smithsonian Astrophysical Observation", "SAO 890"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.10413012),
        dec: Angle.Degrees(+88.13174911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -231.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163988"},
        {"Hipparcos Number", "HIP 82281"},
        {"Geneva Identification System", "GEN# +1.00163988"},
        {"Smithsonian Astrophysical Observation", "SAO 2849"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.18043920),
        dec: Angle.Degrees(+88.15620561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26341"},
        {"Hipparcos Number", "HIP 24396"},
        {"Geneva Identification System", "GEN# +1.00026341"},
        {"Smithsonian Astrophysical Observation", "SAO 746"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.50395198),
        dec: Angle.Degrees(+88.22202521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91724"},
    },
    visualMagnitude: 9.87,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)42, 15.2300),
        dec: Angle.DegreesMinutesSeconds((int)+88, (int)17, 59.000)
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
    primaryId: "HIP 91720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91720"},
        {"Geneva Identification System", "GEN# +0.08700183"},
        {"Smithsonian Astrophysical Observation", "SAO 3184"},
        {"Wilson Evans Batten Catalogue", "WEB 15782"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.56338806),
        dec: Angle.Degrees(+88.30268146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44563"},
        {"Smithsonian Astrophysical Observation", "SAO 1361"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.20004153),
        dec: Angle.Degrees(+88.32233297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223257"},
        {"Hipparcos Number", "HIP 117008"},
        {"Geneva Identification System", "GEN# +1.00223257"},
        {"Smithsonian Astrophysical Observation", "SAO 3963"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.80010697),
        dec: Angle.Degrees(+88.34201833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 815"},
        {"Hipparcos Number", "HIP 1284"},
        {"Smithsonian Astrophysical Observation", "SAO 36"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.02181573),
        dec: Angle.Degrees(+88.40120934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37247"},
        {"Smithsonian Astrophysical Observation", "SAO 1110"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.75576693),
        dec: Angle.Degrees(+88.46384051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11696"},
        {"Hipparcos Number", "HIP 11980"},
        {"Geneva Identification System", "GEN# +1.00011696"},
        {"Smithsonian Astrophysical Observation", "SAO 362"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.63128300),
        dec: Angle.Degrees(+88.47114297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79176"},
        {"Smithsonian Astrophysical Observation", "SAO 2759"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.39474049),
        dec: Angle.Degrees(+88.51173994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47044"},
        {"Smithsonian Astrophysical Observation", "SAO 1449"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.81226957),
        dec: Angle.Degrees(+88.51278015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8395"},
        {"Hipparcos Number", "HIP 8846"},
        {"Geneva Identification System", "GEN# +1.00008395"},
        {"Smithsonian Astrophysical Observation", "SAO 258"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.44520044),
        dec: Angle.Degrees(+88.55166287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66368"},
        {"Hipparcos Number", "HIP 45919"},
        {"Fundamental Katalog 5th Edition", "FK5 3954"},
        {"Geneva Identification System", "GEN# +1.00066368J"},
        {"Smithsonian Astrophysical Observation", "SAO 1401"},
        {"Wilson Evans Batten Catalogue", "WEB 8710"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.45342894),
        dec: Angle.Degrees(+88.57030562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163545"},
        {"Hipparcos Number", "HIP 80223"},
        {"Geneva Identification System", "GEN# +1.00163545"},
        {"Smithsonian Astrophysical Observation", "SAO 2802"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.65417452),
        dec: Angle.Degrees(+88.60603030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36324"},
        {"Smithsonian Astrophysical Observation", "SAO 1059"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.16212696),
        dec: Angle.Degrees(+88.63717825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56124"},
        {"Smithsonian Astrophysical Observation", "SAO 1859"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.57914219),
        dec: Angle.Degrees(+88.74971621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187138"},
        {"Hipparcos Number", "HIP 88846"},
        {"Smithsonian Astrophysical Observation", "SAO 3143"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.05117499),
        dec: Angle.Degrees(+88.82277953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71030"},
        {"Smithsonian Astrophysical Observation", "SAO 2504"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.91034441),
        dec: Angle.Degrees(+88.85886251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63245"},
        {"Smithsonian Astrophysical Observation", "SAO 2173"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.39335519),
        dec: Angle.Degrees(+88.95758734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5914"},
        {"Hipparcos Number", "HIP 7283"},
        {"Fundamental Katalog 5th Edition", "FK5 4141"},
        {"Geneva Identification System", "GEN# +1.00005914"},
        {"Smithsonian Astrophysical Observation", "SAO 209"},
        {"Wilson Evans Batten Catalogue", "WEB 1564"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.45214999),
        dec: Angle.Degrees(+89.01571833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183030"},
        {"Hipparcos Number", "HIP 84535"},
        {"Fundamental Katalog 5th Edition", "FK5 914"},
        {"Geneva Identification System", "GEN# +1.00183030"},
        {"Smithsonian Astrophysical Observation", "SAO 3020"},
        {"Wilson Evans Batten Catalogue", "WEB 14273"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.23858572),
        dec: Angle.Degrees(+89.03771546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14369"},
        {"Hipparcos Number", "HIP 17195"},
        {"Geneva Identification System", "GEN# +1.00014369"},
        {"Smithsonian Astrophysical Observation", "SAO 460"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.23321118),
        dec: Angle.Degrees(+89.10495838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106556"},
        {"Smithsonian Astrophysical Observation", "SAO 3700"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.71192355),
        dec: Angle.Degrees(+89.22291660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11767",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Lodestar"},
        {"Common Name 2", "Polaris"},
        {"Common Name 3", "North Star"},
        {"Aitken", "ADS 1477 A"},
        {"Aitken 2", "ADS 1477 AP"},
        {"Henry Draper", "HD 8890"},
        {"Hipparcos Number", "HIP 11767"},
        {"Fundamental Katalog 5th Edition", "FK5 907"},
        {"Geneva Identification System", "GEN# +1.00008890A"},
        {"Smithsonian Astrophysical Observation", "SAO 308"},
        {"Wilson Evans Batten Catalogue", "WEB 2438"},
    },
    visualMagnitude: 1.97,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.94614689),
        dec: Angle.Degrees(+89.26413805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211455"},
        {"Hipparcos Number", "HIP 101884"},
        {"Fundamental Katalog 5th Edition", "FK5 5816"},
        {"Geneva Identification System", "GEN# +1.00211455"},
        {"Smithsonian Astrophysical Observation", "SAO 3602"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.69815611),
        dec: Angle.Degrees(+89.40653468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1687"},
        {"Hipparcos Number", "HIP 3128"},
        {"Geneva Identification System", "GEN# +1.00001687"},
        {"Smithsonian Astrophysical Observation", "SAO 75"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.93427094),
        dec: Angle.Degrees(+89.44429274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21070"},
        {"Hipparcos Number", "HIP 47953"},
        {"Geneva Identification System", "GEN# +1.00021070"},
        {"Smithsonian Astrophysical Observation", "SAO 1157"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.58251561),
        dec: Angle.Degrees(+89.56940851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
